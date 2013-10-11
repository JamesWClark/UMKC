using System;

namespace JamesClark_CS303_Assignment_05 {
    class Program {

        static Decimal owed = 0;
        static Decimal given = 0;

        static void Main(string[] args) {
            Decimal amount;
            while (!Decimal.TryParse(GetMoney(), out amount)) {
                Console.WriteLine("\nInvalid amount. Try again.\n");
            }
            amount = Decimal.Round(amount, 2);
            owed = Decimal.Parse(amount.ToString().Substring(amount.ToString().Length - 3));

            //termination case = greatest quantity quarters that will fit
            //Console.WriteLine((int)(.76 / .25));

            GiveCoins(string.Empty);
        }

        //mod Q then D then N then P to determine greatest quantity of highest coin that will fit
        //example: .76 / .25 = 

        static string GetMoney() {
            Console.Write("Give me your money: ");
            return Console.ReadLine();
        }

        static void GiveCoins(string coins) {
            given = CalcTotal(coins);
            if (given < owed) {
                //give out pennies
                coins += 'P';
                GiveCoins(coins);
            } else if (given == owed) {
                Console.WriteLine(coins);
                coins.Replace("PPPPP", "N");
            }
            //turn pennies into nickels
            

            //turn nickels into dimes
            //turn dimes into quarters
        }
        static decimal CalcTotal(string coins) {
            given = 0;
            foreach (char coin in coins) {
                switch (coin) {
                    case 'P':
                        given += 0.01m;
                        break;
                    case 'N':
                        given += 0.05m;
                        break;
                    case 'D':
                        given += 0.1m;
                        break;
                    case 'Q':
                        given += 0.25m;
                        break;
                    default:
                        break;
                }
            }
            return given;
        }
    }
}
