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

            //


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (store.UpdateDataFromHotcakes())

            {
               
                dataGridView1.DataSource = store.Orders;
            }
            else
            {
                
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                var order = store.Orders[dataGridView1.SelectedRows[0].Index];

                comboBox1.Text = order.Status;
               
                UpdateOrderDetails(order.Bvin);

                decimal totalPrice = 0;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    
                    if (!row.IsNewRow)
                    {
                        
                        if (decimal.TryParse(row.Cells["Price"].Value.ToString(), out decimal price))
                        {
                            totalPrice += price;
                        }
                    }
                }



            }
            catch (Exception ex)
            {
               
            }
        }
        private void UpdateOrderDetails(string orderId)
        {
          

            List<Termek> items = store.GetOrderItems(orderId);

            foreach (Termek item in items)
            {
                Debug.WriteLine(item.Name, item.Quantity, item.Price);
            }

            dataGridView2.DataSource = items;

            if (items == null)
            {
                
            }
            else
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            search.ShowDialog();

            filteredOrders = new List<Rendeles>();

            foreach (Rendeles order in store.Orders)
            {
                if (order.Date >= search.DateStart && order.Date <= search.DateEnd)
                {
                   
                    filteredOrders.Add(order);
                    
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dataGridView1.DataSource = filteredOrders;
            }
            else
            {
                dataGridView1.DataSource = store.Orders;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedOrderBvin = store.Orders[dataGridView1.SelectedRows[0].Index].Bvin;
                
                bool done = store.SetOrderState(selectedOrderBvin, comboBox1.Text);
                if (done)
                {
                    store.Orders[dataGridView1.SelectedRows[0].Index].Status = comboBox1.Text;
                    
                }
                else
                {
                    
                }
            }
            catch
            {
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
