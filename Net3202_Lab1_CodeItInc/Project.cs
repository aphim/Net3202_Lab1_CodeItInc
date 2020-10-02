//These are default (keep them!)
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
//keep the default namespace too, BillingApp is just the name of my project.
namespace Net3202_Lab1_CodeItInc
{
    public class Project
    {
        //First private data member
        private string projectName;
        private double budget;
        private double amountSpent;
        private double hoursRemaining;
        private string projectStatus;

        //Complete the rest (there are four more mentioned in the description).
        //constructor, you need to complete it this is a no parameter constructor
       // shown below.
    public Project(string projectName, double budget, double amountSpent, double hoursRemaining, string projectStatus)
        {
            this.projectName = projectName;
            this.budget = budget;
            this.amountSpent = amountSpent;
            this.hoursRemaining = hoursRemaining;
            this.projectStatus = projectStatus;
        }
            
    public string ProjectName
        {
            get { return this.projectName; }
            set { this.projectName = value; }
        }
    public double ProjectBudget
        { 
            get { return this.budget; }
            set { this.budget = value; }
        }
    public double ProjectSpent
        {
            get { return this.amountSpent; }
            set { this.amountSpent = value; }
        }
    public double HoursRemaining
        {
            get { return this.hoursRemaining; }
            set { this.hoursRemaining = value; }
        }
    public string ProjectStatus
        {
            get { return this.projectStatus; }
            set { this.projectStatus = value; }
        }

    }
   
}
