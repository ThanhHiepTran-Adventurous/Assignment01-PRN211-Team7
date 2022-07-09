using Microsoft.Extensions.Configuration;

using DataAccess.Repository;
namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {   

        IMemberRepository memberRepository = new IMemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var adminLogin = Program.Configuration.GetSection("AdminAccount").Get<MemberObject>();


            var mem = MemberDAO.Instance.GetMemberList();
            string Email = adminLogin.Email;

            string Password = adminLogin.Password;


            string _Email = txtEmail.Text;
            string _Password = txtPassword.Text;


            string EmailMemberTest = txtEmail.Text;
            string PasswordMemberTest = txtPassword.Text;
            bool checkLogin = false;
        }
    }
}