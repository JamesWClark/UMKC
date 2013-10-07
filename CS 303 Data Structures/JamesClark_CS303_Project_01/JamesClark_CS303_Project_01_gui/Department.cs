using System;
using System.Collections.Generic;

namespace JamesClark_CS303_Project_01_gui {
    class Department {

        public Guid DepartmentID { get; set; }
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
        public Department(string departmentName, Guid departmentID) {
            this.DepartmentName = departmentName;
            this.DepartmentID = departmentID;
        }
        /// <summary>
        /// Adds a new Executive to the Queue.
        /// </summary>
        /// <remarks>Updates payroll.</remarks>
        /// <param name="executive"></param>
        public void Join(Executive executive) {
            //add new executive to end of queue
            Executives.Enqueue(executive);
            //update payroll
            Payroll();
        }
        /// <summary>
        /// Finds an Exeuctive by their ExecutiveID and removes them from the Queue.
        /// </summary>
        /// <remarks>Updates payroll.</remarks>
        /// <param name="executive"></param>
        public void Quit(Executive executive) {
            //number of elements in queue
            int count = Executives.Count;
            //evaluate every element in the queue
            for (int i = 0; i < count; i++) {
                //remove the first item in the queue
                Executive current = Executives.Dequeue();
                //if not a match, return the item to the end of the queue
                if (current.EmployeeID != executive.EmployeeID) {
                    Executives.Enqueue(current);
                }
                //if a match is found, the item will not be returned to the queue, thus removing it permanently
                //when the loop finishes, all elements will be in the original position except that which was removed
            }
            Payroll();
        }
        /// <summary>
        /// Moves an Executive out of the current department, into a new department
        /// </summary>
        /// <param name="executive"></param>
        /// <param name="department"></param>
        public void Change(Executive executive, Department department) {
            //remove executive from current department
            this.Quit(executive);
            //add exectuvie to target department
            department.Join(executive);
            //update payroll
            Payroll();
        }
        /// <summary>
        /// Updates payroll by iterating members of the Queue.
        /// </summary>
        /// <remarks>An Executive is paid $1000 for themself and every Executive lower in the Queue priority.</remarks>
        public void Payroll() {
            //number of elements in queue
            int count = Executives.Count;
            //enumerate every element
            Queue<Executive>.Enumerator enumerator = Executives.GetEnumerator();
            while (enumerator.MoveNext()) {
                //update salary
                enumerator.Current.Salary = 1000 * count--;
            }
        }
        /// <summary>
        /// Returns an Executive from the specified index in the Queue
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Executive</returns>
        public Executive GetExecutive(int index) {
            //enumerate to the specified index
            Queue<Executive>.Enumerator enumerator = Executives.GetEnumerator();
            for (int i = 0; i < index + 1; i++) {
                enumerator.MoveNext();
            }
            //return a reference to the executive at specified index
            return enumerator.Current;
        }
        public override string ToString() {
            return this.DepartmentName;
        }
    }
}
