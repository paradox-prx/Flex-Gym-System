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
    public partial class CreateDietTrainer : Form
    {
        public CreateDietTrainer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDietTrainer f1 = new CreateDietTrainer();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateWorkoutPlan f1 = new CreateWorkoutPlan();
            f1.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            TrainerAppointment f1 = new TrainerAppointment();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrainerDietPlan f1 = new TrainerDietPlan();
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrainerWorkoutPlan f1 = new TrainerWorkoutPlan();
            f1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TrainerFeedback f1 = new TrainerFeedback();
            f1.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CreateWorkoutPlan f1 = new CreateWorkoutPlan();
            f1.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TrainerDietPlan f1 = new TrainerDietPlan();
            f1.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            TrainerWorkoutPlan f1 = new TrainerWorkoutPlan();
            f1.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            TrainerFeedback f1 = new TrainerFeedback();
            f1.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
