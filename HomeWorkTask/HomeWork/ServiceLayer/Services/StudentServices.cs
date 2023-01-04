using DomainLayer.Models;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class StudentServices : IStudentServices
    {
        public Students[] GetStudentNamesSearch(string studName)
        {   
            Students[] students = All();
            Students[] result = new Students[students.Length];


            int count = 0;
            bool contains = false;
            foreach (var item in students)
            {
                if (item.Name.ToLower() == studName.ToLower() || item.Surname.ToLower() == studName.ToLower())
                {
                    result[count] = item;
                    count++;
                    contains = true;

                }

            }

            if (!contains)
            {
                Console.WriteLine(Errors.NameNotFound);
            }

            return result;
        }

        public Students[] GetStudentsAddress()
        {   
            Students[] students = All();
            Students[] result = new Students[students.Length];
            int count = 0;
            bool check = false;
            foreach (var item in students)
            {
                if (item.Address.Contains("Ehmedli"))
                {
                    result[count] = item;
                    count++;
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine(Errors.AddressNotFound);
            }
            return result;
        }

        public double GetStudentsAge()
        {
            Students[] students = All();

            double count = 0;
            foreach (Students item in students)
            {
                count += item.Age;

            }

            return count / students.Length;
        }

        public int GetStudentsByCount()
        {
            var people = All();

            int count = 0;
            foreach (var item in people)
            {
                count++;
            }
            return count;
        }

        public Students[] GetStudentsEmailAndName()
        {
            Students[] students = All();
            Students[] result = new Students[students.Length];

            int count = 0;
            bool check = false;
            foreach (var item in students)

            {
                if (item.Email.StartsWith("C"))
                {
                    result[count] = item;
                    count++;
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine(Errors.EmailNotFound);
            }
            return result;
        }

        public int GetStudentsNamesFiltered()
        {
            var students = All();
            int count = 0;
            foreach (var item in students)
            {
                if (item.Name == "Cavid")
                {
                    count++;

                }
            }
            return count;
        }


        private Students[] All()
        {


            Students stu1 = new Students()
            {
                Id = 1,
                Name = "Shaiq",
                Surname = "Kazimov",
                Email = "Shaiqak@code.edu.az",
                Age = 25,
                Education = "Second education",
                Address = "Sedmoy"
            };

            Students stu2 = new Students()
            {
                Id = 1,
                Name = "Alakbar",
                Surname = "Hasanov",
                Email = "Alakbar@code.edu.az",
                Age = 21,
                Education = "First education",
                Address = "Bayil"
            };

            Students stu3 = new Students()
            {
                Id = 2,
                Name = "Cavid",
                Surname = "Bashirov",
                Email = "CavidBashirov@code.edu.az",
                Age = 29,
                Education = "First education",
                Address = "Ehmedli"
            };

            Students stu4 = new Students()
            {
                Id = 3,
                Name = "Mubariz",
                Surname = "Agayev",
                Email = "Mubarizaa@code.edu.az",
                Age = 19,
                Education = "Second education",
                Address = "Nerimanov"
            };

            Students[] people = { stu1, stu2, stu3, stu4 };

            return people;

        }
    }
}

