using System;

namespace My_first_program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output of text to the user
            Console.WriteLine("Hello World!");

            //In-Class Exercise 1
            //Write a program that collects 3 numbers from users and outputs the largest of the 3 numbers.
            //The program should handle improper inputs gracefully.Paste the code in the text area.

            
            int n1 = 0, n2 = 0, n3 = 0;
            Console.WriteLine("Please enter 3 numbers :");
            string n11 = Console.ReadLine();
            String n22 = Console.ReadLine();
            String n33 = Console.ReadLine();
            try
            {
                n1 = Convert.ToInt32(n11);
                n2 = Convert.ToInt32(n22);
                n3 = Convert.ToInt32(n33);

            }
            catch (Exception e)
            {
                Console.WriteLine("Custom Message: You did not enter a valid number, Please enter valid numbers.");
                Console.WriteLine("System Defined Message" + e.Message);
            }

            int max_number = Math.Max(n3, Math.Max(n1, n2));
            Console.WriteLine("The max of the 3 numbers is:  " + max_number);
            Console.ReadLine();

            // End of In-Class Exercise 1

            //In-Class Exercise 2
            // Write a program that collects 10 numbers as inputs from the user as well as a number to find.
            // The program should add the numbers to a dictionary and return true if the number was among the 10 numbers input and
            // false otherwise.Paste the code in the text area.

            int[] arr = new int[10];
            int i=1; 
            Console.WriteLine("Enter 10 numbers:");

            for (i = 0; i < 10; i++)
            {
                
                Console.WriteLine("Enter Variable number " + (i+1));
                String temp = Console.ReadLine();
                try
                {
                   
                    arr[i] = Convert.ToInt32(temp);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception Message" + e.Message);
                }
                    
            }
            //Console.WriteLine("Elements in array are: ");
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("You entered " + arr[i]);
            //}

            Console.WriteLine("Enter the number to search: ");
            String temp1 = Console.ReadLine();
            int searched_num= Convert.ToInt32(temp1);
            int success_search = 0;
            for (i = 0; i < 10; i++)
            {
              if (arr[i]==searched_num)
                {
                    success_search = 1;
                    break;
                  
                }

            }
            if (success_search==1)
                Console.WriteLine("Number has been found. It was entered in postion #:" + (i + 1));
            else
                Console.WriteLine("Number was not found" );

            Console.ReadLine();

            //End of In-Class Exercise 2 -test


        }
    }
}