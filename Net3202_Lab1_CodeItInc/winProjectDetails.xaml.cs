//Project Name: Net3202_Lab1_CodeItInc
//Author: Jacky Yuan
//Date: Oct 2, 2020
//Description: Makes a program that generates projects.
//Change log: N/A

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Net3202_Lab1_CodeItInc
{
    /// <summary>
    /// Interaction logic for winProjectDetails.xaml
    /// </summary>
    public partial class winProjectDetails : Window
    {
        public ObservableCollection<Project> list;
        public int listIndex;

        /// <summary>
        /// Initialization of the new window. 
        /// </summary>
        /// <param name="viewedProject"></param>
        public winProjectDetails(ObservableCollection<Project> list, int listIndex)
        {
            InitializeComponent();

            //creates a new instance of the project object
            this.list = list;
            this.listIndex = listIndex;
            Project currentProject = list[listIndex];

            //Calls the getters of the object and displays them as the textboxs and combobox output.
            txtProjectNameOut.Text = currentProject.ProjectName;
            txtBudgetOut.Text = currentProject.ProjectBudget.ToString();
            txtSpentOut.Text = currentProject.ProjectSpent.ToString();
            txtEstHoursRemainingOut.Text = currentProject.HoursRemaining.ToString();
            cmbStatusOut.SelectedIndex = currentProject.ProjectStatus;

        }

        /// <summary>
        /// Event handler for pressing the close window buttton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            //closes the window
            this.Close();
        }

        private void btnAlterProject_Click(object sender, RoutedEventArgs e)
        {
            //temp variable for the user inputs
            string inputtedProjectName;
            double inputtedProjectSpent;
            double inputtedProjectBudget;
            double inputtedHoursRemaining;
            int inputtedProjectStatus;

            //checks if the project name field is empty
            if (txtProjectNameOut.Text.Trim() != string.Empty)
            {
                inputtedProjectName = txtProjectNameOut.Text.Trim();

                //checks if the budget field is empty or non numeric
                if (Double.TryParse(txtBudgetOut.Text.Trim(), out inputtedProjectBudget))
                {
                    //checks if budget field is in bounds
                    if (inputtedProjectBudget >= 0)
                    {
                        //checks if the amount spent is empty or non numeric
                        if (Double.TryParse(txtSpentOut.Text.Trim(), out inputtedProjectSpent))
                        {
                            //checks if the amount spent is in bounds
                            if (inputtedProjectSpent >= 0)
                            {
                                //checks if the estimated time remaining is empty or non numeric
                                if (Double.TryParse(txtEstHoursRemainingOut.Text.Trim(), out inputtedHoursRemaining))
                                {
                                    //checks if estimated time remaining is in bounds
                                    if (inputtedHoursRemaining >= 0)
                                    {
                                        inputtedProjectStatus = cmbStatusOut.SelectedIndex;
                                        //checks if estimated time remaining is equal to zero
                                        if (inputtedHoursRemaining == 0)
                                        {
                                            //changes status to completed
                                            cmbStatusOut.SelectedIndex = 5;
                                            inputtedProjectStatus = cmbStatusOut.SelectedIndex;
                                        }
                                        //checks if the status selected is equal to completed
                                        if (cmbStatusOut.SelectedIndex == 5)
                                        {
                                            //changes estimated time to 0
                                            txtEstHoursRemainingOut.Text = "0";
                                            inputtedHoursRemaining = 0;
                                        }
                                        //creates new project with current inputs
                                        list[listIndex] = new Project(inputtedProjectName, inputtedProjectBudget, inputtedProjectSpent,
                                        inputtedHoursRemaining, inputtedProjectStatus);

                                    }
                                    //error for hour input out of bounds
                                    else
                                    {
                                        txtEstHoursRemainingOut.Focus();
                                        txtEstHoursRemainingOut.SelectAll();
                                        MessageBox.Show("Error: Cannot have negative hours remaining.");
                                    }
                                }
                                //error for non numeric hour input
                                else
                                {
                                    txtEstHoursRemainingOut.Focus();
                                    txtEstHoursRemainingOut.SelectAll();
                                    MessageBox.Show("Error: Estimated time must be a numeric input.");
                                }
                            }
                            //error for input amount spent out of bounds
                            else
                            {
                                txtSpentOut.Focus();
                                txtSpentOut.SelectAll();
                                MessageBox.Show("Error: Cannot amount spent cannot be negative value.");
                            }
                        }
                        //error for non numeric input amount spent
                        else
                        {
                            txtSpentOut.Focus();
                            txtSpentOut.SelectAll();
                            MessageBox.Show("Error: Amount Spent must be a numeric input.");
                        }
                    }
                    //error for input budget out of bounds
                    else
                    {
                        txtBudgetOut.Focus();
                        txtBudgetOut.SelectAll();
                        MessageBox.Show("Error: Cannot budget cannot be negative value.");
                    }
                }
                //error for non numeric input budget
                else
                {
                    txtBudgetOut.Focus();
                    txtBudgetOut.SelectAll();
                    MessageBox.Show("Error: Budget must be a numeric input.");
                }
            }
            //error for empty project name
            else
            {
                txtProjectNameOut.Focus();
                txtProjectNameOut.SelectAll();
                MessageBox.Show("Error: Project name cannot be empty.");
            }
        }
    }
}
