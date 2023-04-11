using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ClassStudent
    {
        Classroom[] classrooms=new Classroom[0];
        public void CreateClass()
        {
            Console.WriteLine("Zehmet olmasa qrup adin daxil edin");
            string name=Console.ReadLine();
            Console.WriteLine("Class typeni secin ");
            Console.WriteLine("1.Back end");
            Console.WriteLine("2.Front end");
            int type=int.Parse(Console.ReadLine());
            Classroom classroom=new Classroom(name,type);
            AddClass(classroom);
            
        }
        public void AddClass(Classroom classroom)
        {
            Array.Resize(ref classrooms,classrooms.Length+1);
            classrooms[classrooms.Length-1]=classroom;
        }
        public void StudentCreate()
        {
            if (classrooms.Length != 0)
            {


                Console.WriteLine("Student adavizi daxil edin");
                string name = Console.ReadLine();
                Console.WriteLine("Soyadivizi daxil edin");
                string surname = Console.ReadLine();

                Student student = new Student(name, surname);


                Console.WriteLine("Zehmet olmasa girmek istediyiniz qrupu secin");

                foreach (Classroom classroom in classrooms)
                {
                    Console.WriteLine(classroom.Name + " ");
                }
                string classroomname = Console.ReadLine();

                foreach (Classroom classroom in classrooms)
                {
                    if (classroom.Name.ToLower() == classroomname.ToLower())
                    {
                        classroom.StudentAdd(student);
                    }

                }
            }
        }
    }
}
