using System;
using System.Collections.Generic;

namespace JamesClark_CS303_Project_01_gui {
    class Department {

        public string DepartmentName { get; set; }
        public Queue<Executive> Executives = new Queue<Executive>();

        public Department(string departmentName) {
            this.DepartmentName = departmentName;          
        }

        public void Join(Executive executive) {
            Executives.Enqueue(executive);
            Payroll();
        }
        public void Quit(Executive executive) {
            for (int i = 0; i < Executives.Count; i++) {
                Executive current = Executives.Dequeue();
                if (current != executive) {
                    
                }
            }
            Payroll();
        }
        public void Payroll() {
            int count = Executives.Count;
            Queue<Executive>.Enumerator enumerator = Executives.GetEnumerator();
            while (enumerator.MoveNext()) {
                enumerator.Current.Salary = 1000 * count--;
            }
        }
        public override string ToString() {
            return this.DepartmentName;
        }
    }
}
