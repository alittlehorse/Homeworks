#region License

// Copyright (c) 2006-2008, ClearCanvas Inc.
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

using System;
using System.IO;
using System.Windows.Forms;
using ClearCanvas.Dicom.Codec;

namespace ClearCanvas.Dicom.Samples
{
    public partial class SamplesForm : Form
    {
        #region Private Constants
        private const string STR_Cancel = "Cancel";
        private const string STR_Verify = "Verify";
        #endregion

		private StorageScu _storageScu = new StorageScu();
        private VerificationScu _verificationScu = new VerificationScu();

        public SamplesForm()
        {
			InitializeComponent();
            _buttonStorageScuVerify.Text = STR_Verify;

            Logger.RegisterLogHandler(this.OutputTextBox);

            if (String.IsNullOrEmpty(Properties.Settings.Default.ScpStorageFolder))
            {
                Properties.Settings.Default.ScpStorageFolder = Path.Combine(Path.GetTempPath(), "DicomImages");
            }
        }

        #region Button Click Handlers
        private void buttonStorageScuSelectFiles_Click(object sender, EventArgs e)
        {
			openFileDialogStorageScu.Multiselect = true;
			
            this.openFileDialogStorageScu.ShowDialog();

            foreach (String file in this.openFileDialogStorageScu.FileNames)
            {
                if (file != null)
                    try
                    {
                        _storageScu.AddFileToSend(file);
                    }
                    catch (FileNotFoundException ex)
                    {
                        Logger.LogErrorException(ex, "Unexpectedly cannot find file: {0}", file);
                    }
            }
            
        }

        private void buttonStorageScuConnect_Click(object sender, EventArgs e)
        {
            int port;
            if (!int.TryParse(_textBoxStorageScuRemotePort.Text,out port))
            {
                Logger.LogError("Unable to parse port number: {0}", _textBoxStorageScuRemotePort.Text);
                return;
            }


            _storageScu.Send(_textBoxStorageScuLocalAe.Text, _textBoxStorageScuRemoteAe.Text, _textBoxStorageScuRemoteHost.Text, port);
        }

        private void buttonStorageScpStartStop_Click(object sender, EventArgs e)
        {
            if (StorageScp.Started)
            {
                _buttonStorageScpStartStop.Text = "Start";
                StorageScp.StopListening(int.Parse(_textBoxStorageScpPort.Text));
            }
            else
            {
                _buttonStorageScpStartStop.Text = "Stop";
                StorageScp.StorageLocation = _textBoxStorageScpStorageLocation.Text;
                StorageScp.StartListening(_textBoxStorageScpAeTitle.Text,
                    int.Parse(_textBoxStorageScpPort.Text));

            }

        }

        private void buttonStorageScuSelectDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialogStorageScu.ShowDialog();
            if (folderBrowserDialogStorageScu.SelectedPath == null)
                return;

            _storageScu.AddDirectoryToSend(folderBrowserDialogStorageScu.SelectedPath);
        }

        private void _buttonStorageScuSelectStorageLocation_Click(object sender, EventArgs e)
        {
            folderBrowserDialogStorageScp.ShowDialog();

            _textBoxStorageScpStorageLocation.Text = folderBrowserDialogStorageScp.SelectedPath;
        }

        private void _buttonStorageScuVerify_Click(object sender, EventArgs e)
        {
            if (_buttonStorageScuVerify.Text == STR_Verify)
                StartVerify();
            else
                CancelVerify();
        }

        private void _buttonOutputClearLog_Click(object sender, EventArgs e)
        {
            OutputTextBox.Text = "";
        }

        private void _buttonStorageScuClearFiles_Click(object sender, EventArgs e)
        {
            _storageScu.ClearFiles();
        }
        #endregion

        private void StartVerify()
        {
            int port;
            if (!int.TryParse(_textBoxStorageScuRemotePort.Text, out port))
            {
                Logger.LogError("Unable to parse port number: {0}", _textBoxStorageScuRemotePort.Text);
                return;
            }
            IAsyncResult o_AsyncResult = _verificationScu.BeginVerify(_textBoxStorageScuLocalAe.Text, _textBoxStorageScuRemoteAe.Text, _textBoxStorageScuRemoteHost.Text, port, new AsyncCallback(VerifyComplete), null);
            SetVerifyButton(true);

			//QueryScu.Find(_textBoxStorageScuLocalAe.Text, _textBoxStorageScuRemoteAe.Text, _textBoxStorageScuRemoteHost.Text, port);
        }

        private void VerifyComplete(IAsyncResult ar)
        {
            VerificationResult verificationResult = _verificationScu.EndVerify(ar);
            Logger.LogInfo("Verify result: " + verificationResult.ToString());
            SetVerifyButton(false);
        }


        private void SetVerifyButton(bool running)
        {
            if (!this.InvokeRequired)
            {
                if (running)
                    _buttonStorageScuVerify.Text = STR_Cancel;
                else
                    _buttonStorageScuVerify.Text = STR_Verify;
            }
            else
            {
                this.BeginInvoke(new Action<bool>(SetVerifyButton), new object[] { running });
            }
        }

        private void CancelVerify()
        {
            _verificationScu.Cancel();
        }

    }
}