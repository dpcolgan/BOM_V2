using BOM_V2.Controllers.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BOM_V2.Controllers;
using BOM_V2.Models;

namespace BOM_V2.Controllers
{
    public class BOMDataController : ApiController
    {
        #region IS THIS USER AN ADMIN
        [HttpGet]
        [Route("api/Database/InsertIncident")]
        public bool InsertIncident(BoroughIncident INC)
        {
            try
            {
                using (BoroEntities BD = new BoroEntities())
                {
                    BoroughIncident BI = new BoroughIncident();
                    BI.IncidentStatusID = INC.IncidentStatusID;
                    BI.IncidentTypeID = INC.IncidentTypeID;
                    BI.IncidentReportDate = INC.IncidentReportDate;
                    BI.IncidentReportedBy = INC.IncidentReportedBy;
                    BI.IncidentReportedByContactPhone = INC.IncidentReportedByContactPhone;
                    BI.LastUpdatedBy = INC.LastUpdatedBy;
                    BI.ViolationCode = INC.ViolationCode;
                    BI.IncidentReportText = INC.IncidentReportText;
                    BI.IncidentStreetAddress1 = INC.IncidentStreetAddress1;
                    BI.IncidentStreetAddress2 = INC.IncidentStreetAddress2;
                    BD.BoroughIncidents.Add(BI);
                    BD.SaveChanges();

                    return true;
                }

            }
            catch(Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
