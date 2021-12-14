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
    public partial class AddHumanForm : Form, IAddHumanView {
        AddHumanPresenter presenter;
        public AddHumanForm() { 
            InitializeComponent();
            presenter = new AddHumanPresenter(this);
        }
        public void ShowErrorMessage(string message) {
            MessageBox.Show(message);
        }

        private void addButton_Click(object sender, EventArgs e) {
            presenter.CheckCorrect(countOfPeopleTextBox.Text, startFloorTextBox.Text, endFloorTextBox.Text);
                }
    }
}
