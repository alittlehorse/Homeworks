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
using System.Net;
using System.Text;
using ClearCanvas.Dicom.Network;
using System.Data;
using System.Data.SqlClient;
using StanrdSqlHelper;
using System.Configuration;

namespace ClearCanvas.Dicom.Samples
{
    /// <summary>
    /// DICOM Storage SCP Sample Application
    /// </summary>
    class StorageScp : IDicomServerHandler
    {
        #region Private Members
        private static bool _started = false;
        private static String _staticStorageLocation;
        private static ServerAssociationParameters _staticAssocParameters;
        private ServerAssociationParameters _assocParameters;
        #endregion

        #region Constructors
        private StorageScp(ServerAssociationParameters assoc)
        {
            _assocParameters = assoc;
        }
        #endregion

        #region Public Properties
        public static bool Started
        {
            get { return _started; }
        }

        /// <summary>
        /// The path (directory) to store incoming images.
        /// </summary>
        public static String StorageLocation
        {
            get { return _staticStorageLocation; }
            set { _staticStorageLocation = value; }
        }

        #endregion
        
        #region Private Methods
        //进行SOP配对；
        private static void AddPresentationContexts(ServerAssociationParameters assoc)
        {
            byte pcid = assoc.AddPresentationContext(SopClass.VerificationSopClass);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.MrImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.CtImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.SecondaryCaptureImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.UltrasoundImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.UltrasoundImageStorageRetired);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.UltrasoundMultiFrameImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.UltrasoundMultiFrameImageStorageRetired);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.NuclearMedicineImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.DigitalIntraOralXRayImageStorageForPresentation);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.DigitalIntraOralXRayImageStorageForProcessing);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.DigitalMammographyXRayImageStorageForPresentation);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.DigitalMammographyXRayImageStorageForProcessing);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.DigitalXRayImageStorageForPresentation);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.DigitalXRayImageStorageForProcessing);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.ComputedRadiographyImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.GrayscaleSoftcopyPresentationStateStorageSopClass);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.KeyObjectSelectionDocumentStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.OphthalmicPhotography16BitImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.OphthalmicPhotography8BitImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.VideoEndoscopicImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.VideoMicroscopicImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.VideoPhotographicImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.VlEndoscopicImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.VlMicroscopicImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.VlPhotographicImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.VlSlideCoordinatesMicroscopicImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.XRayAngiographicBiPlaneImageStorageRetired);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.XRayAngiographicImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.XRayRadiofluoroscopicImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.XRayRadiationDoseSrStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.ChestCadSrStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.XRay3dAngiographicImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.XRay3dCraniofacialImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.EncapsulatedCdaStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.OphthalmicTomographyImageStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);
            #region 增加的FIND的SOP
            pcid = assoc.AddPresentationContext(SopClass.StudyRootQueryRetrieveInformationModelFind);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.PatientRootQueryRetrieveInformationModelFind);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.PatientRootQueryRetrieveInformationModelMove);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.StudyRootQueryRetrieveInformationModelMove);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);
            #endregion
        }
