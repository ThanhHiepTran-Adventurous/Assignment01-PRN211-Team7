using Microsoft.Extensions.Configuration;
using BusinessObject;
using DataAccess;
namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {   

        IMemberRepository memberRepository = new MemberRepository();
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

            if (Email.Equals(_Email) && Password.Equals(_Password))
            {

                checkLogin = true;
                if (checkLogin)
                {
                    MessageBox.Show("Login succes with admin");
                }
                frmMemberManagement frmMemberManagement = new frmMemberManagement(Email);
                frmMemberManagement.Show();//hiển thị form main
                this.Hide();// ẩn form login
            }
            else
            {
                foreach (MemberObject member in mem)
                {
                    if (member.Email.ToString().ToLower() == EmailMemberTest.ToString().ToLower()
                        && member.Password.ToString().ToLower().Equals(PasswordMemberTest.ToString().ToLower()))
                    {
                        frmMemberDetails frmMemberDetails = new frmMemberDetails
                        {

                            Text = "Update member " + "of " + member.MemberName,
                            InsertOrUpdate = true,
                            MemberInfo = member,
                            MemberRepository = memberRepository,

                        };
                        checkLogin = true;
                        if (checkLogin)
                        {
                            MessageBox.Show("Login success with member!");
                        }
                        frmMemberDetails.Show();
                        this.Hide();
                    }
                }
            }
            if (checkLogin == false)
            {
                MessageBox.Show("Login Fails");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }
        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}