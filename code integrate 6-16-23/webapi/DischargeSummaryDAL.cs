using System;
using System.Configuration;
using System.Data;
using TCS.DigitalIPHospitalService.DataContracts;
using TCS.Utilities.ResourceManager.BusinessModels;
using TCS.DigitalIPHospitalService.Utility;
using Oracle.DataAccess.Client;
using System.Xml;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using OutboundlayerDigital;
using OHCProxy;
using System.Collections.Generic;
using eHIS.Common.Utility;

namespace TCS.DigitalIPHospitalService.DAL
{
    public class DischargeSummaryDAL
    {
        string WardsConnectionString = string.Empty;
        string ATConnectionString = string.Empty;
        string OTConnectionString = string.Empty;
        string BillingConnectionString = string.Empty;
        string HRConnectionString = string.Empty;
        string FNBConnectionString = string.Empty;
        string ConnectionString = string.Empty;
        string RegConnectionString = string.Empty;
        string LabConnectionString = string.Empty;
        string RadiologyConnectionString = string.Empty;
        string PharmacyConnectionString = string.Empty;
        public DischargeSummaryDAL()
        {
            WardsConnectionString = ConfigurationManager.ConnectionStrings["WARDSCONNECTIONSTRING"].ConnectionString;
            RegConnectionString = ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString;
            ATConnectionString = ConfigurationManager.ConnectionStrings["ATConnectionString"].ConnectionString;
            OTConnectionString = ConfigurationManager.ConnectionStrings["OTConnectionString"].ConnectionString;
            BillingConnectionString = ConfigurationManager.ConnectionStrings["BILLConnectionString"].ConnectionString;
            HRConnectionString = ConfigurationManager.ConnectionStrings["HRConnectionString"].ConnectionString;
            FNBConnectionString = ConfigurationManager.ConnectionStrings["FNBConnectionString"].ConnectionString;
            LabConnectionString = ConfigurationManager.ConnectionStrings["LabConnectionString"].ConnectionString;
            ConnectionString = ConfigurationManager.ConnectionStrings[DBConstants.DGCONNECTIONSTRING].ConnectionString;
            RadiologyConnectionString = ConfigurationManager.ConnectionStrings["RadiologyConnectionString"].ConnectionString;
            PharmacyConnectionString = ConfigurationManager.ConnectionStrings["PharmacyConnectionString"].ConnectionString;
        }

