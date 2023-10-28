using System;

public class Employee
{
	public Employee()
	{
		string empname, city;
		double basicsal, DA, HRA;

		void getdata()

        {
            Console.WriteLine("enter employee name");

            empname = Console.ReadLine();
            Console.WriteLine("enter city");
            city = Console.ReadLine();
            Console.WriteLine("enter basic salary");
            basicsal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter dearness allowance   ");
            DA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter house rent ");
            HRA = Convert.ToInt32(Console.ReadLine());



        }

         double calculate()
        {
            total = basicsal + basicsal * DA / 100 + basicsal * HRA / 100;
        } return total();
;
        void display()
        {
            Console.WriteLine("EMPLOYEE NAME - " + empname "\n" "BASIC SALARY - " + basicsal "\n" "DA - " + DA "\n" "HRA - " + HRA);
              
        }

    }
}
