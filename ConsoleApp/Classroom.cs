using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Classroom
    {
        private static int _id;
        private static int _studentCount;
        public int StudentCount { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        Student[] Students;
        public CLassroomType Type { get; set; }
        public Classroom(string name,int type)
        {
            _id++;
            Id = _id;
            switch (type)
            {
                case (int)CLassroomType.Backend:Type = CLassroomType.Backend; break;
                case (int)CLassroomType.Frontend:Type = CLassroomType.Frontend; break;
            }
            Name = name;
            if(type==1)
            {
                Students = new Student[3];
            }
            else if(type==2)
            {
                Students=new Student[2];
            }
        }
        public void StudentAdd(Student student)
        {
            Students[StudentCount] = student;
            _studentCount++;
            StudentCount = _studentCount;
        }

    }

    enum CLassroomType
    {
        Backend=1,
        Frontend
    }
}
