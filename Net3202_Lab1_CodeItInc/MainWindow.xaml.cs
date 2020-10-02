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
        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
            string inputtedProjectName;
            double inputtedProjectSpent;
            double inputtedProjectBudget;
            double inputtedHoursRemaining;
            int inputtedProjectStatus;

            if (txtProjectName.Text.Trim() != string.Empty)
            {
                inputtedProjectName = txtProjectName.Text.Trim();
                if (Double.TryParse(txtBudget.Text.Trim(), out inputtedProjectBudget))
                {
                    if (inputtedProjectBudget >= 0)
                    {
                        if (Double.TryParse(txtSpent.Text.Trim(), out inputtedProjectSpent))
                        {
                            if (inputtedProjectSpent >= 0)
                            {
                                if (Double.TryParse(txtEstHoursRemaining.Text.Trim(), out inputtedHoursRemaining))
                                {
                                    if (inputtedHoursRemaining >= 0)
                                    {
                                        inputtedProjectStatus = cmbRequirements.SelectedIndex;
                                    }
                                    else if (inputtedHoursRemaining == 0)
                                    {
                                        cmbRequirements.SelectedIndex = 5;
                                        inputtedProjectStatus = cmbRequirements.SelectedIndex;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error: Cannot have negative hours remaining."); 
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error: Estimated time must be a numeric input.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error: Cannot amount spent cannot be negative value.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Amount Spent must be a numeric input.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Cannot budget cannot be negative value.");
                    }
                }
                else
                {
                    MessageBox.Show("Error: Budget must be a numeric input.");
                }
            }
            else
            {
                MessageBox.Show("Error: Project name cannot be empty.");
            }
        }
    }
}
