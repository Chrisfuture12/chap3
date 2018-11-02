using System;

namespace  chap3
{
	class chap3
	{
        public static void Main(){
            DisplayTitle();
            double roomLen =  getInput("Length");
            double roomWid =  getInput("Width");
            double totalPrice1 = CalculateCosts(roomLen,roomWid, price);
            double totalPrice2 = CalculateCosts(roomLen,roomWid, price2);
            DisplayResults(totalPrice1);

        }

        public static double getInput(string x){
            string userInput;
            Console.WriteLine("\t Enter room " + x + ".");
            userInput = Console.ReadLine( );
            double somenum = double.Parse(inputValue);
            retrun somenum; // or  return double.Parse(inputValue);
        }

        public static void DisplayTitle(){
            Console.WriteLine("\t Carpet app")
        }

		public static double CalculateCosts(double length, double width, double price)
        {
            return length * width * price;
        }

        public static void DisplayResults(double price1, double price2)
        {
            Console.WriteLine("Berber:\t {0:c2}", price1);
            Console.WriteLine("Pile:\t {0:c2}", price2);
        }

    }
}

