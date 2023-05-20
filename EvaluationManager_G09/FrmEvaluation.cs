using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManager_G09 {
    public partial class FrmEvaluation : Form {

        private Models.Student student;
        public FrmEvaluation(Models.Student selectedStudent) {
            InitializeComponent();
            student = selectedStudent;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label1_Click_1(object sender, EventArgs e) {

        }
    }
}
