namespace WindowsForms {
    partial class SimulationForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hnwnhnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accelerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlHumalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHumansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShutdownButton = new System.Windows.Forms.Button();
            this.pictureBoxFloor = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(962, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simulation";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hnwnhnToolStripMenuItem,
            this.controlHumalToolStripMenuItem,
            this.fireAlarmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hnwnhnToolStripMenuItem
            // 
            this.hnwnhnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accelerateToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.showInformationToolStripMenuItem});
            this.hnwnhnToolStripMenuItem.Name = "hnwnhnToolStripMenuItem";
            this.hnwnhnToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.hnwnhnToolStripMenuItem.Text = "Control process";
            // 
            // accelerateToolStripMenuItem
            // 
            this.accelerateToolStripMenuItem.Name = "accelerateToolStripMenuItem";
            this.accelerateToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.accelerateToolStripMenuItem.Text = "Acceleration";
            this.accelerateToolStripMenuItem.Click += new System.EventHandler(this.accelerateToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // showInformationToolStripMenuItem
            // 
            this.showInformationToolStripMenuItem.Name = "showInformationToolStripMenuItem";
            this.showInformationToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showInformationToolStripMenuItem.Text = "Show information";
            this.showInformationToolStripMenuItem.Click += new System.EventHandler(this.showInformationToolStripMenuItem_Click);
            // 
            // controlHumalToolStripMenuItem
            // 
            this.controlHumalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripMenuItem,
            this.addHumansToolStripMenuItem});
            this.controlHumalToolStripMenuItem.Name = "controlHumalToolStripMenuItem";
            this.controlHumalToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.controlHumalToolStripMenuItem.Text = " Control human system";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.statusToolStripMenuItem.Text = "Show Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // addHumansToolStripMenuItem
            // 
            this.addHumansToolStripMenuItem.Name = "addHumansToolStripMenuItem";
            this.addHumansToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addHumansToolStripMenuItem.Text = "Add humans";
            this.addHumansToolStripMenuItem.Click += new System.EventHandler(this.addHumansToolStripMenuItem_Click);
            // 
            // fireAlarmToolStripMenuItem
            // 
            this.fireAlarmToolStripMenuItem.Name = "fireAlarmToolStripMenuItem";
            this.fireAlarmToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.fireAlarmToolStripMenuItem.Text = "Fire alarm";
            this.fireAlarmToolStripMenuItem.Click += new System.EventHandler(this.fireAlarmToolStripMenuItem_Click);
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.BackColor = System.Drawing.Color.OrangeRed;
            this.ShutdownButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShutdownButton.Location = new System.Drawing.Point(1800, 1006);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Size = new System.Drawing.Size(75, 23);
            this.ShutdownButton.TabIndex = 5;
            this.ShutdownButton.Text = "Shutdown";
            this.ShutdownButton.UseVisualStyleBackColor = false;
            this.ShutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);
            // 
            // pictureBoxFloor
            // 
            this.pictureBoxFloor.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFloor.InitialImage = null;
            this.pictureBoxFloor.Location = new System.Drawing.Point(470, 27);
            this.pictureBoxFloor.Name = "pictureBoxFloor";
            this.pictureBoxFloor.Size = new System.Drawing.Size(1405, 1020);
            this.pictureBoxFloor.TabIndex = 6;
            this.pictureBoxFloor.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBoxFloor);
            this.Controls.Add(this.ShutdownButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SimulationForm";
            this.Text = "SimulationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SimulationForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hnwnhnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accelerateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlHumalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireAlarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHumansToolStripMenuItem;
        private System.Windows.Forms.Button ShutdownButton;
        private System.Windows.Forms.PictureBox pictureBoxFloor;
        private System.Windows.Forms.Timer timer;
    }
}