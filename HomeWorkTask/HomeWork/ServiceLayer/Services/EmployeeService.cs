using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Employee[] GetEmployee(DateTime maxTime, DateTime minTime)
        {
            Employee[] employees = GetAll();
            Employee[] result = new Employee[employees.Length];
            int count = 0;


            foreach (var item in employees)
            {
                if (item.Birthday > maxTime && item.Birthday < minTime && item.Salary > 2000)
                {
                    result[count] = item;
                    count++;
                }
            }

            return result;
        }



        private Employee[] GetAll()
        {

            Employee employee1 = new Employee()
            {
                Name = "Shaiq",
                Surname = "Kazimov",
                Birthday = new DateTime(1990, 11, 26),
                Salary = 2800,
            };
            Employee employee2 = new Employee()
            {
                Name = "Cahangest",
                Surname = "Veliyev",
                Birthday = new DateTime(1996, 08, 12),
                Salary = 1400,
            };
            Employee employee3 = new Employee()
            {
                Name = "Ibrahim",
                Surname = "Aliyev",
                Birthday = new DateTime(1997, 04, 18),
                Salary = 1000,
            };
            Employee employee4 = new Employee()
            {
                Name = "Alakbar",
                Surname = "Hasanov",
                Birthday = new DateTime(2001, 05, 08),
                Salary = 4000,
            }; Employee employee5 = new Employee()
            {
                Name = "Cavid",
                Surname = "Beshirov",
                Birthday = new DateTime(1992, 04, 25),
                Salary = 16000,
            };

            Employee[] people = {employee1,employee2,employee3,employee4,employee5};

            return people;





        }
    }
    
}
