namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassStudent classStudent = new ClassStudent();  
            string input = "";
            do
            {
                Console.WriteLine("Menumuza xos geldiniz");
                Console.WriteLine("1.Classrom yaratmaq");
                Console.WriteLine("2.Student yaratmaq");
                Console.WriteLine("0.Exit");
                Console.Write("Secim edin :  ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":classStudent.CreateClass(); 
                        break;
                        case "2":classStudent.StudentCreate();
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        break;
                }

            } while (input!="0");
        }
    }
}