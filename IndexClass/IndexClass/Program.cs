using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexClass
{
    class Student
    {
        public int idStudent { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public List<int> Marks { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"{idStudent} {Name} AvgMarks - {Marks.Average()} "; ///   ИСПРАВИТЬ!!!
        }

    }

    class Group
    {
        public int idGroup {get; set; }
        public string NomGroup { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();


        public Student this[int id]
        {
            get
            {
                return Students.FirstOrDefault(s => id == s.idStudent);
            }
            set
            {
                var st = Students.FirstOrDefault(s => id == s.idStudent);
                if (st != null)
                    st = value;
                else
                    Students.Add(value);
            }

        }

        //public Student this[string name]              TODO!!!
        //{
        //    get
        //    {
        //        return Students.FirstOrDefault(s => id == s.idStudent);
        //    }
        //    set
        //    {
        //        var st = Students.FirstOrDefault(s => id == s.idStudent);
        //        if (st != null)
        //            st = value;
        //        else
        //            Students.Add(value);
        //    }

        //}




        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Group - {NomGroup}");
            Students.ForEach(s => sb.AppendLine(s.ToString()));
            return sb.ToString();
        }



    }




    class Program
    {
        static void Main(string[] args)
        {
            Group gr = new Group() { idGroup = 1, NomGroup = "11-811" };
            gr[1] = new Student() { GroupId = 1, idStudent = 1, Name = "Ivanov" };
            gr[2] = new Student() { GroupId = 1, idStudent = 2, Name = "Petrov" };


            gr[1].Marks.Add(5);
            gr[1].Marks.Add(4);
            gr[1].Marks.Add(4);
            gr[2].Marks.Add(2);


            Console.WriteLine(gr);


        }
    }
}
