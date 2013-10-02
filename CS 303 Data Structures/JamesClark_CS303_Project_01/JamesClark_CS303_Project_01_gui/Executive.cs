using System;
using System.Collections.Generic;

namespace JamesClark_CS303_Project_01_gui {
    class Executive {

        public Guid EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Salary { get; set; }

        public Executive() {

        }
        public Executive(string firstName, string lastName, Guid id) {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmployeeID = id;
        }
        public override string ToString() {
            return this.LastName + ", " + this.FirstName + ", $" + this.Salary;
        }
    }
}
