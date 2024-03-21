using CafeBookingAppSample.Models;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CafeBookingAppContext appContext = new CafeBookingAppContext();
            Menu menu = new Menu();
            menu.Title = txtTitle.Text;
            menu.Description = txtDescription.Text;
            menu.Price = Convert.ToDecimal(txtPrice.Text);

            appContext.Add(menu);
            appContext.SaveChanges();
            LoadUpdate();

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            LoadUpdate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            CafeBookingAppContext context = new CafeBookingAppContext();
            Menu menu = context.Menu.Where(x => x.Id == selectedId).FirstOrDefault();

            menu.Title = txtTitle.Text;
            menu.Description = txtDescription.Text;
            menu.Price = Convert.ToDecimal(txtPrice.Text);

            context.SaveChanges();
            LoadUpdate();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            CafeBookingAppContext context = new CafeBookingAppContext();
            Menu menu = context.Menu.Where(x => x.Id == selectedId).FirstOrDefault();

            txtDescription.Text = menu.Description;
            txtPrice.Text = menu.Price.ToString();
            txtTitle.Text = menu.Title;


        }
        private void LoadUpdate()
        {
            CafeBookingAppContext appContext = new CafeBookingAppContext();
            List<Menu> menu = appContext.Menu.ToList();
            dataGridView1.DataSource = menu;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            CafeBookingAppContext context = new CafeBookingAppContext();
            Menu menu = context.Menu.Where(x => x.Id == selectedId).FirstOrDefault();

            context.Remove(menu);
            context.SaveChanges();
            LoadUpdate();

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomers frmCustomers = new FrmCustomers();
            frmCustomers.ShowDialog();
           
            
        }
    }
}
