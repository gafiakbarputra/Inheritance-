using System;

namespace ConsoleApp1
{
    class Program
    {
        public class Person
        {
            public string name;
            public int age;
            public Person(string nama,int umur)
            {
                name = nama;
                age = umur;
            }
            public void GetNameAndAge()
            {
                Console.WriteLine("Orang ini memiliki nama {0} dan umur {1}", name, age);
            }
        }
        public class Teacher
        {
            public string name;
            public int age;
            public string nomor;
            public string matkul;
            public Teacher(string nama, int umur,string id,string matakuliah)
            {
                name = nama;
                age = umur;
                nomor = id;
                matkul = matakuliah;
            }
            public void GetNameAndAge()
            {
                Console.WriteLine("Orang ini memiliki nama {0}, umur {1},ID Card:{2},Mata Kuliah:{3} ", name, age,nomor,matkul);
            }
        }
        public class Student
        {
            public string name;
            public int age;
            public string nomor;
            public string email;
            public Student(string nama, int umur, string id, string emails)
            {
                name = nama;
                age = umur;
                nomor = id;
                email = emails;
            }
            public void GetNameAndAge()
            {
                Console.WriteLine("Orang ini memiliki nama {0}, umur {1},ID Card:{2},Email:{3} ", name, age, nomor, email);
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Mike", 20);
            person.GetNameAndAge();
            Teacher teacher = new Teacher("Thomas", 35, "190302", "Math");
            teacher.GetNameAndAge();
            Student student = new Student("Sara", 19, "10506", "sara1234@amikom.ac.id");
            student.GetNameAndAge();
        

        }
    }
}
