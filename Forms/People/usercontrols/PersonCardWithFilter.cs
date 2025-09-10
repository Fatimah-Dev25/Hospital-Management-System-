using HospitalManagementSystem.Models;
using HospitalManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.People.usercontrols
{
    public partial class PersonCardWithFilter : UserControl
    {
        public event Action<int> onPersonSelected;
        protected virtual void PersonSelected(int personId)
        {
            Action<int> handler = onPersonSelected;
            if (handler != null)
            {
                handler(personId);
            }
        }

        private bool _ShowAddPerson = true;
        private bool _FilterEnabled = true;
        
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilterBy.Enabled = _FilterEnabled;
            }
        }

        public bool ShowAddPerson
        {
            get => _ShowAddPerson;
            set {
            
                _ShowAddPerson = value;
                btnAddPerson.Enabled = _ShowAddPerson;
            }
        }

        public int PersonID 
        {
            get => ucPersonView1.PersonID;
        }

        public Person SelectedPerson
        {
            get => ucPersonView1.SelectedPerson;
        }

        public PersonCardWithFilter()
        {
            InitializeComponent();
            
        }

        public void LoadPersonInfo(int personId)
        {
            txtFilterBy.Text = personId.ToString();
            cbFilterBy.SelectedIndex = 0;
            
            FindNow();
        }
        private void FindNow()
        {

            switch (cbFilterBy.SelectedIndex) { 
            
                case 0:
                    {
                        ucPersonView1.LoadPersonInControl(Convert.ToInt32(txtFilterBy.Text));
                        break;
                    }
                
                case 1: {

                        ucPersonView1.LoadPersonInControl(txtFilterBy.Text);
                        break;
                    }

                default:break;
            }

            if (onPersonSelected != null && FilterEnabled)
                onPersonSelected(ucPersonView1.PersonID);
        }

        public void FilterFocus()
        {
            txtFilterBy.Focus();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFindPerson.PerformClick();
            }

            if (cbFilterBy.SelectedIndex == 0)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if(!ValidationHelper.IsNotEmpty(txtFilterBy, errorProvider1))
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow();
        }

        private void DataBackEvent(object sender, int personID)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterBy.Text = personID.ToString();
            ucPersonView1.LoadPersonInControl(personID);

            onPersonSelected(ucPersonView1.PersonID);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();  
            
        }

        private void gbFilterBy_Enter(object sender, EventArgs e)
        {

        }

        private void PersonCardWithFilter_Load_1(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterBy.Text = "";
        }

        private void ucPersonView1_Load(object sender, EventArgs e)
        {

        }
    }
}
