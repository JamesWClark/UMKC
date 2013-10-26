using System;
using System.IO;

namespace HazlewoodClark_CS303_Project_02 {
    class Program {
        static void Main(string[] args) {
            try {
                using (StreamReader sr = new StreamReader("MorseCode.txt")) {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            } catch (Exception e) {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

    }
}
