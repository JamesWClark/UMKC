using System;
using System.Collections.Generic;

namespace JamesClark_CS303_Project_01 {
    class Department : Queue<Executive> {
        public Guid DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public Department() {

        }
        public Department(string departmentName, Guid departmentID) {
            this.DepartmentName = departmentName;
            this.DepartmentID = departmentID;
        }
    }
}
