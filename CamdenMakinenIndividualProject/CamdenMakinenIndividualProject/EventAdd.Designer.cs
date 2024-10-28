
namespace CamdenMakinenIndividualProject
{
    partial class EventAdd
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
            hubAddButton = new Button();
            addEName = new TextBox();
            label1 = new Label();
            startTimeAdd = new DateTimePicker();
            endTimeAdd = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            eventAddButton = new Button();
            addEDesc = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // hubAddButton
            // 
            hubAddButton.ForeColor = Color.Firebrick;
            hubAddButton.Location = new Point(671, 387);
            hubAddButton.Name = "hubAddButton";
            hubAddButton.Size = new Size(117, 51);
            hubAddButton.TabIndex = 0;
            hubAddButton.Text = "Back to Hub";
            hubAddButton.UseVisualStyleBackColor = true;
            hubAddButton.Click += hubAddButton_Click;
            // 
            // addEName
            // 
            addEName.Location = new Point(12, 27);
            addEName.Name = "addEName";
            addEName.Size = new Size(238, 23);
            addEName.TabIndex = 2;
            addEName.TextChanged += addEName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter Event Name:";
            // 
            // startTimeAdd
            // 
            startTimeAdd.Format = DateTimePickerFormat.Time;
            startTimeAdd.Location = new Point(12, 87);
            startTimeAdd.Name = "startTimeAdd";
            startTimeAdd.Size = new Size(200, 23);
            startTimeAdd.TabIndex = 4;
            startTimeAdd.ValueChanged += startTimeAdd_ValueChanged;
            // 
            // endTimeAdd
            // 
            endTimeAdd.Format = DateTimePickerFormat.Time;
            endTimeAdd.Location = new Point(12, 148);
            endTimeAdd.Name = "endTimeAdd";
            endTimeAdd.Size = new Size(200, 23);
            endTimeAdd.TabIndex = 5;
            endTimeAdd.ValueChanged += endTimeAdd_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 6;
            label2.Text = "Event Start Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 7;
            label3.Text = "Event End Time:";
            // 
            // eventAddButton
            // 
            eventAddButton.Location = new Point(12, 303);
            eventAddButton.Name = "eventAddButton";
            eventAddButton.Size = new Size(200, 63);
            eventAddButton.TabIndex = 8;
            eventAddButton.Text = "Add Event to Calendar";
            eventAddButton.UseVisualStyleBackColor = true;
            eventAddButton.Click += eventAddButton_Click;
            // 
            // addEDesc
            // 
            addEDesc.Location = new Point(14, 222);
            addEDesc.Multiline = true;
            addEDesc.Name = "addEDesc";
            addEDesc.Size = new Size(200, 75);
            addEDesc.TabIndex = 9;
            addEDesc.TextChanged += addEDesc_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 204);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 10;
            label4.Text = "Event Description:";
            // 
            // EventAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(addEDesc);
            Controls.Add(eventAddButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(endTimeAdd);
            Controls.Add(startTimeAdd);
            Controls.Add(label1);
            Controls.Add(addEName);
            Controls.Add(hubAddButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EventAdd";
            Text = "Add Events";
            Load += EventAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button hubAddButton;
        private TextBox addEName;
        private Label label1;
        private DateTimePicker startTimeAdd;
        private DateTimePicker endTimeAdd;
        private Label label2;
        private Label label3;
        private Button eventAddButton;
        private TextBox addEDesc;
        private Label label4;
    }
}