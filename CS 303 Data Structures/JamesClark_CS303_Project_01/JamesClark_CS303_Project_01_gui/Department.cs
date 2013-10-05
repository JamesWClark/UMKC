using System;
using System.Collections.Generic;

namespace JamesClark_CS303_Project_01_gui {
    class Department {

        public string DepartmentName { get; set; }
        public Queue<Executive> Executives = new Queue<Executive>();

        public Department(string departmentName) {
            this.DepartmentName = departmentName;          
        }
        public void Change(Executive executive, Department department) {
            this.Quit(executive);
            department.Join(executive);
            Payroll();
        }
        /// <summary>
        /// Adds a new Executive to the Queue.
        /// </summary>
        /// <remarks>Updates payroll.</remarks>
        /// <param name="executive"></param>
        public void Join(Executive executive) {
            Executives.Enqueue(executive);
            Payroll();
        }
        /// <summary>
        /// Finds and removes an Executive from the Queue.
        /// </summary>
        /// <remarks>Updates payroll.</remarks>
        /// <param name="executive"></param>
        public void Quit(Executive executive) {
            int count = Executives.Count;
            for (int i = 0; i < count; i++) {
                //remove the first item in the queue
                Executive current = Executives.Dequeue();
                //if not a match, return the item to the end of the queue
                if (current.EmployeeID != executive.EmployeeID) {
                    Executives.Enqueue(current);
                }
                //if a match is found, the item will not be returned to the queue, thus removing it permanently
            }
            Payroll();
        }
        /// <summary>
        /// Updates payroll by iterating members of the Queue.
        /// </summary>
        /// <remarks>An Executive is paid $1000 for themself and every Executive lower in the Queue priority.</remarks>
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
