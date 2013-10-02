using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JamesClark_CS303_Project_01 {
    class Company {
        public Guid CompanyID { get; set; }
        public string Name { get; set; }
        public Queue<Department> departments { get; set; }
        

        public Company() {

        }
        public Company(string name, Guid id) {
            this.CompanyID = id;
            this.Name = name;
        }
    }
}
