namespace ParticipantManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStripSerialization = new System.Windows.Forms.MenuStrip();
            this.binarySerializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLSerializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbNewParticipant = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lvParticipants = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStripSerialization.SuspendLayout();
            this.gbNewParticipant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripSerialization
            // 
            this.menuStripSerialization.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripSerialization.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarySerializationToolStripMenuItem,
            this.xMLSerializationToolStripMenuItem,
            this.teToolStripMenuItem});
            this.menuStripSerialization.Location = new System.Drawing.Point(0, 0);
            this.menuStripSerialization.Name = "menuStripSerialization";
            this.menuStripSerialization.Size = new System.Drawing.Size(1113, 28);
            this.menuStripSerialization.TabIndex = 0;
            this.menuStripSerialization.Text = "menuStrip1";
            // 
            // binarySerializationToolStripMenuItem
            // 
            this.binarySerializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializaToolStripMenuItem,
            this.dToolStripMenuItem});
            this.binarySerializationToolStripMenuItem.Name = "binarySerializationToolStripMenuItem";
            this.binarySerializationToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.binarySerializationToolStripMenuItem.Text = "Binary Serialization";
            // 
            // serializaToolStripMenuItem
            // 
            this.serializaToolStripMenuItem.Name = "serializaToolStripMenuItem";
            this.serializaToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.serializaToolStripMenuItem.Text = "Serialize";
            this.serializaToolStripMenuItem.Click += new System.EventHandler(this.serializaToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.dToolStripMenuItem.Text = "Deserialize";
            // 
            // xMLSerializationToolStripMenuItem
            // 
            this.xMLSerializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.xMLSerializationToolStripMenuItem.Name = "xMLSerializationToolStripMenuItem";
            this.xMLSerializationToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.xMLSerializationToolStripMenuItem.Text = "XML Serialization";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.serializeToolStripMenuItem.Text = "Serialize";
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            // 
            // teToolStripMenuItem
            // 
            this.teToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.teToolStripMenuItem.Name = "teToolStripMenuItem";
            this.teToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.teToolStripMenuItem.Text = "TextFile";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // gbNewParticipant
            // 
            this.gbNewParticipant.Controls.Add(this.btnAdd);
            this.gbNewParticipant.Controls.Add(this.dtpBirthDate);
            this.gbNewParticipant.Controls.Add(this.tbFirstName);
            this.gbNewParticipant.Controls.Add(this.tbLastName);
            this.gbNewParticipant.Controls.Add(this.lblBirthDate);
            this.gbNewParticipant.Controls.Add(this.lblFirstName);
            this.gbNewParticipant.Controls.Add(this.lblLastName);
            this.gbNewParticipant.Location = new System.Drawing.Point(17, 60);
            this.gbNewParticipant.Margin = new System.Windows.Forms.Padding(4);
            this.gbNewParticipant.Name = "gbNewParticipant";
            this.gbNewParticipant.Padding = new System.Windows.Forms.Padding(4);
            this.gbNewParticipant.Size = new System.Drawing.Size(1080, 187);
            this.gbNewParticipant.TabIndex = 1;
            this.gbNewParticipant.TabStop = false;
            this.gbNewParticipant.Text = "New Participant";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(699, 113);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(351, 57);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Participant";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(774, 52);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(265, 22);
            this.dtpBirthDate.TabIndex = 5;
            this.dtpBirthDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpBirthDate_Validating);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFirstName.Location = new System.Drawing.Point(103, 96);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(250, 22);
            this.tbFirstName.TabIndex = 4;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // tbLastName
            // 
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLastName.Location = new System.Drawing.Point(103, 49);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(250, 22);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(695, 57);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(71, 16);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Birth Date: ";
            this.lblBirthDate.Click += new System.EventHandler(this.serializaToolStripMenuItem_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 96);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 49);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 16);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name: ";
            // 
            // lvParticipants
            // 
            this.lvParticipants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvParticipants.HideSelection = false;
            this.lvParticipants.Location = new System.Drawing.Point(17, 256);
            this.lvParticipants.Margin = new System.Windows.Forms.Padding(4);
            this.lvParticipants.Name = "lvParticipants";
            this.lvParticipants.Size = new System.Drawing.Size(1079, 282);
            this.lvParticipants.TabIndex = 2;
            this.lvParticipants.UseCompatibleStateImageBehavior = false;
            this.lvParticipants.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Last Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Birth Date";
            this.columnHeader3.Width = 120;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1113, 554);
            this.Controls.Add(this.lvParticipants);
            this.Controls.Add(this.gbNewParticipant);
            this.Controls.Add(this.menuStripSerialization);
            this.MainMenuStrip = this.menuStripSerialization;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStripSerialization.ResumeLayout(false);
            this.menuStripSerialization.PerformLayout();
            this.gbNewParticipant.ResumeLayout(false);
            this.gbNewParticipant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripSerialization;
        private System.Windows.Forms.GroupBox gbNewParticipant;
        private System.Windows.Forms.ToolStripMenuItem binarySerializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLSerializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teToolStripMenuItem;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvParticipants;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

