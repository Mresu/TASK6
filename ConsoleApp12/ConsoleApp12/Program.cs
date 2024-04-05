
namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("jom", 3,3);

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Show info");
            Console.WriteLine("2. Create new group");
            Console.WriteLine("3. Addstudent");
            Console.WriteLine("0. Quit");

            while (true)
            {
                Console.Write("Seçiminizi daxil edin: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Student student1=new Student();
                        student.ShowInfo();
                        break;
                    case "2":
                        Group group1= new Group();


                        Console.WriteLine("showinfo");
                        break;
                    case "3":

                        Console.WriteLine("");


                        break;
                    case "0":
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.WriteLine("Yanlış seçim!");
                        break;
                }
            }
        }
    }
}
        
    