#endregion

        #region Static Public Methods
        //监听开始与否,整复制
        public static void StartListening(string aeTitle, int port)
        {
            if (_started)
                return;

            _staticAssocParameters = new ServerAssociationParameters(aeTitle, new IPEndPoint(IPAddress.Any, port));

            AddPresentationContexts(_staticAssocParameters);

            DicomServer.StartListening(_staticAssocParameters,
                delegate(DicomServer server, ServerAssociationParameters assoc) 
                {
                    return new StorageScp(assoc);
                } );

            _started = true;
        }

        public static void StopListening(int port)
        {
            if (_started)
            {
                DicomServer.StopListening(_staticAssocParameters);
                _started = false;
            }
        }
        #endregion


        #region IDicomServerHandler Members

       
        void IDicomServerHandler.OnReceiveAssociateRequest(DicomServer server, ServerAssociationParameters association)
        {
            server.SendAssociateAccept(association);
        }

        void IDicomServerHandler.OnReceiveRequestMessage(DicomServer server, ServerAssociationParameters association, byte presentationID, DicomMessage message)
        {
            //C-ECHO
            if (message.CommandField == DicomCommandField.CEchoRequest)
            {
                server.SendCEchoResponse(presentationID, message.MessageId, DicomStatuses.Success);
                return;
            }
            //C-Storage
            else if (message.CommandField == DicomCommandField.CStoreRequest)
            {
                String studyInstanceUid = null;
                String seriesInstanceUid = null;
                DicomUid sopInstanceUid;

                bool ok = message.DataSet[DicomTags.SopInstanceUid].TryGetUid(0, out sopInstanceUid);
                if (ok) ok = message.DataSet[DicomTags.SeriesInstanceUid].TryGetString(0, out seriesInstanceUid);
                if (ok) ok = message.DataSet[DicomTags.StudyInstanceUid].TryGetString(0, out studyInstanceUid);

                if (!ok)
                {
                    Logger.LogError("Unable to retrieve UIDs from request message, sending failure status.");

                    server.SendCStoreResponse(presentationID, message.MessageId, sopInstanceUid.UID,
                        DicomStatuses.ProcessingFailure);
                    return;
                }

                if (!Directory.Exists(StorageScp.StorageLocation))
                    Directory.CreateDirectory(StorageScp.StorageLocation);

                StringBuilder path = new StringBuilder();
                path.AppendFormat("{0}{1}{2}{3}{4}", StorageScp.StorageLocation, Path.DirectorySeparatorChar,
                    studyInstanceUid, Path.DirectorySeparatorChar, seriesInstanceUid);

                Directory.CreateDirectory(path.ToString());

                path.AppendFormat("{0}{1}.dcm", Path.DirectorySeparatorChar, sopInstanceUid.UID);

                DicomFile dicomFile = new DicomFile(message, path.ToString());

                dicomFile.TransferSyntaxUid = TransferSyntax.ExplicitVrLittleEndianUid;
                dicomFile.MediaStorageSopInstanceUid = sopInstanceUid.UID;
                dicomFile.ImplementationClassUid = DicomImplementation.ClassUID.UID;
                dicomFile.ImplementationVersionName = DicomImplementation.Version;
                dicomFile.SourceApplicationEntityTitle = association.CallingAE;
                dicomFile.MediaStorageSopClassUid = message.SopClass.Uid;

                dicomFile.Save(DicomWriteOptions.None);
                #region Database Insert
                String PatientsName = dicomFile.DataSet[DicomTags.PatientsName].GetString(0, "");
                String PatientId = dicomFile.DataSet[DicomTags.PatientId].GetString(0, "");
                String StudyId = dicomFile.DataSet[DicomTags.StudyId].GetString(0, "");
                String StudyTime = dicomFile.DataSet[DicomTags.StudyTime].GetString(0, "");
                String SopClassUid = dicomFile.DataSet[DicomTags.SopClassUid].GetString(0, "");

                SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@SopInstanceUid",SqlDbType.VarChar),
                new SqlParameter("@SqlClassUid",SqlDbType.VarChar),
                new SqlParameter("@Path",SqlDbType.VarChar),
                new SqlParameter("@PatientId",SqlDbType.VarChar),
                new SqlParameter("@PatientsName",SqlDbType.VarChar),
                new SqlParameter("@StudyId",SqlDbType.VarChar),
                new SqlParameter("@StudyTime",SqlDbType.VarChar),
                new SqlParameter("@StudyInstanceUid",SqlDbType.VarChar),
                new SqlParameter("@SeriesInstanceUid",SqlDbType.VarChar),
                new SqlParameter("@ImageId",SqlDbType.VarChar)
            };
                sqlParameters[0].Value = sopInstanceUid.ToString();
                sqlParameters[1].Value = SopClassUid;
                sqlParameters[2].Value = path.ToString();
                sqlParameters[3].Value = PatientId;
                sqlParameters[4].Value = PatientsName;
                sqlParameters[5].Value = StudyId;
                sqlParameters[6].Value = StudyTime;
                sqlParameters[7].Value = dicomFile.DataSet[DicomTags.StudyInstanceUid].GetString(0, "");
                sqlParameters[8].Value = dicomFile.DataSet[DicomTags.SeriesInstanceUid].GetString(0, "");
                sqlParameters[9].Value = dicomFile.DataSet[DicomTags.ImageId].GetString(0, "");
                String sql = @"INSERT INTO DICOMLIB VALUES(@SopInstanceUid,@SqlClassUid,@Path,@PatientId,@PatientsName,@StudyId,@StudyTime,@StudyInstanceUid,@SeriesInstanceUid,@ImageId)";
                SqlHelper.ExecuteNonQuery(SqlHelper.GetConnSting(), CommandType.Text, sql, sqlParameters);
                #endregion
                Logger.LogInfo("Received SOP Instance: {0} for patient {1}", sopInstanceUid, PatientsName);
                server.SendCStoreResponse(presentationID, message.MessageId,
                    sopInstanceUid.UID,
                    DicomStatuses.Success);
            }
            //C-Find
            else if (message.CommandField == DicomCommandField.CFindRequest)
            {
                //TODO:读取数据库
                //foreach(构造N+1个Message,SendCFindResponse());
                #region 找出筛选条件
                String[] Patameters = new string[4];
                Patameters[0] = message.DataSet[DicomTags.PatientId].ToString();
                Patameters[1] = message.DataSet[DicomTags.PatientsName].ToString();
                Patameters[2] = message.DataSet[DicomTags.StudyId].ToString();
                Patameters[3] = message.DataSet[DicomTags.StudyTime].ToString();
                String level = message.DataSet[DicomTags.QueryRetrieveLevel].ToString();
                String OnlyFliter = ""; Int32 i = 0;
                while (i < 4)
                {
                    if (Patameters[i] != "") { OnlyFliter = Patameters[i]; break; }
                    i++;
                }
                SqlParameter sqlParameter = null;
                String sql = "";
                if (OnlyFliter == "")
                {
                    sql = @"SELECT * FROM DICOMLIB";
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            sqlParameter = new SqlParameter("@PatientId", SqlDbType.VarChar);
                            sqlParameter.Value = OnlyFliter; sql = @"SELECT * FROM DICOMLIB WHERE PatientId=@PatientId"; break;
                        case 1:
                            sqlParameter = new SqlParameter("@PatientsName", SqlDbType.VarChar);
                            sqlParameter.Value = OnlyFliter; sql = @"SELECT * FROM DICOMLIB WHERE PatientsName=@PatientsName"; break;
                        case 2:
                            sqlParameter = new SqlParameter("@StudyId", SqlDbType.VarChar);
                            sqlParameter.Value = OnlyFliter; sql = @"SELECT * FROM DICOMLIB WHERE StudyId=@StudyId"; break;
                        case 3:
                            sqlParameter = new SqlParameter("@StudyTime", SqlDbType.VarChar);
                            sqlParameter.Value = OnlyFliter; sql = @"SELECT * FROM DICOMLIB WHERE StudyTime=@StudyTime"; break;
                    }
                }

                #endregion
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, sql, sqlParameter);
                int rows = ds.Tables[0].Rows.Count;
                DicomMessage tempMessage = message;
                for (int mi = 0; mi < rows; mi++)
                {
                    tempMessage.DataSet[DicomTags.PatientsName].SetString(0, ds.Tables[0].Rows[mi]["PatientsName"].ToString());
                    tempMessage.DataSet[DicomTags.PatientId].SetString(0, ds.Tables[0].Rows[mi]["PatientId"].ToString());
                    tempMessage.DataSet[DicomTags.StudyId].SetString(0, ds.Tables[0].Rows[mi]["StudyId"].ToString());
                    tempMessage.DataSet[DicomTags.StudyTime].SetString(0, ds.Tables[0].Rows[mi]["StudyTime"].ToString());
                    tempMessage.DataSet[DicomTags.SopInstanceUid].SetString(0, ds.Tables[0].Rows[mi]["SopInstanceUid"].ToString());
                    tempMessage.DataSet[DicomTags.SopClassUid].SetString(0, ds.Tables[0].Rows[mi]["SqlClassUid"].ToString());
                    tempMessage.DataSet[DicomTags.StudyInstanceUid].SetString(0, ds.Tables[0].Rows[mi]["StudyInstanceUid"].ToString());
                    tempMessage.DataSet[DicomTags.SeriesInstanceUid].SetString(0, ds.Tables[0].Rows[mi]["SeriesInstanceUid"].ToString());
                    tempMessage.DataSet[DicomTags.ImageId].SetString(0, ds.Tables[0].Rows[mi]["ImageId"].ToString());
                    server.SendCFindResponse(presentationID, tempMessage.MessageId, tempMessage, DicomStatuses.Pending);
                }
                server.SendCFindResponse(presentationID, tempMessage.MessageId, tempMessage, DicomStatuses.Success);
            }
            else if (message.CommandField == DicomCommandField.CMoveRequest)
            {
                //检索数据库,找到文件
                //发送
                #region 查询数据库
               
                String sql = "";
               
                String QueryRetrieveLevel = message.DataSet[DicomTags.QueryRetrieveLevel].ToString();
                SqlParameter sqlParameter = null;
                if (QueryRetrieveLevel =="PATIENT")
                {
                    sqlParameter = new SqlParameter("@PatientId", SqlDbType.VarChar);
                    sqlParameter.Value= message.DataSet[DicomTags.PatientId].ToString();
                    sql = "SELECT Path FROM DICOMLIB WHERE PatientId = @PatientId";
                  
                }
                else if (QueryRetrieveLevel == "STUDY")
                {
                    sqlParameter = new SqlParameter("@StudyInstanceUid", SqlDbType.VarChar);
                    sqlParameter.Value=message.DataSet[DicomTags.StudyInstanceUid].ToString();
                    sql = "SELECT Path FROM DICOMLIB WHERE StudyInstanceUid = @StudyInstanceUid";

                }
                else if (QueryRetrieveLevel == "SERIES")
                {
                    sqlParameter = new SqlParameter("@SeriesInstanceUid", SqlDbType.VarChar);
                    sqlParameter.Value =  message.DataSet[DicomTags.SeriesInstanceUid].ToString();
                    sql = "SELECT Path FROM DICOMLIB WHERE SeriesInstanceUid = @SeriesInstanceUid";

                }
                else if (QueryRetrieveLevel == "IMAG")
                {
                    sqlParameter = new SqlParameter("@ImageId", SqlDbType.VarChar);
                    sqlParameter.Value = message.DataSet[DicomTags.ImageId].ToString();
                    sql = "SELECT Path FROM DICOMLIB WHERE ImageId = @ImageId";
                }
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.GetConnSting(), CommandType.Text, sql, sqlParameter);

                #endregion
                DicomFile dicomFile = new DicomFile(message, message.DataSet[DicomTags.ImageId].ToString());
                String MoveDestination = message.MoveDestination.ToString();
              
                StorageScu _storagescu = new StorageScu();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        String path = ds.Tables[0].Rows[i]["Path"].ToString();
                        _storagescu.AddFileToSend(path);
                    }
                    if (MoveDestination == Samples.Properties.Settings.Default.AETs){
                        _storagescu.Send(Samples.Properties.Settings.Default.ScpAETitle, Properties.Settings.Default.AETs, Properties.Settings.Default.RemoteHost, Properties.Settings.Default.RemotePort);
                    }
                       
                }
                else {
                    Logger.LogInfo("NoFiles");
                }


            }
        }

        void IDicomServerHandler.OnReceiveResponseMessage(DicomServer server, ServerAssociationParameters association, byte presentationID, DicomMessage message)
        {
			Logger.LogError("Unexpectedly received response mess on server.");

            server.SendAssociateAbort(DicomAbortSource.ServiceUser, DicomAbortReason.UnrecognizedPDU);
        }



        void IDicomServerHandler.OnReceiveReleaseRequest(DicomServer server, ServerAssociationParameters association)
        {
			Logger.LogInfo("Received association release request from  {0}.", association.CallingAE);
        }

        void IDicomServerHandler.OnReceiveAbort(DicomServer server, ServerAssociationParameters association, DicomAbortSource source, DicomAbortReason reason)
        {
			Logger.LogError("Unexpected association abort received.");
        }

        void IDicomServerHandler.OnNetworkError(DicomServer server, ServerAssociationParameters association, Exception e)
        {
            Logger.LogErrorException(e, "Unexpected network error over association from {0}.", association.CallingAE);
        }

        void IDicomServerHandler.OnDimseTimeout(DicomServer server, ServerAssociationParameters association)
        {
            Logger.LogInfo("Received DIMSE Timeout, continuing listening for messages");
        }
        

        protected void LogAssociationStatistics(ServerAssociationParameters association)
        {

        }
        #endregion
    }
}
