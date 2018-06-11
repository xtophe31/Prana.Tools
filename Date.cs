using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prana.Tools
{
    /// <summary>
    ///
    /// </summary>
    /// <author>Christophe GILBERT</author>
    /// <creationDate>31.10.2010</creationDate>
    public class Date
    {
        public static int MonthDiff(DateTime date1, DateTime date2)
        {
            return Math.Abs(((date2.Year * 12) + date2.Month) - ((date1.Year * 12) + date1.Month));
        }
    }
}
