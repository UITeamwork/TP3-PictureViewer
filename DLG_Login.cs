﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validation;
using PhotoManagerClient;

namespace Client_PM
{
    public partial class DLG_Login : Form
    {
        public User Logged_User { get; set; }
        ValidationProvider ValidationProvider;
        public DLG_Login()
        {
            InitializeComponent();
            Logged_User = null;
        }

        private void DLG_Login_Load(object sender, EventArgs e)
        {
            ValidationProvider = new ValidationProvider(this, Submit_Task);
            ValidationProvider.AddControlToValidate(TBX_UserName, Validate_UserName, Validate_UserName_OnSubmit);
            ValidationProvider.AddControlToValidate(TBX_Password, Validate_Password, Validate_Password_OnSubmit);
            Load_Settings();
        }

        private bool Validate_UserName(ref string message)
        {
            message = "User name is missing";
            return TBX_UserName.Text != "";
        }

        private bool Validate_UserName_OnSubmit(ref string message)
        {
            message = "User name does not exist";
            return DBPhotosWebServices.UserNameExist(TBX_UserName.Text);
        }

        private bool Validate_Password(ref string message)
        {
            message = "Password is missing";
            return TBX_Password.Text != "";
        }

        private bool Validate_Password_OnSubmit(ref string message)
        {
            message = "Wrong password";
            return DBPhotosWebServices.PasswordMatch(TBX_UserName.Text, TBX_Password.Text);
        }

        private void Submit_Task()
        {
            Save_Settings();
            WaitSplash.Show(this, "Login...");
            Logged_User = DBPhotosWebServices.Login(TBX_UserName.Text, TBX_Password.Text);
            WaitSplash.Hide();
        }

        private void Load_Settings()
        {


            TBX_UserName.Text = Properties.Settings.Default.Login_Name;
            TBX_Password.Text = Properties.Settings.Default.Login_Password;
            if (Properties.Settings.Default.Login_Name != "" && Properties.Settings.Default.Login_Password != "")
            {
                CBX_RememberMe.Checked = true;
            }
        }
        private void Save_Settings()
        {
            if (CBX_RememberMe.Checked)
            {
                Properties.Settings.Default.Login_Name = TBX_UserName.Text;
                Properties.Settings.Default.Login_Password = TBX_Password.Text;
            }
            else
            {
                Properties.Settings.Default.Login_Name = "";
                Properties.Settings.Default.Login_Password = ""; ;
            }

            Properties.Settings.Default.Save();
        }
    }
}