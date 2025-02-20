﻿using TrayToolbar.Controls;

namespace TrayToolbar
{
    partial class FolderControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderControl));
            FolderComboBox = new CustomComboBox();
            BrowseFolderButton = new PictureBox();
            DeleteFolderButton = new PictureBox();
            RecursiveCheckbox = new CheckBox();
            toolTips = new ToolTip(components);
            ErrorIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BrowseFolderButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteFolderButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).BeginInit();
            SuspendLayout();
            // 
            // FolderComboBox
            // 
            FolderComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FolderComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            FolderComboBox.AutoCompleteSource = AutoCompleteSource.FileSystemDirectories;
            FolderComboBox.DropDownStyle = ComboBoxStyle.Simple;
            FolderComboBox.FormattingEnabled = true;
            FolderComboBox.Location = new Point(3, 3);
            FolderComboBox.MaxDropDownItems = 15;
            FolderComboBox.Name = "FolderComboBox";
            FolderComboBox.Size = new Size(330, 23);
            FolderComboBox.Sorted = true;
            FolderComboBox.TabIndex = 6;
            FolderComboBox.TextUpdate += FolderComboBox_TextUpdate;
            // 
            // BrowseFolderButton
            // 
            BrowseFolderButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BrowseFolderButton.BackgroundImage = (Image)resources.GetObject("BrowseFolderButton.BackgroundImage");
            BrowseFolderButton.BackgroundImageLayout = ImageLayout.Center;
            BrowseFolderButton.Location = new Point(335, 3);
            BrowseFolderButton.Name = "BrowseFolderButton";
            BrowseFolderButton.Size = new Size(30, 23);
            BrowseFolderButton.TabIndex = 7;
            BrowseFolderButton.TabStop = false;
            BrowseFolderButton.Click += BrowseFolderButton_Click;
            // 
            // DeleteFolderButton
            // 
            DeleteFolderButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteFolderButton.BackgroundImage = (Image)resources.GetObject("DeleteFolderButton.BackgroundImage");
            DeleteFolderButton.BackgroundImageLayout = ImageLayout.Center;
            DeleteFolderButton.Location = new Point(367, 3);
            DeleteFolderButton.Name = "DeleteFolderButton";
            DeleteFolderButton.Size = new Size(30, 23);
            DeleteFolderButton.TabIndex = 8;
            DeleteFolderButton.TabStop = false;
            DeleteFolderButton.Click += DeleteFolderButton_Click;
            // 
            // RecursiveCheckbox
            // 
            RecursiveCheckbox.AutoSize = true;
            RecursiveCheckbox.Location = new Point(3, 32);
            RecursiveCheckbox.Name = "RecursiveCheckbox";
            RecursiveCheckbox.Size = new Size(124, 19);
            RecursiveCheckbox.TabIndex = 9;
            RecursiveCheckbox.Text = "Include Subfolders";
            RecursiveCheckbox.UseVisualStyleBackColor = true;
            RecursiveCheckbox.CheckedChanged += RecursiveCheckbox_CheckedChanged;
            // 
            // ErrorIcon
            // 
            ErrorIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ErrorIcon.BackColor = Color.Transparent;
            ErrorIcon.Image = (Image)resources.GetObject("ErrorIcon.Image");
            ErrorIcon.Location = new Point(313, 6);
            ErrorIcon.Margin = new Padding(0);
            ErrorIcon.Name = "ErrorIcon";
            ErrorIcon.Size = new Size(16, 16);
            ErrorIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            ErrorIcon.TabIndex = 10;
            ErrorIcon.TabStop = false;
            ErrorIcon.Visible = false;
            // 
            // FolderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(ErrorIcon);
            Controls.Add(RecursiveCheckbox);
            Controls.Add(DeleteFolderButton);
            Controls.Add(BrowseFolderButton);
            Controls.Add(FolderComboBox);
            Name = "FolderControl";
            Size = new Size(400, 60);
            ((System.ComponentModel.ISupportInitialize)BrowseFolderButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteFolderButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomComboBox FolderComboBox;
        private PictureBox BrowseFolderButton;
        private PictureBox DeleteFolderButton;
        private CheckBox RecursiveCheckbox;
        private ToolTip toolTips;
        private PictureBox ErrorIcon;
    }
}
