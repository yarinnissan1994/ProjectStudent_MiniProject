using ProjectStudent.DAL;
using ProjectStudent.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStudent.entities
{
    public class StudentsManager
    {
        public static void AddStudentsToHashTable(int id, string name, int age, string address)
        {
            Student newStudent = new Student(id, name, age, address);
            MainManager.Instance.StudentsTbl.Add(newStudent.Id, newStudent);
        }
        public static void AddStudentsToDB(string id, string name, string age, string address)
        {
            SqlQuery.RunNonQuery($"insert into StudentsList (ID, Name, Age, Address) values ('{id}', '{name}', '{age}', '{address}') ");
        }
        public static Student SearchStudentById(int id)
        {
            return (Student)MainManager.Instance.StudentsTbl[id];
        }
        public static void LoadStudentsList()
        {
            SqlQuery.RunCommand("select * from StudentsList", BringDBIntoHash);
        }
        public static void BringDBIntoHash(SqlDataReader reader)
        {
            MainManager.Instance.StudentsTbl.Clear();
            while (reader.Read())
            {
                Student newStudent = new Student(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
                MainManager.Instance.StudentsTbl.Add(newStudent.Id, newStudent);
            }
        }
    }
}
