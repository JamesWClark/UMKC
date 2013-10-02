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

        static Department[] departments = new Department[3];

        public Form1() {
            InitializeComponent();
        }
        static void Init() {
            Department zero = new Department("UMKC", Guid.NewGuid());
            departments[0] = zero;
            departments[0].Enqueue(new Executive("James", "Clark", Guid.NewGuid()));
            departments[0].Enqueue(new Executive("Hussam", "Hashem", Guid.NewGuid()));
            departments[0].Enqueue(new Executive("Mohammad", "Kuhail", Guid.NewGuid()));

            Department one = new Department("Students", Guid.NewGuid());
            departments[1] = one;
            departments[1].Enqueue(new Executive("Kim", "Heckman", Guid.NewGuid()));
            departments[1].Enqueue(new Executive("Rebecca", "Clark", Guid.NewGuid()));

            Department two = new Department("Workers", Guid.NewGuid());
            departments[2] = two;
            departments[2].Enqueue(new Executive("Patrick", "Connelly", Guid.NewGuid()));
            departments[2].Enqueue(new Executive("Justin", "Noonan", Guid.NewGuid()));

            
        }

        private void Form1_Load(object sender, EventArgs e) {
            Init();
            for (int i = 0; i < departments.Length; i++) {
                lvDepartments.Items.Add(departments[i].ToString());
            }
        }

        private void lvDepartments_SelectedIndexChanged(object sender, EventArgs e) {

            lvExecutives.Items.Clear();
            Department.Enumerator enumerator;
            try { //try,catch is necessary because the second click in a listview throws an index out of range
                enumerator = departments[lvDepartments.SelectedIndices[0]].GetEnumerator();
                while (enumerator.MoveNext()) {
                    lvExecutives.Items.Add(enumerator.Current.ToString());
                }
            } catch {
            }

        }
    }
}
