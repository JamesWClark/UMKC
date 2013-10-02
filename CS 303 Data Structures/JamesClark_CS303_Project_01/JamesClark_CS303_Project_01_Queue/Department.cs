using System;
using System.Collections.Generic;

namespace JamesClark_CS303_Project_01_Queue {
    class Department : Queue<Executive> {
        public Guid DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public Department(string departmentName, Guid departmentID) {
            this.DepartmentName = departmentName;
            this.DepartmentID = departmentID;            
        }
        public Department() {
            
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
