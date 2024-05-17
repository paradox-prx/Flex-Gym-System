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
    public partial class TrainerDietPlanDetails : Form
    {
        public TrainerDietPlanDetails()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrainerDietPlan f1= new TrainerDietPlan();
            f1.Show();
            this.Hide();
        }
    }
}
