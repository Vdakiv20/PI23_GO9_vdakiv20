﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManager_G09 {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (txtUsername.Text == "" || txtPassword.Text == "") {
                MessageBox.Show("Nisu uneseni podaci", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {

                FrmStudents frmStudents = new FrmStudents();
                frmStudents.ShowDialog();
            }

        }
    }
}
