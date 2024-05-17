﻿using System;
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
    public partial class TrainerWorkoutPlan : Form
    {
        public TrainerWorkoutPlan()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateDietTrainer f1 = new CreateDietTrainer();
            f1.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Click_1(object sender, EventArgs e)
        {
            TrainerAppointment f1 = new TrainerAppointment();
            f1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TrainerWorkoutPlanDetails f1 = new TrainerWorkoutPlanDetails();
            f1.Show();
            this.Hide();
        }
    }
}
