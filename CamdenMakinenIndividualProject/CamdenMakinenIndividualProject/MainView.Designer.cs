
namespace CamdenMakinenIndividualProject
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileSystemWatcher1 = new FileSystemWatcher();
            viewButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(488, 12);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(300, 150);
            viewButton.TabIndex = 0;
            viewButton.Text = "View All Events";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += button1_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(12, 288);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(300, 150);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete Events";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += this.deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(488, 288);
            editButton.Name = "editButton";
            editButton.Size = new Size(300, 150);
            editButton.TabIndex = 3;
            editButton.Text = "Edit Events";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += this.editButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(300, 150);
            addButton.TabIndex = 4;
            addButton.Text = "Add Events";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addButton);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(viewButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainView";
            Text = "Main Hub";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Button viewButton;
        private Button deleteButton;
        private Button addButton;
        private Button editButton;
    }
}
