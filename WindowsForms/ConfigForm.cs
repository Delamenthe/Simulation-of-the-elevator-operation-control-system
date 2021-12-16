using System;
using System.IO;
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

        private void saveButton_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files | *.txt";
            saveFileDialog1.Title = "Save data in file";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "") {
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                StreamWriter w = new StreamWriter(fs);
                w.WriteLine(countOfElevatorTextBox.Text);
                w.WriteLine(countOfFloorsTextBox.Text);
                w.WriteLine(strategyRadioButton.Checked);
                w.WriteLine(maxWeightTextBox.Text);
                w.WriteLine(speedValueTextBox.Text);
                w.WriteLine(accelerationValueTextBox.Text);
                w.WriteLine(ruleTextBox.Text);
                
                w.Flush();
                w.Close();
            }
        }

        private void loadButton_Click(object sender, EventArgs e) {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "d:\\";
                openFileDialog.Filter = "Text Files | *.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream)) {
                        this.countOfElevatorTextBox.Text = reader.ReadLine();
                        this.countOfFloorsTextBox.Text = reader.ReadLine();

                        if (reader.ReadLine().Equals("True")) {
                            this.strategyRadioButton.Checked = true;
                        }
                        else {
                            this.strategyRadioButton.Checked = false;
                        }
                        this.maxWeightTextBox.Text = reader.ReadLine();
                        this.speedValueTextBox.Text = reader.ReadLine();
                        this.accelerationValueTextBox.Text = reader.ReadLine();
                        this.ruleTextBox.Text = reader.ReadLine();
                    }
                }
            }
        }

        private void countOfElevatorTextBox_Enter(object sender, EventArgs e) {
            if (countOfElevatorTextBox.Text == "   !   ")
                countOfElevatorTextBox.Text = "";
        }

        private void countOfElevatorTextBox_Leave(object sender, EventArgs e) {
            if (countOfElevatorTextBox.Text == "") {
                countOfElevatorTextBox.Text = "   !   ";
            }
                
        }

        private void countOfFloorsTextBox_Enter(object sender, EventArgs e) {
            if (countOfFloorsTextBox.Text == "   !   ")
                countOfFloorsTextBox.Text = "";
        }

        private void countOfFloorsTextBox_Leave(object sender, EventArgs e) {
            if (countOfFloorsTextBox.Text == "")
                countOfFloorsTextBox.Text = "   !   ";
        }

        private void maxWeightTextBox_Enter(object sender, EventArgs e) {
            if (maxWeightTextBox.Text == "   !   ")
                maxWeightTextBox.Text = "";
        }

        private void maxWeightTextBox_Leave(object sender, EventArgs e) {
            if (maxWeightTextBox.Text == "")
                maxWeightTextBox.Text = "   !   ";
        }

        private void speedValueTextBox_Enter(object sender, EventArgs e) {
            if (speedValueTextBox.Text == "   !   ")
                speedValueTextBox.Text = "";
        }

        private void speedValueTextBox_Leave(object sender, EventArgs e) {
            if (speedValueTextBox.Text == "")
                speedValueTextBox.Text = "   !   ";
        }

        private void accelerationValueTextBox_Enter(object sender, EventArgs e) {
            if (accelerationValueTextBox.Text == "   !   ")
                accelerationValueTextBox.Text = "";
        }

        private void accelerationValueTextBox_Leave(object sender, EventArgs e) {
            if (accelerationValueTextBox.Text == "")
                accelerationValueTextBox.Text = "   !   ";
        }

    }
}
