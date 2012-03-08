﻿using System.Windows.Forms;

namespace Terminals.Forms
{
    partial class PersistenceOptionPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxPersistenceType = new System.Windows.Forms.GroupBox();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.lblConnetion = new System.Windows.Forms.Label();
            this.rbtnSqlPersistence = new System.Windows.Forms.RadioButton();
            this.rbtnFilePersistence = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBoxPersistenceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBoxPersistenceType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 328);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxPersistenceType
            // 
            this.groupBoxPersistenceType.Controls.Add(this.txtConnectionString);
            this.groupBoxPersistenceType.Controls.Add(this.lblConnetion);
            this.groupBoxPersistenceType.Controls.Add(this.rbtnSqlPersistence);
            this.groupBoxPersistenceType.Controls.Add(this.rbtnFilePersistence);
            this.groupBoxPersistenceType.Location = new System.Drawing.Point(6, 3);
            this.groupBoxPersistenceType.Name = "groupBoxPersistenceType";
            this.groupBoxPersistenceType.Size = new System.Drawing.Size(500, 322);
            this.groupBoxPersistenceType.TabIndex = 0;
            this.groupBoxPersistenceType.TabStop = false;
            this.groupBoxPersistenceType.Text = "Select where to store application data";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Enabled = false;
            this.txtConnectionString.Location = new System.Drawing.Point(53, 87);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(433, 166);
            this.txtConnectionString.TabIndex = 5;
            // 
            // lblConnetion
            // 
            this.lblConnetion.AutoSize = true;
            this.lblConnetion.Location = new System.Drawing.Point(50, 71);
            this.lblConnetion.Name = "lblConnetion";
            this.lblConnetion.Size = new System.Drawing.Size(92, 13);
            this.lblConnetion.TabIndex = 4;
            this.lblConnetion.Text = "Connection string:";
            // 
            // rbtnSqlPersistence
            // 
            this.rbtnSqlPersistence.AutoSize = true;
            this.rbtnSqlPersistence.Location = new System.Drawing.Point(25, 51);
            this.rbtnSqlPersistence.Name = "rbtnSqlPersistence";
            this.rbtnSqlPersistence.Size = new System.Drawing.Size(174, 17);
            this.rbtnSqlPersistence.TabIndex = 1;
            this.rbtnSqlPersistence.Text = "Microsoft SQL database server:";
            this.rbtnSqlPersistence.UseVisualStyleBackColor = true;
            // 
            // rbtnFilePersistence
            // 
            this.rbtnFilePersistence.AutoSize = true;
            this.rbtnFilePersistence.Checked = true;
            this.rbtnFilePersistence.Location = new System.Drawing.Point(25, 28);
            this.rbtnFilePersistence.Name = "rbtnFilePersistence";
            this.rbtnFilePersistence.Size = new System.Drawing.Size(113, 17);
            this.rbtnFilePersistence.TabIndex = 0;
            this.rbtnFilePersistence.TabStop = true;
            this.rbtnFilePersistence.Text = "Files in local profile";
            this.rbtnFilePersistence.UseVisualStyleBackColor = true;
            this.rbtnFilePersistence.CheckedChanged += new System.EventHandler(this.OnRbtnFilePersistenceCheckedChanged);
            // 
            // PersistenceOptionPanel
            // 
            this.Controls.Add(this.panel1);
            this.Name = "PersistenceOptionPanel";
            this.Size = new System.Drawing.Size(512, 328);
            this.panel1.ResumeLayout(false);
            this.groupBoxPersistenceType.ResumeLayout(false);
            this.groupBoxPersistenceType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBoxPersistenceType;
        private TextBox txtConnectionString;
        private Label lblConnetion;
        private RadioButton rbtnSqlPersistence;
        private RadioButton rbtnFilePersistence;
    }
}