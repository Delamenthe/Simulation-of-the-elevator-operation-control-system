using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters.IViews;
using Presenters;

namespace WindowsForms {
    public partial class AccelerationForm : Form, IAccelerationView {
        AccelerationPresenter presenter;
        public AccelerationForm() {
            InitializeComponent();
            presenter = new AccelerationPresenter(this);      
        }

        public void Confirm() {
            this.Hide();
        }

        public void ShowErrorMessage(string message) {
            MessageBox.Show(message);
        }

        private void SetButton_Click(object sender, EventArgs e) {
            presenter.CheckCorrect(AccelerationTextBox.Text);
            this.Hide();
        }
    }
}
