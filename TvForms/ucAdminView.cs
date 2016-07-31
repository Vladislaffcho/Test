﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVContext;

namespace TvForms
{
    public partial class ucAdminView : UserControl
    {
        
        private User _currentUser;
        public ucAdminView(User currentUser)
        {
            _currentUser = currentUser;
            
            /*using (var context = new TvDBContext())
            {
                var defaultEmail = new List<UserEmail> {
                    new UserEmail {
                        EmailName = "root@root.com",
                        Comment = "Admin's email",
                        TypeConnect = context.TypeConnects.First(x => x.Id == 1),
                        User = context.Users.First(l => l.Id == 1)
                    },
                    new UserEmail {
                        EmailName = "user@user.com",
                        Comment = "User's email",
                        TypeConnect = context.TypeConnects.First(x => x.Id == 2),
                        User = context.Users.First(l => l.Id == 2)
                    }
                };

                foreach (var item in defaultEmail)
                {
                    context.UserEmails.Add(item);
                }

                context.SaveChanges();
            }*/


            InitializeComponent();
            SetPageView();
        }

        private void SetPageView()
        {
            // clear the list view in case user's opened it previously during a session
            lvUserList.Items.Clear();
            cbStatus.Items.Add("Active");
            cbStatus.Items.Add("Inactive");
            initForAdmin();
        }

        private void initForAdmin()
        {
            using (var context = new TvDBContext())
            {
                // Filling the user list List View
                var usr = from u in context.Users
                          select u;

                usr.ToList();

                foreach (var i in usr)
                {
                    var lvItem = new ListViewItem(i.Id.ToString());
                    lvItem.SubItems.Add(i.Login);
                    lvItem.SubItems.Add(i.FirstName);
                    lvItem.SubItems.Add(i.LastName);
                    lvUserList.Items.Add(lvItem);
                }
            }
        }

        private void gbUsers_Enter(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetItemsForChosenUser();
            var listView = (ListView)sender;
            if (listView.SelectedItems.Count > 0)
            {
                var listViewItem = listView.SelectedItems[0];
                int id = GetInt(listViewItem.SubItems[0].Text);
                tbName.Text = listViewItem.SubItems[2].Text;
                tbSurname.Text = listViewItem.SubItems[3].Text;

                using (var context = new TvDBContext())
                {
                    // Filling user's phone list List View
                    var address = context.UserAddresses.Where(c => c.User.Id == id);
                    if (address.Any())
                    {
                        address.ToList();

                        foreach (var i in address)
                        {
                            var lvItem = new ListViewItem(i.TypeConnect.NameType);
                            lvItem.SubItems.Add(i.Address);
                            lvItem.SubItems.Add(i.Comment);
                            lvUserAddress.Items.Add(lvItem);
                        }
                    }

                    // Filling user's email list List View
                    var email = context.UserEmails.Where(c => c.User.Id == id);
                    if (email.Any())
                    {
                        email.ToList();

                        foreach (var i in email)
                        {
                            var lvItem = new ListViewItem(i.TypeConnect.NameType);
                            lvItem.SubItems.Add(i.EmailName);
                            lvItem.SubItems.Add(i.Comment);
                            lvUserEmail.Items.Add(lvItem);
                        }
                    }

                    // Filling user's phone list List View
                    var phone = context.UserPhones.Where(c => c.User.Id == id);
                    if (phone.Any())
                    {
                        phone.ToList();

                        foreach (var i in phone)
                        {
                            var lvItem = new ListViewItem(i.TypeConnect.NameType);
                            lvItem.SubItems.Add(i.Number.ToString());
                            lvItem.SubItems.Add(i.Comment);
                            lvUserTelephone.Items.Add(lvItem);
                        }
                    }

                    // Filling Money TB
                    /*var money = context.Users.Where(c => c.DepositAccount == id);
                    tbMoney.Text = */
                }
            }
        }

        private int GetInt(string source)
        {
            int i;
            if (int.TryParse(source, out i))
            {
                return i;
            }
            return -1;
        }

        private void SetItemsForChosenUser()
        {
            // clear the list views in case user's opened it previously during a session
            lvUserAddress.Items.Clear();
            lvUserTelephone.Items.Clear();
            lvUserEmail.Items.Clear();
            


            tbMoney.Text = "Change in ucAdminClass";
            //uncomment when full functionality is available
            //tbMoney.Text = _currentUser.DepositAccount.Balance.ToString();
            
            cbStatus.SelectedIndex = 0;
            /*if (_currentUser.DepositAccount.Status)
            {
                cbStatus.SelectedIndex = 0;
            }
            else
            {
                cbStatus.SelectedIndex = 1;
            }*/
        }
    }
}
