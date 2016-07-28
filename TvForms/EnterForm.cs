﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvForms
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
            this.tbEnForm_Pass.Select();
            this.tbEnForm_Pass.ScrollToCaret();
        }

        public int IsValidPass { get; set; }

        private void bEnterF_Enter_Click(object sender, EventArgs e)
        {
            PassValidator();
        }


        private int PassValidator()
        {
            //go to database and check user or admin if exists
            if (tbEnForm_Pass.Text != String.Empty)
            {
                string pass = tbEnForm_Pass.Text;
                if (pass == "1") //temporary admin password = 1
                {
                    IsValidPass = 1;

                }
                else if (pass == "2") //temorary user password
                {
                    IsValidPass = 2;

                }
                else
                    IsValidPass = 0; // access denied
            }
            else
            {
                MessageBox.Show("Please enter password", "Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }


    }
}
