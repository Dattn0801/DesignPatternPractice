using System;
using System.Collections.Generic;

namespace CompositePattern
{
    interface IEmployee
    {
        string Name { get; set; }
        string Dept { get; set; }  //Department
        string Designation { get; set; }
        void DisplayDetails ();
    }
    
    //leaf node
    class Empolyee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }  //Department
        public string Designation { get; set; }
        public void DisplayDetails()
        {
            Console.WriteLine("\t {0} work on department : {1}. Designation : {2}", Name, Dept, Designation);
        }
    }

    //none leaf
    class CompositeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Dept { get; set; }  //Department
        public string Designation { get; set; }
        private List<IEmployee> subordinateEmp = new List<IEmployee>();
        // add an Employee
        public void AddEmployee(IEmployee e)
        {
            subordinateEmp.Add(e);
        }
        // remove an employee
        public void RemoveEmployee(IEmployee e)
        {
            subordinateEmp.Remove(e);
        }
        public void DisplayDetails()
        {
            Console.WriteLine(" {0} work on department : {1}. Designation : {2}", Name, Dept, Designation);
            foreach(IEmployee e in subordinateEmp)
            {
                e.DisplayDetails();
            }
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("-------------This is demo composite pattern -----------");
            Empolyee Lecture1 = new Empolyee { Name = "Nguyen Van A", Dept = "math", Designation = "Lectures" };
            Empolyee Lecture2 = new Empolyee { Name = "Nguyen Van B", Dept = "math", Designation = "Lectures" };
            CompositeEmployee HeadOfMathDept = new CompositeEmployee { Name = "Le Van C", Dept = "math", Designation = "Dean" };


            // add 2 lecture
            HeadOfMathDept.AddEmployee(Lecture1);
            HeadOfMathDept.AddEmployee(Lecture2);

            Empolyee CSEE1 = new Empolyee { Name = "Nguyen Van C", Dept = "CSE", Designation = "Lectures" };
            Empolyee CSEE2 = new Empolyee { Name = "Nguyen Thi D", Dept = "CSE", Designation = "Lectures" };
            Empolyee CSEE3 = new Empolyee { Name = "Nguyen Van F", Dept = "CSE", Designation = "Lectures" };
            CompositeEmployee HeadOfCSEDept = new CompositeEmployee { Name = "Le Van G", Dept = "CSE", Designation = "Dean" };


            // add 3 lecture (3 lecture will report to  HOD)
            HeadOfCSEDept.AddEmployee(CSEE1);
            HeadOfCSEDept.AddEmployee(CSEE2);
            HeadOfCSEDept.AddEmployee(CSEE3);

            CompositeEmployee HeadMaster = new CompositeEmployee { Name = "dr S", Dept = "math", Designation = "Head Master" };
            HeadMaster.AddEmployee(HeadOfMathDept);
            HeadMaster.AddEmployee(HeadOfCSEDept);


            // Print 
            Console.WriteLine("information from the principal");
            HeadMaster.DisplayDetails();
            Console.WriteLine("-------------------------------------------------------------");

            //Print
            Console.WriteLine("information from the CSE");
            HeadOfCSEDept.DisplayDetails();
            Console.WriteLine("-------------------------------------------------------------");

            //Print
            Console.WriteLine("information from the MATH");
            HeadOfMathDept.DisplayDetails();
            Console.WriteLine("-------------------------------------------------------------");

            // lecuture2 in CSE DEPT leave
            Console.WriteLine("{0} in CSE DEPT leave school",CSEE2.Name);
            HeadOfCSEDept.RemoveEmployee(CSEE2);
            HeadOfCSEDept.DisplayDetails();
        }   
    }
}
