using System;
using System.Collections.Generic;

namespace JamesClark_CS303_Project_01_gui {
    class Department {

        public string DepartmentName { get; set; }
        public Queue<Executive> Executives = new Queue<Executive>();

        /// <summary>
        /// The default construct constructs a new Department object
        /// </summary>
        public Department() {

        }
        /// <summary>
        /// Construct a new Department including its name.
        /// </summary>
        /// <param name="departmentName"></param>
        public Department(string departmentName) {
            this.DepartmentName = departmentName;          
        }
        /// <summary>
        /// Returns an Executive from the specified index in the Queue
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Executive</returns>
        public Executive GetExecutive(int index) {
            Queue<Executive>.Enumerator enumerator = Executives.GetEnumerator();
            for (int i = 0; i < index + 1; i++) {
                enumerator.MoveNext();
            }
            return enumerator.Current;
        }
        /// <summary>
        /// Moves an Executive out of the current department, into a new department
        /// </summary>
        /// <param name="executive"></param>
        /// <param name="department"></param>
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
        /// Finds an Exeuctive by their ExecutiveID and removes them from the Queue.
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
        /// Removes and returns an Executive from position index in the Queue
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Executive</returns>
        public Executive Quit(int index) {
            for (int i = 0; i < index; i++) {
                Executives.Enqueue(Executives.Dequeue());
            }
            return Executives.Dequeue();
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
