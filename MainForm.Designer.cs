﻿namespace Furore.Fhir.ValidationDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnOpenProfileDir = new System.Windows.Forms.Button();
            this.txtProfileDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDisableFP = new System.Windows.Forms.CheckBox();
            this.lblTerminology = new System.Windows.Forms.Label();
            this.cboTerminology = new System.Windows.Forms.ComboBox();
            this.chkShowTraceInfo = new System.Windows.Forms.CheckBox();
            this.chkXsdValidation = new System.Windows.Forms.CheckBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtInstanceXml = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOutcome = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.btnOpenProfileDir);
            this.groupBox1.Controls.Add(this.txtProfileDirectory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1538, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile source directory";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1514, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = "For performance reasons, profiles in this directory will not be re-scanned at eac" +
    "h validation run. Press \'Reload\' to refresh the cached information the validator" +
    " may have.";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(18, 215);
            this.btnReload.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(150, 44);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "&Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnOpenProfileDir
            // 
            this.btnOpenProfileDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenProfileDir.Location = new System.Drawing.Point(1376, 75);
            this.btnOpenProfileDir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOpenProfileDir.Name = "btnOpenProfileDir";
            this.btnOpenProfileDir.Size = new System.Drawing.Size(150, 44);
            this.btnOpenProfileDir.TabIndex = 2;
            this.btnOpenProfileDir.Text = "&Browse...";
            this.btnOpenProfileDir.UseVisualStyleBackColor = true;
            this.btnOpenProfileDir.Click += new System.EventHandler(this.btnOpenProfileDir_Click);
            // 
            // txtProfileDirectory
            // 
            this.txtProfileDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfileDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Furore.Fhir.ValidationDemo.Properties.Settings.Default, "ProfileSourceDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtProfileDirectory.Location = new System.Drawing.Point(12, 81);
            this.txtProfileDirectory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProfileDirectory.Name = "txtProfileDirectory";
            this.txtProfileDirectory.Size = new System.Drawing.Size(1348, 31);
            this.txtProfileDirectory.TabIndex = 1;
            this.txtProfileDirectory.Text = global::Furore.Fhir.ValidationDemo.Properties.Settings.Default.ProfileSourceDirectory;
            this.txtProfileDirectory.TextChanged += new System.EventHandler(this.txtProfileDirectory_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(860, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "The validator will look for your profiles and other conformance resources in this" +
    " directory:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkDisableFP);
            this.groupBox2.Controls.Add(this.lblTerminology);
            this.groupBox2.Controls.Add(this.cboTerminology);
            this.groupBox2.Controls.Add(this.chkShowTraceInfo);
            this.groupBox2.Controls.Add(this.chkXsdValidation);
            this.groupBox2.Controls.Add(this.btnValidate);
            this.groupBox2.Controls.Add(this.txtInstanceXml);
            this.groupBox2.Location = new System.Drawing.Point(26, 337);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(1534, 540);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xml Instance";
            // 
            // chkDisableFP
            // 
            this.chkDisableFP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDisableFP.AutoSize = true;
            this.chkDisableFP.Location = new System.Drawing.Point(474, 414);
            this.chkDisableFP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkDisableFP.Name = "chkDisableFP";
            this.chkDisableFP.Size = new System.Drawing.Size(264, 29);
            this.chkDisableFP.TabIndex = 3;
            this.chkDisableFP.Text = "Disable &FirePath checks";
            this.chkDisableFP.UseVisualStyleBackColor = true;
            // 
            // lblTerminology
            // 
            this.lblTerminology.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTerminology.AutoSize = true;
            this.lblTerminology.Location = new System.Drawing.Point(1128, 413);
            this.lblTerminology.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTerminology.Name = "lblTerminology";
            this.lblTerminology.Size = new System.Drawing.Size(136, 25);
            this.lblTerminology.TabIndex = 4;
            this.lblTerminology.Text = "&Terminology:";
            // 
            // cboTerminology
            // 
            this.cboTerminology.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTerminology.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerminology.FormattingEnabled = true;
            this.cboTerminology.Items.AddRange(new object[] {
            "None",
            "Local",
            "Grahame"});
            this.cboTerminology.Location = new System.Drawing.Point(1274, 406);
            this.cboTerminology.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboTerminology.Name = "cboTerminology";
            this.cboTerminology.Size = new System.Drawing.Size(232, 33);
            this.cboTerminology.TabIndex = 5;
            // 
            // chkShowTraceInfo
            // 
            this.chkShowTraceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowTraceInfo.AutoSize = true;
            this.chkShowTraceInfo.Location = new System.Drawing.Point(18, 414);
            this.chkShowTraceInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkShowTraceInfo.Name = "chkShowTraceInfo";
            this.chkShowTraceInfo.Size = new System.Drawing.Size(198, 29);
            this.chkShowTraceInfo.TabIndex = 1;
            this.chkShowTraceInfo.Text = "&Trace information";
            this.chkShowTraceInfo.UseVisualStyleBackColor = true;
            // 
            // chkXsdValidation
            // 
            this.chkXsdValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkXsdValidation.AutoSize = true;
            this.chkXsdValidation.Location = new System.Drawing.Point(250, 414);
            this.chkXsdValidation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkXsdValidation.Name = "chkXsdValidation";
            this.chkXsdValidation.Size = new System.Drawing.Size(166, 29);
            this.chkXsdValidation.TabIndex = 2;
            this.chkXsdValidation.Text = "&Xsd validation";
            this.chkXsdValidation.UseVisualStyleBackColor = true;
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnValidate.Location = new System.Drawing.Point(18, 469);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(150, 44);
            this.btnValidate.TabIndex = 6;
            this.btnValidate.Text = "&Validate!";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtInstanceXml
            // 
            this.txtInstanceXml.AcceptsTab = true;
            this.txtInstanceXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstanceXml.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Furore.Fhir.ValidationDemo.Properties.Settings.Default, "InstanceXml", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtInstanceXml.Location = new System.Drawing.Point(18, 44);
            this.txtInstanceXml.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInstanceXml.Name = "txtInstanceXml";
            this.txtInstanceXml.Size = new System.Drawing.Size(1492, 341);
            this.txtInstanceXml.TabIndex = 0;
            this.txtInstanceXml.Text = global::Furore.Fhir.ValidationDemo.Properties.Settings.Default.InstanceXml;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtOutcome);
            this.groupBox3.Location = new System.Drawing.Point(24, 888);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(1534, 402);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Last Validation results";
            // 
            // txtOutcome
            // 
            this.txtOutcome.AcceptsTab = true;
            this.txtOutcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutcome.Location = new System.Drawing.Point(20, 38);
            this.txtOutcome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtOutcome.Multiline = true;
            this.txtOutcome.Name = "txtOutcome";
            this.txtOutcome.ReadOnly = true;
            this.txtOutcome.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutcome.Size = new System.Drawing.Size(1492, 327);
            this.txtOutcome.TabIndex = 0;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select a folder where this application can find your profiles to validate against" +
    ".";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnValidate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 1053);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = ".NET Profile Validation Demo 1.3 (STU3)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnOpenProfileDir;
        private System.Windows.Forms.TextBox txtProfileDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkXsdValidation;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.RichTextBox txtInstanceXml;
        private System.Windows.Forms.CheckBox chkShowTraceInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOutcome;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ComboBox cboTerminology;
        private System.Windows.Forms.Label lblTerminology;
        private System.Windows.Forms.CheckBox chkDisableFP;
    }
}

