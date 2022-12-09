using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStudent.model
{
    public class Student
    {
        public Student (int id, string name, int age, string address) 
        {
            this._id = id;
            this._name = name;
            this._age = age;
            this._address = address;
        }
        int _id;
        public int Id { get { return _id; } }

        int _age;
        public int Age { get { return _age; } }

        string _name;
        public string Name { get { return _name; } }

        string _address;
        public string Address { get { return _address; } }
    }
}
