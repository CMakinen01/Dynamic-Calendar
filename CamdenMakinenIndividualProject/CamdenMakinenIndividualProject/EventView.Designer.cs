namespace CamdenMakinenIndividualProject
{
    partial class EventView
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
            monthViewButton = new Button();
            weekViewButton = new Button();
            hubEVButton = new Button();
            eventViewBox = new TextBox();
            monthPicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            viewAllButton = new Button();
            SuspendLayout();
            // 
            // monthViewButton
            // 
            monthViewButton.Location = new Point(218, 627);
            monthViewButton.Name = "monthViewButton";
            monthViewButton.Size = new Size(193, 72);
            monthViewButton.TabIndex = 0;
            monthViewButton.Text = "Monthly View";
            monthViewButton.UseVisualStyleBackColor = true;
            monthViewButton.Click += monthViewButton_Click;
            // 
            // weekViewButton
            // 
            weekViewButton.Location = new Point(1314, 660);
            weekViewButton.Name = "weekViewButton";
            weekViewButton.Size = new Size(158, 39);
            weekViewButton.TabIndex = 1;
            weekViewButton.Text = "Weekly View";
            weekViewButton.UseVisualStyleBackColor = true;
            weekViewButton.Click += weekViewButton_Click;
            // 
            // hubEVButton
            // 
            hubEVButton.ForeColor = Color.Firebrick;
            hubEVButton.Location = new Point(671, 627);
            hubEVButton.Name = "hubEVButton";
            hubEVButton.Size = new Size(193, 72);
            hubEVButton.TabIndex = 2;
            hubEVButton.Text = "Back to Hub";
            hubEVButton.UseVisualStyleBackColor = true;
            hubEVButton.Click += hubEVButton_Click;
            // 
            // eventViewBox
            // 
            eventViewBox.Enabled = false;
            eventViewBox.Location = new Point(12, 12);
            eventViewBox.Multiline = true;
            eventViewBox.Name = "eventViewBox";
            eventViewBox.ReadOnly = true;
            eventViewBox.Size = new Size(1460, 609);
            eventViewBox.TabIndex = 3;
            eventViewBox.TextChanged += eventViewBox_TextChanged;
            // 
            // monthPicker
            // 
            monthPicker.Format = DateTimePickerFormat.Custom;
            monthPicker.Location = new Point(12, 660);
            monthPicker.Name = "monthPicker";
            monthPicker.ShowUpDown = true;
            monthPicker.Size = new Size(200, 23);
            monthPicker.TabIndex = 5;
            monthPicker.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            monthPicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 627);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 6;
            label1.Text = "Press Button to Display all\r\nEvents in Chosen Month:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1314, 627);
            label2.Name = "label2";
            label2.Size = new Size(158, 30);
            label2.TabIndex = 7;
            label2.Text = "Press Button to Display \r\nALL Events Ordered by Week";
            // 
            // viewAllButton
            // 
            viewAllButton.Location = new Point(1011, 627);
            viewAllButton.Name = "viewAllButton";
            viewAllButton.Size = new Size(193, 72);
            viewAllButton.TabIndex = 8;
            viewAllButton.Text = "View All";
            viewAllButton.UseVisualStyleBackColor = true;
            viewAllButton.Click += viewAllButton_Click;
            // 
            // EventView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 711);
            Controls.Add(viewAllButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(monthPicker);
            Controls.Add(eventViewBox);
            Controls.Add(hubEVButton);
            Controls.Add(weekViewButton);
            Controls.Add(monthViewButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EventView";
            Text = "View Events";
            Load += EventView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button monthViewButton;
        private Button weekViewButton;
        private Button hubEVButton;
        private TextBox eventViewBox;
        private DateTimePicker monthPicker;
        private Label label1;
        private Label label2;
        private Button viewAllButton;
    }
}