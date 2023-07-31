using CourseConsoleProject;

Course course1 = new Course();
string no;
double avgPoint;
Group group;


Console.WriteLine("Menu");
Console.WriteLine("1. Qrup elave et");
Console.WriteLine("2. Bütün qruplara bax");
Console.WriteLine("3. Verilmiş point aralığındaki qruplara bax");
Console.WriteLine("4. Verilmiş nömreli qrupa bax");
Console.WriteLine("0. Menudan cıx");

while (true)
{
    Console.WriteLine("Seciminizi daxil edin");
    int.TryParse(Console.ReadLine(), out int choice);
    switch (choice)
    {
        case 1:
            bool validNo;
            do
            {
                Console.WriteLine("Enter Group No:");
                no = Console.ReadLine();
                validNo = Group.CheckNo(no);
                if (!validNo)
                {
                    Console.WriteLine("Invalid number. Try again.");
                }
            } while (!validNo);


            Console.WriteLine("Enter Average Point:");
            avgPoint = double.Parse(Console.ReadLine());
            group = new Group(no, avgPoint);
            course1.AddGroup(group);
            break;
        case 2:
            Console.WriteLine("Groups in course1:");
            foreach (Group g in course1.Groups)
            {
                Console.WriteLine($"Group No: {g.No}, Average Point: {g.AvgPoint}");
            }
            break;
        case 3:
            Console.WriteLine("Enter minimum point:");
            double minPoint = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter maximum point:");
            double maxPoint = double.Parse(Console.ReadLine());
            course1.GetGroupsByPointRange(minPoint, maxPoint);
            break;
        case 4:
            Console.WriteLine("Enter Group No:");
            no = Console.ReadLine();
            course1.GetGroupByNo(no);
            break;
        case 0:
            Console.WriteLine("Exiting menu...");
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}
