//http://www.youtube.com/watch?v=3VBjhiKUtmE
//http://goo.gl/kLDrH

using System;

namespace JamesClark_CS303_Assignment_05 {
    class Program {

string[] labels = { "Q", "D", "N", "P" };

void Main(string[] args) {
    int[] coins = { 25, 10, 5, 1 };
    int[] quantity = new int[coins.Length];
    Console.WriteLine("Q = quarter, D = dime, N = nickel, P = penny");
    PrintCoins(coins, quantity, 0, 41);
}
void PrintCoins(int[] coins, int[] quantity, int index, int amount) {
    //print final results
    if (index >= coins.Length) {
        //for every coin, print the label
        for (int i = 0; i < coins.Length; i++)
            for (int j = 0; j < quantity[i]; j++)
                Console.Write(labels[i]);
        Console.WriteLine();
        return;
    }
    //reached the last coin
    if (index == coins.Length - 1) {
        //division should not have a remainder
        if (amount % coins[index] == 0) {
            quantity[index] = amount / coins[index];
            PrintCoins(coins, quantity, index + 1, 0);
        }
    }
    //not finished yet - still have coins to process
    else {
        //for as many times as the current coin will fit in the amount
        for (int i = 0; i <= amount / coins[index]; i++) {
            //increment a count for that coin
            quantity[index] = i;
            //print coins for the remaining amount of currency to process
            PrintCoins(coins, quantity, index + 1, amount - coins[index] * i);
        }
    }
        }
    }
}