using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Dalegate_Real_Use_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 4
            /*lets make this method sttic so we can invoke this */
            #endregion

            List<Empolyee> empList = new List<Empolyee>();
            empList.Add(new Empolyee() { ID = 101, Name = "Mary", Salary = 5000, Experince = 5 });
            empList.Add(new Empolyee() { ID = 102, Name = "Atmar", Salary = 1000, Experince = 4 });
            empList.Add(new Empolyee() { ID = 103, Name = "Mursal", Salary = 500, Experince = 6 });
            empList.Add(new Empolyee() { ID = 104, Name = "Jazmin", Salary = 50500, Experince = 2 });
            //now to use that all i can do 
            Empolyee.PermoteEmpolyee(empList);
            #region 5
            // this not Dalegate we havent use dalegate and that is why this program is not flixable
            // tomorrow if they want to permote thier empolyee base on salary they have to change the logic which is bad
            // how is that possible with the help of dalegate in the next demo
            #endregion
        }
    }
    #region 1
    /*lets say i have class empolyee and this class has some properties */
    #endregion
    class Empolyee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experince { get; set; }

        #region 2
        /*now what i want is i want a method in this class called permote empolyees and what this method
         * should do it take list of empolyees and base on some logic it should print the name empolyee
         * who are eligibale for permotion lets make the method the method take a list of empolyee  now
         the list class is part of generic class lets add namespace for that
         and the loop through that list */
        #endregion
        public static void PermoteEmpolyee(List<Empolyee> empolyeeList)
        {
            foreach (Empolyee empolyee in empolyeeList)
            {
                #region 3
                //if empolyee has more than 5 years we want to permote the empolyee 
                //if that emplyee and his Experince grater than or equel 5 
                // this class we want to make it reusable anyone should be able to reuse and provite their own logic 
                // but if you look at this class it is not re useble because we have hard coded the logic how we want
                //how we want the empolyee lets say a cpomany want to sort you class base on salry can they
                //use without re arrange the no they cant you have to change the logic 
                //we want to have this permote empolyee but have to have flixabilty for people to plug in the
                // logic they want we will do in the next sission but lets finish this one lets say we want complate this
                // we create list of empolyee goto 4

                #endregion
                if (empolyee.Experince >= 5)
                {
                    Console.WriteLine(empolyee.Name + "permpted");
                }
            }

        }
    }

}

