using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2V2
{
    public static class DBController
    {
        public static async Task<List<Employee>> GetEmployees()
        {
            //get list of all employees
            using (var db = new Session2Entities())
            {
                return (from e in db.Employees
                        select e).ToList();
            }
        }
        public static async Task<List<AssetInfo>> getAssets(int empID)
        {
            //get all assets for the datagridview
            using (var db = new Session2Entities())
            {
                List<AssetInfo> returnlist = new List<AssetInfo>();
                var query = (from a in db.Assets
                             where a.EmployeeID == empID
                             select a);
                foreach (var item in query)
                {
                    AssetInfo availableAssets = new AssetInfo();
                    availableAssets.AssetID = (int)item.ID;
                    availableAssets.AssetSN = item.AssetSN;
                    availableAssets.AssetName = item.AssetName;
                    DateTime? dt = null;
                    int numberOfEM = 0;
                    var EMs = (from e in db.EmergencyMaintenances
                               where e.AssetID == item.ID
                               where e.EMEndDate != null
                               orderby e.EMEndDate descending
                               select e).ToList();
                    try
                    {
                        dt = EMs.First().EMEndDate;
                        numberOfEM = EMs.Count();
                    }
                    catch (Exception e)
                    {

                    }
                    availableAssets.LastClosedEM = dt;
                    availableAssets.NumberOfEM = numberOfEM;
                    returnlist.Add(availableAssets);
                }
                return returnlist;
            }
        }
        public static async Task<AssetEMPageInfo> GetAssetInfo(int assetID)
        {
            //get information on the asset from database
            using (var db = new Session2Entities())
            {
                AssetEMPageInfo AssetPage = new AssetEMPageInfo();
                var priorities = (from p in db.Priorities
                                  select p.Name).ToList();
                var asset = (from e in db.EmergencyMaintenances
                             where e.ID == assetID
                             select e).First();
                AssetPage.AssetSN = asset.Asset.AssetSN;
                AssetPage.AssetID = (int)asset.AssetID;
                AssetPage.AssetName = asset.Asset.AssetName;
                AssetPage.Department = asset.Asset.DepartmentLocation.Department.Name;
                AssetPage.Priorities = priorities;
                return AssetPage;
            }
        }
        public static async Task addEmergencyMaintenance(AssetEMPageInfo info)
        {
            //insert maintenance request
            using (var db = new Session2Entities())
            {
                var ID = (from em in db.EmergencyMaintenances
                          orderby em.ID descending
                          select em.ID).First() + 1;
                var priorityID = (from p in db.Priorities
                                  where p.Name == info.SelectedPriorities
                                  select p.ID).First();
                EmergencyMaintenance EM = new EmergencyMaintenance();
                EM.ID = ID;
                EM.PriorityID = priorityID;
                EM.AssetID = info.AssetID;
                EM.DescriptionEmergency = info.Description;
                EM.OtherConsiderations = info.Considerations;
                EM.EMTechnicianNote = null;
                EM.EMReportDate = DateTime.Now;
                EM.EMStartDate = DateTime.Now;
                db.EmergencyMaintenances.Add(EM);
                await db.SaveChangesAsync();
            }

        }
        public static async Task<List<EMRequests>> getOpenRequests()
        {
            //get requests that are currently open, eg, no end date
            using (var db = new Session2Entities())
            {
                List<EMRequests> returnlist = new List<EMRequests>();
                var query = (from em in db.EmergencyMaintenances
                             where em.EMEndDate == null
                             orderby em.PriorityID descending
                             select em).ToList();
                foreach (var item in query)
                {
                    EMRequests em = new EMRequests();
                    em.EMID = (int)item.ID;
                    em.AssetSN = item.Asset.AssetSN;
                    em.AssetName = item.Asset.AssetName;
                    em.Department = item.Asset.DepartmentLocation.Department.Name;
                    em.RequestDate = item.EMReportDate;
                    em.EmployeeName = $"{item.Asset.Employee.FirstName} {item.Asset.Employee.LastName}";
                    returnlist.Add(em);
                }
                return returnlist;
            }
        }
        public static async Task<ManageRequestInfo> getEMInfo(int emID)
        {
            //get information on the selected EM
            using (var db = new Session2Entities())
            {
                ManageRequestInfo info = new ManageRequestInfo();
                var query = (from em in db.EmergencyMaintenances
                             where em.ID == emID
                             select em).First();
                var parts = (from p in db.Parts
                             select p.Name).ToList();
                info.EMID = emID;
                info.AssetID = (int)query.AssetID;
                info.AssetName = query.Asset.AssetName;
                info.Department = query.Asset.DepartmentLocation.Department.Name;
                info.EndDate = query.EMEndDate;
                info.StartDate = query.EMStartDate;
                info.listOfParts = parts;
                info.TechnicianNote = query.EMTechnicianNote;
                return info;
            }
        }
        public static async Task updateEMData(ManageRequestInfo info)
        {
            using (var db = new Session2Entities())
            {
                var query = (from em in db.EmergencyMaintenances
                             where em.ID == info.EMID
                             select em).First();
                query.EMStartDate = info.StartDate;
                query.EMEndDate = info.EndDate;
                query.EMTechnicianNote = info.TechnicianNote;
                await db.SaveChangesAsync();
            }
        }
        public static async Task<Part> getPartfromName(string partname)
        {
            using (var db = new Session2Entities())
            {
                var part = (from p in db.Parts
                            where p.Name == partname
                            select p).FirstOrDefault();
                return part;
            }
        }
    }
}
