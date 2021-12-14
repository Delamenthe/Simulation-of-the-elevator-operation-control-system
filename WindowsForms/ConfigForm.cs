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
    public partial class ConfigForm : Form, IConfigView {
        ConfigPresenter presenter;
        public ConfigForm() {
            InitializeComponent();
            presenter = new ConfigPresenter(this);

        }

        private void exitLabel_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void RunButton_Click(object sender, EventArgs e) {
            presenter.CheckCorrect(countOfElevatorTextBox.Text,countOfFloorsTextBox.Text, strategyRadioButton.Checked
            ,maxWeightTextBox.Text,speedValueTextBox.Text,accelerationValueTextBox.Text,ruleTextBox.Text);
            
        }

        public void Confirm() {
            this.Hide();
            SimulationForm simulationForm = new SimulationForm();
            simulationForm.Show();
        }

        public void ShowErrorMessage(string message) {
            MessageBox.Show(message);
        }

        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        
    }
}
