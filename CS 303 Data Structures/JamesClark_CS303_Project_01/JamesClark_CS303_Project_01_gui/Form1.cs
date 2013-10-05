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
        private void Init() {
            Department zero = new Department("UMKC");
            zero.Join(new Executive("Mohammad", "Kuhail", Guid.NewGuid()));
            zero.Join(new Executive("Hussam", "Hashem", Guid.NewGuid()));
            zero.Join(new Executive("James", "Clark", Guid.NewGuid()));
            departments[0] = zero;
            ListExecutives(zero.Executives.GetEnumerator(), lvDepartment1);

            Department one = new Department("Students");
            one.Join(new Executive("Kim", "Heckman", Guid.NewGuid()));
            one.Join(new Executive("Rebecca", "Clark", Guid.NewGuid()));
            departments[1] = one;
            ListExecutives(one.Executives.GetEnumerator(), lvDepartment2);

            Department two = new Department("Workers");
            two.Join(new Executive("Patrick", "Connelly", Guid.NewGuid()));
            two.Join(new Executive("Justin", "Noonan", Guid.NewGuid()));
            departments[2] = two;
            ListExecutives(two.Executives.GetEnumerator(), lvDepartment3);
        }
        private void ListExecutives(Queue<Executive>.Enumerator enumerator, ListView listView) {
            listView.Clear();
            while (enumerator.MoveNext()) {
                listView.Items.Add(enumerator.Current.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            Init();
            
        }

        private void lvDepartment1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnJoinDepartment_Click(object sender, EventArgs e) {
            //if text boxes don't have text, throw error 
            if (txtFirstName.Text == String.Empty || txtLastName.Text == String.Empty) {
                ShowError("first & last name are required");
            }
            //else add executive to selected department
            else {
                HideError();
                foreach (RadioButton rb in pnlRadioButtons.Controls) {
                    if (rb.Checked == true) {
                        switch (rb.Name) {
                            case "rbDepartment1":
                                departments[0].Join(new Executive(txtFirstName.Text, txtLastName.Text, Guid.NewGuid()));
                                ListExecutives(departments[0].Executives.GetEnumerator(), lvDepartment1);
                                break;
                            case "rbDepartment2":
                                departments[1].Join(new Executive(txtFirstName.Text, txtLastName.Text, Guid.NewGuid()));
                                ListExecutives(departments[1].Executives.GetEnumerator(), lvDepartment2);
                                break;
                            case "rbDepartment3":
                                departments[2].Join(new Executive(txtFirstName.Text, txtLastName.Text, Guid.NewGuid()));
                                ListExecutives(departments[2].Executives.GetEnumerator(), lvDepartment3);
                                break;
                        }
                        
                    } else {

                    }
                }
            }
        }
        private void ShowError(string error) {
            txtError.Visible = true;
            txtError.Text = error;
        }
        private void HideError() {
            txtError.Visible = false;
            txtError.Text = String.Empty;
        }

        private void btn1v2right_Click(object sender, EventArgs e) {
            HideError();
            if (lvDepartment1.SelectedIndices.Count == 0) {
                ShowError("Select an executive from department 1.");
            } else {
                
            }
        }
        private void Change(Executive executive, Department fromDepartment, Department toDepartment) {

        }

        private void btn1v2left_Click(object sender, EventArgs e) {

        }

        private void btn1v2quit_Click(object sender, EventArgs e) {
            Queue<Executive>.Enumerator enumerator = departments[0].Executives.GetEnumerator();
            for (int i = 0; i <= lvDepartment1.SelectedIndices[0]; i++) {
                enumerator.MoveNext();
            }
            Executive exec = enumerator.Current;
            departments[0].Quit(exec);
            ListExecutives(departments[0].Executives.GetEnumerator(), lvDepartment1);
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
