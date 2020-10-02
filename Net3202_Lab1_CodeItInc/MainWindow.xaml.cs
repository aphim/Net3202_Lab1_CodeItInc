//Project Name: Net3202_Lab1_CodeItInc
//Author: Jacky Yuan
//Date: Oct 2, 2020
//Description: Makes a program that generates projects.
//Change log: N / A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Net3202_Lab1_CodeItInc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Generate a list for storing the projects generated
        static List<Project> list = new List<Project>();

        /// <summary>
        /// Event for when the create project button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
            //temp variable for the user inputs
            string inputtedProjectName;
            double inputtedProjectSpent;
            double inputtedProjectBudget;
            double inputtedHoursRemaining;
            string inputtedProjectStatus;

            //checks if the project name field is empty
            if (txtProjectName.Text.Trim() != string.Empty)
            {
                inputtedProjectName = txtProjectName.Text.Trim();

                //checks if the budget field is empty or non numeric
                if (Double.TryParse(txtBudget.Text.Trim(), out inputtedProjectBudget))
                {
                    //checks if budget field is in bounds
                    if (inputtedProjectBudget >= 0)
                    {
                        //checks if the amount spent is empty or non numeric
                        if (Double.TryParse(txtSpent.Text.Trim(), out inputtedProjectSpent))
                        {
                            //checks if the amount spent is in bounds
                            if (inputtedProjectSpent >= 0)
                            {
                                //checks if the estimated time remaining is empty or non numeric
                                if (Double.TryParse(txtEstHoursRemaining.Text.Trim(), out inputtedHoursRemaining))
                                {
                                    //checks if estimated time remaining is in bounds
                                    if (inputtedHoursRemaining >= 0)
                                    {
                                        inputtedProjectStatus = cmbStatus.Text;
                                        //checks if estimated time remaining is equal to zero
                                        if (inputtedHoursRemaining == 0)
                                        {
                                            //changes status to completed
                                            cmbStatus.SelectedIndex = 5;
                                            inputtedProjectStatus = cmbStatus.Text;
                                        }
                                        //checks if the status selected is equal to completed
                                        if (cmbStatus.SelectedIndex == 5)
                                        {
                                            //changes estimated time to 0
                                            txtEstHoursRemaining.Text = "0";
                                            inputtedHoursRemaining = 0;
                                        }
                                        //adds the new project object into the list
                                        list.Add(new Project(inputtedProjectName, inputtedProjectBudget, inputtedProjectSpent,
                                        inputtedHoursRemaining, inputtedProjectStatus));
                                        
                                        //clears the list diaplay
                                        lsbOutputDisplay.Items.Clear();
                                        
                                        //loops through the list and outputs the objects created
                                        for (int i = 0; i < list.Count; i++)
                                        {
                                            lsbOutputDisplay.Items.Add(list[i].ProjectName);
                                        }

                                    }
                                    //error for hour input out of bounds
                                    else
                                    {
                                        txtEstHoursRemaining.Focus();
                                        txtEstHoursRemaining.SelectAll();
                                        MessageBox.Show("Error: Cannot have negative hours remaining.");
                                    }
                                }
                                //error for non numeric hour input
                                else
                                {
                                    txtEstHoursRemaining.Focus();
                                    txtEstHoursRemaining.SelectAll();
                                    MessageBox.Show("Error: Estimated time must be a numeric input.");
                                }
                            }
                            //error for input amount spent out of bounds
                            else
                            {
                                txtSpent.Focus();
                                txtSpent.SelectAll();
                                MessageBox.Show("Error: Cannot amount spent cannot be negative value.");
                            }
                        }
                        //error for non numeric input amount spent
                        else
                        {
                            txtSpent.Focus();
                            txtSpent.SelectAll();
                            MessageBox.Show("Error: Amount Spent must be a numeric input.");
                        }
                    }
                    //error for input budget out of bounds
                    else
                    {
                        txtBudget.Focus();
                        txtBudget.SelectAll();
                        MessageBox.Show("Error: Cannot budget cannot be negative value.");
                    }
                }
                //error for non numeric input budget
                else
                {
                    txtBudget.Focus();
                    txtBudget.SelectAll();
                    MessageBox.Show("Error: Budget must be a numeric input.");
                }
            }
            //error for empty project name
            else
            {
                txtProjectName.Focus();
                txtProjectName.SelectAll();
                MessageBox.Show("Error: Project name cannot be empty.");
            }
        }
        /// <summary>
        /// event handler for double click on a listbox object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbOutputDisplay_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            //creates a new window
            winProjectDetails newWindow = new winProjectDetails();
            newWindow.Show();
        }
    }
}
