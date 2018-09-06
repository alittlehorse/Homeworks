#region License

// Copyright (c) 2006-2007, ClearCanvas Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification, 
// are permitted provided that the following conditions are met:
//
//    * Redistributions of source code must retain the above copyright notice, 
//      this list of conditions and the following disclaimer.
//    * Redistributions in binary form must reproduce the above copyright notice, 
//      this list of conditions and the following disclaimer in the documentation 
//      and/or other materials provided with the distribution.
//    * Neither the name of ClearCanvas Inc. nor the names of its contributors 
//      may be used to endorse or promote products derived from this software without 
//      specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, 
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR 
// PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR 
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, 
// OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE 
// GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) 
// HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, 
// STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 
// ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY 
// OF SUCH DAMAGE.

#endregion

namespace ClearCanvas.Dicom.Samples
{
    partial class SamplesForm
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
            this.SamplesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SamplesTabs = new System.Windows.Forms.TabControl();
            this.StorageScuTab = new System.Windows.Forms.TabPage();
            this._buttonStorageScuClearFiles = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this._textBoxStorageScuLocalAe = new System.Windows.Forms.TextBox();
            this._buttonStorageScuVerify = new System.Windows.Forms.Button();
            this._buttonStorageScuSelectDirectory = new System.Windows.Forms.Button();
            this._buttonStorageScuConnect = new System.Windows.Forms.Button();
            this.buttonStorageScuSelectFiles = new System.Windows.Forms.Button();
            this._textBoxStorageScuRemotePort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._textBoxStorageScuRemoteHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxStorageScuRemoteAe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StorageScpTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this._buttonStorageScuSelectStorageLocation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this._buttonStorageScpStartStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._textBoxStorageScpAeTitle = new System.Windows.Forms.TextBox();
            this._textBoxStorageScpStorageLocation = new System.Windows.Forms.TextBox();
            this._textBoxStorageScpPort = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btSaveAETs = new System.Windows.Forms.Button();
            this.txPort = new System.Windows.Forms.TextBox();
            this.txHost = new System.Windows.Forms.TextBox();
            this.txAETsTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._buttonOutputClearLog = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialogStorageScu = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogStorageScp = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogStorageScu = new System.Windows.Forms.FolderBrowserDialog();
            this.SamplesSplitContainer.Panel1.SuspendLayout();
            this.SamplesSplitContainer.Panel2.SuspendLayout();
            this.SamplesSplitContainer.SuspendLayout();
            this.SamplesTabs.SuspendLayout();
            this.StorageScuTab.SuspendLayout();
            this.StorageScpTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SamplesSplitContainer
            // 
            this.SamplesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SamplesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SamplesSplitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.SamplesSplitContainer.Name = "SamplesSplitContainer";
            this.SamplesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SamplesSplitContainer.Panel1
            // 
            this.SamplesSplitContainer.Panel1.Controls.Add(this.SamplesTabs);
            this.SamplesSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // SamplesSplitContainer.Panel2
            // 
            this.SamplesSplitContainer.Panel2.Controls.Add(this._buttonOutputClearLog);
            this.SamplesSplitContainer.Panel2.Controls.Add(this.OutputTextBox);
            this.SamplesSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SamplesSplitContainer.Size = new System.Drawing.Size(1232, 681);
            this.SamplesSplitContainer.SplitterDistance = 178;
            this.SamplesSplitContainer.SplitterWidth = 5;
            this.SamplesSplitContainer.TabIndex = 0;
            // 
            // SamplesTabs
            // 
            this.SamplesTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SamplesTabs.Controls.Add(this.StorageScuTab);
            this.SamplesTabs.Controls.Add(this.StorageScpTab);
            this.SamplesTabs.Controls.Add(this.tabPage1);
            this.SamplesTabs.Location = new System.Drawing.Point(4, 0);
            this.SamplesTabs.Margin = new System.Windows.Forms.Padding(4);
            this.SamplesTabs.Name = "SamplesTabs";
            this.SamplesTabs.SelectedIndex = 0;
            this.SamplesTabs.Size = new System.Drawing.Size(1224, 174);
            this.SamplesTabs.TabIndex = 0;
            // 
            // StorageScuTab
            // 
            this.StorageScuTab.Controls.Add(this._buttonStorageScuClearFiles);
            this.StorageScuTab.Controls.Add(this.label7);
            this.StorageScuTab.Controls.Add(this._textBoxStorageScuLocalAe);
            this.StorageScuTab.Controls.Add(this._buttonStorageScuVerify);
            this.StorageScuTab.Controls.Add(this._buttonStorageScuSelectDirectory);
            this.StorageScuTab.Controls.Add(this._buttonStorageScuConnect);
            this.StorageScuTab.Controls.Add(this.buttonStorageScuSelectFiles);
            this.StorageScuTab.Controls.Add(this._textBoxStorageScuRemotePort);
            this.StorageScuTab.Controls.Add(this.label3);
            this.StorageScuTab.Controls.Add(this._textBoxStorageScuRemoteHost);
            this.StorageScuTab.Controls.Add(this.label2);
            this.StorageScuTab.Controls.Add(this._textBoxStorageScuRemoteAe);
            this.StorageScuTab.Controls.Add(this.label1);
            this.StorageScuTab.Location = new System.Drawing.Point(4, 25);
            this.StorageScuTab.Margin = new System.Windows.Forms.Padding(4);
            this.StorageScuTab.Name = "StorageScuTab";
            this.StorageScuTab.Padding = new System.Windows.Forms.Padding(4);
            this.StorageScuTab.Size = new System.Drawing.Size(1216, 145);
            this.StorageScuTab.TabIndex = 0;
            this.StorageScuTab.Text = "StorageSCU";
            this.StorageScuTab.UseVisualStyleBackColor = true;
            // 
            // _buttonStorageScuClearFiles
            // 
            this._buttonStorageScuClearFiles.Location = new System.Drawing.Point(736, 94);
            this._buttonStorageScuClearFiles.Margin = new System.Windows.Forms.Padding(4);
            this._buttonStorageScuClearFiles.Name = "_buttonStorageScuClearFiles";
            this._buttonStorageScuClearFiles.Size = new System.Drawing.Size(133, 26);
            this._buttonStorageScuClearFiles.TabIndex = 12;
            this._buttonStorageScuClearFiles.Text = "Clear Files";
            this._buttonStorageScuClearFiles.UseVisualStyleBackColor = true;
            this._buttonStorageScuClearFiles.Click += new System.EventHandler(this._buttonStorageScuClearFiles_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Local AE";
            // 
            // _textBoxStorageScuLocalAe
            // 
            this._textBoxStorageScuLocalAe.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuLocalAETitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScuLocalAe.Location = new System.Drawing.Point(12, 39);
            this._textBoxStorageScuLocalAe.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxStorageScuLocalAe.Name = "_textBoxStorageScuLocalAe";
            this._textBoxStorageScuLocalAe.Size = new System.Drawing.Size(132, 25);
            this._textBoxStorageScuLocalAe.TabIndex = 10;
            this._textBoxStorageScuLocalAe.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuLocalAETitle;
            // 
            // _buttonStorageScuVerify
            // 
            this._buttonStorageScuVerify.Location = new System.Drawing.Point(551, 94);
            this._buttonStorageScuVerify.Margin = new System.Windows.Forms.Padding(4);
            this._buttonStorageScuVerify.Name = "_buttonStorageScuVerify";
            this._buttonStorageScuVerify.Size = new System.Drawing.Size(133, 26);
            this._buttonStorageScuVerify.TabIndex = 9;
            this._buttonStorageScuVerify.Text = "Verify";
            this._buttonStorageScuVerify.UseVisualStyleBackColor = true;
            this._buttonStorageScuVerify.Click += new System.EventHandler(this._buttonStorageScuVerify_Click);
            // 
            // _buttonStorageScuSelectDirectory
            // 
            this._buttonStorageScuSelectDirectory.Location = new System.Drawing.Point(12, 94);
            this._buttonStorageScuSelectDirectory.Margin = new System.Windows.Forms.Padding(4);
            this._buttonStorageScuSelectDirectory.Name = "_buttonStorageScuSelectDirectory";
            this._buttonStorageScuSelectDirectory.Size = new System.Drawing.Size(133, 26);
            this._buttonStorageScuSelectDirectory.TabIndex = 8;
            this._buttonStorageScuSelectDirectory.Text = "Select Directory";
            this._buttonStorageScuSelectDirectory.UseVisualStyleBackColor = true;
            this._buttonStorageScuSelectDirectory.Click += new System.EventHandler(this.buttonStorageScuSelectDirectory_Click);
            // 
            // _buttonStorageScuConnect
            // 
            this._buttonStorageScuConnect.Location = new System.Drawing.Point(365, 94);
            this._buttonStorageScuConnect.Margin = new System.Windows.Forms.Padding(4);
            this._buttonStorageScuConnect.Name = "_buttonStorageScuConnect";
            this._buttonStorageScuConnect.Size = new System.Drawing.Size(133, 26);
            this._buttonStorageScuConnect.TabIndex = 7;
            this._buttonStorageScuConnect.Text = "Connect";
            this._buttonStorageScuConnect.UseVisualStyleBackColor = true;
            this._buttonStorageScuConnect.Click += new System.EventHandler(this.buttonStorageScuConnect_Click);
            // 
            // buttonStorageScuSelectFiles
            // 
            this.buttonStorageScuSelectFiles.Location = new System.Drawing.Point(187, 94);
            this.buttonStorageScuSelectFiles.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStorageScuSelectFiles.Name = "buttonStorageScuSelectFiles";
            this.buttonStorageScuSelectFiles.Size = new System.Drawing.Size(133, 26);
            this.buttonStorageScuSelectFiles.TabIndex = 6;
            this.buttonStorageScuSelectFiles.Text = "Select Files";
            this.buttonStorageScuSelectFiles.UseVisualStyleBackColor = true;
            this.buttonStorageScuSelectFiles.Click += new System.EventHandler(this.buttonStorageScuSelectFiles_Click);
            // 
            // _textBoxStorageScuRemotePort
            // 
            this._textBoxStorageScuRemotePort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemotePort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScuRemotePort.Location = new System.Drawing.Point(551, 40);
            this._textBoxStorageScuRemotePort.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxStorageScuRemotePort.Name = "_textBoxStorageScuRemotePort";
            this._textBoxStorageScuRemotePort.Size = new System.Drawing.Size(132, 25);
            this._textBoxStorageScuRemotePort.TabIndex = 5;
            this._textBoxStorageScuRemotePort.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemotePort;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remote Port";
            // 
            // _textBoxStorageScuRemoteHost
            // 
            this._textBoxStorageScuRemoteHost.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemoteHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScuRemoteHost.Location = new System.Drawing.Point(365, 40);
            this._textBoxStorageScuRemoteHost.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxStorageScuRemoteHost.Name = "_textBoxStorageScuRemoteHost";
            this._textBoxStorageScuRemoteHost.Size = new System.Drawing.Size(132, 25);
            this._textBoxStorageScuRemoteHost.TabIndex = 3;
            this._textBoxStorageScuRemoteHost.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemoteHost;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remote Host";
            // 
            // _textBoxStorageScuRemoteAe
            // 
            this._textBoxStorageScuRemoteAe.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScuRemoteAETitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScuRemoteAe.Location = new System.Drawing.Point(187, 40);
            this._textBoxStorageScuRemoteAe.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxStorageScuRemoteAe.Name = "_textBoxStorageScuRemoteAe";
            this._textBoxStorageScuRemoteAe.Size = new System.Drawing.Size(132, 25);
            this._textBoxStorageScuRemoteAe.TabIndex = 1;
            this._textBoxStorageScuRemoteAe.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScuRemoteAETitle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remote AE";
            // 
            // StorageScpTab
            // 
            this.StorageScpTab.Controls.Add(this.label6);
            this.StorageScpTab.Controls.Add(this._buttonStorageScuSelectStorageLocation);
            this.StorageScpTab.Controls.Add(this.label5);
            this.StorageScpTab.Controls.Add(this._buttonStorageScpStartStop);
            this.StorageScpTab.Controls.Add(this.label4);
            this.StorageScpTab.Controls.Add(this._textBoxStorageScpAeTitle);
            this.StorageScpTab.Controls.Add(this._textBoxStorageScpStorageLocation);
            this.StorageScpTab.Controls.Add(this._textBoxStorageScpPort);
            this.StorageScpTab.Location = new System.Drawing.Point(4, 25);
            this.StorageScpTab.Margin = new System.Windows.Forms.Padding(4);
            this.StorageScpTab.Name = "StorageScpTab";
            this.StorageScpTab.Padding = new System.Windows.Forms.Padding(4);
            this.StorageScpTab.Size = new System.Drawing.Size(1216, 145);
            this.StorageScpTab.TabIndex = 1;
            this.StorageScpTab.Text = "StorageSCP";
            this.StorageScpTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "AE Title";
            // 
            // _buttonStorageScuSelectStorageLocation
            // 
            this._buttonStorageScuSelectStorageLocation.Location = new System.Drawing.Point(943, 40);
            this._buttonStorageScuSelectStorageLocation.Margin = new System.Windows.Forms.Padding(4);
            this._buttonStorageScuSelectStorageLocation.Name = "_buttonStorageScuSelectStorageLocation";
            this._buttonStorageScuSelectStorageLocation.Size = new System.Drawing.Size(100, 26);
            this._buttonStorageScuSelectStorageLocation.TabIndex = 5;
            this._buttonStorageScuSelectStorageLocation.Text = "Select...";
            this._buttonStorageScuSelectStorageLocation.UseVisualStyleBackColor = true;
            this._buttonStorageScuSelectStorageLocation.Click += new System.EventHandler(this._buttonStorageScuSelectStorageLocation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Storage Location";
            // 
            // _buttonStorageScpStartStop
            // 
            this._buttonStorageScpStartStop.Location = new System.Drawing.Point(34, 39);
            this._buttonStorageScpStartStop.Margin = new System.Windows.Forms.Padding(4);
            this._buttonStorageScpStartStop.Name = "_buttonStorageScpStartStop";
            this._buttonStorageScpStartStop.Size = new System.Drawing.Size(100, 26);
            this._buttonStorageScpStartStop.TabIndex = 2;
            this._buttonStorageScpStartStop.Text = "Start";
            this._buttonStorageScpStartStop.UseVisualStyleBackColor = true;
            this._buttonStorageScpStartStop.Click += new System.EventHandler(this.buttonStorageScpStartStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port";
            // 
            // _textBoxStorageScpAeTitle
            // 
            this._textBoxStorageScpAeTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScpAETitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScpAeTitle.Location = new System.Drawing.Point(241, 42);
            this._textBoxStorageScpAeTitle.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxStorageScpAeTitle.Name = "_textBoxStorageScpAeTitle";
            this._textBoxStorageScpAeTitle.Size = new System.Drawing.Size(164, 25);
            this._textBoxStorageScpAeTitle.TabIndex = 6;
            this._textBoxStorageScpAeTitle.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScpAETitle;
            // 
            // _textBoxStorageScpStorageLocation
            // 
            this._textBoxStorageScpStorageLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScpStorageFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScpStorageLocation.Location = new System.Drawing.Point(671, 42);
            this._textBoxStorageScpStorageLocation.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxStorageScpStorageLocation.Name = "_textBoxStorageScpStorageLocation";
            this._textBoxStorageScpStorageLocation.Size = new System.Drawing.Size(263, 25);
            this._textBoxStorageScpStorageLocation.TabIndex = 3;
            this._textBoxStorageScpStorageLocation.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScpStorageFolder;
            // 
            // _textBoxStorageScpPort
            // 
            this._textBoxStorageScpPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClearCanvas.Dicom.Samples.Properties.Settings.Default, "ScpPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBoxStorageScpPort.Location = new System.Drawing.Point(472, 42);
            this._textBoxStorageScpPort.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxStorageScpPort.Name = "_textBoxStorageScpPort";
            this._textBoxStorageScpPort.Size = new System.Drawing.Size(132, 25);
            this._textBoxStorageScpPort.TabIndex = 1;
            this._textBoxStorageScpPort.Text = global::ClearCanvas.Dicom.Samples.Properties.Settings.Default.ScpPort;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btSaveAETs);
            this.tabPage1.Controls.Add(this.txPort);
            this.tabPage1.Controls.Add(this.txHost);
            this.tabPage1.Controls.Add(this.txAETsTitle);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1216, 145);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "AETs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btSaveAETs
            // 
            this.btSaveAETs.Location = new System.Drawing.Point(646, 58);
            this.btSaveAETs.Name = "btSaveAETs";
            this.btSaveAETs.Size = new System.Drawing.Size(90, 23);
            this.btSaveAETs.TabIndex = 6;
            this.btSaveAETs.Text = "±£´æ";
            this.btSaveAETs.UseVisualStyleBackColor = true;
            this.btSaveAETs.Click += new System.EventHandler(this.btSaveAETs_Click);
            // 
            // txPort
            // 
            this.txPort.Location = new System.Drawing.Point(229, 105);
            this.txPort.Name = "txPort";
            this.txPort.Size = new System.Drawing.Size(168, 25);
            this.txPort.TabIndex = 5;
            // 
            // txHost
            // 
            this.txHost.Location = new System.Drawing.Point(229, 63);
            this.txHost.Name = "txHost";
            this.txHost.Size = new System.Drawing.Size(168, 25);
            this.txHost.TabIndex = 4;
            // 
            // txAETsTitle
            // 
            this.txAETsTitle.Location = new System.Drawing.Point(229, 16);
            this.txAETsTitle.Name = "txAETsTitle";
            this.txAETsTitle.Size = new System.Drawing.Size(168, 25);
            this.txAETsTitle.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Port";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Host";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Title";
            // 
            // _buttonOutputClearLog
            // 
            this._buttonOutputClearLog.Location = new System.Drawing.Point(21, 4);
            this._buttonOutputClearLog.Margin = new System.Windows.Forms.Padding(4);
            this._buttonOutputClearLog.Name = "_buttonOutputClearLog";
            this._buttonOutputClearLog.Size = new System.Drawing.Size(100, 26);
            this._buttonOutputClearLog.TabIndex = 1;
            this._buttonOutputClearLog.Text = "Clear Log";
            this._buttonOutputClearLog.UseVisualStyleBackColor = true;
            this._buttonOutputClearLog.Click += new System.EventHandler(this._buttonOutputClearLog_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(4, 35);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OutputTextBox.MaxLength = 65536;
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTextBox.Size = new System.Drawing.Size(1227, 462);
            this.OutputTextBox.TabIndex = 0;
            this.OutputTextBox.WordWrap = false;
            // 
            // openFileDialogStorageScu
            // 
            this.openFileDialogStorageScu.FileName = "openFileDialogStorageScu";
            this.openFileDialogStorageScu.Filter = "DICOM files|*.dcm|All files|*.*";
            this.openFileDialogStorageScu.Title = "Open DICOM File";
            // 
            // SamplesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 681);
            this.Controls.Add(this.SamplesSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SamplesForm";
            this.Text = "ClearCanvas.Dicom.Samples";
            this.Load += new System.EventHandler(this.SamplesForm_Load);
            this.SamplesSplitContainer.Panel1.ResumeLayout(false);
            this.SamplesSplitContainer.Panel2.ResumeLayout(false);
            this.SamplesSplitContainer.Panel2.PerformLayout();
            this.SamplesSplitContainer.ResumeLayout(false);
            this.SamplesTabs.ResumeLayout(false);
            this.StorageScuTab.ResumeLayout(false);
            this.StorageScuTab.PerformLayout();
            this.StorageScpTab.ResumeLayout(false);
            this.StorageScpTab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SamplesSplitContainer;
        private System.Windows.Forms.TabControl SamplesTabs;
        private System.Windows.Forms.TabPage StorageScuTab;
        private System.Windows.Forms.TabPage StorageScpTab;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button _buttonStorageScuConnect;
        private System.Windows.Forms.Button buttonStorageScuSelectFiles;
        private System.Windows.Forms.TextBox _textBoxStorageScuRemotePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textBoxStorageScuRemoteHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxStorageScuRemoteAe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _buttonStorageScuSelectDirectory;
        private System.Windows.Forms.OpenFileDialog openFileDialogStorageScu;
        private System.Windows.Forms.Button _buttonStorageScpStartStop;
        private System.Windows.Forms.TextBox _textBoxStorageScpPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _textBoxStorageScpStorageLocation;
        private System.Windows.Forms.Button _buttonStorageScuSelectStorageLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogStorageScp;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogStorageScu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _textBoxStorageScpAeTitle;
        private System.Windows.Forms.Button _buttonStorageScuVerify;
        private System.Windows.Forms.Button _buttonOutputClearLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _textBoxStorageScuLocalAe;
        private System.Windows.Forms.Button _buttonStorageScuClearFiles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btSaveAETs;
        private System.Windows.Forms.TextBox txPort;
        private System.Windows.Forms.TextBox txHost;
        private System.Windows.Forms.TextBox txAETsTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

