namespace CamdenMakinenIndividualProject
{
    partial class EventDelete
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
            hubDeleteButton = new Button();
            deleteViewBox = new TextBox();
            deleteButton = new Button();
            label1 = new Label();
            deleteID = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)deleteID).BeginInit();
            SuspendLayout();
            // 
            // hubDeleteButton
            // 
            hubDeleteButton.ForeColor = Color.Firebrick;
            hubDeleteButton.Location = new Point(855, 398);
            hubDeleteButton.Name = "hubDeleteButton";
            hubDeleteButton.Size = new Size(117, 51);
            hubDeleteButton.TabIndex = 1;
            hubDeleteButton.Text = "Back to Hub";
            hubDeleteButton.UseVisualStyleBackColor = true;
            hubDeleteButton.Click += hubDeleteButton_Click;
            // 
            // deleteViewBox
            // 
            deleteViewBox.Enabled = false;
            deleteViewBox.Location = new Point(12, 12);
            deleteViewBox.Multiline = true;
            deleteViewBox.Name = "deleteViewBox";
            deleteViewBox.Size = new Size(837, 426);
            deleteViewBox.TabIndex = 2;
            deleteViewBox.TextChanged += deleteViewBox_TextChanged;
            // 
            // deleteButton
            // 
            deleteButton.ForeColor = Color.Red;
            deleteButton.Location = new Point(855, 341);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(117, 51);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete Event";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(855, 28);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 4;
            label1.Text = "Choose ID to Delete:";
            // 
            // deleteID
            // 
            deleteID.Location = new Point(855, 56);
            deleteID.Name = "deleteID";
            deleteID.Size = new Size(120, 23);
            deleteID.TabIndex = 6;
            deleteID.ValueChanged += deleteID_ValueChanged;
            // 
            // EventDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(deleteID);
            Controls.Add(label1);
            Controls.Add(deleteButton);
            Controls.Add(deleteViewBox);
            Controls.Add(hubDeleteButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EventDelete";
            Text = "Delete Event";
            Load += EventDelete_Load;
            ((System.ComponentModel.ISupportInitialize)deleteID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hubDeleteButton;
        private TextBox deleteViewBox;
        private Button deleteButton;
        private Label label1;
        private NumericUpDown deleteID;
    }
}