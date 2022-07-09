using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        //Create a data source
        BindingSource source;
        //--------------------------------------------------

        public frmMemberManagement(string Email)
        {
            InitializeComponent();
            lbEmail.Text = Email;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;

            dgvMemberList.CellDoubleClick += DgvCarList_CellDoubleClick;
        }

        private void DgvCarList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update member",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository,
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //set focus member update
                source.Position = source.Count - 1;
            }
        }

        private MemberObject GetMemberObject()
        {
            MemberObject mem = null;
            try
            {
                mem = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Password = txtPassword.Text,
                    RoleID = txtRoleID.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail.Text
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return mem;
        }//end GetMemberObject

        private void LoadMemberList()
        {
            var members = memberRepository.GetMembers();
            try
            {
                //
                BindingSource source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtRoleID.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtEmail.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtRoleID.DataBindings.Add("Text", source, "RoleID");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtEmail.DataBindings.Add("Text", source, "Email");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member List");
            }
        }

        //clear text on TextBoxes
        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtRoleID.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }


        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetail = new frmMemberDetails
            {
                Text = "Add a new Members",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //set focus member insert
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var mem = GetMemberObject();
                memberRepository.DeleteMember(mem.MemberID);
                LoadMemberList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void cbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmbCountry = cbxCountry.SelectedItem;
            Console.WriteLine(cmbCountry);
            var listMembersFilteredByCountry = memberRepository.FilterMemberByCountry(cmbCountry.ToString());
            Console.WriteLine(cmbCountry.ToString());
            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = listMembersFilteredByCountry;
        }

        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmbCity = cbxCity.SelectedItem;
            Console.WriteLine(cmbCity);
            var listMembersFilteredByCity = memberRepository.FilterMemberByCity(cmbCity.ToString());
            Console.WriteLine(cmbCity.ToString());
            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = listMembersFilteredByCity;
        }

        private void txtTypeSearchMemberName_TextChanged(object sender, EventArgs e)
        {
            var members = memberRepository.GetMembers();
            string nameMember = txtTypeSearchMemberName.Text;
            //  int iDMember = Convert.ToInt32(txtTypeSearchMemberName.Text.Trim());
            Console.WriteLine("================" + nameMember);
            List<MemberObject> memberList = new List<MemberObject>();

            foreach (MemberObject member in members)
            {
                LoadMemberList();

                if (member.MemberName.ToString().ToLower().Contains(nameMember.ToLower()))
                {
                    memberList.Add(member);
                }

            }
            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = memberList;
        }

        private void txtsearchid_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtsearchid.Text))
            {
                string value = txtsearchid.Text;
                var members = memberRepository.GetMembers();
                List<MemberObject> memberList = new List<MemberObject>();

                LoadMemberList();

                foreach (MemberObject member in members)
                {
                    if (member.MemberID == int.Parse(value.ToString()))
                    {
                        memberList.Add(member);
                    }

                }
                if (memberList.Count <= 0)
                {
                    MessageBox.Show("Not Found Member by ID");
                }
                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = memberList;

            }
            else
                LoadMemberList();
        }

        private void btnSortNameDesc_Click(object sender, EventArgs e)
        {
            this.LoadMemberList();
            var sortedMembersByName = memberRepository.SortNameDesc();
            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = sortedMembersByName;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
