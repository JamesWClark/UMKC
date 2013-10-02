using System;
using System.Collections.Generic;

namespace JamesClark_CS303_Project_01_Queue {
    class Program {

        //an array of queues to keep track of executives
        static Department[] departments = new Department[3];
        static bool exit = false;

        static void Main(string[] args) {
            Init();
            while (!exit) {
                ShowUserOptions();
                int option = GetUserOption();
                ProcessUserOption(option);
            }
        }
        static void Join(Executive person, Department department) {

        }
        static void Quit(Executive person) {

        }
        static void Change(Executive person, Department department) {

        }
        static void Payroll() {

        }
        static void Exit() {
            exit = true;
        }
        static void Init() {
            Department zero = new Department("UMKC", Guid.NewGuid());
            departments[0] = zero;
            departments[0].Enqueue(new Executive("James", "Clark", Guid.NewGuid()));
            departments[0].Enqueue(new Executive("Hussam", "Hashem", Guid.NewGuid()));
            departments[0].Enqueue(new Executive("Mohammad", "Kuhail", Guid.NewGuid()));
            
            Department one = new Department("Students", Guid.NewGuid());
            departments[1] = one;
            departments[1].Enqueue(new Executive("Kim", "Heckman", Guid.NewGuid()));
            departments[1].Enqueue(new Executive("Rebecca", "Clark", Guid.NewGuid()));
            
            Department two = new Department("Workers", Guid.NewGuid());
            departments[2] = two;
            departments[2].Enqueue(new Executive("Patrick", "Connelly", Guid.NewGuid()));
            departments[2].Enqueue(new Executive("Justin", "Noonan", Guid.NewGuid()));
        }
        static void ListDepartments() {
            Console.Clear();
            for (int i = 0; i < departments.Length; i++) {
                Console.WriteLine("{0} - {1}", i, departments[i].DepartmentName);
            }
        }
        static void ShowUserOptions() {
            Console.Clear();
            Console.WriteLine("0 - join <person> <department>");
            Console.WriteLine("1 - quit <person> <department>");
            Console.WriteLine("2 - change <person> <department>");
            Console.WriteLine("3 - payroll");
            Console.WriteLine("4 - exit the application");
            Console.Write("\nWhat do you want to do? ");
        }
        static int GetUserOption() {
            int action;
            int.TryParse(Console.ReadLine(), out action);
            return action;
        }
        static void ProcessUserOption(int option) {
            switch (option) {
                case 0: //join
                    break;
                case 1: //quit
                    break;
                case 2: //change
                    ListDepartments();
                    Console.Write("\nIn which department is the person you want to change? ");
                    Department dept = departments[GetUserOption()];
                    //dept.ListExecutives();
                    Console.Write("\nWhich person are you changing? ");
                    Executive exec = dept.GetExecutive(GetUserOption());
                    Change(exec, dept);
                    break;
                case 3: //payroll
                    break;
                case 4: //exit
                    break;
            }
        }
    }
}
