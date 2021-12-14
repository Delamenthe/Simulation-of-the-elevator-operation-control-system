namespace WindowsForms {
    partial class ConfigForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.countOfElevatorTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countOfFloorsTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maxWeightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.speedValueTextBox = new System.Windows.Forms.MaskedTextBox();
            this.accelerationValueTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.strategyRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.ruleTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Config Panel";
            // 
            // countOfElevatorTextBox
            // 
            this.countOfElevatorTextBox.Location = new System.Drawing.Point(185, 108);
            this.countOfElevatorTextBox.Mask = "000";
            this.countOfElevatorTextBox.Name = "countOfElevatorTextBox";
            this.countOfElevatorTextBox.PromptChar = ' ';
            this.countOfElevatorTextBox.Size = new System.Drawing.Size(24, 20);
            this.countOfElevatorTextBox.TabIndex = 2;
            this.countOfElevatorTextBox.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Global configuration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Count of elevators";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Count of floors";
            // 
            // countOfFloorsTextBox
            // 
            this.countOfFloorsTextBox.Location = new System.Drawing.Point(185, 134);
            this.countOfFloorsTextBox.Mask = "000";
            this.countOfFloorsTextBox.Name = "countOfFloorsTextBox";
            this.countOfFloorsTextBox.PromptChar = ' ';
            this.countOfFloorsTextBox.Size = new System.Drawing.Size(24, 20);
            this.countOfFloorsTextBox.TabIndex = 6;
            this.countOfFloorsTextBox.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Elevators settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Max weight (human)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Max speed value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Acceleration value";
            // 
            // maxWeightTextBox
            // 
            this.maxWeightTextBox.Location = new System.Drawing.Point(185, 261);
            this.maxWeightTextBox.Mask = "000";
            this.maxWeightTextBox.Name = "maxWeightTextBox";
            this.maxWeightTextBox.PromptChar = ' ';
            this.maxWeightTextBox.Size = new System.Drawing.Size(24, 20);
            this.maxWeightTextBox.TabIndex = 11;
            this.maxWeightTextBox.Text = "5";
            // 
            // speedValueTextBox
            // 
            this.speedValueTextBox.Location = new System.Drawing.Point(185, 286);
            this.speedValueTextBox.Mask = "000";
            this.speedValueTextBox.Name = "speedValueTextBox";
            this.speedValueTextBox.PromptChar = ' ';
            this.speedValueTextBox.Size = new System.Drawing.Size(24, 20);
            this.speedValueTextBox.TabIndex = 12;
            this.speedValueTextBox.Text = "3";
            // 
            // accelerationValueTextBox
            // 
            this.accelerationValueTextBox.Location = new System.Drawing.Point(185, 311);
            this.accelerationValueTextBox.Mask = "000";
            this.accelerationValueTextBox.Name = "accelerationValueTextBox";
            this.accelerationValueTextBox.PromptChar = ' ';
            this.accelerationValueTextBox.Size = new System.Drawing.Size(24, 20);
            this.accelerationValueTextBox.TabIndex = 13;
            this.accelerationValueTextBox.Text = "50";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(13, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Choice of strategy:";
            // 
            // strategyRadioButton
            // 
            this.strategyRadioButton.AutoSize = true;
            this.strategyRadioButton.Checked = true;
            this.strategyRadioButton.Location = new System.Drawing.Point(134, 167);
            this.strategyRadioButton.Name = "strategyRadioButton";
            this.strategyRadioButton.Size = new System.Drawing.Size(64, 17);
            this.strategyRadioButton.TabIndex = 15;
            this.strategyRadioButton.TabStop = true;
            this.strategyRadioButton.Text = "Min time";
            this.strategyRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(204, 167);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Min idling";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 366);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(134, 366);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 18;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(431, 394);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 19;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ruleTextBox
            // 
            this.ruleTextBox.Location = new System.Drawing.Point(279, 92);
            this.ruleTextBox.Multiline = true;
            this.ruleTextBox.Name = "ruleTextBox";
            this.ruleTextBox.Size = new System.Drawing.Size(212, 175);
            this.ruleTextBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(294, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Rules";
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel1.Location = new System.Drawing.Point(236, 270);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(300, 16);
            this.infoLabel1.TabIndex = 22;
            this.infoLabel1.Text = "/human <start floor> <end floor> <count of people>";
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel2.Location = new System.Drawing.Point(236, 286);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(198, 16);
            this.infoLabel2.TabIndex = 23;
            this.infoLabel2.Text = "/firealarm <start time> <duration>";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(540, 443);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.infoLabel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ruleTextBox);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.strategyRadioButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.accelerationValueTextBox);
            this.Controls.Add(this.speedValueTextBox);
            this.Controls.Add(this.maxWeightTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countOfFloorsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countOfElevatorTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox countOfElevatorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox countOfFloorsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maxWeightTextBox;
        private System.Windows.Forms.MaskedTextBox speedValueTextBox;
        private System.Windows.Forms.MaskedTextBox accelerationValueTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton strategyRadioButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox ruleTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Label infoLabel2;
    }
}