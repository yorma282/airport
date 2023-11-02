using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace airport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formlogin = new RouteForm();
            formlogin.Show();
            formlogin.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Hide();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formlogin = new AirplaneForm();
            formlogin.Show();
            formlogin.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formlogin = new DateForm();
            formlogin.Show();
            formlogin.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            Hide();
        }
    }
}
