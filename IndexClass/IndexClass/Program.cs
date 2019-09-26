using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexClass
{
    public class Student
    {
        public int idStudent { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public List<int> Marks { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"{idStudent} {Name} {Marks.Average()}";  //Исправить
        }

    }


    public class Group
    {
        public int idGroup { get; set; }
        public string GroupNum { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public Student this[int id]
        {
            get
            {
                return Students.FirstOrDefault(s => s.idStudent == id);
            }
            set
            {
                var st = Students.FirstOrDefault(s => s.idStudent == id);
                if (st != null)
                    st = value;
                else 
                    Students.Add(value);
            }
        }
        //public Student this[string name]    
        //{
        //    get
        //    {
        //        return Students.FirstOrDefault(s => s.idStudent == id);
        //    }
        //    set
        //    {
        //        var st = Students.FirstOrDefault(s => s.idStudent == id);
        //        if (st != null)
        //            st = value;
        //        else
        //            Students.Add(value);
        //    }
        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Group - {GroupNum}");
            Students.ForEach(s => sb.AppendLine(s.ToString()));

            return sb.ToString();
        }



    }



    class Program
    {
        static void Main(string[] args)
        {
            Group gr = new Group() { idGroup = 1, GroupNum = "11-809" };

            gr[0] = new Student() { GroupId = 1, idStudent = 0, Name = "Ivanov" };
            gr[1] = new Student() { GroupId = 1, idStudent = 1, Name = "Petrov" };
            gr[2] = new Student() { GroupId = 1, idStudent = 2, Name = "Sidorov" };

            gr[0].Marks.Add(4);
            gr[0].Marks.Add(5);
            gr[1].Marks.Add(3);
            gr[1].Marks.Add(3);
            gr[2].Marks.Add(5);
            gr[2].Marks.Add(5);
            gr[3].Marks.Add(3);



            Console.WriteLine(gr);


        }
    }
}
