using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JamesClark_CS303_Project_01_gui {
    public partial class Form1 : Form {

        static Queue<Executive>[] departments = new Queue<Executive>[3];

        public Form1() {
            InitializeComponent();
        }
        private void Init() {
            Department zero = new Department("UMKC");
            zero.JoinExecutive(new Executive("Mohammad", "Kuhail", Guid.NewGuid()));
            zero.JoinExecutive(new Executive("Hussam", "Hashem", Guid.NewGuid()));
            zero.JoinExecutive(new Executive("James", "Clark", Guid.NewGuid()));
            departments[0] = zero.Executives;
            ListExecutives(departments[0].GetEnumerator(), lvDepartment1);

            Department one = new Department("Students");
            one.JoinExecutive(new Executive("Kim", "Heckman", Guid.NewGuid()));
            one.JoinExecutive(new Executive("Rebecca", "Clark", Guid.NewGuid()));
            departments[1] = one.Executives;
            ListExecutives(departments[1].GetEnumerator(), lvDepartment2);

            Department two = new Department("Workers");
            two.JoinExecutive(new Executive("Patrick", "Connelly", Guid.NewGuid()));
            two.JoinExecutive(new Executive("Justin", "Noonan", Guid.NewGuid()));
            departments[2] = two.Executives;
            ListExecutives(departments[2].GetEnumerator(), lvDepartment3);
            
        }
        private void ListExecutives(Queue<Executive>.Enumerator enumerator, ListView listView) {
            while (enumerator.MoveNext()) {
                listView.Items.Add(enumerator.Current.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            Init();
            
        }
        /*
        private void lvDepartments_SelectedIndexChanged(object sender, EventArgs e) {

            Department.Enumerator enumerator;
            try { //try,catch is necessary because the second click in a listview throws an index out of range
                enumerator = departments[lvDepartment3.SelectedIndices[0]].GetEnumerator();
                while (enumerator.MoveNext()) {
                    lvExecutives.Items.Add(enumerator.Current.ToString());
                }
            } catch {
            }

        }
         * */
    }
}
