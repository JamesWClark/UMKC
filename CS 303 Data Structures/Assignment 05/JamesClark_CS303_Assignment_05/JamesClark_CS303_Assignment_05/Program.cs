using System;

namespace JamesClark_CS303_Assignment_05 {
    class Program {

        static int indexPenny;
        static int indexNickel;
        static int indexDime;
        static int indexQuarter;

        static int cents;

        static void Main(string[] args) {

            while (!int.TryParse(GetCents(), out cents)) {
                Console.WriteLine("\nEnter the value in cents (integers only, no decimals).\n");
            }

            GiveCoins(string.Empty);
        }

        static string GetCents() {
            Console.Write("Enter a value in cents: ");
            return Console.ReadLine();
        }

        static void GiveCoins(string coins) {

        //do

            //fill with pennies
            FillCoins('P', ref coins);

            //swap a nickel
            SwapCoin('N', ref coins);

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
        static void FillCoins(char denomination, ref string coins) {
            switch (denomination) {
                case 'P':
                    int total = CalcTotal(coins);
                    coins = coins.Replace("P",string.Empty);
                    for (int i = 0; i < cents - total; i++) {
                        coins += "P";
                    }
                    break;
                case 'N':
                    break;
                case 'D':
                    break;
                case 'Q':
                    break;
            }
            Console.WriteLine(coins);
        }
        static void SwapCoin(char denomination, ref string coins) {
            switch (denomination) {
                case 'P':
                    break;
                case 'N':
                    int index = coins.IndexOf("PPPPP");
                    if (index != -1) {
                        coins = coins.Remove(index, 5);
                        coins = coins.Insert(index, "N");
                        Console.WriteLine(coins);
                        SwapCoin('N', ref coins);
                    } else {
                        SwapCoin('D', ref coins);
                    }
                    break;
                case 'D':
                    break;
                case 'Q':
                    break;
            }
            
        }
        static int CalcTotal(string coins) {
            int given = 0;
            foreach (char coin in coins) {
                switch (coin) {
                    case 'P':
                        given += 1;
                        break;
                    case 'N':
                        given += 5;
                        break;
                    case 'D':
                        given += 10;
                        break;
                    case 'Q':
                        given += 25;
                        break;
                    default:
                        break;
                }
            }
            return given;
        }
    }
}
