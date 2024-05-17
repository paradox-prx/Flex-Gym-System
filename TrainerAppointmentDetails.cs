using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class TrainerAppointmentDetails : Form
    {
        public TrainerAppointmentDetails()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrainerAppointment f1 = new TrainerAppointment();
            f1.Show();
            this.Hide();
        }
    }
}
