using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCS.DigitalIPHospitalService.DAL
{
    public class DBConstants
    {
        internal const string DGCONNECTIONSTRING = "DGConnectionString";
        internal const string LABCONNECTIONSTRING = "LabConnectionString";
        internal const string WARDSCONNECTIONSTRING = "WardsConnectionString";
        internal const string ALLERGYCONNECTIONSTRING = "AllergyConnectionString";
        internal const string SECURITYCONNECTIONSTRING = "SecurityConnectionString";
        internal const string ESCONNECTIONSTRING = "ESConnectionString";
        internal const string OTCONNECTIONSTRING = "OTConnectionString";
        internal const string AHCCONNECTIONSTRING = "AHCConnectionString";
        internal const string RSCONNECTIONSTRING = "RegistrationConnectionString";
        internal const string BILLCONNECTIONSTRING = "BILLConnectionString";
        internal const string HRCONNECTIONSTRING = "HRConnectionString";
        internal const string FNBCONNECTIONSTRING = "FNBConnectionString";
        internal const string RADIOLOGYCONNECTIONSTRING = "RadiologyConnectionString";
        internal const string PHARMACYCONNECTIONSTRING = "PharmacyConnectionString";
        internal const string ATCONNECTIONSTRING = "ATConnectionString";
        internal const string MMCONNECTIONSTRING = "MMConnectionString";
        internal const string BBCONNECTIONSTRING = "BBConnectionString";
        internal const string RegistrationConnectionString = "RegistrationConnectionString";
        internal const string ACECONNECTIONSTRING = "ACEConnectionString";
        internal const string eHISCONNECTIONSTRING = "EHISConnectionString";
        internal const string MNMCONNECTIONSTRING = "MNMConnectionString";

        public class DG_GETIPDOCTORDASHBOARD_ALL
        {
            internal const string NAME = "DIGITAL.DG_GETIPDOCTORDASHBOARD_ALL";
            internal const string PARAM_IN_ResourceId = "IV_RESOURCEID";
            internal const string PARAM_IN_LocationId = "IV_location";
            internal const string PARAM_OUT_SERVICEITEM = "REFCURS_IP";
        }
        public class P_ADDFAVORITELIST
        {
            internal const string NAME = "LAB.P_ADDFAVORITELIST";
            internal const string PARAM_IN_FAVDETAILS = "iclob_FavoriteDetails";
            internal const string PARAM_OUT_ReturnCode = "on_ReturnCode";
        }
        //Search History details start
        public class DG_SEARCHHISTORY_IP
        {
            internal const string NAME = "DIGITAL.DG_SEARCHHISTORY_IP";
            internal const string PARAM_IN_ResourceId = "IV_RESOURCEID";
            internal const string PARAM_IN_LocationId = "IV_LOCATION";
            internal const string PARAM_IN_IPNumber = "IV_IPNUMBER";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_OUT_SERVICEITEM = "REFCURS_IP";
        }
        //Search History details end
        public class P_DG_SAVEDIAGNOSIS
        {
            internal const string SPNAME = "DIGITAL.p_dg_savediagnosis_chronic";
            internal const string PARAM_IN_REMARKS = "IV_REMARKS";
            internal const string PARAM_IN_INACTIVATEDDATE = "IV_INACTIVATEDDATE";
            internal const string PARAM_IN_DIAGNOSISID = "IV_DIAGNOSISID";
            internal const string PARAM_IN_CHRONICPROBLEM = "IV_CHRONICPROBLEM";
            internal const string PARAM_IN_DoctorId = "IV_DoctorId";

        }
        public class P_FALLRISKASSESSMENTRPT
        {
            internal const string SPNAME = "FORMGEN.P_FALLRISKASSESSMENTRPT";
            internal const string PARAM_in_formid = "IV_FORMID";
            internal const string PARAM_in_uhid = "IV_UHID";
            internal const string PARAM_in_ipnumber = "IV_IPNO";
            internal const string PARAM_in_locationId = "IV_LOCATIONID";
            internal const string PARAM_in_doctorId = "IV_DOCTORID";
            internal const string PARAM_in_patienttype = "IV_PATIENTTYPE";
            internal const string PARAM_Out_DETAILS = "OCURSOR_DETAILS";
            internal const string PARAM_Out_DETAILSONE = "OCURSOR_DETAILSONE";
        }
        public class DG_GETDISCHARGEPLAN
        {
            internal const string NAME = "DIGITAL.DG_GetDischargeSummaryList";
            internal const string PARAM_IN_LocationId = "IV_location";
            internal const string PARAM_OUT_DISCHARGEPLAN = "REFCURS_DISCHARGEPLAN";

        }
        public class DG_GetDoctorSettings
        {
            internal const string NAME = "digital.DG_GetDoctorSettings";
            internal const string PARAM_IN_DoctorId = "in_DoctorId";
            internal const string PARAM_OUT_Result_Defaults = "oCursor_Result_DEFAULTS";
        }
        public class DG_GetDoctorDefaultSettings
        {
            internal const string NAME = "DIGITAL.DG_GetDoctorDefaultSettings";
            internal const string PARAM_IN_DoctorId = "in_DoctorId";
            internal const string PARAM_IN_LocationId = "in_LocationID";
            internal const string PARAM_OUT_Result_DefaultDashboard = "oCursor_Result_DD";
            internal const string PARAM_OUT_Result_DefaultSortOrder = "oCursor_Result_DS";
            internal const string PARAM_OUT_Result_AutoSave = "oCursor_Result_AS";
            internal const string PARAM_OUT_Result_ShortLinksSequence = "oCursor_Result_DSEQ";
            internal const string PARAM_OUT_Result_Defaults = "oCursor_Result_DEFAULTS";
        }
        public class GETWARDNAME
        {
            internal const string SPNAME = "ADT.P_GetWardLevelMaster";
            internal const string PARAM_IN_PARENTLEVELID = "in_ParentLevelID";
            internal const string PARAM_IN_LEVELDETAILCODE = "iv_LevelDetailCode";
            internal const string PARAM_IN_LEVELDETAILNAME = "iv_LevelDetailName";
            internal const string PARAM_IN_LEVELTYPEID = "in_LevelTypeID";
            internal const string PARAM_IN_LEVELOCCUPANCYID = "in_LevelOccupancyTypeID";
            internal const string PARAM_IN_LEVELSPECIALITYID = "in_LevelSpecialityID";
            internal const string PARAM_IN_STATUS = "in_Status";
            internal const string PARAM_IN_LOCATIONID = "in_LocationID";
            internal const string PARAM_OUT_WARDNAME = "oCursor_LevelMaster";
        }
        public class DG_AddDoctorDefaultSettings
        {
            internal const string NAME = "DIGITAL.DG_AddDoctorDefaultSettings";
            internal const string PARAM_IN_DoctorId = "in_DoctorId";
            internal const string PARAM_IN_LocationId = "in_LocationID";
            internal const string PARAM_IN_LOVId = "in_lovid";
            internal const string PARAM_IN_LOVDetailId = "in_lovdetailid";
            internal const string PARAM_IN_LOVValue = "in_lovvalue";
            internal const string PARAM_IN_User = "in_user";
        }

        public class DB_GETLOGINDETAILS
        {
            internal const string NAME = "SECURITYTEST_64.P_GETUSERBASELOCATION";
            internal const string PARAM_IN_LOGINID = "p_LOGINID";
            internal const string PARAM_OUT_BASELOCATION = "p_BASELOCATION";
            internal const string PARAM_OUT_BASELOCATIONID = "p_BASELOCATIONID";
            internal const string PARAM_OUT_USERNAME = "p_USERNAME";
            internal const string PARAM_OUT_EMPLOYEEID = "p_EMPLOYEEID";
            internal const string PARAM_IN_USERID = "in_userid";
            internal const string PARAM_OUT_USERROLE = "ocursor_userroles";
            internal const string ROLE_NAME = "digital.p_getuserroles";
            internal const string PARAM_IN_RESOURCEID = "in_resourceid";
            internal const string PARAM_OUT_SPECIALITY = "o_speaciality";
            internal const string SPECIALITY_NAME = "Digital.dg_getspecialiy";

        }
        public class DG_GetDoctorId
        {
            internal const string SPNAME = "DIGITAL.DG_GetDoctorId";
            internal const string PARAM_IN_OPNUMBER = "IV_OPNUMBER";
            internal const string PARAM_IN_VISITID = "IV_VISITID";
            internal const string PARAM_OUT_PRIMARYDOC = "cursor_DOCTORID";
        }
        public class DG_GETPRIMARYDOC_DET
        {
            internal const string SPNAME = "DIGITAL.DG_GETPRIMARYDOCTOR_DET";
            internal const string PARAM_IN_APPOINTMENTID = "IN_APPID";
            internal const string PARAM_IN_BILLINGNUM = "IN_BILLINGNUM";
            internal const string PARAM_OUT_PRIMARYDOC = "OCURSOR_DOCID";

        }
        public class DG_GETDOCTORINOUTSTATUS
        {
            internal const string NAME = "DIGITAL.DG_GETDOCTORINOUT";
            internal const string PARAM_IN_DOCTORID = "IV_DOCTORID";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUT_DOCTORSTATUS = "OCURSOR_STATUS";
        }
        public class DG_GETROOMID
        {
            internal const string NAME = "DIGITAL.DG_GETROOMID";
            internal const string PARAM_IN_DOCTORID = "IV_DOCTORID";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUT_ROOMID = "OUT_ROOMID_CURSOR";
        }
        public class DG_POSTDOCTORINOUTSTATUS
        {
            internal const string NAME = "WARDS.P_ADDOPDOCTOINOUTTIME";
            internal const string PARAM_IN_INOUTID = "IV_INOUTID";
            internal const string PARAM_IN_DOCTORID = "IV_DOCTORID";
            internal const string PARAM_IN_LOGINID = "IV_LOGINID";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_ROOMID = "IV_ROOMID";
            internal const string PARAM_IN_FLAG = "IV_FLAG";
            internal const string PARAM_IN_REASON = "IV_REASON";
            internal const string PARAM_REASON = "BY DOCTOR";
        }
        /// <summary>
        /// 
        /// </summary>
        public class DG_GETIPPATIENTBYWARDDOCTOR
        {
            internal const string NAME = "DIGITAL.DG_GETIPPATIENTSBYWARD_DOCTOR";
            internal const string PARAM_IN_WardNo = "IV_WARDS";
            internal const string PARAM_IN_ResourceId = "IV_RESOURCEID";
            internal const string PARAM_IN_LocationId = "IV_location";
            internal const string PARAM_OUT_SERVICEITEM = "REFCURS_IP";
        }

        public class DG_GET_ALLERGIESCHANGED
        {
            internal const string SPNAME = "DIGITAL.p_get_allallergies";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_OUT_O_ALLERGYDETAILS = "O_ALLERGYDETAILS";
            internal const string PARAM_OUT_O_GROUPMAPPINGS = "O_GROUPMAPPINGS";
            internal const string PARAM_OUT_O_AUDITDETAILS = "O_AUDITDETAILS";

        }

        public class DG_ADD_ALLERGIESCHANGED
        {
            internal const string SPNAME = "DIGITAL.P_ADD_UPDATEALLERGY";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_RESOURCEID = "IN_RESOURCEID";
            internal const string PARAM_IN_ALLERGYTYPEID = "IN_ALLERGYTYPEID";
            internal const string PARAM_IN_ALLERGYSEVERITYID = "IN_ALLERGYSEVERITYID";
            internal const string PARAM_IN_ALLERGENID = "IN_ALLERGENID";
            internal const string PARAM_IN_GROUPID = "IN_GROUPID";
            internal const string PARAM_IN_ALLERGYNAME = "IN_ALLERGYNAME";
            internal const string PARAM_IN_ALLERGYDESC = "IN_ALLERGYDESC";
            internal const string PARAM_IN_ID = "IN_ID";
            internal const string PARAM_IN_SAVEDRAFTID = "IN_SAVEDRAFTID";
            internal const string PARAM_IN_FLAG = "IN_FLAG";
            internal const string PARAM_IN_DRAFTFLAG = "IN_TRANSFLAG";
            internal const string PARAM_IN_REMARKS = "IN_REMARKS";
            internal const string PARAM_IN_INACTIVATIONDATE = "IN_INACTIVATIONDATE";

        }

        //Bill Type for Visits Screen
        public class DG_PATIENTBILLTYPE
        {
            internal const string NAME = "DIGITAL.DG_PATIENTBILLTYPE";
            internal const string PARAM_IN_IpNumber = "IN_IPNUMBER";
            internal const string PARAM_IN_LocationId = "IN_LOCATIONID";
            internal const string PARAM_OUT_BillTypeDetails = "OCUR_DETAILS";
        }
        //Gourav
        public class DG_GETLRNRESULT
        {
            internal const string SP_NAME = "DIGITAL.P_DG_GETLRNRESULT";
            //internal const string PARAM_IN_EpisodeType = "IV_EPISODETYPE";
            internal const string PARAM_IN_LocationId = "IN_LOCATIONID";
            internal const string PARAM_IN_TIMEDIFF = "IN_TIMEDIFF";
            internal const string PARAM_IN_DOCTORID = "IN_DOCTORID";
            internal const string PARAM_OUT_IPLRNDETAILS = "oref_iplrndetails";
            internal const string PARAM_OUT_OPLRNDETAILS = "oref_oplrndetails";
            internal const string PARAM_OUT_AHCLRNDETAILS = "oref_ahclrndetails";
        }
        public class DG_GETDRNRESULT
        {


            internal const string SP_NAME = "DIGITAL.P_DG_GETRESULTDETAIL";
            internal const string PARAM_IN_LocationId = "IN_LOCATIONID";
            internal const string PARAM_IN_TIMEDIFF = "IN_TIMEDIFF";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_PATIENTSERVICENO = "IN_PATIENTSERVICENO";
            internal const string PARAM_OUT_RESULTS = "OREF_RESULTDETAILS";
        }

        public class LAB_GETTESTRESULTS
        {
            internal const string SP_NAME = "DIGITAL.p_dg_gettestresult";
            internal const string PARAM_IN_LOCATIONID = "in_locationid";
            internal const string PARAM_IN_LRN = "in_lrn";
            internal const string PARAM_IN_UHID = "in_uhid";
            internal const string PARAM_IN_PATIENTSERVICENO = "in_patientserviceno";
            internal const string PARAM_OUT_TESTDETAILS = "oref_testdetails";
        }

        public class DG_GETRESULTS
        {
            internal const string SP_NAME = "DIGITAL.P_DG_GETRESULTS";
            internal const string NURSE_NAME = "DIGITAL.P_GETRECENTRESULTS_DG";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_TIMEDIFF = "IN_TIMEDIFF";
            internal const string PARAM_IN_DOCTORID = "IN_DOCTORID";
            internal const string PARAM_IN_NURSEID = "IN_NURSEID";
            internal const string PARAM_OUT_IPLRNDetails = "OREF_IPLRNDETAILS";
            internal const string PARAM_OUT_OPLRNDetails = "OREF_OPLRNDETAILS";
            internal const string PARAM_OUT_AHCLRNDetails = "OREF_AHCLRNDETAILS";
        }

        public class LAB_GETTESTREPORT
        {
            internal const string SP_NAME = "LAB.p_gettestreport";
            internal const string PARAM_IN_LRN = "in_lrn";
            internal const string PARAM_IN_GroupName = "in_groupname";
            internal const string PARAM_IN_RequestedID = "in_requesttestid";
            internal const string PARAM_IN_PatientServiceNo = "iv_patientserviceno";
            internal const string PARAM_IN_LocationID = "iv_locationid";
            internal const string PARAM_IN_TestID = "iv_testid";
            internal const string PARAM_IN_UHID = "iv_uhid";
            internal const string PARAM_IN_AgeType = "iv_agetype";
            internal const string PARAM_IN_Age = "iv_age";
            internal const string PARAM_IN_Gender = "iv_gender";
            internal const string PARAM_OUT_LRNDetails = "oref_lrndetails";
            internal const string PARAM_OUT_TestParameter = "oref_testparameter";
            internal const string PARAM_OUT_TestsCountForLRN = "oref_testscountforlrn";
            internal const string PARAM_IN_SearchBy = "iv_searchby";
            internal const string PARAM_IN_DepartmentID = "in_departmnetid";
            internal const string PARAM_IN_LoginID = "in_loginid";
        }

        public class dg_getOPDDiagnostics
        {
            internal const string SPNAME = "DIGITAL.dg_getOPDDiagnostics";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUT_DIAGNOSIS = "OCURSOR_OPDIAGNOSIS";
        }
        //Admission Note Details
        public class DG_ADMISSIONNOTEVIEW
        {
            internal const string NAME = "DIGITAL.DG_ADMISSIONNOTEVIEW";
            internal const string PARAM_IN_IpNumber = "IN_IPNUMBER";
            internal const string PARAM_IN_LocationId = "IN_LOCATIONID";
            internal const string PARAM_IN_ADMISSIONNO = "IN_ADMISSIONNO";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_OUT_ADMISSIONNOTE = "OCUR_ADMISSIONNOTE";
        }
        //Past surgery details
        public class DG_PASTSURGERY
        {
            internal const string NAME = "DIGITAL.DG_PASTSURGERY";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_LocationId = "IN_LOCATIONID";
            internal const string PARAM_IN_IPNUMBER = "IN_IPNUMBER";
            internal const string PARAM_OUT_SURGDETAILS = "OCUR_SURGDETAILS";
            internal const string PARAM_OUT_OPERATIONNOTES = "OCUR_OPERATIONNOTES";
        }

        public class DG_GETPROGRESSNOTE
        {
            internal const string NAME = "DIGITAL.dg_getipsoap";
            internal const string PARAM_IN_Ipnumber = "in_ipnumber";
            internal const string PARAM_IN_ResourceId = "in_doctorid";
            internal const string PARAM_IN_LocationId = "in_locationid";
            internal const string PARAM_OUT_SERVICEITEM = "out_details";
        }
        //Progress Notes Save
        public class DG_ADDIPSOAP
        {
            internal const string SPNAME = "DIGITAL.P_ADDIPSOAP";
            internal const string PARAM_IN_SOAPID = "IN_SOAPID";
            internal const string PARAM_IN_ADMISSIONNO = "IN_ADMISSIONNO";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_IPNUMBER = "IN_IPNUMBER";
            internal const string PARAM_IN_CREATEDBY = "IN_CREATEDBY";
            internal const string PARAM_IN_STATUS = "IN_STATUS";
            internal const string PARAM_IN_UPDATEDBY = "IN_UPDATEDBY";
            internal const string PARAM_IN_SUBJECTIVE = "IN_SUBJECTIVE";
            internal const string PARAM_IN_OBJECTIVE = "IN_OBJECTIVE";
            internal const string PARAM_IN_ASSESSMENT = "IN_ASSESSMENT";
            internal const string PARAM_IN_PLAN = "IN_PLAN";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_NOTESTYPE = "IN_NOTESTYPE";
            internal const string PARAM_IN_EDUCATION = "IN_EDUCATION";
            internal const string PARAM_IN_PAINSCORE = "IN_PAINSCORE";
            internal const string PARAM_IN_DOCTORID = "IN_DOCTORID";
            internal const string PARAM_IN_COMMENTS = "IN_COMMENTS";
        }

        #region IP vitals
        public class DG_GETVITALDETAILS
        {
            internal const string SPNAME = "DIGITAL.p_DG_GetipVitalDetails";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_VITALFLAG = "IV_VITALFLAG";
            internal const string PARAM_OUT_VITALDETAILS = "OCURSOR_VITALDETAILS";
            //internal const string PARAM_OUT_DAVITALDETAILS = "OCURSOR_DAVITALDETAILS";
        }

        /*Vitals history*/
        public class DG_GETVITALHistory
        {
            internal const string SPNAME = "DIGITAL.dg_getdavitalgraphrecords";
            internal const string PARAM_IV_UHID = "iv_uhid";
            internal const string PARAM_IV_IPNUMBER = "iv_ipnumber";
            internal const string PARAM_IV_LOCATIONID = "iv_locationid";
            internal const string PARAM_IV_PARAMETERID = "iv_parameterid";
            internal const string PARAM_IV_datefrom = "IV_datefrom";
            internal const string PARAM_IV_dateto = "IV_dateto";
            internal const string PARAM_IV_vitalflag = "IV_vitalflag";
            internal const string PARAM_OUT_IPVITALHISTORY = "OCURSOR_IPVITALHISTORY";

        }
        public class DG_DIGITAL_VITALDETAILS
        {
            internal const string NAME = "DIGITAL.P_DG_SAVEIPVITALCHILDDETAILS";
            internal const string PARAM_IN_IPVITALCHILD = "V_IPVITALCHILD";
            //internal const string PARAM_IN_OPVITALID = "IV_OPVITALID";
            internal const string PARAM_IN_PARAMETERID = "IV_PARAMETERID";
            internal const string PARAM_IN_VITALVALUE1 = "IV_VITALVALUE1";
            internal const string PARAM_IN_VITALVALUE2 = "IV_VITALVALUE2";
            internal const string PARAM_IN_VITALVALUE3 = "IV_VITALVALUE3";
            internal const string PARAM_IN_VITALUNITID = "IV_VITALUNITID";
            internal const string PARAM_IN_VITALREMARKS = "IV_VITALREMARKS";
            internal const string PARAM_IN_CREATEDBY = "IV_CREATEDBY";
            internal const string PARAM_IN_CREATEDDATE = "IV_CREATEDDATE";
            internal const string PARAM_IN_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_LocationID = "IV_LocationID";
            internal const string PARAM_IN_FLAG = "IN_FLAG";
            internal const string PARAM_IN_PAINSCORETYPE = "IV_PAINSCORETYPE";

        }

        #endregion

        #region Instruction
        //gouri
        public class DG_GETIPPATIENTSINSTRUCTIONS
        {
            internal const string SPNAME = "DIGITAL.P_DG_GETINSTRUCTIONS";
            internal const string PARAM_IN_IpNumber = "IN_IPNUMBER";
            internal const string PARAM_IN_DoctorId = "IN_DOCTORID";
            internal const string PARAM_IN_LocationId = "IN_LOCATIONID";
            internal const string PARAM_OUT_InstructionDetails = "OUT_INSTRUCTIONSDETAILS";
            internal const string PARAM_OUT_InstructionBatchValue = "out_InstructionBatchValue";

        }
        public class DG_GETROLES
        {
            internal const string SPNAME = "DIGITAL.P_DG_GETROLES_new";
            internal const string PARAM_IN_RoleName = "in_rolenames";
            internal const string PARAM_IN_LocationId = "iv_locationid";
            internal const string PARAM_IN_ModuleId = "in_moduleid";
            internal const string PARAM_OUT_UserRoles = "ocursor_userroles";
        }
        // end//

        //Ranjith Hv
        public class DG_GETINSTRUCTIONSET
        {
            internal const string SPNAME = "WARDS.P_GETROLEINSTRUCTIONMAPPING";//"DG_GETInstructionSetOnROLES";
            internal const string IN_RoleId = "IN_ROLEID";
            internal const string IN_InstructionId = "IV_INSTRUCTIONID";
            internal const string IN_LocationId = "IV_LOCATIONID";
            internal const string PARAM_OUT_UserInstr = "OCURSOR_ROLEINSTRUCTIONMAPPING";
        }

        public class DG_GETNAME
        {
            internal const string SPNAME = "DIGITAL.P_DG_getMappedDoctors";
            internal const string IN_LoginId = "IV_PRIMARYDOCTOR";
            internal const string IN_LocationId = "IV_LOCATIONID";
            internal const string IN_IpNumber = "IV_IPNUMBER";
            internal const string PARAM_OUT_PCTRESULTS = "OCURSOR_PCTRESULTS";
            internal const string PARAM_OUT_PCTCOUNT = "OCURSOR_PCTCOUNT";
        }

        public class DG_Acknowledge_Instruction
        {
            internal const string SPNAME = "DIGITAL.DG_Acknowledge_Instruction";
            internal const string PARAM_IV_GIVENBYID = "IV_GIVENBYID";
            internal const string PARAM_IV_GIVENBYROLE = "IV_GIVENBYROLE";
            internal const string PARAM_IV_GIVENTOID = "IV_GIVENTOID";
            internal const string PARAM_IV_GIVENTOROLE = "IV_GIVENTOROLE";
            internal const string PARAM_IV_ACKREMARKS = "IV_ACKREMARKS";
            internal const string PARAM_IV_InsAckBatchId = "IV_InsAckBatchId";
            internal const string PARAM_IV_AcknowledgedByFlag = "IV_AcknowledgedByFlag";
            internal const string PARAM_IV_PARENTCHATID = "IV_PARENTCHATID";
            internal const string PARAM_IV_INSGIVENDATE = "IV_INSGIVENDATE";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";

        }

        public class DG_RoleType
        {
            internal const string SPNAME = "DIGITAL.DG_GetRoletype";
            internal const string IN_IPNumber = "IN_IPNUMBER";
            internal const string IN_LoginDoctorNo = "IN_LOGINDOCTORNO";
            internal const string IN_LocationId = "IN_LOCATIONID";
            internal const string PARAM_OUT = "OCURSOR_ROLETYPE";
        }
        #endregion

        //PatlandingAcordion
        public class dg_PAtLAND
        {
            internal const string NAME = "DIGITAL.DG_PATLANDACCORDIANUPDATEINFO";
            internal const string ipnumber = "in_ipnumber";
            internal const string UHID = "IV_UHID";
            internal const string locationid = "in_locationId";
            internal const string REFCURS_IP = "PATLANDCURS_IP";
        }


        //Discharge Summary
        //Get Discharge Intimate Flag
        public class P_GETDISCHARGEINTIMATEFLAG
        {
            internal const string NAME = "WARDS.P_GETDISCHARGEINTIMATEFLAG";
            internal const string PARAM_iv_LocationId = "iv_LocationId";
            internal const string PARAM_iv_IPNumber = "iv_IPNumber";
            internal const string PARAM_OUT_IPDetails = "OCursor_IPDetails";
        }
        //Get DS UHID
        //public class p_getuhid
        //{
        //    internal const string NAME = "WARDS.p_getuhid";
        //    internal const string PARAM_iv_ipnumber = "iv_ipnumber";
        //    internal const string PARAM_iv_locationid = "iv_locationid";
        //    internal const string PARAM_OUT_details = "ocursor_details";
        //}
        //Get Employee main Details
        public class P_GETEMPLOYEEMAINDETAILS
        {
            internal const string NAME = "HR.P_GETEMPLOYEEMAINDETAILS";
            internal const string PARAM_IN_EMPLOYEE_ID = "IN_EMPLOYEE_ID";
            internal const string PARAM_IV_FIRSTNAME = "IV_FIRSTNAME";
            internal const string PARAM_ID_DOB = "ID_DOB";
            internal const string PARAM_IN_LOCATION_ID = "IN_LOCATION_ID";
            internal const string PARAM_IN_DEPARTMENT_ID = "IN_DEPARTMENT_ID";
            internal const string PARAM_IN_COSTCENTER_ID = "IN_COSTCENTER_ID";
            internal const string PARAM_IN_LEVELID = "IN_LEVELID";
            internal const string PARAM_IN_CATEGORYID = "IN_CATEGORYID";
            internal const string PARAM_IN_TYPEID = "IN_TYPEID";
            internal const string PARAM_IN_EMPLOYMENTSTATUSID = "IN_EMPLOYMENTSTATUSID";
            internal const string PARAM_IN_DESIGNATIONID = "IN_DESIGNATIONID";
            internal const string PARAM_IN_GRADEID = "IN_GRADEID";
            internal const string PARAM_IN_SPECIALITYID = "IN_SPECIALITYID";
            internal const string PARAM_IN_SCHEDULABLE = "IN_SCHEDULABLE";
            internal const string PARAM_IN_CALENDARPRIV = "IN_CALENDARPRIV";
            internal const string PARAM_IN_PRESENTEMPID = "IN_PRESENTEMPID";
            internal const string PARAM_IN_LOGINID = "IN_LOGINID";
            internal const string PARAM_IN_SUPERVISORID = "IN_SUPERVISORID";
            internal const string PARAM_IN_SPZSERVICES = "IN_SPZSERVICES";
            internal const string PARAM_IN_POSITIONID = "IN_POSITIONID";
            internal const string PARAM_OUT_EMPMAINDTAILS = "OCURSOR_EMPMAINDTAILS";
        }

        public class DG_GETLABANDRADIOLOGYLISTDTLS
        {
            internal const string SPNAME = "DIGITAL.P_GETLABANDRADIOLOGYLISTDTLS";
            internal const string PARAM_IN_UHID = "p_UHID";
            internal const string PARAM_IN_DATEFROM = "datefrom";
            internal const string PARAM_IN_DATETO = "dateto";
            internal const string PARAM_IN_IV_RESOURCEID = "IV_RESOURCEID";
            internal const string PARAM_OUT_LABANDRADIOLOGYLISTDTLS = "p_RefCursor";
        }

        public class LAB_GETTESTRESULTS_IA
        {
            internal const string SP_NAME = "DIGITAL.P_DG_GETTESTRESULT_IA";
            internal const string PARAM_IN_LOCATIONID = "in_locationid";
            internal const string PARAM_IN_LRN = "in_lrn";
            internal const string PARAM_IN_UHID = "in_uhid";
            internal const string PARAM_IN_PATIENTSERVICENO = "in_patientserviceno";
            internal const string PARAM_OUT_TESTDETAILS = "oref_testdetails";
        }

        //Initial Assessment First Sub Menu save
        //CODE CHANGED BY SHUBHANKAR AND RAKESH

        public class DG_SAVEFIRSTMENU
        {
            internal const string SPNAME = "DIGITAL.P_DG_SAVEFIRSTMENU";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_COMPLAINTS = "IV_COMPLAINTS";
            internal const string PARAM_IV_HOPI = "IV_HOPI";
            internal const string PARAM_IV_PASTHISTORY = "IV_PASTHISTORY";
            internal const string PARAM_IV_FAMILYHISTORY = "IV_FAMILYHISTORY";
            internal const string PARAM_IV_SURGICALHISTORY = "IV_SURGICALHISTORY";
            internal const string PARAM_IV_CURRENTMEDICATION = "IV_CURRENTMEDICATION";
            internal const string PARAM_IV_SURGICALEXAMINATIONDETAILS = "IV_SURGICALEXAMINATIONDETAILS";
            internal const string PARAM_IV_INVESTIGATIONDONE = "IV_INVESTIGATIONDONE";
            internal const string PARAM_IV_INVESTIGATIONRESULTS = "IV_INVESTIGATIONRESULTS";
            internal const string PARAM_IV_HABITSPRINT = "IV_HABITSPRINT";
            internal const string PARAM_IV_SMOKING = "IV_SMOKING";
            internal const string PARAM_IV_ALCOHOL = "IV_ALCOHOL";
            internal const string PARAM_IV_EXERCISETOLERANCE = "IV_EXERCISETOLERANCE";
            internal const string PARAM_IV_DIET = "IV_DIET";
            internal const string PARAM_IV_OTHERHABITS = "IV_OTHERHABITS";
            internal const string PARAM_IV_LOGIN = "IV_LOGIN";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_DRUGABUSE = "IV_DRUGABUSE";
            internal const string PARAM_IV_SEXUALABUSE = "IV_SEXUALABUSE";
            internal const string PARAM_IV_SINGLEPARENTUPBRINGING = "IV_SINGLEPARENTUPBRINGING";
            internal const string PARAM_IV_NEGLECTBYFAMILY = "IV_NEGLECTBYFAMILY";
            internal const string PARAM_IV_HEARINGIMPAIRMENT = "IV_HEARINGIMPAIRMENT";
            internal const string PARAM_IV_VISUALIMPAIRMENT = "IV_VISUALIMPAIRMENT";
            internal const string PARAM_IV_ENVIRONMENTAL = "IV_ENVIRONMENTAL";
            internal const string PARAM_IV_SMOKINGREMARK = "IV_SMOKINGREMARK";
            internal const string PARAM_IV_ALCOHOLREMARK = "IV_ALCOHOLREMARK";
            internal const string PARAM_IV_EXERCISEREMARK = "IV_EXERCISEREMARK";
            internal const string PARAM_IV_DIETREMARK = "IV_DIETREMARK";
            internal const string PARAM_IV_DRUGABUSEREMARK = "IV_DRUGABUSEREMARK";
            internal const string PARAM_IV_SEXUALABUSEREMARK = "IV_SEXUALABUSEREMARK";
            internal const string PARAM_IV_SINGLEPARENTREMARK = "IV_SINGLEPARENTREMARK";
            internal const string PARAM_IV_NEGLECTREMARK = "IV_NEGLECTREMARK";
            internal const string PARAM_IV_HEARINGREMARK = "IV_HEARINGREMARK";
            internal const string PARAM_IV_VISUALREMARK = "IV_VISUALREMARK";
            internal const string PARAM_IV_ENVIRONMENTALREMARK = "IV_ENVIRONMENTALREMARK";
            internal const string PARAM_IV_DATEOFSURGERY = "IV_DATEOFSURGERY";
            internal const string PARAM_IV_UNITY = "IV_UNITY";
            internal const string PARAM_IV_SURGERYDETAILS = "IV_SURGERYDETAILS";
            internal const string PARAM_IV_DATEOFRADIO = "IV_DATEOFRADIO";
            internal const string PARAM_IV_CHEMOCYCLE = "IV_CHEMOCYCLE";
            internal const string PARAM_IV_RADIOTHERAPYDETAILS = "IV_RADIOTHERAPYDETAILS";

            //for medication
            internal const string PARAM_IV_medicationname = "IV_medicationname";
            internal const string PARAM_IV_medstrength = "IV_medstrength";
            internal const string PARAM_IV_medroute = "IV_medroute";
            internal const string PARAM_IV_medfrequency = "IV_medfrequency";

            //internal const string PARAM_IV_RADIOTHERAPY = "IV_RADIOTHERAPY"
        }

        //Initial Assessment First Menu 2 save
        //CODE CHANGED BY SHUBHANKAR AND RAKESH
        public class DG_SAVEFIRSTMENU2
        {
            internal const string SPNAME = "DIGITAL.P_DG_SAVEFIRSTMENU2";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_ISWEIGHTCHANGES = "IV_ISWEIGHTCHANGES";
            internal const string PARAM_IV_WEIGHT = "IV_WEIGHT";
            internal const string PARAM_IV_ISFEVER = "IV_ISFEVER";
            internal const string PARAM_IV_FEVER = "IV_FEVER";
            internal const string PARAM_IV_ENT = "IV_ENT";
            internal const string PARAM_IV_EYE = "IV_EYE";
            internal const string PARAM_IV_CARDIOVASCULAR = "IV_CARDIOVASCULAR";
            internal const string PARAM_IV_CROTHERS = "IV_CROTHERS";
            internal const string PARAM_IV_GASTROINTESTINAL = "IV_GASTROINTESTINAL";
            internal const string PARAM_IV_GIOTHERS = "IV_GIOTHERS";
            internal const string PARAM_IV_GENITO = "IV_GENITO";
            internal const string PARAM_IV_GUOTHERS = "IV_GUOTHERS";
            internal const string PARAM_IV_HEMATOLOGIC = "IV_HEMATOLOGIC";
            internal const string PARAM_IV_INTEGUMENT = "IV_INTEGUMENT";
            internal const string PARAM_IV_MUSCULOSKELETAL = "IV_MUSCULOSKELETAL";
            internal const string PARAM_IV_PSYCHIATRIC = "IV_PSYCHIATRIC";
            internal const string PARAM_IV_ENDOCRINE = "IV_ENDOCRINE";
            internal const string PARAM_IV_LOGIN = "IV_LOGIN";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
        }
        //Initial Assessment Second Sub Menu save
        //CODE CHANGED BY SHUBHANKAR AND RAKESH
        public class DG_SAVESECONDSUBMENU
        {
            internal const string SPNAME = "DIGITAL.P_DG_SAVESECONDSUBMENU";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_PSYCHOLOGICALEVALUATION = "IV_PSYCHOLOGICALEVALUATION";
            internal const string PARAM_IV_PEISPRINT = "IV_PEISPRINT";
            internal const string PARAM_IV_FEWALKING = "IV_FEWALKING";
            internal const string PARAM_IV_FEEATING = "IV_FEEATING";
            internal const string PARAM_IV_FEBATHING = "IV_FEBATHING";
            internal const string PARAM_IV_FEDRESSING = "IV_FEDRESSING";
            internal const string PARAM_IV_FETOILETNEEDS = "IV_FETOILETNEEDS";
            internal const string PARAM_IV_FEREMARKS = "IV_FEREMARKS";
            internal const string PARAM_IV_NRSFOODINTAKE = "IV_NRSFOODINTAKE";
            internal const string PARAM_IV_NRSWEIGTHLOSS = "IV_NRSWEIGTHLOSS";
            internal const string PARAM_IV_NRSMOBILITY = "IV_NRSMOBILITY";
            internal const string PARAM_IV_NRSACUTEDISEASE = "IV_NRSACUTEDISEASE";
            internal const string PARAM_IV_NRSNEUROPHYSCOPRBLM = "IV_NRSNEUROPHYSCOPRBLM";
            internal const string PARAM_IV_NRSBODYHABITUS = "IV_NRSBODYHABITUS";
            internal const string PARAM_IV_NRSTOTALSCORE = "IV_NRSTOTALSCORE";
            internal const string PARAM_IV_LOGIN = "IV_LOGIN";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_FERISKOFSUICIDE = "IV_FERISKOFSUICIDE";
            internal const string PARAM_IV_FECOOKING = "IV_FECOOKING";
            internal const string PARAM_IV_FECLEANING = "IV_FECLEANING";
            internal const string PARAM_IV_FEMEDICATIONS = "IV_FEMEDICATIONS";
            internal const string PARAM_IV_FESHOPPING = "IV_FESHOPPING";
            internal const string PARAM_IV_FEBANKING = "IV_FEBANKING";
            internal const string PARAM_IV_FEDRIVING = "IV_FEDRIVING";


        }
        //Obstetric and gynaec save
        public class DG_SAVEGYNECOBSTETRICS
        {
            internal const string SPNAME = "DIGITAL.P_DG_SAVEGYNECOBSTETRICS";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_MENARCHE = "IV_MENARCHE";
            internal const string PARAM_IV_goCYCLE = "IV_goCYCLE";
            internal const string PARAM_IV_FLOW = "IV_FLOW";
            internal const string PARAM_IV_INTERMENSTRUALBLEEDING = "IV_INTERMENSTRUALBLEEDING";
            internal const string PARAM_IV_PAIN = "IV_PAIN";
            internal const string PARAM_IV_LMP = "IV_LMP";
            internal const string PARAM_IV_VAGINALDISCHARGE = "IV_VAGINALDISCHARGE";
            internal const string PARAM_IV_CERVICALSMEAR = "IV_CERVICALSMEAR";
            internal const string PARAM_IV_CONTRACEPTION = "IV_CONTRACEPTION";
            internal const string PARAM_IV_ObstreticHistory = "IV_ObstreticHistory";
            internal const string PARAM_IV_LOGIN = "IV_LOGIN";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
        }
        //Discharge Planning Form save
        public class DG_SAVEDISCHARGEPLANNINGFORM
        {
            internal const string SPNAME = "DIGITAL.P_DG_SAVEDISCHARGEPLANNINGFORM";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_SOURCEOFINFORMATION = "IV_SOURCEOFINFORMATION";
            internal const string PARAM_IV_MENTALSTATUS = "IV_MENTALSTATUS";
            internal const string PARAM_IV_ADMITTEDTHROUGH = "IV_ADMITTEDTHROUGH";
            internal const string PARAM_IV_LIVINGWITH = "IV_LIVINGWITH";
            internal const string PARAM_IV_PHYSIOTHERAPHYREQUIRED = "IV_PHYSIOTHERAPHYREQUIRED";
            internal const string PARAM_IV_HOMEMEDICALEQUIPMENT = "IV_HOMEMEDICALEQUIPMENT";
            internal const string PARAM_IV_DRESSINGNEEDS = "IV_DRESSINGNEEDS";
            internal const string PARAM_IV_REMARKS = "IV_REMARKS";
            internal const string PARAM_IV_LOGIN = "IV_LOGIN";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_HOMEOXYGENTHERAPY = "IV_HOMEOXYGENTHERAPY";
        }

        //PysicalExamination Save
        //CODE CHANGED BY SHUBHANKAR AND RAKESH
        public class DG_SAVEPHYSICALEXAMINATION
        {
            internal const string SPNAME = "DIGITAL.P_DG_SAVEPHYSICALEXAMINATION";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_PALOR = "IV_PALOR";
            internal const string PARAM_IV_CYANOSIS = "IV_CYANOSIS";
            internal const string PARAM_IV_ICTERUS = "IV_ICTERUS";
            internal const string PARAM_IV_CLUBBING = "IV_CLUBBING";
            internal const string PARAM_IV_EDEMA = "IV_EDEMA";
            internal const string PARAM_IV_LYMPADENOPATHY = "IV_LYMPADENOPATHY";
            internal const string PARAM_IV_PEDETAILS = "IV_PEDETAILS";
            internal const string PARAM_IV_LOGIN = "IV_LOGIN";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_OEDEMAFEET = "IV_OEDEMAFEET";
            internal const string PARAM_IV_ORALCAVITY = "IV_ORALCAVITY";
            internal const string PARAM_IV_SUSPECTED = "IV_SUSPECTED";
            internal const string PARAM_IV_IMMUNO = "IV_IMMUNO";
            internal const string PARAM_IV_ISOLATION = "IV_ISOLATION";
            internal const string PARAM_IV_HENT = "IV_HENT";
            internal const string PARAM_IV_CVS = "IV_CVS";
            internal const string PARAM_IV_RS = "IV_RS";
            internal const string PARAM_IV_ABDOMEN = "IV_ABDOMEN";
            internal const string PARAM_IV_CNC = "IV_CNC";
            internal const string PARAM_IV_GENITALS = "IV_GENITALS";
            internal const string PARAM_IV_OTHERS = "IV_OTHERS";
        }

        //Diagnosis save

        public class DG_SAVEDIAGNOSIS
        {
            internal const string SPNAME = "DIGITAL.P_DG_SAVEDIAGNOSIS";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_ICDCODE = "IV_ICDCODE";
            internal const string PARAM_IV_TYPE = "IV_TYPE";
            internal const string PARAM_IV_COMMENTS = "IV_COMMENTS";
            internal const string PARAM_IV_CONFIDENTIAL = "IV_CONFIDENTIAL";
            internal const string PARAM_IV_SORTORDER = "IV_SORTORDER";
            internal const string PARAM_IV_STATUS = "IV_STATUS";
            internal const string PARAM_IV_PRINT = "IV_PRINT";
            internal const string PARAM_IV_LOGIN = "IV_LOGIN";
            internal const string PARAM_IV_DIAGNOSISNAME = "IV_DIAGNOSISNAME";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_Side = "IV_Side";
            internal const string PARAM_IV_LOCATION = "IV_LOCATION";
            internal const string PARAM_IV_CHRONICPROBLEM = "IV_CHRONICPROBLEM";
        }
        /// <summary>
        //Surgery Save 
        //Coded By Shubhankar
        public class DG_SAVESURGERY
        {
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_DATEOFSURGERY = "IV_DATEOFSURGERY";
            internal const string PARAM_IV_UNITY = "IV_UNITY";
            internal const string PARAM_IV_LOGIN = "IV_LOGIN";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_SURGID = "IV_SURGID";
            internal const string PARAM_IV_SURGSTATUS = "IV_SURGSTATUS";
            internal const string PARAM_IV_SURGERYDETAILS = "IV_SURGERYDETAILS";
            internal const string SPNAME = "digital.P_DG_SAVESURGERY";
        }

        //RadioTherapy Save
        //Coded By Shubhankar And Rakesh
        public class DG_SAVERADIO
        {
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_DATEOFRADIO = "IV_DATEOFRADIO";
            internal const string PARAM_IV_CHEMOCYCLE = "IV_CHEMOCYCLE";
            internal const string PARAM_IV_LOGIN = "IV_LOGIN";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_IV_RADIOID = "IV_RADIOID";
            internal const string PARAM_IV_RADIOSTATUS = "IV_RADIOSTATUS";
            internal const string PARAM_IV_RADIOTHERAPYDETAILS = "IV_RADIOTHERAPYDETAILS";
            internal const string PARAM_IV_FLAG = "FLAG";
            internal const string SPNAME = "digital.P_DG_SAVERADIOTHERAPY";
        }

        public class DG_SAVEMED
        {
            internal const string SPNAME = "DIGITAL.P_DG_SAVEIAMEDICATION";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_LOGIN = "IV_LOGIN";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_MEDNAME = "IV_MEDNAME";
            internal const string PARAM_IV_MEDSTRENGTH = "IV_MEDSTRENGTH";
            internal const string PARAM_IV_MEDROUTE = "IV_MEDROUTE";
            internal const string PARAM_IV_MEDFREQUENCY = "IV_MEDFREQUENCY";
            internal const string PARAM_IV_MEDLASTDOSAGE = "IV_MEDLASTDOSAGE";
            internal const string PARAM_IV_CONTINUE = "IV_CONTINUE";
            internal const string PARAM_IV_MEDID = "IV_MEDID";
        }

        //for Source & Disposition  of Medication  BT RAKESH
        public class DG_SAVESOURCEDISP
        {
            internal const string SPNAME = "DIGITAL.P_DG_SAVESOURCEDISPMEDICATION";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_UHID = "IV_IPNUMBER";
            internal const string PARAM_IV_DOCT0RID = "IV_DOCT0RID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_PATIENTMDICATIONLIST = "IV_PATIENTMDICATIONLIST";
            internal const string PARAM_IV_PHYSICIANLIST = "IV_PHYSICIANLIST";
            internal const string PARAM_IV_PATIENTFAMILYRECALL = "IV_PATIENTFAMILYRECALL";
            internal const string PARAM_IV_PREVIOUSDISCHARGEPAPERS = "IV_PREVIOUSDISCHARGEPAPERS";
            internal const string PARAM_IV_PHARMACY = "IV_PHARMACY";
            internal const string PARAM_IV_OTHERSCHECK = "IV_OTHERSCHECK";
            internal const string PARAM_IV_OTHERSTEXT = "IV_OTHERSTEXT";
            internal const string PARAM_IV_NONEWITHPATIENT = "IV_NONEWITHPATIENT";
            internal const string PARAM_IV_SENTHOMEWIRHFAMILY = "IV_SENTHOMEWIRHFAMILY";
        }

        //Coded By Shubhankar
        //PastMasterData Save

        public class DG_SAVEPASTHISTTRANSACTIONS
        {
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_LOGINID = "IV_LOGINID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_IAPASTHISTORYDETAILS = "IV_IAPASTHISTORYDETAILS";
            internal const string SPNAME = "digital.P_DG_SAVEPASTHISTTRANSACTIONS";

        }

        //GET IA
        public class P_GETIACONTROLS
        {
            internal const string NAME = "WARDS.P_GETIACONTROLS";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_FLAG = "IV_FLAG";
            internal const string PARAM_OUT_SUBMENUCONTROLS = "OCURSOR_SUBMENUCONTROLS";
            internal const string PARAM_OUT_PARAMCONTROLS = "OCURSOR_PARAMCONTROLS";
            internal const string PARAM_OUT_IACONTROLS = "OCURSOR_IACONTROLS";
        }

        //Get IA Details
        //Coded By Shubhankar And Rakesh
        public class DG_GETIADETAILS
        {
            internal const string NAME = "DIGITAL.P_DG_GETIADETAILS";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_COMPONENT1 = "OCURSOR_COMPONENT1";
            internal const string PARAM_OUT_COMPONENT2 = "OCURSOR_COMPONENT2";
            internal const string PARAM_OUT_COMPONENT3 = "OCURSOR_COMPONENT3";
            internal const string PARAM_OUT_COMPONENT4 = "OCURSOR_COMPONENT4";
            internal const string PARAM_OUT_COMPONENT5 = "OCURSOR_COMPONENT5";
            internal const string PARAM_OUT_COMPONENT6 = "OCURSOR_COMPONENT6";
            internal const string PARAM_OUT_COMPONENT7 = "OCURSOR_COMPONENT7";
            internal const string PARAM_OUT_COMPONENT8 = "OCURSOR_COMPONENT8";
            internal const string PARAM_OUT_COMPONENT9 = "OCURSOR_COMPONENT9";
            internal const string PARAM_OUT_COMPONENT10 = "OCURSOR_COMPONENT10";
            internal const string PARAM_OUT_COMPONENT11 = "OCURSOR_RADIOTHERAPY";
            internal const string PARAM_OUT_PASTFAMHIST = "OCURSOR_PASTFAMHIST";
            internal const string PARAM_OUT_INVESTIGATIONRESULTS = "OCURSOR_INVESTIGATIONRESULTS";
            internal const string PARAM_OUT_INVESTIGATIONDETAILS = "OCURSOR_INVESTIGATIONDETAILS";
            internal const string PARAM_OUT_PASTMASTERTRANSDATA = "OCURSOR_PASTMASTERTRANSDATA";
            internal const string PARAM_OUT_OCURSOR_SOURCEDISP = "OCURSOR_SOURCEDISP";
            internal const string PARAM_OUT_OCURSOR_MEDICATION = "OCURSOR_MEDICATION";

        }

        public class DG_GETPRESENTATIONDETAILS
        {
            internal const string SPNAME = "DIGITAL.DG_GetPresentationDetails";
            internal const string PARAM_IN_UHID = "p_UHID";
            internal const string PARAM_IN_SPECIALITYID = "p_specialityid";
            internal const string PARAM_IN_AVAILABLEID = "p_AVAILABLEID";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUT_OPIADETAILS = "OCURSOR_OPIADETAILS";
            internal const string PARAM_OUT_VITALDETAILS = "OCURSOR_VITALDETAILS";
            internal const string PARAM_OUT_BILLINGOPP = "OCURSOR_BILLINGOPP";
        }

        #region Diagnosis
        public class DG_GETIADIAGDTLS
        {
            internal const string NAME = "DIGITAL.P_DG_GETIADIAGNOSISDTLS";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_IADIAGNOSISDTLS = "OCURSOR_IADIAGNOSISDTLS";
        }

        public class DG_GETDIAGNOSEFAVOURITE
        {
            internal const string NAME = "DIGITAL.DG_GETDIAGNOSEFAVOURITE";
            internal const string PARAM_IN_DOCTORID = "IN_DOCTORID";
            internal const string PARAM_IN_LOCATIONID = "IN_LocationID";
            internal const string PARAM_OUT_SERVICEITEM = "out_cur_service";
        }

        public class DG_IADiagnosisInformation
        {
            internal const string Name = "DIGITAL.DG_ADDIP_IPDIAGNOSIS";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_ADMISSIONNO = "IV_ADMISSIONNO";
            internal const string PARAM_IV_LocationId = "IV_LocationId";
            internal const string PARAM_IV_LoginId = "IV_LoginId ";
            internal const string PARAM_IV_DIAGNOSISCODE = "IV_DIAGNOSISCODE";
            internal const string PARAM_IV_DIAGNOSISTYPE = "IV_DIAGNOSISTYPE";
            internal const string PARAM_IV_DIAGNOSISNAME = "IV_DIAGNOSISNAME";
            internal const string PARAM_IV_DIAGNOSISID = "IV_DIAGNOSISID";
            internal const string PARAM_IV_COMMENTS = "IV_COMMENTS";
            internal const string PARAM_IV_Side = "IV_Side";
            internal const string PARAM_IV_Location = "IV_Location";
            internal const string PARAM_IV_CONFIDENTIAL = "IV_CONFIDENTIAL";
            internal const string PARAM_IV_SORTORDER = "IV_SORTORDER";
            internal const string PARAM_IV_PRINT = "IV_PRINT";
            internal const string PARAM_IV_CHRONICPROBLEM = "IV_CHRONICPROBLEM";
            internal const string PARAM_IV_FLAG = "IV_FLAG";
            internal const string PARAM_IV_STATUS = "IV_STATUS";

        }
        public class DG_ADDFAVOURITESLIST
        {
            internal const string NAME = "DIGITAL.DG_ADDFAVOURITESLIST";
            internal const string PARAM_IN_DOCTORID = "IV_DOCTORID";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_TYPE = "IV_Type";
            internal const string PARAM_IN_SERVICEID = "IV_FAVOURITENAME";
            internal const string PARAM_IN_ALIASNAME = "IV_ALIASNAME";

        }

        public class DG_UPDATEFAVOURITES
        {
            internal const string NAME = "DIGITAL.DG_UPDATEFAVOURITES";
            internal const string PARAM_IN_DOCTORID = "V_DOCTORID";
            internal const string PARAM_IN_LOCATIONID = "V_LOCATIONID";
            internal const string PARAM_IN_SERVICEID = "V_SERVICEID";
        }

        #endregion

        #region Intial Assessment track changes
        public class Trackchangesia
        {
            internal const string NAME = "DIGITAL.P_DG_TrackChanges_IA";
            internal const string HabitsProcNAME = "P_DG_TrackChanges_IA_Habits";
            internal const string PARAM_IN_IpNumber = "in_ipnumber";
            internal const string PARAM_IN_Doctorid = "in_doctorid";
            internal const string PARAM_IN_Locationid = "in_locationId";
            internal const string PARAM_IN_Submenuname = "in_submenuname";
            internal const string PARAM_IN_Paramname = "in_paramname";
            internal const string PARAM_IN_Fromdate = "in_fromdate";
            internal const string PARAM_IN_Todate = "in_todate";
            internal const string PARAM_OUT_Parameterdatavalues = "out_parameterdata";
        }

        public class Trackchangesia_menu
        {
            internal const string NAME = "DIGITAL.P_DG_AccordianMenu_IA";
            internal const string PARAM_IN_IpNumber = "in_ipnumber";
            internal const string PARAM_IN_Doctorid = "in_doctorid";
            internal const string PARAM_IN_Locationid = "in_locationId";
            internal const string PARAM_OUT_AccordianMenu = "out_accordianmenu";
            internal const string PARAM_OUT_AccordianParamList = "out_accordianparamlist";
        }
        #endregion Intial Assessment track changes

        #region "Discharge Process"
        public class p_getdischargeintimated
        {
            internal const string SPNAME = "WARDS.p_getdischargeintimated";
            internal const string PARAM_IN_LocationId = "iv_locationid";
            internal const string PARAM_IN_DoctorId = "iv_loginid";
            internal const string PARAM_IN_IPNumber = "iv_ipnumber";
            internal const string PARAM_OUT_ipdetails = "ocursor_ipdetails";
        }
        public class P_EMG_GETINITIALASSESSMENT
        {
            internal const string SPNAME = "WARDS.P_EMG_GETINITIALASSESSMENT";
            internal const string PARAM_IN_IPNumber = "IV_EPNUMBER";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_LocationId = "IV_LOCATIONID";
            internal const string PARAM_OUT_ARRIVALDETAILS = "oCursor_ARRIVALDETAILS";
            internal const string PARAM_OUT_VITALDETAILS = "oCursor_VITALDETAILS";
            internal const string PARAM_OUT_PRESENTINGCOMP = "oCursor_PRESENTINGCOMP";
            internal const string PARAM_OUT_EREXAMINATION = "oCursor_EREXAMINATION";
            internal const string PARAM_OUT_AMPLEHISTORY = "oCursor_AMPLEHISTORY";
            internal const string PARAM_OUT_PUPILREACTION = "oCursor_PUPILREACTION";
            internal const string PARAM_OUT_FINDINGS = "oCursor_FINDINGS";
            internal const string PARAM_OUT_MEDICATION = "oCursor_MEDICATION";
            internal const string PARAM_OUT_INITIALASSESSMENTDTL = "oCursor_INITIALASSESSMENTDTL";
        }

        public class p_getpatientoccupiedbeds
        {
            internal const string SPNAME = "ADT.p_getpatientoccupiedbeds";
            internal const string PARAM_IN_IPNumber = "iv_inpatientno";
            internal const string PARAM_IN_UHID = "iv_uhid";
            internal const string PARAM_IN_LocationId = "in_locationid";
            internal const string PARAM_OUT_result = "ocursor_result";
            internal const string PARAM_OUT_transferhistory = "ocursor_transferhistory";
        }
        public class P_GETLOVVALUES
        {
            internal const string SPNAME = "WARDS.P_GETLOVVALUES";
            internal const string PARAM_IN_LOVID = "IN_LOVID";
            internal const string PARAM_IV_LOVCODE = "IV_LOVCODE";
            internal const string PARAM_IN_LOVDETAILID = "IN_LOVDETAILID";
            internal const string PARAM_IV_LOVDETAILVALUE = "IV_LOVDETAILVALUE";
            internal const string PARAM_OUT_LOVCURSOR = "OREF_LOVCURSOR";
            internal const string PARAM_OUT_LOVDETAIL = "OREF_LOVDETAIL";
        }
        public class P_GETDIAGNOSISFORANIPNUMBER
        {
            internal const string SPNAME = "WARDS.P_GETDIAGNOSISFORANIPNUMBER";
            internal const string PARAM_IN_IPNumber = "Iv_IPNumber";
            internal const string PARAM_IV_LocationId = "Iv_locationid";
            internal const string PARAM_OUT_DiagnosisDetails = "ORef_DiagnosisDetails";
        }
        public class P_GetUnBilledServices
        {
            internal const string SPNAME = "BILLING.P_GetUnBilledServices";
            internal const string PARAM_IN_PatientIdentifierNo = "iv_patientidentifierno";
            internal const string PARAM_IN_DepartmentId = "iv_departmentid";
            internal const string PARAM_IN_LocationId = "iv_locationid";
            internal const string PARAM_OUT_UnbilledServices = "oc_unbilledservices";
        }

        public class p_getprescription
        {
            internal const string SPNAME = "WARDS.p_getprescription";
            internal const string PARAM_IN_admissionno = "in_admissionno";
            internal const string PARAM_IN_prescriptionno = "in_prescriptionno";
            internal const string PARAM_IN_uhid = "iv_uhid";
            internal const string PARAM_IN_locationid = "iv_locationid";
            internal const string PARAM_IN_ipnumber = "iv_ipnumber";
            internal const string PARAM_IN_transactionstatus = "iv_transactionstatus";
            internal const string PARAM_IN_doctorid = "iv_doctorid";
            internal const string PARAM_OUT_prescdetailstrans = "ocursor_prescdetailstrans";
            internal const string PARAM_OUT_prescriptionvitalinfo = "ocursor_prescriptionvitalinfo";
            internal const string PARAM_OUT_prescriptiondetails = "ocursor_prescriptiondetails";
            internal const string PARAM_OUT_detailsdischargepres = "ocursor_detailsdischargepres";
        }
        public class p_get_consum_notdone
        {
            internal const string SPNAME = "OT.pkg_intermodule_references_p_get_consum_notdone";
            internal const string PARAM_IN_UHID = "iv_uhid";
            internal const string PARAM_IN_IPNumber = "iv_ipnumber";
            internal const string PARAM_IN_LocationId = "iv_locationid";
            internal const string PARAM_OUT_OTRequests = "ocursor_data";
            internal const string PARAM_OUT_OTRequests1 = "ocursor_data1";
        }
        public class P_GETEQUIPMENTREQUEST
        {
            internal const string SPNAME = "WARDS.P_GETEQUIPMENTREQUEST";
            internal const string PARAM_IN_requeststatus = "IN_REQUESTSTATUS";
            internal const string PARAM_IN_requestno = "IN_REQUESTNO";
            internal const string PARAM_IN_fromdate = "ID_FROMDATE";
            internal const string PARAM_IN_todate = "ID_TODATE";
            internal const string PARAM_IN_LocationId = "iv_LocationId";
            internal const string PARAM_IN_UHID = "iv_uhid";
            internal const string PARAM_IN_equipmentdetailid = "iv_EQUIPMENTDETAILID";
            internal const string PARAM_IN_IPNumber = "iv_ipnumber";
            internal const string PARAM_OUT_completedrrcursor = "OREF_COMPLETEDRRCURSOR";
            internal const string PARAM_OUT_equipmentmastercursor = "OREF_EQUIPMENTMASTERCURSOR";
            internal const string PARAM_OUT_equipmentdetailcursor = "OREF_EQUIPMENTDETAILCURSOR";
        }

        public class P_GetBillingBlockData
        {
            internal const string SPNAME = "MM.P_GetBillingBlockData";
            internal const string PARAM_IN_IPNumber = "iv_IpNo";
            internal const string PARAM_OUT_Expirydate = "ocursor_Expirydate";
        }
        public class P_GETREFERRED_TRANSFER_CASES
        {
            internal const string SPNAME = "WARDS.P_GETREFERRED_TRANSFER_CASES";
            internal const string PARAM_IN_DoctorsLoginId = "iv_DoctorsLoginId";
            internal const string PARAM_IN_RequestType = "in_RequestType";
            internal const string PARAM_IN_LocationId = "iv_LocationId";
            internal const string PARAM_IN_IPNumber = "iv_IPNumber";
            internal const string PARAM_OUT_REFERRED_TRANSFER_TO = "OCursor_REFERRED_TRANSFER_TO";
            internal const string PARAM_OUT_REFERRED_TRANSFER_BY = "OCursor_REFERRED_TRANSFER_BY";
        }

        public class P_GetOpenIndentAginstIP
        {
            internal const string SPNAME = "MM.P_GetOpenIndentAginstIP";
            internal const string PARAM_IN_IPNumber = "iv_ipno";
            internal const string PARAM_IN_LocationId = "iv_hospitalid";
            internal const string PARAM_OUT_getopenindentaginstip = "ocursor_getopenindentaginstip";
            internal const string PARAM_OUT_GETISSUESTATUSDETAILS = "oCURSOR_GETISSUESTATUSDETAILS";
            internal const string PARAM_OUT_GETRETACKDETAILS = "oCURSOR_GETRETACKDETAILS";

        }
        public class p_getippatientindentdetails
        {
            internal const string SPNAME = "PHARMACY.p_getippatientindentdetails";
            internal const string PARAM_IN_IPNumber = "iv_ipno";
            internal const string PARAM_IN_LocationId = "iv_locationid";
            internal const string PARAM_OUT_getindentstatusdetail = "ocursor_getindentstatusdetail";
            internal const string PARAM_OUT_getissuestatusdetails = "ocursor_getissuestatusdetails";
            internal const string PARAM_OUT_getretackdetails = "ocursor_getretackdetails";
        }
        public class P_GETIPPATIENTINDENTEXDETAILS
        {
            internal const string SPNAME = "PHARMACY.P_GETIPPATIENTINDENTEXDETAILS";
            internal const string PARAM_IN_IPNumber = "IV_IPNO";
            internal const string PARAM_IN_INDENTCODE = "IV_INDENTCODE";
            internal const string PARAM_IN_STORECODE = "IV_STORECODE";
            internal const string PARAM_OUT_getindentexdetail = "oCURSOR_GETINDENTEXDETAIL";

        }
        public class P_UpdatePatientStatus
        {
            internal const string SPNAME = "ADT.P_UpdatePatientStatus";
            internal const string PARAM_iv_inpatientno = "iv_inpatientno";
            internal const string PARAM_in_patientstatusid = "in_patientstatusid";
            internal const string PARAM_in_status = "in_status";
            internal const string PARAM_iv_loginid = "iv_loginid";
        }
        public class DG_UPDATEDISCHARGEINTIMATION
        {
            internal const string SPNAME = "WARDS.DG_UPDATEDISCHARGEINTIMATION";
            internal const string PARAM_v_ipnumber = "v_ipnumber";
            internal const string PARAM_v_updatedby = "v_updatedby";
            internal const string PARAM_v_updateddate = "v_updateddate";
            internal const string PARAM_v_dischargestatus = "v_dischargestatus";
            internal const string PARAM_v_dischargeintimateddatetime = "v_dischargeintimateddatetime";
        }
        public class P_UPDATEDISCHARGETIME
        {
            internal const string SPNAME = "BILLING.P_UPDATEDISCHARGETIME";
            internal const string PARAM_IN_IPNO = "IV_IPNO";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_DATE = "IV_DATE";
        }

        public class DG_CANCELPHYSIOREQUEST
        {
            internal const string SPNAME = "WARDS.DG_CANCELPHYSIOREQUEST";
            internal const string V_CANCEL_PHYSIOREQUEST = "V_CANCEL_PHYSIOREQUEST";
        }
        public class DG_DELETETESTPROFILES
        {
            internal const string SPNAME = "LAB.DG_DELETETESTPROFILES";
            internal const string PARAM_IN_DELETEPROFILE = "IN_DELETEPROFILE";
            internal const string PARAM_OUT_RETURNVALUE = "ON_RETURNVALUE";
        }
        public class DG_CANCELOTHERSERVICESREQUEST
        {
            internal const string SPNAME = "WARDS.DG_CANCELOTHERSERVICESREQUEST";
            internal const string V_CANCEL_OTHERSERVICEREQUEST = "V_CANCEL_OTHERSERVICEREQUEST";
        }
        public class DG_CANCELLHKREQUEST
        {
            internal const string SPNAME = "WARDS.DG_CANCELLHKREQUEST";
            internal const string PARAM_IN_CANCELREQUEST = "IN_CANCELREQUEST";

        }
        public class DG_CANCELCSSDREQUEST
        {
            internal const string SPNAME = "WARDS.DG_CANCELCSSDREQUEST";
            internal const string PARAM_IN_CSSDWORKLIST = "IN_CSSDWORKLIST";

        }
        public class DG_UPDATEBILLINGSTATUS
        {
            internal const string SPNAME = "BILLING.DG_UPDATEBILLINGSTATUS";
            internal const string PARAM_IN_UPDATEBILLINGSTATUS = "V_UPDATEBILLINGSTATUS";
            internal const string PARAM_IN_BillingService = "IV_BillingService";
            internal const string PARAM_IN_LoginId = "IV_LoginId";
        }
        public class DG_GETWORKLISTNAME
        {
            internal const string SPNAME = "WARDS.DG_GETWORKLISTNAME";
            internal const string V_IPNUMBER = "V_IPNUMBER";
            internal const string V_LOCATIONID = "V_LOCATIONID";
            internal const string V_DISCHARGE_INITIATION = "IV_DISCHARGE_INITIATION";
            internal const string PARAM_OUT_WORKLISTNAME = "OCURSOR_WORKLISTNAME";
        }
        public class P_GETDEPTMASTER
        {
            internal const string SPNAME = "WARDS.P_GETDEPTMASTER";
            internal const string V_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUT_DEPTMASTER = "OCursor_DEPTMASTER";
        }

        public class P_CHANGESERVICEID
        {
            internal const string NAME = "BB.P_CHANGESERVICEID";
            internal const string PARAM_IN_IPOPNumber = "in_IPOPNumber";
            internal const string PARAM_OUT_cursorChangedID = "O_cursorChangedID";
        }
        public class P_GETIPVISITDETAILS
        {
            internal const string NAME = "WARDS.P_GETIPVISITDETAILS";
            internal const string PARAM_IN_IPNumber = "IV_IPNumber";
            internal const string PARAM_IN_LocationId = "IV_LocationId";
            internal const string PARAM_OUT_DOCTORSTORAISE = "OC_DOCTORSTORAISE";
            internal const string PARAM_OUT_SERVICEDETAILS = "OC_SERVICEDETAILS";
        }
        public class DG_SERVICEREQUEST
        {
            internal const string NAME = "BILLING.DG_SERVICEREQUEST";
            internal const string PARAM_IN_LOCATIONID = "V_LOCATIONID";
            internal const string PARAM_IN_REGISTRATIONNO = "V_REGISTRATIONNO";
            internal const string PARAM_IN_PATIENTIDENTIFIERNO = "V_PATIENTIDENTIFIERNO";
            internal const string PARAM_IN_BILLINGSERVICE = "V_BILLINGSERVICE";
            internal const string PARAM_IN_BILLINGSTATUS = "V_BILLINGSTATUS";
            internal const string PARAM_IN_SERVICE_REQUEST = "V_SERVICE_REQUEST";
        }
        #endregion

        #region "Discharge Summary"
        public class P_GETDSSHORTLINKS
        {
            internal const string NAME = "P_GETDSSHORTLINKS";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUT_DSSHORTLINKS = "OCURSOR_DSSHORTLINKS";
        }
        public class P_SAVEDSSHORTLINKS
        {
            internal const string NAME = "P_SAVEDSSHORTLINKS";
            internal const string PARAM_IN_DESC = "IN_DESC";
            internal const string PARAM_IN_ALIAS = "IN_ALIAS";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_PARAMID = "IN_PARAMID";
        }
        public class P_UPDATEDSSHORTLINKS
        {
            internal const string NAME = "P_UPDATEDSSHORTLINKS";
            internal const string PARAM_IN_DESC = "IN_DESCRIPTION";
            internal const string PARAM_IN_ALIAS = "IN_ALIAS";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_PARAMID = "IN_PARAMID";
            internal const string PARAM_IN_SHORTLINKID = "IN_SHORTLINKID";
        }
        public class P_DELETESSHORTLINKS
        {
            internal const string NAME = "P_DELETESSHORTLINKS";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_SHORTLINKID = "IN_SHORTLINKID";
        }

        public class P_GETMULTILINEPARAMS
        {
            internal const string NAME = "P_GETMULTILINEPARAMS";
            internal const string PARAM_IN_SPECIALITYID = "IN_SPECIALITYID";
            internal const string PARAM_IN_CONTROLTYPEID = "IN_CONTROLTYPEID";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUT_PARAMETERMAPPING = "OCURSOR_PARAMETERMAPPING";
        }

        //Get DS UHID
        public class p_getuhid
        {
            internal const string NAME = "WARDS.p_getuhid";
            internal const string PARAM_iv_ipnumber = "iv_ipnumber";
            internal const string PARAM_iv_locationid = "iv_locationid";
            internal const string PARAM_OUT_details = "ocursor_details";
        }

        public class P_GET_DISCHARGESUMMARYDYNC
        {
            internal const string NAME = "WARDS.P_GET_DISCHARGESUMMARYDYNC";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUT_SURGERYDETAILS = "OREF_SURGERYDETAILS";
            internal const string PARAM_OUT_VITALDETAILS = "OREF_VITALDETAILS";
            internal const string PARAM_OUT_PRESCRIPTIONDETAILS = "OREF_PRESCRIPTIONDETAILS";
            internal const string PARAM_OUT_DIAGNOSISDETAILS = "OREF_DIAGNOSISDETAILS";
            internal const string PARAM_OUT_CASESHEETDETAIL = "OREF_CASESHEETDETAIL";
            internal const string PARAM_OUT_DOCTORDETAIL = "OREF_DOCTORDETAIL";
            internal const string PARAM_OUT_FINDINGS = "OREF_FINDINGS";
            internal const string PARAM_OUT_FAMILYHISTORY = "OREF_FAMILYHISTORY";
            internal const string PARAM_OUT_SURGEONSDETAILS = "OREF_SURGEONSDETAILS";
            internal const string PARAM_OUT_ANASTHESIANDETAILS = "OREF_ANASTHESIANDETAILS";
            internal const string PARAM_OUT_DISCHARGESUMMARY = "OREF_DISCHARGESUMMARY";
            internal const string PARAM_OUT_DISCHARGESUMMARYDETAILS = "OREF_DISCHARGESUMMARYDETAILS";
        }
        //Get Diet Info On Discharge
        public class P_GETDIETINFOONIPDISCHARGE
        {
            internal const string NAME = "FB.P_GETDIETINFOONIPDISCHARGE";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_SERVICENO = "IV_SERVICENO";
            internal const string PARAM_IN_LocationID = "IN_LocationID";
            internal const string PARAM_OUT_DIETINFO = "ocursor_DIETINFO";
        }
        //Get Patient Occupied Beds
        public class P_GETPATIENTOCCUPIEDBEDS
        {
            internal const string NAME = "adt.P_GETPATIENTOCCUPIEDBEDS";
            internal const string PARAM_IV_INPATIENTNO = "IV_INPATIENTNO";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_RESULT = "OCURSOR_RESULT";
            internal const string PARAM_OUT_TRANSFERHISTORY = "OCURSOR_TRANSFERHISTORY";
        }
        //Get Discharge Intimated Details
        public class P_GETDISCHARGEINTIMATED
        {
            internal const string NAME = "WARDS.P_GETDISCHARGEINTIMATED";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_LOGINID = "IV_LOGINID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_OUT_IPDETAILS = "OCURSOR_IPDETAILS";
        }
        public class p_cancelprescription
        {
            internal const string NAME = "WARDS.p_cancelprescription";
            internal const string PARAM_IN_PRESCNO = "IN_PRESCRIPTIONNO";
            internal const string PARAM_IN_PRESCDTLID = "IN_PRESCRIPTIONDETAILID";
            internal const string PARAM_IV_LOGINID = "IV_LOGINID";
        }
        public class P_GETDEATHDECLARATIONDETAILS
        {
            internal const string NAME = "WARDS.P_GETDEATHDECLARATIONDETAILS";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_OUT_COMPONENT1 = "OCURSOR_DEATHDECLARATION";
        }



        public class P_GET_COMPLETED_REQUESTS
        {
            internal const string NAME = "ot.pkg_intermodule_references_p_get_completed_requests";
            internal const string PARAM_IV_INPATIENTNO = "IV_IPNUMBER";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUT_REQUESTDATA = "OCURSOR_REQUEST_DATA";
            internal const string PARAM_OUT_SURGDATA = "OCURSOR_SURG_DATA";
            internal const string PARAM_OUT_SURGEONSDATA = "OCURSOR_SURGEONS_DATA";
            internal const string PARAM_OUT_ANAEDATA = "OCURSOR_ANAE_DATA";
        }

        public class p_getpatientpolicydetails
        {
            internal const string NAME = "BILLING.p_getpatientpolicydetails";
            internal const string PARAM_IV_UHID = "iv_uhid";
            internal const string PARAM_IV_PATIENTIDENTIFIERNO = "iv_patientidentifierno";
            internal const string PARAM_IV_LOCATIONID = "iv_locationid";
            internal const string PARAM_OUT_PATIENTPOLICY = "oc_patientpolicy";
            internal const string PARAM_OUT_PATIENTPOLICYMASTER = "oc_patientpolicymaster";
        }
        #endregion

        #region "Medication Orders"

        public class DG_SAVEMEDICATIONORDERS
        {
            internal const string SPNAME = "WARDS.DG_SaveMedicationOrders";
            internal const string OUT_PRESCRIPTIONNO = "OUT_PRESCRIPTIONNO";
            internal const string IN_ADMISSIONNO = "IN_ADMISSIONNO";
            internal const string v_UHID = "v_UHID";
            internal const string v_DIAGNOSIS = "v_DIAGNOSIS";
            internal const string v_HEIGHT = "v_HEIGHT";
            internal const string v_WEIGHT = "v_WEIGHT";
            internal const string v_BSA = "v_BSA";
            internal const string v_BMI = "v_BMI";
            internal const string v_LOCATIONID = "v_LOCATIONID";
            internal const string v_DOCTORNAME = "v_DOCTORNAME";
            internal const string v_PRESCRIPTIONDATE = "v_PRESCRIPTIONDATE";
            internal const string v_HEIGHTTYPE = "v_HEIGHTTYPE";
            internal const string v_WEIGHTTYPE = "v_WEIGHTTYPE";
            internal const string v_STATUS = "v_STATUS";
            internal const string v_CREATEDBY = "v_CREATEDBY";
            internal const string v_INSTRUCTION = "v_INSTRUCTION";
            internal const string v_PRESCRIPTIONTYPE = "v_PRESCRIPTIONTYPE";
            internal const string v_TRANSACTIONALSTATUS = "v_TRANSACTIONALSTATUS";
            internal const string v_IPNUMBER = "v_IPNUMBER";
            internal const string v_REASONFORPRESCRIPTION = "v_REASONFORPRESCRIPTION";
            internal const string v_DISCHARGEMEDICATION = "v_DISCHARGEMEDICATION";
            internal const string v_IPBILL = "v_IPBILL";
            internal const string V_Medication_Details = "V_Medication_Details";

        }
        // update draft prescription
        public class DG_UpdateDraftPrescription
        {
            internal const string SPNAME = "WARDS.DG_UpdateDraftPrescription";

            internal const string IN_ADMISSIONNO = "IN_ADMISSIONNO";
            internal const string v_CREATEDBY = "v_CREATEDBY";
            internal const string v_DISCHARGEMEDICATION = "v_DISCHARGEMEDICATION";
            internal const string v_IPBILL = "v_IPBILL";
            internal const string v_DOCTORNAME = "v_DOCTORNAME";
            internal const string V_PRESCRIPTIONNO = "V_PRESCRIPTIONNO";
            internal const string V_PRESCRIPTIONDETAILID = "V_PRESCRIPTIONDETAILID";
            internal const string v_IPNUMBER = "v_IPNUMBER";
            internal const string V_Medication_Details = "V_Medication_Details";

        }
        public class DG_getmedicinevalues
        {
            internal const string SPNAME = "WARDS.p_dg_getmedicinevalues";
            internal const string PARAM_OUT_Frequency = "ocursor_frequency";
            internal const string PARAM_OUT_Quantity = "ocursor_quantity";
            internal const string PARAM_OUT_Relationmeals = "ocursor_relationmeals";
            internal const string PARAM_OUT_DURATION = "OREF_DURATION";
            internal const string PARAM_OUT_YESNO = "OREF_YESNO";
            internal const string PARAM_OUT_RouteOfAdmin = "ocursor_listofrouteofadmin";
            internal const string PARAM_OUT_TYPEOFROUTEOFADMIN = "OCursor_TYPEOFROUTEOFADMIN";
        }
        //AddMedicineFavList
        public class DG_AddMedFAV
        {
            internal const string SPNAME = "DIGITAL.DG_Addfavlist";
            internal const string IV_DRUGALIAS = "IV_DRUGALIAS";
            internal const string IV_DOCTORID = "IV_DOCTORID";
            internal const string IV_DRUGID = "IV_DRUGID";
            internal const string IV_LOCATIONID = "IV_LOCATIONID";
            internal const string IV_FREQUENCYTYPE = "IV_FREQUENCYTYPE";
            internal const string IV_FREQUENCY = "IV_FREQUENCY";
            internal const string IV_QUANTITY = "IV_QUANTITY";
            internal const string IV_QUANTITYTYPE = "IV_QUANTITYTYPE";
            internal const string IV_MEALSRELATION = "IV_MEALSRELATION";
            internal const string IV_DURATION = "IV_DURATION";
            internal const string IV_DURATIONTYPE = "IV_DURATIONTYPE";
            internal const string IV_STRENGTH = "IV_STRENGTH";
            internal const string IV_QLFor = "IV_QLFor";
            internal const string PARAM_OUT_SERVICEITEM = "OUT_RETCODE";
        }
        //GetItemCategory

        public class DG_GetItemCategory
        {
            internal const string SPNAME = "PHARMACY.P_UC_GetItemCategory";
            internal const string in_itemtype = "in_itemtype";
            internal const string PARAM_OUT_Item = "oCursor_ItemCategory";
        }
        //getitemtypecategory
        public class DG_GetItemTypeCategory
        {
            internal const string SPNAME = "PHARMACY.P_UC_GetItemTypeCategory";
            internal const string PARAM_OUT_Itemtype = "oCursor_ItemType";
            internal const string PARAM_OUT_Itemcategory = "oCursor_ItemCategory";
        }
        //getitemsearch
        public class DG_GetItemSearch
        {
            internal const string SPNAME = "PHARMACY.P_GETWARDSITEMDETAILS";
            internal const string iv_StoreCode = "iv_StoreCode";
            internal const string iv_LocationId = "iv_LocationId";
            internal const string iv_ShortDesc = "iv_ShortDesc";
            internal const string iv_ItemType = "iv_ItemType";
            internal const string iv_ItemCategory = "iv_ItemCategory";
            internal const string iv_ParentStoreCode = "iv_ParentStoreCode";
            internal const string iv_checkflag = "iv_checkflag";
            internal const string PARAM_OUT_Itemsearch = "oCursor_GetItems";
        }
        public class DG_GetItemSearchstorecode
        {
            internal const string SPNAME = "PHARMACY.P_GETIPSTORECODE";
            internal const string iv_LocationId = "IV_LOCATIONID";
            internal const string PARAM_OUT_Itemsearchstorecode = "OCURSOR_RESULT";
        }
        //getpreviouspresc
        public class DG_GetPrescription
        {
            internal const string SPNAME = "WARDS.DG_GetPreviousPresc_IP";
            internal const string iv_LocationId = "iv_LocationId";
            internal const string iv_IPNumber = "iv_IPNumber";
            internal const string iv_UHID = "iv_UHID";
            internal const string iv_DoctorID = "iv_DoctorID";
            internal const string iv_fromdate = "iv_fromdate";
            internal const string iv_todate = "iv_todate";
            internal const string iv_currentepisode = "iv_currentepisode";
            internal const string iv_consultant = "iv_consultant";
            internal const string PARAM_OUT_PrevPresc = "OCursor_PrescriptionDetails";
            internal const string PARAM_OUT_Prevnondrug = "oCursor_NonDrugDetails";

        }

        //get draft prescription
        public class DG_GetDraftPrescription
        {
            internal const string SPNAME = "WARDS.DG_GetDraft";
            internal const string iv_LocationId = "iv_LocationId";
            internal const string iv_IPNumber = "iv_IPNumber";
            internal const string iv_UHID = "iv_UHID";
            internal const string iv_DoctorID = "iv_DoctorID";
            internal const string iv_fromdate = "iv_fromdate";
            internal const string iv_todate = "iv_todate";
            internal const string iv_currentepisode = "iv_currentepisode";
            internal const string iv_consultant = "iv_consultant";
            internal const string PARAM_OUT_PrevPresc = "OCursor_PrescriptionDetails";

        }
        //getopprevpresc
        public class DG_previousmedicines
        {
            internal const string SPNAME = "WARDS.DG_GetPreviousPresc_OP";
            internal const string IV_LOCATIONID = "IV_LOCATIONID";
            internal const string IV_UHID = "IV_UHID";
            internal const string IV_DOCTORID = "IV_DOCTORID";
            internal const string IV_FROMDATE = "IV_FROMDATE ";
            internal const string IV_TODATE = "IV_TODATE ";
            internal const string IV_consultant = "IV_consultant";
            internal const string PARAM_OUT_OPPrescriptions = "OCURSOR_PREVIOUSPRCP";
        }
        //getahcprevpresc
        public class DG_GetPreviousPresc_AHC
        {
            internal const string SPNAME = "AHC.DG_GetPreviousPresc_AHC";
            internal const string IV_LOCATIONID = "iv_LocationId";
            internal const string IV_UHID = "iv_UHID";
            internal const string IV_DOCTORID = "iv_DoctorID";
            internal const string IV_FROMDATE = "IV_FROMDATE ";
            internal const string IV_TODATE = "IV_TODATE ";
            internal const string IV_consultant = "IV_consultant";
            internal const string PARAM_OUT_AHCPrescriptions = "O_cursorahcdetails";
        }
        //getfavnondruglist
        public class DG_GetFavnondrugQL
        {
            internal const string SPNAME = "DIGITAL.DG_GETFAVDRUGQL";
            internal const string IV_DOCTORID = "IV_DOCTORID";
            internal const string IV_LocationID = "IV_LocationID";
            internal const string IV_QLFor = "IV_QLFor";
            internal const string PARAM_OUT_favnondrug = "OCURSOR_ALIASCHILD";
        }
        //SaveNonDrugRequest
        public class DG_ADDINDENTPRESCRIPTION
        {
            internal const string SPNAME = "PHARMACY.DG_ADDINDENTPRESCRIPTION";
            internal const string V_UHIDNumber = "V_UHIDNumber";
            internal const string V_IPNO = "V_IPNO";
            internal const string V_LocationId = "V_LocationId";
            internal const string V_IndentCode = "V_IndentCode";
            internal const string V_CreatedBy = "V_CreatedBy";
            internal const string V_MaterialProfileCode = "V_MaterialProfileCode";
            internal const string V_INDENTDETAILS = "V_INDENTDETAILS";
            internal const string PARAM_OUT_RETRECEIVEITEMSCODE = "V_RETRECEIVEITEMSCODE";
        }
        //final save
        public class P_FINALIZE_PRESC
        {
            internal const string SPNAME = "WARDS.P_FINALIZE_PRESC";
            internal const string V_IPNO = "V_IPNUMBER";
            internal const string V_LocationID = "V_LOCATIONID";
            internal const string V_LoginID = "V_LOGINID";
        }
        //Cancel Draft Prescription
        public class DG_CANCEL_DRAFTPRESC
        {
            internal const string SPNAME = "WARDS.DG_CANCEL_DRAFTPRESC";
            internal const string V_IPNO = "V_IPNUMBER";
            internal const string V_LoginID = "V_LOGINID";
            internal const string V_LocationID = "V_LOCATIONID";
            internal const string V_PrescriptionNo = "V_PRESCRIPTIONNO";

        }

        public class DG_Getprescfreqtimings
        {
            internal const string SPNAME = "WARDS.p_getprescfreqtimings";
            internal const string iv_FrequencyId = "IN_FREQUENCYID";
            internal const string iv_LocationId = "IV_LOCATIONID";
            internal const string PARAM_OUT_FreqTimings = "oref_freqtimings";

        }
        #endregion

        public class dg_getinstructions_report
        {
            internal const string SPNAME = "DIGITAL.dg_getinstructions_report";
            internal const string PARAM_in_ipnumber = "IPNumber";
            internal const string PARAM_in_doctorid = "DoctorID";
            internal const string PARAM_in_locationId = "LocationId";
            internal const string PARAM_in_fromdate = "fromdate";
            internal const string PARAM_in_todate = "todate";
            internal const string PARAM_Out_instructionsreport_IP = "OCURSOR_DOCID";
            internal const string PARAM_Out_QFcode = "Out_QFcode";

        }
        public class DG_GETPROGRESSNOTE_REPORTS
        {
            internal const string NAME = "DIGITAL.dg_progressnotes_report";
            internal const string NURSINGREPORT_NAME = "digital.dg_NursingNotes_report";
            internal const string IN_Ipnumber = "in_ipnumber";
            internal const string IN_ResourceId = "in_doctorid";
            internal const string IN_LocationId = "in_locationid";
            internal const string IN_FromDate = "in_fromdate";
            internal const string IN_ToDate = "in_todate";
            internal const string out_details = "out_details";
            internal const string patient_details = "patient_details";
            internal const string Out_QFcode = "Out_QFcode";
        }
        #region Intial Assessment Report
        //Code Changed By Shubhankar
        public class Report_IA
        {
            internal const string in_doctorid = "in_doctorid";
            internal const string IN_LocationId = "in_locationId";
            internal const string IPNumber = "in_ipnumber";
            internal const string NAME = "DIGITAL.DG_IntialAsessmentMF_Reports";
            internal const string ResourceId = "in_doctorid";
            internal const string initial_assessment = "initial_assessment";
            internal const string initial_assessment_habbits = "initial_assessment_habbits";
            internal const string initial_assessment_vitals = "initial_assessment_vitals";
            internal const string initial_assessment_pcplan = "initial_assessment_pcplan";
            internal const string initial_assessment_ia = "initial_assessment_ia";
            internal const string qfcodemaster = "qfcodemaster";
            internal const string refcurs_ip = "refcurs_ip";
            internal const string initial_assessment_diagn = "initial_assessment_diagn";
            internal const string INTIALVITAL_DATE = "INTIALVITAL_DATE";
            internal const string initial_assessment_missing = "initial_assessment_missing";
            internal const string initial_assessment_missing1 = "initial_assessment_missing1";
            internal const string initial_assessment_missing2 = "initial_assessment_missing2";
            internal const string initial_assessment_missing3 = "initial_assessment_missing3";
            internal const string initial_assessment_Surgery = "initial_assessment_Surgery";
            internal const string initial_assessment_Radio = "initial_assessment_Radio";
            internal const string initial_assessment_DisPlanForm = "initial_assessment_DisPlanForm";
            // code added by rakesh for IA Medication
            internal const string initial_assessment_Medication = "initial_assessment_Medication";
            internal const string initial_assessment_SourceDisp = "initial_assessment_SourceDisp";

        }

        #endregion Intial Assessment Report
        #region get referral doctors for instructions screen

        public class DG_GETREFERRALDOCTOR_LIST
        {
            internal const string NAME = "DIGITAL.P_DG_GETREFERRALDOCTOR_LIST";
            internal const string PARAM_IN_Ipnumber = "Ipnumber";
            internal const string PARAM_IN_LocationId = "LocationId";
            internal const string PARAM_OUT_REFCURSCOUNT_IP = "REFCURSCOUNT_IP";
            internal const string PARAM_OUT_REFCURS_IP = "REFCURS_IP";
        }

        #endregion get referral doctors for instructions screen

        public class DG_GetInstructionAcknowledgments
        {
            internal const string NAME = "DIGITAL.P_DG_GetInsAcknowledements";
            internal const string PARAM_in_instructionackbatchid = "in_instructionackbatchid";
            internal const string PARAM_in_locationId = "in_locationId";
            internal const string PARAM_in_ipnumber = "in_ipnumber";
            internal const string PARAM_out_AcknowledgmentDetails = "out_AcknowledgmentDetails";
        }

        #region Role Matrix
        public class DG_ROLEMATRIX
        {
            internal const string SPNAME = "DIGITAL.p_DG_GetRoleMatrixData";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_DOCTORID = "IV_DOCTORID";
            internal const string PARAM_OUT_ROLEMATRIXDATA = "OCURSOR_ROLEMATRIXDATA";
        }
        #endregion

        #region Results Consolidated

        public class ResultsConsolidated
        {

            internal const string Name = "DIGITAL.DG_GETCONSOLIDATED_Report";
            internal const string IV_Doctorid = "IV_Doctorid";
            internal const string IV_LRN = "IV_LRN";
            internal const string IV_UHID = "IV_UHID";
            internal const string IV_PATIENTSERVICENO = "IV_PATIENTSERVICENO";
            internal const string in_locationId = "in_locationId";
            internal const string PARAM_OUT_OREF_TESTPARAMETER = "OREF_TESTPARAMETER";
            internal const string PARAM_OUT_oc_PatientDetails = "oc_PatientDetails";

        }
        #endregion
        #region QuickNotes
        public class DG_GETQUICKNOTES
        {
            internal const string NAME = "DIGITAL.DG_P_GETQUICKNOTES";
            internal const string PARAM_IV_FLAG = "IV_IADSFLAG";
            internal const string PARAM_IV_SPECIALITYID = "IV_SPECIALITYID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_DRAFT = "IV_DRAFTSTATUS";
            internal const string PARAM_IN_PATIENTTYPE = "IV_PATIENTTYPE";
            internal const string PARAM_IN_REQUIREDDATE = "IV_REQUIREDDATE";
            internal const string PARAM_OUT_COMPONENT1 = "OCURSOR_TEXTBOXPARAMETERS";
            internal const string PARAM_OUT_COMPONENT2 = "OCURSOR_QUICKNOTESDATA";
            internal const string PARAM_OUT_COMPONENT3 = "OCURSOR_QUICKNOTESBULKDATA";
        }
        #endregion
        #region PreviousIpList
        public class DG_GetPreviousIPList
        {
            internal const string NAME = "DIGITAL.DG_getpreviousiplist";
            internal const string PARAM_IN_ResourceId = "IV_RESOURCEID";
            internal const string PARAM_IN_LocationId = "IV_location";
            internal const string PARAM_IN_FROMDT = "IV_Fromdt";
            internal const string PARAM_IN_TODT = "IV_Todt";
            internal const string PARAM_OUT_SERVICEITEM = "REFCURS_IP";
        }
        #endregion

        #region InvestigationOrders_Rad

        public class P_GETDEPARTMENTMODALITIES
        {
            internal const string Name = "Radiology.PKG_RADDEPTMDLMASTER_P_GETDEPARTMENTMODALITIES";
            internal const string IN_DeptId = "IN_DEPTID";
            internal const string IN_MdLovDtlId = "IN_MDLLOVID";
            internal const string IN_PhyLocId = "IN_PHYLOCID";
            internal const string IN_LocationId = "IN_LOCATIONID";
            internal const string PARAM_OUT_OCURSOR_GETRESULTS = "OCURSOR_GETRESULTS";
        }
        public class P_GETRADSERVICES
        {
            internal const string Name = "radiology.PKG_RADSERVICEMASTER_P_GETRADSERVICES";
            internal const string IN_ModalityId = "IN_MODALITYID";
            internal const string IN_DeptId = "IN_DEPTID";
            internal const string IN_LocationId = "IV_LOCATIONID";
            internal const string IN_Age = "IN_AGE";
            internal const string IN_GenderId = "IV_GENDERID";
            internal const string IN_PatientConditionId = "IV_PATIENTCONDITIONID";
            internal const string PARAM_OUT_OCURSOR_RADSERVICES = "OCURSOR_RADSERVICES";
        }
        public class P_GETQUICKLIST
        {
            internal const string Name = "PKG_RADUSERQUICKLIST.P_GETQUICKLIST";
            internal const string IN_UserId = "IN_USERID";
            internal const string IN_LocationId = "IN_LOCATIONID";
            internal const string PARAM_OUT_OCURSOR_QUICKLIST = "OCURSOR_QUICKLIST";
        }
        #endregion
        #region GETSPECIALITIES
        public class p_getlocationspecialities
        {
            internal const string NAME = "HR.P_GETLOCATIONSPECIALITIES";
            internal const string PARAM_in_mappingid = "in_mappingid";
            internal const string PARAM_in_specialityid = "in_specialityid";
            internal const string PARAM_in_locationId = "iv_locationid";
            internal const string PARAM_out_locations = "ocursor_locations";
            internal const string PARAM_out_locnspecialities = "ocursor_locnspecialities";
        }
        #endregion

        #region GETREVIEWCONSULTANTS
        public class P_GETDOCTORS
        {
            internal const string NAME = "HR.P_GETDOCTORS";
            internal const string PARAM_IV_DEPARTMENTID = "IV_DEPARTMENTID";
            internal const string PARAM_in_Specialityid = "in_Specialityid";
            internal const string PARAM_in_locationId = "iv_locationID";
            internal const string PARAM_iv_flag = "iv_flag";
            internal const string PARAM_out_doctors = "OCURSOR_DOCTORS";
        }
        #endregion
        public class DG_SearchMedicine
        {
            internal const string NAME = "DIGITAL.P_DRUG_PHARMACYITEMS";
            internal const string PARAM_IN_SEARCHSTRING = "iv_searchstring";
            internal const string PARAM_IN_LOCATIONID = "iv_locationid";
            internal const string PARAM_OUT_SEARCHMEDICINE = "OCURSOR_PHARMACYITEMS";

        }
        public class DG_GETINVETIGATIONCONSOLIDATED_REPORTS
        {
            internal const string NAME = "LAB.P_GETEPISODEBATCHPRINTING";
            internal const string IV_PATIENTSERVICENO = "IV_PATIENTSERVICENO";
            internal const string oc_PatientDetails = "oc_PatientDetails";
            internal const string OREF_LRNDETAILS = "OREF_LRNDETAILS";
            internal const string OREF_TESTPARAMETER = "OREF_TESTPARAMETER";
        }
        # region OP Parameter Sequence
        public class DG_GETOPPARAMSEQ
        {
            internal const string SPNAME = "DIGITAL.DG_GETOPPARAMSEQ";
            internal const string PARAM_IV_RESOURCEID = "IN_RESOURCEID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_TEMPLATENAME = "IN_TemplateName";
            internal const string PARAM_IV_IN_RESET = "IN_RESET";
            internal const string PARAM_OUT_Sequence = "OUT_Sequence";
            internal const string PARAM_OUT_ISDEFAULT = "OUT_ISDEFAULT";
            internal const string PARAM_OUT_ISRESET = "OUT_ISRESET";
        }
        public class DG_RESETOPPARAMSEQ
        {
            internal const string SPNAME = "DG_RESETOPPARAMSEQ";
            internal const string PARAM_IV_RESOURCEID = "IN_RESOURCEID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_TEMPLATENAME = "IN_TemplateName";
            internal const string PARAM_OUT_Sequence = "OUT_Sequence";
            internal const string PARAM_OUT_ISDEFAULT = "OUT_ISDEFAULT";
        }
        public class DG_GETOPSORTEDSEQ
        {
            internal const string SPNAME = "DIGITAL.DG_GETOPSORTEDSEQ";
            internal const string PARAM_IV_RESOURCEID = "IN_RESOURCEID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_TEMPLATENAME = "IN_TemplateName";
            internal const string PARAM_OUT_Sequence = "OUT_Sequence";
        }
        //temp type
        public class DG_GETTEMPFLAG
        {
            internal const string SPNAME = "DIGITAL.DG_GETTEMPFLAG";
            internal const string PARAM_IV_APPOINTMENTID = "IN_APPOINTMENTID";
            internal const string PARAM_IV_BILLINGNO = "IN_BILLINGNO";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_UHID = "IN_UHID";
            internal const string PARAM_OUT_Sequence = "OUT_Sequence";
        }
        public class DG_GETDRAFTTEMP
        {
            internal const string SPNAME = "DIGITAL.DG_GETDRAFTTEMP";
            internal const string PARAM_IV_AVAILABLEID = "IN_AVAILABLEID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_UHID = "IN_UHID";
            internal const string PARAM_OUT_Sequence = "OUT_Sequence";
        }
        public class DG_SaveOPParamSeq
        {
            internal const string SPNAME = "DIGITAL.DG_SaveOPParamSeq";
            internal const string PARAM_in_DoctorId = "in_DoctorId";
            internal const string PARAM_in_LocationID = "in_LocationID";
            internal const string PARAM_IN_TemplateName = "IN_TemplateName";
            internal const string PARAM_IN_ParameterName = "IN_ParameterName";
            internal const string PARAM_IN_SEQ = "IN_SEQ";
            internal const string PARAM_IN_PRSEQ = "IN_PRSEQ";

        }
        public class DG_GETPRISMFLAG
        {
            internal const string SPNAME = "DIGITAL.DG_GETPRISMFLAG";
            internal const string PARAM_IV_IPNUMBER = "IN_IPNO";
            internal const string PARAM_IV_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_Cursor = "OUT_Cursor";
        }
        public class DG_GETPRISMFLAGOP
        {
            internal const string SPNAME = "DIGITAL.DG_GETPRISMFLAGOP";
            internal const string PARAM_IV_OPNUMBER = "IN_OPNO";
            internal const string PARAM_IV_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_Cursor = "OUT_Cursor";
        }
        public class DG_GETPRISMFLAGAHC
        {
            internal const string SPNAME = "DIGITAL.DG_GETPRISMFLAGAHC";
            internal const string PARAM_IV_AHCNUMBER = "IN_AHCNO";
            internal const string PARAM_IV_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_Cursor = "OUT_Cursor";
        }
        public class DG_GETPRISMFLAGRADIOLOGY
        {
            internal const string SPNAME = "DIGITAL.DG_GETPRISMFLAGRADIOLOGY";
            internal const string PARAM_IV_DRNNUMBER = "IN_DRNNO";
            internal const string PARAM_IV_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_Cursor = "OUT_Cursor";
        }
        public class DG_GETPRISMFLAGLAB
        {
            internal const string SPNAME = "DIGITAL.DG_GETPRISMFLAGLAB";
            internal const string PARAM_IV_LRNNUMBER = "IN_LRNNO";
            internal const string PARAM_IV_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IV_DEPTID = "IN_DEPTID";
            internal const string PARAM_IV_TESTID = "IN_TESTID";
            internal const string PARAM_OUT_Cursor = "OUT_Cursor";
        }
        public class DG_UPDATEPRISMFLAG
        {
            internal const string SPNAME = "DIGITAL.DG_UPDATEPRISMFLAG";
            internal const string PARAM_IN_IPNUMBER = "IN_IPNO";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_FLAG = "IN_FLAG";
        }
        public class DG_UPDATEPRISMFLAGOP
        {
            internal const string SPNAME = "DIGITAL.DG_UPDATEPRISMFLAGOP";
            internal const string PARAM_IN_OPNUMBER = "IN_OPNO";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_FLAG = "IN_FLAG";
        }
        public class DG_UPDATEPRISMFLAGAHC
        {
            internal const string SPNAME = "DIGITAL.DG_UPDATEPRISMFLAGAHC";
            internal const string PARAM_IN_AHCNUMBER = "IN_AHCNO";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_FLAG = "IN_FLAG";
        }
        public class DG_UPDATEPRISMFLAGRADIOLOGY
        {
            internal const string SPNAME = "DIGITAL.DG_UPDATEPRISMFLAGRADIOLOGY";
            internal const string PARAM_IN_DRNNUMBER = "IN_DRNNO";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_FLAG = "IN_FLAG";
        }
        public class DG_GETOPTEMPTYPE
        {
            internal const string SPNAME = "DIGITAL.DG_GETOPTEMPTYPE";
            internal const string PARAM_IV_OPNUMBER = "IN_OPNO";
            internal const string PARAM_IV_VISITID = "IN_VISITID";
            internal const string PARAM_IV_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IV_UHID = "IN_UHID";
            internal const string PARAM_OUT_Cursor = "OUT_Cursor";
        }
        public class DG_GETLABSTATUS
        {
            internal const string SPNAME = "DIGITAL.DG_GETLABSTATUS";
            internal const string PARAM_IV_TESTID = "IN_TESTID";
            internal const string PARAM_IV_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_Cursor = "OUT_TESTFLAG";
        }
        public class DG_GETPATIENTSTATUS
        {
            internal const string SPNAME = "DIGITAL.DG_GETPATIENTSTATUS";
            internal const string PARAM_IV_UHID = "IN_UHID";
            internal const string PARAM_OUT_Cursor = "OUT_STATUS";
        }
        public class DG_GETDAMA
        {
            internal const string SPNAME = "DIGITAL.DG_GETDAMA";
            internal const string PARAM_IV_DISCHARGENO = "IN_DISCHARGENO";
            internal const string PARAM_OUT_Cursor = "OUT_DAMA";
        }
        public class DG_UPDATEPRISMFLAGLAB
        {
            internal const string SPNAME = "DIGITAL.DG_UPDATEPRISMFLAGLAB";
            internal const string PARAM_IN_LRNNUMBER = "IN_LRNNO";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_DEPTID = "IN_DEPTID";
            internal const string PARAM_IN_TESTID = "IN_TESTID";
            internal const string PARAM_IN_FLAG = "IN_FLAG";
        }
        #endregion
        #region DrugDetails

        public class P_GETDRUGADMIN
        {
            internal const string NAME = "DIGITAL.P_GETDRUGADMIN";
            internal const string IN_IpNo = "in_IPNUMBER";
            internal const string IN_LocId = "iv_LocationId";
            internal const string IN_Date = "id_Date";
            internal const string IN_RoleID = "IN_RoleID";
            internal const string o_drugdet = "OCursor_DrugAdminNotDone";
            internal const string o_emardrugdet = "OCursor_DrugAdminDone";
            internal const string o_emarroleprevilage = "OCURSOR_EMARROLEPREVILAGE";
            internal const string o_nurseaccess = "OCURSOR_NURSEACCESS";
        }

        #endregion
        #region nursing
        public class DG_GETIPNURSEDASHBOARD_ALL
        {
            internal const string NAME = "DIGITAL.P_GETIPNURSEDASHBOARD_ALL_DG";
            internal const string PARAM_IN_ResourceId = "IV_RESOURCEID";
            internal const string PARAM_IN_LocationId = "IV_location";
            internal const string PARAM_OUT_SERVICEITEM = "REFCURS_IP";
            internal const string PARAM_OUT_TRANSFERITEM = "REFCURS_TRANSFER";
            internal const string PARAM_OUT_WARDDETAILS = "REFCURS_WARDDETAILS";
        }
        public class DG_GETPENDINGCHECKIN
        {
            internal const string NAME = "WARDS.P_GETPENDINGFORCHECKINNURSE_DG";
            internal const string PARAM_IN_ResourceId = "iv_nurseid";
            internal const string PARAM_IN_LocationId = "iv_locationid";
            internal const string PARAM_OUT_OCURSOR_NEWADMISSION = "OCURSOR_NEWADMISSION";

        }

        public class DG_MENUITEMS
        {
            internal const string NAME = "SECURITYTEST_64.P_GETMENUITEMS_DG";
            internal const string PARAM_IN_ROLEID = "IV_ROLEID";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUT = "REFCUR_MENUITEMS";
        }


        public class P_GetNurseSettings_DG
        {
            internal const string NAME = "DIGITAL.P_GetNurseSettings_DG";
            internal const string PARAM_IN_NurseId = "in_NurseId";
            internal const string PARAM_IN_LocationId = "in_LocationId";
            internal const string PARAM_OUT_Result_Defaults = "oCursor_Result_DEFAULTS";
            internal const string PARAM_OUT_Result_transact = "oCursor_Result_transact";
        }
        public class P_GetNurseDefaultSettings_DG
        {
            internal const string NAME = "DIGITAL.P_GetNurseDefaultSettings_DG";
            internal const string PARAM_IN_NurseId = "in_NurseId";
            internal const string PARAM_IN_LocationId = "in_LocationID";
            internal const string PARAM_OUT_Result_DefaultDashboard = "oCursor_Result_DD";
            internal const string PARAM_OUT_Result_DefaultSortOrder = "oCursor_Result_DS";
            internal const string PARAM_OUT_Result_AutoSave = "oCursor_Result_AS";
            internal const string PARAM_OUT_Result_ShortLinksSequence = "oCursor_Result_DSEQ";
            internal const string PARAM_OUT_Result_Defaults = "oCursor_Result_DEFAULTS";
        }
        public class P_AddNurseDefaultSettings_DG
        {
            internal const string NAME = "DIGITAL.P_AddNurseDefaultSettings_DG";
            internal const string PARAM_IN_NurseId = "in_NurseId";
            internal const string PARAM_IN_LocationId = "in_LocationID";
            internal const string PARAM_IN_LOVId = "in_lovid";
            internal const string PARAM_IN_LOVDetailId = "in_lovdetailid";
            internal const string PARAM_IN_LOVValue = "in_lovvalue";
            internal const string PARAM_IN_User = "in_user";
            internal const string PARAM_IN_istransact = "in_istransact ";
            internal const string PARAM_IN_MasterDtaSetup = "in_MasterDtaSetup";
            internal const string SPNAME = "DIGITAL.P_AddMASTERSETTINGS_DG";
        }
        public class DG_VIEWEXISTINGASSGNMENTS
        {
            internal const string NAME = "ADT.p_ViewExistingAssignments_DG";
            internal const string PARAM_IN_WARDID = "in_leveldetailid";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_OCURSOR_EXTNGASGNMTS = "ocursor_iplist";
        }

        #region WARDTRANSFER
        public class AT_GetWardLevelMaster
        {
            internal const string SPNAME = "ADT.P_GetWardLevelMaster";
            internal const string PARAM_in_ParentLevelID = "in_ParentLevelID";
            internal const string PARAM_in_LevelDetailCode = "iv_LevelDetailCode";
            internal const string PARAM_in_LevelDetailName = "iv_LevelDetailName";
            internal const string PARAM_in_LevelTypeID = "in_LevelTypeID";
            internal const string PARAM_in_LevelOccupancyTypeID = "in_LevelOccupancyTypeID";
            internal const string PARAM_in_LevelSpecialityId = "in_LevelSpecialityID";
            internal const string PARAM_in_Status = "in_Status";
            internal const string PARAM_in_LevelNo = "in_LevelNo";
            internal const string PARAM_in_locationId = "in_locationid";
            internal const string PARAM_out_LevelMaster = "oCursor_LevelMaster";


        }

        public class AT_GETBEDCATEGORYMASTER
        {
            internal const string SPNAME = "ADT.P_GETBEDCATEGORYMASTER";
            internal const string PARAM_in_CategoryName = "IV_CATEGORYNAME";
            internal const string PARAM_in_Categorycode = "IV_CATEGORYCODE";
            internal const string PARAM_in_Rank = "IN_RANK";
            internal const string PARAM_in_Status = "IN_STATUS";
            internal const string PARAM_in_locationId = "in_LocationID";
            internal const string PARAM_out_BEDCATEGORYMaster = "OCURSOR_BEDCATEGORY";
        }

        public class AT_GetPatientOccupiedBeds
        {
            internal const string SPNAME = "ADT.P_GetPatientOccupiedBeds";
            internal const string PARAM_in_IPNO = "IV_INPATIENTNO";
            internal const string PARAM_in_UHID = "iv_UHID";
            internal const string PARAM_in_locationId = "in_LocationID";
            internal const string PARAM_out_Result = "OCURSOR_RESULT";
            internal const string PARAM_out_PatientHistory = "oCursor_TransferHistory";

        }

        public class AT_GetPendingApprovals
        {
            internal const string SPNAME = "ADT.P_GETPROCESSPENDINGREQUESTS";
            internal const string PARAM_in_ProcessID = "in_processID";
            internal const string PARAM_out_Result = "O_CursorProcessPendingRequest";

        }

        public class AT_ApprovalRequired
        {
            internal const string SPNAME = "ADT.P_ApprovalRequired";
            internal const string PARAM_in_ProcessID = "IN_ProcessID";
            internal const string PARAM_out_Status = "oN_Status";

        }

        public class AT_AddBedTransfer
        {
            internal const string SPNAME = "ADT.P_ADDBEDTRANSFER";
            internal const string PARAM_in_InpatientID = "IN_INPATIENTID";
            internal const string PARAM_in_CLOB_BEDTRANSFERDETAIL = "ICLOB_BEDTRANSFERDETAIL";
            internal const string PARAM_in_LoginID = "IV_LOGINID";
        }
        public class AT_InitiateApprovalProcess
        {
            internal const string SPNAME = "ADT.P_INITIATEAPPROVALPROCESS";
            internal const string PARAM_in_processID = "in_processID";
            internal const string PARAM_in_RegistrationID = "in_RegistrationID";
            internal const string PARAM_in_LoginID = "iv_LoginID";
            internal const string PARAM_iClob_UHIDXML = "ic_UHIDXML";
            internal const string PARAM_in_Description = "iv_Description";
            internal const string PARAM_in_NotificationRequired = "in_NotificationRequired";
        }
        public class AT_GetTransactionId
        {
            internal const string SPNAME = "ADT.P_GETTRANSACTIONID";
            internal const string PARAM_Out_TRANSACTIONID = "in_TRANSACTIONID";
        }

        public class AT_GetPendingTasks
        {
            internal const string SPNAME = "ADT.P_PENDINGAPPROVALS";
            internal const string PARAM_in_ProcessID = "in_processID";
            internal const string PARAM_in_loginid = "in_loginid";
            internal const string PARAM_out_Approvals = "ocur_Approvals";

        }

        public class AT_ApprovingProcess
        {
            internal const string SPNAME = "ADT.P_APPROVINGPROCESS";
            internal const string PARAM_in_ProcessID = "IN_ProcessID";
            internal const string PARAM_in_ProcessElementID = "IN_ProcessElementID";
            internal const string PARAM_in_ApprovalRole = "IV_ApprovalRole";
            internal const string PARAM_in_ApprovalLevel = "IV_ApprovalLevel";
            internal const string PARAM_in_ApprovalStatus = "IV_ApprovalStatus";
            internal const string PARAM_in_loginid = "IV_LoginID";
            internal const string PARAM_in_Remarks = "IV_Remarks";
            internal const string PARAM_in_TransactionID = "IN_TransactionID";

        }
        //TransferOUt

        public class AT_UPDATETRANSFERREQUEST
        {
            internal const string SPNAME = "ADT.P_UpdateTransferRequest";
            internal const string PARAM_in_ProcessID = "in_processID";
            internal const string PARAM_in_transactionID = "in_transactionID";
            internal const string PARAM_iCLOB_TransferDetails = "iCLOB_TransferDetails";
            internal const string PARAM_in_LoginID = "iv_LoginID";
        }


        #endregion

        #region TRANSFER IN


        //GetPendingTask-Process iD,Transaction ID
        public class AT_GetTransactionsontransid
        {
            internal const string SPNAME = "ADT.P_GetTransactionsontransid";
            internal const string PARAM_in_ProcessID = "in_processID";
            internal const string PARAM_in_transactionID = "in_transactionID";
            internal const string PARAM_in_CurrentLocation = "in_CurrentLocation";
            internal const string PARAM_Out_Result = "oCursor_Result";
        }
        public class Ehis_GetRelationshipMaster
        {
            internal const string SPNAME = "EHIS.p_getrelationshipmaster";
            internal const string PARAM_ocursor_relationship = "ocursor_relationship";
        }

        public class AT_UpdateAttendantDetails
        {
            internal const string SPNAME = "ADT.p_updateattendantdetails_dg";
            internal const string PARAM_in_INPATIENTNO = "IN_INPATIENTNO";
            internal const string PARAM_in_ATTENDANTNAME = "IN_ATTENDANTNAME";
            internal const string PARAM_in_CONTACTNO = "IN_CONTACTNO";
            internal const string PARAM_in_RELATIONSHIP = "IN_RELATIONSHIP";
            internal const string PARAM_in_LOCATIONID = "IN_LOCATIONID";
        }

        //getAdmissionDetails
        public class AT_GetPatientAdmRegDetails
        {
            internal const string SPNAME = "ADT.P_GetAdmissionDetailsforAT";
            internal const string PARAM_in_InpatientNo = "iv_InpatientNo";
            internal const string PARAM_in_LocationID = "in_LocationID";
            internal const string PARAM_out_AdmDetails = "oCursor_AdmDetails";
            internal const string PARAM_Out_Result = "ocursor_RegDetails";
        }


        //getBedHierarchy
        public class AT_GetBedLevelsByBed
        {
            internal const string SPNAME = "ADT.P_GETBEDLEVELSBYBED";
            internal const string PARAM_IN_BEDID = "IN_BEDID";
            internal const string PARAM_out_Result = "OCURSOR_RESULT";
        }

        //getBed Code
        public class AT_GetBedCode
        {
            internal const string SPNAME = "ADT.P_GETBEDCODE";
            internal const string PARAM_IN_BedID = "IN_BedID";
            internal const string PARAM_out_BedCode = "OV_BedCode";
        }


        //CheckActivePatient
        public class AT_CheckActivePatient
        {
            internal const string SPNAME = "ADT.P_CheckActiveInPatient";
            internal const string PARAM_IN_IPNO = "IV_IPNO";
            internal const string PARAM_out_ACTIVE = "OCURSOR_ACTIVE";
        }

        //CheckBedForTransfer
        public class AT_CheckBedForTransfer
        {
            internal const string SPNAME = "ADT.P_CheckBedOccupancyForTransfer";
            internal const string PARAM_IN_BedId = "IV_BedId";
            internal const string PARAM_IN__ipnumber = "in_ipnumber";
            internal const string PARAM_out_BedDetails = "OCursor_BedDetails";
        }

        //CheckBedStatus
        public class AT_CheckBedStatus
        {
            internal const string SPNAME = "ADT.P_CHECKBEDSTATUS";
            internal const string PARAM_IN_BedId = "in_BedID";
            internal const string PARAM_IN__ipnumber = "in_ipnumber";
            internal const string PARAM_out_RESULT = "on_Result";
            internal const string PARAM_out_BEDSTATUS = "oCursor_BedStatus";
        }


        //CheckDischargeStatus
        public class AT_CheckDischargeStatus
        {
            internal const string SPNAME = "ADT.p_checkdischargestatus";
            internal const string PARAM_IN__ipnumber = "in_ipnumber";
            internal const string PARAM_out_STATUS = "status";
        }
        //GetInPatientID
        public class AT_GetInPatientID
        {
            internal const string SPNAME = "ADT.P_GETINPATIENTID";
            internal const string PARAM_IN__ipnumber = "IN_INPATIENTNO";
            internal const string PARAM_out_INPATIENTID = "ON_INPATIENTID";
        }

        //NotificationDone
        public class AT_NotificationDone
        {
            internal const string SPNAME = "ADT.P_NotificationDone";
            internal const string PARAM_in_TransactionID = "in_TransactionID";

        }

        //Update DayCare Status in Wards against the IPNumber
        public class Wards_UpdateDayCareFlag
        {
            internal const string SPNAME = "WARDS.P_UPDATEDAYCAREFLAG";
            internal const string PARAM_in_ipnumber = "Iv_IPNumber";
            internal const string PARAM_in_locationid = "Iv_locationid";

        }

        //Get BedServiceId From Billing
        public class Billing_GETBEDCATEGORYSERVICENAME
        {
            internal const string SPNAME = "BILLING.P_GetBedCategoryServiceName";
            internal const string PARAM_in_locationid = "iv_locationid";
            internal const string PARAM_out_ServiceItemDetails = "o_ServiceItemDetails";
        }



        //TransferDieticianTask
        public class AT_TransferDieticianTask
        {
            internal const string SPNAME = "ADT.P_TransferDieticianTask";
            internal const string PARAM_in_ipnumber = "in_ipnumber";
            internal const string PARAM_in_fromBedCode = "in_fromBedCode";

        }

        public class Billing_ServiceRequest
        {
            internal const string SPNAME = "BILLING.P_AddIPBEDDETAILS";
            internal const string PARAM_in_ixml_IPBedDetails = "ixml_IPBedDetails";
            internal const string PARAM_in_LoginId = "iv_LoginId";

        }


        #endregion

        #region PackageRequest

        public class GetPackagesRaisedfromBilling
        {
            internal const string SPNAME = "BILLING.P_GETPACKAGEDETAILSFORIP";
            internal const string PARAM_IN_Uhid = "IV_Uhid";
            internal const string PARAM_IN__Ipno = "iv_Ipno";
            internal const string PARAM_IN_locationid = "iv_locationid";
            internal const string PARAM_OUT_NonInvasivePackages = "OC_NonInvasivePackages";
            internal const string PARAM_OUT_SurgicalPackages = "OC_SurgicalPackages";
        }

        public class GetPackageTypesfromBilling
        {
            internal const string SPNAME = "BILLING.p_getipsurgicalservicestypes";
            internal const string PARAM_IN_locationid = "iv_locationid";
            internal const string PARAM_OUT_servicetypelist = "oc_servicetypelist";
        }

        public class GetwardPackageItemsfromBilling
        {
            internal const string SPNAME = "BILLING.P_GETSEARCHPACKAGEWARDS";
            internal const string PARAM_IN_servicecategoryid = "in_servicecategoryid";
            internal const string PARAM_IN_servicetypeid = "in_servicetypeid";
            internal const string PARAM_IN_IPNO = "IV_IPNO";
            internal const string PARAM_IN_deptid = "iv_deptid";
            internal const string PARAM_IN_LocationID = "iv_LocationID";
            internal const string PARAM_IN_ispackagedefined = "iv_ispackagedefined";
            internal const string PARAM_IN_customerid = "in_customerid";
            internal const string PARAM_IN_aggrementid = "in_aggrementid";
            internal const string PARAM_IN_ServiceName = "iv_ServiceName";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_OUT_SearchPackage = "O_SEARCHPACKAGE";
        }

        public class GETMINDEPFORIPPACKAGE
        {
            internal const string SPNAME = "BILLING.P_GetMinDepForIPPackage";
            internal const string PARAM_IN_RegNo = "IV_REGISTRATIONNO";
            internal const string PARAM_IN_PatientIdentifier = "IV_PATIENTIDENTIFIERNO";
            internal const string PARAM_IN_LocationID = "IV_LOCATIONID";
            internal const string PARAM_IN_SERVICEID = "IV_SERVICEID";
            internal const string PARAM_OUT_PACKAGEDEPDETAILS = "OC_PACKAGEDEPDETAILS";

        }

        public class UpdateIPServiceApplicableDates
        {
            internal const string SPNAME = "BILLING.P_UpdateIPServiceAppDates";
            internal const string PARAM_Iclob_Requestxml = "iXMLServiceRequest";
            internal const string PARAM_IN_LoginID = "iv_LoginID";

        }

        #endregion

        #region ProfileRequest
        public class BillingGetprofiles
        {
            internal const string SPNAME = "BILLING.P_SEARCHPACKAGE";
            internal const string PARAM_IN_servicecategoryid = "in_servicecategoryid";
            internal const string PARAM_IN_servicetypeid = "in_servicetypeid";
            internal const string PARAM_IN_deptid = "iv_deptid";
            internal const string PARAM_IN_Fromdate = "id_Fromdate";
            internal const string PARAM_IN_ToDate = "id_ToDate";
            internal const string PARAM_IN_LocationID = "iv_LocationID";
            internal const string PARAM_IN_ispackagedefined = "iv_ispackagedefined";
            internal const string PARAM_IN_customerid = "in_customerid";
            internal const string PARAM_IN_aggrementid = "in_aggrementid";
            internal const string PARAM_IN_quoteid = "in_quoteid";
            internal const string PARAM_IN_crmstatus = "iv_crmstatus";
            internal const string PARAM_IN_ServiceName = "iv_ServiceName";
            internal const string PARAM_OUT_SearchPackage = "o_SearchPackage";
        }
        public class BillingGetPackageDetails
        {
            internal const string SPNAME = "BILLING.P_GetPackageDetails";
            internal const string PARAM_IN_packageid = "iv_packageid";
            internal const string PARAM_IN_locationid = "iv_locationid";
            internal const string PARAM_IN__patientidentifierno = "iv_patientidentifierno";
            internal const string PARAM_IN_customerid = "in_customerid";
            internal const string PARAM_IN_aggrementid = "in_aggrementid";
            internal const string PARAM_OUT_packagedefination = "oc_packagedefination";
            internal const string PARAM_OUT_packageiteminclusion = "oc_packageiteminclusion";
            internal const string PARAM_OUT_packageitemexclsion = "oc_packageitemexclsion";
            internal const string PARAM_OUT_packagetypeinclusiondetails = "oc_packagetypeinclusiondetails";
            internal const string PARAM_OUT_packagediscountdetails = "oc_packagediscountdetails";
            internal const string PARAM_OUT_packagegenderapplicability = "oc_packagegenderapplicability";
        }

        public class GetProfilesRaisedfromBilling
        {
            internal const string SPNAME = "BILLING.P_GetProfileDetailsforip";
            internal const string PARAM_IN_Uhid = "IV_Uhid";
            internal const string PARAM_IN__Ipno = "iv_Ipno";
            internal const string PARAM_IN_locationid = "iv_locationid";
            internal const string PARAM_OUT_DateWiseAmounts = "OC_DateWiseAmounts";
        }
        public class HRGETEMPLOYEESLIST
        {
            internal const string SPNAME = "HR.P_GETEMPLOYEESLIST";
            internal const string PARAM_Iclob_EMPLOYEESDETAILS = "IC_EMPLOYEESDETAILS";
            internal const string PARAM_OUT_EMPLOYEESINFO = "OCURSOR_EMPLOYEESINFORMATION";


        }
        public class GETDOCTORSALPHABETIC
        {
            internal const string SPNAME = "HR.P_GET_DOCTORS_ALPHABETIC";
            internal const string PARAM_DEPARTMENTID = "IV_DEPARTMENTID";
            internal const string PARAM_SPECIALITYID = "IN_SPECIALITYID";
            internal const string PARAM_OUT_DOCTORS = "OCURSOR_DOCTORS";
            internal const string PARAM_EMP_ALPHA = "IN_EMP_ALPHA";
            internal const string PARAM_LOCATIONID = "IV_LOCATIONID";

        }
        public class LabGetpriority
        {
            internal const string SPNAME = "LAB.P_GETLOVDETAILS";
            internal const string PARAM_LovCode = "v_LovCode";
            internal const string PARAM_OUT_LovDetail = "OCursor_LovDetail";

        }
        public class CANCELOPBILLSERVICES
        {
            internal const string SPNAME = "BILLING.P_CANCELOPBILLSERVICES";
            internal const string PARAM_IN_servicerequestdetailsid = "in_servicerequestdetailsid";
            internal const string PARAM_IN__requestid = "in_requestid";
            internal const string PARAM_IN_requestno = "in_requestno";
            internal const string PARAM_IN_patientidentifiernumber = "iv_patientidentifiernumber";
            internal const string PARAM_IN_registrationno = "iv_registrationno";
            internal const string PARAM_IN_serviceid = "in_serviceid";
            internal const string PARAM_IN_remarks = "in_remarks";
            internal const string PARAM_IN_locationid = "iv_locationid";
            internal const string PARAM_IN_loginid = "iv_loginid";
            internal const string PARAM_IN_allserviceflag = "iv_allserviceflag";
            internal const string PARAM_IN_BillNo = "iv_BillNo";
            internal const string PARAM_out_cancelstatus = "iv_cancelstatus";

        }

        #endregion

        #region Physiotherapy
        public class DG_PHYSIOTHERAPY
        {
            internal const string NAME = "BILLING.P_GETSERVICES";
            internal const string PARAM_IN_LocationId = "IN_LocationId";
            internal const string PARAM_IN_PatientServiceId = "IN_PATIENTSERVICEID";
            internal const string PARAM_IN_IPNumber = "IN_IPNumber";
            internal const string PARAM_IN_DeptId = "IN_DeptId";
            internal const string PARAM_IN_CategoryId = "IN_CATEGORYID";
            internal const string PARAM_IN_ServiceTypeId = "IN_ServiceTypeID";
            internal const string PARAM_IN_ServiceName = "IN_SERVICENAME";
            internal const string PARAM_IN_Billable = "IN_BILLABLE";
            internal const string PARAM_IN_ServiceStatus = "IN_SERVICESTATUS";
            internal const string PARAM_IN_Restorable = "IN_RESTORABLE";
            internal const string PARAM_IN_ServiceId = "IN_SERVICEID";
            internal const string PARAM_IN_Taxable = "IN_TAXABLE";
            internal const string PARAM_IN_Schedulable = "IN_SCHEDULABLE";
            internal const string PARAM_IN_WildserviceItem = "IN_WildserviceItem";
            internal const string PARAM_IN_Age = "IN_AGE";
            internal const string PARAM_IN_GenderId = "IN_PatientConditionID";
            internal const string PARAM_IN_PatientConditionId = "IN_PatientConditionID";
            internal const string PARAM_IN_RequestStatus = "IN_REQUESTSTATUS";
            internal const string PARAM_IN_RequestNumber = "IN_REQUESTNO";
            internal const string PARAM_IN_From = "IN_FROMDATE";
            internal const string PARAM_IN_To = "IN_TODATE";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_PatientType = "IN_PATIENTTYPE";
            internal const string PARAM_IN_EQUIPMENTDETAILID = "iv_EQUIPMENTDETAILID";
            internal const string PARAM_OUT_OCURSOR_OC_SERVICELIST = "OC_SERVICELIST";

            #region ServiceItemDetails
            internal const string ITEMSP = "billing.p_getserviceitemdetail";
            internal const string PARAM_OUT_OCURSOR_SERVICEITEMDETAILS = "o_serviceitemdetails";
            internal const string PARAM_OUT_OCURSOR_PEM = "o_pem";
            internal const string PARAM_OUT_OCURSOR_PATIENTCONSENT = "o_patientconsent";
            internal const string PARAM_OUT_OCURSOR_PREREQUISITES = "o_prerequisite";
            internal const string PARAM_OUT_OCURSOR_CODESYSTEM = "o_codesystem";
            internal const string PARAM_OUT_OCURSOR_RESOURCEROLE = "o_resourcerole";
            internal const string PARAM_OUT_OCURSOR_EQUIPMENT = "o_equipment";
            internal const string PARAM_OUT_OCURSOR_MATERIAL = "o_material";
            internal const string PARAM_OUT_OCURSOR_GENDERDETAILS = "o_genderdetails";
            internal const string PARAM_OUT_OCURSOR_SERVICEFACILITY = "o_servicefacility";
            internal const string PARAM_OUT_OCURSOR_ROMMDETAILS = "oc_rommdetails";
            internal const string PARAM_OUT_OCURSOR_SERVICEDELIVERY = "oc_servicedelivery";
            internal const string PARAM_OUT_OCURSOR_SERVICEAPPLICABILITY = "oc_serviceapplicability";
            internal const string PARAM_OUT_OCURSOR_O_SCHEDULABLE = "o_o_schedulable";
            internal const string PARAM_OUT_OCURSOR_PATIENTAPPLICABILITY = "oc_patientapplicability";
            #endregion

            internal const string PHYSPNAME = "billing.p_getservices";
            internal const string GETLOVNAME = "wards.P_GETLOVVALUES";
            internal const string ADDFAVSPNAME = "wards.P_ADDFAVOURITES";
            internal const string SPNAME = "wards.P_ADDPHYSIOREQUEST1";
            internal const string RAISEBILLSPNAME = "billing.p_servicerequest";
            internal const string CANCELSPNAME = "wards.P_UPDATEPHYSIOREQUEST";
            internal const string IPBILLSPPNAME = "wards.P_UPDATEPHYSIOREQUEST";
            internal const string PARAM_IN_CLOB_FAVOURITES = "ICLOB_FAVOURITES";
            internal const string PARAM_OUT_PARAM_OUT_ERRORMSG = "ov_ErrorMsg";
            internal const string PARAM_IN_CLOB_PHYSIOTHERAPYREQUEST = "ICLOB_PHYSIOTHERAPYREQUEST";
            internal const string PARAM_IN_LOVID = "IN_LOVID";
            internal const string PARAM_IN_LOVCODE = "IV_LOVCODE";
            internal const string PARAM_IN_LOVDETAILID = "IN_LOVDETAILID";
            internal const string PARAM_IN_LOVDETAILVALUE = "IV_LOVDETAILVALUE";
            internal const string PARAM_OUT_OREF_LOVCURSOR = "OREF_LOVCURSOR";
            internal const string PARAM_OUT_OREF_LOVDETAIL = "OREF_LOVDETAIL";
            internal const string PARAM_OUT_PARAM_OUT_PHYSIOTHERAPYREQUESTNO = "ON_PHYSIOTHERAPYREQUESTNO";
            internal const string PARAM_OUT_OCURSOR_PHYSIOTHERAPYDETAILS = "OCURSOR_PHYSIOTHERAPYDETAILS";
            internal const string PARAM_OUT_OCURSOR_PHYSIOTHERAPYSTATUS = "OCURSOR_PHYSIOTHERAPYSTATUS";
            internal const string PARAM_IN_LOGINID = "IV_LOGINID";
            internal const string PARAM_IN_CLOB_IXMLSERVICEREQUEST = "ixmlservicerequest";
            internal const string PARAM_OUT_PARAM_OUT_BUFFERCHECK = "v_buffercheck";
            internal const string PARAM_OUT_OCURSOR_OCURSOR_PHYSIOTHERAPYSTATUS = "OCURSOR_PHYSIOTHERAPYSTATUS";
            internal const string PARAM_IN_CLOB_IXMLUPDATESERVICES = "IXMLUPDATESERVICES";



        }

        public class DG_SERVICEiTEMS
        {
            internal const string NAME = "billing.p_getserviceitemdetail";
            internal const string PARAM_OUT_OCURSOR_SERVICEITEMDETAILS = "o_serviceitemdetails";
            internal const string PARAM_OUT_OCURSOR_PEM = "o_pem";
            internal const string PARAM_OUT_OCURSOR_PATIENTCONSENT = "o_patientconsent";
            internal const string PARAM_OUT_OCURSOR_PREREQUISITE = "o_prerequisite";
            internal const string PARAM_OUT_OCURSOR_CODESYSTEM = "o_codesystem";
            internal const string PARAM_OUT_OCURSOR_RESOURCEROLE = "o_resourcerole";
            internal const string PARAM_OUT_OCURSOR_EQUIPMENT = "o_equipment";
            internal const string PARAM_OUT_OCURSOR_MATERIAL = "o_material";
            internal const string PARAM_OUT_OCURSOR_GENDERDETAILS = "o_genderdetails";
            internal const string PARAM_OUT_OCURSOR_SERVICEFACILITY = "o_servicefacility";
            internal const string PARAM_OUT_OCURSOR_ROMMDETAILS = "oc_rommdetails";
            internal const string PARAM_OUT_OCURSOR_SERVICEDELIVERY = "oc_servicedelivery";
            internal const string PARAM_OUT_SERVICEAPPLICABILITY = "oc_serviceapplicability";
            internal const string PARAM_OUT_SCHEDULABLE = "o_schedulable";
            internal const string PARAM_OUT_patientapplicability = "oc_patientapplicability";
            internal const string PARAM_OUT_serviceapplicability = "oc_serviceapplicability";
        }
        #endregion

        #region EQUIPMENT
        public class DG_EQUIPMENT
        {
            //GetFavourites
            internal const string PARAM_IN_FAVID = "in_FAVOURITEID";
            internal const string PARAM_IN_FAVNAME = "id_FAVOURITENAME";
            internal const string PARAM_IN_FAVTYPE = "id_FAVOURITETYPE";
            internal const string PARAM_IN_DOCTORNAME = "id_DOCTORNAME";
            internal const string PARAM_IN_LOCID = "iv_Locationid";
            internal const string PARAM_OUT_OCURSOR_FAVMASTER = "OREF_FAVMASTER";
            internal const string GETFAVSP = "wards.P_GETFAVOURITEMASTER";
            //GetFavourites

            internal const string EQPSP = "wards.P_GETEQUIPMENTREQUEST";
            internal const string PARAM_OUT_OREF_COMPLETEDRRCURSOR = "OREF_COMPLETEDRRCURSOR";
            internal const string PARAM_OUT_OREF_EQUIPMENTMASTERCURSOR = "OREF_EQUIPMENTMASTERCURSOR";
            internal const string PARAM_OUT_OREF_EQUIPMENTDETAILCURSOR = "OREF_EQUIPMENTDETAILCURSOR";

            internal const string RAISESPNAME = "wards.P_ADDEQUIPMENTREQUEST1";
            internal const string PARAM_IN_CLOB_EQUIPMENTSREQUEST = "ICLOB_EQUIPMENTSREQUEST";
            internal const string PARAM_OUT_EQUIPMENTREQUSETNO = "ON_EQUIPMENTREQUSETNO";
            //internal const string PARAM_OUT_OCURSOR_EQUIPMENTDETAILS = "OCURSOR_EQUIPMENTDETAILS";
            //internal const string PARAM_OUT_OCURSOR_EQUIPMENTSTATUS = "OCURSOR_EQUIPMENTSTATUS";

            internal const string CANCELSPNAME = "wards.P_UPDATEEQUIPMENTREQUEST";
            internal const string PARAM_IN_CLOB_EQUIPMENTREQUEST = "ICLOB_EQUIPMENTREQUEST";
            internal const string PARAM_OUT_OCURSOR_EQUIPMENTDETAILS = "OCURSOR_EQUIPMENTDETAILS";
            internal const string PARAM_OUT_OCURSOR_EQUIPMENTSTATUS = "OCURSOR_EQUIPMENTSTATUS";
        }
        #endregion

        #region OTHERS
        public class GetPatientDetailsOnIPNo
        {
            internal const string SPNAME = "adt.p_getpatientdetailsonipno";
            internal const string PARAM_ICLOB_IPNO = "iclob_ipno";
            internal const string PARAM_OCUR_PATIENTDETAILS = "ocur_patientdetails";
            internal const string PARAM_OCURSOR_TRANSFERHISTORY = "ocursor_transferhistory";
        }
        public class DG_OTHERS
        {
            //internal const string NAME = "p_getdeptmaster";
            internal const string DEPTNAME = "billing.p_GetDeptServices";
            internal const string PARAM_IN_DeptId = "IN_DEPTID";
            internal const string PARAM_IN_CompanyId = "IN_COMPANYID";
            internal const string PARAM_IN_LocationId = "IN_LOCATIONID";
            internal const string PARAM_IN_IPNumber = "IN_IPNUMBER";
            internal const string PARAM_IN_PatientConditionId = "IN_PATIENTCONDITIONID ";
            internal const string PARAM_IN_RoomId = "IN_RoomID";
            internal const string PARAM_IN_RoomName = "IN_ROOMNAME";
            internal const string PARAM_IN_RequestStatus = "IN_REQUESTSTATUS";
            internal const string PARAM_IN_RequestNumber = "IN_REQUESTNO";
            internal const string PARAM_IN_From = "IN_FROMDATE";
            internal const string PARAM_IN_To = "IN_TODATE";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_OtherServiceDetailId = "IN_OTHERSERVICEDETAILID";
            internal const string PARAM_IN_PatientType = "IN_PATIENTTYPE";
        }
        public class DG_RaiseOTHERSREQUEST
        {

            internal const string SPNAME = "WARDS.P_ADDOTHERSERVICESREQUEST";
            internal const string PARAM_ICLOB_OTHRTSERVICESREQUEST = "ICLOB_OTHRTSERVICESREQUEST";
            internal const string PARAM_ON_OTHERSERVICEREQUSETNO = "ON_OTHERSERVICEREQUSETNO";
            internal const string PARAM_OCURSOR_OTHERSERVICEDETAILS = "OCURSOR_OTHERSERVICEDETAILS";
            internal const string PARAM_OCURSOR_OTHERSERVICESTATUS = "OCURSOR_OTHERSERVICESTATUS";
        }
        public class DG_CancelOTHERSREQUEST
        {

            internal const string SPNAME = "WARDS.P_UPDATEOTHERSERVICEREQUEST";
            internal const string PARAM_ICLOB_OTHRTSERVICESREQUEST = "ICLOB_OTHERSERVICEREQUEST";
            internal const string PARAM_OCURSOR_OTHERSERVICEDETAILS = "OCURSOR_OTHERSERVICEDETAILS";
            internal const string PARAM_OCURSOR_OCURSOR_OTHERSERVICESTATUS = "OCURSOR_OTHERSERVICESTATUS";
        }
        public class UpdateOtherServiceReport
        {
            internal const string SPNAME = "WARDS.P_UPDATEOTHERSERVICEREPORT";
            internal const string PARAM_ICLOB_UPDATEOTHERSERVICEREPORT = "ICLOB_UPDATEOTHERSERVICEREPORT";
        }
        public class WorksheetView
        {
            internal const string SPNAME = "lab.P_GetWorksheetMaster";
            internal const string PARAM_IN_WORKSHEETID = "in_WorksheetID";
            internal const string PARAM_IN_TESTID = "in_TestID";
            internal const string PARAM_IN_METHODID = "in_MethodID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OREF_WORKSHEETCURSOR = "oref_WorksheetCursor";
        }
        public class GetConstantTemplate
        {
            internal const string SPNAME = "WARDS.P_GETCONSTANTTEMPLATE";
            internal const string PARAM_IV_TESTID = "IV_TESTID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OREF_SERVICETEMPLATE = "OREF_SERVICETEMPLATE";
        }
        public class GETSERVICEITEMTEPLATE
        {
            internal const string SPNAME = "WARDS.P_GETSERVICEITEMTEPLATE";
            internal const string PARAM_IV_TESTID = "IV_TESTID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_APPLICABLETO = "IV_APPLICABLETO";
            internal const string PARAM_OREF_SERVICEITEMTEPLATE = "OREF_SERVICEITEMTEPLATE";
        }
        public class GetPatientDetailsOnUHID
        {
            internal const string SPNAME = "REGISTRATION.P_GETPATIENTDETAILSONUHID";
            internal const string PARAM_ICLOB_UHID = "ICLOB_UHID";
            internal const string PARAM_OCUR_PATIENTDETAILS = "OCUR_PATIENTDETAILS";
        }
        #endregion

        #region CSSD
        public class DG_CSSD_Packtype
        {

            internal const string PacktypeNAME = "billing.P_GETSERVICES";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_PATIENTSERVICEID = "IN_PATIENTSERVICEID";
            internal const string PARAM_IN_DEPTID = "IV_DEPTID";
            internal const string PARAM_IN_CATEGORYID = "IN_CATEGORYID";
            internal const string PARAM_IN_SERVICETYPEID = "IN_SERVICETYPEID";
            internal const string PARAM_IN_SERVICENAME = "IV_SERVICENAME";
            internal const string PARAM_IN_BILLABLE = "IV_BILLABLE";
            internal const string PARAM_IN_SERVICESTATUS = "IV_SERVICESTATUS";
            internal const string PARAM_IN_RequestNumber = "IV_RESTORABLE";
            internal const string PARAM_IN_SERVICEID = "IN_SERVICEID";
            internal const string PARAM_IN_TAXABLE = "IV_TAXABLE";
            internal const string PARAM_IN_SCHEDULABLE = "IV_SCHEDULABLE";
            internal const string PARAM_IN_WILDSERVICEITEM = "IV_WILDSERVICEITEM";
            internal const string PARAM_IN_AGE = "IN_AGE";
            internal const string PARAM_IN_GENDERID = "IV_GENDERID";
            internal const string PARAM_IN_PATIENTCONDITIONID = "IV_PATIENTCONDITIONID";
            internal const string PARAM_OCURSOR_SERVICELIST = "OC_SERVICELIST";
        }
        public class DG_Getcssdrequestdetails
        {
            internal const string SPNAME = "WARDS.P_GETCSSDREQUESTDETAILS";
            internal const string CSSDREQUESTDETAILSNAME = "P_GETCSSDREQUESTDETAILS";
            internal const string PARAM_IN_CSSDRequestNo = "IN_CSSDREQUESTNO";
            internal const string PARAM_IN_DISTPATCHSTATUS = "IN_DISTPATCHSTATUS";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IN_PACKTYPE = "IV_PACKTYPE";
            internal const string PARAM_IN_FROMDATE = "ID_FROMDATE";
            internal const string PARAM_IN_ToDate = "ID_TODATE";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OCURSOR_CSSDREQUEST_DISTPATCH = "OCURSOR_CSSDREQUEST_DISTPATCH";
            internal const string PARAM_OCURSOR_CSSD_Raised_master = "OCursor_CSSD_Raised_master ";
            internal const string PARAM_OCURSOR_CSSD_Raised_Child = "OCursor_CSSD_Raised_Child";
        }
        public class DG_RaiseCSSDREQUEST
        {

            internal const string SPNAME = "WARDS.P_ADDCSSDREQUEST_DG";
            internal const string PARAM_ICLOB_CSSDREQUEST = "ICLOB_CSSDREQUEST";
            internal const string PARAM_ON_CSSDREQUESTNO = "ON_CSSDREQUESTNO";
            internal const string PARAM_OCURSOR_CSSDDETAILS = "OCURSOR_CSSDDETAILS";
            internal const string PARAM_OCURSOR_CSSDSTATUS = "OCURSOR_CSSDSTATUS";
        }
        public class DG_CancelCSSDREQUEST
        {

            internal const string SPNAME = "WARDS.P_UPDATECSSDWORKLIST";
            internal const string PARAM_ICLOB_CSSDREQUEST = "ICLOB_CSSDREQUEST";
            internal const string PARAM_OCURSOR_CSSDDETAILS = "OCURSOR_CSSDDETAILS";
            internal const string PARAM_OCURSOR_CSSDSTATUS = "OCURSOR_CSSDSTATUS";
        }

        public class DG_CancelviewCSSDRequest
        {
            internal const string SPNAME = "WARDS.P_CANCELCSSDREQUEST";
            internal const string PARAM_ICLOB_CSSDREQUEST = "ICLOB_CSSDREQUEST";
        }
        #endregion

        #region BillingCommon
        public class RaiseBillingServices
        {
            internal const string SPNAME = "billing.p_servicerequest";
            internal const string PARAM_Iclob_ixmlservicerequest = "ixmlservicerequest";
            internal const string PARAM_IN__loginid = "iv_loginid";
            internal const string PARAM_out_buffercheck = "v_buffercheck";
        }
        public class UpdateBillingService
        {
            internal const string SPNAME = "BILLING.P_UPDATESERVICEREQUEST";
            internal const string PARAM_Iclob_IXMLUPDATESERVICES = "IXMLUPDATESERVICES";
            internal const string PARAM_IN__loginid = "IV_LOGINID";

        }

        public class UpdateBillingStatus
        {
            internal const string SPNAME = "BILLING.p_updateservicestatus_dg";
            internal const string PARAM_Iclob_iXMLServiceRequest = "iXMLServiceRequest";
            internal const string PARAM_IN__loginid = "IV_LOGINID";

        }

        public class BillingGetServiceDetails
        {
            internal const string SPNAME = "BILLING.P_GetServices";
            internal const string PARAM_IN_locationid = "IV_LOCATIONID";
            internal const string PARAM_IN__PATIENTSERVICEID = "IN_PATIENTSERVICEID";
            internal const string PARAM_IN_DEPTID = "IV_DEPTID";
            internal const string PARAM_IN_CATEGORYID = "IN_CATEGORYID";
            internal const string PARAM_IN_SERVICETYPEID = "IN_SERVICETYPEID";
            internal const string PARAM_IN_SERVICENAME = "IV_SERVICENAME";
            internal const string PARAM_IN_BILLABLE = "IV_BILLABLE";
            internal const string PARAM_IN_SERVICESTATUS = "IV_SERVICESTATUS";
            internal const string PARAM_IN_RESTORABLE = "IV_RESTORABLE";
            internal const string PARAM_IN_SERVICEID = "IN_SERVICEID";
            internal const string PARAM_IN_TAXABLE = "IV_TAXABLE";
            internal const string PARAM_IN_SCHEDULABLE = "IV_SCHEDULABLE";
            internal const string PARAM_IN_WILDSERVICEITEM = "IV_WILDSERVICEITEM";
            internal const string PARAM_IN_AGE = "IN_AGE";
            internal const string PARAM_IN_GENDERID = "IV_GENDERID";
            internal const string PARAM_IN_PATIENTCONDITIONID = "IV_PATIENTCONDITIONID";
            internal const string PARAM_OUT_SERVICELIST = "OC_SERVICELIST";
        }
        public class BillingGetserviceitemdetail
        {

            internal const string ITEMSP = "billing.p_getserviceitemdetail";
            internal const string PARAM_IN_RequestStatus = "in_serviceid";
            internal const string PARAM_IN_LocationId = "iv_locationid";
            internal const string PARAM_OUT_OCURSOR_SERVICEITEMDETAILS = "o_serviceitemdetails";
            internal const string PARAM_OUT_OCURSOR_PEM = "o_pem";
            internal const string PARAM_OUT_OCURSOR_PATIENTCONSENT = "o_patientconsent";
            internal const string PARAM_OUT_OCURSOR_PREREQUISITES = "o_prerequisite";
            internal const string PARAM_OUT_OCURSOR_CODESYSTEM = "o_codesystem";
            internal const string PARAM_OUT_OCURSOR_RESOURCEROLE = "o_resourcerole";
            internal const string PARAM_OUT_OCURSOR_EQUIPMENT = "o_equipment";
            internal const string PARAM_OUT_OCURSOR_MATERIAL = "o_material";
            internal const string PARAM_OUT_OCURSOR_GENDERDETAILS = "o_genderdetails";
            internal const string PARAM_OUT_OCURSOR_SERVICEFACILITY = "o_servicefacility";
            internal const string PARAM_OUT_OCURSOR_ROMMDETAILS = "oc_rommdetails";
            internal const string PARAM_OUT_OCURSOR_SERVICEDELIVERY = "oc_servicedelivery";
            internal const string PARAM_OUT_OCURSOR_SERVICEAPPLICABILITY = "oc_serviceapplicability";
            internal const string PARAM_OUT_OCURSOR_O_SCHEDULABLE = "o_o_schedulable";
            internal const string PARAM_OUT_OCURSOR_PATIENTAPPLICABILITY = "oc_patientapplicability";
        }

        #endregion

        #region Nursing_PatientSearch
        public class DG_NURSINGPATIENTSEARCH
        {
            internal const string PATIENTSEARCH_AT_NAME = "adt.P_SearchPatientDetailsForAT";
            internal const string PATIENTSTATUS_NAME = "P_GetPatientStatusMaster";
            internal const string PARAM_IN_ResourceId = "IV_RESOURCEID";
            internal const string PARAM_IN_LocationId = "IV_location";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_PRN = "IV_PRN";
            internal const string PARAM_IN_ERN = "IV_ERN";
            internal const string PARAM_IN_DATEOFADMISSION = "ID_DATEOFADMISSION";
            internal const string PARAM_IN_WAITINGLISTNO = "IV_WAITINGLISTNO";
            internal const string PARAM_IN_BOOKNO = "IV_BOOKNO";
            internal const string PARAM_IN_INPATIENTNO = "IV_INPATIENTNO";
            internal const string PARAM_IN_FIRSTNAME = "IV_FIRSTNAME";
            internal const string PARAM_IN_MIDDLENAME = "IV_MIDDLENAME";
            internal const string PARAM_IN_LASTNAME = "IV_LASTNAME";
            internal const string PARAM_IN_FROMDATEOFBOOKING = "ID_FROMDATEOFBOOKING";
            internal const string PARAM_IN_TODATEOFBOOKING = "ID_TODATEOFBOOKING";
            internal const string PARAM_IN_PATIENTSTATUS = "IV_PATIENTSTATUS";
            internal const string PARAM_IN_LEVELDETAILID = "IN_LEVELDETAILID";
            internal const string PARAM_IN_FROMADMISSIONDATE = "IN_FROMADMISSIONDATE";
            internal const string PARAM_IN_TOADMISSIONDATE = "IN_TOADMISSIONDATE";
            internal const string PARAM_IN_ADMITTINGDR = "IN_ADMITTINGDR";
            internal const string PARAM_OUT_PATIENTSEARCHFROMAT = "OCURSOR_PATIENTDETAILS";
            internal const string PARAM_OUT_PATIENTSTATUSFROMAT = "oCursor_PatientStatus";
            internal const string PARAM_OUT_SERVICEITEM = "REFCURS_IP";

        }
        public class DG_OT_RADREQUEST
        {
            internal const string NAME = "digital.P_GETOTANDRADIOLOGYREQUEST_DG";
            internal const string PARAM_IN_ResourceId = "IV_RESOURCEID";
            internal const string PARAM_IN_LocationId = "IV_LOCATIONID";
            internal const string PARAM_OUT_REQUEST_DATA = "OCURSOR_REQUEST_DATA";
        }

        /// <summary>
        /// Nursing dashboard - Appointments - view requests
        /// </summary>
        public class DG_VIEWREQUESTS
        {
            internal const string RADIOLOGYNAME = "PKG_RADIOLOGYREQUEST.P_GETRADREQUESTDTLS";
            internal const string OTNAME = "PKG_INTERMODULE_REFERENCES.P_GET_IPNUMBER_DATA";
            internal const string PARAM_IN_IPNumber = "IN_IPNUMBER";
            internal const string PARAM_IN_Proc_Req_HDR_Id = "IN_PROC_REQ_HDR_ID";
            internal const string PARAM_IN_LocationId = "IN_LOCATIONID ";
            internal const string PARAM_IN_PatientNo = "IN_PATIENTNO";
            internal const string PARAM_IN_ReqNo = "IN_REQUESTNO";
            internal const string PARAM_IN_ReqId = "IN_REQUESTID";
            internal const string PARAM_IN_ReqDetailId = "IN_REQUESTDTLID";
            internal const string PARAM_IN_UHId = "IN_UHID";
            internal const string PARAM_OUT_DG_VIEWREQUESTS = "DG_VIEWREQUESTS";
            internal const string PARAM_OUT_OCURSOR_SURG_DATA = "OCURSOR_SURG_DATA";
            internal const string PARAM_OUT_OCURSOR_SURGEONS_DATA = "OCURSOR_SURGEONS_DATA";
            internal const string PARAM_OUT_OCURSOR_ANAE_DATA = "OCURSOR_ANAE_DATA";
            internal const string PARAM_OUT_OCURSOR_RADREQUESTDTLS = "OCURSOR_RADREQUESTDTLS";
            //PreRequisistes
            internal const string PARAM_IN_ServiceId = "IN_SERVICEID";
            internal const string PARAM_OUT__PREREQUISITES = "OCURSOR_PREREQUISITES";
            internal const string PREREQUSITESNAME = "PKG_PREREQPREPCONS.P_GETPREREQUISITES";
            //PreRequisistes
        }
        #endregion
        #region Admin

        public class GETNURSEANDWARDNAME
        {
            internal const string SPNAME = "WARDS.P_GETNURSES_DG";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_NURSEID = "IV_NURSEID";
            internal const string PARAM_IN_NURSENAME = "IV_NURSENAME";
            internal const string PARAM_IN_WARDNAME = "IV_WARDNAME";
            internal const string PARAM_IN_ISACTIVEPAYROLL = "IV_ISACTIVEPAYROLL";
            internal const string PARAM_OUT_NUSENAME = "OCURSOR_NURSES";
            internal const string PARAM_OUT_WARDNAME = "OCURSOR_WARDS";
        }
        public class GETMAPWARD
        {
            internal const string SPNAME = "WARDS.P_GETMMAPWARD_DG";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_NURSEID = "IV_NURSEID";
            internal const string PARAM_OUT_MAPWARD = "OCURSOR_MAPNURSE";
        }
        public class GETALLOCATIONDETAILS
        {
            internal const string SPNAME = "WARDS.P_GETNURSEWARDALLOCATION_DG";
            internal const string PARAM_IN_WARDIDNAME = "IN_WARDID";
            internal const string PARAM_IN_FROMWARDIDNAME = "IN_FROMWARDID";
            internal const string PARAM_IN_NURSEIDNAME = "IN_NURSEID";
            internal const string PARAM_IN_FROMDATE = "IN_FROMDATE";
            internal const string PARAM_IN_TODATE = "IN_TODATE";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_ALLOCATIONTYPE = "IN_ALLOCATIONTYPE";
            internal const string PARAM_OUT_ALLOCATIONDETAILS = "OCURSOR_DETAILS";
        }
        public class SAVEUPDATEDELETEALLOCATION
        {
            internal const string SPNAME = "WARDS.P_NURSEWARDALLOCATION_DG";
            internal const string PARAM_IN_TYPEID = "IN_TYPEID";
            internal const string PARAM_IN_NURSEID = "IN_NURSEID";
            internal const string PARAM_IN_FROMWARDID = "IN_FROMWARDID";
            internal const string PARAM_IN_TOWARDID = "IN_TOWARDID";
            internal const string PARAM_IN_FROMDATE = "IN_FROMDATE";
            internal const string PARAM_IN_TODATE = "IN_TODATE";
            internal const string PARAM_IN_STATUS = "IN_STATUS";
            internal const string PARAM_IN_ALLOCATIONTYPE = "IN_ALLOCATIONTYPE";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_CREATEDBY = "IN_CREATEDBY";
            internal const string PARAM_IN_CREATEDDATE = "IN_CREATEDDATE";
            internal const string PARAM_IN_UPDATEDBY = "IN_UPDATEDBY";
            internal const string PARAM_IN_UPDATEDATE = "IN_UPDATEDATE";
            internal const string PARAM_IN_ALLOCATIONID = "IN_ALLOCATIONID";
            internal const string PARAM_IN_DURATIONTYPE = "IN_DURATIONTYPE";
            internal const string PARAM_IN_OUTSTATUS = "OUTSTATUS";
        }
        public class DISPLAYUNALLOCATEDNURSES
        {
            internal const string SPNAME = "wards.p_getunallocatednurses_dg";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_UNALLOCATEDNURSES = "ocursor_unallocatednurses";
        }
        public class GETNURSEHISTORY
        {
            internal const string SPNAME = "P_NURSEHISTORY_DG";
            internal const string PARAM_IN_NURSEID = "IN_NURSEID";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_NURSEHISTORY = "OCURSOR_HISTORY";
        }
        #endregion

        //Handover
        public class P_INSERTHANDOVERDETAILS_DG
        {
            internal const string SPNAME = "DIGITAL.P_INSERTHANDOVERDETAILS_DG";
            internal const string PARAM_IN_IPNUMBER = "IPNUMBER";
            internal const string PARAM_IN_UHID = "UHID";
            internal const string PARAM_IN_LOCATIONID = "LOCATIONID";
            internal const string PARAM_IN_STATUS = "STATUS";
            internal const string PARAM_IN_TRANSACTIONSTATUS = "TRANSACTIONSTATUS";
            internal const string PARAM_IN_FROMNURSEID = "FROMNURSEID";
            internal const string PARAM_IN_TONURSEID = "TONURSEID";
            internal const string PARAM_IN_FROMWARDID = "FROMWARDID";
            internal const string PARAM_IN_TOWARDID = "TOWARDID";
            internal const string PARAM_IN_BEDNO = "BEDNO";
            internal const string PARAM_IN_HANDOVERNOTES = "HANDOVERNOTES";
            internal const string PARAM_IN_CRITICALNOTES = "CRITICALNOTES";
            internal const string PARAM_IN_CREATEDBY = "CREATEDBY";
            internal const string PARAM_IN_UPDATEDBY = "UPDATEDBY";
            internal const string PARAM_IN_IsDraft = "Issaveasdraft";
            internal const string PARAM_IN_IsFlag = "Flag";

        }

        public class P_GETHANDOVERDETAILS_DG
        {
            internal const string NAME = "DIGITAL.P_GETHANDOVERDETAILS_DG";
            internal const string PARAM_IN_RESOURCEID = "RESOURCEID";
            internal const string PARAM_IN_LOCATIONID = "LOCATIONID";
            internal const string PARAM_OUT_RefCursor = "OUTPUT";
        }

        public class P_GETPATIENTHANDOVERDETAILS_DG
        {
            internal const string NAME = "DIGITAL.P_GETPATIENTHANDOVERDETAILS_DG";
            internal const string PARAM_IN_RESOURCEID = "RESOURCEID";
            internal const string PARAM_IN_LOCATIONID = "LOCATIONID";
            internal const string PARAM_IN_UHID = "UHID";
            internal const string PARAM_IN_IPNUMBER = "IPNUMBER";
            internal const string PARAM_OUT_RefCursor = "OUTPUT";
        }

        public class P_GETNURSEHANDOVERREQUESTS_DG
        {
            internal const string NAME = "digital.p_getnursehandoverrequests_dg";
            internal const string PARAM_IN_RESOURCEID = "IN_RESOURCEID";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OCURSOR_OUTREQUESTS = "OCURSOR_OUTREQUESTS";
            internal const string PARAM_OCURSOR_INREQUESTS = "OCURSOR_INREQUESTS";
            internal const string PARAM_OCURSOR_ACCEPTREQUESTS = "OCURSOR_ACCEPTREQUESTS";
        }


        public class p_updatehandovertrans_dg
        {
            internal const string NAME = "p_updatehandovertrans_dg";
            internal const string PARAM_IN_IPNUMBER = "IN_IPNUMBER";
            internal const string PARAM_IN_STATUS = "IN_STATUS";
            internal const string PARAM_IN_RESOURCEID = "IN_RESOURCEID";
            internal const string PARAM_IN_HANDOVERNOTES = "IN_HANDOVERNOTES";
            internal const string PARAM_IN_CRITICALNOTES = "IN_CRITICALNOTES";
            internal const string PARAM_IN_SEQUENCEID = "IN_SEQUENCEID";
        }
        //Get handovernotes section
        public class P_GetHandoverNotesSection_DG
        {
            internal const string NAME = "digital.P_GetHandoverNotesSection_DG";
            //internal const string PARAM_IN_UHID = "UHID";
            //internal const string PARAM_IN_IPNO = "IPNUMBER";
            //internal const string PARAM_IN_LOCATIONID = "LOCATIONID";
            //internal const string PARAM_IN_FROMDATE = "FROMDATE";
            //internal const string PARAM_IN_TODATE = "TODATE";
            internal const string PARAM_OUT_RefCursor = "OUTPUT";
        }

        public class P_GETCHECKOUT
        {
            internal const string NAME = "WARDS.P_getcheckedoutpatients";
            internal const string PARAM_iv_UHID = "iv_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_TODATE = "IV_TODATE";
            internal const string PARAM_IV_FROMDATE = "IV_FROMDATE";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_FLAG = "IN_FLAG";
            internal const string PARAM_out_checkoutpatients = "OCURSOR_CHECKEDOUTPATIENTS";
        }
        public class DG_GETPATIENTDETAILSWITHREGISTRATIONNUMBER
        {
            internal const string NAME = "REGISTRATION.p_getpatientdetailswithregno";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_REGISTRATIONNUMBER = "IN_REGISTRATIONNUMBER";
            internal const string PARAM_IN_LOCATIONID = "iv_locationid";
            internal const string PARAM_OUT_COMPONENT1 = "OCURSOR_COMPONENT1";
            internal const string PARAM_OUT_COMPONENT3 = "OCURSOR_COMPONENT3";
            internal const string PARAM_OUT_COMPONENT4 = "OCURSOR_COMPONENT4";
            internal const string PARAM_OUT_COMPONENT5 = "OCURSOR_COMPONENT5";
            internal const string PARAM_OUT_COMPONENT6 = "OCURSOR_COMPONENT6";
            internal const string PARAM_OUT_COMPONENT7 = "OCURSOR_COMPONENT7";
            internal const string PARAM_OUT_COMPONENT8 = "OCURSOR_COMPONENT8";
            internal const string PARAM_OUT_COMPONENT9 = "OCURSOR_COMPONENT9";
            internal const string PARAM_OUT_COMPONENT10 = "OCURSOR_COMPONENT10";
            internal const string PARAM_OUT_COMPONENT11 = "OCURSOR_COMPONENT11";
            internal const string PARAM_OUT_COMPONENT12 = "OCURSOR_COMPONENT12";
            internal const string PARAM_OUT_COMPONENT13 = "OCURSOR_COMPONENT13";
            internal const string PARAM_OUT_COMPONENT14 = "OCURSOR_COMPONENT14";
            internal const string PARAM_OUT_COMPONENT15 = "OCURSOR_COMPONENT15";
            internal const string PARAM_IN_MasterFlag = "in_MasterFlag";

        }


        #region Diabetic monitoring chart
        public class NursingDA_DiabeticChart
        {
            internal const string GETROUTEOFADMIN_NAME = "wards.P_GETROUTEOFADMIN";
            internal const string PARAM_IN_ROUTEOFADMINID = "iv_RouteOfAdminID";
            internal const string PARAM_OUT_LISTOFROUTEOFADMIN = "OCursor_LISTOFROUTEOFADMIN";
            internal const string PARAM_OUT_TYPEOFROUTEOFADMIN = "OCursor_TYPEOFROUTEOFADMIN";

            internal const string GETDIABETICCHART_NAME = "wards.P_GET_OTHERASSESSMENT_DAILY_DG";
            internal const string PARAM_IN_OTHERASSESSMENTID = "IN_OTHERASSESSMENTID";
            internal const string PARAM_IN_ADMISSIONNO = "IN_ADMISSIONNO";
            internal const string PARAM_IN_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_DATEFROM = "DATEFROM";
            internal const string PARAM_IN_DATETO = "DATETO";
            internal const string PARAM_OUT_OTHERASSESSMENTS = "OCURSOR_OTHERASSESSMENTS";

            internal const string GETBLOODSUGARTYPE_NAME = "wards.P_GETLOVDETAILS";
            internal const string PARAM_IN_LOVCODE = "V_LOVCODE";
            internal const string PARAM_OUT_LOVDETAIL = "OCURSOR_LOVDETAIL";
        }

        //-----------------Prathibha added class --start-------------
        public class GETDAGENERALOBSERVATIONS
        {
            internal const string SPNAME = "DIGITAL.P_GETDAGENERALOBSERVATIONS_DG";
            internal const string PARAM_IN_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_FROMDATE = "IV_FROMDATE";
            internal const string PARAM_IN_TODATE = "IV_TODATE";
            internal const string PARAM_OUT_GETDAGENERALOBSERVATIONS = "refcur_generalobservations";
        }
        public class GETDAGENERALOBSERVATIONSRPT
        {
            internal const string SPNAME = "DIGITAL.P_GNRLOBSRVTNSRPTHEADER_DG";
            internal const string PARAM_IN_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IN_QFCODE = "IV_QFCODE";

            internal const string PARAM_OUT_GETDAGENERALOBSERVATIONS = "OCURSOR_RPTHEADER";
            internal const string PARAM_OUT_QFCODE = "OCURSOR_QFCODE";
        }
        public class SAVEDAGENERALOBSERVATIONS
        {
            internal const string NAME = "DIGITAL.P_SAVEDAGENERALOBSERVATIONS_DG";
            internal const string PARAM_IV_DAGONUMBER = "IV_DAGONUMBER";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_DIET = "IV_DIET";
            internal const string PARAM_IV_POSTOPDAYS = "IV_POSTOPDAYS";
            internal const string PARAM_IV_VOIDEDURINE = "IV_VOIDEDURINE";
            internal const string PARAM_IV_PASSEDSTOOLS = "IV_PASSEDSTOOLS";
            internal const string PARAM_IV_ANTIBIOTICS = "IV_ANTIBIOTICS";
            internal const string PARAM_IV_UPDATEDBY = "IV_UPDATEDBY";
            internal const string PARAM_IV_DAYSOFHOSPITALIZATION = "IV_DOH";
            internal const string PARAM_IV_UHID = "IV_UHID";


        }
        //-----------------Prathibha added class --end-------------

        #endregion
        #region NursingNotes
        public class NursingNotes
        {
            internal const string GET_SPNAME = "digital.P_GetNursingNotes_dg";
            internal const string SAVE_SPNAME = "wards.P_ADDPatientObservations_DG";
            internal const string PARAM_IN_OBSERVATIONNO = "IN_OBSERVATIONID";
            internal const string PARAM_IN_ADMISSIONNO = "IN_ADMISSIONNO";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_IPNUMBER = "IN_IPNUMBER";
            internal const string PARAM_IN_CREATEDBY = "IN_CREATEDBY";
            internal const string PARAM_IN_STATUS = "IN_STATUS";
            internal const string PARAM_IN_UPDATEDBY = "IN_UPDATEDBY";
            internal const string PARAM_IN_GOAL = "IN_GOAL";
            internal const string PARAM_IN_ACTIONPLAN = "IN_ACTIONPLAN";
            internal const string PARAM_IN_INTERVENTION = "IN_INTERVENTION";
            internal const string PARAM_IN_OUTCOME = "IN_OUTCOME";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_REMARKS = "IN_REMARKS";
            internal const string PARAM_IN_OBSERVEDBY = "IN_OBSERVEDBY";
            internal const string PARAM_OUT_OCURSOR_NOTES = "out_details";
        }
        #endregion


        public class DG_GETPAINSCALE
        {
            internal const string NAME = "DIGITAL.P_GETPAINSCORE_DG";
            internal const string PARAM_OUT_GETPAINSCALETYPES = "REFCUR_PAINSCALETYPES";
        }
        public class DG_DRUGRECEIVE
        {
            internal const string NAME = "PHARMACY.P_GetIssueCodeDetails";
            internal const string PARAM_IN_ISSUECODE = "iv_IssueCode";
            internal const string PARAM_IN_StoreCode = "iv_StoreCode";
            internal const string PARAM_IN_UserID = "iv_UserID";
        }
        public class DG_GetPatientOccupiedBeds
        {
            internal const string NAME = "ADT.P_GetPatientOccupiedBeds";
            internal const string PARAM_IN_IPNo = "IV_InpatientNo";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";

        }
        public class DG_AddReceiveItemDetails
        {
            internal const string NAME = "PHARMACY.P_AddReceiveItems";
            internal const string PARAM_iCLOB_ReceiveItemsDetails = "iCLOB_ReceiveItemsDetails";

        }
        public class DG_ReceiveBatchSerialItems
        {
            internal const string NAME = "PHARMACY.P_ReceiveBatchSerialItems";
            internal const string PARAM_IN_ISSUECODE = "iv_IssueCode";
            internal const string PARAM_IN_StoreCode = "iv_Storecode";
            internal const string PARAM_IN_ItemCode = "iv_ItemCode";
            internal const string PARAM_IN_StockTransactionDetailsId = "iv_StockTransactionDetailsId";
        }
        // get drug return procs added by nagesh
        public class DG_GETDRUGRETURNBATCHDETAILS
        {
            internal const string SPNAME = "pharmacy.PKG_CONSUMPTIONDECLARATION_P_GETGOISUECODEDETAILSFOR";
            internal const string PARAM_IN_STORECODE = "iv_fromstorecode";
            internal const string PARAM_IN_ISSUECODE = "iv_issuecode";
            internal const string PARAM_IN_LOCATIONID = "iv_locationid";
            internal const string PARAM_IN_REGIONID = "iv_regionid";
            internal const string PARAM_OUT_DRUGRETURN = "ocursor_outgocursordet";
        }

        public class DG_GETBATCHSERIALDETAILS
        {
            internal const string SPNAME = "pharmacy.PKG_CONSUMPTIONDECLARATION_P_GETBATCHSERIALDETAILSFORDECL";
            internal const string PARAM_IN_STORECODE = "iv_fromstorecode";
            internal const string PARAM_IN_ISSUECODE = "iv_issuecode";
            internal const string PARAM_IN_LOCATIONID = "iv_locationid";
            internal const string PARAM_IN_REGIONID = "iv_regionid";
            internal const string PARAM_OUT_DRUGRETURNOUTBATCHSERDET = "ocursor_outbatchserdet";
        }
        public class DG_GETISSUEDETAILSAGAINSTIP
        {

            internal const string SPNAME = "pharmacy.PKG_CONSUMPTIONDECLARATION_P_PKGGETISSUESAGAINSTIPNEW";
            internal const string PARAM_IN_IPNO = "v_ipno";
            internal const string PARAM_IN_FLAG = "v_flag";

            internal const string PARAM_OUT_OCURSOR_HEADERDETAILS = "ocursor_headerdetails";
            internal const string PARAM_OUT_OCURSOR_ISSITEMDETAILS = "ocursor_issitemdetails";
        }
        public class DG_GETDRUGRETURNISSUECODEDETAILS
        {

            internal const string SPNAME = "pharmacy.PKG_CONSUMPTIONDECLARATION_P_GETPKGSISSUEDETAILCONS";
            internal const string PARAM_IN_STORECODE = "IV_STORECODE";
            internal const string PARAM_IN_ISSUECODE = "IV_ISSUECODE";
            internal const string PARAM_IN_LOCATIONID = "L_LOCATIONID";
            internal const string PARAM_IN_REGIONID = "L_REGIONID";
            internal const string PARAM_OUT_OCURSOR_GETPKGISSUEDETAILS = "OCURSOR_GETPKGISSUEDETAILS";
            internal const string PARAM_OUT_OCURSOR_GETPKGPATIENTISSUEDET = "OCURSOR_GETPKGPATIENTISSUEDET";
            internal const string PARAM_OUT_OCURSOR_GETPKGREUSABLEITEMS = "OCURSOR_GETPKGREUSABLEITEMS";
            internal const string PARAM_IN_ITEMCODE = "IV_ITEMCODE";
        }

        public class DG_GETADDCONSUMPTIONDECDETAILS
        {

            internal const string SPNAME = "pharmacy.PKG_CONSUMPTIONDECLARATION_P_ADDCONSDECLARATIONHEADER";
            internal const string PARAM_IN_INDENTCODE = "V_INDENTCODE";
            internal const string PARAM_IN_ISSUECODE = "V_ISSUECODE";
            internal const string PARAM_IN_USERID = "V_USERID";
            internal const string PARAM_IN_DEPTID = "V_DEPTID";
            internal const string PARAM_IN_STORECODE = "V_STORECODE";
            internal const string PARAM_IN_FROMSTORECODE = "V_FROMSTORECODE";
            internal const string PARAM_IN_PATIENTUHID = "V_PATIENTUHID";
            internal const string PARAM_IN_SPECIALREMARKS = "V_SPECIALREMARKS";
            internal const string PARAM_IN_REASONCODEID = "V_REASONCODEID";
            internal const string PARAM_IN_LOCATIONID = "V_LOCATIONID";
            internal const string PARAM_IN_REGIONID = "V_REGIONID";
            internal const string PARAM_IN_CHECKRETURN = "V_CHECKRETURN";
            internal const string PARAM_IN_TRANSACTIONCODE = "V_TRANSACTIONCODE";
            internal const string PARAM_OUT_CONSDECLARATION = "V_CONSDECLARATION";
        }

        public class DG_GEPADDCONSDECLITEMDETAILS
        {

            internal const string SPNAME = "pharmacy.PKG_CONSUMPTIONDECLARATION_P_ADDCONSDECLITEMDETAILS";
            internal const string PARAM_IN_RETURNCODE = "V_RETURNCODE ";
            internal const string PARAM_IN_QTY = "V_QTY";
            internal const string PARAM_IN_ITEMCODE = "V_ITEMCODE";
            internal const string PARAM_IN_REMARKS = "V_REMARKS";
            internal const string PARAM_IN_ITEMVALUE = "V_ITEMVALUE";
            internal const string PARAM_IN_VDECL_DECLARATIONCODE = "VDECL_DECLARATIONCODE";
            internal const string PARAM_IN_VDECL_QTY = "VDECL_QTY";
            internal const string PARAM_IN_VDCL_ITEMCODE = "VDECL_ITEMCODE";
            internal const string PARAM_IN_VDECL_REMARKS = "VDECL_REMARKS";
            internal const string PARAM_IN_VDECL_ITEMVALUE = "VDECL_ITEMVALUE";

        }

        public class DG_GEPADDCONSDECLBATCHDETAILS
        {
            internal const string SPNAME = "pharmacy.PKG_CONSUMPTIONDECLARATION_P_ADDCONSDECLBATCHDETAILS";
            internal const string PARAM_IN_RETURNCODE = "V_RETURNCODE ";
            internal const string PARAM_IN_BATCHSERIALCODE = "V_BATCHSERIALCODE";
            internal const string PARAM_IN_ITEMCODE = "V_ITEMCODE";
            internal const string PARAM_IN_STORECODE = "V_STORECODE";
            internal const string PARAM_IN_ISBATCH = "V_ISBATCH";
            internal const string PARAM_IN_QTY = "V_QTY";
            internal const string PARAM_IN_MFGDATE = "V_MFGDATE";
            internal const string PARAM_IN_EXPIRYDATE = "V_EXPIRYDATE";
            internal const string PARAM_IN_RECEIPTDATE = "V_RECEIPTDATE";
            internal const string PARAM_IN_BATCHVALUE = "V_BATCHVALUE";
            internal const string PARAM_IN_UNITCOST = "V_UNITCOST";
            internal const string PARAM_IN_MRP = "V_MRP";
            internal const string PARAM_IN_CONSUMEDQTY = "V_CONSUMEDQTY";

            internal const string PARAM_IN_VDECL_DECLARATIONCODE = "VDECL_DECLARATIONCODE ";
            internal const string PARAM_IN_VDECL_BATCHSERIALCODE = "VDECL_BATCHSERIALCODE";
            internal const string PARAM_IN_VDECL_ITEMCODE = "VDECL_ITEMCODE";
            internal const string PARAM_IN_VDECL_STORECODE = "VDECL_STORECODE";
            internal const string PARAM_IN_VDECL_QTY = "VDECL_QTY";
            internal const string PARAM_IN_VDECL_MFGDATE = "VDECL_MFGDATE";
            internal const string PARAM_IN_VDECL_EXPIRYDATE = "VDECL_EXPIRYDATE";
            internal const string PARAM_IN_VDECL_RECEIPTDATE = "VDECL_RECEIPTDATE";
            internal const string PARAM_IN_VDECL_ISBATCH = "VDECL_ISBATCH";
            internal const string PARAM_IN_VDECL_BATCHVALUE = "VDECL_BATCHVALUE";
            internal const string PARAM_IN_VDECL_UNITCOST = "VDECL_UNITCOST";
            internal const string PARAM_IN_VDECL_MRP = "VDECL_MRP";
            internal const string PARAM_IN_VDECL_CONSUMEDQTY = "VDECL_CONSUMEDQTY";

        }

        public class DG_GEPrescriptionRequestSave
        {
            internal const string SPNAME = "WARDS.P_UPDATERETUNDRUGS";

            internal const string PARAM_IN_ICLOB_DRUGDETAILS = "ICLOB_DRUGDETAILS";

        }

        public class DG_BatchDetailsForReturn
        {

            internal const string SPNAME = "PHARMACY.P_GETBATCHDETAILSFORRETURN";
            internal const string PARAM_IN_ISSUCODERETURN = "IV_ISSUECODE";
            internal const string PARAM_IN_ITEMCODERETURN = "IV_ITEMCODE";

            internal const string OCURSOR_OUT_OUTBATCHSERDET = "OCURSOR_OUTBATCHSERDET";

        }

        // get drug return procs added by nagesh ends
        #region HR

        public class HR_SUBDEPARTMENTS
        {
            internal const string SPNAME = "SECURITYTEST_64.P_GETSUBDEPARTMENTS";
            internal const string PARAM_IV_SUBDEPTID = "iv_subdeptid";
            internal const string PARAM_IV_DEPTID = "iv_deptid";
            internal const string PARAM_IV_LOCATIONID = "iv_locationid";
            internal const string PARAM_OUT_OCURSOR_DEPARTMENT = "ocursor_Department";
        }

        #endregion


        public class UpdatePhysiotherapyReport
        {
            internal const string SPNAME = "WARDS.P_AddPhysiotherapyObservations";
            internal const string PARAM_ICLOB_UPDATEPHYSIOTHERAPYREPORT = "ICLOB_PhysiotherapyDetails";

        }
        public class DG_GETREPORTDETAILS
        {
            internal const string SPNAME = "WARDS.P_GETPhysiotherapyObservations";
            internal const string PARAM_IN_PHYSIOREQUESTID = "iv_PhysiorequestID";
            internal const string PARAM_IN_LOCATIONID = "iv_LocationId";
            internal const string PARAM_OUT_OCURSOR_REPORTRESULTS = "OCursor_PhysioObservations";

        }
        public class DG_GETDAILYPHYSIODETAILS
        {
            internal const string SPNAME = "WARDS.P_GETDAILYREPORTPHYSIOTHERAPY";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNO = "IV_IPNO";
            internal const string PARAM_IV_FROMDATE = "IV_FROMDATE";
            internal const string PARAM_IV_TODATE = "IV_TODATE";
            internal const string PARAM_IV_REQSTATUS = "IV_REQSTATUS";
            internal const string PARAM_IN_LOCATION = "IN_LOCATION";
            internal const string PARAM_OUT_CUR_RPT = "CUR_RPT";

        }
        public class DG_GETSERVICENAMES
        {
            internal const string SPNAME = "BILLING.P_GETSERVICENAMES";
            internal const string PARAM_IN_iCLOB_serviceid = "iCLOB_serviceid";
            internal const string PARAM_IN_locationid = "in_locationid";
            internal const string PARAM_OUT_ocur_servicenames = "ocur_servicenames";
        }
        public class DG_getpatientdetailsonipno
        {
            internal const string SPNAME = "ADT.p_getpatientdetailsonipno";
            internal const string PARAM_IN_iclob_ipno = "iclob_ipno";
            internal const string PARAM_OUT_ocur_patientdetails = "ocur_patientdetails";
            internal const string PARAM_OUT_ocursor_transferhistory = "ocursor_transferhistory";
        }
        public class DG_GETEMPLOYEEMAINDETAILS
        {
            internal const string SPNAME = "HR.P_GETEMPLOYEEMAINDETAILS";
            internal const string PARAM_IN_EMPLOYEE_ID = "IN_EMPLOYEE_ID";
            internal const string PARAM_IV_FIRSTNAME = "IV_FIRSTNAME";
            internal const string PARAM_ID_DOB = "ID_DOB";
            internal const string PARAM_IN_LOCATION_ID = "IN_LOCATION_ID";
            internal const string PARAM_IN_DEPARTMENT_ID = "IN_DEPARTMENT_ID";
            internal const string PARAM_IN_COSTCENTER_ID = "IN_COSTCENTER_ID";
            internal const string PARAM_IN_LEVELID = "IN_LEVELID";
            internal const string PARAM_IN_CATEGORYID = "IN_CATEGORYID";
            internal const string PARAM_IN_TYPEID = "IN_TYPEID";
            internal const string PARAM_IN_EMPLOYMENTSTATUSID = "IN_EMPLOYMENTSTATUSID";
            internal const string PARAM_IN_DESIGNATIONID = "IN_DESIGNATIONID";
            internal const string PARAM_IN_GRADEID = "IN_GRADEID";
            internal const string PARAM_IN_SPECIALITYID = "IN_SPECIALITYID";
            internal const string PARAM_IN_SCHEDULABLE = "IN_SCHEDULABLE";
            internal const string PARAM_IN_CALENDARPRIV = "IN_CALENDARPRIV";
            internal const string PARAM_IN_PRESENTEMPID = "IN_PRESENTEMPID";
            internal const string PARAM_IN_LOGINID = "IN_LOGINID";
            internal const string PARAM_IN_SUPERVISORID = "IN_SUPERVISORID";
            internal const string PARAM_IN_SPZSERVICES = "IN_SPZSERVICES";
            internal const string PARAM_IN_POSITIONID = "IN_POSITIONID";
            internal const string PARAM_OUT_OCURSOR_EMPMAINDTAILS = "OCURSOR_EMPMAINDTAILS";
        }
        public class DG_GETPATIENTDETAILSWITHREGNUMBER
        {
            internal const string SPNAME = "REGISTRATION.P_GETPATIENTDETAILSWITHREGNO";
            internal const string PARAM_IN_REGISTRATIONNUMBER = "IN_REGISTRATIONNUMBER";
            internal const string PARAM_in_LocationID = "in_LocationID";
            internal const string PARAM_OUT_ocursor_Component1 = "ocursor_Component1";
            internal const string PARAM_OUT_ocursor_Component3 = "ocursor_Component3";
            internal const string PARAM_OUT_ocursor_Component4 = "ocursor_Component4";
            internal const string PARAM_OUT_ocursor_Component5 = "ocursor_Component5";
            internal const string PARAM_OUT_ocursor_Component6 = "ocursor_Component6";
            internal const string PARAM_OUT_ocursor_Component7 = "ocursor_Component7";
            internal const string PARAM_OUT_ocursor_Component8 = "ocursor_Component8";
            internal const string PARAM_OUT_ocursor_Component9 = "ocursor_Component9";
            internal const string PARAM_OUT_ocursor_Component10 = "ocursor_Component10";
            internal const string PARAM_OUT_ocursor_Component11 = "ocursor_Component11";
            internal const string PARAM_OUT_ocursor_Component12 = "ocursor_Component12";
            internal const string PARAM_OUT_ocursor_Component13 = "ocursor_Component13";
            internal const string PARAM_OUT_ocursor_Component14 = "ocursor_Component14";
            internal const string PARAM_OUT_ocursor_Component15 = "ocursor_Component15";
            internal const string PARAM_in_MasterFlag = "in_MasterFlag";
        }

        public class GETEMPLOYEEROLES
        {
            internal const string SPNAME = "HR.P_GETEMPLOYEEONROLENAME";
            internal const string PARAM_In_Location_ID = "In_Location_ID";
            internal const string PARAM_IN_ROLENAME = "IN_ROLENAME";
            internal const string PARAM_Ocursor_EmpMainDtails = "Ocursor_EmpMainDtails";

        }
        public class GETSTATUSDETAILS
        {
            internal const string SPNAME = "WARDS.P_GETSTATUSDETAILS";
            internal const string PARAM_IV_TABLENAME = "IV_TABLENAME";
            internal const string PARAM_IV_COLUMNNAME = "IV_COLUMNNAME";
            internal const string PARAM_IN_LOCATION = "IN_LOCATION";
            internal const string PARAM_CUR_LIST = "CUR_LIST";

        }
        //Nurse Initial Assessment Basic Info
        public class DG_SAVEIADATA
        {
            internal const string SPNAME = "DIGITAL.P_SAVEIADATA_DG";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_NURSEID = "IV_NURSEID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_CREATEDBY = "IV_CREATEDBY";
            internal const string PARAM_IV_UPDATEDBY = "IV_UPDATEDBY";
            internal const string PARAM_IV_ISSAVE = "IV_ISSAVE";
            internal const string PARAM_IV_ISSAVELOCK = "IV_ISSAVELOCK";
            internal const string PARAM_IV_SPECIALITYID = "IV_SPECIALITYID";

        }
        //Nurse Initial Assessment Basic Info
        public class DG_SAVEBASICINFO
        {
            internal const string SPNAME = "DIGITAL.P_SAVEIABASICINFO_DG";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_DOCTORID = "IV_DOCTORID";
            internal const string PARAM_IV_NURSEID = "IV_NURSEID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_WAYOFADMISSION = "IV_WAYOFADMISSION";
            internal const string PARAM_IV_ATTENDANTPRESENT = "IV_ATTENDANTPRESENT";
            internal const string PARAM_IV_ATTENDANTDESC = "IV_ATTENDANTDESC";
            internal const string PARAM_IV_ATTENDANTRELATIONID = "IV_ATTENDANTRELATIONID";
            internal const string PARAM_IV_ISLOCALLANGUAGE = "IV_ISLOCALLANGUAGE";
            internal const string PARAM_IV_ISENGLISH = "IV_ISENGLISH";
            internal const string PARAM_IV_ISINTERPRETER = "IV_ISINTERPRETER";
            internal const string PARAM_IV_INTERPRETERLANGID = "IV_INTERPRETERLANGID";
            internal const string PARAM_IV_NEEDFOROXYGEN = "IV_NEEDFOROXYGEN";
            internal const string PARAM_IV_TRACHEOSTOMY = "IV_TRACHEOSTOMY";
            internal const string PARAM_IV_CONSCIOUS = "IV_CONSCIOUS";
            internal const string PARAM_IV_INTUBATED = "IV_INTUBATED";
            internal const string PARAM_IV_CREATEDBY = "IV_CREATEDBY";
            internal const string PARAM_IV_UPDATEDBY = "IV_UPDATEDBY";
            internal const string PARAM_IV_ISSAVE = "IV_ISSAVE";
            internal const string PARAM_IV_ISSAVELOCK = "IV_ISSAVELOCK";
            internal const string PARAM_IV_SPECIALITYID = "IV_SPECIALITYID";
            internal const string PARAM_IV_ISNEONATAL = "IV_ISNEONATAL";
            internal const string PARAM_IV_DOB = "IV_DOB";
            internal const string PARAM_IV_TYPE = "IV_TYPE";
            internal const string PARAM_IV_BIRTHWEIGHT = "IV_BIRTHWEIGHT";
            internal const string PARAM_IV_MOTHERNAME = "IV_MOTHERNAME";
            internal const string PARAM_IV_CONTACT = "IV_CONTACT";
            internal const string PARAM_IV_MOTHERTONGUE = "IV_MOTHERTONGUE";
        }
        //Nurse Initial Assessment Third accordian
        public class DG_SAVEPATORIENTATION
        {
            internal const string SPNAME = "DIGITAL.P_SAVEIAPATORIENTATION_DG";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_DOCTORID = "IV_DOCTORID";
            internal const string PARAM_IV_NURSEID = "IV_NURSEID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_GENORIENTATION = "IV_GENORIENTATION";
            internal const string PARAM_IV_RIGHTS = "IV_RIGHTS";
            internal const string PARAM_IV_ISSPECIALNEEDS = "IV_ISSPECIALNEEDS";
            internal const string PARAM_IV_SPECIALNEEDDESC = "IV_SPECIALNEEDDESC";
            internal const string PARAM_IV_PATIENTDIET1 = "IV_PATIENTDIET1";
            internal const string PARAM_IV_PATIENTDIET2 = "IV_PATIENTDIET2";
            internal const string PARAM_IV_PATIENTDIET3 = "IV_PATIENTDIET3";
            internal const string PARAM_IV_ISOTHER = "IV_ISOTHER";
            internal const string PARAM_IV_OTHERDESC = "IV_OTHERDESC";
            internal const string PARAM_IV_CREATEDBY = "IV_CREATEDBY";
            internal const string PARAM_IV_UPDATEDBY = "IV_UPDATEDBY";

        }
        //Nurse Initial Assessment Gynae accordian
        public class DG_SAVEGYNAEDETAILS
        {
            internal const string SPNAME = "DIGITAL.P_SAVEIAGYNAEDETAILS_DG";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_DOCTORID = "IV_DOCTORID";
            internal const string PARAM_IV_NURSEID = "IV_NURSEID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_ISMENARCHE = "IV_ISMENARCHE";
            internal const string PARAM_IV_MENARCHEDESC = "IV_MENARCHEDESC";
            internal const string PARAM_IV_ISMENOPAUSE = "IV_ISMENOPAUSE";
            internal const string PARAM_IV_MENOPAUSEDESC = "IV_MENOPAUSEDESC";
            internal const string PARAM_IV_MENSTRUALCYCLE = "IV_MENSTRUALCYCLE";
            internal const string PARAM_IV_DURATIONCYCLE = "IV_DURATIONCYCLE";
            internal const string PARAM_IV_TYPEOFMENSTRUAL = "IV_TYPEOFMENSTRUAL";
            internal const string PARAM_IV_ISCONTRACEPTION = "IV_ISCONTRACEPTION";
            internal const string PARAM_IV_CONTRACEPTIONDESC = "IV_CONTRACEPTIONDESC";
            internal const string PARAM_IV_PASTHISTORY = "IV_PASTHISTORY";
            internal const string PARAM_IV_OTHERINFO = "IV_OTHERINFO";
            internal const string PARAM_IV_MARTIALHISTORY = "IV_MARTIALHISTORY";
            internal const string PARAM_IV_LMP = "IV_LMP";
            internal const string PARAM_IV_ISPREGNANT = "IV_ISPREGNANT";
            internal const string PARAM_IV_ISLABOUR = "IV_ISLABOUR";
            internal const string PARAM_IV_CREATEDBY = "IV_CREATEDBY";
            internal const string PARAM_IV_UPDATEDBY = "IV_UPDATEDBY";
            internal const string NAME_PREGNANT = "DIGITAL.P_SAVEIAPREGENANTDETAILS_DG";
            internal const string PARAM_IV_OBSTETRICALSCORE = "IV_OBSTETRICALSCORE";
            internal const string PARAM_IV_EDD = "IV_EDD";
            internal const string PARAM_IV_WEEKSOFGESTATION = "IV_WEEKSOFGESTATION";
            internal const string PARAM_IV_FHS = "IV_FHS";
            internal const string PARAM_IV_ISEDEMA = "IV_ISEDEMA";
            internal const string PARAM_IV_EDEMADESC = "IV_EDEMADESC";
            internal const string PARAM_IV_ISPREVLSCS = "IV_ISPREVLSCS";
            internal const string PARAM_IV_PREVLSCSDESC = "IV_PREVLSCSDESC";
            internal const string PARAM_IV_BREAST = "IV_BREAST";
            internal const string PARAM_IV_ISCOMPLICATION = "IV_ISCOMPLICATION";
            internal const string PARAM_IV_COMPLICATIONDESC = "IV_COMPLICATIONDESC";

        }
        //Nurse Initial Assessment Third accordian
        public class DG_SAVERISKASSESSMENT
        {
            internal const string SPNAME = "DIGITAL.P_SAVEIARISKASSESSMENT_DG";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_DOCTORID = "IV_DOCTORID";
            internal const string PARAM_IV_NURSEID = "IV_NURSEID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_ISMOBILITYAID = "IV_ISMOBILITYAID";
            internal const string PARAM_IV_MOBILITYAIDDESC = "IV_MOBILITYAIDDESC";
            internal const string PARAM_IV_PRESSUREULCER = "IV_PRESSUREULCER";
            internal const string PARAM_IV_PRESSUREULCERDESC = "IV_PRESSUREULCERDESC";
            internal const string PARAM_IV_ISRISK = "IV_ISRISK";
            internal const string PARAM_IV_SPECIALNOTES = "IV_SPECIALNOTES";
            internal const string PARAM_IV_CREATEDBY = "IV_CREATEDBY";
            internal const string PARAM_IV_UPDATEDBY = "IV_UPDATEDBY";
            internal const string PARAM_IV_ISARTIFICIALPROSTHESISID = "IV_ISARTIFICIALPROSTHESISID";
            internal const string PARAM_IV_ARTIFICIALPROSTHESISDESC = "IV_ARTIFICIALPROSTHESISDESC";
            internal const string PARAM_IV_ISTHERAPEUTICDIETID = "IV_ISTHERAPEUTICDIETID";
            internal const string PARAM_IV_THERAPEUTICDIETDESC = "IV_THERAPEUTICDIETDESC";

        }
        //Nurse Initial Assessment Assessment
        public class DG_SAVEASSESSMENTINFO
        {
            internal const string SPNAME = "DIGITAL.P_SAVEIAASSESSMENT_DG";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_DOCTORID = "IV_DOCTORID";
            internal const string PARAM_IV_NURSEID = "IV_NURSEID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_ISINVASIVE = "IV_ISINVASIVE";
            internal const string PARAM_IV_INVASIVEDESC = "IV_INVASIVEDESC";
            internal const string PARAM_IV_ISEDEMA = "IV_ISEDEMA";
            internal const string PARAM_IV_EDEMADESC = "IV_EDEMADESC";
            internal const string PARAM_IV_ISCONGENTIAL = "IV_ISCONGENTIAL";
            internal const string PARAM_IV_CONGENTIALDESC = "IV_CONGENTIALDESC";
            internal const string PARAM_IV_ISGRUNTING = "IV_ISGRUNTING";
            internal const string PARAM_IV_COLOR = "IV_COLOR";
            internal const string PARAM_IV_NAILBUDS = "IV_NAILBUDS";
            internal const string PARAM_IV_ADBOMEN = "IV_ADBOMEN";
            internal const string PARAM_IV_SKIN = "IV_SKIN";
            internal const string PARAM_IV_ISFEEDING = "IV_ISFEEDING";
            internal const string PARAM_IV_CREATEDBY = "IV_CREATEDBY";
            internal const string PARAM_IV_UPDATEDBY = "IV_UPDATEDBY";
            internal const string PARAM_IV_NOFEEDINGDESC = "IV_NOFEEDINGDESC";
            internal const string PARAM_IV_ISVOIDEDURINE = "IV_ISVOIDEDURINE";
            internal const string PARAM_IV_NOVOIDEDURINE = "IV_NOVOIDEDURINE";
            internal const string PARAM_IV_ISPASSEDSTOOLS = "IV_ISPASSEDSTOOLS";
            internal const string PARAM_IV_NOPASSEDDESC = "IV_NOPASSEDDESC";
            internal const string PARAM_IV_TYPEOFFEED = "IV_TYPEOFFEED";
            internal const string PARAM_IV_FEED = "IV_FEED";
            internal const string PARAM_IV_SPECIALNOTES = "IV_SPECIALNOTES";

        }
        public class DG_GETNURSEIALOVDetails
        {
            internal const string NAME = "DIGITAL.P_GETIALOVDETAILS_DG";
            internal const string PARAM_OUT_Result_Master = "oCursor_Result_MASTER";
            internal const string PARAM_OUT_Result_subMaster = "oCursor_Result_submaster";
        }
        public class DG_GETNurseIADETAILS
        {
            internal const string NAME = "DIGITAL.P_GETNURSEIADETAILS_DG";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_NURSEID = "IV_NURSEID";
            internal const string PARAM_OUT_NURSEIADATA = "OCURSOR_NURSEIADATA";
            internal const string PARAM_OUT_BASICINFO = "OCURSOR_BASICINFO";
            internal const string PARAM_OUT_PATORIENTATION = "OCURSOR_PATORIENTATION";
            internal const string PARAM_OUT_PATVALUABLES = "OCURSOR_PATVALUABLES";
            internal const string PARAM_OUT_GYNAE = "OCURSOR_GYNAE";
            internal const string PARAM_OUT_PREGNANT = "OCURSOR_PREGNANT";
            internal const string PARAM_OUT_LABOUR = "OCURSOR_LABOUR";
            internal const string PARAM_OUT_RISKASS = "OCURSOR_RISKASS";
            internal const string PARAM_OUT_RISKASSNEED = "OCURSOR_RISKASSNEED";
            internal const string PARAM_OUT_ASSESSMENT = "OCURSOR_ASSESSMENT";
            internal const string PARAM_OUT_PRESSUREULCER = "OCURSOR_PRESSUREULCER";
            internal const string REPORTNAME = "DIGITAL.P_NURSEIADETAILSREPORT_DG";
            internal const string PARAM_OUT_VITALS = "Initial_assessment_VITALS";
            internal const string PARAM_OUT_VITALSDATE = "INTIALVITAL_DATE";
            internal const string PARAM_OUT_GENORIENTATION = "OCURSOR_GENORIENTATION";
            internal const string PARAM_OUT_RIGHTSRESP = "OCURSOR_RIGHTSRESP";
        }
        public class GETLANGUAGES
        {
            internal const string SPNAME = "DIGITAL.P_GETLANGUAGES_DG";
            internal const string PARAM_IN_LANGUAGENAME = "IV_LANGUAGENAME";
            internal const string PARAM_OUT_LANGUAGENAME = "oCursor_Language";
        }

        //sticker generation starts here

        public class GETLABSTICKERDETAILS_ALL
        {
            internal const string SPNAME = "LAB.p_generatesequenceforsamples";
            internal const string PARAM_IN_Request = "IN_REQUEST";
            internal const string PARAM_IN_LocationID = "IN_LOCATIONID";
            internal const string PARAM_IN_LoginID = "IN_LOGINID";
            internal const string PARAM_IN_DepartmentName = "IN_DEPARTMNETNAME";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_SIN = "IN_SIN";
            internal const string PARAM_IN_LRN = "IN_LRN";
            internal const string PARAM_IN_PatientServiceNo = "IN_PATIENTSERVICENO";
            internal const string PARAM_IN_CampID = "IN_CAMPID";
            internal const string PARAM_IN_AgencyID = "IN_AGENCYID";
            internal const string PARAM_OUT_DETAILS = "OREF_MYTASKSAMPLES";
        }

        public class LabGetDepartments
        {
            internal const string SPNAME = "LAB.P_GETDEPARTMENTS";
            internal const string PARAM_IN_departID = "IN_PARENTDEPARTMENID";
            internal const string PARAM_IN_LocationID = "IV_LOCATIONID";
            internal const string PARAM_OUT_Deptcursor = "OREF_DEPTCURSOR";
        }
        public class LabGetbedNo
        {
            internal const string SPNAME = "ADT.P_GETPATIENTOCCUPIEDBEDS";
            internal const string PARAM_IN_IPNO = "IV_INPATIENTNO";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_LocationID = "IN_LOCATIONID";
            internal const string PARAM_OUT_OCUR1 = "OCURSOR_RESULT";
            internal const string PARAM_OUT_OCUR2 = "OCURSOR_TRANSFERHISTORY";
        }
        public class LabStickerPtnStatus
        {
            internal const string SPNAME = "ADT.p_getadmissiondetails";
            internal const string PARAM_IN_IPNO = "iv_inaptientno";
            internal const string PARAM_IN_UHID = "iv_uhid";
            internal const string PARAM_IN_LocationID = "in_locationid";
            internal const string PARAM_OUT_OCUR1 = "ov_status";
            internal const string PARAM_OUT_OCUR2 = "ocursor_admdetails";
        }
        public class LabGetPatientDetails
        {
            internal const string SPNAME = "REGISTRATION.P_GETPATIENTDETAILS";
            internal const string PARAM_IN_registrationNo = "IN_REGISTRATIONNUMBER";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_PreRegistrationNo = "IN_PREREGISTRATIONNO";
            internal const string PARAM_IN_EmergencyNo = "IN_EMERGENCYNO";
            internal const string PARAM_IN_tempDraftId = "IV_TEMPDRAFTID";
            internal const string PARAM_IN_locationid = "IN_LOCATIONID";
            internal const string PARAM_IN_MasterFlag = "IN_MASTERFLAG";
            internal const string PARAM_OUT_patientDetailsCursor1 = "OCURSOR_COMPONENT1";
            internal const string PARAM_OUT_patientDetailsCursor3 = "OCURSOR_COMPONENT3";
            internal const string PARAM_OUT_patientDetailsCursor4 = "OCURSOR_COMPONENT4";
            internal const string PARAM_OUT_patientDetailsCursor5 = "OCURSOR_COMPONENT5";
            internal const string PARAM_OUT_patientDetailsCursor6 = "OCURSOR_COMPONENT6";
            internal const string PARAM_OUT_patientDetailsCursor7 = "OCURSOR_COMPONENT7";
            internal const string PARAM_OUT_patientDetailsCursor8 = "OCURSOR_COMPONENT8";
            internal const string PARAM_OUT_patientDetailsCursor9 = "OCURSOR_COMPONENT9";
            internal const string PARAM_OUT_patientDetailsCursor10 = "OCURSOR_COMPONENT10";
            internal const string PARAM_OUT_patientDetailsCursor11 = "OCURSOR_COMPONENT11";
            internal const string PARAM_OUT_patientDetailsCursor12 = "OCURSOR_COMPONENT12";
            internal const string PARAM_OUT_patientDetailsCursor13 = "OCURSOR_COMPONENT13";
            internal const string PARAM_OUT_patientDetailsCursor14 = "OCURSOR_COMPONENT14";
            internal const string PARAM_OUT_patientDetailsCursor15 = "OCURSOR_COMPONENT15";
            internal const string PARAM_OUT_patientDetailsCursor16 = "OCURSOR_COMPONENT16";
            internal const string PARAM_OUT_patientDetailsCursor17 = "OCURSOR_COMPONENT17";
            internal const string PARAM_OUT_patientDetailsCursor18 = "OCURSOR_COMPONENT18";
            internal const string PARAM_OUT_patientDetailsCursorALTUID = "OCURSOR_ALTUID";
        }


        //---------- Lab sricker generation code ends here---------
        //---------- IP sricker generation code Starts here---------

        public class DG_GETIPSTICKER
        {
            internal const string NAME = "registration.p_Stickers_wards";
            internal const string PARAM_IN_UHID = "v_uhid";
            internal const string PARAM_IN_Ipnumber = "v_ipno";
            internal const string PARAM_IN_LocationId = "v_locationid";
            internal const string PARAM_IN_v_bedno = "v_bedno";
            internal const string PARAM_OUT_SERVICEITEM = "cur_stickers";

        }

        //---------- IP sricker generation code ends here---------
        //----------drugsricker generation code starts here---------

        public class DG_GETDRUG_DETAILS_ALL
        {
            internal const string NAME = "PHARMACY.p_getreturncodesonip";
            internal const string PARAM_IN_IPNumber = "iv_ipnumber";
            internal const string PARAM_IN_FromDate = "iv_fromdate";
            internal const string PARAM_IN_ToDate = "iv_todate";
            internal const string PARAM_OUT_ReturnCode = "ocursor_result1";
            internal const string SP_NAME = "P_getIpName";
            internal const string PARAM_OUT_GETIPNAME = "oCursor_Result1";
        }
        public class DG_GETDRUGPROC2_DETAILS_ALL
        {
            internal const string NAME = "PHARMACY.p_rptreturncode";
            internal const string PARAM_IN_ReturnNumber = "iv_returnnumber";
            internal const string PARAM_OUT_Details = "oCursor_Result1";
        }
        //sticker generation ends here
        //Consumption Declaration MM Starts
        public class ConDecUpdateBillingStatus
        {
            internal const string SPNAME = "BILLING.P_UpdateBillingStatus";
            internal const string PARAM_Iclob_iXMLServiceRequest = "iXMLServiceRequest";
            internal const string PARAM_IN__loginid = "IV_LOGINID";

        }
        //Consumption Declaration MM End
        #region ConsumptionDeclaration
        public class DG_GetIssueSearchDetails
        {
            internal const string NAME = "MM.p_issuesearch";
            internal const string PARAM_IN_ISSUECODE = "iv_IssueCode";
            internal const string PARAM_IN_StoreCode = "iv_StoreCode";
            internal const string PARAM_IN_IPNO = "iv_IPNO";
            internal const string PARAM_IN_DeptId = "iv_DeptId";
            internal const string PARAM_IN_Issuer = "iv_Issuer";
            internal const string PARAM_IN_Fromdate = "iv_Fromdate";
            internal const string PARAM_IN_Todate = "iv_Todate";
            internal const string PARAM_IN_Status = "iv_Status";
            internal const string PARAM_IN_regionid = "iv_regionid";

        }
        public class DG_GetStatusDetails
        {
            internal const string NAME = "MM.p_getinitialdata";
            internal const string PARAM_IN_LOVCODE = "iv_lovcode";

        }
        public class DG_GetConsumptionDeclaration
        {
            internal const string NAME = "MM.P_GETISSUEDDETAILS";
            internal const string PARAM_IN_ISSUECODE = "iv_IssueCode";
            internal const string PARAM_IN_StoreCode = "iv_StoreCode";
            internal const string PARAM_IN_RegionID = "iv_RegionID";
        }
        public class DG_GetRegionLocation
        {
            internal const string NAME = "MM.P_GETREGIONONLOCATION";
            internal const string PARAM_IN_LOCATIONID = "iv_chartId";
        }
        public class DG_GetStoreUsers
        {
            internal const string NAME = "MM.P_GETSTOREUSERS";
            internal const string PARAM_IN_LoginID = "iv_LoginID";

            internal const string PARAM_IN_LOCATIONID = "iv_LocationID";

        }
        public class DG_SaveConsumptionDeclarationitems
        {
            internal const string NAME = "MM.p_ConsumptionDeclarationitems";
            internal const string PARAM_iCLOB_RETURNDETAILS = "ICLOB_RETURNDETAILS";

        }
        //public class DG_BillingServiceRequest
        //{
        //    internal const string NAME = "p_servicerequest";
        //    internal const string PARAM_ixmlservicerequest = "ixmlservicerequest";
        //    internal const string PARAM_IN_LoginId = "iv_loginid";
        //}
        //public class RaiseBillingServices
        //{
        //    internal const string SPNAME = "p_servicerequest";
        //    internal const string PARAM_Iclob_ixmlservicerequest = "ixmlservicerequest";
        //    internal const string PARAM_IN__loginid = "iv_loginid";
        //    internal const string PARAM_out_buffercheck = "v_buffercheck";
        //}
        #endregion


        //Patient absconding starts
        //Get patientdetails for absconding

        public class P_getpatientuhidipnumber_DG
        {
            internal const string SPNAME = "DIGITAL.P_GETPATIENTUHIDIPNUMBER_DG";
            internal const string PARAM_IN_serachparam = "parameter";
            internal const string PARAM_IN_SERACHTYPE = "IV_SERACHTYPE";
            internal const string PARAM_OUT_cursor = "ocursor_result";
        }

        //get patient banner for absconding
        public class P_GETPATIENTABSCONDBANNER_DG
        {
            internal const string NAME = "DIGITAL.P_GETPATIENTABSCONDBANNER_DG";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IN_LocationId = "IV_location";
            internal const string PARAM_OUT_CURSOR = "REFCURS_IP";

        }


        public class UPDATENURSECHECKINCHKOUT
        {
            internal const string SPNAME = "WARDS.P_UPDATENURSECHECKINCHKOUT";
            internal const string PARAM_ICLOB_UPDATENURSECHECKINCHKOUT = "ICLOB_NURSECHECKINCHKOUT";

        }

        public class DG_GetViewDietList
        {
            internal const string SPNAME = "FB.P_GETDIETSLIPSFORINITIATION";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_ServiceNo = "IV_SERVICENO";
            internal const string PARAM_IN_DietitionNo = "IV_DIETINTIATIONNO";
            internal const string PARAM_IN_LocationId = "IV_LOCATIONID";
            internal const string PARAM_OUT_ocursor_Request = "OCURSOR_REQUESTS";
            internal const string PARAM_OUT_ocursor_DietSlip = "OCURSOR_DIETSLIPS";

        }
        public class DG_GETLHKVIEW
        {
            internal const string NAME = "LHK.P_GET_REQUEST";
            internal const string PARAM_IN_REQUESTNUMBER = "IV_REQUESTNUMBER";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IN_IV_PATIENTLOC = "IV_PATIENTLOCATION";
            internal const string PARAM_IN_IV_JOBTYPE = "IV_JOBTYPE";
            internal const string PARAM_IN_IV_REQUESTSTATUS = "IV_REQUESTSTATUS";
            internal const string PARAM_IN_IV_REQUESTFROMDATE = "IV_REQUESTFROMDATE";
            internal const string PARAM_IN_IV_REQUESTTODATE = "IV_REQUESTTODATE";
            internal const string PARAM_OUT_REQUEST = "ocursor_request";
            internal const string PARAM_IN_IV_JOBTYPEID = "IN_JOBTYPEID";
            internal const string PARAM_IN_v_bedno = "in_bedno";
            internal const string PARAM_IN_LocationId = "iv_locationid";


        }
        public class DG_DELETELHKVIEW
        {
            internal const string SPNAME = "LHK.P_SAVE_UPD_DEL_LHKREQUEST";
            internal const string PARAM_IV_REQUESTNO = "IV_REQUESTNO";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_PATIENTSERVICENUMBER = "IV_PATIENTSERVICENUMBER";
            internal const string PARAM_IV_JOBTYPE = "IV_JOBTYPE";
            internal const string PARAM_IV_JOBPRIORITY = "IV_JOBPRIORITY";
            internal const string PARAM_IV_REQUIREDAT = "IV_REQUIREDAT";
            internal const string PARAM_IV_REQUIREDDATE = "IV_REQUIREDDATE";
            internal const string PARAM_IV_REQUIREDTIME = "IV_REQUIREDTIME";
            internal const string PARAM_IV_SURGERYDATE = "IV_SURGERYDATE";
            internal const string PARAM_IV_SURGERYTIME = "IV_SURGERYTIME";
            internal const string PARAM_IV_STATUS = "IV_STATUS";
            internal const string PARAM_IV_LOCATION = "IV_LOCATION";
            internal const string PARAM_IV_RAISEDBY = "IV_RAISEDBY";
            internal const string PARAM_IV_RAISEDDATE = "IV_RAISEDDATE";
            internal const string PARAM_IV_MODIFIEDBY = "IV_MODIFIEDBY";
            internal const string PARAM_IV_MODIFIEDDATE = "IV_MODIFIEDDATE";
            internal const string PARAM_IV_ISSUEBILLING = "IV_ISSUEBILLING";
            internal const string PARAM_IV_REMARKS = "IV_REMARKS";
            internal const string PARAM_IV_FLAG = "IV_FLAG";
            internal const string PARAM_OV_GENERATEDREQUESTNO = "OV_GENERATEDREQUESTNO";
            internal const string PARAM_ICLOB_REQUEST = "ICLOB_REQUEST";
            internal const string PARAM_IV_SPECIALNOTE = "IV_SPECIALNOTE";
            internal const string PARAM_IV_REQUESTFOR = "IV_REQUESTFOR";
            internal const string PARAM_IV_TOLOCATION = "IV_TOLOCATION";
            internal const string PARAM_IV_QUANTITY = "IV_QUANTITY";
            internal const string PARAM_IN_JOBTYPEID = "IN_JOBTYPEID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_COMPLETEDBY = "IV_COMPLETEDBY";
        }
        public class Dite_Acknowledge
        {
            internal const string SPNAME = "FNB.P_ACKNOWLEDGEDIETSLIP";

            internal const string PARAM_ICLOB_sERVINGID = "IN_ServingID";
            internal const string PARAM_IV_LOGINID = "IV_LOGINID";


        }

        //Patient absconding end

        #region Nurse Intial Assessment audit
        public class AuditIa
        {
            internal const string BASICNAME = "digital.P_AUDITDATA_IA";
            internal const string GYNAENAME = "digital.P_AUDITDATA_GYNAE_DG";
            internal const string ORIENTATIONNAME = "digital.P_AUDITDATA_ORIENTATION_DG";
            internal const string RISKNAME = "digital.P_AUDITDATA_RISKASSESSMENT_DG";
            internal const string ASSESNAME = "digital.P_AUDITDATA_ASSESSMENT_DG";
            //internal const string HabitsProcNAME = "P_DG_TrackChanges_IA_Habits";
            internal const string PARAM_IN_IpNumber = "in_ipnumber";
            internal const string PARAM_IN_Doctorid = "in_doctorid";
            internal const string PARAM_IN_Locationid = "in_locationId";
            internal const string PARAM_IN_Submenuname = "in_submenuname";
            internal const string PARAM_IN_Paramname = "in_paramname";
            internal const string PARAM_IN_Fromdate = "in_fromdate";
            internal const string PARAM_IN_Todate = "in_todate";
            internal const string PARAM_OUT_Parameterdatavalues = "out_parameterdata";
        }

        public class Auditia_menu
        {
            internal const string NAME = "digital.P_AUDITMENU_DG";
            internal const string PARAM_IN_NurseId = "in_nurseid";
            internal const string PARAM_OUT_AccordianMenu = "out_accordianmenu";
            internal const string PARAM_OUT_AccordianParamList = "out_accordianparamlist";
        }
        #endregion Intial Assessment audit

        #region Bed side
        public class DG_BEDSIDEREQUEST
        {
            internal const string NAME = "ot.PKG_PROCEDURE_REQUEST_P_ADD_PROC_REQUEST_DATA";
            internal const string PARAM_IN_SURG_ADVICE_ID = "IN_SURG_ADVICE_ID";
            internal const string PARAM_IV_IP_NUMBER = "IV_IP_NUMBER";
            internal const string PARAM_IN_SPECIALITY_ID = "IN_SPECIALITY_ID";
            internal const string PARAM_IN_PATIENTTYPE_ID = "IN_PATIENTTYPE_ID";
            internal const string PARAM_IC_DURATION_SOURCE = "IC_DURATION_SOURCE";
            internal const string PARAM_ID_PLANNED_DURATION = "ID_PLANNED_DURATION";
            internal const string PARAM_IV_PLANNED_START_TIME = "IV_PLANNED_START_TIME";
            internal const string PARAM_IV_PLANNED_END_TIME = "IV_PLANNED_END_TIME";
            internal const string PARAM_ID_PLANNED_DATE = "ID_PLANNED_DATE";
            internal const string PARAM_IN_PLANNED_OT_ID = "IN_PLANNED_OT_ID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_CREATED_BY = "IV_CREATED_BY";
            internal const string PARAM_ON_REQ_NO = "ON_REQ_NO";
            internal const string PARAM_IN_REQUEST_PRIORITY_ID = "IN_REQUEST_PRIORITY_ID";
            internal const string PARAM_IV_OP_NUMBER = "IV_OP_NUMBER";
            internal const string PARAM_IV_ERN = "IV_ERN";
            internal const string PARAM_IN_APPOINTMENT_ID = "IN_APPOINTMENT_ID";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IN_TEAM_LEAD_ID = "IN_TEAM_LEAD_ID";
            internal const string PARAM_ID_ENDDATE = "ID_ENDDATE";
            internal const string PARAM_IC_BEDSIDE_FLAG = "IC_BEDSIDE_FLAG";
            internal const string PARAM_IC_OT_BOOKING_CHRG_FLAG = "IC_OT_BOOKING_CHRG_FLAG";
            internal const string PARAM_IV_FREETEXTSURGERY = "IV_FREETEXTSURGERY";
            internal const string PARAM_IN_PROCREQTYPE = "IN_PROCREQTYPE";
        }
        #endregion
        #region bloodbank
        public class BB_GetBloodTypeMaster
        {
            internal const string SPNAME = "bb.P_GETBLOODTYPEMASTER";
            internal const string PARAM_in_BLOODTYPECODE = "IV_BLOODTYPECODE";
            internal const string PARAM_in_BLOODTYPENAME = "IV_BLOODTYPENAME";
            internal const string PARAM_in_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_out_BLOODTYPE = "OCURSOR_BLOODTYPE";

        }
        public class BB_GetOTROOMS
        {
            internal const string SPNAME = "bb.P_GETOTROOMS";
            internal const string PARAM_in_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_out_OCURSOR = "OCURSOR";

        }
        public class BB_GetPriority
        {
            internal const string SPNAME = "bb.p_getlovdetail";
            internal const string PARAM_in_lovcode = "iv_lovcode";
            internal const string PARAM_in_lovdetailvalue = "iv_lovdetailvalue";
            internal const string PARAM_out_ocursor_lovdetail = "ocursor_lovdetail";

        }
        public class BB_GetRequestNo
        {
            internal const string SPNAME = "BB.P_GetMaxInternalRequestNo";
            internal const string PARAM_out_RequestNo = "Ov_RequestNumber";
        }

        public class BBConfigValue
        {
            internal const string SPNAME = "bb.P_GETBBCONFIGVALUE";
            internal const string PARAM_IV_CONFIGKEY = "IV_CONFIGKEY";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUTCURSOR = "OUTCURSOR";
        }

        public class BB_GetBBInvDtls
        {
            internal const string SPNAME = "bb.P_GetBloodBankInvDetails1";
            internal const string PARAM_in_BloodTypeID = "in_BloodTypeID";
            internal const string PARAM_in_BloodGroupID = "in_BloodGroupID";
            internal const string PARAM_in_RhTypeID = "in_RhTypeID";
            internal const string PARAM_id_ExpiryDate = "id_ExpiryDate";
            internal const string PARAM_in_BagStatusID = "in_BagStatusID";
            internal const string PARAM_in_LocationID = "in_LocationID";
            internal const string PARAM_in_uhid = "in_uhid";
            internal const string PARAM_out_oCursor_BagCountDetails = "oCursor_BagCountDetails";
            internal const string PARAM_out_oCursor_BagDetails = "oCursor_BagDetails";
        }
        public class BB_GetRequestDetails
        {
            internal const string SPNAME = "bb.P_GetRequestDetails";
            internal const string PARAM_iv_RequestNo = "iv_RequestNo";
            internal const string PARAM_iv_servicenumber = "iv_servicenumber";
            internal const string PARAM_in_LocationID = "in_LocationID";
            internal const string PARAM_ocursor_RequestDetails = "ocursor_RequestDetails";

        }
        public class BB_Getservicesid
        {
            internal const string SPNAME = "bb.P_GETSERVICEVALUE";
            internal const string PARAM_IV_BLOODTYPE = "IV_BLOODTYPE";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_CONFIGKEY = "IV_CONFIGKEY";
            internal const string PARAM_OUTCURSOR = "OUTCURSOR";

        }
        public class BB_GetBloodTypeForRPH
        {
            internal const string SPNAME = "bb.P_GETBLOODTYPEFORAPH";
            internal const string PARAM_IV_BLOODTYPEID = "IV_BLOODTYPEID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_O_OUTPUT = "O_OUTPUT";
        }

        public class BB_GetBloodGroupRHID
        {
            internal const string SPNAME = "digital.P_GETBLOODGROUPRHID_DG";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_O_OUTPUT = "O_OUTPUT";
        }
        public class DG_RaiseBBRequest
        {
            internal const string SPNAME = "bb.P_ADDREQUESTDETAILS";
            internal const string PARAM_ICLOB_REQUESTDETAILS = "ICLOB_REQUESTDETAILS";
            internal const string PARAM_IV_LOGINID = "IV_LOGINID";

        }
        public class BB_GetServiceTypeID
        {
            internal const string SPNAME = "bb.P_GETSERVICETYPEID_DG";
            internal const string PARAM_IV_BLOODTYPEID = "IV_BLOODTYPEID";
            internal const string PARAM_IV_ispediatric = "IV_ISPEDIATRIC";
            internal const string PARAM_IV_istheslismia = "IV_ISTHESLISMIA";
            internal const string PARAM_IV_LocationId = "IV_LOCATIONID";
            internal const string PARAM_O_OUTPUT = "O_OUTPUT";
        }

        public class DG_GETBLOODCOMPDETAILS_ALL
        {
            internal const string SP_NAME = "bb.P_SEARCHINTERNALREQUEST_dg";
            internal const string PARAM_IN_Requestnumber = "iv_requestnumber";
            internal const string PARAM_IN_UHID = "iv_uhid";
            internal const string PARAM_IN_IPNumber = "iv_ip_opnumber";
            internal const string PARAM_IN_DEPT = "in_req_dept";
            internal const string PARAM_IN_BLOODGROUP = "in_bloodgroupid";
            internal const string PARAM_IN_RHTYPE = "in_rhtypeid";
            internal const string PARAM_IN_REQUESTEDDATE = "id_requesteddate";
            internal const string PARAM_IN_REQUESTEDSTATUS = "in_requeststatusid";
            internal const string PARAM_IN_LocationID = "in_locationid";
            internal const string PARAM_OUT_BloodComponentData = "ocursor_internalreqdetails";
        }
        public class DG_GETRETURNREASON_ALL
        {
            internal const string SP_NAME = "bb.p_GetReasonMaster";
            internal const string PARAM_IN_ReasonTypeID = "in_ReasonTypeID";
            internal const string PARAM_IN_CategoryID = "in_CategoryID";
            internal const string PARAM_IN_ReasonName = "iv_ReasonName";
            internal const string PARAM_OUT_ReturnReasonData = "ocursor_Reason";
        }
        public class RETURNINTERNALBLOODBAG
        {
            internal const string SPNAME = "P_RETURNINTERNALBLOODBAG";
            internal const string PARAM_v_BLOODBAGNUMBER = "IV_BLOODBAGNUMBER";
            internal const string PARAM_v_REASONFORRETURN = "ICLOB_REASONFORRETURN";
            internal const string PARAM_v_REMARKS = "IV_REMARKS";
            internal const string PARAM_v_LOGINID = "IV_LOGINID";
            internal const string PARAM_v_locationId = "iv_locationId";
        }
        public class RECEIVEBLOODBAG
        {
            internal const string SPNAME = "bb.p_ReceiveBloodBag";
            internal const string PARAM_v_BloodBagNumber = "iv_BloodBagNumber";
            internal const string PARAM_v_ReceivedAt = "in_ReceivedAt";
            internal const string PARAM_v_LoginID = "iv_LoginID";
            internal const string PARAM_v_locationId = "iv_locationId";
        }
        public class DG_GETTHERAPEUTICDETAILS_ALL
        {
            internal const string SP_NAME = "bb.P_GETTHERAPEUTICFORWARDS_DG";
            internal const string PARAM_IN_Requestnumber = "iv_requestnumber";
            internal const string PARAM_IN_IPNumber = "iv_ipnumber";
            internal const string PARAM_IN_UHID = "iv_uhid";
            internal const string PARAM_IN_LocationID = "in_locationid";
            internal const string PARAM_OUT_TherapeuticData = "ocursor_Therapeutic";
        }

        public class DG_CANCELTHERAPEUTICREORD
        {
            internal const string SPNAME = "bb.p_canceltherapeutic";
            internal const string PARAM_v_RequestNo = "iv_requestnumber";
            internal const string PARAM_v_reasonforcancellation = "iv_reasonforcancellation";
            internal const string PARAM_v_dateofcancellation = "id_dateofcancellation";
            internal const string PARAM_v_loginID = "iv_loginid";
        }
        public class DG_GETPROCEDUREDETAILS_ALL
        {
            internal const string SP_NAME = "bb.P_GETPROCEDUREREQUESTVIEW_DG";
            internal const string PARAM_IN_Requestnumber = "iv_requestnumber";
            internal const string PARAM_IN_IPNumber = "iv_ipnumber";
            internal const string PARAM_IN_UHID = "iv_uhid";
            internal const string PARAM_IN_LocationID = "in_locationid";
            internal const string PARAM_OUT_ProcedureData = "ocursor_Procedure";
        }

        public class DG_CANCELPROCEDURERECORD
        {
            internal const string SPNAME = "bb.P_CANCELPROCEDURE_DG";
            internal const string PARAM_v_RequestNo = "iv_requestnumber";
            internal const string PARAM_v_reasonforcancellation = "iv_reasonforcancellation";
            internal const string PARAM_v_dateofcancellation = "id_dateofcancellation";
            internal const string PARAM_v_loginID = "iv_loginid";
        }
        public class DG_CANCEL_bb_BLOODUNITREORD
        {
            internal const string SPNAME = "bb.P_CANCELINTERNALREQUEST";
            internal const string PARAM_v_RequestNo = "iv_RequestNumber";
            internal const string PARAM_v_reasonforcancellation = "iv_reasonforcancellation";
            internal const string PARAM_v_loginID = "iv_loginid";
        }
        public class BB_GetProcedureServices
        {
            internal const string SPNAME = "billing.P_GetServices";
            internal const string PARAM_iv_locationid = "iv_locationid";
            internal const string PARAM_in_patientserviceid = "in_patientserviceid";
            internal const string PARAM_iv_deptid = "iv_deptid";
            internal const string PARAM_in_categoryid = "in_categoryid";
            internal const string PARAM_in_servicetypeid = "in_servicetypeid";
            internal const string PARAM_iv_servicename = "iv_servicename";
            internal const string PARAM_iv_billable = "iv_billable";
            internal const string PARAM_iv_servicestatus = "iv_servicestatus";
            internal const string PARAM_iv_restorable = "iv_restorable";
            internal const string PARAM_in_serviceid = "in_serviceid";
            internal const string PARAM_iv_taxable = "iv_taxable";
            internal const string PARAM_iv_schedulable = "iv_schedulable";
            internal const string PARAM_iv_wildserviceitem = "iv_wildserviceitem";
            internal const string PARAM_in_age = "in_age";
            internal const string PARAM_iv_genderid = "iv_genderid";
            internal const string PARAM_iv_patientconditionid = "iv_patientconditioni";
            internal const string PARAM_oc_servicelist = "oc_servicelist";

        }

        public class BB_RaiseProcedureRequest
        {
            internal const string SPNAME = "bb.P_AddProcedureDetails";
            internal const string PARAM_iCLOB_AddProcedureDetails = "iCLOB_AddProcedureDetails";
            internal const string PARAM_ocursor_RequestDetails = "ocursor_RequestDetails";
        }

        public class BB_GetUnitDetail
        {
            internal const string SPNAME = "bb.p_getunitsdetail";
            internal const string PARAM_iv_unitcode = "iv_unitcode";
            internal const string PARAM_iv_unitdetailname = "iv_unitdetailname";
            internal const string PARAM_ocursor_unitsdetail = "ocursor_unitsdetail";
        }

        public class BB_GetThruRequestNo
        {
            internal const string SPNAME = "bb.P_GetMaxTherapeuticRequestNo";
            internal const string PARAM_Ov_RequestNumber = "Ov_RequestNumber";
        }

        public class BB_RaiseTherupaticRequest
        {
            internal const string PARAM_iClob_RequestDetails = "iClob_RequestDetails";
            internal const string PARAM_iv_loginid = "iv_loginid";
            internal const string PARAM_on_requestid = "on_requestid";
            internal const string SPNAME = "bb.P_ADDTHERAPEUTICREQUEST";

        }
        public class BB_GetPreviousTransfusionHistory
        {
            internal const string PARAM_iv_ipno = "iv_ipno";
            internal const string PARAM_iv_uhid = "iv_uhid";
            internal const string PARAM_iv_requestno = "iv_requestno";
            internal const string PARAM_out_history = "out_history";
            internal const string SPNAME = "bb.P_GETTRANSFUSIONHISTORY_DG";
        }
        public class BB_PreviousBloodUnitRequest
        {
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_OCURSER_REQUESTDETAILS = "OCURSER_REQUESTDETAILS";
            internal const string SPNAME = "bb.P_GETPREVIOUSBLOODUNITREQUEST";
        }

        #endregion

        #region Mealorder

        public class DG_GETSERVICETIMEDETAILS
        {
            internal const string SPNAME = "fb.p_getservicetimemaster";
            internal const string PARAM_IN_LOCATIONID = "in_locationid";
            internal const string PARAM_IN_SERVICEID = "in_serviceid";
            internal const string PARAM_IV_SERVICENAME = "iv_servicename";
            internal const string PARAM_IN_SERVICESTATUS = "in_servicestatus";
            internal const string PARAM_IN_TIMESLABMIN = "in_timeslabmin";
            internal const string PARAM_IN_TIMESLABMAX = "in_timeslabmax";
            internal const string PARAM_IN_LIQUIDSERVICE = "in_liquidservice";
            internal const string PARAM_OUT_OCURSOR_SERVICENAME = "ocursor_servicename";
        }



        public class DG_getfooditemmaster
        {
            internal const string SPNAME = "fb.p_getfooditemmaster";
            internal const string PARAM_IN_LOCATIONID = "in_locationid";
            internal const string PARAM_IN_FOODITEMCATEGORYID = "in_fooditemcategoryid";
            internal const string PARAM_IN_FOODITEMID = "in_fooditemid";
            internal const string PARAM_IV_FOODITEMNAME = "iv_fooditemname";
            internal const string PARAM_IN_SERVINGQUANTITYID = "in_servingquantityid";
            internal const string PARAM_IN_INGREDIENTPERQTY = "in_ingredientperqty";
            internal const string PARAM_IV_INGREDIENTPERQTYUNITS = "iv_ingredientperqtyunits";
            internal const string PARAM_IF_ENERGY = "if_energy";
            internal const string PARAM_IN_MEALTYPE = "in_mealtype";
            internal const string PARAM_OUT_OCURSOR_FOODITEM = "ocursor_fooditem";
        }

        public class DG_getmenu
        {
            internal const string SPNAME = "fb.p_getmenu";
            internal const string PARAM_IN_SERVICEID = "in_serviceid";
            internal const string PARAM_IN_SERVICEDATE = "in_servicedate";
            internal const string PARAM_IN_DAYID = "in_dayid";
            internal const string PARAM_OUT_OCURSOR_MENU = "ocursor_menu";
            internal const string PARAM_OUT_OCURSOR_FOOD = "ocursor_food";
        }
        public class GetPatientPanelDetails
        {
            internal const string SPNAME = "ehis.P_GETPATIENTPANELDETAILS";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_PRN = "IV_PRN";
            internal const string PARAM_IV_ERN = "IV_ERN";
            internal const string PARAM_OCURSOR_RESULT1 = "OCURSOR_RESULT1";
            internal const string PARAM_OCURSOR_RESULT2 = "OCURSOR_RESULT2";
            internal const string PARAM_OCURSOR_RESULT3 = "OCURSOR_RESULT3";
            internal const string PARAM_OCURSOR_RESULT4 = "OCURSOR_RESULT4";

        }

        public class DG_SAVEDIETSLIP_FNB
        {
            internal const string SPMEALORDERNAME = "fb.p_savedietslip";
            //    internal const string PARAM_in_location = "in_location";
            //    internal const string PARAM_in_servicetimeid = "in_servicetimeid";
            //    internal const string PARAM_in_requesttype = "in_requesttype";
            //    internal const string PARAM_in_patienttype = "in_patienttype";
            //    internal const string PARAM_in_fnbserviceid = "in_fnbserviceid";
            //    internal const string PARAM_in_typeofdiet = "in_typeofdiet";
            //    internal const string PARAM_in_date = "in_date";
            //    internal const string PARAM_in_totalbill = "in_totalbill";
            //    internal const string PARAM_iv_uhid = "iv_uhid";
            //    internal const string PARAM_iv_servicenumber = "iv_servicenumber";
            //    internal const string PARAM_iv_name = "iv_name";
            //    internal const string PARAM_iv_age = "iv_age";
            //    internal const string PARAM_iv_gender = "iv_gender";
            //    internal const string PARAM_iv_building = "iv_building";
            //    internal const string PARAM_iv_block = "iv_block";
            //    internal const string PARAM_iv_floor = "iv_floor";
            //    internal const string PARAM_iv_bedcategory = "iv_bedcategory";
            //    internal const string PARAM_iv_bedcode = "iv_bedcode";
            //    internal const string PARAM_iv_ward = "iv_ward";
            //    internal const string PARAM_iv_bednumber = "iv_bednumber";
            //    internal const string PARAM_iv_diabetic = "iv_diabetic";
            //    internal const string PARAM_iv_consultantname = "iv_consultantname";
            //    internal const string PARAM_ic_fooditemxml = "ic_fooditemxml";
            //    internal const string PARAM_iv_loginid = "iv_loginid";
            //    internal const string PARAM_on_dietid = "on_dietid";
            //    internal const string PARAM_in_dietpreparationid = "in_dietpreparationid";
            //    internal const string PARAM_ov_dietslipno = "ov_dietslipno";
            //    internal const string PARAM_on_bedid = "on_bedid";
            //    internal const string PARAM_ic_dietrestrictionxml = "ic_dietrestrictionxml";




        }

        public class DG_GETMEALORDERSLIP
        {
            internal const string SPNAME = "fb.P_MEALORDERSLIP";
            internal const string PARAM_IN_REQUESTNO = "IN_REQUESTNO";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OVCURSOR_MEALDETAILS = "OVCURSOR_MEALDETAILS";

        }


        #endregion

        #region SpecialDietRequest


        public class DG_GETFNBSERVCIES
        {
            internal const string SPNAME = "fb.p_getfnbservcies";
            internal const string PARAM_IN_LOCATIONID = "in_locationid";
            internal const string PARAM_IN_FNBSERVICEID = "in_fnbserviceid";
            internal const string PARAM_IN_FNBSERVICETYPE = "in_fnbservicetype";
            internal const string PARAM_IV_UHID = "iv_uhid";
            internal const string PARAM_IV_SERVICENO = "iv_serviceno";

            internal const string PARAM_OUT_OCURSOR_PATIENTDIETTYE = "ocursor_patientdiettye";
            internal const string PARAM_OCURSOR_PATIENTMEALTYPE = "ocursor_patientmealtype";
            internal const string PARAM_OCURSOR_PATIENTPREFERENCE = "ocursor_patientpreference";
            internal const string PARAM_OUT_OCURSOR_DIETINITIATION = "ocursor_dietinitiation";
            internal const string PARAM_OUT_OCURSOR_FNB = "ocursor_fnb";

        }


        #endregion

        #region Diet
        public class DietRaiseRequest
        {
            internal const string SPNAME = "FB.P_SAVEDIETINITIATION";
            internal const string PARAM_IN_LocationID = "IN_LocationID";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_SERVICENO = "IV_SERVICENO";
            internal const string PARAM_IN_SERVICECATERGORYID = "IN_SERVICECATERGORYID";
            internal const string PARAM_IN_REASONFORMODIFICATION = "IN_REASONFORMODIFICATION";
            internal const string PARAM_IV_LOGINID = "IV_LOGINID";
            internal const string PARAM_ON_DietInitationID = "ON_DietInitationID";
            internal const string PARAM_IC_PatientRecall = "IC_PatientRecall";
            internal const string PARAM_IC_PatientComplaint = "IC_PatientComplaint";
            internal const string PARAM_IC_Prescribtion = "IC_Prescribtion";
            internal const string PARAM_out_OV_DIETNO = "OV_DIETNO";
        }

        public class UpdateDietRaiseRequest
        {
            internal const string SPNAME = "Fb.P_UpdateDIETINITIATION";
            internal const string PARAM_IN_LocationID = "IN_LocationID";
            internal const string PARAM_IN_DietiniationID = "IN_DietiniationID";
            internal const string PARAM_IV_RequestType = "IV_RequestType";
            internal const string PARAM_IC_DietInitationDetails = "IC_DietInitationDetails";
            internal const string PARAM_IV_LOGINID = "IV_LOGINID";
            internal const string PARAM_OV_DIETNO = "OV_DIETNO";
        }

        public class GetDietType
        {
            internal const string SPNAME = "Fb.P_GetDietTypeMaster";
            internal const string PARAM_in_DietID = "in_DietID";
            internal const string PARAM_iv_DietType = "iv_DietType";
            internal const string PARAM_iv_Colour = "iv_Colour";
            internal const string PARAM_iv_DietDesc = "iv_DietDesc";
            internal const string PARAM_iv_dietstatus = "iv_dietstatus";
            internal const string PARAM_in_LocationID = "in_LocationID";
            internal const string PARAM_ocursor_DietType = "ocursor_DietType";

        }


        //public class GetPatientPanelDetails
        //{
        //    internal const string SPNAME = "P_GETPATIENTPANELDETAILS";
        //    internal const string PARAM_IV_UHID = "IV_UHID";
        //    internal const string PARAM_IV_PRN = "IV_PRN";
        //    internal const string PARAM_IV_ERN = "IV_ERN";
        //    internal const string PARAM_OCURSOR_RESULT1 = "OCURSOR_RESULT1";
        //    internal const string PARAM_OCURSOR_RESULT2 = "OCURSOR_RESULT2";
        //    internal const string PARAM_OCURSOR_RESULT3 = "OCURSOR_RESULT3";
        //    internal const string PARAM_OCURSOR_RESULT4 = "OCURSOR_RESULT4";

        //}
        public class GetNationalityPatientType
        {
            internal const string SPNAME = "FNB.p_Getnationalitypatienttype";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_in_uhid = "in_uhid";
            internal const string PARAM_OCURSOR_Nationality = "OCURSOR_Nationality";

        }

        public class GetPatientDetails
        {
            internal const string SPNAME = "REGISTRATION.P_GETPATIENTDETAILS";
            internal const string PARAM_IN_REGISTRATIONNUMBER = "IN_REGISTRATIONNUMBER";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_PREREGISTRATIONNO = "IN_PREREGISTRATIONNO";
            internal const string PARAM_IN_EMERGENCYNO = "IN_EMERGENCYNO";
            internal const string PARAM_IV_TEMPDRAFTID = "IV_TEMPDRAFTID";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_MASTERFLAG = "IN_MASTERFLAG";
            internal const string PARAM_OCURSOR_COMPONENT1 = "OCURSOR_COMPONENT1";
            internal const string PARAM_OCURSOR_COMPONENT3 = "OCURSOR_COMPONENT3";
            internal const string PARAM_OCURSOR_COMPONENT4 = "OCURSOR_COMPONENT4";
            internal const string PARAM_OCURSOR_COMPONENT5 = "OCURSOR_COMPONENT5";
            internal const string PARAM_OCURSOR_COMPONENT6 = "OCURSOR_COMPONENT6";
            internal const string PARAM_OCURSOR_COMPONENT7 = "OCURSOR_COMPONENT7";
            internal const string PARAM_OCURSOR_COMPONENT8 = "OCURSOR_COMPONENT8";
            internal const string PARAM_OCURSOR_COMPONENT9 = "OCURSOR_COMPONENT9";
            internal const string PARAM_OCURSOR_COMPONENT10 = "OCURSOR_COMPONENT10";
            internal const string PARAM_OCURSOR_COMPONENT11 = "OCURSOR_COMPONENT11";
            internal const string PARAM_OCURSOR_COMPONENT12 = "OCURSOR_COMPONENT12";
            internal const string PARAM_OCURSOR_COMPONENT13 = "OCURSOR_COMPONENT13";
            internal const string PARAM_OCURSOR_COMPONENT14 = "OCURSOR_COMPONENT14";
            internal const string PARAM_OCURSOR_COMPONENT15 = "OCURSOR_COMPONENT15";
            internal const string PARAM_OCURSOR_COMPONENT16 = "OCURSOR_COMPONENT16";
            internal const string PARAM_OCURSOR_COMPONENT17 = "OCURSOR_COMPONENT17";
            internal const string PARAM_OCURSOR_COMPONENT18 = "OCURSOR_COMPONENT18";
            internal const string PARAM_OCURSOR_ALTUID = "OCURSOR_ALTUID";

        }
        public class AddLiquidTemplate
        {
            internal const string SPNAME = "FNB.P_ADDLIQUIDTEMPLATE";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_SERVICENO = "IV_SERVICENO";
            internal const string PARAM_IN_DietInitiationID = "IN_DietInitiationID";
            internal const string PARAM_IN_MENUNAMEID = "IN_MENUNAMEID";
            internal const string PARAM_IN_DIETTYPEID = "IN_DIETTYPEID";
            internal const string PARAM_ID_DATE = "ID_DATE";
            internal const string PARAM_IV_LOGINID = "IV_LOGINID";
        }
        public class CancelPreviousDiets
        {
            internal const string SPNAME = "ACE.p_CancelPreviousDiets";
            internal const string PARAM_iv_BTK = "iv_BTK";
            internal const string PARAM_Iv_LoginID = "Iv_LoginID";

        }
        public class GetDietInitiation
        {
            internal const string SPNAME = "FB.P_GETDIETINITIATION";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_SERVICENO = "IV_SERVICENO";
            internal const string PARAM_IN_DietInitiationID = "IN_DietInitiationID";
            internal const string PARAM_IV_RequestType = "IV_RequestType";
            internal const string PARAM_ocursor_MealType = "ocursor_MealType";
            internal const string PARAM_ocursor_DietType = "ocursor_DietType";
            internal const string PARAM_ocursor_Appetite = "ocursor_Appetite";
            internal const string PARAM_ocursor_IngredientName = "ocursor_IngredientName";
            internal const string PARAM_OCursor_CurrentDraft = "OCursor_CurrentDraft";
            internal const string PARAM_OCursor_CurrentRecord = "OCursor_CurrentRecord";
            internal const string PARAM_OCursor_PreviousRecord = "OCursor_PreviousRecord";
            internal const string PARAM_OCursor_CancelRecord = "OCursor_CancelRecord";
            internal const string PARAM_ocursor_patientdiettye = "ocursor_patientdiettye";
            internal const string PARAM_ocursor_patientmealtype = "ocursor_patientmealtype";
            internal const string PARAM_ocursor_patientpreference = "ocursor_patientpreference";

        }
        public class SaveNutritionalAssessment
        {
            internal const string SPNAME = "Fb.P_SAVENUTRITIONALASSESSMENT";
            internal const string PARAM_IN_DietiniationID = "IN_DietiniationID";
            internal const string PARAM_IN_REASONFORMODIFICATION = "IN_REASONFORMODIFICATION";
            internal const string PARAM_IV_LOGINID = "IV_LOGINID";
            internal const string PARAM_ON_NUTRITIONALASSESMENTID = "ON_NUTRITIONALASSESMENTID";

        }

        public class ShowBedAllocationStatus
        {
            internal const string SPNAME = "Fb.P_SHOWBEDSTATUS";
            internal const string PARAM_IC_DieticianDetails = "IC_DieticianDetails";
            internal const string PARAM_OCursor_BEDSTATUS = "OCursor_BEDSTATUS";

        }
        public class UpdateAllergy
        {
            internal const string SPNAME = "REGISTRATION.p_updateallergy";
            internal const string PARAM_in_registrationid = "in_registrationid";
            internal const string PARAM_ic_allergyxml = "ic_allergyxml";
            internal const string PARAM_iv_loginid = "iv_loginid";
        }
        public class GetRegistrationID
        {
            internal const string SPNAME = "REGISTRATION.p_GetRegistrationID";
            internal const string PARAM_iv_UHID = "iv_UHID";
            internal const string PARAM_on_RegistrationID = "on_RegistrationID";
        }
        public class GetPageBusinessKeys
        {
            internal const string SPNAME = "process.P_GetPageBusinessKeys";
            internal const string PARAM_Iv_PageName = "Iv_PageName";
            internal const string PARAM_Iv_BusinessModuleID = "Iv_BusinessModuleID";
            internal const string PARAM_OCursor_BusinessKeys = "OCursor_BusinessKeys";
        }
        public class GetProcessFlow
        {
            internal const string SPNAME = "process.P_GETPROCESSFLOW";
            internal const string PARAM_in_ProcessFlowID = "in_ProcessFlowID";
            internal const string PARAM_in_BusinessModuleID = "in_BusinessModuleID";
            internal const string PARAM_in_Entryactivityid = "in_Entryactivityid";
            internal const string PARAM_oCursor_PRocessFlows = "oCursor_PRocessFlows";
        }
        public class GetProcessFlowDetails
        {
            internal const string SPNAME = "process.P_GetProcessFlowDetails";
            internal const string PARAM_Iv_BusinessKey = "Iv_BusinessKey";
            internal const string PARAM_In_PFTransID = "In_PFTransID";
            internal const string PARAM_Iv_BusinessTransKey = "Iv_BusinessTransKey";
            internal const string PARAM_In_ProcessFlowID = "In_ProcessFlowID";
            internal const string PARAM_OCursor_ProcessFlow = "OCursor_ProcessFlow";
            internal const string PARAM_OCursor_ActivityStatus = "OCursor_ActivityStatus";
            internal const string PARAM_OCursor_SUBPROCESS = "OCursor_SUBPROCESS";
        }
        public class GetProcessFlowDetailsDIET
        {
            internal const string SPNAME = "P_GetProcessFlowDetailsDIET";
            // internal const string SPNAME = "P_GetProcessFlowDetails_DIET";
            internal const string PARAM_Iv_BusinessKey = "Iv_BusinessKey";
            internal const string PARAM_In_PFTransID = "In_PFTransID";
            internal const string PARAM_Iv_BusinessTransKey = "Iv_BusinessTransKey";
            internal const string PARAM_In_ProcessFlowID = "In_ProcessFlowID";
            internal const string PARAM_OCursor_ProcessFlow = "OCursor_ProcessFlow";
            internal const string PARAM_OCursor_ActivityStatus = "OCursor_ActivityStatus";
            internal const string PARAM_OCursor_SUBPROCESS = "OCursor_SUBPROCESS";
        }
        public class GetProcessFlowServices
        {
            internal const string SPNAME = "process.P_GetProcessFlowServices";
            internal const string PARAM_In_ProcessFlowID = "In_ProcessFlowID";
            internal const string PARAM_OCursor_PFServices = "OCursor_PFServices";
        }
        public class CheckActivityStatus
        {
            internal const string SPNAME = "process.P_CheckActivityStatus";
            internal const string PARAM_In_ActivityID = "In_ActivityID";
            internal const string PARAM_In_StatusID = "In_StatusID";
            internal const string PARAM_On_Result = "On_Result";
        }
        public class AddProcessFlowInstance
        {
            internal const string SPNAME = "process.P_AddProcessFlowInstance";
            internal const string PARAM_In_ProcessFlowID = "In_ProcessFlowID";
            internal const string PARAM_Iv_IDXML = "Iv_IDXML";
            internal const string PARAM_Iv_LoginID = "Iv_LoginID";
            internal const string PARAM_On_PFInstanceID = "On_PFInstanceID";
        }
        public class ADDSUBPROCESSINSTANCE
        {
            internal const string SPNAME = "process.P_ADDSUBPROCESSINSTANCE";
            internal const string PARAM_in_ProcessFlowInstanceID = "in_ProcessFlowInstanceID";
            internal const string PARAM_in_ProcessFlowTransID = "in_ProcessFlowTransID";
            internal const string PARAM_iv_LoginID = "iv_LoginID";
        }
        public class AddProcessFlowTrans
        {
            internal const string SPNAME = "process.P_AddProcessFlowTrans";
            internal const string PARAM_In_PFInstanceID = "In_PFInstanceID";
            internal const string PARAM_In_CurrentPFTransID = "In_CurrentPFTransID";
            internal const string PARAM_In_ActivityID = "In_ActivityID";
            internal const string PARAM_In_ServiceID = "In_ServiceID";
            internal const string PARAM_Iv_LoginID = "Iv_LoginID";
            internal const string PARAM_On_PFTransID = "On_PFTransID";
        }
        public class AddProcessFlowTransDIET
        {

            internal const string SPNAME = "process.P_AddProcessFlowTrans_DIET";
            internal const string PARAM_In_PFInstanceID = "In_PFInstanceID";
            internal const string PARAM_In_CurrentPFTransID = "In_CurrentPFTransID";
            internal const string PARAM_In_ActivityID = "In_ActivityID";
            internal const string PARAM_In_ServiceID = "In_ServiceID";
            internal const string PARAM_Iv_LoginID = "Iv_LoginID";
            internal const string PARAM_Iv_IPNUMBER = "Iv_IPNUMBER";
            internal const string PARAM_Iv_DIETINITIATIONID = "Iv_DIETINITIANTIONNO";
            internal const string PARAM_Iv_WARDID = "Iv_WardID";
            internal const string PARAM_Iv_LOCATIONID = "Iv_LOCATIONID";
            internal const string PARAM_On_PFTransID = "On_PFTransID";


        }
        public class SetPFTransWIP
        {
            internal const string SPNAME = "process.P_SetPFTransWIP";
            internal const string PARAM_in_ProcessFlowTransID = "in_ProcessFlowTransID";
            internal const string PARAM_iv_OriginalWIPBy = "iv_OriginalWIPBy";
            internal const string PARAM_iv_LoginID = "iv_LoginID";
            internal const string PARAM_on_Success = "on_Success";
        }
        public class SetPFTransWIPDIET
        {
            internal const string SPNAME = "process.P_SetPFTransWIPDIET";
            internal const string PARAM_in_ProcessFlowTransID = "in_ProcessFlowTransID";
            internal const string PARAM_iv_OriginalWIPBy = "iv_OriginalWIPBy";
            internal const string PARAM_iv_LoginID = "iv_LoginID";
            internal const string PARAM_on_Success = "on_Success";
        }
        public class SetPrefferedUsers
        {
            internal const string SPNAME = "process.P_SETPREFFEREDUSERS";
            internal const string PARAM_In_PROCESSFLOWTRANSID = "In_PROCESSFLOWTRANSID";
            internal const string PARAM_Iv_LoginID = "Iv_LoginID";
        }
        public class SetPrefferedUsersDIET
        {
            internal const string SPNAME = "process.P_SETPREFFEREDUSERSDIET";
            internal const string PARAM_In_PROCESSFLOWTRANSID = "In_PROCESSFLOWTRANSID";
            internal const string PARAM_Iv_LoginID = "Iv_LoginID";
        }
        public class UpdateDietStatus
        {
            internal const string SPNAME = "wards.P_UPDATEDIETSTARTEDFLAG";
            internal const string PARAM_iv_DietStarted = "iv_DietStarted";
            internal const string PARAM_iv_IPNumber = "iv_IPNumber";
            internal const string PARAM_iv_LogInId = "iv_LogInId";
        }
        public class SetPrevPfInstanceComplete
        {
            internal const string SPNAME = "process.P_SETPREVPFINSTANCECOMPLETE";
            internal const string PARAM_IV_BUSINESSTRANSKEY = "IV_BUSINESSTRANSKEY";
        }
        public class SetPrevPfInstanceCompletediet
        {
            internal const string SPNAME = "process.P_SETPREVPFINSTANCECOMPDIET";
            internal const string PARAM_IV_BUSINESSTRANSKEY = "IV_BUSINESSTRANSKEY";
        }
        public class UpdatePFOnNewDietInitiation
        {
            internal const string SPNAME = "process.P_UPDATEPFONNEWDIETINITIATION";
            internal const string PARAM_IN_DIN = "in_din";
        }
        public class UpdatePFOnNewDietInitiation_diet
        {
            internal const string SPNAME = "P_UPDATEPFTDNEWDIETINITIATION";
            internal const string PARAM_IN_DIN = "in_din";
        }
        public class SetPFTransStatus
        {
            internal const string SPNAME = "process.P_SetPFTransStatus";
            internal const string PARAM_In_ProcessFlowTransID = "In_ProcessFlowTransID";
            internal const string PARAM_In_BusinessTransKey = "In_BusinessTransKey";
            internal const string PARAM_In_StatusID = "In_StatusID";
            internal const string PARAM_ixml_TransIDXML = "ixml_TransIDXML";
            internal const string PARAM_Iv_LoginID = "Iv_LoginID";
            internal const string PARAM_Iv_ToolTipInfo = "Iv_ToolTipInfo";
            internal const string PARAM_ICLOB_Attachments = "ICLOB_Attachments";
            internal const string PARAM_Ov_Success = "Ov_Success";
        }
        public class SetPFTransStatusDIET
        {
            // internal const string SPNAME = "P_SetPFTransStatus";
            internal const string SPNAME = "process.P_SetPFTransStatusDIET";
            internal const string PARAM_In_ProcessFlowTransID = "In_ProcessFlowTransID";
            internal const string PARAM_In_BusinessTransKey = "In_BusinessTransKey";
            internal const string PARAM_In_StatusID = "In_StatusID";
            internal const string PARAM_ixml_TransIDXML = "ixml_TransIDXML";
            internal const string PARAM_Iv_LoginID = "Iv_LoginID";
            internal const string PARAM_Iv_ToolTipInfo = "Iv_ToolTipInfo";
            internal const string PARAM_ICLOB_Attachments = "ICLOB_Attachments";
            internal const string PARAM_Ov_Success = "Ov_Success";
        }
        public class GetPF_WF_Expressions
        {
            internal const string SPNAME = "process.P_GETPF_WF_EXPRESSIONS";
            internal const string PARAM_in_ProcessFlowID = "in_ProcessFlowID";
            internal const string PARAM_in_ActivityID = "in_ActivityID";
            internal const string PARAM_in_ServiceID = "in_ServiceID";
            internal const string PARAM_in_StatusID = "in_StatusID";
            internal const string PARAM_oCursor_GetExprs = "oCursor_GetExprs";
        }
        public class SetPFTransComplete
        {
            internal const string SPNAME = "process.P_SETPFTRANSCOMPLETE";
            internal const string PARAM_IN_PROCESSFLOWTRANSID = "IN_PROCESSFLOWTRANSID";
            internal const string PARAM_IV_WORKFLOWSTATE = "IV_WORKFLOWSTATE";
            internal const string PARAM_IV_LOGINID = "IV_LOGINID";
        }
        public class SetPFTransDIETComplete
        {
            internal const string SPNAME = "P_SETPFTRANSDIETCOMPLETE";
            internal const string PARAM_IN_PROCESSFLOWTRANSID = "IN_PROCESSFLOWTRANSID";
            internal const string PARAM_IV_WORKFLOWSTATE = "IV_WORKFLOWSTATE";
            internal const string PARAM_IV_LOGINID = "IV_LOGINID";
        }
        public class UpdateDItoLiquidTemplateMaster
        {
            internal const string SPNAME = "fb.p_AddoUpdateLDTForDI";
            internal const string PARAM_IN_DietInitID = "IN_DietInitID";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_ServiceNumber = "IN_ServiceNumber";
            internal const string PARAM_IN_DietTypeID = "IN_DietTypeID";
            internal const string PARAM_IN_Date = "IN_Date";
            internal const string PARAM_IN_LoginID = "IN_LoginID";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
        }
        public class UpdateLiquidToNormalTemplate
        {
            internal const string SPNAME = "fb.P_UPDATELIQUIDTONORMAL";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_SERVICENO = "IV_SERVICENO";
            internal const string PARAM_ID_DATE = "ID_DATE";
        }
        public class UpdateNormalToLiquid
        {
            internal const string SPNAME = "fb.P_UPDATENORMALTOLIQUID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_SERVICENO = "IV_SERVICENO";
        }
        public class UpdateDietRequestStatus
        {
            internal const string SPNAME = "fb.P_UpdateDietRequestStatus";
            internal const string PARAM_iv_DietinitiationID = "iv_DietinitiationID";
            internal const string PARAM_iv_LocationID = "iv_LocationID";
        }
        public class TransDietModification
        {
            internal const string SPNAME = "process.P_TRANSDIETMODIFICATION";
            internal const string PARAM_IN_DIN = "IN_DIN";
        }
        public class TransDietModification_DIET
        {
            internal const string SPNAME = "P_TRANSDIETMODIFICATIONDIET";
            internal const string PARAM_IN_DIN = "IN_DIN";
        }
        public class SearchPatientDetailsFromAT
        {
            internal const string SPNAME = "fb.P_SearchPatientDetailsFromAT";
            internal const string PARAM_iv_UHID = "iv_UHID";
            internal const string PARAM_iv_PRN = "iv_PRN";
            internal const string PARAM_iv_ERN = "iv_ERN";
            internal const string PARAM_id_DateOfAdmission = "id_DateOfAdmission";
            internal const string PARAM_iv_WaitingListNo = "iv_WaitingListNo";
            internal const string PARAM_iv_BookNo = "iv_BookNo";
            internal const string PARAM_iv_InpatientNo = "iv_InpatientNo";
            internal const string PARAM_iv_FirstName = "iv_FirstName";
            internal const string PARAM_iv_MiddleName = "iv_MiddleName";
            internal const string PARAM_iv_LastName = "iv_LastName";
            internal const string PARAM_in_LocationID = "in_LocationID";
            internal const string PARAM_id_FromDateOfBooking = "id_FromDateOfBooking";
            internal const string PARAM_id_ToDateOfBooking = "id_ToDateOfBooking";
            internal const string PARAM_iv_PatientStatus = "iv_PatientStatus";
            internal const string PARAM_in_leveldetailid = "in_leveldetailid";
            internal const string PARAM_in_fromAdmissionDate = "in_fromAdmissionDate";
            internal const string PARAM_in_toAdmissionDate = "in_toAdmissionDate";
            internal const string PARAM_in_AdmittingDr = "in_AdmittingDr";
            internal const string PARAM_in_bedcode = "in_bedcode";
            internal const string PARAM_oCursor_PatientDetails = "oCursor_PatientDetails";
        }
        public class GetDietRestriction
        {
            internal const string SPNAME = "fb.p_Getdietrestriction";
            internal const string PARAM_iv_dietrestrictionid = "iv_dietrestrictionid";
            internal const string PARAM_iv_dietrestriction = "iv_dietrestriction";
            internal const string PARAM_iv_description = "iv_description";
            internal const string PARAM_iv_location = "iv_location";
            internal const string PARAM_o_cursor = "o_cursor";
        }
        public class GetRestrictionCategory
        {
            internal const string SPNAME = "fb.p_Getrestrictioncategory";
            internal const string PARAM_iv_restrictioncategoryid = "iv_restrictioncategoryid";
            internal const string PARAM_iv_dietrestrictionid = "iv_dietrestrictionid";
            internal const string PARAM_iv_restrictioncategory = "iv_restrictioncategory";
            internal const string PARAM_iv_location = "iv_location";
            internal const string PARAM_o_cursor = "o_cursor";
        }
        public class GetPFExpressionWithNextActivity
        {
            internal const string SPNAME = "process.P_GETPFEXPRSWITHNEXTACTIVITY";
            internal const string PARAM_in_ProcessFlowID = "in_ProcessFlowID";
            internal const string PARAM_in_ActivityID = "iv_dietrestrictionid";
            internal const string PARAM_in_ServiceID = "iv_restrictioncategory";
            internal const string PARAM_in_StatusID = "in_StatusID";
            internal const string PARAM_oCursor_Expressions = "oCursor_Expressions";
        }
        public class GetBusinessMessageKeyValues
        {
            internal const string SPNAME = "process.p_getmessagekeys";
            internal const string PARAM_in_pfinstanceid = "in_pfinstanceid";
            internal const string PARAM_in_pftransid = "in_pftransid";
            internal const string PARAM_in_wftransid = "in_wftransid";
            internal const string PARAM_ocursor_messagekeys = "ocursor_messagekeys";
        }
        public class GetBusinessMessageKeyValuesDIET
        {
            // internal const string SPNAME = "p_getmessagekeys";
            internal const string SPNAME = "process.P_GetMessageKeysdiet";
            internal const string PARAM_in_pfinstanceid = "in_pfinstanceid";
            internal const string PARAM_in_pftransid = "in_pftransid";
            internal const string PARAM_in_wftransid = "in_wftransid";
            internal const string PARAM_ocursor_messagekeys = "ocursor_messagekeys";
        }

        #endregion

        #region SampleCollection
        public class SAMPLECOLLECTION
        {
            //GetUnits
            internal const string PARAM_IN_UNITID = "IN_UNITID";
            internal const string PARAM_OUT_OCURSOR_UNITDETAIL = "OREF_UNITDETAIL";
            internal const string GETUNITSNAME = "lab.P_VIEWUNITDETAILS";
            //GetUnits

            //GetLRNS
            internal const string PARAM_IN_LRN = "IN_LRN";
            internal const string PARAM_INP_SIN = "IN_SIN";
            internal const string PARAM_IN_LOGINID = "IN_LOGINID";
            internal const string PARAM_IN_EMPID = "IN_EMPID";
            internal const string PARAM_IN_LOCID = "IN_LOCATIONID";
            internal const string PARAM_IN_PATIENTSERVICE = "IV_PATIENTSERVICE";
            internal const string PARAM_IN_IPNUM = "IV_PATIENTSERVICENO";
            internal const string PARAM_OUT_OCURSOR_LRNS = "OREF_MYLRNS";
            internal const string PARAM_OUT_OCURSOR_TESTS = "OREF_MYTASKCURSOR";
            internal const string GETLRNSP = "lab.P_GETIPREQUESTEDLRNS";
            internal const string GETTESTSSP = "lab.P_GETTESTSFORLRN";
            //GetLRNS

            //GetServiceNames
            internal const string PARAM_IN_SERVICEID = "iCLOB_serviceid";
            internal const string PARAM_IN_SERVICETYPEID = "In_servicetypeid";
            internal const string PARAM_OUT_OCURSOR_SERVICENAMES = "ocur_servicenames";
            internal const string GETSERVICESP = "billing.P_GETLABSERVICES";
            //GetServiceNames


            //SampleCollection
            internal const string PARAM_IN_CLOB_SAMPLECOLLECTION = "iclob_SampleCollection";
            internal const string PARAM_OUT_RETURNCODE = "on_ReturnCode";
            internal const string SAVESAMPLESP = "lab.P_ADDSAMPLECOLLECTION";
            //SampleCollection

            //UpdateRaisedServiceStatus
            internal const string PARAM_IN_CLOB_SERVICE = "iXMLUpdateServices";
            internal const string UPDATESERVICEREQUESTSP = "billing.P_UPDATESERVICEREQUEST";
            //UpdateRaisedServiceStatus

            //UPdateServiceStatus
            internal const string PARAM_IN_CLOB_CANCELSERVICE = "iXMLCancelledServices";
            internal const string UPDATESERVICESTATUS = "billing.P_UPDATESERVICESTATUS_DG";
            //UPdateServiceStatus

            //GenerateNewSIN
            internal const string PARAM_IN_REQTESTID = "Iv_REQUESTTESTID";
            internal const string PARAM_IN_SIN = "Iv_SIN";
            internal const string PARAM_OUT_NEWSIN = "OV_NEWSIN";
            internal const string GENERATESIN = "LAB.P_UPDATE_SIN_LABEL";
            //GenerateNewSIN

        }
        #endregion

        public class GETLHKJOBTYPE
        {
            internal const string SPNAME = "LHK.P_GET_LHKSERVICEMASTER";
            internal const string PARAM_IN_SERVICEID = "IN_SERVICEID";
            internal const string PARAM_IN_SERVICENAME = "IV_SERVICENAME";
            internal const string PARAM_IN_SERVICEDESC = "IV_SERVICEDESC";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_LHKJOBTYPE = "O_CURSOR";
        }


        public class GETLHKREQUESTFOR
        {
            internal const string SPNAME = "LHK.P_GETLHKSERVICEDETAILMASTER";
            internal const string PARAM_IN_SERVICEDETAILID = "IN_SERVICEDETAILID";
            internal const string PARAM_IN_SERVICEID = "IN_SERVICEID";
            internal const string PARAM_IV_SERVICENAME = "IV_SERVICENAME";
            internal const string PARAM_IV_SERVICEDETAILNAME = "IV_SERVICEDETAILNAME";
            internal const string PARAM_IV_SERVICEDETAILDESC = "IV_SERVICEDETAILDESC";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_BILLABLE = "IN_BILLABLE";
            internal const string PARAM_IN_TARIFF = "IN_TARIFF";
            internal const string PARAM_OUT_LHKREQUESTFOR = "O_CURSOR";
        }
        public class GETLHKTOLOCATION
        {
            internal const string SPNAME = "LHK.P_GetFacilityLocations";
            internal const string PARAM_iv_roomid = "iv_roomid";
            internal const string PARAM_iv_deptid = "iv_deptid";
            internal const string PARAM_iv_Location = "iv_Location";
            internal const string PARAM_OUT_LHKTOLOCATION = "O_CURSOR";
        }

        public class SAVELHKRAISEREQUEST
        {
            internal const string SPNAME = "LHK.P_SAVE_UPD_DEL_LHKREQUEST";
            internal const string PARAM_IV_REQUESTNO = "IV_REQUESTNO";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_PATIENTSERVICENUMBER = "IV_PATIENTSERVICENUMBER";
            internal const string PARAM_IV_JOBTYPE = "IV_JOBTYPE";
            internal const string PARAM_IV_JOBPRIORITY = "IV_JOBPRIORITY";
            internal const string PARAM_IV_REQUIREDAT = "IV_REQUIREDAT";
            internal const string PARAM_IV_REQUIREDDATE = "IV_REQUIREDDATE";
            internal const string PARAM_IV_REQUIREDTIME = "IV_REQUIREDTIME";
            internal const string PARAM_IV_SURGERYDATE = "IV_SURGERYDATE";
            internal const string PARAM_IV_SURGERYTIME = "IV_SURGERYTIME";
            internal const string PARAM_IV_STATUS = "IV_STATUS";
            internal const string PARAM_IV_LOCATION = "IV_LOCATION";
            internal const string PARAM_IV_RAISEDBY = "IV_RAISEDBY";
            internal const string PARAM_IV_RAISEDDATE = "IV_RAISEDDATE";
            internal const string PARAM_IV_MODIFIEDBY = "IV_MODIFIEDBY";
            internal const string PARAM_IV_MODIFIEDDATE = "IV_MODIFIEDDATE";
            internal const string PARAM_IV_ISSUEBILLING = "IV_ISSUEBILLING";
            internal const string PARAM_IV_REMARKS = "IV_REMARKS";
            internal const string PARAM_IV_FLAG = "IV_FLAG";
            internal const string PARAM_OV_GENERATEDREQUESTNO = "OV_GENERATEDREQUESTNO";
            internal const string PARAM_ICLOB_REQUEST = "ICLOB_REQUEST";
            internal const string PARAM_IV_SPECIALNOTE = "IV_SPECIALNOTE";
            internal const string PARAM_IV_REQUESTFOR = "IV_REQUESTFOR";
            internal const string PARAM_IV_TOLOCATION = "IV_TOLOCATION";
            internal const string PARAM_IV_QUANTITY = "IV_QUANTITY";
            internal const string PARAM_IN_JOBTYPEID = "IN_JOBTYPEID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_COMPLETEDBY = "IV_COMPLETEDBY";
        }

        public class GETLHKPATIENTPANEL
        {
            internal const string SPNAME = "EHIS.P_GETPATIENTPANELDETAILS";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_PRN = "IV_PRN";
            internal const string PARAM_IV_ERN = "IV_ERN";
            internal const string PARAM_OUT_PATIENTDETAILS = "OCURSOR_RESULT1";
            internal const string PARAM_OUT_ALLERGYDETAILS = "OCURSOR_RESULT2";
            internal const string PARAM_OUT_LOCATIONDETAILS = "OCURSOR_RESULT3";
            internal const string PARAM_OUT_AHCDETAILS = "OCURSOR_RESULT4";
        }

        public class GETLHKPREVIOUSREQUEST
        {
            internal const string SPNAME = "LHK.P_GETPREVIOUSREQUEST";
            internal const string PARAM_IN_IPNO = "IN_IPNO";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_JOBTYPEID = "IN_JOBTYPEID";
            internal const string PARAM_IN_RAISEDDATE = "IN_RAISEDDATE";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_LHKPREVIOUSREQUEST = "O_CURSOR";
        }

        #region ATTENDANT SERVICES
        public class DG_ATTENDANTSERVICES
        {
            internal const string PARAM_IN_LOCID = "in_LocationID";
            //internal const string PARAM_IN_FOODCATID = "in_FoodItemCategoryID";
            internal const string PARAM_IN_FOODCAT = "iv_FoodItemCategory";
            internal const string PARAM_IN_FOODCATDESC = "iv_FoodItemCategoryDescription";
            internal const string PARAM_OUT_OCURSOR_FOODCATEGORIES = "ocursor_FoodItemCategory";
            internal const string GETFOODCATEGORIESspNAME = "fb.P_GetFoodItemCategoryMaster";

            internal const string PARAM_IN_ROOMTYPEID = "iv_RoomTypeID";
            internal const string PARAM_OUT_OCURSOR_ROOMS = "ov_cursorRoomList";
            internal const string GETROOMS = "fb.p_GetRoomMaster";

            internal const string PARAM_OUT_OCURSOR_FOODITEMS = "ocursor_FoodItem";
            internal const string GETFOOODITEMS = "fb.P_GetFoodItemOnFoodCategory";

            internal const string PARAM_IN_ITMPRICEID = "in_ItemPriceID";
            internal const string PARAM_IN_ITMPRICE = "in_FoodItemPrice";
            internal const string PARAM_OUT_OCURSOR_FOODITEMPRICE = "ocursor_FoodItemPrice";
            internal const string GETPRICESP = "fb.P_GetFoodItemPriceMaster";

            internal const string GETPATIENTDETAILS = "adt.P_SEARCHPATIENTDETAILS";

            internal const string GETPROCESSFLOW = "process.P_SETPFTRANSSTATUSCHECKOUT";

            internal const string PARAM_IN_FNBSERVICETYPEID = "IN_FNBSERVICETYPEID";
            internal const string PARAM_IN_CLOB_FNBSERVICES = "IC_FNBSERVICES";
            internal const string PARAM_IN_OUT_FNBID = "ON_FNBSERVICES";

        }
        #endregion

        #region MRD Activity

        public class Getpriority
        {
            internal const string SPNAME = "EHIS.P_GetLOVDetail";
            internal const string PARAM_LovCode = "iv_LOVCode";
            internal const string PARAM_OUT_LovDetail = "oCursor_LovDetail";
        }
        public class GetRooms
        {
            internal const string SPNAME = "WARDS.P_GETROOMANDTYPE";
            internal const string PARAM_ROOMTYPEID = "IN_ROOMTYPEID";
            internal const string PARAM_DEPTID = "IN_DEPTID";
            internal const string PARAM_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_OC_ROOMANDTYPE = "OC_ROOMANDTYPE";
        }
        public class GETREGISTRATIONDETAILS
        {
            internal const string SPNAME = "REGISTRATION.P_GETPATIENTDETAILS";
            internal const string PARAM_IN_REGISTRATIONNUMBER = "IN_REGISTRATIONNUMBER";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_PREREGISTRATIONNO = "IN_PREREGISTRATIONNO";
            internal const string PARAM_IN_EMERGENCYNO = "IN_EMERGENCYNO";
            internal const string PARAM_IV_TEMPDRAFTID = "IV_TEMPDRAFTID";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_MASTERFLAG = "IN_MASTERFLAG";
            internal const string PARAM_OUT_OCURSOR_COMPONENT1 = "OCURSOR_COMPONENT1";
            internal const string PARAM_OUT_OCURSOR_COMPONENT3 = "OCURSOR_COMPONENT3";
            internal const string PARAM_OUT_OCURSOR_COMPONENT4 = "OCURSOR_COMPONENT4";
            internal const string PARAM_OUT_OCURSOR_COMPONENT5 = "OCURSOR_COMPONENT5";
            internal const string PARAM_OUT_OCURSOR_COMPONENT6 = "OCURSOR_COMPONENT6";
            internal const string PARAM_OUT_OCURSOR_COMPONENT7 = "OCURSOR_COMPONENT7";
            internal const string PARAM_OUT_OCURSOR_COMPONENT8 = "OCURSOR_COMPONENT8";
            internal const string PARAM_OUT_OCURSOR_COMPONENT9 = "OCURSOR_COMPONENT9";
            internal const string PARAM_OUT_OCURSOR_COMPONENT10 = "OCURSOR_COMPONENT10";
            internal const string PARAM_OUT_OCURSOR_COMPONENT11 = "OCURSOR_COMPONENT11";
            internal const string PARAM_OUT_OCURSOR_COMPONENT12 = "OCURSOR_COMPONENT12";
            internal const string PARAM_OUT_OCURSOR_COMPONENT13 = "OCURSOR_COMPONENT13";
            internal const string PARAM_OUT_OCURSOR_COMPONENT14 = "OCURSOR_COMPONENT14";
            internal const string PARAM_OUT_OCURSOR_COMPONENT15 = "OCURSOR_COMPONENT15";
            internal const string PARAM_OUT_OCURSOR_COMPONENT16 = "OCURSOR_COMPONENT16";
            internal const string PARAM_OUT_OCURSOR_COMPONENT17 = "OCURSOR_COMPONENT17";
            internal const string PARAM_OUT_OCURSOR_COMPONENT18 = "OCURSOR_COMPONENT18";
            internal const string PARAM_OUT_OCURSOR_ALTUID = "OCURSOR_ALTUID";
        }
        public class GetPatientIdentifiers
        {
            internal const string SPNAME = "WARDS.P_GETALLPATIENTIDENTIFERS";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUT_OCURSOR_ALLPATIENTSLIST = "OCURSOR_ALLPATIENTSLIST";
        }
        public class GetMRDFilelocation
        {
            internal const string SPNAME = "WARDS.P_GETMRDSTORE";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_LOCATIONID = "IN_LOCATION";
            internal const string PARAM_OUT_CUR = "OUT_CUR";
        }
        public class GetMRDRequest
        {
            internal const string SPNAME = "WARDS.p_getmrdrequest";
            internal const string PARAM_iv_mrdid = "iv_mrdid";
            internal const string PARAM_iv_uhid = "iv_uhid";
            internal const string PARAM_iv_loginid = "iv_loginid";
            internal const string PARAM_iv_locationid = "iv_locationid";
            internal const string PARAM_iv_transactionstatus = "iv_transactionstatus";
            internal const string PARAM_iv_requeststatus = "iv_requeststatus";
            internal const string PARAM_id_fromdate = "id_fromdate";
            internal const string PARAM_id_todate = "id_todate";
            internal const string PARAM_iv_requestpage = "iv_requestpage";
            internal const string PARAM_OUT_ocursor_mrdrequest = "ocursor_mrdrequest";
            internal const string PARAM_OUT_ocursor_mrdallrequest = "ocursor_mrdallrequest";
            internal const string PARAM_OUT_ocursor_recordstatus = "ocursor_recordstatus";
        }
        public class GETONCALLESDETAILS
        {
            internal const string SPNAME = "HR.P_GETONCALLESDETAILS";
            internal const string PARAM_IN_DOCTORID = "IN_DOCTORID";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_COUNTERID = "IN_COUNTERID";
            internal const string PARAM_IN_ROOMID = "IN_ROOMID";
            internal const string PARAM_IN_ONCALL = "IN_ONCALL";
            internal const string PARAM_IN_SPECIALITYID = "IN_SPECIALITYID";
            internal const string PARAM_IN_ONCALLDATE = "IN_ONCALLDATE";
            internal const string PARAM_OUT_OCURSOR_ONCALLDETAILS = "OCURSOR_ONCALLDETAILS";
        }
        public class GETPREVIOUSMRDREQUEST
        {
            internal const string SPNAME = "WARDS.P_GETPREVIOUSMRDREQUEST";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_ID_FROMDATE = "ID_FROMDATE";
            internal const string PARAM_ID_TODATE = "ID_TODATE";
            internal const string PARAM_OUT_OCURSOR_MRDREQUEST = "OCURSOR_MRDREQUEST";
        }
        public class ADDMRDRAISEREQUEST
        {
            internal const string SPNAME = "WARDS.P_ADDMRDRAISEREQUEST";
            internal const string PARAM_ICLOB_MRDREQUEST = "ICLOB_MRDREQUEST";
            internal const string PARAM_ON_MRDID = "ON_MRDID";
        }
        public class CANCELMRDREQUEST
        {
            internal const string SPNAME = "WARDS.P_CANCELMRDREQUEST";
            internal const string PARAM_IN_MRDID = "IN_MRDID";
            internal const string PARAM_IN_MRDDETAILID = "IN_MRDDETAILID";
            internal const string PARAM_IV_REQUESTPAGE = "IV_REQUESTPAGE";
            internal const string PARAM_IV_LOGINID = "IV_LOGINID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_REASON = "IV_REASON";
        }
        public class UPDATEMRDREQUEST
        {
            internal const string SPNAME = "WARDS.P_UPDATEMRDDOCTORWORKLIST";
            internal const string PARAM_ICLOB_MRDREQUEST = "ICLOB_MRDREQUEST";
            internal const string PARAM_IN_ACTION = "IN_ACTION";
        }
        #endregion

        #region TransfusionFeedback

        public class AddTransfusionFeedbackDetails
        {
            internal const string SPNAME = "BB.P_AddTransfusionFeedbackDetail";
            internal const string PARAM_iCLOB_FeedbackDetails = "iCLOB_FeedbackDetails";
            internal const string PARAM_iv_LoginID = "iv_LoginID";
            internal const string PARAM_on_TransfusionFeedbackID = "on_TransfusionFeedbackID";

        }
        public class AddVitalMonitoringDetails
        {

            internal const string SPNAME = "BB.P_AddTransRecordVitalDetails";
            internal const string PARAM_iCLOB_VitalDetails = "iCLOB_VitalDetails";
            internal const string PARAM_iv_LoginID = "iv_LoginID";
            internal const string PARAM_iv_bloodbagid = "iv_bloodbagid";
            internal const string PARAM_iv_uhid = "iv_uhid";
            internal const string PARAM_iv_locationid = "iv_locationid";

        }

        public class GetUnitsDetail
        {
            internal const string SPNAME = "BB.P_GetUnitsDetail";
            internal const string PARAM_iv_UnitCode = "iv_UnitCode";
            internal const string PARAM_iv_UnitDetailName = "iv_UnitDetailName";
            internal const string PARAM_ocursor_UnitsDetail = "ocursor_UnitsDetail";
        }
        public class GetStatusMaster
        {
            internal const string SPNAME = "BB.P_GetStatusMaster";
            internal const string PARAM_in_StatusTypeID = "in_StatusTypeID";
            internal const string PARAM_iv_StatusName = "iv_StatusName";
            internal const string PARAM_ocursor_Status = "ocursor_Status";
        }
        public class GetBBagsAllocatedForReqNo
        {
            internal const string SPNAME = "BB.p_getbagsallocatedforreqno";
            internal const string PARAM_in_bloodbagid = "in_bloodbagid";
            internal const string PARAM_iv_bloodbagnumber = "iv_bloodbagnumber";
            internal const string PARAM_iv_requestnumber = "iv_requestnumber";
            internal const string PARAM_iv_uhid = "iv_uhid";
            internal const string PARAM_in_bagstatusid = "in_bagstatusid";
            internal const string PARAM_in_locationid = "in_locationid";
            internal const string PARAM_ocursor_bloodbagreq = "ocursor_bloodbagreq";
        }
        public class GetTransfusionFeedback
        {
            internal const string SPNAME = "BB.p_GetTransfusionFeedback";
            internal const string PARAM_iv_UHID = "iv_UHID";
            internal const string PARAM_in_BloodBagID = "in_BloodBagID";
            internal const string PARAM_in_LocationID = "in_LocationID";
            internal const string PARAM_oCursor_FeedbackDetails = "oCursor_FeedbackDetails";
            internal const string PARAM_oCursor_VitalDetails = "oCursor_VitalDetails";
        }

        #endregion

        #region MMRequest
        public class MM_GetRegionId
        {
            internal const string SPNAME = "MM.P_GetRegionOnLocation";
            internal const string PARAM_in_chartId = "iv_chartId";
            internal const string PARAM_out_OCURSOR = "oCursor_Result";

        }
        public class MM_GETHOSPITALSTORENAME
        {
            internal const string SPNAME = "MM.P_GETHOSPITALSTORENAME";
            internal const string PARAM_in_LocationId = "iv_LocationId";
            internal const string PARAM_in_HospitalId = "iv_HospitalId";
            internal const string PARAM_out_oCursor_HospitalSTORES = "oCursor_HospitalSTORES";
            internal const string PARAM_out_oCursor_stores = "oCursor_stores";

        }
        public class MM_GETFROMDEPARTMENTNAME
        {
            internal const string SPNAME = "MM.P_GETSTOREUSERS";
            internal const string PARAM_in_LoginID = "iv_LoginID";
            internal const string PARAM_out_oCursor_Result = "oCursor_Result";
            internal const string PARAM_out_oCursor_DeptMappedLogins = "oCursor_DeptMappedLogins";
            internal const string PARAM_in_LocationID = "iv_LocationID";

        }
        public class MM_GETITEMCATEGORY
        {
            internal const string SPNAME = "MM.P_UC_GETITEMTYPECATEGORY";

            internal const string PARAM_out_oCursor_ItemType = "oCursor_ItemType";
            internal const string PARAM_out_oCursor_ItemCategory = "oCursor_ItemCategory";

        }
        public class MM_GETLOCATIONID
        {
            internal const string SPNAME = "MM.P_GETLOCATIONID";

            internal const string PARAM_iv_StoreCode = "iv_StoreCode";
            internal const string PARAM_iv_Status = "iv_Status";
            internal const string PARAM_iv_CostcenterCode = "iv_CostcenterCode";
            internal const string PARAM_oCursor_GetLocationId = "oCursor_GetLocationId";
            internal const string PARAM_oCursor_GetRegionId = "oCursor_GetRegionId";
            internal const string PARAM_oCursor_GetStoreCostcenter = "oCursor_GetStoreCostcenter";
            internal const string PARAM_oCursor_GetCostcenter = "oCursor_GetCostcenter";
            internal const string PARAM_oCursor_ItemCategory = "oCursor_ItemCategory";

        }
        public class GetItemTypeCategory
        {
            internal const string SPNAME = "MM.P_UC_GETITEMCATEGORY";
            internal const string PARAM_in_itemtype = "in_itemtype";
            internal const string PARAM_in_itemcategory = "in_itemcategory";
            internal const string PARAM_oCursor_ItemCategory = "oCursor_ItemCategory";
            internal const string PARAM_oCursor_ItemSubcategory1 = "oCursor_ItemSubcategory1";
        }
        public class DG_MMRaiseRequest
        {
            internal const string SPNAME = "MM.P_ADDINDENTS";
            internal const string PARAM_iCLOB_IndentDetails = "iCLOB_IndentDetails";
            internal const string PARAM_OUT_v_RetReceiveItemsCode = "v_RetReceiveItemsCode";

        }
        public class DG_SEQUENCEGENERATOR
        {
            internal const string SPNAME = "MM.P_SEQUENCEGENERATOR";
            internal const string PARAM_iv_code = "iv_code";
        }
        public class UC_SEARCHITEMS
        {
            internal const string SPNAME = "MM.P_UC_SEARCHITEMS";
            internal const string PARAM_iv_StoreCode = "iv_StoreCode";
            internal const string PARAM_iv_LocationId = "iv_LocationId";
            internal const string PARAM_iv_ShortDesc = "iv_ShortDesc";
            internal const string PARAM_iv_ItemCode = "iv_ItemCode";
            internal const string PARAM_iv_ItemCategory = "iv_ItemCategory";
            internal const string PARAM_iv_ParentStoreCode = "iv_ParentStoreCode";
            internal const string PARAM_iv_checkflag = "iv_checkflag";
            internal const string PARAM_iv_biscode = "iv_biscode";
            internal const string PARAM_iv_barcode = "iv_barcode";
            internal const string PARAM_iv_subcategory1 = "iv_subcategory1";
            //ADD by MURALI
            internal const string PARAM_iv_manufacturer = "iv_manufacturer";
            internal const string PARAM_iv_division = "iv_division";
            internal const string PARAM_iv_checkcpuuser = "iv_checkcpuuser";
            //ADD by MURALI
            internal const string PARAM_oCursor_GetItems = "oCursor_GetItems";
        }
        public class UC_GETITEMS
        {
            internal const string SPNAME = "MM.P_UC_GETITEMS";
            internal const string PARAM_IV_STORECODE = "IV_STORECODE";
            internal const string PARAM_iv_itemCodeFormat = "iv_itemCodeFormat";
            internal const string PARAM_oCursor_GetItems = "oCursor_GetItems";
            internal const string PARAM_iv_Parentstore = "iv_Parentstore";
            internal const string PARAM_v_Location = "v_Location";
        }
        public class GetMaterialProfile
        {
            internal const string SPNAME = "MM.P_GetMaterialProfile";
            internal const string PARAM_iv_ItemcategoryId = "iv_ItemcategoryId";
            internal const string PARAM_iv_storecode = "iv_storecode";
            internal const string PARAM_oCursor_Result = "oCursor_Result";
        }
        public class GetMaterialProfileDetails
        {
            internal const string SPNAME = "MM.P_GetMaterialProfileDetails";
            internal const string PARAM_iv_MaterialProfileCode = "iv_MaterialProfileCode";
            internal const string PARAM_iv_Storecode = "iv_Storecode";
            internal const string PARAM_oCursor_MaterialProfile = "oCursor_MaterialProfile";
            internal const string PARAM_iv_isuom = "iv_isuom";
            internal const string PARAM_iv_RegionID = "iv_RegionID";
        }
        public class GetrptHospitalFilter
        {
            internal const string SPNAME = "MM.P_rptHospitalFilter";
            internal const string PARAM_iv_RegionId = "iv_RegionId";
            internal const string PARAM_ocursor_GETHOSPITALS = "ocursor_GETHOSPITALS";
            internal const string PARAM_ocursor_GetStore = "ocursor_GetStore";
            internal const string PARAM_ocursor_GETPARENTID = "ocursor_GETPARENTID";
        }
        public class GetRPTUSERINDENT
        {
            internal const string SPNAME = "MM.P_RPTUSERINDENT";
            internal const string PARAM_iv_fromdate = "iv_fromdate";
            internal const string PARAM_iv_todate = "iv_todate";
            internal const string PARAM_iv_indentcode = "iv_indentcode";
            internal const string PARAM_oCursor_Result1 = "oCursor_Result1";
            internal const string PARAM_oCursor_Result2 = "oCursor_Result2";
            internal const string PARAM_IV_LocationID = "IV_LocationID";
            internal const string PARAM_iv_HospitalID = "iv_HospitalID";
            internal const string PARAM_iv_DeptID = "iv_DeptID";
        }
        public class ADDWORKFLOWTRANS
        {
            internal const string SPNAME = "ACE.P_ADDWORKFLOWTRANS";
            internal const string PARAM_in_WorkFlowID = "in_WorkFlowID";
            internal const string PARAM_in_ProcessFlowTransID = "in_ProcessFlowTransID";
            internal const string PARAM_in_ApprovalSequenceNO = "in_ApprovalSequenceNO";
            internal const string PARAM_iv_LoginID = "iv_LoginID";
            internal const string PARAM_on_ProcessFlowTransWorkFlowID = "on_ProcessFlowTransWorkFlowID";
        }
        public class SetWorkFlowTransWIP
        {
            internal const string SPNAME = "ACE.P_SetWorkFlowTransWIP";
            internal const string PARAM_in_ProcessFlowTransWorkFlowID = "in_ProcessFlowTransWorkFlowID";
            internal const string PARAM_iv_OriginalWIPBy = "iv_OriginalWIPBy";
            internal const string PARAM_iv_LoginID = "iv_LoginID";
            internal const string PARAM_on_Success = "on_Success";
        }
        #endregion
        #region Procedure
        public class DG_DEPARTMENTS
        {
            internal const string NAME = "HR.P_GETDEPARTMENTS";
            internal const string PARAM_IV_DEPTID = "iv_deptid";
            internal const string PARAM_IV_LOCATIONID = "iv_locationid";
            internal const string PARAM_ON_SUBDEPARTMENTS = "ocursor_subdepartments";
            internal const string PARAM_ON_DEPARTMENT = "ocursor_Department";

        }
        public class DG_PROCEDURETYPES
        {
            internal const string NAME = "BILLING.P_GetTherapeuticServiceTypes";
            internal const string PARAM_IV_LOCATIONID = "iv_Locationid";
            internal const string PARAM_ON_SERVICETYPELIST = "oc_ServiceTypeList";

        }
        public class DG_GTELOCATIONDEPARTMENTS
        {
            internal const string NAME = "HR.P_GETLOCATIONDEPARTMENTS";
            internal const string PARAM_IV_DEPTID = "iv_deptid";
            internal const string PARAM_IV_LOCATIONID = "iv_locationid";
            internal const string PARAM_ON_LOCATIONS = "ocursor_Locations";
            internal const string PARAM_ON_LOCSUBDEPTS = "ocursor_locsubdepts";
            internal const string PARAM_ON_DEPARTMENTS = "ocursor_Departments";

        }
        public class DG_GTELOCATIONS
        {
            internal const string NAME = "HR.P_GETREGIONMAPPINGMASTER";
            internal const string PARAM_IN_MAPPINGID = "in_mappingid";
            internal const string PARAM_IN_REGIONID = "in_regionid";
            internal const string PARAM_IN_CHARTID = "in_chartid";
            internal const string PARAM_IN_MAPPINGSTATUS = "in_mappingstatus";
            internal const string PARAM_ON_REGIONMAPPING = "ocursor_regionmappingmaster";

        }
        public class DG_PROCEDURE_PACKAGE
        {
            internal const string PacktypeNAME = "BILLING.P_GETSEARCHPACKAGEWARDS";
            internal const string PARAM_IN_SERVICECATEGORYID = "IN_SERVICECATEGORYID";
            internal const string PARAM_IN_SERVICETYPEID = "IN_SERVICETYPEID";
            internal const string PARAM_IV_IPNO = "IV_IPNO";
            internal const string PARAM_IV_DEPTID = "IV_DEPTID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_ISPACKAGEDEFINED = "IV_ISPACKAGEDEFINED";
            internal const string PARAM_IN_CUSTOMERID = "IN_CUSTOMERID";
            internal const string PARAM_IN_AGGREMENTID = "IN_AGGREMENTID";
            internal const string PARAM_IV_SERVICENAME = "IV_SERVICENAME";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_O_SEARCHPACKAGE = "O_SEARCHPACKAGE";


        }
        public class DG_CONSUMNOTDONE
        {
            internal const string NAME = "ot.PKG_INTERMODULE_REFERENCES_P_GET_CONSUM_NOTDONE";
            internal const string PARAM_IV_UHID = "IV_UHID";
            internal const string PARAM_IV_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_ON_DATA = "OCURSOR_DATA";
            internal const string PARAM_ON_DATA1 = "OCURSOR_DATA1";


        }
        public class DG_PACKAGEDETAILS
        {
            internal const string NAME = "billing.P_GetPackageDetails";
            internal const string PARAM_IV_PACKAGEID = "iv_Packageid";
            internal const string PARAM_IV_LOCATIONID = "iv_Locationid";
            internal const string PARAM_IV_PATIENTIDENTIFIERNO = "iv_PatientIdentifierNo";
            internal const string PARAM_IN_CUSTOMERID = "in_customerid";
            internal const string PARAM_IN_AGGREMENTID = "in_aggrementid";
            internal const string PARAM_ON_PACKAGEDEFINATION = "oc_PackageDefination";
            internal const string PARAM_ON_PACKAGEITEMINCLUSION = "oc_PackageItemInclusion";
            internal const string PARAM_ON_PACKAGEITEMEXCLSION = "oc_PackageItemexclsion";
            internal const string PARAM_ON_PACKAGETYPEINCLUSIONDETAILS = "oc_PackageTypeInclusionDetails";
            internal const string PARAM_ON_PACKAGEDISCOUNTDETAILS = "oc_PackageDiscountDetails";
            internal const string PARAM_ON_PACKAGEGENDERAPPLICABILITY = "oc_PackageGenderapplicability";


        }
        public class DG_PRIORITIES
        {
            internal const string NAME = "ot.PKG_LOVMASTER_DETAIL_P_GET_LOVDETAIL";
            internal const string PARAM_IN_LOVID = "IN_LOVID";
            internal const string PARAM_IV_LOVCODE = "IV_LOVCODE";
            internal const string PARAM_IN_LOVDETAILID = "IN_LOVDETAILID";
            internal const string PARAM_IV_LOCATIONID = "iv_locationid";
            internal const string PARAM_ON_DATA = "OCURSOR_DATA";

        }
        public class DG_FACILITYTYPE
        {
            internal const string NAME = "ehis.P_GETROOMS";
            internal const string PARAM_IN_ROOMTYPEID = "IN_ROOMTYPEID";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_ON_DATA = "OC_ROOM";

        }
        public class DG_TEAMNAME
        {
            internal const string NAME = "es.P_GET_TEAM_SERVICEID_OT";
            internal const string PARAM_IN_SERVICEID = "IN_SERVICEID";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_TEAMID = "IV_TEAMID";
            internal const string PARAM_IV_STARTDATE = "IV_STARTDATE";
            internal const string PARAM_IV_ENDDATE = "IV_ENDDATE";
            internal const string PARAM_ON_TEAMSERVICE = "oCursor_TeamServiceDetails";
            internal const string PARAM_ON_TEAMMEMBER = "OCURSOR_TEAMMEMBERDETAILS";

        }
        public class DG_CALENDERANDAPPOINTMENT
        {
            internal const string NAME = "es.P_GETTODAYSAPPOINTMENTSXML";
            internal const string PARAM_IN_APPOINT = "IN_CLOB_APPOINTMENTS";
            internal const string PARAM_ON_CALENDAR = "OCUR_CALENDARRULEDETAILS";
            internal const string PARAM_ON_APPOINTMENTS = "OCUR_APPOINTMENTSDETAILS";

        }
        public class DG_GETCALENDARRULES
        {
            internal const string NAME = "es.P_GetCalendarRulesDetails";
            internal const string PARAM_IN_CalendarID = "IN_CalendarID";
            internal const string PARAM_IV_ServiceID = "IV_ServiceID";
            internal const string PARAM_IClob_Resourceid = "IClob_Resourceid";
            internal const string PARAM_ID_Date = "ID_Date";
            internal const string PARAM_IV_ResourceTypeID = "IV_ResourceTypeID";
            internal const string PARAM_IV_Locationid = "IV_Locationid";
            internal const string PARAM_ON_CALENDER = "ocalendarcursor_result";

        }
        //GET TEAM DETAILS
        public class P_TEAMDEATILS
        {
            internal const string NAME = "es.P_GET_UPDATE_TEAM";
            internal const string PARAM_IV_TEAMID = "IV_TEAMID";
            internal const string PARAM_OUT_LOCATION = "OCURSOR_LOCATION";
            internal const string PARAM_OUT_MEMBER = "OCURSOR_MEMBER";
            internal const string PARAM_OUT_SERVICE = "OCURSOR_SERVICE";
        }
        public class P_GETTODAYSAPPOINTMENTS
        {
            internal const string NAME = "es.P_GETTODAYSAPPOINTMENTS";
            internal const string PARAM_IN_AppointmentID = "IN_AppointmentID";
            internal const string PARAM_IV_RegistrationNumber = "IV_RegistrationNumber";
            internal const string PARAM_IV_PatientName = "IV_PatientName";
            internal const string PARAM_IN_ServiceID = "IN_ServiceID";
            internal const string PARAM_IN_SpecialityID = "IN_SpecialityID";
            internal const string PARAM_IN_LocationID = "IN_LocationID";
            internal const string PARAM_IN_SiteID = "IN_SiteID";
            internal const string PARAM_IN_ResourceID = "IN_ResourceID";
            internal const string PARAM_ID_StartDateTime = "ID_StartDateTime";
            internal const string PARAM_ID_EndDateTime = "ID_EndDateTime";
            internal const string PARAM_ID_CancellationDate = "ID_CancellationDate";
            internal const string PARAM_IN_StatusCheck = "IN_StatusCheck";
            internal const string PARAM_IV_UpdatedBy = "IV_UpdatedBy";
            internal const string PARAM_IV_AdmissionNumber = "IV_AdmissionNumber";
            internal const string PARAM_IV_AdmissionType = "IV_AdmissionType";
            internal const string PARAM_IN_RepeatAppointmentID = "IN_RepeatAppointmentID";
            internal const string PARAM_OUT_Result = "oCursor_Result";
        }
        public class P_GETSTOPBOOKDETAILSSERVICES
        {
            internal const string NAME = "es.P_GET_STOPBOOK_SERVICEID";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_SERVICEID = "IN_SERVICEID";
            internal const string PARAM_IV_RESOURCEID = "IV_RESOURCEID";
            internal const string PARAM_iv_resourcetypeid = "iv_resourcetypeid";
            internal const string PARAM_ON_SERVICE = "OCURSOR_SERVICE";
            internal const string PARAM_ON_RESOURCES = "OCURSOR_RESOURCES";
        }
        public class P_CHECKCONSTRAINTS
        {
            internal const string NAME = "es.P_CHKBLK_HLD_OFTIME_INSCHED";
            internal const string PARAM_IN_AppointmentID = "IN_AppointmentID";
            internal const string PARAM_IV_RegistrationNumber = "IV_RegistrationNumber";
            internal const string PARAM_IV_PatientNumber = "IV_PatientNumber";
            internal const string PARAM_IN_ServiceID = "IN_ServiceID";
            internal const string PARAM_IN_SpecialityID = "IN_SpecialityID";
            internal const string PARAM_IN_LocationID = "IN_LocationID";
            internal const string PARAM_IN_SiteID = "IN_SiteID";
            internal const string PARAM_IN_ResourceID = "IN_ResourceID";
            internal const string PARAM_ID_StartDateTime = "ID_StartDateTime";
            internal const string PARAM_ID_EndDateTime = "ID_EndDateTime";
            internal const string PARAM_ID_CancellationDate = "ID_CancellationDate";
            internal const string PARAM_IN_StatusCheck = "IN_StatusCheck";
            internal const string PARAM_IV_UpdatedBy = "IV_UpdatedBy";
            internal const string PARAM_IV_AdmissionNumber = "IV_AdmissionNumber";
            internal const string PARAM_IV_AdmissionType = "IV_AdmissionType";
            internal const string PARAM_OUT_BLOCK = "OCURSOR_BLOCK";
            internal const string PARAM_OUT_HOLD = "OCURSOR_HOLD";
            internal const string PARAM_OUT_OFFTIME = "OCURSOR_OFFTIME";
            internal const string PARAM_OUT_INSCHEDULE = "OCURSOR_INSCHEDULE";
            internal const string PARAM_OUT_DIFFLOCATIONS = "OCURSOR_DIFFLOCATIONS";
        }
        public class DG_VALIDATEHOLIDAY
        {
            internal const string NAME = "hr.p_validateholiday";
            internal const string PARAM_IN_locationid = "iv_locationid";
            internal const string PARAM_IN_date = "id_date";
            internal const string PARAM_ON_RESULT = "on_result";

        }
        public class P_ADDAPPOINTMENTS
        {
            internal const string NAME = "es.P_BookAppointment";
            internal const string PARAM_IV_RegistrationType = "IV_RegistrationType";
            internal const string PARAM_IV_RegistrationNumber = "IV_RegistrationNumber";
            internal const string PARAM_IV_PatientName = "IV_PatientName";
            internal const string PARAM_IV_ContactNumber = "IV_ContactNumber";
            internal const string PARAM_IN_ServiceID = "IN_ServiceID";
            internal const string PARAM_IN_SpecialityID = "IN_SpecialityID";
            internal const string PARAM_IN_LocationID = "IN_LocationID";
            internal const string PARAM_IN_SiteID = "IN_SiteID";
            internal const string PARAM_IN_ResourceID = "IN_ResourceID";
            internal const string PARAM_IN_LanguageID = "IN_LanguageID";
            internal const string PARAM_IN_GenderID = "IN_GenderID";
            internal const string PARAM_ID_StartDateTime = "ID_StartDateTime";
            internal const string PARAM_ID_EndDateTime = "ID_EndDateTime";
            internal const string PARAM_IV_PreferredTime = "IV_PreferredTime";
            internal const string PARAM_IV_Notes = "IV_Notes";
            internal const string PARAM_IV_UpdatedBy = "UpdatedBy";
            internal const string PARAM_IN_StatusCheck = "IN_StatusCheck";
            internal const string PARAM_OUT_Resources = "IClob_Resources";
            internal const string PARAM_OUT_GroupDetails = "IClob_GroupDetails";
            internal const string PARAM_IV_AdmissionNumber = "IV_AdmissionNumber";
            internal const string PARAM_IV_AdmissionType = "IV_AdmissionType";
            internal const string PARAM_IV_Repeats = "IV_Repeats";
            internal const string PARAM_IN_RepeatID = "IN_RepeatID";

            internal const string PARAM_Iv_ServiceName = "Iv_ServiceName";
            internal const string PARAM_Iv_SpecialityName = "Iv_SpecialityName";
            internal const string PARAM_IN_PATIENTSERVICEFLAG = "IN_PATIENTSERVICEFLAG";
            internal const string PARAM_ON_AppointmentID = "ON_AppointmentID";
            internal const string PARAM_IN_MODEOFAPPOINTMENT = "IN_MODEOFAPPOINTMENT";
            internal const string NAME_ADDOT = "es.p_bookappointment_bkp";

        }

        #endregion
        public class DG_GetSlidingScaleDefaultValues
        {
            internal const string SPNAME = "WARDS.P_GetDefaultSlidingScale_DG";
            internal const string PARAM_OUT_Result = "oCursor_Result";

        }
        public class OT_GETPROCEDUREVIEW
        {
            internal const string NAME = "ot.P_get_ipnumber_data_dg";
            internal const string PARAM_IN_Ipnumber = "iv_ipno";
            internal const string PARAM_IN_HDRID = "in_proc_req_hdr_id";
            internal const string PARAM_IN_LocationId = "iv_locationid";
            internal const string PARAM_OUT_ocursor_request_data = "ocursor_request_data";
            internal const string PARAM_OUT_ocursor_surg_data = "ocursor_surg_data";
            internal const string PARAM_OUT_ocursor_surgeons_data = "ocursor_surgeons_data";
            internal const string PARAM_OUT_ocursor_anae_data = "ocursor_anae_data";

        }

        public class OT_GETREPORTVIEW
        {
            internal const string NAME = "pkg_dashboard.p_getsurgerydetailsforreport";
            internal const string PARAM_IN_in_otrequestno = "in_otrequestno";
            internal const string PARAM_IN_iv_ottestno = "iv_ottestno";
            internal const string PARAM_IN_iv_uhid = "iv_uhid";
            internal const string PARAM_IN_iv_fromdate = "iv_fromdate";
            internal const string PARAM_IN_iv_todate = "iv_todate";
            internal const string PARAM_IN_iv_locationid = "iv_locationid";
            internal const string PARAM_IN_iv_ipnumber = "iv_ipnumber";
            internal const string PARAM_IN_in_requeststatus = "in_requeststatus";
            internal const string PARAM_OUT_oref_otsurgeondetails = "oref_otsurgeondetails";
            internal const string PARAM_OUT_oref_otanesthesiandetails = "oref_otanesthesiandetails";
            internal const string PARAM_OUT_oref_otequipmentdetails = "oref_otequipmentdetails";
            internal const string PARAM_OUT_oref_otmaster = "oref_otmaster";
            internal const string PARAM_IN_oref_otdetails = "oref_otdetails";

        }
        public class Reg_PatientDetails
        {
            internal const string NAME = "REGISTRATION.p_getpatientdetailswithregno";
            internal const string PARAM_IN_in_registrationnumber = "in_registrationnumber";
            internal const string PARAM_IN_in_locationid = "in_locationid";
            internal const string PARAM_OUT_ocursor_component1 = "ocursor_component1";
            internal const string PARAM_OUT_ocursor_component3 = "ocursor_component3";
            internal const string PARAM_OUT_ocursor_component4 = "ocursor_component4";
            internal const string PARAM_OUT_ocursor_component5 = "ocursor_component5";
            internal const string PARAM_OUT_ocursor_component6 = "ocursor_component6";
            internal const string PARAM_OUT_ocursor_component7 = "ocursor_component7";
            internal const string PARAM_OUT_ocursor_component8 = "ocursor_component8";
            internal const string PARAM_OUT_ocursor_component9 = "ocursor_component9";
            internal const string PARAM_OUT_ocursor_component10 = "ocursor_component10";
            internal const string PARAM_OUT_ocursor_component11 = "ocursor_component11";
            internal const string PARAM_OUT_ocursor_component12 = "ocursor_component12";
            internal const string PARAM_OUT_ocursor_component13 = "ocursor_component13";
            internal const string PARAM_OUT_ocursor_component14 = "ocursor_component14";
            internal const string PARAM_OUT_ocursor_component15 = "ocursor_component15";
            internal const string PARAM_OUT_in_masterflag = "in_masterflag";

        }
        public class OT_GETMMVIEW
        {
            internal const string NAME = "mm.P_GetMMindentrequests_dg";
            internal const string PARAM_IN_Ipnumber = "iv_Ipno";
            internal const string PARAM_IN_LocationId = "iv_Hospitalid";
            internal const string PARAM_IN_fromdate = "ip_FromDate";
            internal const string PARAM_IN_todate = "ip_ToDate";
            internal const string PARAM_OUT_ocursor_getopenindentaginstip = "oCursor_GetOpenIndentAginstIP";


        }

        public class OT_CANCELPROCEDUREVIEW
        {
            internal const string NAME = "PKG_PROCEDURE_REQUEST.P_DELETE_PROC_DTLS_SURG_DATA";
            internal const string PARAM_IN_PROC_REQ_DTLS_IDIpnumber = "IN_PROC_REQ_DTLS_ID";
            internal const string PARAM_IN_SURG_ID = "IN_SURG_ID";
            internal const string PARAM_IV_UPDATED_BY = "IV_UPDATED_BY";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IV_CANCELLATION_REASON = "IV_CANCELLATION_REASON";
            internal const string PARAM_IV_CANCELLATIONFROM = "IV_CANCELLATIONFROM";


        }

        public class DG_SAVENURSEMEDICATIONORDERS
        {
            internal const string SPNAME = "WARDS.P_SaveMedicationOrdersNurse_DG";
            internal const string OUT_PRESCRIPTIONNO = "OUT_PRESCRIPTIONNO";
            internal const string IN_ADMISSIONNO = "IN_ADMISSIONNO";
            internal const string v_UHID = "v_UHID";
            internal const string v_DIAGNOSIS = "v_DIAGNOSIS";
            internal const string v_HEIGHT = "v_HEIGHT";
            internal const string v_WEIGHT = "v_WEIGHT";
            internal const string v_BSA = "v_BSA";
            internal const string v_BMI = "v_BMI";
            internal const string v_LOCATIONID = "v_LOCATIONID";
            internal const string v_DOCTORNAME = "v_DOCTORNAME";
            internal const string v_PRESCRIPTIONDATE = "v_PRESCRIPTIONDATE";
            internal const string v_HEIGHTTYPE = "v_HEIGHTTYPE";
            internal const string v_WEIGHTTYPE = "v_WEIGHTTYPE";
            internal const string v_STATUS = "v_STATUS";
            internal const string v_CREATEDBY = "v_CREATEDBY";

            internal const string v_INSTRUCTION = "v_INSTRUCTION";
            internal const string v_PRESCRIPTIONTYPE = "v_PRESCRIPTIONTYPE";
            internal const string v_TRANSACTIONALSTATUS = "v_TRANSACTIONALSTATUS";
            internal const string v_IPNUMBER = "v_IPNUMBER";
            internal const string v_REASONFORPRESCRIPTION = "v_REASONFORPRESCRIPTION";
            internal const string v_DISCHARGEMEDICATION = "v_DISCHARGEMEDICATION";
            internal const string v_IPBILL = "v_IPBILL";
            internal const string V_Medication_Details = "V_Medication_Details";
            internal const string V_Med_SlidingScale = "V_Med_SlidingScale";
            internal const string v_UPDATEDBY = "v_UPDATEDBY";
            internal const string v_UPDATEDDATE = "v_UPDATEDDATE";
            internal const string v_PRESCRIBINGDOCTOR = "v_PRESCRIBINGDOCTOR";
            internal const string v_DIABETICVALUE = "v_DIABETICVALUE";
            internal const string v_SLIDINGSTATUS = "v_SLIDINGSTATUS";

            internal const string v_RELATIONWITHSLIDINGNO = "v_RELATIONWITHSLIDINGNO";

        }

        public class DG_GetPrePrescSlidingScale
        {
            internal const string SPNAME = "WARDS.P_GetSlidingScale_DG";
            internal const string iv_LocationId = "iv_LocationId";
            internal const string iv_IPNumber = "iv_IPNumber";
            internal const string iv_UHID = "iv_UHID";
            internal const string iv_DoctorID = "iv_DoctorID";
            internal const string iv_fromdate = "iv_fromdate";
            internal const string iv_todate = "iv_todate";
            internal const string iv_currentepisode = "iv_currentepisode";
            internal const string iv_consultant = "iv_consultant";
            internal const string PARAM_OUT_SlidingScale = "OCursor_SlidingScale";

        }
        // get doctor name alphbetically
        public class DG_GetDocNameAlphabetically
        {
            internal const string SPNAME = "HR.P_GETSS_DOCTORS_ALPHABETIC";
            internal const string IV_DEPARTMENTID = "IV_DEPARTMENTID";
            internal const string IN_SPECIALITYID = "IN_SPECIALITYID";

            internal const string OCURSOR_DOCTORS = "OCURSOR_DOCTORS";
            internal const string IN_EMP_ALPHA = "IN_EMP_ALPHA";
            internal const string IV_LOCATIONID = "IV_LOCATIONID";

        }

        //get sliding scale history dates
        public class DG_GetSlidingScaleHistoryDates
        {
            internal const string SPNAME = "WARDS.P_GetSlidingScaleDates_DG";
            internal const string iv_LocationId = "iv_LocationId";
            internal const string iv_IPNumber = "iv_IPNumber";
            internal const string iv_PrescriptionDetailID = "iv_PrescriptionDetailID";
            internal const string OCursor_SlidingScaleDate = "OCursor_SlidingScaleDate";

        }

        // delete sliding scale values
        public class P_DELETESLIDINGSCALEVALUES_DG
        {
            internal const string SPNAME = "WARDS.P_DELETESLIDINGSCALEVALUES_DG";
            internal const string v_DrugCode = "v_DrugCode";
            internal const string v_PrescriptionDetailID = "v_PrescriptionDetailID";
            internal const string v_SlidingScaleNo = "v_SlidingScaleNo";
            internal const string v_DoctorID = "v_DoctorID";

        }

        //get sliding scale values date and time wise
        public class DG_GetSlidingScaleHistoryDateWise
        {
            internal const string SPNAME = "WARDS.P_GetSSHistoryDateWise_DG";
            internal const string iv_LocationId = "iv_LocationId";
            internal const string iv_IPNumber = "iv_IPNumber";
            internal const string iv_CreatedDate = "iv_CreatedDate";
            internal const string OCursor_SlidingScaleHistory = "OCursor_SlidingScaleHistory";

        }
        // update sliding scale Values
        public class P_UpdateSlidingScaleValues_DG
        {
            internal const string SPNAME = "WARDS.P_UpdateSlidingScaleValues_DG";


            internal const string v_PrescriptionDetailId = "v_PrescriptionDetailId";
            internal const string v_DRUGCODE = "v_DRUGCODE";
            internal const string v_CREATEDBY = "v_CREATEDBY";
            internal const string V_Med_SlidingScale = "V_Med_SlidingScale";
            internal const string v_UPDATEDBY = "v_UPDATEDBY";
            internal const string v_UPDATEDDATE = "v_UPDATEDDATE";
            internal const string v_SLIDINGSTATUS = "v_SLIDINGSTATUS";

            internal const string v_RELATIONWITHSLIDINGNO = "v_RELATIONWITHSLIDINGNO";

        }
        #endregion
        #region MNM
        public class MNM_SAVE_UPD_DEL_JOBREQUEST
        {
            internal const string SPNAME = "MNM.P_SAVE_UPD_DEL_JOBREQUEST";
            internal const string PARAM_IV_JOBORDERNO = "IV_JOBORDERNO";
            internal const string PARAM_IV_REQUESTORNAME = "IV_REQUESTORNAME";
            internal const string PARAM_IV_EMP_ID = "IV_EMP_ID";
            internal const string PARAM_IV_REQUESTEDDATE = "IV_REQUESTEDDATE";
            internal const string PARAM_IV_DEPARTMENTID = "IV_DEPARTMENTID";
            internal const string PARAM_IV_WORKAREA = "IV_WORKAREA";
            internal const string PARAM_IV_PHYSICALLOCATION = "IV_PHYSICALLOCATION";
            internal const string PARAM_IV_ASSETTYPE = "IV_ASSETTYPE";
            internal const string PARAM_IV_ASSETNAME = "IV_ASSETNAME";
            internal const string PARAM_IV_PROBLEMID = "IV_PROBLEMID";
            internal const string PARAM_IV_PROBLEMDESCRIPTION = "IV_PROBLEMDESCRIPTION";
            internal const string PARAM_IV_PATIENTAFFECTED = "IV_PATIENTAFFECTED";
            internal const string PARAM_IV_EQUIPMENTDOWNTIME = "IV_EQUIPMENTDOWNTIME";
            internal const string PARAM_IV_EQUIPMENTTIME = "IV_EQUIPMENTTIME";
            internal const string PARAM_IV_EQUIPMENTSTATUS = "IV_EQUIPMENTSTATUS";
            internal const string PARAM_IV_PRIORITYID = "IV_PRIORITYID";
            internal const string PARAM_IV_SEVERITYID = "IV_SEVERITYID";
            internal const string PARAM_IV_UPLOAD = "IV_UPLOAD";
            internal const string PARAM_IV_CREATIONDATE = "IV_CREATIONDATE";
            internal const string PARAM_IV_STATUS = "IV_STATUS";
            internal const string PARAM_IV_UPDATEDBY = "IV_UPDATEDBY";
            internal const string PARAM_IV_UPDATEDDATE = "IV_UPDATEDDATE";
            internal const string PARAM_IV_CONTACTNUMBER = "IV_CONTACTNUMBER";
            internal const string PARAM_IV_CONTACTDATE = "IV_CONTACTDATE";
            internal const string PARAM_IV_CONTACTTIME = "IV_CONTACTTIME";
            internal const string PARAM_IV_PREFFEREDTIME = "IV_PREFFEREDTIME";
            internal const string PARAM_IV_PREFFEREDFROMTIME = "IV_PREFFEREDFROMTIME";
            internal const string PARAM_IV_PREFFEREDTOTIME = "IV_PREFFEREDTOTIME";
            internal const string PARAM_IV_FLAG = "IV_FLAG";
            internal const string PARAM_IV_REOPEN = "IV_REOPEN";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_DEPTVAL = "IN_DEPTID";
            internal const string PARAM_IV_WORKAREAID = "IV_WORKAREAID";
            internal const string PARAM_IV_REQUESTTYPE = "IV_REQUESTTYPE";
            internal const string PARAM_IV_JOBTYPENAME = "IV_JOBTYPENAME";
            internal const string PARAM_IV_JOBTYPEID = "IV_JOBTYPEID";
            internal const string PARAM_OV_JOBORDERID = "OV_JOBORDERID";
        }
        public class MNM_GETLOCATIONDEPARTMENTS
        {
            internal const string SPNAME = "HR.P_GETLOCATIONDEPARTMENTS";
            internal const string PARAM_iv_deptid = "iv_deptid";
            internal const string PARAM_iv_locationid = "iv_locationid";
            internal const string PARAM_ocursor_Locations = "ocursor_Locations";
            internal const string PARAM_ocursor_locsubdepts = "ocursor_locsubdepts";
            internal const string PARAM_ocursor_Departments = "ocursor_Departments";
        }
        public class MNM_GET_JOBTYPES
        {
            internal const string SPNAME = "MNM.P_GET_JOBTYPES";
            internal const string PARAM_IV_JOBTYPEID = "IV_JOBTYPEID";
            internal const string PARAM_IV_JOBTYPENAME = "IV_JOBTYPENAME";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OCURSOR_JOBTYPEMASTER = "OCURSOR_JOBTYPEMASTER";
        }
        public class MNM_GET_WORKAREA
        {
            internal const string SPNAME = "MNM.P_GET_WORKAREA";
            internal const string PARAM_IN_WORKAREAID = "IN_WORKAREAID";
            internal const string PARAM_IN_WORKAREANAME = "IN_WORKAREANAME";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_O_CURSOR = "O_CURSOR";
        }
        public class MNM_GET_SEVERITY
        {
            internal const string SPNAME = "MNM.P_GET_SEVERITY";
            internal const string PARAM_IV_SEVERITYID = "IV_SEVERITYID";
            internal const string PARAM_IV_SEVERITYNAME = "IV_SEVERITYNAME";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OCURSOR_SEVERITYMASTER = "OCURSOR_SEVERITYMASTER";
        }
        public class MNM_GET_PRIORITY
        {
            internal const string SPNAME = "MNM.P_GET_PRIORITY";
            internal const string PARAM_IV_PRIORITYID = "IV_PRIORITYID";
            internal const string PARAM_IV_PRIORITYNAME = "IV_PRIORITYNAME";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OCURSOR_PRIORITYMASTER = "OCURSOR_PRIORITYMASTER";
        }
        public class MNM_GET_PROBLEMMASTER
        {
            internal const string SPNAME = "MNM.P_GET_PROBLEMMASTER";
            internal const string PARAM_IV_PROBLEMID = "IV_PROBLEMID";
            internal const string PARAM_IV_PROBLEMNAME = "IV_PROBLEMNAME";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OCURSOR_PROBLEMMASTER = "OCURSOR_PROBLEMMASTER";
        }
        public class MNM_REOPEN_JOBREQUEST
        {
            internal const string SPNAME = "MNM.P_REOPEN_JOBREQUEST";
            internal const string PARAM_IV_JOBORDERNO = "IV_JOBORDERNO";
            internal const string PARAM_IV_STATUS = "IV_STATUS";
            internal const string PARAM_IV_UPDATEDBY = "IV_UPDATEDBY";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
        }
        public class MNM_CLOSE_JOBREQUEST
        {
            internal const string SPNAME = "MNM.P_CLOSE_JOBREQUEST";
            internal const string PARAM_IV_JOBORDERNO = "IV_JOBORDERNO";
            internal const string PARAM_IV_UPDATEDBY = "IV_UPDATEDBY";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
        }
        public class MNM_GET_ASSETTYPEFROMDEPT
        {
            internal const string SPNAME = "MNM.P_GET_ASSETTYPEFROMDEPT";
            internal const string PARAM_IV_ASSETID = "IV_ASSETID";
            internal const string PARAM_IV_ASSETTYPEID = "IV_ASSETTYPEID";
            internal const string PARAM_IV_ASSETDEPTID = "IV_ASSETDEPTID";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_O_CURSOR = "O_CURSOR";
        }
        public class MNM_GET_RAISEASSET
        {
            internal const string SPNAME = "MNM.P_GET_RAISEASSET";
            internal const string PARAM_IN_ASSETTYPEID = "IN_ASSETTYPEID";
            internal const string PARAM_IN_DEPTASSET = "IN_DEPTASSET";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_O_CURSOR = "O_CURSOR";
        }
        public class MNM_ViewRequest
        {
            internal const string SPNAME = "MNM.P_GETJOBREQUEST";
            internal const string PARAM_IV_JOBORDERNO = "IV_JOBORDERNO";
            internal const string PARAM_IV_JOBORDERSTATUS = "IV_JOBORDERSTATUS";
            internal const string PARAM_IV_RAISEDBY = "IV_RAISEDBY";
            internal const string PARAM_IV_DEPT = "IV_DEPT";
            internal const string PARAM_IV_WORKAREA = "IV_WORKAREA";
            internal const string PARAM_IV_REQFROMDATE = "IV_REQFROMDATE";
            internal const string PARAM_IV_REQTODATE = "IV_REQTODATE";
            internal const string PARAM_IV_EMPID = "IV_EMPID";
            internal const string PARAM_IV_PHYLOC = "IV_PHYLOC";
            internal const string PARAM_IV_ASSETTYPE = "IV_ASSETTYPE";
            internal const string PARAM_IV_ASSETNAME = "IV_ASSETNAME";
            internal const string PARAM_IV_PRIORITY = "IV_PRIORITY";
            internal const string PARAM_IV_SEVERITY = "IV_SEVERITY";
            internal const string PARAM_IV_CREATIONDATE = "IV_CREATIONDATE";
            internal const string PARAM_IV_LOCATION = "IV_LOCATION";
            internal const string PARAM_IN_REQUESTTYPE = "IN_REQUESTTYPE";
            internal const string PARAM_IN_JOBTYPE = "IN_JOBTYPE";
            internal const string PARAM_O_CURSOR = "O_CURSOR";
        }
        public class MNM_CancelRequest
        {
            internal const string SPNAME = "MNM.P_CANCEL_JOBREQUEST";
            internal const string PARAM_IV_JOBORDERNO = "IV_JOBORDERNO";
            internal const string PARAM_IV_Reason = "IN_REASONFORCANCEL";
            internal const string PARAM_IV_UpdatedBy = "IV_UPDATEDBY";
            internal const string PARAM_IV_LocationID = "IV_LOCATIONID";
        }
        public class MNM_JOBStatus
        {
            internal const string SPNAME = "MNM.P_JOBSTATUS";
            internal const string PARAM_O_CURSOR = "ocursor_status";
        }
        public class MNM_RaisedBy
        {
            internal const string SPNAME = "MNM.p_get_raisedby";
            internal const string PARAM_O_CURSOR = "O_CURSOR";
        }
        public class MNM_ViewDetails
        {

            internal const string SPNAME = "MNM.P_GETVIEWJOBDETAILS";
            internal const string PARAM_IV_JOBORDERNO = "IV_JOBORDERNO";
            internal const string PARAM_IV_LOCATION = "IV_LOCATION";
            internal const string PARAM_O_REQUESTORDETAILS = "O_REQUESTORDETAILS";
            internal const string PARAM_O_ASSETDETAILS = "O_ASSETDETAILS";
            internal const string PARAM_O_JOBDETAILS = "O_JOBDETAILS";
            internal const string PARAM_O_PANDSDETAILS = "O_PANDSDETAILS";
            internal const string PARAM_O_COMPLETIONDETAILS = "O_COMPLETIONDETAILS";
            internal const string PARAM_O_GATEPASS = "O_GATEPASS";
            internal const string PARAM_O_JOBTYPEDETAILS = "O_JOBTYPEDETAILS";
        }
        #endregion


        public class P_GETIPDETAILSFORRETURN
        {

            internal const string SPNAME = "PHARMACY.P_GETIPDETAILSFORRETURN";
            internal const string PARAM_IN_IPNO = "v_ipno";
            internal const string PARAM_IN_FLAG = "v_flag";
            internal const string PARAM_IN_ITEMSHORTDESC = "V_ITEMSHORTDESC";
            internal const string PARAM_OUT_OCURSOR_HEADERDETAILS = "OCURSOR_HEADERDETAILS";
            internal const string PARAM_OUT_OCURSOR_ISSITEMDETAILS = "OCURSOR_ISSITEMDETAILS";
        }

        public class P_ADDMULTIDRUGRETURN
        {

            internal const string SPNAME = "PHARMACY.P_ADDMULTIDRUGRETURN";
            internal const string PARAM_IN_IV_RETURNXML = "IV_RETURNXML";
            internal const string OCURSOR_OUT_IV_RETURN = "IV_RETURN";


        }
        public class DG_p_getstoreusers
        {
            internal const string SPNAME = "PHARMACY.p_getstoreusers";
            internal const string PARAM_IN_iv_loginid = "iv_loginid";
            internal const string PARAM_OUT_ocursor_result = "ocursor_result";

        }
        //end nursing
        //drug recive update in at table

        public class p_getIndentStatus
        {
            internal const string NAME = "PHARMACY.p_getIndentStatus";
            internal const string PARAM_iv_indentcode = "iv_indentcode";
            internal const string PARAM_iv_IPNO = "iv_IPNO";
            internal const string PARAM_iv_status = "iv_status";
        }
        public class P_UpdateDischargeMedication
        {
            internal const string NAME = "ADT.P_UpdateDischargeMedication";
            internal const string PARAM_IV_IPNO = "IV_IPNO";
            internal const string PARAM_IN_STATUS = "IN_STATUS";
            internal const string PARAM_IV_LOGINID = "IV_LOGINID";
        }
        public class DELETELRN
        {
            internal const string SPNAME = "LAB.P_DELETETEST";
            //internal const string PARAM_IN_in_LRN = "in_LRN";
            internal const string PARAM_iv_requesttestid = "IN_REQUESTTESTID";
            internal const string PARAM_iv_LoginID = "IV_LOGINID";
            internal const string PARAM_iv_comments = "IV_COMMENTS";
            internal const string PARAM_OUT_on_Returnvalue = "ON_RETURNVALUE";
        }

        public class DELETEDRN
        {
            internal const string SPNAME = "PKG_WORKLIST.P_UPDATEWORKLISTSTATUS";
            internal const string PARAM_IN_REQUESTDTLID = "IN_REQUESTDTLID";
            internal const string PARAM_IN_UPDATEDBY = "IN_UPDATEDBY";
            internal const string PARAM_IN_FLAG = "IN_FLAG";
            internal const string PARAM_IN_DRN = "IN_DRN";
            internal const string PARAM_IN_ATTTORADIOLOGIST = "IN_ATTTORADIOLOGIST";
            internal const string PARAM_IN_EQUIPMENTID = "IN_EQUIPMENTID";
            internal const string PARAM_IN_DOCTORID = "IN_DOCTORID";
            internal const string PARAM_OUT_RETURNVAL = "OUT_RETURNVAL";
        }

        //end

        //Attendant CR starts

        public class p_getattendentDetails
        {
            internal const string NAME = "digital.p_getattendentDetails";
            internal const string PARAM_IN_IPNUMBER = "IN_IPNUMBER";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_OUT_OCURSOR_DETAILS = "OCURSOR_DETAILS";
        }
        public class P_GetRelationShipMaster
        {
            internal const string NAME = "EHIS.P_GetRelationShipMaster";
            internal const string PARAM_OUT_oCursor_Relationship = "oCursor_Relationship";
        }
        //Attendant CR ends

        public class DG_DIABETICCHART_REPORT
        {
            internal const string NAME = "DIGITAL.DG_DIABETICCHART_REPORT";
            //  internal const string NURSINGREPORT_NAME = "dg_NursingNotes_report";
            internal const string IN_Ipnumber = "IN_IPNUMBER";
            internal const string IN_ResourceId = "IN_DOCTORID";
            internal const string IN_LocationId = "IN_LOCATIONID";
            internal const string IN_FromDate = "IN_FROMDATE";
            internal const string IN_ToDate = "IN_TODATE";
            internal const string patient_details = "PATIENT_DETAILS";
            internal const string out_details = "OUT_DETAILS";

            //internal const string Out_QFcode = "Out_QFcode";
        }
        #region CCB
        public class DynamicFormInput
        {
            public string FormId { get; set; }
            public string SpecialityId { get; set; }
            public string LocationId { get; set; }
        }
        public class GetFormNames
        {
            internal const string NAME = "FORMGEN.P_GETFORMSBYMODULE";
            internal const string IV_FORMNAME = "IV_FORMNAME";
            internal const string IV_MODULEID = "IV_MODULEID";
            internal const string OCURSOR_FORMNAMES = "OCURSOR_FORMNAMES";
        }
        public class GETPANELPARAMETERMAPPING
        {
            internal const string NAME = "FORMGEN.P_GETPANELPARAMETERMAPPING_NEW";
            internal const string IV_FORMID = "IV_FORMID";
            //internal const string IV_SPECIALITYID = "IV_SPECIALITYID";
            internal const string IV_LOCATIONID = "IV_LOCATIONID";
            internal const string IV_ACTION = "IV_ACTION";
            internal const string OCURSOR_FORM = "OCURSOR_FORM";
            internal const string OCURSOR_PANELMAPPING = "OCURSOR_PANELMAPPING";
            internal const string OCURSOR_PARAMETERMAPPING = "OCURSOR_PARAMETERMAPPING";
        }
        public class GETPANELPARAMETERDETAILS
        {
            internal const string NAME = "FORMGEN.P_GETPANELPARAMETERDETAILS_NEW";
            internal const string IV_FORMID = "IV_FORMID";
            internal const string IV_LOCATIONID = "IV_LOCATIONID";
            internal const string IV_ACTION = "IV_ACTION";
            internal const string IV_REQUESTID = "IV_REQUESTID";
            internal const string OCURSOR_FORM = "OCURSOR_FORM";
            internal const string OCURSOR_PANELMAPPING = "OCURSOR_PANELMAPPING";
            internal const string OCURSOR_PARAMETERMAPPING = "OCURSOR_PARAMETERMAPPING";
            internal const string OCURSOR_PARAMMAPPINGWITHVAL = "OCURSOR_PARAMMAPPINGWITHVAL";
        }
        public class GetAttachedForms
        {
            internal const string NAME = "FORMGEN.P_GETATTACHEDFORMS";
            internal const string IV_UHID = "UHID";
            internal const string OCURSOR_FORMNAMES = "OCURSOR_FORMNAMES";
            internal const string OCURSOR_FORMDETAILS = "OCURSOR_FORMDETAILS";
        }
        public class GETSELECTEDFORMDTLS
        {
            internal const string NAME = "FORMGEN.P_GETSELECTEDFORMDTLS";
            internal const string IV_FORMID = "FORMID";
            internal const string IV_UHID = "IV_UHID";
            internal const string IV_IPNO = "IV_IPNO";
            internal const string OCURSOR_FORMDETAILS = "OCURSOR_FORMDETAILS";
        }
        public class P_SAVEASSESSMENTDETAILS_NEW
        {
            internal const string NAME = "FORMGEN.P_SAVEASSESSMENTDETAILS_NEW";
            internal const string IV_FORMDETAILS = "iclob_formdetails";
        }


        public class P_ADDFAVOURITES
        {
            internal const string NAME = "WARDS.P_ADDFAVOURITES";
            internal const string PARAM_IN_FavoriteName = "IV_FAVOURITENAME";
            internal const string PARAM_IN_Doctorname = "IV_DOCTORNAME";
            internal const string PARAM_IN_status = "IV_STATUS";
            internal const string PARAM_IN_LocationId = "IV_LOCATIONID";
            internal const string PARAM_IN_ModuleId = "IV_MODULEID";
            internal const string PARAM_IN_LoginId = "IV_LOGINID";
        }

        public class P_GETFAVOURITES
        {
            internal const string NAME = "FORMGEN.P_GETFAVOURITES";
            internal const string PARAM_IN_Doctorname = "IV_DOCTORNAME";
            internal const string PARAM_IN_ModuleId = "IV_MODULEID";
            internal const string PARAM_OUT_Result = "OCURSOR_FAVOURITEMASTER";
        }
        public class P_GETASSESSMENTDETAILS_NEW
        {
            internal const string NAME = "FORMGEN.p_getassessmentdetails_new";
            internal const string PARAM_in_requestid = "in_requestid";
            internal const string PARAM_iv_locationid = "iv_locationid";
            internal const string PARAM_oref_formrequest = "oref_formrequest";
            internal const string PARAM_oref_formrequestdetails = "oref_formrequestdetails";
            internal const string PARAM_oref_formreqgriddetails = "oref_formreqgriddetails";
        }
        public class DG_GETOPSERVICES
        {
            internal const string NAME = "digital.p_rptgetopservicedetails";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_VISITID = "IV_VISITID";
            internal const string PARAM_IN_OPNUMBER = "IV_OPNUMBER";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_DELIMETER = "IV_DELIMETER";
            internal const string PARAM_OUT_CURSOROPSERVICEDETAILS = "OCURSOR_OPSERVICEDETAILS";
            internal const string PARAM_OUT_CURSOROPNOTES = "OCURSOR_OPNOTES";
            internal const string PARAM_OUT_CURSORPRESCRIPTION = "OCURSOR_OPPRESCRIPTION";
            internal const string PARAM_OUT_CURSOROPDIAGNOSIS = "OCURSOR_OPDIAGNOSIS";
            internal const string PARAM_OUT_CURSORPRIMARYDOCTOR = "OCURSOR_PRIMARYDOCTOR";
            internal const string PARAM_OUT_CURSORRECOMMENDATIONS = "OCURSOR_OPRECOMENDATIONS";
            internal const string PARAM_OUT_CURSORINITIALASSESMENT = "OCURSOR_INITIALASSESSMENT";
            internal const string PARAM_OUT_CURSORVITALDETAILS = "OCURSOR_VITALDETAILS";
            internal const string PARAM_OUT_CURSORPATIENTEDUCATION = "OCURSOR_PATIENTEDUCATION";
            internal const string PARAM_OUT_CURSOROPIADDETAILS = "OCURSOR_OPIADETAILS";
            internal const string PARAM_OUT_CURSORCONFIDENTIAL = "OCURSOR_CONFIDENTIAL";
        }
        public class DG_GETALLERGYREPORTDETAILS
        {
            internal const string NAME = "digital.dg_getPatientallergiesReport";

            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IV_VISITID = "IV_VISITID";
            internal const string PARAM_IV_OPNUMBER = "IV_OPNUMBER";
            internal const string PARAM_IV_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUT_ALLERGIESHISTORY = "o_AllergyHistory";
            internal const string PARAM_OUT_COUNT = "IN_Count";
        }
        public class GetReports
        {
            internal const string NAME = "FORMGEN.P_GETREPORTSBYMODULE";
            internal const string PARAM_in_reportname = "IV_REPORTNAME";
            internal const string PARAM_in_moduleid = "IV_MODULEID";
            internal const string PARAM_in_chartable = "IV_CHARTABLE";
            internal const string PARAM_oref_reports = "OCURSOR_REPORTS";
        }
        public class DG_GETDIAGNOSISMASTERDATA
        {
            internal const string NAME = "digital.DG_GETSIDEMASTER_PRC";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_OUT_GETDIAGNOSISMASTERDATA = "OCURSOR_SIDEDETAILS";
        }
        public class P_DELETEFAVOURITES_NEW
        {
            internal const string NAME = "P_DELETEFAVOURITES_NEW";
            internal const string PARAM_IN_FAVID = "IV_FAVID";
            internal const string PARAM_IN_IV_LOGINID = "IV_LOGINID";
        }
        public class GetAssessmentopPatientBanner_DG
        {
            internal const string NAME = "digital.p_GETOPPAITENTBANNER_DG";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_CREATEDdATE = "IN_StartDate";
            internal const string PARAM_OUT_cursor1 = "OCURSOR_OPBANNERDETAILS";
            internal const string PARAM_OUT_cursor2 = "OCURSOR_NOACTIVEIPOP";
        }


        public class GetAssessmentPatientBanner_DG
        {
            internal const string NAME = "FORMGEN.P_GETASSESSMENTPATBANNER_DG";
            internal const string PARAM_IN_UHID = "IV_UHID";
            internal const string PARAM_IN_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IN_LocationId = "IV_location";
            internal const string PARAM_OUT_CURSOR = "REFCURS_IP";
        }


        public class GetAssessmentPatientDetails
        {
            internal const string NAME = "digital.p_getFormdetailsfromUHID";
            internal const string PARAM_IN_UHID = "iv_UHID";
            internal const string PARAM_IN_IPNUMBER = "iv_IP_NUMBER";
            internal const string PARAM_IN_Status = "iv_STATUS";
            internal const string PARAM_IN_FormName = "iv_FORMNAME";
            internal const string PARAM_IN_Patientype = "iv_PATIENTType";
            internal const string PARAM_IN_Wardname = "iv_WARDNAME";
            internal const string PARAM_IN_BedNo = "iv_BEDNO";
            internal const string PARAM_IN_fromDate = "iv_fromdate";
            internal const string PARAM_IN_iv_Todate = "iv_todate";

            internal const string PARAM_OUT_CURSOR = "ocursor_result";
        }
        public class GetAssessmentFormName
        {
            internal const string NAME = "P_GETFORMNAMES";

            internal const string PARAM_IN_IV_LOCATION = "IV_LOCATION";

            internal const string PARAM_OUT_OV_RESULT = "OV_RESULT";
        }









        #endregion
        #region GetCardiac
        public class DG_GetCardiacDetails
        {
            internal const string SPNAME = "DIGITAL.P_GETIPCARDIACVITALS";
            internal const string PARAM_IN_UHID = "V_UHID";
            internal const string PARAM_IN_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_DOCTORID = "IV_DOCTORID";
            internal const string PARAM_OUT_VITALDETAILS = "OCURSOR_VITALDETAILS";
        }
        #endregion
        #region Doctor Fee
        #region Billing

        public class Billing_GetServiceItem
        {
            internal const string SPNAME = "digital.P_GetServices";
            internal const string PARAM_IN_LOCATIONID = "IV_LOCATIONID";
            internal const string PARAM_IN_PATIENTSERVICEID = "IN_PATIENTSERVICEID";
            internal const string PARAM_IN_DEPTID = "IV_DEPTID";
            internal const string PARAM_IN_CATEGORYID = "IN_CATEGORYID";
            internal const string PARAM_IN_SERVICETYPEID = "IN_SERVICETYPEID";

            internal const string PARAM_IN_SERVICENAME = "IV_SERVICENAME";
            internal const string PARAM_IN_BILLABLE = "IV_BILLABLE";
            internal const string PARAM_IN_SERVICESTATUS = "IV_SERVICESTATUS";
            internal const string PARAM_IN_RESTORABLE = "IV_RESTORABLE";
            internal const string PARAM_IN_SERVICEID = "IN_SERVICEID";

            internal const string PARAM_IN_TAXABLE = "IV_TAXABLE";
            internal const string PARAM_IN_SCHEDULABLE = "IV_SCHEDULABLE";
            internal const string PARAM_IN_WILDSERVICEITEM = "IV_WILDSERVICEITEM";
            internal const string PARAM_IN_AGE = "IN_AGE";
            internal const string PARAM_IN_GENDERID = "IV_GENDERID";

            internal const string PARAM_IN_PATIENTCONDITIONID = "IV_PATIENTCONDITIONID";
            internal const string PARAM_OUT_OC_SERVICELIST = "OC_SERVICELIST";
        }

        #endregion
        #region GetUHIDForAnIPNumber
        public class DB_GetUHIDForAnIPNumber
        {
            internal const string SPNAME = "adt.P_GetUHID";
            internal const string PARAM_IN_IPNUMBER = "IV_IPNUMBER";
            internal const string PARAM_IN_LOCATIONID = "iv_LocationId";
            internal const string PARAM_OUT_OCURSOR_DETAILS = "OCURSOR_DETAILS";
        }
        #endregion
        #region GetPatientOccupiedBeds
        public class DB_GetPatientOccupiedBeds
        {
            internal const string SPNAME = "adt.P_GetPatientOccupiedBeds";
            internal const string PARAM_IN_IPNUMBER = "IV_INPATIENTNO";
            internal const string PARAM_IN_UHID = "iv_UHID";
            internal const string PARAM_IN_LOCATIONID = "in_LocationID";
            internal const string PARAM_OUT_OCURSOR_RESULT = "OCURSOR_RESULT";
            internal const string PARAM_OUT_OCURSOR_TRANSFERHISTORY = "oCursor_TransferHistory";
        }
        #endregion
        #region GETPATIENTDETAILS
        public class DB_GETPATIENTDETAILS
        {
            internal const string SPNAME = "ahc.P_GETPATIENTDETAILS";
            internal const string PARAM_IN_REGISTRATIONNUMBER = "IN_REGISTRATIONNUMBER";
            internal const string PARAM_IN_UHID = "IN_UHID";
            internal const string PARAM_IN_PRN = "IN_PREREGISTRATIONNO";
            internal const string PARAM_IN_ERN = "IN_EMERGENCYNO";
            internal const string PARAM_IN_TEMPDRAFTID = "IV_TEMPDRAFTID";
            internal const string PARAM_IN_LOCATIONID = "IN_LOCATIONID";
            internal const string PARAM_IN_MASTERFLAG = "IN_MASTERFLAG";
            internal const string PARAM_OUT_COMPONENT1 = "OCURSOR_COMPONENT1";
            internal const string PARAM_OUT_COMPONENT3 = "OCURSOR_COMPONENT3";
            internal const string PARAM_OUT_COMPONENT4 = "OCURSOR_COMPONENT4";
            internal const string PARAM_OUT_COMPONENT5 = "OCURSOR_COMPONENT5";
            internal const string PARAM_OUT_COMPONENT6 = "OCURSOR_COMPONENT6";
            internal const string PARAM_OUT_COMPONENT7 = "OCURSOR_COMPONENT7";
            internal const string PARAM_OUT_COMPONENT8 = "OCURSOR_COMPONENT8";
            internal const string PARAM_OUT_COMPONENT9 = "OCURSOR_COMPONENT9";
            internal const string PARAM_OUT_COMPONENT10 = "OCURSOR_COMPONENT10";
            internal const string PARAM_OUT_COMPONENT11 = "OCURSOR_COMPONENT11";
            internal const string PARAM_OUT_COMPONENT12 = "OCURSOR_COMPONENT12";
            internal const string PARAM_OUT_COMPONENT13 = "OCURSOR_COMPONENT13";
            internal const string PARAM_OUT_COMPONENT14 = "OCURSOR_COMPONENT14";
            internal const string PARAM_OUT_COMPONENT15 = "OCURSOR_COMPONENT15";
            internal const string PARAM_OUT_COMPONENT16 = "OCURSOR_COMPONENT16";
            internal const string PARAM_OUT_COMPONENT17 = "OCURSOR_COMPONENT17";
            internal const string PARAM_OUT_COMPONENT18 = "OCURSOR_COMPONENT18";
            internal const string PARAM_OUT_ALTUID = "OCURSOR_ALTUID";

        }
        #endregion
        #region GetIPEditableServices
        public class GetIPEditableServices
        {
            internal const string SPNAME = "billing.P_GetIPEditableServices";
            internal const string PARAM_IN_IPNUMBER = "iv_PatientIdentifierNo";
            internal const string PARAM_IN_LOCATIONID = "iv_locationid";
            internal const string PARAM_IN_REGISTRATIONNUMBER = "iv_Registrationno";
            internal const string PARAM_OUT_OCURSOR_DETAILS = "oc_surgery";
        }
        #endregion
        #region ServicesRequest
        public class DB_ServicesRequest
        {
            internal const string SPNAME = "billing.P_ServiceRequest";
            internal const string PARAM_IN_iXMLServiceRequest = "iXMLServiceRequest";
            internal const string PARAM_IN_LoginID = "Iv_LoginID";
            internal const string PARAM_OUT_Outparam = "v_BufferCheck";
        }
        #endregion
        #endregion
        //end

        public class P_GETDRUGRECEIVEPENDINGDATA_DG
        {
            internal const string NAME = "DIGITAL.P_GETDRUGRECEIVEPENDINGDATA_DG";
            // internal const string PARAM_IN_Ipnumber = "in_ipnumber";
            internal const string PARAM_IN_ResourceId = "IV_RESOURCEID";
            internal const string PARAM_IN_LocationId = "IV_location";
            internal const string PARAM_OUT_PARAM_OUT_REFCURS_IP = "REFCURS_IP";
        }
        public class DG_CASEREFERAL_REPORT
        {
            internal const string NAME = "DIGITAL.DG_CROSSREFERAL_REPORT";
            //  internal const string NURSINGREPORT_NAME = "dg_NursingNotes_report";
            internal const string IN_Ipnumber = "IN_IPNUMBER";
            internal const string IN_LocationId = "IN_LOCATIONID";
            internal const string patient_details = "PATIENT_DETAILS";
            internal const string out_details = "OUT_DETAILS";

            //internal const string Out_QFcode = "Out_QFcode";
        }

        public class DG_RESULTNOTIFY
        {
            internal const string NAME = "DIGITAL.DG_TESTRESULTADDNOTIFY";
            internal const string PARAM_IN_NURSEID = "IV_NURSEID";
            internal const string PARAM_IN_PATIENTID = "IV_PATIENTID";
            internal const string PARAM_IN_LABREPORTVISITTIME = "IV_LABREPORTVISITTIME";
        }
    }

}
