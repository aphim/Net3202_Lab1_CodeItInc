//Project Name: Net3202_Lab1_CodeItInc
//Author: Jacky Yuan
//Date: Oct 2, 2020
//Description: Makes a program that generates projects.
//Change log: N / A

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Net3202_Lab1_CodeItInc
{
    public class Project
    {
        //private variables
        private string projectName;
        private double budget;
        private double amountSpent;
        private double hoursRemaining;
        private int projectStatus;

        //public constructor for creating a project class object
        public Project(string projectName, double budget, double amountSpent, double hoursRemaining, int projectStatus)
        {
            this.projectName = projectName;
            this.budget = budget;
            this.amountSpent = amountSpent;
            this.hoursRemaining = hoursRemaining;
            this.projectStatus = projectStatus;
        }
        /// <summary>
        /// Getter and Setter for Project Name
        /// </summary>
        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                this.projectName = value;
            }
        }
        /// <summary>
        /// Getter and setter for Project budget
        /// </summary>
        public double ProjectBudget
        {
            get { return this.budget; }
            set { this.budget = value; }
        }
        /// <summary>
        /// Getter and setter for project spent
        /// </summary>
        public double ProjectSpent
        {
            get { return this.amountSpent; }
            set { this.amountSpent = value; }
        }
        /// <summary>
        /// Getter and setter for hours remaining
        /// </summary>
        public double HoursRemaining
        {
            get { return this.hoursRemaining; }
            set { this.hoursRemaining = value; }
        }
        /// <summary>
        /// getter and setter for project status
        /// </summary>
        public int ProjectStatus
        {
            get { return this.projectStatus; }
            set { this.projectStatus = value; }
        }

    }
}
