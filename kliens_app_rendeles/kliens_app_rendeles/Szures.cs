using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kliens_app_rendeles
{
    public partial class Szures : Form
    {


        //private string _status;
        private DateTime _dateStart;
        private DateTime _dateEnd;

        //public string Status { get { return _status; } }
        public DateTime DateStart { get { return _dateStart; } }
        public DateTime DateEnd { get { return _dateEnd; } }

        public Szures()
        {
            InitializeComponent();
            List<string> dataSource = new List<string>();

            dataSource.Add(" ");
            foreach (string s in HotcakesKezeles.OrderStatuses) { dataSource.Add(s); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_status = comboBoxSStatus.Text;
            _dateStart = dateTimePicker1.Value;
            _dateEnd = dateTimePicker2.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
