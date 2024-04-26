using System;
using System.Configuration;
using System.Data;
using TCS.DigitalIPHospitalService.DataContracts;
using TCS.Utilities.ResourceManager.BusinessModels;
using TCS.DigitalIPHospitalService.Utility;
using TCS.DigitalIPHospitalService.DataContracts.IP_COMMON;
using Oracle.DataAccess.Client;
using System.Xml;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Collections.Generic;
using eHIS.ES.Facade;
using Npgsql;
using NpgsqlTypes;
using eHIS.Common.Utility;

namespace TCS.DigitalIPHospitalService.DAL
{
    public class ProcedureDAL
    {
        string HRConnectionString = string.Empty;
        string Secturityconnectionstring = string.Empty;
        string BillingConnectionString = string.Empty;
        string OTConnectionString = string.Empty;
        string EHISConnectionString = string.Empty;
        string ESConnectionString = string.Empty;
        string ConnectionString = string.Empty;

        public ProcedureDAL()
        {
            HRConnectionString = ConfigurationManager.ConnectionStrings["HRConnectionString"].ConnectionString;
            BillingConnectionString = ConfigurationManager.ConnectionStrings["BILLConnectionString"].ConnectionString;
            OTConnectionString = ConfigurationManager.ConnectionStrings["OTConnectionString"].ConnectionString;
            EHISConnectionString = ConfigurationManager.ConnectionStrings["EHISConnectionString"].ConnectionString;
            ESConnectionString = ConfigurationManager.ConnectionStrings["ESConnectionString"].ConnectionString;
        }
        public ResultSet GetDeparments(string DepartmentId, string LocationId)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(HRConnectionString);


