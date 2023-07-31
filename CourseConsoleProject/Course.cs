using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseConsoleProject
{
    internal class Course
    {
        public string Name { get; set; }

        public Group[] Groups;


        public Course()
        {

            Groups = new Group[0];
        }

        public void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;

        }
        public void GetGroupByNo(string no)
        {
            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].No == no)
                {
                    Console.WriteLine($"{Groups[i].No} group is exist");
                }
                else
                {
                    Console.WriteLine("Doesn't exist");
                }
            }
        }

        public void GetGroupsByPointRange(double minPoint, double maxPoint)
        {
            string[] pointRange = new string[0];
            bool result = false;
            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].AvgPoint > minPoint && Groups[i].AvgPoint < maxPoint)
                {
                    Array.Resize(ref pointRange, pointRange.Length + 1);
                    pointRange[pointRange.Length - 1] = Groups[i].No;
                    result = true;

                }
            }
            if (result)
            {
                foreach (string item in pointRange)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("We don't have any group which suit this average");
            }
        }
    }
}
