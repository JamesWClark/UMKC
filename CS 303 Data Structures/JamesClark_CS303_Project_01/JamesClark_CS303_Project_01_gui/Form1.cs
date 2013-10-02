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
            zero.JoinExecutive(new Executive("Mohammad", "Kuhail", Guid.NewGuid()));
            zero.JoinExecutive(new Executive("Hussam", "Hashem", Guid.NewGuid()));
            zero.JoinExecutive(new Executive("James", "Clark", Guid.NewGuid()));
            departments[0] = zero;
            ListExecutives(zero.Executives.GetEnumerator(), lvDepartment1);

            Department one = new Department("Students");
            one.JoinExecutive(new Executive("Kim", "Heckman", Guid.NewGuid()));
            one.JoinExecutive(new Executive("Rebecca", "Clark", Guid.NewGuid()));
            departments[1] = one;
            ListExecutives(one.Executives.GetEnumerator(), lvDepartment2);

            Department two = new Department("Workers");
            two.JoinExecutive(new Executive("Patrick", "Connelly", Guid.NewGuid()));
            two.JoinExecutive(new Executive("Justin", "Noonan", Guid.NewGuid()));
            departments[2] = two;
            ListExecutives(two.Executives.GetEnumerator(), lvDepartment3);
        }
        private void ListExecutives(Queue<Executive>.Enumerator enumerator, ListView listView) {
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
                                departments[0].JoinExecutive(new Executive(txtFirstName.Text, txtLastName.Text, Guid.NewGuid()));
                                break;
                            case "rbDepartment2":
                                departments[1].JoinExecutive(new Executive(txtFirstName.Text, txtLastName.Text, Guid.NewGuid()));
                                break;
                            case "rbDepartment3":
                                departments[2].JoinExecutive(new Executive(txtFirstName.Text, txtLastName.Text, Guid.NewGuid()));
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
