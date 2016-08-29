﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TvForms.Helpers;
using TVContext;

namespace TvForms
{
    public partial class CoreForm : Form//, IIdentifyUser
    {
        //ToDo Review need to store all user data
        private int CurrentUserId { get; set; } = 2; // need delete '2' after test programme and uncommit ShowLoginForm() in CoreForm constructor

        public CoreForm()
        {
            ShowLoginForm(); //uncommit after test programme

            InitializeComponent();
            LoadMainControl();

            string nameWindow = this.Text;
            var userRepo = new BaseRepository<User>();
            nameWindow += " - " + userRepo.Get(u => u.Id == CurrentUserId).FirstOrDefault().Login;
            this.Text = nameWindow;
        }


        private void LoadMainControl()
        {
            if (CurrentUserId != 0)
            {
                var user = new BaseRepository<User>();
                var firstOrDefault = user.Get(x => x.Id == CurrentUserId).FirstOrDefault();
                if (firstOrDefault != null)
                {
                    var userType = firstOrDefault.UserType.Id;

                    switch (userType)
                    {
                        case (int) EUserType.ADMIN: //admin
                            panelCore.Controls.Add(new UcAdminView(CurrentUserId));
                            break;
                        case (int) EUserType.CLIENT: //user
                            panelCore.Controls.Add(new UcTabsForUser(CurrentUserId));
                            break;
                    }
                }
            }
        }

        
        private void ShowLoginForm()
        {
            PassForm lg = new PassForm();
            if (lg.ShowDialog() == DialogResult.OK)
            {
                CurrentUserId = lg.CurrentUserId;
            }
            else
            {
                Environment.Exit(0);
            }
        }


        private void openXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ToDo Naming convention!
            var openXmlFile = new OpenFileDialog
            {
                DefaultExt = "*.xml",
                Filter = "XML Files|*.xml"
            };
            
            if (openXmlFile.ShowDialog() != DialogResult.OK || openXmlFile.FileName.Length <= 0) return;

            XmlFileHelper.ParseChannel(openXmlFile.FileName);
            XmlFileHelper.ParseProgramm(openXmlFile.FileName);
        }


        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Uncomment when bookmarks will be ready end specify appropriate one!!!!
            var actions = new ActionForm(new UcUserProfile(CurrentUserId))
            {
                Text = @"User profile",
                Icon = new Icon(@"d:\docs\C#\TvAppTeam\TVAppVNV\TvForms\icons\j01_9602.ico")
            };
            actions.Show();
        }


        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var actions = new ActionForm(new UсOrdersView(CurrentUserId))
            {
                Text = @"User orders history",
                Icon = new Icon(@"d:\docs\C#\TvAppTeam\TVAppVNV\TvForms\icons\wallet.ico")
            };
            actions.Show();
        }


        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var actions = new ActionForm(new UcPayments(CurrentUserId))
            {
                Text = @"PAYMENTS",
                Icon = new Icon(@"d:\docs\C#\TvAppTeam\TVAppVNV\TvForms\icons\dollar.ico")
            };
            actions.Show();
        }
        

        private void xmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog()
            {
                DefaultExt = "*.xml",
                Filter = @"XML Files(*.xml)|*.xml|All files(*.*)|*.*"
            };

            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;

            XmlFileHelper.XmlFavouriteWriter(saveFile.FileName, CurrentUserId);

            MessageBox.Show(@"Файл XML сохранен", @"Save",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void zipToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var saveFile = new SaveFileDialog()
            {
                DefaultExt = "*.zip",
                Filter = @"ZIP Files(*.zip)|*.zip"
            };

            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;

            XmlFileHelper.XmlFavouriteWriter(saveFile.FileName.Split('.')[0] + ".xml", CurrentUserId);
            ZipHelper.CreateZipFile(saveFile.FileName, saveFile.FileName.Split('.')[0] + ".xml");
            Helper.DeleteFileIfExist(saveFile.FileName.Split('.')[0] + ".xml");

            MessageBox.Show(@"Файл ZIP сохранен", @"Save",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void CoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var context = new TvDBContext())
            {
                var ordRepo = new BaseRepository<Order>(context);
                var schedRepo = new BaseRepository<UserSchedule>(context);


                var notPaidOrders = ordRepo.Get(x => x.IsPaid == false).ToList();

                foreach (var order in notPaidOrders)
                    ordRepo.Remove(order);

                var ordChannels = new BaseRepository<OrderChannel>(context).Get(oCh => oCh.Order.User.Id == CurrentUserId).ToList();
                var needCheckForRemoveTvShow = schedRepo.Get(pr => pr.User.Id == CurrentUserId).ToList();
                foreach (var show in needCheckForRemoveTvShow)
                {
                    if (ordChannels.Find(ch => ch.Channel.Id == show.TvShow.Channel.Id) == null)
                        schedRepo.Remove(show);
                }
            }
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ab = new About();
            ab.ShowDialog();
        }

        private void accountRechargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var acc = new BaseRepository<Account>().Get(a => a.User.Id == CurrentUserId).FirstOrDefault();
            if (acc?.IsActiveStatus == false)
            {
                MessagesContainer.DisplayError("Account is diactivated!" + Environment.NewLine +
                                               "Please connect to administrator", "Attention!!!");
                return;
            }

            var actions = new AccountChargeForm(CurrentUserId)
            {
                Text = @"Account recharge",
                Icon = new Icon(@"d:\docs\C#\TvAppTeam\TVAppVNV\TvForms\icons\mastercard_1450.ico")
            };
            actions.Show();
        }
    }
}