        public ResultSet GetDEATHDECLARATIONDETAILSDAL(DyncInput objInput)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetDeathDclrtnDtlsDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetDeathDclrtnDtlsDAL.GetParameterArray(2);
                Oraparam[0] = daGetDeathDclrtnDtlsDAL.GetParameter(DBConstants.P_GETDEATHDECLARATIONDETAILS.PARAM_IV_UHID, objInput.UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetDeathDclrtnDtlsDAL.GetParameter(DBConstants.P_GETDEATHDECLARATIONDETAILS.PARAM_OUT_COMPONENT1, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetDeathDclrtnDtlsDAL.ExecuteDataSet(DBConstants.P_GETDEATHDECLARATIONDETAILS.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetDEATHDECLARATIONDETAILSDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetDEATHDECLARATIONDETAILSDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

       

        public ResultSet GetOTCompletedRequestsDAL(string IPNo, string LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGGetOTRequestsDAL = DataAccessLayerFactory.GetDataAccessLayer(OTConnectionString);

                IDataParameter[] Oraparam = daGGetOTRequestsDAL.GetParameterArray(6);
                Oraparam[0] = daGGetOTRequestsDAL.GetParameter(DBConstants.P_GET_COMPLETED_REQUESTS.PARAM_IV_INPATIENTNO, IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGGetOTRequestsDAL.GetParameter(DBConstants.P_GET_COMPLETED_REQUESTS.PARAM_IN_LOCATIONID, LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGGetOTRequestsDAL.GetParameter(DBConstants.P_GET_COMPLETED_REQUESTS.PARAM_OUT_REQUESTDATA, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[3] = daGGetOTRequestsDAL.GetParameter(DBConstants.P_GET_COMPLETED_REQUESTS.PARAM_OUT_SURGDATA, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[4] = daGGetOTRequestsDAL.GetParameter(DBConstants.P_GET_COMPLETED_REQUESTS.PARAM_OUT_SURGEONSDATA, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[5] = daGGetOTRequestsDAL.GetParameter(DBConstants.P_GET_COMPLETED_REQUESTS.PARAM_OUT_ANAEDATA, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGGetOTRequestsDAL.ExecuteDataSet(DBConstants.P_GET_COMPLETED_REQUESTS.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetOTCompletedRequestsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetOTCompletedRequestsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }


        public ResultSet GetPatientPolicyDetailsDAL(string UHID, string IPNo, string LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetPatientPolicyDetailsDAL = DataAccessLayerFactory.GetDataAccessLayer(BillingConnectionString);

                IDataParameter[] Oraparam = daGetPatientPolicyDetailsDAL.GetParameterArray(5);
                Oraparam[0] = daGetPatientPolicyDetailsDAL.GetParameter(DBConstants.p_getpatientpolicydetails.PARAM_IV_UHID, UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetPatientPolicyDetailsDAL.GetParameter(DBConstants.p_getpatientpolicydetails.PARAM_IV_PATIENTIDENTIFIERNO, IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetPatientPolicyDetailsDAL.GetParameter(DBConstants.p_getpatientpolicydetails.PARAM_IV_LOCATIONID, LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetPatientPolicyDetailsDAL.GetParameter(DBConstants.p_getpatientpolicydetails.PARAM_OUT_PATIENTPOLICY, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[4] = daGetPatientPolicyDetailsDAL.GetParameter(DBConstants.p_getpatientpolicydetails.PARAM_OUT_PATIENTPOLICYMASTER, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetPatientPolicyDetailsDAL.ExecuteDataSet(DBConstants.p_getpatientpolicydetails.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetPatientPolicyDetailsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetPatientPolicyDetailsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        //Discharge Summary Dync
        public ResultSet GetDisSummaryDyncDAL(String IPNo, string LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetDisSummaryDyncDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetDisSummaryDyncDAL.GetParameterArray(14);
                Oraparam[0] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_IV_IPNUMBER, IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_IV_LOCATIONID, LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_OUT_SURGERYDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[3] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_OUT_VITALDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[4] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_OUT_PRESCRIPTIONDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[5] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_OUT_DIAGNOSISDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[6] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_OUT_CASESHEETDETAIL, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[7] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_OUT_DOCTORDETAIL, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[8] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_OUT_FINDINGS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[9] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_OUT_FAMILYHISTORY, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[10] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_OUT_SURGEONSDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[11] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_OUT_ANASTHESIANDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[12] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_OUT_DISCHARGESUMMARY, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[13] = daGetDisSummaryDyncDAL.GetParameter(DBConstants.P_GET_DISCHARGESUMMARYDYNC.PARAM_OUT_DISCHARGESUMMARYDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                rsIP.dsResult = daGetDisSummaryDyncDAL.ExecuteDataSet(DBConstants.P_GET_DISCHARGESUMMARYDYNC.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetDisSummaryDyncDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetDisSummaryDyncDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        //Diet info on Discharge
        public ResultSet GetDietInfoOnIPDischargeDAL(string UHID, string IPNo, string LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetDietInfoOnIPDischargeDAL = DataAccessLayerFactory.GetDataAccessLayer(FNBConnectionString);

                IDataParameter[] Oraparam = daGetDietInfoOnIPDischargeDAL.GetParameterArray(4);
                Oraparam[0] = daGetDietInfoOnIPDischargeDAL.GetParameter(DBConstants.P_GETDIETINFOONIPDISCHARGE.PARAM_IV_UHID, UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetDietInfoOnIPDischargeDAL.GetParameter(DBConstants.P_GETDIETINFOONIPDISCHARGE.PARAM_IV_SERVICENO, IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetDietInfoOnIPDischargeDAL.GetParameter(DBConstants.P_GETDIETINFOONIPDISCHARGE.PARAM_IN_LocationID, LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetDietInfoOnIPDischargeDAL.GetParameter(DBConstants.P_GETDIETINFOONIPDISCHARGE.PARAM_OUT_DIETINFO, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetDietInfoOnIPDischargeDAL.ExecuteDataSet(DBConstants.P_GETDIETINFOONIPDISCHARGE.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetDietInfoOnIPDischargeDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetDietInfoOnIPDischargeDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        //Get Discharge Intimated Details
        public ResultSet GetDischargeIntimatedDAL(string LocationID, string LoginID, string IPNo)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetDischargeIntimatedDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetDischargeIntimatedDAL.GetParameterArray(4);
                Oraparam[0] = daGetDischargeIntimatedDAL.GetParameter(DBConstants.P_GETDISCHARGEINTIMATED.PARAM_IV_LOCATIONID, LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetDischargeIntimatedDAL.GetParameter(DBConstants.P_GETDISCHARGEINTIMATED.PARAM_IV_LOGINID, LoginID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetDischargeIntimatedDAL.GetParameter(DBConstants.P_GETDISCHARGEINTIMATED.PARAM_IV_IPNUMBER, IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetDischargeIntimatedDAL.GetParameter(DBConstants.P_GETDISCHARGEINTIMATED.PARAM_OUT_IPDETAILS, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetDischargeIntimatedDAL.ExecuteDataSet(DBConstants.P_GETDISCHARGEINTIMATED.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetDischargeIntimatedDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetDischargeIntimatedDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        //Get Discharge Intimate Flag       
        public ResultSet GetDSIntimateFlagDAL(string IPNo,string LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetDSIntimateFlagDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetDSIntimateFlagDAL.GetParameterArray(3);
                Oraparam[0] = daGetDSIntimateFlagDAL.GetParameter(DBConstants.P_GETDISCHARGEINTIMATEFLAG.PARAM_iv_LocationId,LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetDSIntimateFlagDAL.GetParameter(DBConstants.P_GETDISCHARGEINTIMATEFLAG.PARAM_iv_IPNumber, IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetDSIntimateFlagDAL.GetParameter(DBConstants.P_GETDISCHARGEINTIMATEFLAG.PARAM_OUT_IPDetails, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetDSIntimateFlagDAL.ExecuteDataSet(DBConstants.P_GETDISCHARGEINTIMATEFLAG.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetDSIntimateFlagDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetDSIntimateFlagDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        //Get UHID
        public ResultSet GetDSUHIDDAL(string IPNo, String LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetDSUHIDDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetDSUHIDDAL.GetParameterArray(3);
                Oraparam[0] = daGetDSUHIDDAL.GetParameter(DBConstants.p_getuhid.PARAM_iv_ipnumber, IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetDSUHIDDAL.GetParameter(DBConstants.p_getuhid.PARAM_iv_locationid, LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetDSUHIDDAL.GetParameter(DBConstants.p_getuhid.PARAM_OUT_details, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetDSUHIDDAL.ExecuteDataSet(DBConstants.p_getuhid.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetDSUHIDDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetDSUHIDDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        //Get Employee Main Details
        public ResultSet GetEmpMainDetailsDAL(int EmployeeId,String LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetEmpMainDetailsDAL = DataAccessLayerFactory.GetDataAccessLayer(HRConnectionString);

                IDataParameter[] Orahrparam = daGetEmpMainDetailsDAL.GetParameterArray(21);
                Orahrparam[0] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_EMPLOYEE_ID, EmployeeId, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Orahrparam[1] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IV_FIRSTNAME, string.Empty, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Orahrparam[2] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_ID_DOB, null, ParameterDirection.Input, null, DbType.DateTime, string.Empty, XDbType.None);
                Orahrparam[3] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_LOCATION_ID, LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Orahrparam[4] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_DEPARTMENT_ID, string.Empty, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Orahrparam[5] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_COSTCENTER_ID, string.Empty, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Orahrparam[6] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_LEVELID, string.Empty, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Orahrparam[7] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_CATEGORYID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Orahrparam[8] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_TYPEID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Orahrparam[9] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_EMPLOYMENTSTATUSID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Orahrparam[10] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_DESIGNATIONID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Orahrparam[11] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_GRADEID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Orahrparam[12] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_SPECIALITYID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Orahrparam[13] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_SCHEDULABLE, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Orahrparam[14] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_CALENDARPRIV, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Orahrparam[15] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_PRESENTEMPID, string.Empty, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Orahrparam[16] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_LOGINID, string.Empty, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Orahrparam[17] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_SUPERVISORID, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Orahrparam[18] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_SPZSERVICES, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Orahrparam[19] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_IN_POSITIONID, string.Empty, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Orahrparam[20] = daGetEmpMainDetailsDAL.GetParameter(DBConstants.P_GETEMPLOYEEMAINDETAILS.PARAM_OUT_EMPMAINDTAILS, null, ParameterDirection.InputOutput, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetEmpMainDetailsDAL.ExecuteDataSet(DBConstants.P_GETEMPLOYEEMAINDETAILS.NAME, CommandType.StoredProcedure, Orahrparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetEmpMainDetailsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetEmpMainDetailsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        //Get Patient Occupied Beds
        public ResultSet GetOccupiedBedsDAL(string IPNo, string UHID, string LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetOccupiedBedsDAL = DataAccessLayerFactory.GetDataAccessLayer(ATConnectionString);

                IDataParameter[] Oraparam = daGetOccupiedBedsDAL.GetParameterArray(5);
                Oraparam[0] = daGetOccupiedBedsDAL.GetParameter(DBConstants.P_GETPATIENTOCCUPIEDBEDS.PARAM_IV_INPATIENTNO, IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetOccupiedBedsDAL.GetParameter(DBConstants.P_GETPATIENTOCCUPIEDBEDS.PARAM_IV_UHID, UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetOccupiedBedsDAL.GetParameter(DBConstants.P_GETPATIENTOCCUPIEDBEDS.PARAM_IN_LOCATIONID, LocationID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[3] = daGetOccupiedBedsDAL.GetParameter(DBConstants.P_GETPATIENTOCCUPIEDBEDS.PARAM_OUT_RESULT, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[4] = daGetOccupiedBedsDAL.GetParameter(DBConstants.P_GETPATIENTOCCUPIEDBEDS.PARAM_OUT_TRANSFERHISTORY, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetOccupiedBedsDAL.ExecuteDataSet(DBConstants.P_GETPATIENTOCCUPIEDBEDS.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetOccupiedBedsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetOccupiedBedsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        //Get PanelParameterMapping
        public ResultSet GetPanelParameterMapping(string _Flag, int SpecialityId, string PatientType, string LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetPnlMpngDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetPnlMpngDAL.GetParameterArray(9);
                Oraparam[0] = daGetPnlMpngDAL.GetParameter("IV_IADSFLAG", _Flag, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetPnlMpngDAL.GetParameter("IV_SPECIALITYID", SpecialityId, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[2] = daGetPnlMpngDAL.GetParameter("IV_PATIENTTYPE", PatientType, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetPnlMpngDAL.GetParameter("IV_LOCATIONID", LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daGetPnlMpngDAL.GetParameter("IV_ACTION", string.Empty, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[5] = daGetPnlMpngDAL.GetParameter("IV_DRAFTSTATUS", 1, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[6] = daGetPnlMpngDAL.GetParameter("IV_REQUIREDDATE", System.DateTime.MinValue, ParameterDirection.Input, null, DbType.DateTime, string.Empty, XDbType.None);
                Oraparam[7] = daGetPnlMpngDAL.GetParameter("OCURSOR_PANELMAPPING", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[8] = daGetPnlMpngDAL.GetParameter("OCURSOR_PARAMETERMAPPING", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetPnlMpngDAL.ExecuteDataSet("wards.P_GetPanelParameterMapping", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetPanelParameterMapping " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetPanelParameterMapping " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        //Get PanelParameterMapping
        public ResultSet GetParameters(string _Flag, int SpecialityId, string PatientType, string LocationID,int PanelID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetPnlMpngDAL = DataAccessLayerFactory.GetDataAccessLayer(ConnectionString);

                IDataParameter[] Oraparam = daGetPnlMpngDAL.GetParameterArray(9);
                Oraparam[0] = daGetPnlMpngDAL.GetParameter("IV_IADSFLAG", _Flag, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetPnlMpngDAL.GetParameter("IV_SPECIALITYID", SpecialityId, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[2] = daGetPnlMpngDAL.GetParameter("IV_PATIENTTYPE", PatientType, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetPnlMpngDAL.GetParameter("IV_LOCATIONID", LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daGetPnlMpngDAL.GetParameter("IV_ACTION", string.Empty, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[5] = daGetPnlMpngDAL.GetParameter("IV_DRAFTSTATUS", 1, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[6] = daGetPnlMpngDAL.GetParameter("IV_REQUIREDDATE", System.DateTime.MinValue, ParameterDirection.Input, null, DbType.DateTime, string.Empty, XDbType.None);
                Oraparam[7] = daGetPnlMpngDAL.GetParameter("IN_PANELID", PanelID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[8] = daGetPnlMpngDAL.GetParameter("OCURSOR_PARAMETERS", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetPnlMpngDAL.ExecuteDataSet("digital.P_GETPARAMETERS", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetParameters " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetParameters " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        //Get Discharge Intimate Flag       
        public ResultSet GetLOVDetails(String lovDetailValue)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetLOVDetailsDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetLOVDetailsDAL.GetParameterArray(2);
                Oraparam[0] = daGetLOVDetailsDAL.GetParameter("V_LOVCODE", lovDetailValue, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetLOVDetailsDAL.GetParameter("OCURSOR_LOVDETAIL", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetLOVDetailsDAL.ExecuteDataSet("wards.P_GETLOVDETAILS", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetDSIntimateFlagDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetDSIntimateFlagDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        //Get Patient Occupied Beds
        public ResultSet GetATDetailsForDischargeDAL(string UHID, string IPNo, string LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetATDetailsForDischargeDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetATDetailsForDischargeDAL.GetParameterArray(4);
                Oraparam[0] = daGetATDetailsForDischargeDAL.GetParameter("iv_InpatientNo", IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetATDetailsForDischargeDAL.GetParameter("iv_UHID", UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetATDetailsForDischargeDAL.GetParameter("in_LocationID", LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetATDetailsForDischargeDAL.GetParameter("oCursor_Result", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetATDetailsForDischargeDAL.ExecuteDataSet("wards.p_rptgetpatientdischargedbeds", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetOccupiedBedsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetOccupiedBedsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        //Get Patient Occupied Beds
        public ResultSet GetAllDoctorsForIPDAL(string UHID, string IPNo, string LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetAllDoctorsForIPDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetAllDoctorsForIPDAL.GetParameterArray(4);
                Oraparam[0] = daGetAllDoctorsForIPDAL.GetParameter("Iv_IpNumber", IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetAllDoctorsForIPDAL.GetParameter("iv_LocationId", LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetAllDoctorsForIPDAL.GetParameter("OCursor_PrimaryDoctor", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[3] = daGetAllDoctorsForIPDAL.GetParameter("OCursor_RefferralDoctors", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetAllDoctorsForIPDAL.ExecuteDataSet("wards.P_GetDoctorsForIP", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetOccupiedBedsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetOccupiedBedsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        //Get Patient Occupied Beds
        public ResultSet GetPatientDetailsWithAllergyPDAL(string UHID, string LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetPatientDetailsWithAllergyPDAL = DataAccessLayerFactory.GetDataAccessLayer(RegConnectionString);

                IDataParameter[] Oraparam = daGetPatientDetailsWithAllergyPDAL.GetParameterArray(16);
               // Oraparam[0] = daGetPatientDetailsWithAllergyPDAL.GetParameter("IN_RegistrationNumber", UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
               // Oraparam[1] = daGetPatientDetailsWithAllergyPDAL.GetParameter("in_LocationID", LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
               //Oraparam[2] = daGetPatientDetailsWithAllergyPDAL.GetParameter("in_MasterFlag", string.Empty, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
               // Oraparam[3] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component1", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // //  Oraparam[3] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component2", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // Oraparam[4] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component3", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // Oraparam[5] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component4", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // Oraparam[6] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component5", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // Oraparam[7] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component6", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // Oraparam[8] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component7", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // Oraparam[9] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component8", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // Oraparam[10] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component9", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // Oraparam[11] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component10", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // Oraparam[12] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component11", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // Oraparam[13] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component12", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // Oraparam[14] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component13", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // Oraparam[15] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component14", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
               // Oraparam[16] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component15", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[0] = daGetPatientDetailsWithAllergyPDAL.GetParameter("IN_RegistrationNumber", UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetPatientDetailsWithAllergyPDAL.GetParameter("in_LocationID", LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component1", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                //  Oraparam[3] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component2", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[3] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component3", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[4] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component4", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[5] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component5", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[6] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component6", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[7] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component7", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[8] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component8", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[9] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component9", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[10] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component10", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[11] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component11", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[12] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component12", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[13] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component13", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[14] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component14", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[15] = daGetPatientDetailsWithAllergyPDAL.GetParameter("ocursor_Component15", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetPatientDetailsWithAllergyPDAL.ExecuteDataSet("registration.p_getpatientdetailswithregno", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetOccupiedBedsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetOccupiedBedsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public InsertResultSet SaveDyncSummaryDAL(string json)
        {
            InsertResultSet rsIP = new InsertResultSet();
            try
            {
                // To convert JSON text contained in string json into an XML node
                json = json.Replace("_at_", "@").Replace("_hash_", "#").Replace("text\": \"@", "text\":\"");
                XmlDocument doc = new XmlDocument();
                string flag=""; 
                if (json.IndexOf("flag") > -1)
                {
                    doc = (XmlDocument)JsonConvert.DeserializeXmlNode(json, "DeathSummaryRequest");
                    flag = (doc).SelectSingleNode("/DeathSummaryRequest/flag").InnerText;
                    if (flag == "DT")
                    {
                        XmlNode el = (XmlNode)doc.SelectSingleNode("/DeathSummaryRequest/flag");

                        if (el != null) { el.ParentNode.RemoveChild(el); }
                        
                    }
                }
                else{

                    doc = (XmlDocument)JsonConvert.DeserializeXmlNode(json, "DischargeSummaryRequest");
                }
                
                
                string xml = SerializeObject(doc);
               xml= xml.Replace("Dischargenumber=\"\"", "Dischargenumber=\"0\"");
                DataAccessLayerBaseClass daSaveDyncSummaryDAL = DataAccessLayerFactory.GetDataAccessLayer(ConnectionString);
                //OracleConnection con = new OracleConnection();
                //con.ConnectionString = ConnectionString;
                //con.Open();

                if (flag == "DT")
                {
                    //OracleCommand com = new OracleCommand("digital.P_DG_SAVEDEATHDYNCDETAILS", con);
                    //com.CommandType = CommandType.StoredProcedure;
                    //com.Parameters.Add("ICLOB_DEATHDETAILS", OracleDbType.Clob, xml, ParameterDirection.Input);
                    //com.ExecuteNonQuery();
                    DataAccessLayerBaseClass daSaveDeathDetailsDAL = DataAccessLayerFactory.GetDataAccessLayer(ConnectionString);

                    IDataParameter[] oraParam = daSaveDeathDetailsDAL.GetParameterArray(1);
                    oraParam[0] = daSaveDeathDetailsDAL.GetParameter("ICLOB_DEATHDETAILS", xml, ParameterDirection.Input, null, DbType.Object, string.Empty, XDbType.Clob);

                    daSaveDeathDetailsDAL.ExecuteQueryByRef("digital.P_DG_SAVEDEATHDYNCDETAILS", CommandType.StoredProcedure, oraParam);


                }
                else
                {
                    //OracleCommand com = new OracleCommand("P_DG_SAVEDISCHARGEDYNCDETAILS", con);
                    //com.CommandType = CommandType.StoredProcedure;
                    //com.Parameters.Add("ICLOB_DISCHARGEDETAILS", OracleDbType.Clob, xml, ParameterDirection.Input);
                    //com.ExecuteNonQuery();
                    DataAccessLayerBaseClass daSaveDeathDetailsDAL = DataAccessLayerFactory.GetDataAccessLayer(ConnectionString);

                    IDataParameter[] oraParam = daSaveDeathDetailsDAL.GetParameterArray(1);
                    oraParam[0] = daSaveDeathDetailsDAL.GetParameter("ICLOB_DISCHARGEDETAILS", xml, ParameterDirection.Input, null, DbType.Object, string.Empty, XDbType.Clob);

                    daSaveDeathDetailsDAL.ExecuteQueryByRef("digital.P_DG_SAVEDISCHARGEDYNCDETAILS", CommandType.StoredProcedure, oraParam);

                }

                //con.Close();
                rsIP.Err_Msg = "SUCCESS";
                #region OHC
                if (rsIP.Err_Msg == "SUCCESS")
                {
                    try
                    {
                        if (flag != "DT")
                        {
                            string IPno = GetFirstInstance("@IPNumber", json);
                            string LocationID = GetFirstInstance("@LocationID", json);
                            if (!string.IsNullOrEmpty(IPno) && !string.IsNullOrEmpty(LocationID))
                            {
                                List<KeyValuePair<string, string>> objAppTriggerIdentifier = new List<KeyValuePair<string, string>>();
                                List<KeyValuePair<string, string>> objAppTriggerParameter = new List<KeyValuePair<string, string>>();
                                OutboundlayerDigital.OHCTrigger objAppOHCTrigger = new OutboundlayerDigital.OHCTrigger();
                                objAppTriggerParameter.Add(new KeyValuePair<string, string>("AppType", "Digital"));
                                objAppTriggerParameter.Add(new KeyValuePair<string, string>("PatientType", "IP"));
                                objAppTriggerIdentifier.Add(new KeyValuePair<string, string>("IPNumber", IPno));
                                objAppOHCTrigger.SendToViaduct(objAppTriggerIdentifier, objAppTriggerParameter, LocationID, "DocumentReference");
                            }
                        }
                    }
                    catch (Exception excep)
                    {
                        LogWriter.Error("Exception occured in OHC to Persona" + excep.Message, "OHC");
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in UpdatePatientStatusDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in UpdatePatientStatusDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;

        }
        #region OHC
        public string GetFirstInstance(string propertyName, string json)
        {
            using (var stringReader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                while (jsonReader.Read())
                {
                    if (jsonReader.TokenType == JsonToken.PropertyName
                        && (string)jsonReader.Value == propertyName)
                    {
                        jsonReader.Read();
                        return ((Newtonsoft.Json.JsonReader)(jsonReader)).Value.ToString();
                    }
                }
                return null;
            }
        }
        #endregion

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
                LogWriter.Error("Exception occured in SerializeObject " + ex.Message, "DETAILED_GOPD_IPPATIENT");
            }         
            return objStringWriter.ToString();

        }

        public ResultSet GetDiagnosisForAnIPNumberDAL(string IPNo, string LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetDiagnosisForAnIPNumberIPDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetDiagnosisForAnIPNumberIPDAL.GetParameterArray(3);
                Oraparam[0] = daGetDiagnosisForAnIPNumberIPDAL.GetParameter("Iv_IPNumber", IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetDiagnosisForAnIPNumberIPDAL.GetParameter("Iv_locationid", LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetDiagnosisForAnIPNumberIPDAL.GetParameter("ORef_DiagnosisDetails", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetDiagnosisForAnIPNumberIPDAL.ExecuteDataSet("wards.P_GETDIAGNOSISFORANIPNUMBER", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetDiagnosisForAnIPNumberDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetDiagnosisForAnIPNumberDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }


        public InsertResultSet CancelPrescriptionDAL(int PrescNo,int PrescDtlID,string LoginID)
        {
            InsertResultSet rsIP = new InsertResultSet();
            try
            {
                //OracleConnection con = new OracleConnection();
                //con.ConnectionString = WardsConnectionString;
                //con.Open();
                //OracleCommand com = new OracleCommand(DBConstants.p_cancelprescription.NAME, con);
                //com.CommandType = CommandType.StoredProcedure;
                //com.Parameters.Add(DBConstants.p_cancelprescription.PARAM_IN_PRESCNO, OracleDbType.Int32, null, ParameterDirection.Input);
                //com.Parameters.Add(DBConstants.p_cancelprescription.PARAM_IN_PRESCDTLID, OracleDbType.Int32, PrescDtlID, ParameterDirection.Input);
                //com.Parameters.Add(DBConstants.p_cancelprescription.PARAM_IV_LOGINID, OracleDbType.Varchar2, LoginID, ParameterDirection.Input);
                //com.ExecuteNonQuery();
                //con.Close();

                DataAccessLayerBaseClass daCancelprescriptionDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);


                IDataParameter[] oraParam = daCancelprescriptionDAL.GetParameterArray(3);
                oraParam[0] = daCancelprescriptionDAL.GetParameter(DBConstants.p_cancelprescription.PARAM_IN_PRESCNO, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                oraParam[1] = daCancelprescriptionDAL.GetParameter(DBConstants.p_cancelprescription.PARAM_IN_PRESCDTLID, PrescDtlID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                oraParam[2] = daCancelprescriptionDAL.GetParameter(DBConstants.p_cancelprescription.PARAM_IV_LOGINID, LoginID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
 

                daCancelprescriptionDAL.ExecuteQuery(DBConstants.p_cancelprescription.NAME, CommandType.StoredProcedure, oraParam);

                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in CancelPrescriptionDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in CancelPrescriptionDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;

        }

        public ResultSet GetPrescriptionDetailsDAL(string UHID, string IPNo, Int32 Status, string LocationID, string LoginID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetPrescriptionDetailsDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetPrescriptionDetailsDAL.GetParameterArray(11);
                Oraparam[0] = daGetPrescriptionDetailsDAL.GetParameter("in_AdmissionNo", null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[1] = daGetPrescriptionDetailsDAL.GetParameter("in_PrescriptionNo", null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[2] = daGetPrescriptionDetailsDAL.GetParameter("iv_UHID", UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetPrescriptionDetailsDAL.GetParameter("iv_LocationId", LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daGetPrescriptionDetailsDAL.GetParameter("iv_IPNumber", IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[5] = daGetPrescriptionDetailsDAL.GetParameter("iv_transactionstatus", Status, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[6] = daGetPrescriptionDetailsDAL.GetParameter("iv_DoctorID", LoginID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[7] = daGetPrescriptionDetailsDAL.GetParameter("OCursor_PrescDetailsTRANS", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[8] = daGetPrescriptionDetailsDAL.GetParameter("OCursor_PrescriptionVitalInfo", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[9] = daGetPrescriptionDetailsDAL.GetParameter("OCursor_PrescriptionDetails", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[10] = daGetPrescriptionDetailsDAL.GetParameter("OCursor_detailsdischargepres", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetPrescriptionDetailsDAL.ExecuteDataSet("wards.P_GetPrescription", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetPrescriptionDetailsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetPrescriptionDetailsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        //get Draft Prescription
        public ResultSet GetDraftPrescriptionDetailsDAL(PreviousPRescInputs input)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass dagetprevpresc = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = dagetprevpresc.GetParameterArray(9);

                Oraparam[0] = dagetprevpresc.GetParameter(DBConstants.DG_GetDraftPrescription.iv_LocationId, input.LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = dagetprevpresc.GetParameter(DBConstants.DG_GetDraftPrescription.iv_IPNumber, input.IPNumber, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = dagetprevpresc.GetParameter(DBConstants.DG_GetDraftPrescription.iv_UHID, input.UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = dagetprevpresc.GetParameter(DBConstants.DG_GetDraftPrescription.iv_DoctorID, input.DoctorID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = dagetprevpresc.GetParameter(DBConstants.DG_GetDraftPrescription.iv_fromdate, input.fromdate, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[5] = dagetprevpresc.GetParameter(DBConstants.DG_GetDraftPrescription.iv_todate, input.todate, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[6] = dagetprevpresc.GetParameter(DBConstants.DG_GetDraftPrescription.iv_currentepisode, input.currentepisode, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[7] = dagetprevpresc.GetParameter(DBConstants.DG_GetDraftPrescription.iv_consultant, input.consultant, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[8] = dagetprevpresc.GetParameter(DBConstants.DG_GetDraftPrescription.PARAM_OUT_PrevPresc, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);

                rsIP.dsResult = dagetprevpresc.ExecuteDataSet(DBConstants.DG_GetDraftPrescription.SPNAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetDraftPrescriptionDetailsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetDraftPrescriptionDetailsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetAllDoctorsForIP(string IPNo, string LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetPrescriptionDetailsDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetPrescriptionDetailsDAL.GetParameterArray(4);
                Oraparam[0] = daGetPrescriptionDetailsDAL.GetParameter("Iv_IpNumber", LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetPrescriptionDetailsDAL.GetParameter("iv_LocationId", IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetPrescriptionDetailsDAL.GetParameter("OCursor_PrimaryDoctor", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[3] = daGetPrescriptionDetailsDAL.GetParameter("OCursor_RefferralDoctors", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetPrescriptionDetailsDAL.ExecuteDataSet("wards.P_GetDoctorsForIP", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetAllDoctorsForIP " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetAllDoctorsForIP " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetWardsInvestigationResultsDAL(string IPNo, string UHID, string LocationID, Int32 RequestStatus)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetWardsInvestigationResultsDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetWardsInvestigationResultsDAL.GetParameterArray(7);
                Oraparam[0] = daGetWardsInvestigationResultsDAL.GetParameter("IN_REQUESTSTATUS", RequestStatus, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[1] = daGetWardsInvestigationResultsDAL.GetParameter("iv_LocationId", LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetWardsInvestigationResultsDAL.GetParameter("iv_IPNumber", IPNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetWardsInvestigationResultsDAL.GetParameter("IV_UHID", UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daGetWardsInvestigationResultsDAL.GetParameter("OREF_RadiologyCURSOR", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[5] = daGetWardsInvestigationResultsDAL.GetParameter("OREF_PhysiotherapyCURSOR", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[6] = daGetWardsInvestigationResultsDAL.GetParameter("OREF_OtherServicesCURSOR", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetWardsInvestigationResultsDAL.ExecuteDataSet("wards.P_GETAllWardsInvestigations", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetWardsInvestigationResultsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetWardsInvestigationResultsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetLRNResultsDAL(string PatientServiceNo, Int32 LRN, string SIN, Int32 LocationID, string UHID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetLRNResultsDAL = DataAccessLayerFactory.GetDataAccessLayer(LabConnectionString);

                IDataParameter[] Oraparam = daGetLRNResultsDAL.GetParameterArray(7);
                Oraparam[0] = daGetLRNResultsDAL.GetParameter("in_PatientServiceNo", PatientServiceNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetLRNResultsDAL.GetParameter("in_LRN", null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[2] = daGetLRNResultsDAL.GetParameter("in_SIN", SIN, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetLRNResultsDAL.GetParameter("in_LocationID", LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daGetLRNResultsDAL.GetParameter("in_UHID", UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[5] = daGetLRNResultsDAL.GetParameter("OUT_CURSOR_TESTREPORTS", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[6] = daGetLRNResultsDAL.GetParameter("OUT_CURSOR_T_RESULTS", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetLRNResultsDAL.ExecuteDataSet("lab.P_GetLRNResults", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetLRNResultsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetLRNResultsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        //PKG_RADIOLOGYREQUEST.P_GETRADIOLOGYREQUESTS
        public ResultSet GetRadiologyRequestDAL(string PatientNo, string RequestNo, Int32 RequestID, Int32 REQUESTDTLID, string UHID, string locationID, string Status, string FromDate, string ToDate)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetRadiologyRequestDAL = DataAccessLayerFactory.GetDataAccessLayer(RadiologyConnectionString);

                IDataParameter[] Oraparam = daGetRadiologyRequestDAL.GetParameterArray(11);
                Oraparam[0] = daGetRadiologyRequestDAL.GetParameter("IV_PATIENTNO", PatientNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetRadiologyRequestDAL.GetParameter("IV_REQUESTNO", null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetRadiologyRequestDAL.GetParameter("IN_REQUESTID", null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[3] = daGetRadiologyRequestDAL.GetParameter("IN_REQUESTDTLID", null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[4] = daGetRadiologyRequestDAL.GetParameter("IV_UHID", UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[5] = daGetRadiologyRequestDAL.GetParameter("IV_LOCATIONID", locationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[6] = daGetRadiologyRequestDAL.GetParameter("IV_STATUS", Status, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[7] = daGetRadiologyRequestDAL.GetParameter("ID_FROMDATE", null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[8] = daGetRadiologyRequestDAL.GetParameter("ID_TODATE", null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[9] = daGetRadiologyRequestDAL.GetParameter("OCURSOR_RADREQUESTS", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[10] = daGetRadiologyRequestDAL.GetParameter("OCURSOR_RADREQUESTDTLS", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetRadiologyRequestDAL.ExecuteDataSet("radiology.PKG_RADIOLOGYREQUEST_P_GETRADIOLOGYREQUESTS", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetRadiologyRequestDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetRadiologyRequestDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetTestParameters_WardsDAL(string strTestId, string strLocationId)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetTestParametersDAL = DataAccessLayerFactory.GetDataAccessLayer(LabConnectionString);

                IDataParameter[] Oraparam = daGetTestParametersDAL.GetParameterArray(3);
                Oraparam[0] = daGetTestParametersDAL.GetParameter("in_TestID", strTestId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetTestParametersDAL.GetParameter("IV_LOCATIONID", strLocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetTestParametersDAL.GetParameter("oref_TestParameters", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetTestParametersDAL.ExecuteDataSet("lab.P_GetTestParameters_Wards", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetTestParameters_WardsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetTestParameters_WardsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetTestParameterDetailsDAL(Int32 TestId, string LocationId, Int32 age, Int32 gender, string agetype)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetTestParameterDetailsDAL = DataAccessLayerFactory.GetDataAccessLayer(OTConnectionString);

                IDataParameter[] Oraparam = daGetTestParameterDetailsDAL.GetParameterArray(6);
                Oraparam[0] = daGetTestParameterDetailsDAL.GetParameter("in_TestID", TestId, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[1] = daGetTestParameterDetailsDAL.GetParameter("IV_LOCATIONID", LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetTestParameterDetailsDAL.GetParameter("IV_AGE", age, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetTestParameterDetailsDAL.GetParameter("IV_GENDER", gender, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[4] = daGetTestParameterDetailsDAL.GetParameter("IV_AGETYPE", agetype, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[5] = daGetTestParameterDetailsDAL.GetParameter("oref_TestParameters", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetTestParameterDetailsDAL.ExecuteDataSet("PKG_CATHLABREPORT.P_GetTestParameterDetails", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetTestParameterDetailsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetTestParameterDetailsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetOTCathlabReportDAL(Int32 TestId, string LocationId)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetOTCathlabReportDAL = DataAccessLayerFactory.GetDataAccessLayer(OTConnectionString);

                IDataParameter[] Oraparam = daGetOTCathlabReportDAL.GetParameterArray(4);
                Oraparam[0] = daGetOTCathlabReportDAL.GetParameter("iv_OTRequestID", TestId, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[1] = daGetOTCathlabReportDAL.GetParameter("iv_LocationId", LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetOTCathlabReportDAL.GetParameter("OCursor_OTDETAILS", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[3] = daGetOTCathlabReportDAL.GetParameter("OCursor_OTObservations", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetOTCathlabReportDAL.ExecuteDataSet("PKG_CATHLABREPORT.P_GetTestParameterDetails", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetOTCathlabReportDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetOTCathlabReportDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetOTCathlabReport(Int32 OTRequestDetailId, string LocationId, Int32 RequestNumber)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetOTCathlabReportDAL = DataAccessLayerFactory.GetDataAccessLayer(OTConnectionString);

                IDataParameter[] Oraparam = daGetOTCathlabReportDAL.GetParameterArray(5);
                Oraparam[0] = daGetOTCathlabReportDAL.GetParameter("iv_OTRequesthdrID", OTRequestDetailId, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[1] = daGetOTCathlabReportDAL.GetParameter("iv_requestdtlid", RequestNumber, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[2] = daGetOTCathlabReportDAL.GetParameter("iv_LocationId", LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetOTCathlabReportDAL.GetParameter("OCursor_OTDETAILS", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[4] = daGetOTCathlabReportDAL.GetParameter("OCursor_OTObservations", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetOTCathlabReportDAL.ExecuteDataSet("PKG_CATHLABREPORT.P_GETOTObservations", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetOTCathlabReport " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetOTCathlabReport " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetServiceNamesDAL(string ServiceDetails, string locationid)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetServiceNamesDAL = DataAccessLayerFactory.GetDataAccessLayer(BillingConnectionString);

                IDataParameter[] Oraparam = daGetServiceNamesDAL.GetParameterArray(3);
                Oraparam[0] = daGetServiceNamesDAL.GetParameter("iCLOB_serviceid", ServiceDetails, ParameterDirection.Input, null, DbType.Object, string.Empty, XDbType.Clob);
                Oraparam[1] = daGetServiceNamesDAL.GetParameter("in_locationid", locationid, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetServiceNamesDAL.GetParameter("ocur_servicenames", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetServiceNamesDAL.ExecuteDataSet("BILLING.p_getservicenames", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetServiceNamesDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetServiceNamesDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetWardsPatientItemDetailsDAL(string IPNumber, Int32 LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetServiceNamesDAL = DataAccessLayerFactory.GetDataAccessLayer(PharmacyConnectionString);

                IDataParameter[] Oraparam = daGetServiceNamesDAL.GetParameterArray(3);
                Oraparam[0] = daGetServiceNamesDAL.GetParameter("IV_IPNUMBER", IPNumber, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetServiceNamesDAL.GetParameter("IV_LOCATIONID", LocationID, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[2] = daGetServiceNamesDAL.GetParameter("OCURSOR_RESULT", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetServiceNamesDAL.ExecuteDataSet("pharmacy.P_WARDS_CREDITPATIENT_ITEMDTLS", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetWardsPatientItemDetailsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetWardsPatientItemDetailsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetEmployeeNamesListOnEmpIDDAL(string employeeDescriptionXml)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetServiceNamesDAL = DataAccessLayerFactory.GetDataAccessLayer(HRConnectionString);

                IDataParameter[] Oraparam = daGetServiceNamesDAL.GetParameterArray(2);
                Oraparam[0] = daGetServiceNamesDAL.GetParameter("ic_employeesDetails", employeeDescriptionXml, ParameterDirection.Input, null, DbType.Object, string.Empty, XDbType.Clob);
                Oraparam[1] = daGetServiceNamesDAL.GetParameter("ocursor_employeesInformation", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetServiceNamesDAL.ExecuteDataSet("hr.P_GETEMPLOYEESLIST", CommandType.StoredProcedure, Oraparam);
                rsIP.dsResult = CommonUtility.GetDataSetCloumnNameToUpper(rsIP.dsResult);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetEmployeeNamesListOnEmpIDDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetEmployeeNamesListOnEmpIDDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet AddCaseSheetDiagnosisDetailsDAL(string diagnosisDetailsXml)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                diagnosisDetailsXml = diagnosisDetailsXml.Replace("&gt;", ">");
                diagnosisDetailsXml = diagnosisDetailsXml.Replace("&lt;", "<");
                DataAccessLayerBaseClass daGetServiceNamesDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);
                IDataParameter[] Oraparam = daGetServiceNamesDAL.GetParameterArray(1);
                Oraparam[0] = daGetServiceNamesDAL.GetParameter("ICLOB_DIAGNOSIS", diagnosisDetailsXml, ParameterDirection.Input, null, DbType.Object, string.Empty, XDbType.Clob);
                rsIP.dsResult = daGetServiceNamesDAL.ExecuteDataSet("wards.P_ADDDIAGNOSIS", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in AddCaseSheetDiagnosisDetailsDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in AddCaseSheetDiagnosisDetailsDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
        public ResultSet GetMMItemsBasedonIPDAL(string UHID, string IPNumber, string LocationID)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetOTCathlabReportDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                IDataParameter[] Oraparam = daGetOTCathlabReportDAL.GetParameterArray(4);
                Oraparam[0] = daGetOTCathlabReportDAL.GetParameter("IV_UHID", UHID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetOTCathlabReportDAL.GetParameter("IV_IPNumber", IPNumber, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetOTCathlabReportDAL.GetParameter("IV_LocationID", LocationID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetOTCathlabReportDAL.GetParameter("OCURSOR_MMItems", null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetOTCathlabReportDAL.ExecuteDataSet("P_GetMMItemsBasedonIP", CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GetMMItemsBasedonIPDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GetMMItemsBasedonIPDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        public InsertResultSet UpdateStatusOfPatientDAL(string IpNo, Int32 Status, string loginID, Int32 DischargeMedication)
        {
            InsertResultSet rsIP = new InsertResultSet();
            try
            {
                DataAccessLayerBaseClass daUpdatepatientStatusDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);


                IDataParameter[] oraParam = daUpdatepatientStatusDAL.GetParameterArray(4);
                oraParam[0] = daUpdatepatientStatusDAL.GetParameter("iv_INPATIENTNO", IpNo, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                oraParam[1] = daUpdatepatientStatusDAL.GetParameter("in_PatientStatusID", Status, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                oraParam[2] = daUpdatepatientStatusDAL.GetParameter("IN_STATUS", DischargeMedication, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                oraParam[3] = daUpdatepatientStatusDAL.GetParameter("iv_LoginID", loginID, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);


                daUpdatepatientStatusDAL.ExecuteQueryByRef("adt.p_updatepatientstatus", CommandType.StoredProcedure, oraParam);


                //OracleConnection con = new OracleConnection();
                //con.ConnectionString = ATConnectionString;
                //con.Open();
                //OracleCommand com = new OracleCommand("adt.p_updatepatientstatus", con);
                //com.CommandType = CommandType.StoredProcedure;
                //com.Parameters.Add("iv_INPATIENTNO", OracleDbType.Varchar2, IpNo, ParameterDirection.Input);
                //com.Parameters.Add("in_PatientStatusID", OracleDbType.Int32, Status, ParameterDirection.Input);
                //com.Parameters.Add("IN_STATUS", OracleDbType.Int32, DischargeMedication, ParameterDirection.Input);
                //com.Parameters.Add("iv_LoginID", OracleDbType.Varchar2, loginID, ParameterDirection.Input);
                //com.ExecuteNonQuery();
                //con.Close();
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in UpdateStatusOfPatientDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in UpdateStatusOfPatientDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        public InsertResultSet DSDyncConvertPdDAL(string json)
        {
            InsertResultSet rsIP = new InsertResultSet();
            try
            {
                // To convert JSON text contained in string json into an XML node
                json = json.Replace("_at_", "@");
                XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(json, "DiagnosisRequest");

                string xml = SerializeObject(doc);
                DataAccessLayerBaseClass daSaveDyncSummaryDAL = DataAccessLayerFactory.GetDataAccessLayer(WardsConnectionString);

                //OracleConnection con = new OracleConnection();
                //con.ConnectionString = WardsConnectionString;
                //con.Open();
                //OracleCommand com = new OracleCommand("wards.P_ADDDIAGNOSIS", con);
                //com.CommandType = CommandType.StoredProcedure;
                //com.Parameters.Add("ICLOB_DIAGNOSIS", OracleDbType.Clob, xml, ParameterDirection.Input);
                //com.ExecuteNonQuery();
                //con.Close();
                IDataParameter[] oraParam = daSaveDyncSummaryDAL.GetParameterArray(1);
                oraParam[0] = daSaveDyncSummaryDAL.GetParameter("ICLOB_DIAGNOSIS", xml, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.Clob);
                
                daSaveDyncSummaryDAL.ExecuteQuery("wards.P_ADDDIAGNOSIS", CommandType.StoredProcedure, oraParam);
                
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in DSDyncConvertPdDAL " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in DSDyncConvertPdDAL " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;

        }
        //insert diagnosis

        public InsertResultSet PostDsDiagData(SaveDsDiaganosis DsDiagnosis)
        {
            InsertResultSet rsDsDiagnosisInformation = new InsertResultSet();
            DataAccessLayerBaseClass _DbAccess = DataAccessLayerFactory.GetDataAccessLayer(ConnectionString);
            try
            {
                foreach (DsDiagnosisInformation iadiaginfo in DsDiagnosis.DsDiagnosisInformation)
                {
                    IDataParameter[] Parms_DsDiagnosisInformation = _DbAccess.GetParameterArray(17);
                    Parms_DsDiagnosisInformation[0] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_IPNUMBER, iadiaginfo.ipnumber, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[1] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_ADMISSIONNO, iadiaginfo.admissionno, ParameterDirection.Input, null, DbType.Double, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[2] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_LocationId, iadiaginfo.locationid, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[3] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_LoginId, iadiaginfo.loginid, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[4] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_DIAGNOSISCODE, iadiaginfo.DiagnosisCode, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[5] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_DIAGNOSISTYPE, iadiaginfo.DiagnosisType, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[6] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_DIAGNOSISNAME, iadiaginfo.DiagnosisName, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[7] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_DIAGNOSISID, iadiaginfo.DiagnosisId, ParameterDirection.Input, null, DbType.Double, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[8] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_COMMENTS, iadiaginfo.comments, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[9] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_Side, iadiaginfo.Side, ParameterDirection.Input, null, DbType.Double, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[10] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_Location, iadiaginfo.Location, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[11] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_CONFIDENTIAL, iadiaginfo.Confidential, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[12] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_SORTORDER, iadiaginfo.SortOrder, ParameterDirection.Input, null, DbType.Double, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[13] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_PRINT, iadiaginfo.DiagnosisPrint, ParameterDirection.Input, null, DbType.Double, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[14] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_CHRONICPROBLEM, iadiaginfo.chronicproblem, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[15] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_FLAG, iadiaginfo.flag, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                    Parms_DsDiagnosisInformation[16] = _DbAccess.GetParameter(DBConstants.DG_IADiagnosisInformation.PARAM_IV_STATUS, iadiaginfo.Diagnosisstatus, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                    _DbAccess.ExecuteQuery(DBConstants.DG_IADiagnosisInformation.Name, CommandType.StoredProcedure, Parms_DsDiagnosisInformation);
                }
                rsDsDiagnosisInformation.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsDsDiagnosisInformation.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;

                #region OHC
                if (rsDsDiagnosisInformation.Err_Code == 1)
                {
                    try
                    {
                        List<KeyValuePair<string, string>> objConTriggerIdentifier = new List<KeyValuePair<string, string>>();
                        List<KeyValuePair<string, string>> objConTriggerParameter = new List<KeyValuePair<string, string>>();
                        OutboundlayerDigital.OHCTrigger objAppOHCTrigger = new OutboundlayerDigital.OHCTrigger();
                        objConTriggerParameter.Add(new KeyValuePair<string, string>("AppType", "Digital"));
                        objConTriggerParameter.Add(new KeyValuePair<string, string>("PatientType", "IP"));
                        objConTriggerIdentifier.Add(new KeyValuePair<string, string>("InPatientNo", DsDiagnosis.DsDiagnosisInformation[0].ipnumber));
                        objAppOHCTrigger.SendToViaduct(objConTriggerIdentifier, objConTriggerParameter, DsDiagnosis.DsDiagnosisInformation[0].locationid, "Condition");
                    }

                    catch (Exception excep)
                    {
                        LogWriter.Error("Exception occured in SaveDsDiagnosisInformation " + excep.ToString(), "DETAILED_IPPATIENT_Discharge Summary");
                    }
                }
                #endregion
            }
            catch (Exception Ex)
            {
                rsDsDiagnosisInformation.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsDsDiagnosisInformation.Err_Msg = Ex.Message;
                LogWriter.Error("Exception occured in SaveDsDiagnosisInformation " + Ex.ToString(), "DETAILED_IPPATIENT_Discharge Summary");
                throw Ex;
            }
            return rsDsDiagnosisInformation;

        }
        //Get Specialities
        public ResultSet GetSpecialityDetails(string LocationId)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass daGetSpecialities = DataAccessLayerFactory.GetDataAccessLayer(HRConnectionString);

                IDataParameter[] Oraparam = daGetSpecialities.GetParameterArray(5);
                Oraparam[0] = daGetSpecialities.GetParameter(DBConstants.p_getlocationspecialities.PARAM_in_mappingid, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = daGetSpecialities.GetParameter(DBConstants.p_getlocationspecialities.PARAM_in_specialityid, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[2] = daGetSpecialities.GetParameter(DBConstants.p_getlocationspecialities.PARAM_in_locationId, LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = daGetSpecialities.GetParameter(DBConstants.p_getlocationspecialities.PARAM_out_locations, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[4] = daGetSpecialities.GetParameter(DBConstants.p_getlocationspecialities.PARAM_out_locnspecialities, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                rsIP.dsResult = daGetSpecialities.ExecuteDataSet(DBConstants.p_getlocationspecialities.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GETSPECIALITYDETAILS " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GETSPECIALITYDETAILS " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }

        //Get ReviewConsultants
        public ResultSet GetReviewConsultants(string LocationId)
        {
            ResultSet rsIP = new ResultSet();
            try
            {
                DataAccessLayerBaseClass dareviewconsultants = DataAccessLayerFactory.GetDataAccessLayer(HRConnectionString);

                IDataParameter[] Oraparam = dareviewconsultants.GetParameterArray(5);
                Oraparam[0] = dareviewconsultants.GetParameter(DBConstants.P_GETDOCTORS.PARAM_IV_DEPARTMENTID, null, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[1] = dareviewconsultants.GetParameter(DBConstants.P_GETDOCTORS.PARAM_in_Specialityid, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                Oraparam[2] = dareviewconsultants.GetParameter(DBConstants.P_GETDOCTORS.PARAM_in_locationId, LocationId, ParameterDirection.Input, null, DbType.String, string.Empty, XDbType.None);
                Oraparam[3] = dareviewconsultants.GetParameter(DBConstants.P_GETDOCTORS.PARAM_out_doctors, null, ParameterDirection.Output, null, DbType.Object, string.Empty, XDbType.RefCursor);
                Oraparam[4] = dareviewconsultants.GetParameter(DBConstants.P_GETDOCTORS.PARAM_iv_flag, null, ParameterDirection.Input, null, DbType.Int32, string.Empty, XDbType.None);
                rsIP.dsResult = dareviewconsultants.ExecuteDataSet(DBConstants.P_GETDOCTORS.NAME, CommandType.StoredProcedure, Oraparam);
                rsIP.Err_Code = CONSTANTS.DEBUG_SUCCESS_CODE;
                rsIP.Err_Msg = CONSTANTS.DEBUG_SUCCESS_MESSAGE;
            }
            catch (Exception ex)
            {
                rsIP.dsResult = null;
                rsIP.Err_Code = CONSTANTS.DEBUG_FAILURE_CODE;
                rsIP.Err_Msg = ex.Message;
                LogWriter.Error("Exception occured in GETREVIEWCONSULTANTS " + ex.Message, "DETAILED_GOPD_IPPATIENT");
                LogWriter.Error("Exception occured in GETREVIEWCONSULTANTS " + ex.StackTrace, "ERROR_GOPD_IPPATIENT");
                throw (ex);
            }
            return rsIP;
        }
    }
}
