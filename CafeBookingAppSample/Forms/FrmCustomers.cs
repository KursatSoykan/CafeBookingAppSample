using CafeBookingAppSample.Models;
using CafeBookingAppSample.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeBookingAppSample.Forms
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CafeBookingAppContext app = new CafeBookingAppContext();
                CustomerServices customerServices = new CustomerServices();
                Customers customers = new Customers();
                customers.Name = txtName.Text;
                customers.SurName = txtSurName.Text;
                customers.Email = txtMail.Text;
                customers.Phone = txtPhone.Text;
                customers.Address = txtAddress.Text;
                customerServices.CustomersAdd(customers);
                MessageBox.Show(customers.Name + " isimli customers basariyla eklendi");
                LoadAdd();


            }
            catch (Exception)
            {

                MessageBox.Show("Oda eklerken bir hata meydana geldi. Lutfen tekrar deneyiniz");
            }

        }

        public void LoadAdd()
        {
            CustomerServices customerServices = new CustomerServices();
            List<Customers> customers = customerServices.GetAllCustomers();
            dataGridView1.DataSource = customers;
            lblListeleme.Text = customers.Count.ToString() + "  Müşteri listeleniyor";
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            LoadAdd();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            CafeBookingAppContext contextapp = new CafeBookingAppContext();
            Customers customers = contextapp.Customers.Where(x => x.Id == selectedId).FirstOrDefault();

            txtName.Text = customers.Name;
            txtAddress.Text = customers.Address;
            txtMail.Text = customers.Email;
            txtPhone.Text = customers.Phone;
            txtSurName.Text = customers.SurName;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            CafeBookingAppContext contextapp = new CafeBookingAppContext();
            Customers customers = contextapp.Customers.Where(x => x.Id == selectedId).FirstOrDefault();

            customers.Name = txtName.Text;
            customers.Address = txtAddress.Text;
            customers.Email = txtMail.Text;
            customers.SurName = txtSurName.Text;
            customers.Phone = txtPhone.Text;
            contextapp.SaveChanges();
            LoadAdd();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            CafeBookingAppContext contextapp = new CafeBookingAppContext();
            Customers customers = contextapp.Customers.Where(x => x.Id == selectedId).FirstOrDefault();

            contextapp.Remove(customers);
            contextapp.SaveChanges();
            LoadAdd();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.ShowDialog();
           

        }
    }


}   

