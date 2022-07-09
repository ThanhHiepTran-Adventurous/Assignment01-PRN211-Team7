using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }
        public IMemberRepository MemberRepository { get; set; }

        public bool InsertOrUpdate { get; set; }

        public MemberObject MemberInfo { get; set; }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var mem = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Password = txtPassword.Text,
                    RoleID = txtRoleID.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail.Text

                };
                if (InsertOrUpdate == false)
                {
               //     MemberRepository.InsertMember(mem);
                    MessageBox.Show("Add successfully!!");
                    this.Close();
                }
                else
                {
           //         MemberRepository.UpdateMember(mem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Members" : "Update a Member");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
