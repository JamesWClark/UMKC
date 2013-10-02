using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JamesClark_CS303_Project_01 {
    class Program {
        private const int ACTION_CREATE = 1;
        private const int ACTION_DELETE = 2;
        private const int ACTION_ADD = 3;
        private const int ACTION_REMOVE = 4;
        private const int ACTION_SELECT = 5;
        private const int ACTION_EXIT = 0;

        private const string CONTEXT_COMPANY = "company";
        private const string CONTEXT_DEPARTMENT = "department";
        private const string CONTEXT_EXECUTIVE = "executive";

        static Queue<Company> companies = new Queue<Company>();
        static Company currentCompany = null;
        static Department currentDepartment = null;
        static string context = CONTEXT_COMPANY;

        static void Main(string[] args) {
            int action = -1;

            while (action != ACTION_EXIT) {
                ShowContext();
                action = GetUserOption();
                Console.Clear();
                ProcessAction(action);
            }
        }
        static void ShowContext() {
            if (currentCompany != null) {
                Console.Write("Company: {0}", currentCompany.Name);
            }
            if (currentDepartment != null) {
                Console.Write(", Department: {0}", currentDepartment.DepartmentName);
            }
            //context.replace capitalizes the first letter, company = Company
            //Console.Write("Context: {0}", context.Replace(context[0],char.Parse(context[0].ToString().ToUpper())));
            Console.WriteLine("\n{0} - Create a {1}", ACTION_CREATE, context);
            Console.WriteLine("{0} - Delete a {1}", ACTION_DELETE, context);
            Console.WriteLine("{0} - Select a {1}", ACTION_SELECT, context);
            switch (context) {
                case CONTEXT_COMPANY:
                    //Console.WriteLine("{0} - Add a {1}", ACTION_ADD, CONTEXT_DEPARTMENT);
                    //Console.WriteLine("{0} - Remove a {1}", ACTION_REMOVE, CONTEXT_DEPARTMENT);
                    //Console.WriteLine("{0} - Select a {1}", ACTION_SELECT, CONTEXT_COMPANY);
                    break;
                case CONTEXT_DEPARTMENT:
                    //Console.WriteLine("{0} - Add an {1}", ACTION_ADD, CONTEXT_EXECUTIVE);
                    //Console.WriteLine("{0} - Remove an {1}", ACTION_REMOVE, CONTEXT_EXECUTIVE);
                    break;
                case CONTEXT_EXECUTIVE:
                    break;
            }
            Console.WriteLine("{0} - Exit the application\n", ACTION_EXIT);
        }
        static int GetUserOption() {
            int action;
            int.TryParse(Console.ReadLine(), out action);
            return action;
        }
        static void ProcessAction(int action) {
            switch (action) {
                case ACTION_CREATE:
                    Create();
                    break;
                case ACTION_DELETE:
                    Delete();
                    break;
                case ACTION_ADD:
                    Add();
                    break;
                case ACTION_REMOVE:
                    Remove();
                    break;
                case ACTION_SELECT:
                    Select();
                    break;
            }
        }
        static void Create() {
            string name = GetNewName();
            switch (context) {
                case CONTEXT_COMPANY:
                    companies.Enqueue(new Company(name, Guid.NewGuid()));
                    break;
                case CONTEXT_DEPARTMENT:
                    currentCompany.departments.Enqueue(new Department(GetNewName(), Guid.NewGuid()));
                    break;
            }
        }
        static void Delete() {
            List();
            int action = GetUserOption();
            switch (context) {
                case CONTEXT_COMPANY:
                    for (int i = 1; i < action; i++) {
                        companies.Enqueue(companies.Dequeue());
                    }
                    //this removes the selected item
                    companies.Dequeue();
                    for (int i = action-1; i < companies.Count; i++) {
                        companies.Enqueue(companies.Dequeue());
                    }
                    
                    break;
            }
        }
        static void Browse() {
            List();
            int action = GetUserOption();
            switch (context) {
                case CONTEXT_COMPANY:
                    currentCompany = companies.ElementAt<Company>(action);
                    List(currentCompany);
                    action = GetUserOption();
                    break;
                case CONTEXT_DEPARTMENT:
                    break;
                case CONTEXT_EXECUTIVE:
                    break;
            }
        }
        static void Add() {
            List();
            int action = GetUserOption();
            switch (context) {
                case CONTEXT_COMPANY:
                    currentCompany = companies.ElementAt<Company>(action);
                    currentCompany.departments.Enqueue(new Department(GetNewName(), Guid.NewGuid()));
                    break;
                case CONTEXT_DEPARTMENT:
                    break;
                case CONTEXT_EXECUTIVE:
                    break;
            }
        }
        static void Remove() {
            switch (context) {
                case CONTEXT_COMPANY:
                    break;
                case CONTEXT_DEPARTMENT:
                    break;
                case CONTEXT_EXECUTIVE:
                    break;
            }
        }
        static void Select() {
            List();
            int action = GetUserOption();
            switch (context) {
                case CONTEXT_COMPANY:
                    currentCompany = companies.ElementAt<Company>(action - 1);
                    context = CONTEXT_DEPARTMENT;
                    break;
                case CONTEXT_DEPARTMENT:
                    currentDepartment = currentCompany.departments.ElementAt<Department>(action - 1);
                    context = CONTEXT_EXECUTIVE;
                    break;
                case CONTEXT_EXECUTIVE:
                    break;
            }
        }
        static void List() {
            Console.Clear();
            switch (context) {
                case CONTEXT_COMPANY:
                    if (companies.Count == 0) {
                        Console.WriteLine("There are no companies to list.");
                    } else {
                        for (int i = 0; i < companies.Count; i++) {
                            Console.WriteLine("{0} - {1}", i+1, companies.ElementAt(i).Name);
                        }
                    }
                    break;
                case CONTEXT_DEPARTMENT:

                    break;
                case CONTEXT_EXECUTIVE:
                    break;
            }
        }
        static void List(Company company) {
            IEnumerator<Department> e = company.departments.GetEnumerator();
            int count = 1;
            while (e.MoveNext()) {
                Console.WriteLine("{0} - {1}", count++, e.Current.DepartmentName);
            }
        }
        static string GetNewName() {
            Console.Write("Enter the new {0}'s name: ", context);
            string name = Console.ReadLine();
            return name;
        }
    }
}
