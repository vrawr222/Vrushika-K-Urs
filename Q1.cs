using System;

public class Class1
{
	public Class1()
	{



            int[] ar = new int[100];


            int lenght, count;
            count = 0;
            Console.WriteLine("Enter array length");

            lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter array elements: ");
            for (int i = 0; i <= lenght; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());

            }
            int k = ar[0];
            for (int i = 1; i < lenght; i++)
            {
                if (ar[i] == k)
                    count++;


            }
            if (count > 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.Write("false");
            }
        }
    }








}
}
