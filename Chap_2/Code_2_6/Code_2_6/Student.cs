using System;
using System.Collections.Generic;
using System.Text;

namespace Code_2_6
{
    public class Student
    {
        private int id;
        private string name;
        private int age;

        public Student()
        {

        }

        public Student(int id)
        {
            this.id = id;
        }

        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        /*
        public Student(int studetId, string studetName, int studetAge)
        {
            id = studetId;
            name = studetName;
            age = studetAge;
        }
        */
    }
}
