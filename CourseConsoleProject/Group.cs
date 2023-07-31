using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseConsoleProject
{
    internal class Group
    {
        string _no;
        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if (CheckNo(value))
                {
                    _no = value;
                }

            }
        }
        public static bool CheckNo(string no)
        {
            bool result = false;

            if (no.Length == 4 && !char.IsDigit(no[0]) && char.IsUpper(no[0]))
            {
                result = true;
                for (int i = 1; i < no.Length; i++)
                {
                    if (!char.IsDigit(no[i]))
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }
        public double AvgPoint { get; set; }

        public Group(string no, double avgPoint)
        {
            AvgPoint = avgPoint;
            No = no;
        }
    }
}
