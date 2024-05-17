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
    public partial class TrainerFeedbackDetails : Form
    {
        public TrainerFeedbackDetails()
        {
            InitializeComponent();
        }

        private void MealName_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrainerFeedback f1 = new TrainerFeedback();
            f1.Show();
            this.Hide();
        }
    }
}
