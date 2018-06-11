
using System;
using System.Drawing;

namespace Prana.Tools
{
    public partial class Random : System.Random
    {
        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public Random()
            : base()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="seed">Seed value</param>
        public Random(int seed)
            : base(seed)
        {
        }

        #endregion

        #region Public Functions

        /// <summary>
        /// returns a random date/time for a specific date range.
        /// </summary>
        /// <param name="start">Start time</param>
        /// <param name="end">End time</param>
        /// <returns>A random date/time between the start and end times</returns>
        public DateTime NextDate(DateTime start, DateTime end)
        {
            if (start > end)
            {
                throw new ArgumentException("The start value must be earlier than the end value");
            }
            return start + new TimeSpan((long)(new TimeSpan(end.Ticks - start.Ticks).Ticks * NextDouble()));
        }

        /// <summary>
        /// Returns a random boolean value
        /// </summary>
        /// <returns>returns a boolean</returns>
        public bool NextBool()
        {
            if (Next(0, 2) == 1)
                return true;
            return false;
        }

        /// <summary>
        /// Gets a random enum value
        /// </summary>
        /// <typeparam name="T">The enum type</typeparam>
        /// <returns>A random value from an enum</returns>
        public T NextEnum<T>()
        {
            Array values = Enum.GetValues(typeof(T));
            int index = Next(0, values.Length);
            return (T)values.GetValue(index);
        }

        /// <summary>
        /// Randomly generates a new time span
        /// </summary>
        /// <param name="start">Start time span</param>
        /// <param name="end">End time span</param>
        /// <returns>A time span between the start and end</returns>
        public TimeSpan NextTimeSpan(TimeSpan start, TimeSpan end)
        {
            if (start > end)
            {
                throw new ArgumentException("The start value must be earlier than the end value");
            }
            return start + new TimeSpan((long)(new TimeSpan(end.Ticks - start.Ticks).Ticks * NextDouble()));
        }

        /// <summary>
        /// Returns a random color
        /// </summary>
        /// <returns>A random color between black and white</returns>
        public Color NextColor()
        {
            return NextColor(Color.Black, Color.White);
        }

        /// <summary>
        /// Returns a random color within a range
        /// </summary>
        /// <param name="minColor">The inclusive minimum color (minimum for A, R, G, and B values)</param>
        /// <param name="maxColor">The inclusive maximum color (max for A, R, G, and B values)</param>
        /// <returns>A random color between the min and max values</returns>
        public Color NextColor(Color minColor, Color maxColor)
        {
            return Color.FromArgb(Next(minColor.A, maxColor.A + 1),
                Next(minColor.R, maxColor.R + 1),
                Next(minColor.G, maxColor.G + 1),
                Next(minColor.B, maxColor.B + 1));
        }

        #endregion


    }
}
