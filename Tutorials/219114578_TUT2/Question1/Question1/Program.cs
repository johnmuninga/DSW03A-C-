using System;


namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("WELCOME TO UJ HOTEL");
            Console.WriteLine("=======================");
            //prompt user to enter the code  rooms
            int Price;
            Console.WriteLine("Enter code room [1] for queen, [2]for king and [3] for king and a pull-out couch:");
            int codeRoom = int.Parse(Console.ReadLine());
           
            //condition of code and prices
            if (codeRoom== 1) {
                Price= 450;
                Console.WriteLine("Thank you for choosing Queen and the price is " +"R"+ Price );
            }
            else if (codeRoom== 2)
            {
                Price = 690;
                Console.WriteLine("Thank you for choosing King and the price is " + "R" + Price);
            }
            else if(codeRoom== 3)
            {
                Price = 800;
                Console.WriteLine("Thank you for choosing king and a pull-out couch and the price is " + "R" + Price);
            }
            else
            {
                Price = 0;
                Console.WriteLine("Invalid Code Can you please try again!!");
                Console.WriteLine("Price is R" + Price);
                
            }
        }
    }
}
