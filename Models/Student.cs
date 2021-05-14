using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApp.Models

{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Student(int StudentID, string StudentName, int Age, string Address)
        {
            this.StudentID = StudentID;
            this.StudentName = StudentName;
            this.Age = Age;
            this.Address = Address;

        }

    }
   
}
