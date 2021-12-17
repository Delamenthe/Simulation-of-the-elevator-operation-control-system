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
using System.Threading;
namespace WindowsForms {
    public partial class SimulationForm : Form, ISimulationView {
        SimulationPresenter presenter { get; set; }
        System.ComponentModel.ComponentResourceManager resources;
        Image elevator;
        Image wall;
        Image human;
        Image part;
        Graphics g;
        
       

        public SimulationForm() {
            InitializeComponent();
            part = new Bitmap(1420, 1020);
            g = Graphics.FromImage(part);
            resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
            elevator = new Bitmap("..\\..\\Resources\\closeElevator.png"); 
            wall = new Bitmap("..\\..\\Resources\\wall.png");
            human = new Bitmap("..\\..\\Resources\\human.png");
            presenter = new SimulationPresenter(this);
            
            presenter.AddElevator();
        }

        private void exitLabel_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void accelerateToolStripMenuItem_Click(object sender, EventArgs e) {
            AccelerationForm accelerationForm = new AccelerationForm();
            accelerationForm.Show();

        }

        private void showInformationToolStripMenuItem_Click(object sender, EventArgs e) {
            InformationForm informationForm = new InformationForm();
            informationForm.Show();
        }

        private void addHumansToolStripMenuItem_Click(object sender, EventArgs e) {
            AddHumanForm addHumanForm = new AddHumanForm();
            addHumanForm.Show();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e) {
            HumanStatusForm humanStatusForm = new HumanStatusForm();
            humanStatusForm.Show();
        }

        private void ShutdownButton_Click(object sender, EventArgs e) {
            this.Hide();
            InformationForm informationForm = new InformationForm();
            informationForm.Show();
        }

        private void SimulationForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        public void DrawFloors(int countOfFloor,int countOfElevator) {
            int sizeX = 200;
            int sizeY = 50;

            for (int i = 0; i < countOfFloor; i++) {
                for (int j = 0; j < countOfElevator; j++) {
                    g.DrawImage(wall, 0 + j * sizeX, 965 - i * (sizeY), new Rectangle(new Point(0, 0), new Size(sizeX, sizeY)), GraphicsUnit.Pixel);
                    pictureBoxFloor.Image = part;
                }
            }
        }
        public void DrawElevator(int numberElevator,double position) {
            int sizeX = 36;
            int sizeY = 50;
            g.DrawImage(elevator, 200-sizeX+numberElevator*(200),1015-sizeY*(float)position, new Rectangle(new Point(0, 0), new Size(sizeX, sizeY)), GraphicsUnit.Pixel);
            
            pictureBoxFloor.Image = part;

        }
        
        public void DrawHuman(int startFloor, double humanPosition, int humanState, int currFrame,int targetFloor) {
            int sizeX = 20;
            int sizeY = 45;
            if (humanState == 1) {
                g.DrawImage(human, (float)humanPosition * 140, 980 - (sizeY + 5) * startFloor+27, new Rectangle(new Point(sizeX * currFrame, 0), new Size(sizeX, sizeY)), GraphicsUnit.Pixel);
            }
            if (humanState == 0 || humanState == 2) {
                g.DrawImage(human, (float)humanPosition * 140, 980 - (sizeY + 5) * startFloor+27, new Rectangle(new Point(sizeX * 0, 0), new Size(sizeX, sizeY)), GraphicsUnit.Pixel);
            }
            if(humanState == 3) {
                g.DrawImage(human, (float)humanPosition * 200+140, 980 - (sizeY + 5) * startFloor + 27, new Rectangle(new Point(sizeX * currFrame, 0), new Size(sizeX, sizeY)), GraphicsUnit.Pixel);
            }
            if (humanState == 6) {
                g.DrawImage(human, (float)humanPosition * 200-25, 980 - (sizeY + 5) * targetFloor + 27, new Rectangle(new Point(sizeX * currFrame, 45), new Size(sizeX, sizeY)), GraphicsUnit.Pixel);
            }
            pictureBoxFloor.Image = part;
            
            
           
        }

        private void timer_Tick(object sender, EventArgs e) {
            presenter.TimeSet();
            presenter.AddFloors();
            presenter.AddElevator();
            presenter.AddHuman();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e) {
            presenter.Pause();
        }

        private void fireAlarmToolStripMenuItem_Click(object sender, EventArgs e) {
            presenter.FireAlarm();
        }
    }
}
