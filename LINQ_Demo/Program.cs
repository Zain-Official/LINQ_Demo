using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace LINQ_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employe> employeList = new List<Employe>()
           {
               new Employe{Empno=1,Name="Meraj",Age=14,Country="Pakistan",Gender="male",Salary=1200},
               new Employe{Empno=2,Name="Molai",Age=24,Country="India",Gender="male",Salary=100},
               new Employe{Empno=3,Name="Maroof",Age=44,Country="China",Gender="male",Salary=12000},
               new Employe{Empno=4,Name="Haseeb",Age=44,Country="China",Gender="male",Salary=2000},
               new Employe{Empno=5,Name="Bushra",Age=44,Country="China",Gender="female",Salary=1000},
           };

            var result1 = from em1 in employeList select em1;

            Console.WriteLine("Result Is ");

            foreach(var v  in result1)
            {
                Console.WriteLine("Employe No : "+v.Empno+"\nEmploye Name : "+v.Name+"\nEmploye Age : "+v.Age+"\nEmploye Country : "+v.Country+"\nEmploye Gender : "+v.Gender+"\nEmploye Salary : "+v.Salary);
                Console.WriteLine("*********************************");
            }

            var result2 = from em2 in employeList
                          select new
                          {
                              em2.Empno,
                              em2.Name,
                              em2.Country
                          };
            foreach(var v in result2)
            {
                Console.WriteLine("Employe No : "+v.Empno+"\nEmploye Name : "+v.Name+"\nEmploye Country : "+v.Country);

                Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            }
                    
            var result3 =  from em3 in employeList where em3.Country.Equals("China") select em3;
            Console.WriteLine("China Records");
            foreach(var v in result3)
            {
                Console.WriteLine("Employe No : " + v.Empno + "\nEmploye Name : " + v.Name + "\nEmploye Age : " + v.Age + "\nEmploye Country : " + v.Country + "\nEmploye Gender : " + v.Gender + "\nEmploye Salary : " + v.Salary);
                Console.WriteLine("///////////////////////////////////////////");
            }

            var result4 = from em in employeList orderby em.Salary select em;
            Console.WriteLine("Sorted Records......");
            foreach(var v in result4)
            {
                Console.WriteLine("Employe No : " + v.Empno + "\nEmploye Name : " + v.Name + "\nEmploye Age : " + v.Age + "\nEmploye Country : " + v.Country + "\nEmploye Gender : " + v.Gender + "\nEmploye Salary : " + v.Salary);
                Console.WriteLine("*********$$$$$$$$$$$$$$$$********************");
            }
            
        }
    }
}
