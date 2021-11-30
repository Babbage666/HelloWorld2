using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_RAP_Project
{

 enum GenderEnum
    {
        M,
        F,
        X
    }
    class Employee
    {


        private string name; 
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
            }
        }

        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value != null)
                {
                    id = value;
                }
            }
        }


        public GenderEnum gender;
        public int Gender
        {
            get
            {
                return Gender;
            }
            set
            {
                if (value != null)
                {
                    Gender = value;
                }
            }
        }

        public override string ToString()
        {
            return name + " " + id + " " + gender;
        }


    }




class Boss
    {
        private List<Employee> staff;

        public Boss() {
            staff = Agency.Generate();
        }

        public void Display()
        {
            foreach (Employee currentEmployee in staff)
            {
                Console.WriteLine(currentEmployee.ToString());

            }
        }

        public Employee Use(int id) {
            foreach (Employee currentEmployee in staff)
            {
                if (currentEmployee.Id == id)
                {
                    return currentEmployee;
                }
            }

            return null;
        }

        public Employee Fire(int id)
        {
            foreach (Employee currentEmployee in staff)
            {
                if (currentEmployee.Id == id)
                {
                    staff.Remove(currentEmployee);
                    return currentEmployee;
                }
            }
            return null;
        }
    }



 abstract class Agency
    {
        public static List<Employee> Generate()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee { Name= "alex", Id = 1, gender = GenderEnum.M });
            employees.Add(new Employee { Name = "jane", Id = 2, gender = GenderEnum.F });
            employees.Add(new Employee { Name = "Celeste", Id = 3, gender = GenderEnum.X });
            employees.Add(new Employee { Name = "john", Id = 4, gender = GenderEnum.M });
            employees.Add(new Employee { Name = "Elizabeth", Id = 5, gender = GenderEnum.F });
            employees.Add(new Employee { Name = "Havoc", Id = 6, gender = GenderEnum.M });

            return employees;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Boss bigBoss = new Boss();
            Console.WriteLine("Reached bigBoss display line.");
            bigBoss.Display();
        }

        static List<Employee> FilterByGender(List<Employee> staff, GenderEnum gender)
        {
            List<Employee> newList = new List<Employee>();

            foreach (Employee currentEmployee in staff)
            {
                if (currentEmployee.gender == gender)
                {
                    newList.Add(currentEmployee);
                }
            }

            return newList;
        }
    }
}
