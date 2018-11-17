using PhotoManagerClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validation;

namespace Client_PM
{
    public partial class DLG_Account : Form
    {
        public User User { get; set; }
        private ValidationProvider ValidationProvider;
        private bool AvatarImageChanged = false;
        public DLG_Account()
        {
            InitializeComponent();
        }
        private void DLG_Account_Load(object sender, EventArgs e)
        {
            ValidationProvider = new ValidationProvider(this, SubmitTask);
            ValidationProvider.AddControlToValidate(TBX_Username, Validate_TBX_Username, Validate_TBX_Username_OnSubmit);
            ValidationProvider.AddControlToValidate(TBX_Password, Validate_TBX_Password);
            ValidationProvider.AddControlToValidate(TBX_VerifyPassword, Validate_TBX_verifyPassword);
            ValidationProvider.AddControlToValidate(IBX_Avatar, Validate_IBX_Avatar);
            if (User != null)
                User_To_DLG();
        }
        private void User_To_DLG()
        {
            TBX_Username.Text = User.Name;
            TBX_Password.Text = User.Password;
            TBX_VerifyPassword.Text = User.Password;
            IBX_Avatar.BackgroundImage = User.GetAvatarOriginalImage();
            AvatarImageChanged = false;
        }


        private void DLG_To_User()
        {
            User.Name = TBX_Username.Text;
            User.Password = TBX_Password.Text;
            if (AvatarImageChanged )
                User.SetAvatarImage(IBX_Avatar.BackgroundImage);
        }
        private bool Validate_TBX_Username(ref string message)
        {
            message = "Nom d'usager manquant";
            return TBX_Username.Text != "";
        }
        private bool Validate_TBX_Username_OnSubmit(ref string message)
        {
            message = "Nom d'usager déjà utilisé";
            if (User != null)
                return !DBPhotosWebServices.UserNameAlreadyUsed(User.Id, TBX_Username.Text);
            else
                return !DBPhotosWebServices.UserNameExist(TBX_Username.Text);
        }
        private bool Validate_TBX_Password(ref string message)
        {
            message = "Mot de passe manquant";
            return TBX_Password.Text != "";
        }
        private bool Validate_TBX_verifyPassword(ref string message)
        {
            message = "Mot de passe ne correspond avec vérification";
            return TBX_VerifyPassword.Text == TBX_Password.Text;
        }

        private bool Validate_IBX_Avatar(ref string message)
        {
            message = "Veuillez vhoisir votre avatar.";
            return IBX_Avatar.BackgroundImage != null;
        }

        private void SubmitTask()
        {
            if (User == null)
            {
                User = new User();
                DLG_To_User();
                User = DBPhotosWebServices.CreateUser(User);
            }
            else
            {
                DLG_To_User();
                DBPhotosWebServices.UpdateUser(User);
            }
        }

        private void IBX_Avatar_BackgroundImageChanged(object sender, EventArgs e)
        {
            AvatarImageChanged = true;
            ValidationProvider.UpdateValid(IBX_Avatar);
        }

        private void BTN_DeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir effacer votre compte et toutes vos photos?", "Attention!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DBPhotosWebServices.DeleteUser(User.Id);
                User = null;
                DialogResult =  DialogResult.OK;
                Close();
            }
        }
    }
}