                IDataParameter[] Oraparam = daconn.GetParameterArray(4);
                Oraparam[0] = daconn.GetParameter(DBConstants.DG_DEPARTMENTS.PARAM_IV_DEPTID, DepartmentId == "0" ? null : DepartmentId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.DG_DEPARTMENTS.PARAM_IV_LOCATIONID, LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.DG_DEPARTMENTS.PARAM_ON_SUBDEPARTMENTS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[3] = daconn.GetParameter(DBConstants.DG_DEPARTMENTS.PARAM_ON_DEPARTMENT, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_DEPARTMENTS.NAME, CommandType.StoredProcedure, Oraparam);

                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetDeparmentsDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetProcedureTypes(string LocationId)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(BillingConnectionString);


                IDataParameter[] Oraparam = daconn.GetParameterArray(2);
                Oraparam[0] = daconn.GetParameter(DBConstants.DG_PROCEDURETYPES.PARAM_IV_LOCATIONID, LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.DG_PROCEDURETYPES.PARAM_ON_SERVICETYPELIST, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_PROCEDURETYPES.NAME, CommandType.StoredProcedure, Oraparam);

                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetProcedureTypesDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetLocationDepartments(string DepartmentId, string LocationId)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(HRConnectionString);
                if (DepartmentId == string.Empty || DepartmentId == null || DepartmentId == "" || DepartmentId == "0")
                {
                    DepartmentId = null;
                }
                if (LocationId == string.Empty || LocationId == null || LocationId == "" || LocationId == "0")
                {
                    LocationId = null;
                }


                IDataParameter[] Oraparam = daconn.GetParameterArray(5);
                Oraparam[0] = daconn.GetParameter(DBConstants.DG_GTELOCATIONDEPARTMENTS.PARAM_IV_DEPTID, DepartmentId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.DG_GTELOCATIONDEPARTMENTS.PARAM_IV_LOCATIONID, LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.DG_GTELOCATIONDEPARTMENTS.PARAM_ON_LOCATIONS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[3] = daconn.GetParameter(DBConstants.DG_GTELOCATIONDEPARTMENTS.PARAM_ON_LOCSUBDEPTS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[4] = daconn.GetParameter(DBConstants.DG_GTELOCATIONDEPARTMENTS.PARAM_ON_DEPARTMENTS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_GTELOCATIONDEPARTMENTS.NAME, CommandType.StoredProcedure, Oraparam);

                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetLocationDepartmentsDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetLocationData(string LocationId, string RegionId)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(HRConnectionString);



                IDataParameter[] Oraparam = daconn.GetParameterArray(5);
                Oraparam[0] = daconn.GetParameter(DBConstants.DG_GTELOCATIONS.PARAM_IN_MAPPINGID, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.DG_GTELOCATIONS.PARAM_IN_REGIONID, RegionId == "0" ? null : RegionId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.DG_GTELOCATIONS.PARAM_IN_CHARTID, LocationId == "0" ? null : LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daconn.GetParameter(DBConstants.DG_GTELOCATIONS.PARAM_IN_MAPPINGSTATUS, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daconn.GetParameter(DBConstants.DG_GTELOCATIONS.PARAM_ON_REGIONMAPPING, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_GTELOCATIONS.NAME, CommandType.StoredProcedure, Oraparam);

                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetLocationDepartmentsDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GETCONSUMNOTDONE(string UHID, string IPnumber, string LocationId)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(OTConnectionString);



                IDataParameter[] Oraparam = daconn.GetParameterArray(5);
                Oraparam[0] = daconn.GetParameter(DBConstants.DG_CONSUMNOTDONE.PARAM_IV_UHID, UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.DG_CONSUMNOTDONE.PARAM_IV_IPNUMBER, IPnumber, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.DG_CONSUMNOTDONE.PARAM_IV_LOCATIONID, LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daconn.GetParameter(DBConstants.DG_CONSUMNOTDONE.PARAM_ON_DATA, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[4] = daconn.GetParameter(DBConstants.DG_CONSUMNOTDONE.PARAM_ON_DATA1, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_CONSUMNOTDONE.NAME, CommandType.StoredProcedure, Oraparam);

                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetLocationDepartmentsDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        //public ResultSet GetPackageDetails(ProcInput input)
        //{
        //    ResultSet rsIP = new ResultSet();
        //    try
        //    {
        //        DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(BillingConnectionString);



        //        IDataParameter[] Oraparam = daconn.GetParameterArray(11);
        //        Oraparam[0] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IV_PACKAGEID, input.Packageid, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
        //        Oraparam[1] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IV_LOCATIONID, input.LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
        //        Oraparam[2] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IV_PATIENTIDENTIFIERNO, input.IPnumber, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
        //        Oraparam[3] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IN_CUSTOMERID, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
        //        Oraparam[4] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IN_AGGREMENTID, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
        //        Oraparam[5] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEDEFINATION, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
        //        Oraparam[6] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEITEMINCLUSION, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
        //        Oraparam[7] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEITEMEXCLSION, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
        //        Oraparam[8] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGETYPEINCLUSIONDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
        //        Oraparam[9] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEDISCOUNTDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
        //        Oraparam[10] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEGENDERAPPLICABILITY, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

        //        rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_PACKAGEDETAILS.NAME, CommandType.StoredProcedure, Oraparam);
        //        rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
        //        rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

        //    }
        //    catch (Exception ex)
        //    {
        //        rsIP.dsResult = null;
        //        rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
        //        rsIP.Err_Msg = ex.Message;
        //        LogWriter.Error("Exception occured in GetPackageDetailsDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
        //        throw (ex);
        //    }
        //    return rsIP;
        //}
        public ResultSet BindPriority(string LocationId)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(OTConnectionString);


                IDataParameter[] Oraparam = daconn.GetParameterArray(5);
                Oraparam[0] = daconn.GetParameter(DBConstants.DG_PRIORITIES.PARAM_IN_LOVID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.DG_PRIORITIES.PARAM_IV_LOVCODE, "RequestPriority", ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.DG_PRIORITIES.PARAM_IN_LOVDETAILID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[3] = daconn.GetParameter(DBConstants.DG_PRIORITIES.PARAM_IV_LOCATIONID, LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daconn.GetParameter(DBConstants.DG_PRIORITIES.PARAM_ON_DATA, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_PRIORITIES.NAME, CommandType.StoredProcedure, Oraparam);

                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in BindPriorityDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GETFACILITYFROMFACILTYTYPE(int RoomId, string LocationId)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(EHISConnectionString);


                IDataParameter[] Oraparam = daconn.GetParameterArray(3);
                Oraparam[0] = daconn.GetParameter(DBConstants.DG_FACILITYTYPE.PARAM_IN_ROOMTYPEID, RoomId, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.DG_FACILITYTYPE.PARAM_IN_LOCATIONID, LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.DG_FACILITYTYPE.PARAM_ON_DATA, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_FACILITYTYPE.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.dsResult = CommonUtility.GetDataSetCloumnNameToUpper(rsIP.dsResult);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GETFACILITYFROMFACILTYTYPEDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        public ResultSet GetTeamNameOT(int serviceid, string locationid, int Teamid)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(ESConnectionString);


                IDataParameter[] Oraparam = daconn.GetParameterArray(7);
                Oraparam[0] = daconn.GetParameter(DBConstants.DG_TEAMNAME.PARAM_IN_SERVICEID, serviceid, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.DG_TEAMNAME.PARAM_IN_LOCATIONID, locationid, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.DG_TEAMNAME.PARAM_IV_TEAMID, (Teamid == 0 ? null : Convert.ToString(Teamid)), ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daconn.GetParameter(DBConstants.DG_TEAMNAME.PARAM_IV_STARTDATE, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daconn.GetParameter(DBConstants.DG_TEAMNAME.PARAM_IV_ENDDATE, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[5] = daconn.GetParameter(DBConstants.DG_TEAMNAME.PARAM_ON_TEAMSERVICE, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[6] = daconn.GetParameter(DBConstants.DG_TEAMNAME.PARAM_ON_TEAMMEMBER, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_TEAMNAME.NAME, CommandType.StoredProcedure, Oraparam);

                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetTeamNameOT " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        public ResultSet GetUpdateTeamDetails(string TeamId)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daES = DataAccessLayerFactory.GetDataAccessLayer(ESConnectionString);

                IDataParameter[] Oraparam = daES.GetParameterArray(4);
                Oraparam[0] = daES.GetParameter(DBConstants.P_TEAMDEATILS.PARAM_IV_TEAMID, TeamId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daES.GetParameter(DBConstants.P_TEAMDEATILS.PARAM_OUT_LOCATION, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[2] = daES.GetParameter(DBConstants.P_TEAMDEATILS.PARAM_OUT_MEMBER, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[3] = daES.GetParameter(DBConstants.P_TEAMDEATILS.PARAM_OUT_SERVICE, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daES.ExecuteDataSet(DBConstants.P_TEAMDEATILS.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.dsResult = CommonUtility.GetDataSetCloumnNameToUpper(rsIP.dsResult);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetOccupiedBedsDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        public DataTable GetPackageInclusionDetails(string serviceid, string IPnumber, string LocationId)
        {
            DataTable rsIP = new DataTable();
            DataSet ds;
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(BillingConnectionString);



                IDataParameter[] Oraparam = daconn.GetParameterArray(11);
                Oraparam[0] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IV_PACKAGEID, serviceid, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IV_LOCATIONID, LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IV_PATIENTIDENTIFIERNO, IPnumber, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IN_CUSTOMERID, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IN_AGGREMENTID, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[5] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEDEFINATION, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[6] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEITEMINCLUSION, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[7] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEITEMEXCLSION, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[8] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGETYPEINCLUSIONDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[9] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEDISCOUNTDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[10] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEGENDERAPPLICABILITY, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                ds = daconn.ExecuteDataSet(DBConstants.DG_PACKAGEDETAILS.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP = ds.Tables[1];

            }
            catch (Exception ex)
            {
                LogWriter.Error("Exception occured in GetPackageDetailsDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public DataTable GetPackageDetails(string packageid, string IPnumber, string LocationId)
        {
            DataTable rsIP = new DataTable();
            DataSet ds;
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(BillingConnectionString);



                IDataParameter[] Oraparam = daconn.GetParameterArray(11);
                Oraparam[0] = daconn.GetParameter(DBConstants.BillingGetPackageDetails.PARAM_IN_packageid, packageid, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.BillingGetPackageDetails.PARAM_IN_locationid, LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.BillingGetPackageDetails.PARAM_IN__patientidentifierno, IPnumber, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daconn.GetParameter(DBConstants.BillingGetPackageDetails.PARAM_IN_customerid, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daconn.GetParameter(DBConstants.BillingGetPackageDetails.PARAM_IN_aggrementid, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[5] = daconn.GetParameter(DBConstants.BillingGetPackageDetails.PARAM_OUT_packagedefination, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[6] = daconn.GetParameter(DBConstants.BillingGetPackageDetails.PARAM_OUT_packageiteminclusion, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[7] = daconn.GetParameter(DBConstants.BillingGetPackageDetails.PARAM_OUT_packageitemexclsion, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[8] = daconn.GetParameter(DBConstants.BillingGetPackageDetails.PARAM_OUT_packagetypeinclusiondetails, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[9] = daconn.GetParameter(DBConstants.BillingGetPackageDetails.PARAM_OUT_packagediscountdetails, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[10] = daconn.GetParameter(DBConstants.BillingGetPackageDetails.PARAM_OUT_packagegenderapplicability, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                ds = daconn.ExecuteDataSet(DBConstants.BillingGetPackageDetails.SPNAME, CommandType.StoredProcedure, Oraparam);
                rsIP = ds.Tables[1];

            }
            catch (Exception ex)
            {
                LogWriter.Error("Exception occured in GetPackageDetailsDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetCalendarAndAppointmentDetails(List<Calenderappointment> input)
        {
            ResultSet rsIP = new ResultSet();
            StringBuilder objStringBuilder = default(StringBuilder);
            StringWriter objStringWriter = default(StringWriter);
            XmlTextWriter objXmlTextWriter = default(XmlTextWriter);
            try
            {
                objStringBuilder = new StringBuilder(10000);
                objStringWriter = new StringWriter(objStringBuilder);
                objXmlTextWriter = new XmlTextWriter(objStringWriter);
                objXmlTextWriter.WriteStartElement("XMLAppointmentDetails");
                for (int i = 0; i < input.Count; i++)
                {
                    objXmlTextWriter.WriteStartElement("TodaysAppointments");
                    objXmlTextWriter.WriteAttributeString("ResourceID", "", input[i].ResourceID.ToString());
                    objXmlTextWriter.WriteAttributeString("ResourceTypeID", "", input[i].ResourceTypeID.ToString());
                    objXmlTextWriter.WriteAttributeString("LocationId", "", input[i].LocationId.ToString());
                    objXmlTextWriter.WriteAttributeString("StartDateTime", "", input[i].StartDateTime.ToString());
                    objXmlTextWriter.WriteAttributeString("EndDateTime", "", input[i].EndDateTime.ToString());
                    objXmlTextWriter.WriteAttributeString("Date", "", input[i].Date.ToString());
                    objXmlTextWriter.WriteEndElement();

                }
                objXmlTextWriter.WriteEndElement();
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(ESConnectionString);

                IDataParameter[] Oraparam = daconn.GetParameterArray(3);
                Oraparam[0] = daconn.GetParameter(DBConstants.DG_CALENDERANDAPPOINTMENT.PARAM_IN_APPOINT, objStringBuilder.ToString(), ParameterDirection.Input, null, DbType.Object, string.Empty, XDbType.Clob);
                Oraparam[1] = daconn.GetParameter(DBConstants.DG_CALENDERANDAPPOINTMENT.PARAM_ON_CALENDAR, null, ParameterDirection.Output, null, DbType.String, string.Empty, XDbType.RefCursor);
                Oraparam[2] = daconn.GetParameter(DBConstants.DG_CALENDERANDAPPOINTMENT.PARAM_ON_APPOINTMENTS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_CALENDERANDAPPOINTMENT.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.dsResult = CommonUtility.GetDataSetCloumnNameToUpper(rsIP.dsResult);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetCalendarAndAppointmentDetailsDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetCalendarRulesDetails(string CalenderId, string ServiceId, string ResourceId, string SelectedDate, int ResourceTypeID, string LocationId)
        {
            ResultSet rsIP = new ResultSet();
            StringBuilder objStringBuilder = default(StringBuilder);
            StringWriter objStringWriter = default(StringWriter);
            XmlTextWriter objXmlTextWriter = default(XmlTextWriter);
            try
            {
                objStringBuilder = new StringBuilder(10000);
                objStringWriter = new StringWriter(objStringBuilder);
                objXmlTextWriter = new XmlTextWriter(objStringWriter);
                objXmlTextWriter.WriteStartElement("ResourceData");
                objXmlTextWriter.WriteStartElement("ResourceDetails");
                objXmlTextWriter.WriteAttributeString("ResourceId", "", ResourceId);
                objXmlTextWriter.WriteEndElement();
                objXmlTextWriter.WriteEndElement();
                //var json = Calenderappointment.clobresource.ToString();
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(ESConnectionString);
                //json = json.Replace("_at_", "@").Replace("_hash_", "#").Replace("text\": \"@", "text\":\"");
                //XmlDocument doc = new XmlDocument();
                //doc = (XmlDocument)JsonConvert.DeserializeXmlNode(json, "ResourceData");
                //string xml = SerializeObject(doc);

                IDataParameter[] Oraparam = daconn.GetParameterArray(7);
                Oraparam[0] = daconn.GetParameter(DBConstants.DG_GETCALENDARRULES.PARAM_IN_CalendarID, CalenderId == "0" ? "" : CalenderId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.DG_GETCALENDARRULES.PARAM_IV_ServiceID, ServiceId == "null" ? "" : ServiceId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.DG_GETCALENDARRULES.PARAM_IClob_Resourceid, objStringBuilder.ToString(), ParameterDirection.Input, null, DbType.Object, string.Empty, XDbType.Clob);
                Oraparam[3] = daconn.GetParameter(DBConstants.DG_GETCALENDARRULES.PARAM_ID_Date, SelectedDate, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daconn.GetParameter(DBConstants.DG_GETCALENDARRULES.PARAM_IV_ResourceTypeID, ResourceTypeID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[5] = daconn.GetParameter(DBConstants.DG_GETCALENDARRULES.PARAM_IV_Locationid, LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[6] = daconn.GetParameter(DBConstants.DG_GETCALENDARRULES.PARAM_ON_CALENDER, null, ParameterDirection.Output, null, DbType.String, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_GETCALENDARRULES.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.dsResult = CommonUtility.GetDataSetCloumnNameToUpper(rsIP.dsResult);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetCalendarAndAppointmentDetailsDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public string SerializeObject(XmlDocument doc)
        {

            StringWriter objStringWriter = new StringWriter();
            try
            {
                XmlTextWriter objXmlTextWriter = new XmlTextWriter(objStringWriter);
                doc.WriteTo(objXmlTextWriter);
            }
            catch (Exception ex)
            {
                LogWriter.Error("Exception occured in SerializeObject " + ex.Message, "DETAILED_NURSING_IPPATIENT");
            }
            return objStringWriter.ToString();

        }
        public ResultSet GetPackType(string LocationId, string ServiceTypeId, string ServiceId, int DeptId)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetPastSurgeryDAL = DataAccessLayerFactory.GetDataAccessLayer(BillingConnectionString);

                IDataParameter[] Oraparam = daGetPastSurgeryDAL.GetParameterArray(17);
                Oraparam[0] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_LOCATIONID, LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_PATIENTSERVICEID, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_DEPTID, (DeptId == 0) ? null : Convert.ToString(DeptId), ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_CATEGORYID, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_SERVICETYPEID, ServiceTypeId == "0" ? null : ServiceTypeId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[5] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_SERVICENAME, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[6] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_BILLABLE, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[7] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_SERVICESTATUS, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[8] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_RequestNumber, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[9] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_SERVICEID, ServiceId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[10] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_TAXABLE, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[11] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_SCHEDULABLE, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[12] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_WILDSERVICEITEM, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[13] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_AGE, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[14] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_GENDERID, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[15] = daGetPastSurgeryDAL.GetParameter(DBConstants.DG_CSSD_Packtype.PARAM_IN_PATIENTCONDITIONID, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[16] = daGetPastSurgeryDAL.GetParameter("OC_SERVICELIST", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                rsIP.dsResult = daGetPastSurgeryDAL.ExecuteDataSet("billing.P_GETSERVICES", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetPackType_DAL" + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        public ResultSet getTodaysAppiontmnets(TodaysAppointments input)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(ESConnectionString);

               
                
                IDataParameter[] Oraparam = daconn.GetParameterArray(17);
                Oraparam[0] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IN_AppointmentID, DBNull.Value, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IV_RegistrationNumber, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IV_PatientName, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IN_ServiceID, DBNull.Value, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[4] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IN_SpecialityID, DBNull.Value, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[5] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IN_LocationID, input.locationid, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                if (input.siteid == 0)
                {
                    Oraparam[6] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IN_SiteID, DBNull.Value, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                }
                else
                {
                    Oraparam[6] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IN_SiteID, input.siteid, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                }
                Oraparam[7] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IN_ResourceID, input.resourceid, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[8] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_ID_StartDateTime, input.StartDateTime, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[9] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_ID_EndDateTime, input.EndDateTime, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[10] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_ID_CancellationDate, DBNull.Value, ParameterDirection.Input, null, DbType.Date, string.Empty, XDbType.None);
                Oraparam[11] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IN_StatusCheck, DBNull.Value, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[12] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IV_UpdatedBy, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[13] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IV_AdmissionNumber, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[14] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IV_AdmissionType, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[15] = daconn.GetParameter(DBConstants.P_GETTODAYSAPPOINTMENTS.PARAM_IN_RepeatAppointmentID, DBNull.Value, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[16] = daconn.GetParameter("oCursor_Result", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.P_GETTODAYSAPPOINTMENTS.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in getTodaysAppiontmnets_DAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet CheckConstraints(CheckConstraints input)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(ESConnectionString);

                IDataParameter[] Oraparam = daconn.GetParameterArray(20);
                Oraparam[0] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_IN_AppointmentID, DBNull.Value, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_IV_RegistrationNumber, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_IV_PatientNumber, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_IN_ServiceID, DBNull.Value, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[4] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_IN_SpecialityID, DBNull.Value, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[5] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_IN_LocationID, input.locationid, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[6] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_IN_SiteID, input.siteid, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[7] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_IN_ResourceID, input.resourceid, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[8] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_ID_StartDateTime, input.StartDateTime, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[9] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_ID_EndDateTime, input.EndDateTime, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[10] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_ID_CancellationDate, DBNull.Value, ParameterDirection.Input, null, DbType.Date, string.Empty, XDbType.None);
                Oraparam[11] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_IN_StatusCheck, DBNull.Value, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[12] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_IV_UpdatedBy, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[13] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_IV_AdmissionNumber, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[14] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_IV_AdmissionType, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[15] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_OUT_BLOCK, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[16] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_OUT_HOLD, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[17] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_OUT_OFFTIME, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[18] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_OUT_INSCHEDULE, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[19] = daconn.GetParameter(DBConstants.P_CHECKCONSTRAINTS.PARAM_OUT_DIFFLOCATIONS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.P_CHECKCONSTRAINTS.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in getTodaysAppiontmnets_DAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetStopbookdetailsServices(string LocationID, int ServiceID, int ResourceID, int ResourceTypeID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(ESConnectionString);

                IDataParameter[] Oraparam = daconn.GetParameterArray(6);
                Oraparam[0] = daconn.GetParameter(DBConstants.P_GETSTOPBOOKDETAILSSERVICES.PARAM_IN_LOCATIONID, DBNull.Value, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.P_GETSTOPBOOKDETAILSSERVICES.PARAM_IN_SERVICEID, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.P_GETSTOPBOOKDETAILSSERVICES.PARAM_IV_RESOURCEID, DBNull.Value, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daconn.GetParameter(DBConstants.P_GETSTOPBOOKDETAILSSERVICES.PARAM_iv_resourcetypeid, DBNull.Value, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[4] = daconn.GetParameter(DBConstants.P_GETSTOPBOOKDETAILSSERVICES.PARAM_ON_SERVICE, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[5] = daconn.GetParameter(DBConstants.P_GETSTOPBOOKDETAILSSERVICES.PARAM_ON_RESOURCES, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.P_GETSTOPBOOKDETAILSSERVICES.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetStopbookdetailsServices_DAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public validateholiday ValidateHoliday(string locationid, string holidaydate)
        {
            validateholiday OBJHOLIDAY = new validateholiday();
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(HRConnectionString);


                IDataParameter[] Oraparam = daconn.GetParameterArray(3);
                Oraparam[0] = daconn.GetParameter(DBConstants.DG_VALIDATEHOLIDAY.PARAM_IN_locationid, locationid, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.DG_VALIDATEHOLIDAY.PARAM_IN_date, Convert.ToDateTime(holidaydate), ParameterDirection.Input, null, DbType.Date, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.DG_VALIDATEHOLIDAY.PARAM_ON_RESULT, null, ParameterDirection.Output, null, DbType.Int32, string.Empty, XDbType.None);
                daconn.ExecuteDataSet(DBConstants.DG_VALIDATEHOLIDAY.NAME, CommandType.StoredProcedure, Oraparam);
                //rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_VALIDATEHOLIDAY.NAME, CommandType.StoredProcedure, Oraparam);
                OBJHOLIDAY.IsHoliday = Convert.ToInt32(Oraparam[2].Value);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in ValidateHoliday_DAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return OBJHOLIDAY;
        }
        public AppointmentResultSet AddAppointmentDetails(Appointment input)
        {
            //string registrationType, string registrationNumber, string patientName, string contactNumber, int serviceID, string serviceName, int specialityID, string SpecialityName, int locationID, int siteID, int resourceID, int languageID, int genderID, string startDateTime, string endDateTime, string preferredTime, string notes, string loginID, int statusCheck, string resourceXml, ByVal groupDetailsXml As String, ByVal AdmissionNumber As String, ByVal AdmissionType As String, ByVal Repeats As String, ByVal RepeatID As Integer, ByVal PatientServiceFlag As Integer, ByVal DepartmentID As Integer, ByVal ModeOfAppointment As String, ByRef appointmentID As String
            AppointmentResultSet Result_Services = new AppointmentResultSet();
            int retCode = 0;
            string appID = "";
            ResultSet rs = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(ESConnectionString);


                IDataParameter[] Oraparam = daconn.GetParameterArray(28);

                Oraparam[0] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_RegistrationType, input.RegistrationType, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_RegistrationNumber, input.RegistrationNumber, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_PatientName, input.PatientName, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_ContactNumber, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_ServiceID, input.ServiceID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[5] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_SpecialityID, input.SpecialityID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[6] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_LocationID, input.LocationID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[7] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_SiteID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[8] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_ResourceID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[9] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_LanguageID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[10] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_GenderID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[11] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_ID_StartDateTime, input.StartDateTime, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[12] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_ID_EndDateTime, input.EndDateTime, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[13] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_PreferredTime, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[14] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_Notes, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[15] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_UpdatedBy, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[16] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_StatusCheck, input.StatusCheck, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[17] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_OUT_Resources, null, ParameterDirection.Input, null, DbType.Object, string.Empty, XDbType.Clob);
                Oraparam[18] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_OUT_GroupDetails, null, ParameterDirection.Input, null, DbType.Object, string.Empty, XDbType.Clob);
                Oraparam[19] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_AdmissionNumber, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[20] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_AdmissionType, input.AdmissionType, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[21] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_Repeats, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[22] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_RepeatID, input.RepeatID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[23] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_Iv_ServiceName, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[24] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_Iv_SpecialityName, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[25] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_PATIENTSERVICEFLAG, input.PatientServiceFlag, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[26] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_ON_AppointmentID, null, ParameterDirection.Output, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[27] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_MODEOFAPPOINTMENT, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);



                if (input.GroupDetailsXml == String.Empty)
                {
                    Oraparam[18].Value = DBNull.Value;
                }
                else
                {
                    input.GroupDetailsXml = input.GroupDetailsXml.Replace("&amp;", "&");
                    input.GroupDetailsXml = input.GroupDetailsXml.Replace("&amp;", "&");
                    input.GroupDetailsXml = input.GroupDetailsXml.Replace("&lt;", "<");
                    input.GroupDetailsXml = input.GroupDetailsXml.Replace("&gt;", ">");
                    input.GroupDetailsXml = input.GroupDetailsXml.Replace("&nbsp;", "");
                    Oraparam[18].Value = input.GroupDetailsXml;
                }

                daconn.ExecuteDataSet(DBConstants.P_ADDAPPOINTMENTS.NAME, CommandType.StoredProcedure, Oraparam);


                // retCode = ORACLEHelper.ExecuteNonQuery(ConnectionString, CommandType.StoredProcedure, procAddAppointmentDetails, oracleParamArray)

                appID = Convert.ToString(Oraparam[26].Value);
                if (appID != string.Empty)
                {
                    Result_Services.AppointmentId = Convert.ToInt32(appID);
                }

                Result_Services.retCode = 0;

            }
            catch (Exception ex)
            {
                LogWriter.Error("Exception occured in AddAppointmentDetails_DAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return Result_Services;
        }

        public AppointmentResultSet AddOTResource(Appointment input, int AppointmentId)
        {
            //string registrationType, string registrationNumber, string patientName, string contactNumber, int serviceID, string serviceName, int specialityID, string SpecialityName, int locationID, int siteID, int resourceID, int languageID, int genderID, string startDateTime, string endDateTime, string preferredTime, string notes, string loginID, int statusCheck, string resourceXml, ByVal groupDetailsXml As String, ByVal AdmissionNumber As String, ByVal AdmissionType As String, ByVal Repeats As String, ByVal RepeatID As Integer, ByVal PatientServiceFlag As Integer, ByVal DepartmentID As Integer, ByVal ModeOfAppointment As String, ByRef appointmentID As String
            AppointmentResultSet Result_Services = new AppointmentResultSet();
            int retCode = 0;
            string appID = "";
            ResultSet rs = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(ESConnectionString);


                IDataParameter[] Oraparam = daconn.GetParameterArray(27);
                Oraparam[0] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_RegistrationType, input.RegistrationType, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_RegistrationNumber, input.RegistrationNumber, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_PatientName, input.PatientName, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_ContactNumber, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_ServiceID, input.ServiceID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[5] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_SpecialityID, input.SpecialityID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[6] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_LocationID, input.LocationID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[7] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_SiteID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[8] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_ResourceID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[9] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_LanguageID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[10] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_GenderID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[11] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_ID_StartDateTime, input.StartDateTime, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[12] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_ID_EndDateTime, input.EndDateTime, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[13] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_PreferredTime, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[14] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_Notes, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[15] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_UpdatedBy, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[16] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_StatusCheck, input.StatusCheck, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[17] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_OUT_Resources, null, ParameterDirection.Input, null, DbType.Object, string.Empty, XDbType.Clob);
                Oraparam[18] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_OUT_GroupDetails, null, ParameterDirection.Input, null, DbType.Object, string.Empty, XDbType.Clob);
                Oraparam[19] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_AdmissionNumber, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[20] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_AdmissionType, input.AdmissionType, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[21] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IV_Repeats, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[22] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_RepeatID, input.RepeatID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[23] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_Iv_ServiceName, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[24] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_Iv_SpecialityName, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[25] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_IN_PATIENTSERVICEFLAG, input.PatientServiceFlag, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[26] = daconn.GetParameter(DBConstants.P_ADDAPPOINTMENTS.PARAM_ON_AppointmentID, null, ParameterDirection.Output, null, DbType.Int32, string.Empty, XDbType.None);



                if (input.GroupDetailsXml == String.Empty)
                {
                    Oraparam[18].Value = DBNull.Value;
                }
                else
                {
                    input.GroupDetailsXml = input.GroupDetailsXml.Replace("&amp;", "&");
                    input.GroupDetailsXml = input.GroupDetailsXml.Replace("&amp;", "&");
                    input.GroupDetailsXml = input.GroupDetailsXml.Replace("&lt;", "<");
                    input.GroupDetailsXml = input.GroupDetailsXml.Replace("&gt;", ">");
                    input.GroupDetailsXml = input.GroupDetailsXml.Replace("&nbsp;", "");
                    Oraparam[18].Value = input.GroupDetailsXml;
                }
                if (input.ResourcesXml == String.Empty)
                {
                    Oraparam[17].Value = DBNull.Value;
                }
                else
                {
                    input.ResourcesXml = input.ResourcesXml.Replace("&amp;", "&");
                    input.ResourcesXml = input.ResourcesXml.Replace("&amp;", "&");
                    input.ResourcesXml = input.ResourcesXml.Replace("&lt;", "<");
                    input.ResourcesXml = input.ResourcesXml.Replace("&gt;", ">");
                    input.ResourcesXml = input.ResourcesXml.Replace("&nbsp;", "");
                    Oraparam[17].Value = input.ResourcesXml;
                }

                daconn.ExecuteDataSet(DBConstants.P_ADDAPPOINTMENTS.NAME_ADDOT, CommandType.StoredProcedure, Oraparam);


                // retCode = ORACLEHelper.ExecuteNonQuery(ConnectionString, CommandType.StoredProcedure, procAddAppointmentDetails, oracleParamArray)

                appID = Convert.ToString(Oraparam[26].Value);
                if (appID != string.Empty)
                {
                    Result_Services.AppointmentId = Convert.ToInt32(appID);
                }

                Result_Services.retCode = 0;

            }
            catch (Exception ex)
            {
                LogWriter.Error("Exception occured in AddOTResource_DAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return Result_Services;
        }
        public ResultSet SaveReqEmrHrd(string SurgeryAdviceId, string IPNumber, int SpecialityID, int PatientTypeID,
            string Duration, int PlannedDur, string PlannedSrTime, string PlannedEndTime, string PlannedDate, int PlannedOTID, string LocationID, string LoginId, int RequestPriority, string OPNUMBER, string ERN,
            int AppointmentId, string UHID, int Teamleadid, string plannedenddate, string Bedsideproc, string OTBookingChargeReqdFlag, string FreeTextSurgery, string ProcReqType)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(OTConnectionString);


                IDataParameter[] Oraparam = daconn.GetParameterArray(24);
                Oraparam[0] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IN_SURG_ADVICE_ID, null, ParameterDirection.Input, null, DbType.Int64, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IV_IP_NUMBER, IPNumber, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IN_SPECIALITY_ID, SpecialityID, ParameterDirection.Input, null, DbType.Int64, string.Empty, XDbType.None);
                Oraparam[3] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IN_PATIENTTYPE_ID, PatientTypeID, ParameterDirection.Input, null, DbType.Int64, string.Empty, XDbType.None);
                Oraparam[4] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IC_DURATION_SOURCE, Duration, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[5] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_ID_PLANNED_DURATION, PlannedDur, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[6] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IV_PLANNED_START_TIME, PlannedSrTime, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[7] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IV_PLANNED_END_TIME, PlannedEndTime, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[8] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_ID_PLANNED_DATE, PlannedDate, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[9] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IN_PLANNED_OT_ID, PlannedOTID, ParameterDirection.Input, null, DbType.Int64, string.Empty, XDbType.None);
                Oraparam[10] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IV_LOCATIONID, LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[11] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IV_CREATED_BY, LoginId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[12] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_ON_REQ_NO, null, ParameterDirection.Output, null, DbType.Int64, string.Empty, XDbType.None);
                Oraparam[13] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IN_REQUEST_PRIORITY_ID, RequestPriority, ParameterDirection.Input, null, DbType.Int64, string.Empty, XDbType.None);
                Oraparam[14] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IV_OP_NUMBER, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[15] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IV_ERN, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[16] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IN_APPOINTMENT_ID, AppointmentId, ParameterDirection.Input, null, DbType.Int64, string.Empty, XDbType.None);
                Oraparam[17] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IV_UHID, UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[18] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IN_TEAM_LEAD_ID, Teamleadid, ParameterDirection.Input, null, DbType.Int64, string.Empty, XDbType.None);
                Oraparam[19] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_ID_ENDDATE, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[20] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IC_BEDSIDE_FLAG, Bedsideproc, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[21] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IC_OT_BOOKING_CHRG_FLAG, OTBookingChargeReqdFlag, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[22] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IV_FREETEXTSURGERY, FreeTextSurgery, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[23] = daconn.GetParameter(DBConstants.DG_BEDSIDEREQUEST.PARAM_IN_PROCREQTYPE, ProcReqType, ParameterDirection.Input, null, DbType.Int64, string.Empty, XDbType.None);
                rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_BEDSIDEREQUEST.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.returncode = Convert.ToString(Oraparam[12].Value);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in SaveReqEmrHrd " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        public ResultSet SaveReqDTD(int ProReqID, string LoginId, DataTable SurgeryData)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daSavePlanOfCareDAL = DataAccessLayerFactory.GetDataAccessLayer(OTConnectionString);

                int intNoOfRecords = SurgeryData.Rows.Count;
                int[] arrProRequestNo = new int[intNoOfRecords];
                int[] arrSurgeryId = new int[intNoOfRecords];
                string[] arrLoginId = new string[intNoOfRecords];
                string[] arrMappedPkgId = new string[intNoOfRecords];
                int intCount = 0;
                //foreach (DataRow dr in SurgeryData.Rows)
                //{
                //    arrProRequestNo[intCount] = ProReqID;
                //    arrSurgeryId[intCount] = Convert.ToInt32(dr["SurgeryID"]);
                //    arrLoginId[intCount] = LoginId;
                //    arrMappedPkgId[intCount] = dr["MappedPkgID"].ToString();
                //    intCount = intCount + 1;
                //}

                //OracleConnection con = new OracleConnection();
                //con.ConnectionString = OTConnectionString;
                //con.Open();
                //OracleCommand com = new OracleCommand("PKG_PROCEDURE_REQUEST.P_ADD_PROC_REQ_SURG_DATA", con);
                //com.ArrayBindCount = intNoOfRecords;
                //com.CommandType = CommandType.StoredProcedure;
                //com.Parameters.Add("IN_PROC_REQ_HDR_ID", OracleDbType.Int32, arrProRequestNo, ParameterDirection.Input);
                //com.Parameters.Add("IN_SURG_ID", OracleDbType.Int32, arrSurgeryId, ParameterDirection.Input);
                //com.Parameters.Add("IV_CREATED_BY", OracleDbType.Varchar2, arrLoginId, ParameterDirection.Input);
                //com.Parameters.Add("IV_MAPPEDPKGID", OracleDbType.Varchar2, arrMappedPkgId, ParameterDirection.Input);
                //com.ExecuteNonQuery();
                //con.Close();

                NpgsqlCommand orcmdDML = new NpgsqlCommand();

                orcmdDML.Parameters.Add("IN_PROC_REQ_HDR_ID", NpgsqlDbType.Numeric);
                orcmdDML.Parameters.Add("IN_SURG_ID", NpgsqlDbType.Numeric);
                orcmdDML.Parameters.Add("IV_CREATED_BY", NpgsqlDbType.Varchar);
                orcmdDML.Parameters.Add("IV_MAPPEDPKGID", NpgsqlDbType.Numeric);

                int ReturnValue = PgSQLHelper.BulkExecuteNonQuery(OTConnectionString, SurgeryData, "ot.PKG_PROCEDURE_REQUEST_P_ADD_PROC_REQ_SURG_DATA", orcmdDML.Parameters.ToArray());
                rsIP.Err_Code = 1;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception Ex)
            {
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = Ex.Message;
                LogWriter.Error("Exception occured in SaveReqDTDDAL " + Ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (Ex);
            }
            return rsIP;

        }

        public ResultSet SaveReqTeam(int ProReqID, string LoginId, DataTable TeamData)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daSavePlanOfCareDAL = DataAccessLayerFactory.GetDataAccessLayer(OTConnectionString);

                int intNoOfRecords = TeamData.Rows.Count;
                int[] arrProRequestNo = new int[intNoOfRecords];
                int[] arrTeamId = new int[intNoOfRecords];
                int[] arrResTypeId = new int[intNoOfRecords];
                int[] arrResId = new int[intNoOfRecords];
                int[] arrLoginId = new int[intNoOfRecords];
                int intCount = 0;
                foreach (DataRow dr in TeamData.Rows)
                {
                    arrProRequestNo[intCount] = ProReqID;
                    arrTeamId[intCount] = Convert.ToInt32(dr["TeamID"]);
                    arrResTypeId[intCount] = Convert.ToInt32(dr["ResTypeID"]);
                    arrResId[intCount] = Convert.ToInt32(dr["ResID"]);
                    arrLoginId[intCount] = Convert.ToInt32(LoginId);

                    intCount = intCount + 1;
                }

                OracleConnection con = new OracleConnection();
                con.ConnectionString = OTConnectionString;
                con.Open();
                OracleCommand com = new OracleCommand("PKG_PROCEDURE_REQUEST.P_ADD_PROC_REQ_TEAM_DATA", con);
                com.ArrayBindCount = intNoOfRecords;
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("IN_PROC_REQ_HDR_ID", OracleDbType.Int32, arrProRequestNo, ParameterDirection.Input);
                com.Parameters.Add("IN_PROC_TEAM_ID", OracleDbType.Int32, arrTeamId, ParameterDirection.Input);
                com.Parameters.Add("IN_RESOURCE_TYPE_ID", OracleDbType.Int32, arrResTypeId, ParameterDirection.Input);
                com.Parameters.Add("IN_RESOURCE_ID", OracleDbType.Int32, arrResId, ParameterDirection.Input);
                com.Parameters.Add("IV_CREATED_BY", OracleDbType.Int32, arrLoginId, ParameterDirection.Input);
                com.ExecuteNonQuery();
                con.Close();
                rsIP.Err_Code = 1;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception Ex)
            {
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = Ex.Message;
                LogWriter.Error("Exception occured in SaveReqTeamDAL " + Ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (Ex);
            }
            return rsIP;

        }

        public ResultSet SaveReqEquip(int ProReqID, string LoginId, DataTable EquipData)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daSavePlanOfCareDAL = DataAccessLayerFactory.GetDataAccessLayer(OTConnectionString);

                int intNoOfRecords = EquipData.Rows.Count;
                int[] arrProRequestNo = new int[intNoOfRecords];
                int[] arrEquipId = new int[intNoOfRecords];
                int[] arrLoginId = new int[intNoOfRecords];

                int intCount = 0;
                foreach (DataRow dr in EquipData.Rows)
                {
                    arrProRequestNo[intCount] = ProReqID;
                    arrEquipId[intCount] = Convert.ToInt32(dr["EQUIPMENTID"]);
                    arrLoginId[intCount] = Convert.ToInt32(LoginId);

                    intCount = intCount + 1;
                }

                OracleConnection con = new OracleConnection();
                con.ConnectionString = OTConnectionString;
                con.Open();
                OracleCommand com = new OracleCommand("PKG_PROCEDURE_REQUEST.P_ADD_PROC_REQ_EQUPMNTS", con);
                com.ArrayBindCount = intNoOfRecords;
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("IN_PROC_REQ_HDR_ID", OracleDbType.Int32, arrProRequestNo, ParameterDirection.Input);
                com.Parameters.Add("in_equpmnt_id", OracleDbType.Int32, arrEquipId, ParameterDirection.Input);
                com.Parameters.Add("IV_CREATED_BY", OracleDbType.Int32, arrLoginId, ParameterDirection.Input);
                com.ExecuteNonQuery();
                con.Close();
                rsIP.Err_Code = 1;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception Ex)
            {
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = Ex.Message;
                LogWriter.Error("Exception occured in SaveReqEquipDAL " + Ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (Ex);
            }
            return rsIP;

        }
         public ResultSet GetReqData(int RequestID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(OTConnectionString);


                IDataParameter[] Oraparam = daconn.GetParameterArray(5);
                Oraparam[0] = daconn.GetParameter("in_proc_req_hdr_id", RequestID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[1] = daconn.GetParameter("ocursor_data", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                 Oraparam[2] = daconn.GetParameter("ocursor_surg_data", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                 Oraparam[3] = daconn.GetParameter("ocursor_team_data", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                 Oraparam[4] = daconn.GetParameter("ocursor_equp_data", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                rsIP.dsResult = daconn.ExecuteDataSet("PKG_PROCEDURE_REQUEST.P_GET_PROC_REQUEST_DATA", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetReqData_DAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
         public ResultSet GetPackageDetails(ProcInput input)
         {
             ResultSet rsIP = new ResultSet();
             try
             {
                 DataAccessLayerBaseClass daconn = DataAccessLayerFactory.GetDataAccessLayer(BillingConnectionString);



                 IDataParameter[] Oraparam = daconn.GetParameterArray(11);
                 Oraparam[0] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IV_PACKAGEID, input.Packageid, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                 Oraparam[1] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IV_LOCATIONID, input.LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                 Oraparam[2] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IV_PATIENTIDENTIFIERNO, input.IPnumber, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                 Oraparam[3] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IN_CUSTOMERID, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                 Oraparam[4] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_IN_AGGREMENTID, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                 Oraparam[5] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEDEFINATION, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                 Oraparam[6] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEITEMINCLUSION, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                 Oraparam[7] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEITEMEXCLSION, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                 Oraparam[8] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGETYPEINCLUSIONDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                 Oraparam[9] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEDISCOUNTDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                 Oraparam[10] = daconn.GetParameter(DBConstants.DG_PACKAGEDETAILS.PARAM_ON_PACKAGEGENDERAPPLICABILITY, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                 rsIP.dsResult = daconn.ExecuteDataSet(DBConstants.DG_PACKAGEDETAILS.NAME, CommandType.StoredProcedure, Oraparam);
                 rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                 rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

             }
             catch (Exception ex)
             {
                 rsIP.dsResult = null;
                 rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                 rsIP.Err_Msg = ex.Message;
                 LogWriter.Error("Exception occured in GetPackageDetailsDAL " + ex.ToString(), "DETAILED_NURSING_IPPATIENT");
                 throw (ex);
             }
             return rsIP;
         }
      

    }

}
