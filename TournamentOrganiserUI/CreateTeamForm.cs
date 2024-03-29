﻿using OrganiserLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentOrganiserUI                                                                                                                                                                          
{
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedMembers = new List<PersonModel>();
        private List<TeamModel> Team = new List<TeamModel>();
        private ITeamRequest callingform;
        public CreateTeamForm(ITeamRequest caller)
        {
            InitializeComponent();

            callingform = caller;
           // CreateSampleData();

            WireUpMembersList();
        }

        /// <summary>
        /// Method to test Data populates correctly
        /// </summary>
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { Firstname = "Tim", Lastname = "Corey" });
            availableTeamMembers.Add(new PersonModel { Firstname = "David", Lastname = "Calderwood" });

            selectedMembers.Add(new PersonModel { Firstname = "Angus", Lastname = "Calderwood" });
            selectedMembers.Add(new PersonModel { Firstname = "Rona", Lastname = "Calderwood" });
        }

        /// <summary>
        /// Method to select member from dropdown/combobox list, and then populate the playersListBox with selectedMembers.
        /// </summary>
        private void WireUpMembersList()
        {
            memberDropDown.DataSource = null;

            memberDropDown.DataSource = availableTeamMembers;
            memberDropDown.DisplayMember = "FullName";

            playersListBox.DataSource = null;

            playersListBox.DataSource = selectedMembers;
            playersListBox.DisplayMember = "FullName";
        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {

            if(ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.Firstname = firstNameBox.Text;
                p.Lastname = lastNameBox.Text;
                p.Email = emailBox.Text;
                p.TelNumber = telNumberBox.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedMembers.Add(p);

                WireUpMembersList();

                firstNameBox.Text = "";
                lastNameBox.Text = "";
                emailBox.Text = "";
                telNumberBox.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            //TODO - Add valuation to the form
            if (firstNameBox.Text.Length == 0)
            {
                return false;
            }

            if (lastNameBox.Text.Length == 0)
            {
                return false;
            }
            if (emailBox.Text.Length == 0)
            {
                return false;
            }
            if (telNumberBox.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)memberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p); //remove member from dropdown list
                selectedMembers.Add(p); //Adds member to the playersListBox

                WireUpMembersList(); 
            }
            
        }

        private void DeletePlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)playersListBox.SelectedItem;

            if (p != null)
            {
                selectedMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpMembersList(); 
            }
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameText.Text;
            t.TeamMembers = selectedMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingform.TeamComplete(t);

            this.Close();
            
          


        }

        private bool ValidateCreateTeamForm()
        {
            if (ValidateForm() == false)
            {
                return false;
            }
            if (teamNameText.TextLength == 0)
            {
                return false;
            }

            if (playersListBox.Items.Count == 0)
            {
                return false;
            }
            
            return true;
        } 
    }
}
