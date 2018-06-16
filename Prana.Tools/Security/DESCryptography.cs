using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

using NLog;

namespace Prana.Tools.Security
{
    class DESCryptography
    {
        //  pour les logs
        private static Logger logger = LogManager.GetCurrentClassLogger();

        // change me...
        private static string m_encryptionKey = "01234567";

        public static byte[] Encrypt(byte[] plainData, string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            byte[] encryptedData = desencrypt.TransformFinalBlock(plainData, 0, plainData.Length);
            return encryptedData;
        }

        public static byte[] Decrypt(byte[] encryptedData, string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desDecrypt = DES.CreateDecryptor();
            byte[] decryptedData = desDecrypt.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            return decryptedData;
        }

        public static void SaveObjectToFile(object obj, string path)
        {
            try
            {
                MemoryStream memStream = new MemoryStream();
                BinaryFormatter binFormatter = new BinaryFormatter();
                binFormatter.Serialize(memStream, obj);
                byte[] encryptedBytes = Encrypt(memStream.ToArray(), m_encryptionKey);
                memStream.Close();
                Stream streamToFile = File.Open(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                streamToFile.Write(encryptedBytes, 0, encryptedBytes.Length);
                streamToFile.Flush();
                streamToFile.Close();
            }
            catch (Exception e)
            {
                logger.Error("Erreur : {e.Message}");
            }
        }

        public static object LoadObjectFromFile(string path)
        {
            try
            {

                Stream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                byte[] encryptedObj = new byte[fileStream.Length];
                fileStream.Read(encryptedObj, 0, (int)encryptedObj.Length);
                MemoryStream memStream = new MemoryStream(Decrypt(encryptedObj, m_encryptionKey));
                BinaryFormatter binFormatter = new BinaryFormatter();
                object decryptedObj = binFormatter.Deserialize(memStream);
                memStream.Close();
                fileStream.Close();
                return decryptedObj;
            }
            catch (Exception e)
            {
                logger.Error("Erreur : {e.Message}");
            }
            return null;
        }
    }
}
