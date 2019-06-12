using OrganiserLibrary;
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
    public partial class PrizeCreationForm : Form
    {
        public PrizeCreationForm()
        {
            InitializeComponent();
        }

        private void PrizeCreationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void HeadingLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNumberBox.Text,
                    placeNameBox.Text,
                    prizeAmountBox.Text,
                    prizePercentageBox.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                placeNumberBox.Text = "";
                placeNameBox.Text = "";
                prizeAmountBox.Text = "0";
                prizePercentageBox.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberBox.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                output = false;
            } 

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameBox.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool PrizeAmountValid = decimal.TryParse(prizeAmountBox.Text, out prizeAmount);
            bool PrizePercentageValid = double.TryParse(prizePercentageBox.Text, out prizePercentage);

            if (PrizeAmountValid == false || PrizePercentageValid == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 && prizePercentage >100)
            {
                output = false;
            }
            return output;
        }

        
    }
}
