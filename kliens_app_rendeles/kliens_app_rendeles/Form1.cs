using Hotcakes.Modules.SkinSearch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kliens_app_rendeles
{
    public partial class Form1 : Form
    {
        private HotcakesKezeles store = new HotcakesKezeles();
        private Szures search = new Szures();

        DataGridViewCellStyle headerCellStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle selectedCellStyle = new DataGridViewCellStyle();

        private List<Rendeles> filteredOrders = new List<Rendeles>();
        public Form1()
        {
            InitializeComponent();

            store.Init();
            headerCellStyle.BackColor = Color.AntiqueWhite;


            // dataGridViewOrders.DataSource = bindingSource;

            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;

            dataGridView2.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ReadOnly = true;

            comboBox1.DataSource = HotcakesKezeles.OrderStatuses;
            button2_Click(null, EventArgs.Empty);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //labelConnectivityStatus.Text = "Rendelések letöltése folyamatban...";
            if (store.UpdateDataFromHotcakes())

            {
                //labelConnectivityStatus.Text = "Kész";
                dataGridView1.DataSource = store.Orders;
            }
            else
            {
                //labelConnectivityStatus.Text = "Hiba lépett fel a rendeelések letöltése közben";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void UpdateOrderDetails(string orderId)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
