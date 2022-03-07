using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Model;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller; 
            
            //CreateSampeData();

            WireUplists();
        }


        private void CreateSampeData()
        {
            availableTeamMembers.Add(new PersonModel { firstName = "Tim", LastName = "corey" });
            availableTeamMembers.Add(new PersonModel { firstName = "sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { firstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { firstName = "Bill", LastName = "Jones" });
        }

        private void WireUplists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";


            teamMemberListBox.DataSource = null;

            teamMemberListBox.DataSource = selectedTeamMembers;
            teamMemberListBox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.firstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAdress = emailAdressValue.Text;
                p.CellPhoneNumber = phoneNumberValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUplists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailAdressValue.Text = "";
                phoneNumberValue.Text = "";

            }
            else
            {
                MessageBox.Show("All the fields needs to be filled");
            }

        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailAdressValue.Text.Length == 0)
            {
                return false;
            }

            if (phoneNumberValue.Text.Length == 0)
            {
                return false;
            }


            return true;
        }

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUplists();
            }
            

        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemberListBox.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUplists();
            }
           
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
