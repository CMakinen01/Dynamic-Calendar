
namespace CamdenMakinenIndividualProject
{
    partial class EventEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hubEditButton = new Button();
            editID = new NumericUpDown();
            label1 = new Label();
            endTimeEdit = new DateTimePicker();
            startTimeEdit = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            eventEditButton = new Button();
            label4 = new Label();
            editDesc = new TextBox();
            label5 = new Label();
            editName = new TextBox();
            editViewBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)editID).BeginInit();
            SuspendLayout();
            // 
            // hubEditButton
            // 
            hubEditButton.ForeColor = Color.Firebrick;
            hubEditButton.Location = new Point(855, 398);
            hubEditButton.Name = "hubEditButton";
            hubEditButton.Size = new Size(117, 51);
            hubEditButton.TabIndex = 1;
            hubEditButton.Text = "Back to Hub";
            hubEditButton.UseVisualStyleBackColor = true;
            hubEditButton.Click += hubEditButton_Click;
            // 
            // editID
            // 
            editID.Location = new Point(649, 38);
            editID.Name = "editID";
            editID.Size = new Size(75, 23);
            editID.TabIndex = 3;
            editID.ValueChanged += editID_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(649, 20);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter Event ID to Edit:";
            // 
            // endTimeEdit
            // 
            endTimeEdit.Format = DateTimePickerFormat.Time;
            endTimeEdit.Location = new Point(649, 154);
            endTimeEdit.Name = "endTimeEdit";
            endTimeEdit.Size = new Size(200, 23);
            endTimeEdit.TabIndex = 5;
            endTimeEdit.ValueChanged += endTimeEdit_ValueChanged;
            // 
            // startTimeEdit
            // 
            startTimeEdit.Format = DateTimePickerFormat.Time;
            startTimeEdit.Location = new Point(649, 96);
            startTimeEdit.Name = "startTimeEdit";
            startTimeEdit.Size = new Size(200, 23);
            startTimeEdit.TabIndex = 6;
            startTimeEdit.ValueChanged += startTimeEdit_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(649, 136);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 7;
            label2.Text = "Enter New End Time:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(649, 78);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 8;
            label3.Text = "Enter New Start Time:";
            // 
            // eventEditButton
            // 
            eventEditButton.Location = new Point(649, 386);
            eventEditButton.Name = "eventEditButton";
            eventEditButton.Size = new Size(200, 63);
            eventEditButton.TabIndex = 9;
            eventEditButton.Text = "Edit Event in Calendar";
            eventEditButton.UseVisualStyleBackColor = true;
            eventEditButton.Click += eventEditButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(649, 257);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 10;
            label4.Text = "Enter New Description:";
            // 
            // editDesc
            // 
            editDesc.Location = new Point(649, 275);
            editDesc.Multiline = true;
            editDesc.Name = "editDesc";
            editDesc.Size = new Size(200, 70);
            editDesc.TabIndex = 11;
            editDesc.TextChanged += editDesc_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(649, 195);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 12;
            label5.Text = "Enter New Name:";
            // 
            // editName
            // 
            editName.Location = new Point(649, 213);
            editName.Name = "editName";
            editName.Size = new Size(200, 23);
            editName.TabIndex = 13;
            editName.TextChanged += editName_TextChanged;
            // 
            // editViewBox
            // 
            editViewBox.Enabled = false;
            editViewBox.Location = new Point(12, 20);
            editViewBox.Multiline = true;
            editViewBox.Name = "editViewBox";
            editViewBox.Size = new Size(600, 430);
            editViewBox.TabIndex = 14;
            editViewBox.TextChanged += editViewBox_TextChanged;
            // 
            // EventEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(editViewBox);
            Controls.Add(editName);
            Controls.Add(label5);
            Controls.Add(editDesc);
            Controls.Add(label4);
            Controls.Add(eventEditButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(startTimeEdit);
            Controls.Add(endTimeEdit);
            Controls.Add(label1);
            Controls.Add(editID);
            Controls.Add(hubEditButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EventEdit";
            Text = "Edit Event";
            Load += EventEdit_Load;
            ((System.ComponentModel.ISupportInitialize)editID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion

        private Button hubEditButton;
        private NumericUpDown editID;
        private Label label1;
        private DateTimePicker endTimeEdit;
        private DateTimePicker startTimeEdit;
        private Label label2;
        private Label label3;
        private Button eventEditButton;
        private Label label4;
        private TextBox editDesc;
        private Label label5;
        private TextBox editName;
        private TextBox editViewBox;
    }
}