﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TvContext;

namespace TvForms.Forms
{
    // functionality 
    public partial class AddCompanyServices : Form
    {
        public AddCompanyServices()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            var errorMessage ="";
            var isError = false;

            if (!tbServiceName.Text.IsValidService() && tbServiceName.Text != String.Empty)
            {
                errorMessage += "Service name is not valid\n";
                isError = true;
            }

            if (numServicePrice.Text.GetInt() == 0)
            {
                errorMessage += "You should add price to the service\n";
                isError = true;
            }

            if (isError)
            {
                MessagesContainer.DisplayError(errorMessage, "Error");
            }
            else
            {
                var serviceRepo = new BaseRepository<AdditionalService>();
                serviceRepo.Insert(new AdditionalService
                {
                    Name = tbServiceName.Text,
                    Price = numServicePrice.Text.GetInt(),
                    IsAgeLimit = cbAdultContent.Checked
                });
                MessagesContainer.DisplayInfo("Service added successfully", "Success");
                this.Close();
            }
        }
    }
}
