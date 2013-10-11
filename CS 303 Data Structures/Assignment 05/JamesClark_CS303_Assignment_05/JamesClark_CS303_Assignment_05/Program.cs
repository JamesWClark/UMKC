using System;

namespace JamesClark_CS303_Assignment_05 {
    class Program {

        

        static void Main(string[] args) {

            int cents = 0;

            while (!int.TryParse(GetCents(), out cents)) {
                Console.WriteLine("\nEnter the value in cents (integers only, no decimals).\n");
            }

            string coins = string.Empty;
            for (int i = 0; i < cents; i++) {
                coins += 'P';
            }

            GiveCoins(coins);
        }

        static string GetCents() {
            Console.Write("Enter a value in cents: ");
            return Console.ReadLine();
        }

        static void GiveCoins(string coins) {

            Console.WriteLine(coins);
            
            //turn pennies into nickels
            if (coins.EndsWith("PPPPP")) {
                coins = coins.Remove(coins.Length - 5);
                coins = coins.Insert(0, "N");
                GiveCoins(coins);
            }
            //turn nickels into dimes
            else if (coins.Contains("NN")) {
                int index = coins.IndexOf("NN");
                coins = coins.Remove(index,2);
                coins = coins.Insert(index, "D");
                GiveCoins(coins);
            }
            //turn 2 dimes, 1 nickel into quarter
            else if (coins.Contains("DDN")) {
                int index = coins.IndexOf("DDN");
                coins = coins.Remove(index, 3);
                coins = coins.Insert(index, "Q");
                GiveCoins(coins);
            }
            //turn 1 quarter into pennies, 
        }

        //do

            //fill with pennies

            //swap a nickel

        //until full of nickels


        //do

            //swap a dime

            //fill with pennies

            //do

                //swap a nickel

                //fill with nickels
            
            //until full of nickels

        //until full of dimes


        //do

            //swap a quarter

            //fill with pennies

            //do

                //swap a nickel

                //fill with nickels
           
            //until full of nickels

            //do

                //swap a dime

                //fill with pennies

                //do

                    //swap a nickel

                    //fill with nickels

                //until full of nickels

            //until full of dimes
        
        //until full of quarters
    }
}
