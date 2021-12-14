namespace WindowsForms {
    partial class AddHumanForm {
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.countOfPeopleTextBox = new System.Windows.Forms.MaskedTextBox();
            this.startFloorTextBox = new System.Windows.Forms.MaskedTextBox();
            this.endFloorTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count of people";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start floor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End floor";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(86, 147);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // countOfPeopleTextBox
            // 
            this.countOfPeopleTextBox.Location = new System.Drawing.Point(158, 37);
            this.countOfPeopleTextBox.Mask = "000";
            this.countOfPeopleTextBox.Name = "countOfPeopleTextBox";
            this.countOfPeopleTextBox.PromptChar = ' ';
            this.countOfPeopleTextBox.Size = new System.Drawing.Size(24, 20);
            this.countOfPeopleTextBox.TabIndex = 4;
            // 
            // startFloorTextBox
            // 
            this.startFloorTextBox.Location = new System.Drawing.Point(158, 63);
            this.startFloorTextBox.Mask = "000";
            this.startFloorTextBox.Name = "startFloorTextBox";
            this.startFloorTextBox.PromptChar = ' ';
            this.startFloorTextBox.Size = new System.Drawing.Size(24, 20);
            this.startFloorTextBox.TabIndex = 5;
            // 
            // endFloorTextBox
            // 
            this.endFloorTextBox.Location = new System.Drawing.Point(158, 88);
            this.endFloorTextBox.Mask = "000";
            this.endFloorTextBox.Name = "endFloorTextBox";
            this.endFloorTextBox.PromptChar = ' ';
            this.endFloorTextBox.Size = new System.Drawing.Size(24, 20);
            this.endFloorTextBox.TabIndex = 6;
            // 
            // AddHumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 192);
            this.Controls.Add(this.endFloorTextBox);
            this.Controls.Add(this.startFloorTextBox);
            this.Controls.Add(this.countOfPeopleTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddHumanForm";
            this.Text = "AddHumanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MaskedTextBox countOfPeopleTextBox;
        private System.Windows.Forms.MaskedTextBox startFloorTextBox;
        private System.Windows.Forms.MaskedTextBox endFloorTextBox;
    }
}