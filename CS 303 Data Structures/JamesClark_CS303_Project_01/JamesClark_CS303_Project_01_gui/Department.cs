using System;
using System.Collections.Generic;

namespace JamesClark_CS303_Project_01_gui {
    class Department : Queue<Executive> {
        public Guid DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public Department(string departmentName, Guid departmentID) {
            this.DepartmentName = departmentName;
            this.DepartmentID = departmentID;            
        }
        public Department() {
            
        }
        public void ListExecutives() {
            Console.Clear();
            Enumerator e = this.GetEnumerator();
            int count = 0;
            while (e.MoveNext()) {
                Console.WriteLine("{0} - {1}", count++, e.Current.FirstName + " " + e.Current.LastName);
            }
        }
        public override string ToString() {
            return this.DepartmentName;
        }
        public Executive GetExecutive(int position) {
            Enumerator e = this.GetEnumerator();
            int count = 0;
            while (count++ < position + 1) {
                e.MoveNext();
            }
            return e.Current;
        }
    }
}
