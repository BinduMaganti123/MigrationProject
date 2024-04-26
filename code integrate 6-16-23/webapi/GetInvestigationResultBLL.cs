using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using TCS.DigitalIPHospitalService.DAL;
using TCS.DigitalIPHospitalService.DataContracts;
using TCS.DigitalIPHospitalService.DataContracts.IP_COMMON;
using TCS.DigitalIPHospitalService.Utility;
using OutboundlayerDigital;
using OHCProxy;


namespace TCS.DigitalIPHospitalService.BLL
{
    public class GetInvestigationResultBLL
    {


        /// <summary>
        /// The call to get details on Page Load for Raise - Investigation Order
        /// </summary>
        /// <param name="invOrder"></param>
        /// <returns></returns>
        public FavouriteList GetFavListBLL(string LoginId, string LocationId, string Age, string gender)
        {
            FavouriteList objFav = new FavouriteList();
            FavList objFavList = new FavList();
            List<FavList> favList = new List<FavList>();
            GetInvestigationResultDAL objGetInvestOrderDAL = new GetInvestigationResultDAL();
            DataSet dsService;
            int count = 0;
            try
            {
                #region GetFavList

                ResultSet rsGetFav = objGetInvestOrderDAL.GetFavListDAL(LoginId, LocationId);
                DataTable dsGetFav = rsGetFav.dsResult.Tables[0];
                List<AliasL> alias = new List<AliasL>();

                DataTable dtUniqueFavDetails = dsGetFav.DefaultView.ToTable(true, BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_LISTID, BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_EMPLOEYEID, BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_SERVICE_ALIASNAME);
                foreach (DataRow drRow in dtUniqueFavDetails.Rows)
                {
                    count = 0;
                    AliasL objAliasL = new AliasL();
                    objAliasL.AliasName = Convert.ToString(drRow[BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_SERVICE_ALIASNAME]);
                    objAliasL.ListId = Convert.ToInt32(drRow[BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_LISTID]);
                    objAliasL.LoginId = Convert.ToString(drRow[BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_EMPLOEYEID]);

                    DataRow[] drSelectedList = dsGetFav.Select("LISTID=" + objAliasL.ListId);

                    if (drSelectedList.Length > 0)
                    {
                        List<ServiceList> serviceList = new List<ServiceList>();
                        foreach (DataRow r in drSelectedList)
                        {

                            ServiceList objService = new ServiceList();
                            objService.ServiceId = Convert.ToString(r["ServiceId"]);
                            objService.ServiceName = Convert.ToString(r["ServiceName"]);
                            objService.LocationEnabled = Convert.ToString(r["LocationEnabled"]);
                            if (objService.LocationEnabled == "YES")
                            {
                                count++;
                            }
                            serviceList.Add(objService);
                        }
                        objAliasL.Service = serviceList;
                        if (count > 0)
                            objAliasL.Enable = true;
                        //bool exist = serviceList.Exists(S => S.ServiceId == Convert.ToString(r[BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_SERVICE_ID]));
                        //    if (!exist)
                        //    {
                        //    if (Convert.ToString(drRow[BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_SERVICE_ALIASNAME]) == Convert.ToString(r[BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_SERVICE_ALIASNAME]) &&
                        //    Convert.ToString(drRow[BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_LISTID]) == Convert.ToString(r[BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_LISTID]))
                        //        {
                        //        if (!r["Service"].Equals(DBNull.Value))
                        //        {

                        //            //dsService = BindReferralDetails(Convert.ToString(r["Service"]));

                        //            //if (dsService.Tables.Count > 1 && dsService.Tables[1].Rows.Count > 0)
                        //            //{

                        //            //        foreach (DataRow dr in dsService.Tables[1].Rows)
                        //            //        {
                        //            //            ServiceList objServiceList = new ServiceList();
                        //            //            objServiceList.Schedule = Convert.ToString(dr["Schedule"]);
                        //            //            objServiceList.Prerequisite = Convert.ToString(dr["Prerequisite"]);
                        //            //            objServiceList.PEM = Convert.ToString(dr["PEM"]);
                        //            //            objServiceList.LocationId = Convert.ToString(dr["LocationID"]);
                        //            //            objServiceList.BillStatus = Convert.ToString(dr["BillStatus"]);
                        //            //            objServiceList.MethodId = Convert.ToString(dr["MethodId"]);
                        //            //            objServiceList.ContainerId = Convert.ToString(dr["ContainerId"]);
                        //            //            objServiceList.EmployeeId = Convert.ToString(dr["EmployeeId"]);
                        //            //            objServiceList.Group = Convert.ToString(dr["Group"]);
                        //            //            objServiceList.RequestTestId = Convert.ToString(dr["RequestTestId"]);
                        //            //            objServiceList.ServiceType = Convert.ToString(dr["ServiceType"]);
                        //            //            objServiceList.ConsentTaken = Convert.ToString(dr["ConsentTaken"]);
                        //            //            objServiceList.ConsentPath = Convert.ToString(dr["ConsentPath"]);
                        //            //            objServiceList.ServiceId = Convert.ToString(dr["ServiceId"]);
                        //            //            objServiceList.ServiceName = Convert.ToString(dr["ServiceName"]);
                        //            //            objServiceList.ServiceCode = Convert.ToString(dr["ServiceCode"]);
                        //            //            objServiceList.RecurringTest = Convert.ToString(dr["RecurringTest"]);
                        //            //            objServiceList.Frequency = Convert.ToString(dr["Frequency"]);
                        //            //            objServiceList.NoOfDays = Convert.ToString(dr["NoOfDays"]);
                        //            //            objServiceList.NoOfTimesDay = Convert.ToString(dr["NoOfTimesDay"]);
                        //            //            objServiceList.TotalNoOfTimes = Convert.ToString(dr["TotalNoOfTimes"]);
                        //            //            objServiceList.Consent = Convert.ToString(dr["Consent"]);
                        //            //            objServiceList.Priority = Convert.ToString(dr["Priority"]);
                        //            //            //objServiceList.DepartmentId = Convert.ToString(dr["DepartmentId"]);
                        //            //            objServiceList.TestStatus = Convert.ToString(dr["TestStatus"]);
                        //            //            objServiceList.PreferredCollectionSource = Convert.ToString(dr["PreferredCollectionSource"]);
                        //            //            objServiceList.SpecimenType = Convert.ToString(dr["SpecimenType"]);
                        //            //            objServiceList.Age = Convert.ToString(dr["Age"]);
                        //            //            objServiceList.LocationEnabled = Convert.ToString(r["LocationEnabled"]);
                        //            //            serviceList.Add(objServiceList);
                        //            //        }
                        //            //        objAliasL.Service = serviceList;

                        //            //}
                        //        }
                        //        alias.Add(objAliasL);
                        //    }


                        //    //objFavList.Service = Convert.ToString(dr["Service"]);                                                
                        //    //favList.Add(alias);
                        //}

                    }
                    alias.Add(objAliasL);

                }
                objFavList.aliasL = alias;
                favList.Add(objFavList);
                objFav.favList = favList;
                #endregion

                #region Referral Doctor
                //FavouriteList objGetRefDoc = new FavouriteList();
                //GetRefDoc objGetRefDoc = new GetRefDoc();
                GetInvestigationResultDAL objInvOrderDAL = new GetInvestigationResultDAL();
                ResultSet rsGetRefDoc = objInvOrderDAL.GetRefDocDAL(LocationId);
                DataTable dsGetRefDoc = rsGetRefDoc.dsResult.Tables[0];
                if (dsGetRefDoc.Rows.Count > 0)
                {
                    List<GetRefDocList> GetRefDocList = new List<GetRefDocList>();
                    foreach (DataRow dr in dsGetRefDoc.Rows)
                    {
                        GetRefDocList objGetRefDocList = new GetRefDocList();
                        if (dr["EMPLOYEEID"] != DBNull.Value)
                        {
                            objGetRefDocList.EmpId = Convert.ToInt32(dr["EMPLOYEEID"]);
                        }
                        objGetRefDocList.TitleType = Convert.ToString(dr["TITLETYPE"]);
                        objGetRefDocList.DocName = Convert.ToString(dr["DoctorName"]);
                        if (dr["SPECIALITYID"] != DBNull.Value)
                        {
                            objGetRefDocList.SpecId = Convert.ToInt32(dr["SPECIALITYID"]);
                        }
                        objGetRefDocList.SpecName = Convert.ToString(dr["SPECIALITYNAME"]);
                        GetRefDocList.Add(objGetRefDocList);
                    }
                    objFav.RefDocList = GetRefDocList;
                }
                #endregion

                #region  Get Lab Service details
                FavouriteList objLabService = new FavouriteList();
                IPDashboardDAL objDAL = new IPDashboardDAL();
                ResultSet ResultSet_IP = objInvOrderDAL.GetLabParameterDAL(LocationId, Age, gender);
                DataTable dtResultTable = ResultSet_IP.dsResult.Tables[0];
                List<LabDeptServiceList> labDeptSer = new List<LabDeptServiceList>();
                dtResultTable.DefaultView.Sort = "TESTNAME";

                foreach (DataRow dripnumber in dtResultTable.Rows)
                {
                    LabDeptServiceList Obj_IPServiceList = new LabDeptServiceList();
                    Obj_IPServiceList.TestId = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_TESTID]);
                    Obj_IPServiceList.TestName = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_TESTNAME]);
                    Obj_IPServiceList.ServiceTypeId = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_SERVICETYPEID]);
                    Obj_IPServiceList.DepartmentId = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_DEPARTMENTID]);
                    Obj_IPServiceList.ServiceCode = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_SERVICECODE]);
                    Obj_IPServiceList.DeptName = Ageformat(Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_DEPARTMENTNAME]));
                    Obj_IPServiceList.TestCode = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_TESTCODE]);
                    Obj_IPServiceList.DeptLoc = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_DEPARTMENTLOCATION]);
                    if (Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_CONSENT]) == "N")
                        Obj_IPServiceList.Consent = "NA";
                    else
                        Obj_IPServiceList.Consent = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_CONSENT]);
                    if (Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_PEMREQUIRED]) == "N")
                        Obj_IPServiceList.PEMRequired = "NA";
                    else
                        Obj_IPServiceList.PEMRequired = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_PEMREQUIRED]);
                    //Obj_IPServiceList.PEM = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_PEM]);
                    Obj_IPServiceList.Prerequisite = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_PREREQUISITE]);
                    if (Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_SCHEDULE]) == "N")
                        Obj_IPServiceList.Schedule = "NA";
                    else
                        Obj_IPServiceList.Schedule = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_SCHEDULE]);
                    Obj_IPServiceList.GenderApplicability = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_GENDERAPPLICABILITY]);
                    Obj_IPServiceList.ApplicabilityId = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_APPLICABILITYID]);
                    Obj_IPServiceList.ServiceType = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_SERVICETYPE]);
                    Obj_IPServiceList.ServiceId = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_SERVICEID]);
                    //Obj_IPServiceList.TestId = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_TESTID]);
                    Obj_IPServiceList.SpecimenId = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_SPECIMENID]);
                    Obj_IPServiceList.SpecimenName = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_SPECIMENNAME]);
                    Obj_IPServiceList.RecurringTest = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_RECURRINGTEST]);
                    Obj_IPServiceList.ConsentTaken = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_CONSENTTAKEN]);
                    Obj_IPServiceList.AcceptanceCriteria = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_ACCEPTANCECRITERIA]);
                    Obj_IPServiceList.ContainerTypeId = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_CONTAINERTYPEID]);
                    Obj_IPServiceList.ContainerTypeName = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_CONTAINERTYPENAME]);
                    Obj_IPServiceList.QuantityOfSample = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_QUANTITYOFSAMPLE]);
                    Obj_IPServiceList.QuantityOfSample1 = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_QUANTITYOFSAMPLE1]);
                    Obj_IPServiceList.ExpectionComplTime = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_EXPECTEDTIMEOFCOMPLETION]);
                    Obj_IPServiceList.DisplayInLabReception = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_DISPLAYINLABRECEPTION]);
                    Obj_IPServiceList.TypeOfProcessing = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_TYPEOFPROCESSING]);
                    Obj_IPServiceList.TypeOfMethodology = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_TYPEOFMETHODOLOGY]);
                    Obj_IPServiceList.MethodologyName = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_METHODOLGYTYPENAME]);
                    Obj_IPServiceList.ProcessingType = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_PROCESSINGTYPE]);
                    Obj_IPServiceList.TimeDependency = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_TIMEDEPENDENCY]);
                    Obj_IPServiceList.EquipmentName = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_EQUIPMENTNAME]);
                    Obj_IPServiceList.SpecimenCategory = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_SPECIMENCATEGORY]);
                    Obj_IPServiceList.NABL = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_NABL]);
                    Obj_IPServiceList.Comments = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_COMMENTS]);
                    Obj_IPServiceList.ChartId = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_CHARTID]);
                    Obj_IPServiceList.SubDeptId = Convert.ToString(dripnumber[BLLCONSTANTS.P_GETLABDEPARTMENTSERVICE.CUR_OUT_SUBDEPARTMENTID]);

                    labDeptSer.Add(Obj_IPServiceList);

                }

                objFav.labDeptService = labDeptSer;


                #endregion
            }
            catch (Exception ex)
            {
                objFav.Debug_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                objFav.Debug_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetFavList " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetFavList " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return objFav;
        }

        public LabFavorites GetLabFavorite(string LoginId, string LocationId)
        {
            int count = 0;
            LabFavorites objFav = new LabFavorites();
            FavList objFavList = new FavList();
            List<FavList> favList = new List<FavList>();
            GetInvestigationResultDAL objGetInvestOrderDAL = new GetInvestigationResultDAL();

            try
            {
                ResultSet rsGetFav = objGetInvestOrderDAL.GetFavListDAL(LoginId, LocationId);
                DataTable dsGetFav = rsGetFav.dsResult.Tables[0];
                List<AliasL> alias = new List<AliasL>();

                DataTable dtUniqueFavDetails = dsGetFav.DefaultView.ToTable(true, BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_LISTID, BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_EMPLOEYEID, BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_SERVICE_ALIASNAME);
                foreach (DataRow drRow in dtUniqueFavDetails.Rows)
                {
                    count = 0;
                    AliasL objAliasL = new AliasL();
                    objAliasL.AliasName = Convert.ToString(drRow[BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_SERVICE_ALIASNAME]);
                    objAliasL.ListId = Convert.ToInt32(drRow[BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_LISTID]);
                    objAliasL.LoginId = Convert.ToString(drRow[BLLCONSTANTS.DG_GETIPLABFAVOURITESLIST.CUR_OUT_COLUMN_EMPLOEYEID]);

                    DataRow[] drSelectedList = dsGetFav.Select("LISTID=" + objAliasL.ListId);

                    if (drSelectedList.Length > 0)
                    {
                        List<ServiceList> serviceList = new List<ServiceList>();
                        foreach (DataRow r in drSelectedList)
                        {

                            ServiceList objService = new ServiceList();
                            objService.ServiceId = Convert.ToString(r["ServiceId"]);
                            objService.ServiceName = Convert.ToString(r["ServiceName"]);
                            objService.LocationEnabled = Convert.ToString(r["LocationEnabled"]);
                            if (objService.LocationEnabled == "YES")
                            {
                                count++;
                            }
                            serviceList.Add(objService);
                        }
                        objAliasL.Service = serviceList;
                        if (count > 0)
                            objAliasL.Enable = true;


                    }
                    alias.Add(objAliasL);

                }
                objFavList.aliasL = alias;
                favList.Add(objFavList);
                objFav.favList = favList;

                objFav.Debug_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                objFav.Debug_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                objFav.Debug_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                objFav.Debug_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetFavList " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetFavList " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return objFav;
        }
        public DataSet BindReferralDetails(string ReferralDetails)
        {
            XmlDocument ReferralDetails_Xml = new XmlDocument();
            DataSet ds = new DataSet();
            byte[] objBytes = null;
            try
            {
                if (ReferralDetails.Trim().Equals("<Services/>"))
                {
                    ReferralDetails = "";
                }
                if (ReferralDetails != string.Empty)
                {
                    ReferralDetails_Xml.InnerXml = ReferralDetails;
                    objBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(ReferralDetails_Xml.OuterXml);
                    MemoryStream objMemoryStream = new MemoryStream(objBytes);
                    ds.ReadXml(objMemoryStream, XmlReadMode.InferSchema);
                    objMemoryStream.Close();
                }
                return ds;
            }
            catch (Exception objException)
            {
                LogWriter.Error("Exception occured in OP PDF   bind referrral details" + objException.Message, "DETAILED_GOPD_OPHISTORY");
                LogWriter.Error("Exception occured in OP PDF  bind referral details" + objException.StackTrace, "ERROR_GOPD_OPHISTORY");
                //WardsUtility.Log("In OPServiceRequestsReport BindReferralDetails Message : " + objException.ToString());
                return null;
            }
            finally
            {
                ReferralDetails_Xml = null;
                if ((ds != null))
                    ds.Dispose();
                objBytes = null;
            }
        }
        private string Ageformat(string dob)
        {
            DateTime dtDOB;
            string ageformat = string.Empty;
            try
            {
                if (!DateTime.TryParse(dob, out dtDOB))
                {
                    dtDOB = DateTime.Now;
                }
                //DateTime birth = new DateTime(2016, 9, 29);
                DateTime today = DateTime.Now;
                TimeSpan span = today - dtDOB;
                DateTime age = DateTime.MinValue + span;

                // Make adjustment due to MinValue equalling 1/1/1
                int Years = age.Year - 1;
                int Months = age.Month - 1;
                int Days = age.Day - 1;

                if (Years > 5)
                {
                    ageformat = String.Format("{0} Years", Years);
                }
                else if (Years <= 5 && Years >= 1)
                {
                    if (Years == 1)
                    {
                        ageformat = String.Format("{0} Yr,{1} M", Years, Months);
                    }
                    else
                    {
                        ageformat = String.Format("{0} Yrs,{1} M", Years, Months);
                    }
                }
                else if (Years < 1 && Months > 3)
                {
                    ageformat = String.Format("{0} Months", Months);
                }
                else if (Years < 1 && Months <= 3 && Months != 0)
                {
                    ageformat = String.Format("{0} M,{1} Days", Months, Days);
                }
                else
                {
                    ageformat = String.Format("{0} Days", Days);
                }
            }
            catch (Exception ex_ip)
            {
                LogWriter.Error("Exception occured in Ageformat BLL " + ex_ip.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in Ageformat BLL" + ex_ip.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex_ip);
            }
            return ageformat;
        }


        /// <summary>
        /// To Add Fvorites in LAB
        /// </summary>
        /// <param name="favList"></param>
        /// <returns></returns>
        public LabFavorites PostFavList(AliasL alias)
        {
            InsertResultSet objInsertResultSet = new InsertResultSet();
            LabFavorites objFavorites = new LabFavorites();
            try
            {
                GetInvestigationResultDAL objGetInvestOrderDAL = new GetInvestigationResultDAL();

                string xmlFavService = "<AddToFavoriteRequest><AddToFavorite ListId=''" + alias.ListId + "'' LoginId=''" + alias.LoginId + "'' AliasName=''" + alias.AliasName + "''/><Services ServiceType=''0'' LRN=''0'' ServiceCode=''0'' ServiceId=''0''>";
                string innerService = string.Empty;
                foreach (ServiceList service in alias.Service)
                {
                    innerService = string.Concat("<Service Schedule=''", service.Schedule, "'' Prerequisite=''", service.Prerequisite, "'' PEM=''", service.PEM, "'' LocationID=''", service.LocationId, "'' BillStatus=''", service.BillStatus, "'' MethodId=''", service.MethodId, "'' ContainerID=''", service.ContainerId, "'' EmployeeID=''", service.EmployeeId, "'' Group=''", service.Group, "'' RequestTestID=''", service.RequestTestId, "'' ServiceType=''", service.ServiceType, "'' ConsentTaken=''", service.ConsentTaken, "'' ConsentPath=''" + service.ConsentPath + "'' ServiceID=''" + service.ServiceId + "'' ServiceName=''" + service.ServiceName + "'' ServiceCode=''" + service.ServiceCode + "'' RecurringTest=''" + service.RecurringTest + "'' Frequency=''" + service.Frequency + "'' NoOfDays=''" + service.NoOfDays + "'' NoOfTimesDay=''" + service.NoOfTimesDay + "'' TotalNoOfTimes=''" + service.TotalNoOfTimes + "'' Consent=''" + service.Consent + "'' Priority=''" + service.Priority + "'' DepartmentId=''" + service.DepartmentId + "'' TestStatus=''" + service.TestStatus + "'' PreferredCollectionSource=''" + service.PreferredCollectionSource + "'' SpecimenType=''" + service.SpecimenType + "'' Age=''" + service.Age + "''><MaterialUsed/></Service>");

                }

                xmlFavService = string.Concat(xmlFavService, innerService, "</Services></AddToFavoriteRequest>");
                objInsertResultSet = objGetInvestOrderDAL.PostFavListDAL(xmlFavService);
                if (objInsertResultSet.Err_Msg == CONSTANTS.DEBUG_SUCCESS_MESSAGE)
                {
                    objFavorites = GetLabFavorite(alias.LoginId, alias.LocationId);
                }
            }
            catch (Exception exIp)
            {
                objFavorites.Debug_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                objFavorites.Debug_Msg = exIp.Message;
                LogWriter.Error("Exception occured in PostFavList " + exIp.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in PostFavList " + exIp.StackTrace, "ERROR_GOPD_IPPATIENT");
            }
            return objFavorites;
        }

        public ResultSet RaiseLabRequest(RaiseLabRequest objRaise)
        {

            ResultSet rsRaise = new ResultSet();
            Int64 requestno = 0;
            try
            {
                string xmlPrimaryTag = "<RaiseRequestRequest><RaiseRequest RequestType='1' LocationID='" + objRaise.locationid + "' PatientService='IP' UHID='" + objRaise.uhid + "' ClinicalDiagnosis='' AdvisedBy='' PastHistory='' ReferredBy='" + objRaise.ReferalDoctorID + "' Remarks='' PrefDateOfSampleCollection='" + objRaise.prefdateofcollection + "' PrefTimeOfSampleCollection='" + objRaise.preftimeofcollection + "' SiteOfSample='' CountryId='' State='' District='' City='' AddressLine1='' AddressLine2='' PinCode='' PhoneNumber='' ApolloHospital='' CollectionCenter='' ModeOfDispatchResult='0' ExpectedTimeOfReporting='' AgencyId='0' RequestedPerson='' CampId='0' PRN='' PatientServiceNo='" + objRaise.ipnumber + "' ADMISSIONNO='0' HighRiskHIV='N' SendSMS='' Attendant_Doctor_No='' MobileNo='' PatientName=''/>";
                string Service_list = string.Empty;
                foreach (SaveServiceRequest service in objRaise.saveservicedetails)
                {
                    if (service.servicetype == "3")
                    {
                        ResultSet rsInclusionItems = new ResultSet();

                        DataTable dtSingleservicetypeid = new DataTable();
                        DataTable dtprofileservicetypeid = new DataTable();
                        GetInvestigationResultDAL objGetInvestOrder_DAL = new GetInvestigationResultDAL();
                        rsInclusionItems = objGetInvestOrder_DAL.GetProfileInclusionTests(service.serviceid, objRaise.locationid);
                        if (rsInclusionItems.dsResult.Tables[0].Rows.Count > 0)
                        {
                            dtSingleservicetypeid = rsInclusionItems.dsResult.Tables[0].Clone();
                            dtprofileservicetypeid = rsInclusionItems.dsResult.Tables[0].Clone();
                            foreach (DataRow dr in rsInclusionItems.dsResult.Tables[0].Rows)
                            {
                                if (dr["SERVICETYPEID"].ToString() == "3")
                                {
                                    DataRow drProfile = dtprofileservicetypeid.NewRow(); drProfile.ItemArray = dr.ItemArray;
                                    dtprofileservicetypeid.Rows.Add(drProfile);
                                    dtprofileservicetypeid.AcceptChanges();
                                }
                                else
                                {
                                    DataRow drSingle = dtSingleservicetypeid.NewRow(); drSingle.ItemArray = dr.ItemArray;
                                    dtSingleservicetypeid.Rows.Add(drSingle);
                                    dtSingleservicetypeid.AcceptChanges();
                                }
                                //  Service_list = string.Concat(Service_list, "<Service ServiceID='" + dr["SERVICEID"].ToString() + "' RecurringTest='0' ServiceCode='" + dr["PACKAGEID"].ToString() + "' ServiceType='" + service.servicetype + "' Frequency='" + service.Frequency + "' NoOfDays='" + service.NoOfDays + "' NoOfTimesDay='" + service.NoOfTimesDay + "' TotalNoOfTimes='" + service.TotalNoOfTimes + "' ConsentPath='" + service.ConsentPath + "' ConsentTaken='0' Priority='" + service.Priority + "' QuantityOfSample=' ' PreferredCollectionSource='" + service.PreferredCollectionSource + "' Comments='" + service.Comments + "' RecurStartDateTime='" + service.RecurStartDateTime + "' Units=''></Service>");
                            }
                        }
                        if (dtprofileservicetypeid.Rows.Count > 0)
                        {
                            foreach (DataRow drp in dtprofileservicetypeid.Rows)
                            {
                                ResultSet rsInsideinclusionItems = new ResultSet();
                                rsInsideinclusionItems = objGetInvestOrder_DAL.GetProfileInclusionTests(drp["SERVICEID"].ToString(), objRaise.locationid);
                                foreach (DataRow dr in rsInsideinclusionItems.dsResult.Tables[0].Rows)
                                {
                                    DataRow drSingle = dtSingleservicetypeid.NewRow(); drSingle.ItemArray = dr.ItemArray;
                                    dtSingleservicetypeid.Rows.Add(drSingle);
                                    dtSingleservicetypeid.AcceptChanges();
                                }

                            }
                        }

                        foreach (DataRow drs in dtSingleservicetypeid.Rows)
                        {
                            Service_list = string.Concat(Service_list, "<Service ServiceID='" + drs["SERVICEID"].ToString() + "' RecurringTest='0' ServiceCode='" + drs["PACKAGEID"].ToString() + "' ServiceType='" + service.servicetype + "' Frequency='" + service.Frequency + "' NoOfDays='" + service.NoOfDays + "' NoOfTimesDay='" + service.NoOfTimesDay + "' TotalNoOfTimes='" + service.TotalNoOfTimes + "' ConsentPath='" + service.ConsentPath + "' ConsentTaken='0' Priority='" + service.Priority + "' QuantityOfSample='' PreferredCollectionSource='" + service.PreferredCollectionSource + "' Comments='" + service.Comments + "' RecurStartDateTime='" + service.RecurStartDateTime + "' Units=''></Service>");
                        }

                    }
                    else
                    {
                        Service_list = string.Concat(Service_list, "<Service ServiceID='" + service.serviceid + "' RecurringTest='0' ServiceCode='" + service.servicecode + "' ServiceType='" + service.servicetype + "' Frequency='" + service.Frequency + "' NoOfDays='" + service.NoOfDays + "' NoOfTimesDay='" + service.NoOfTimesDay + "' TotalNoOfTimes='" + service.TotalNoOfTimes + "' ConsentPath='" + service.ConsentPath + "' ConsentTaken='0' Priority='" + service.Priority + "' QuantityOfSample='' PreferredCollectionSource='" + service.PreferredCollectionSource + "' Comments='" + service.Comments + "' RecurStartDateTime='" + service.RecurStartDateTime + "' Units=''></Service>");
                    }
                }
                xmlPrimaryTag = string.Concat(xmlPrimaryTag, Service_list, "</RaiseRequestRequest>");
                GetInvestigationResultDAL objGetInvestOrderDAL = new GetInvestigationResultDAL();
                rsRaise = objGetInvestOrderDAL.RaiseLabRequest(xmlPrimaryTag.Replace("'","\""), objRaise.LoginId, ref requestno);

                //-------------------------OHC PERSONA-------------------------------------               
                if (rsRaise.Err_Code == 1)
                {
                    try
                    {
                        ResultSet rsRaiseResult = new ResultSet();
                        rsRaiseResult = rsRaise;
                        DataSet rsRaiseResultDataset = rsRaiseResult.dsResult;
                        List<string> Lrncollection = new List<string>();
                        string LRNOHC = string.Empty;

                        foreach (DataRow dr in rsRaiseResult.dsResult.Tables[0].Rows)
                        {
                            if (!string.IsNullOrEmpty(Convert.ToString(dr["LRN"])))
                            {
                                LRNOHC = Convert.ToString(dr["LRN"]);
                            }
                        }

                        //if (!string.IsNullOrEmpty(LRNOHC) && LRNOHC != "0")
                        //{
                        //    List<KeyValuePair<string, string>> objTriggerIdentifier = new List<KeyValuePair<string, string>>();
                        //    objTriggerIdentifier.Add(new KeyValuePair<string, string>("LRN", LRNOHC));
                        //    string sLocID = objRaise.locationid;
                        //    List<KeyValuePair<string, string>> objTriggerParameter = new List<KeyValuePair<string, string>>();
                        //    objTriggerParameter.Add(new KeyValuePair<string, string>("AppType", "Digital"));
                        //    objTriggerParameter.Add(new KeyValuePair<string, string>("PatientType", "IP"));
                        //    objTriggerParameter.Add(new KeyValuePair<string, string>("Category", "Laboratory"));
                        //    OutboundlayerDigital.OHCTrigger objOHCTrigger = new OutboundlayerDigital.OHCTrigger();
                        //    objOHCTrigger.SendToViaduct(objTriggerIdentifier, objTriggerParameter, sLocID, "ProcedureRequest");
                        //}
                    }
                    catch (Exception ex)
                    {
                        LogWriter.Error("Exception occured in Procedure Request" + ex.StackTrace, "Error_GetInvestigationResultBLL");
                        throw (ex);
                    }

                }
                //--------------------------------------------------------------------------


                if (rsRaise.Err_Code != CONSTANTS.DEBUG_FAILURE_CODE)
                {
                    rsRaise = RaiseLabBillingRequest(objRaise.uhid, objRaise.locationid, objRaise.ipnumber, objRaise.LoginId, objRaise.PatientType, objRaise.BillingTypeId, requestno, rsRaise.dsResult, objRaise.saveservicedetails[0].serviceid);
                    rsRaise.returncode = requestno.ToString();
                }
                rsRaise.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsRaise.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;


            }
            catch (Exception ex)
            {
                rsRaise.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsRaise.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in RaiseLabRequestBLL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in RaiseLabRequestBLL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");

            }

            return rsRaise;


        }

        public ResultSet RaiseLabBillingRequest(string UHID, string LocationId, string PatientServiceNo, string LoginId, string PatientType, string BillingTypeId, Int64 requestno, DataSet result, string serviceid)
        {

            ResultSet rsRaise = new ResultSet();
            DataTable dtRequests = result.Tables[0];
            GetInvestigationResultDAL objGetInvestOrderDAL = new GetInvestigationResultDAL();
            try
            {
                string xmlPrimaryTag = "<ServiceRequest><RequestDetails IsRelatedPabx='' RegistrationNo='" + UHID + "' PatientIdentifierNo='" + PatientServiceNo + "' AdmissionNoteNo='' ServiceID='' ServiceName='' Raisedby='' DateTime='' Status='1' LocationID='" + LocationId + "' PatientServiceId='1' BedCategoryid='" + objGetInvestOrderDAL.getcurrentbedidDAL(PatientServiceNo, LocationId, LocationId) + "' patienttypeid='" + PatientType + "' BillingTypeId='" + BillingTypeId + "' BillingService='Y' CustomerID='0' RequestNo='" + requestno + "' RequestID='0' RequestStatus='' AdmittedDate='' allotedBedcategoryId='0' RequestedBedCategoryId='0' EligibleBedCategoryId='0' BedTransferFlag='N' AgreementID='0' DoctorID='0' DoctorFeeTypeID='0' ConsultationDate='' ConsultationTime='' DoctorFeeAmount='0' ServiceStatus='RAISED'  BillingStatus='UNBILLED' ServiceTypeID='0' DepartmentID='' WardsOpNumber='' VisitID='0' BedDetails='' RequestedFromUrl='' />";
                string Service_list = string.Empty; string packageid = string.Empty; string ExtraChargeFlag = ""; string Serviceinclusions = string.Empty;
                foreach (DataRow drRow in dtRequests.Rows)
                {
                    if (Convert.ToUInt32(drRow["PRIORITY"]) == 332)
                    {
                        ExtraChargeFlag = "S";
                    }
                    if (Convert.ToInt32(drRow["ITEMTYPE"]) == 3)
                    {
                        packageid = Convert.ToString(drRow["ITEMCODE"]);
                        Serviceinclusions = "Y";
                        
                    }
                    Service_list = string.Concat(Service_list, "<Services Comments='' IsRelatedPabx='' ServiceTypeID='0' ServiceId='" + Convert.ToString(drRow["TESTID"]) + "' ItemID='' ItemCode='" + Convert.ToString(drRow["ITEMCODE"]) + "' ItemName='' ServiceStatus='RAISED' RequestNo='' IncludedinPackage='" + Serviceinclusions + "'" +
                                                                        " Packageid='" + packageid + "' Quantity='0' PurchasePrice='0' MRPPrice='0' InventoryPrice='0' ManualPrice='0' StoreCode='' BatchNo='' SubCategoryID1='0' SubCategoryID2='0' SubCategoryID3='0' FloatingQuantity='0' BloodBagNo='' BloodType='' ServiceTimeID='0' ServiceTimeName='' FNBCost='0' FNBServiceRequestID='0' StartDateTime='' EndDateTime='' RequestDetailID='" + Convert.ToString(drRow["REQUESTTESTID"]) +
                                                                        "' DoctorID='0' DoctorFeeTypeID='0' ConsultationDate='' ConsultationTime='' DoctorFeeAmount='0' BedTransactionID='' CurrenctlyOccupied='' RequestedBedCategoryID='0' AllotedBedCategoryID='0' BillableBedCategoryID='0' BillingStatus='' RequestID='0' EligibleBedCategoryID='0' BedCategoryRank='0' ExtraChargeFlag='" + ExtraChargeFlag + "' ApplicableDate='' RequestedDate='' ExcludeItems='' FreeTextEntry='' Scaleofcosts='0' EmergencySurcharge='0' PercentageCharges='0' FinalSurgeonFees='' AppointmentId='0' BedSideFlag='' IsPhlebotomist='' />");
                }
                //if (!string.IsNullOrEmpty(serviceid))
                //{
                //    Service_list = string.Concat(Service_list, "<Services Comments='' IsRelatedPabx='' ServiceTypeID='0' ServiceId='" + serviceid + "' ItemID='' ItemCode='" + string.Empty + "' ItemName='' ServiceStatus='RAISED' RequestNo='' IncludedinPackage='" + string.Empty + "'" +
                //                                                          " Packageid='" + "0" + "' Quantity='0' PurchasePrice='0' MRPPrice='0' InventoryPrice='0' ManualPrice='0' StoreCode='' BatchNo='' SubCategoryID1='0' SubCategoryID2='0' SubCategoryID3='0' FloatingQuantity='0' BloodBagNo='' BloodType='' ServiceTimeID='0' ServiceTimeName='' FNBCost='0' FNBServiceRequestID='0' StartDateTime='' EndDateTime='' RequestDetailID='" + string.Empty +
                //                                                           "' DoctorID='0' DoctorFeeTypeID='0' ConsultationDate='' ConsultationTime='' DoctorFeeAmount='0' BedTransactionID='' CurrenctlyOccupied='' RequestedBedCategoryID='0' AllotedBedCategoryID='0' BillableBedCategoryID='0' BillingStatus='' RequestID='0' EligibleBedCategoryID='0' BedCategoryRank='0' ExtraChargeFlag='" + ExtraChargeFlag + "' ApplicableDate='' RequestedDate='' ExcludeItems='' FreeTextEntry='' Scaleofcosts='0' EmergencySurcharge='0' PercentageCharges='0' FinalSurgeonFees='' AppointmentId='0' BedSideFlag='' IsPhlebotomist='' />");
                //}
                xmlPrimaryTag = string.Concat(xmlPrimaryTag, Service_list, "</ServiceRequest>");

                rsRaise = objGetInvestOrderDAL.RaiseBillingServices(xmlPrimaryTag.Replace("'", "\""), LoginId);

            }
            catch (Exception ex)
            {
                rsRaise.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsRaise.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in RaiseLabRequestBLL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in RaiseLabRequestBLL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);

            }

            return rsRaise;


        }

        public void RaiseBillingServices()
        {



        }

    }
}
