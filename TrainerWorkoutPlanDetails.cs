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
    public partial class TrainerWorkoutPlanDetails : Form
    {
        public TrainerWorkoutPlanDetails()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrainerWorkoutPlan f1= new TrainerWorkoutPlan();
            f1.Show();
            this.Hide();
        }
    }
}
