using System;

namespace JamesClark_CS303_Project_01_gui {
    class Executive : Person {

        public Guid EmployeeID { get; set; }
        public float Salary { get; set; }

        /// <summary>
        /// The default constructor constructs a new Executive object.
        /// </summary>
        public Executive() {

        }
        /// <summary>
        /// Construct an Executive object given their name and ID.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="id"></param>
        public Executive(string firstName, string lastName, Guid id) {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmployeeID = id;
            //the Department will set the salary
        }
        /// <summary>
        /// Returns a string representation of the Executive, including their name and salary.
        /// </summary>
        /// <returns>FirstName, LastName, Salary</returns>
        public override string ToString() {
            return this.LastName + ", " + this.FirstName + ", $" + this.Salary;
        }
    }
}
