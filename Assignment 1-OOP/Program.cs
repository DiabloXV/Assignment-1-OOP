namespace Assignment_1_OOP
{
    internal class Program
    {
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        [Flags]
        public enum Permissions
        {
            None = 0,
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }
        public enum Colors
        {
            Red,
            Green,
            Blue
        }
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            static void Main(string[] args)
            {
                #region Q1: Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

                //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
                //{
                //    Console.WriteLine(day);
                //}
                #endregion

                #region Q2: Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
                //Person[] people = new Person[3];
                //people[0] = new Person("Alice", 30);
                //people[1] = new Person("Bob", 25);
                //people[2] = new Person("Charlie", 35);

                //foreach (Person person in people)
                //{
                //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                //}
                #endregion

                #region Q3:Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
                //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
                //string input = Console.ReadLine();

                //if (Enum.TryParse(input, true, out Season season))
                //{
                //    string monthRange = season switch
                //    {
                //        Season.Spring => "Spring: March to May",
                //        Season.Summer => "Summer: June to August",
                //        Season.Autumn => "Autumn: September to November",
                //        Season.Winter => "Winter: December to February",
                //        _ => "Invalid season entered."
                //    };
                //    Console.WriteLine(monthRange);
                //}
                //else
                //{
                //    Console.WriteLine("Invalid season entered.");
                //}
                #endregion

                #region Q4: Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
                //Permissions userPermissions = Permissions.None;

                //// Add permissions
                //userPermissions |= Permissions.Read;
                //userPermissions |= Permissions.Write;

                //Console.WriteLine("Current permissions: " + userPermissions);

                //// Check if specific permission exists
                //if ((userPermissions & Permissions.Read) == Permissions.Read)
                //{
                //    Console.WriteLine("Read permission is set.");
                //}

                //if ((userPermissions & Permissions.Delete) == Permissions.Delete)
                //{
                //    Console.WriteLine("Delete permission is set.");
                //}
                //else
                //{
                //    Console.WriteLine("Delete permission is not set.");
                //}

                //// Remove a permission
                //userPermissions &= ~Permissions.Write;

                //Console.WriteLine("Current permissions after removing Write: " + userPermissions);

                //// Check again if the Write permission exists
                //if ((userPermissions & Permissions.Write) == Permissions.Write)
                //{
                //    Console.WriteLine("Write permission is set.");
                //}
                //else
                //{
                //    Console.WriteLine("Write permission is not set.");
                //}
                #endregion

                #region Q5:Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
                //Console.WriteLine("Enter a color (Red, Green, Blue):");
                //string input = Console.ReadLine();

                //if (Enum.TryParse(input, true, out Colors color))
                //{
                //    Console.WriteLine($"{input} is a primary color.");
                //}
                //else
                //{
                //    Console.WriteLine($"{input} is not a primary color.");
                //}
                #endregion

                #region Q6:Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
                //Console.WriteLine("Enter the coordinates of the first point (X Y):");
                //string[] input1 = Console.ReadLine().Split(' ');
                //double x1 = double.Parse(input1[0]);
                //double y1 = double.Parse(input1[1]);

                //Console.WriteLine("Enter the coordinates of the second point (X Y):");
                //string[] input2 = Console.ReadLine().Split(' ');
                //double x2 = double.Parse(input2[0]);
                //double y2 = double.Parse(input2[1]);

                //Point point1 = new Point(x1, y1);
                //Point point2 = new Point(x2, y2);

                //double distance = CalculateDistance(point1, point2);
                //Console.WriteLine($"The distance between the two points is: {distance}");
                #endregion

                #region Q7:Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
                //Person[] people = new Person[3];

                //for (int i = 0; i < 3; i++)
                //{
                //    Console.WriteLine($"Enter the name of person {i + 1}:");
                //    string name = Console.ReadLine();
                //    Console.WriteLine($"Enter the age of person {i + 1}:");
                //    int age = int.Parse(Console.ReadLine());
                //    people[i] = new Person(name, age);
                //}

                //Person oldest = FindOldestPerson(people);
                //Console.WriteLine($"The oldest person is {oldest.Name} with age {oldest.Age}");
                #endregion

            }
            /*                      FUNCTIONS USED                  */

            public static double CalculateDistance(Point p1, Point p2)
            {
                double deltaX = p2.X - p1.X;
                double deltaY = p2.Y - p1.Y;
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }

            public static Person FindOldestPerson(Person[] people)
            {
                Person oldest = people[0];
                foreach (Person person in people)
                {
                    if (person.Age > oldest.Age)
                    {
                        oldest = person;
                    }
                }
                return oldest;

            }

        }
}


