//Project Name: Net3202_Lab1_CodeItInc
//Author: Jacky Yuan
//Date: Oct 2, 2020
//Description: Makes a program that generates projects.
//Change log: N / A

using System;
using System.Collections.Generic;
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
        /// <summary>
        /// Initialization of the new window. 
        /// </summary>
        /// <param name="viewedProject"></param>
        public winProjectDetails(Project viewedProject)
        {
            InitializeComponent();

            //creates a new instance of the project object
            Project currentProject = viewedProject;

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

    }
}
