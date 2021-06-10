using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_objects2
{
    class Program
    {
        static void Main()
        {
            // using lambda
            //make list to store countries
            List<string> country = new List<string>();
            //add country
            country.Add("india");
            country.Add("australia");

            //using lambda to show list of countries
            //lambda is to set parameter from left to right .In right we perform operations
            IEnumerable<string> res = country.Select(x => x);

            //loop to access countries
            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //-------------------------------------
            //Min() - use to get min value from list
            int[] ar = { 1, 2, 3, 4, 5 };
            int m = ar.Min();
            Console.WriteLine(m);
            Console.ReadLine();

            /*output = 1*/
            //-----------------------------
            //max 
            int[] arr = { 1, 2, 3, 4, 5 };
            int ma = ar.Max();
            Console.WriteLine(ma);
            Console.ReadLine();
            /*output = 1*/
            //--------------------------------
            //sum
            int po = ar.Sum();
            Console.WriteLine(po);
            Console.ReadLine();
            /*output = 15*/

            //--------------------------------
            //count =to  count number of elements
            int Count = ar.Count();
            Console.WriteLine(Count);
            Console.ReadLine();
            /*output = 5*/

            //------------------------------------
            //Aggregate()- is used to perform operations on each item in list
            int[] n = { 1, 2, 3, 4 };
            int A = n.Aggregate((a, b) => a + b);
            Console.WriteLine("{0}", A);
            Console.ReadLine();

            //------------------------------------
            //partition operator
            //is used to partititon list into2 parts and return 1 part of list items 
            //operators used = TAKE,TAKEWHILE,SKIP,SKIPWHILE

            //TAKE=to return number of elements in sequence
            // TAKEWHILE=to return number of elements in sequence which satisfy condition
            //SKIP = to return number of elements in sequence  and return remaining elemnst
            //SKIPWHILE = to return number of elements in sequence which satisfy condition as true


            //TAKE
            //create array of countries 
            string[] countri = { "india", "japan", "australia", "germany" };


            //use take method, it will return value of string upto assigned numbers
            IEnumerable<string> result = countri.Take(3);

            //access them
            foreach(string co in result)
            {
                Console.WriteLine(co);

            }
            Console.ReadLine();
            /*output = india", "japan", "australia" */
            //------------------------------------------------------

            //Takewhile
            IEnumerable<string> resul = countri.TakeWhile(x=>x.StartsWith("i"));

            //access them
            foreach (string cos in resul)
            {
                Console.WriteLine(cos);

            }
            Console.ReadLine();
            /*output - india*/
            //------------------------------------
            //skip
            IEnumerable<string> resu = countri.Skip(3);

            //access them
            foreach (string co in resu)
            {
                Console.WriteLine(co);

            }
            Console.ReadLine();
            /*output =germany*/
            //------------------------------------

            //------------------------------------
            //orderby

            //syntax for descending order - var studentname = Objstudent.OrderByDescending(x => x.Name);  
            //make 1 lst of students

            //Student class made below with properties
            List<Student> ob = new List<Student>()
           {
               new Student(){ name = "payal", gender = "female"},
                 new Student(){ name = "sakshi", gender = "female"},
           };
           var sname = ob.OrderBy(x => x.name);
           foreach(var i in sname)
           {
               Console.WriteLine(i.name);   //getting names stored in temporary variable
           }
           Console.ReadLine();
           /*output = payal
            sakshi*/

            //------------------------------------
            //orderbyDescending


            //Student class made below with properties
            List<Student> obj = new List<Student>()
            {
                new Student(){ name = "payal", gender = "female"},
                  new Student(){ name = "sakshi", gender = "female"},
            };
            var snames = obj.OrderByDescending(x => x.name);
            foreach (var i in snames)
            {
                Console.WriteLine(i.name);   //getting names stored in temporary variable
            }
            Console.ReadLine();
            /*output =
           sakshi
            payal */


            //------------------------------------
            //ThenBy() = will sort in ascending order

            //Student class made below with properties
            List<Student> obt = new List<Student>()
            {
                new Student(){ name = "payal", gender = "female"},
                  new Student(){ name = "sakshi", gender = "female"},
            };
            var sgendername = obt.OrderBy(x=>x.name).ThenBy(x => x.gender);
            foreach (var i in sgendername)
            {
                Console.WriteLine("{0} and {1}",i.name, i.gender);   //getting names stored in temporary variable
            }
            Console.ReadLine();
            /*output = payal and female
                         sakshi and female*/
        }
    }
    
    class Student
    {
        public string name { get; set; }
        public string gender { get; set; }



    }
    
}
