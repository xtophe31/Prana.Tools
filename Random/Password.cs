namespace Prana.Tools
{
    public partial class Random
    {
        private const string ALPHA = "abcdefghijklmnopqrstuvwxyz";
        private const string NUMERIC = "0123456789";
        private const string SPECIAL = "&#$%*+-_!";

        public enum PasswordRange
        {
            ALPHA = 0x0,
            NUMERIC = 0x1,
            SPECIAL = 0x2,
            CASE_SENSITIVE = 0x3
        }

        public string NextPassword(int length, PasswordRange range)
        {
            var strRange = "";
            
            if ((range & PasswordRange.ALPHA) == PasswordRange.ALPHA)
            {
                strRange += ALPHA;
                if ((range & PasswordRange.CASE_SENSITIVE) == PasswordRange.CASE_SENSITIVE)
                    strRange += ALPHA.ToUpper();
            }

            if ((range & PasswordRange.NUMERIC) == PasswordRange.NUMERIC)
                strRange += NUMERIC;

            if ((range & PasswordRange.SPECIAL) == PasswordRange.SPECIAL)
                strRange += SPECIAL;

            char[] chars = strRange.ToCharArray();

            string password = string.Empty;

            for (int i = 0; i < length; i++)
                password += chars[Next(chars.Length)];
            return password;
        }


    }
}