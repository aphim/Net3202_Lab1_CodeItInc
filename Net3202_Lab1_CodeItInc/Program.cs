//These are default (keep them!)
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
//keep the default namespace too, BillingApp is just the name of my project.
namespace Net3202_Lab1_CodeItInc
{
    public class Program
    {
        //First private data member
        private string projectName;
        private double projectBudget;
        private double projectSpent;
        private double hoursRemaining;
        private string projectStatus;

        //Complete the rest (there are four more mentioned in the description).
        //constructor, you need to complete it this is a no parameter constructor
       // shown below.
    public Program(string projectName, double projectBudget, double projectSpent, double hoursRemaining, string projectStatus)
        {

        }
            
        public string ProjectName
        {
            get { return this.projectName; }
            set { this.projectName = value; }
        }
    public double ProjectBudget
        { 
            get { return this.projectBudget; }
            set { this.projectBudget = value; }
        }
    public double ProjectSpent
        {
            get { return this.projectSpent; }
            set { this.projectSpent = value; }
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
