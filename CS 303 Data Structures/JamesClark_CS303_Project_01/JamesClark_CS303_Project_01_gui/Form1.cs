using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JamesClark_CS303_Project_01_gui {
    public partial class Form1 : Form {
        //requirement: an array of queues to keep track of executives as they are transferred between departments
        //each department contains one queue of executives
        private static Department[] departments = new Department[3];
        /// <summary>
        /// The Form constructor
        /// </summary>
        public Form1() {
            InitializeComponent();
        }
        /// <summary>
        /// The Init method loads the form with sample data.
        /// </summary>
        private void Init() {
            //instantiate new departments
            Department zero = new Department("UMKC", Guid.NewGuid());
            Department one = new Department("Students", Guid.NewGuid());
            Department two = new Department("Workers", Guid.NewGuid());
            //add executives to departments
            zero.Join(new Executive("Mohammad", "Kuhail", Guid.NewGuid()));
            zero.Join(new Executive("Hussam", "Hashem", Guid.NewGuid()));
            zero.Join(new Executive("James", "Clark", Guid.NewGuid()));
            one.Join(new Executive("Kim", "Heckman", Guid.NewGuid()));
            one.Join(new Executive("Rebecca", "Clark", Guid.NewGuid()));
            two.Join(new Executive("Patrick", "Connelly", Guid.NewGuid()));
            two.Join(new Executive("Justin", "Noonan", Guid.NewGuid()));
            //put the departments in an array, per program requirements
            departments[0] = zero;
            departments[1] = one;
            departments[2] = two;
            //list executives in listview containers
            ListExecutives(zero.Executives, lvDepartment1);
            ListExecutives(one.Executives, lvDepartment2);
            ListExecutives(two.Executives, lvDepartment3);
        }
        /// <summary>
        /// Display all executives in a queue, given a listview container.
        /// </summary>
        /// <param name="executives"></param>
        /// <param name="listView"></param>
        private void ListExecutives(Queue<Executive> executives, ListView listView) {
            //clear the list to prevent scrolling duplicates
            listView.Clear();
            //use enumeration to add items from the queue to the list
            Queue<Executive>.Enumerator enumerator = executives.GetEnumerator();
            while (enumerator.MoveNext()) {
                listView.Items.Add(enumerator.Current.ToString());
            }
        }
        /// <summary>
        /// Displays an error message when the user tries to quit and change an executive without first selecting them from a list view.
        /// </summary>
        /// <param name="listView"></param>
        private void ValidateItemSelected(ListView listView) {
            //clear the error, then check for a new one
            HideError();
            if (listView.SelectedIndices.Count == 0) {
                ShowError("Select an executive.");
            }
        }
        /// <summary>
        /// Show an error message in the red error box, given textual input for the message.
        /// </summary>
        /// <param name="error"></param>
        private void ShowError(string error) {
            txtError.Visible = true;
            txtError.Text = error;
        }
        /// <summary>
        /// Remove a current error message.
        /// </summary>
        private void HideError() {
            txtError.Visible = false;
            txtError.Text = String.Empty;
        }
        #region FORM EVENTS
        /// <summary>
        /// The Form_Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e) {
            Init();
        }
        /// <summary>
        /// Event fired by the Join Department button.
        /// </summary>
        /// <remarks>This joins an Executive to the department indicated by the selected radio button.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJoinDepartment_Click(object sender, EventArgs e) {
            //if text boxes don't have text, show error 
            if (txtFirstName.Text == String.Empty || txtLastName.Text == String.Empty) {
                ShowError("first & last name are required");
            }
            //else add executive to selected department
            else {
                //reaching this point means the text fields hold values
                HideError();
                //evaluate the selected radio button
                foreach (RadioButton rb in pnlRadioButtons.Controls) {
                    //one radio button will be selected
                    if (rb.Checked == true) {
                        //join new executive to department, related by radio button selected
                        //update list view
                        switch (rb.Name) {
                            case "rbDepartment1":
                                departments[0].Join(new Executive(txtFirstName.Text, txtLastName.Text, Guid.NewGuid()));
                                ListExecutives(departments[0].Executives, lvDepartment1);
                                break;
                            case "rbDepartment2":
                                departments[1].Join(new Executive(txtFirstName.Text, txtLastName.Text, Guid.NewGuid()));
                                ListExecutives(departments[1].Executives, lvDepartment2);
                                break;
                            case "rbDepartment3":
                                departments[2].Join(new Executive(txtFirstName.Text, txtLastName.Text, Guid.NewGuid()));
                                ListExecutives(departments[2].Executives, lvDepartment3);
                                break;
                        }
                        
                    }
                }
            }
        }
        /// <summary>
        /// This event fires when one of the Change buttons is clicked.
        /// </summary>
        /// <remarks>This changes an executive from one department to another.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e) {
            try {
                //this event is always sent by a Change button
                Button button = (Button)sender;
                //this event requires interaction between two ListViews
                ListView listFrom = null;
                ListView listTo = null;
                //this event requires two departments. recall departments are stored in an array
                int fromIndex = -1;
                int toIndex = -1;
                if (button != null) {
                    switch (button.Name) {
                        //the button clicked determines different outcomes
                        //the to and from departments, and the two and from listViews
                        case "btn1v2":
                            fromIndex = 0;
                            toIndex = 1;
                            listFrom = lvDepartment1;
                            listTo = lvDepartment2;
                            break;
                        case "btn2v1":
                            fromIndex = 1;
                            toIndex = 0;
                            listFrom = lvDepartment2;
                            listTo = lvDepartment1;
                            break;
                        case "btn2v3":
                            fromIndex = 1;
                            toIndex = 2;
                            listFrom = lvDepartment2;
                            listTo = lvDepartment3;
                            break;
                        case "btn3v2":
                            fromIndex = 2;
                            toIndex = 1;
                            listFrom = lvDepartment3;
                            listTo = lvDepartment2;
                            break;
                    }
                }
                //require an item to be selected in the from list view
                ValidateItemSelected(listFrom);
                //get the executive from the department based on the index in the listview
                Executive exec = departments[fromIndex].GetExecutive(listFrom.SelectedIndices[0]);
                //call the Department.Change method
                departments[fromIndex].Change(exec, departments[toIndex]);
                //update the list views
                ListExecutives(departments[fromIndex].Executives, listFrom);
                ListExecutives(departments[toIndex].Executives, listTo);
            } catch (ArgumentException) {
                //this catches an error that will throw if one of the list views does not have a selected item when a change button is clicked
                //the ValidateItemSelected method above will show a visual representation of this error
            }
        }
        /// <summary>
        /// This event calls Department.Quit(Executive)
        /// </summary>
        /// <remarks>This event fires when any of the Quit buttons is clicked.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e) {
            //this method is always triggered by a button click
            Button quitButton = (Button)sender;
            //assign to -1, avoid "use of an unassigned variable" compiler error
            //program logic avoids using the -1, but i catch the IndexOutOfRangeException anyway
            int index = -1;
            //depending on the button clicked, different ListView data is used
            ListView listView = null;
            //different buttons have different outcomes
            switch (quitButton.Name) {
                //set the index and ListView
                case "btn1Quit":
                    index = 0;
                    listView = lvDepartment1;
                    break;
                case "btn2Quit":
                    index = 1;
                    listView = lvDepartment2;
                    break;
                case "btn3Quit":
                    index = 2;
                    listView = lvDepartment3;
                    break;
            }
            try {
                //get the selected Executive from the related Queue
                Queue<Executive>.Enumerator enumerator = departments[index].Executives.GetEnumerator();
                for (int i = 0; i <= listView.SelectedIndices[0]; i++) {
                    enumerator.MoveNext();
                }
                Executive exec = enumerator.Current;
                //call Department.Quit to remove the executive from the queue
                departments[index].Quit(exec);
                //update the list view
                ListExecutives(departments[index].Executives, listView);
            } catch (IndexOutOfRangeException) {
                //this won't happen unless another developer changes the ID of one of the quit buttons
            } catch (ArgumentException) {
                //this happens when Quit is clicked but a ListView item is not selected.
                //the buttons are activated when a list view item is clicked.
                //it's possible to select a ListView item to activate the button, then click the ListView where no items exist to unselect a list item
                //in that case, the buttons stay activated
                //it's also possible to hold click on an item and drag the mouse to select it. this will not activate the buttons
                ValidateItemSelected(listView);
            }
        }
        /// <summary>
        /// Activates associated buttons when any of the list views is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvDepartment_Click(object sender, EventArgs e) {
            //hide pending errors. new errors will be checked when the following buttons are clicked
            HideError();
            //this event is always sent by a ListView
            ListView listView = (ListView)sender;
            if (sender != null) {
                //the selected ListView has different outcomes
                switch (listView.Name) {
                    //display and hide buttons related to actions of the selected list view
                    case "lvDepartment1":
                        btn1Quit.Enabled = true;
                        btn2Quit.Enabled = false;
                        btn3Quit.Enabled = false;
                        btn1v2.Enabled = true;
                        btn2v1.Enabled = false;
                        btn2v3.Enabled = false;
                        btn3v2.Enabled = false;
                        break;
                    case "lvDepartment2":
                        btn1Quit.Enabled = false;
                        btn2Quit.Enabled = true;
                        btn3Quit.Enabled = false;
                        btn1v2.Enabled = false;
                        btn2v1.Enabled = true;
                        btn2v3.Enabled = true;
                        btn3v2.Enabled = false;
                        break;
                    case "lvDepartment3":
                        btn1Quit.Enabled = false;
                        btn2Quit.Enabled = false;
                        btn3Quit.Enabled = true;
                        btn1v2.Enabled = false;
                        btn2v1.Enabled = false;
                        btn2v3.Enabled = false;
                        btn3v2.Enabled = true;
                        break;
                }
            }
        }
        #endregion
    }
}
