using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using PremierSolutions.BussinesLogic;

namespace PremierSolutions.DataAccess
{
    class ContractMaintenanceAccess
    {
        string connect = "Data Source=.; Initial Catalog= CallCenterDatabase; Integrated Security= SSPI";
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;

        #region Insert Functions
        // Insert functions: These functions are used to add services, service levels (including security levels),
        // add packages add contract(aka create a contract)

        // Only the manager can use this method (or anyone with clearance to create services)
        public void InsertService(string name, string equipmentType, string workExpenses, int state)
        {
            string query = $"INSERT INTO Service VALUES({name}, {equipmentType}, {workExpenses},{state})";
            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                // MessageBox.Show() overload number 7
                MessageBox.Show("New service inserted succesfully", "Service Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // MessageBox.Show() overload number 7
                MessageBox.Show("Failed to insert new Service: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Only the manager can use this method (or anyone with clearance to create service levels)
        public void InsertServiceLevel(string levelName, string optOutDetails, double penaltiesForLateWork, double penaltiesForNonPerformance, int state, int securityLevelID)
        {
            string query = $"INSERT INTO ServiceLevel VALUES({levelName}, {optOutDetails}, {penaltiesForLateWork},{penaltiesForNonPerformance},{state},{securityLevelID})";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                // MessageBox.Show() overload number 7
                MessageBox.Show("New service level inserted succesfully", "Service Level Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // MessageBox.Show() overload number 7
                MessageBox.Show("Failed to insert new Service Level: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Only the manager can use this method (or anyone with clearance to create packages)
        public void InsertPackage(string packageName, string serviceIDs, string serviceLevelIDs)
        {
            string query = $"INSERT INTO ContractType VALUES('{packageName}', '{serviceIDs}', '{serviceLevelIDs}')";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);


            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                //MessageBox.Show("New package inserted succesfully", "Package Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("New package inserted succesfully");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Failed to insert new Package: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                Console.WriteLine("Failed to insert new Package");
            }
            finally
            {
                conn.Close();
            }
        }
        // Both the manager and call center personeel can use this method (or anyone with clearance to create contracts)
        // most likely to be used by the call senter personeel, as they deal with clients and create these contracts (sell the services)
        public void InsertContract(int contractTypeID, int clientID)
        {
            string query = $"INSERT INTO Contract VALUES({contractTypeID}, {clientID})";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("New contract inserted succesfully", "Contract Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert new Contract: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // The manager can use this method (or anyone with clearance to create security levels)
        public void InsertSecuriyLevel(string levelDescription, int availability, string emailSupport, string phoneSupport)
        {
            string query = $"INSERT INTO SecurityLevel VALUES({levelDescription}, {availability}, {emailSupport},{phoneSupport})";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("New security level inserted succesfully", "Security Level Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert new security level: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Update Functions: Update data
        // Only the manager can use this method (or anyone with clearance to update services data)
        public void UpdateService(int serviceID, string name, string equipmentType, string workExpenses)
        {
            string query = $"UPDATE Service SET Name = {name}, EquipmentType = {equipmentType}, WorkExpenses = {workExpenses} WHERE ServiceID = {serviceID}";
            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Service updated succesfully", "Service update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Service: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Only the manager can use this method (or anyone with clearance to update service levels data)
        public void UpdateServiceLevel(int serviceLevelID,string levelName, string optOutDetails, double penaltiesForLateWork, double penaltiesForNonPerformance)
        {
            string query = $"UPDATE ServiceLevel SET Name = {levelName}, OptOutDetails = {optOutDetails}, PenaltiesForLateWork = {penaltiesForLateWork}, PenaltiesForNOnPerformance= {penaltiesForNonPerformance} WHERE ServiceLevelID = {serviceLevelID}";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Service Level updated succesfully", "Service Level update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Service Level: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Only the manager can use this method (or anyone with clearance to update packages data)
        public void UpdatePackage(int contractTypeID, string packageName, int serviceID, int serviceLevelID)
        {
            string query = $"UPDATE ContractType SET PackageName = {packageName}, ServiceID = {serviceID}, ServiceLevelID= {serviceLevelID} WHERE ContractTypeID = {contractTypeID}";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Package updated succesfully", "Package update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Package: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Both the manager and call center personeel can use this method (or anyone with clearance to update contracts data)
        // usuua;y call center personeel
        // changing contract maybe from one type to another (maybe change client from one to another ? now sure how that would be useful) 
        // Check and if clientOD does not make sense -- remove from function.
        public void UpdateContract(int contractID, int contractTypeID, int clientID)
        {
            string query = $"UPDATE Contract SET ContractTypeID = {contractTypeID}, ClientID = {clientID} WHERE ContractID = {contractID}";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Contract updated succesfully", "Contract update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Contract: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // The manager can use this method (or anyone with clearance to update security levels data)
        public void UpdateSecurityLevel(int securityLevelID,string levelDescription, string emailSupport, string phoneSupport)
        {
            string query = $"UPDATE SecurityLevel SET LevelDescription= {levelDescription}, EmailSupport = {emailSupport}, PhoneSupport = {phoneSupport} WHERE SecurityLevelID = {securityLevelID}";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Security Level updated succesfully", "Security Level update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Security Level: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Update Functions: Overloading funcitons for ChangeState Functions
        // The functions in this area are purely for changing the state of items that make up the contracts.
        // All contract maintenance classes that have states will be changed in here
        // e,g when a package is no longer availale 
        // might add more states for when a package is on sale or promotion (e.g BIT promo) 

        // Only the manager can use this method (or anyone with clearance to update services)
        public void UpdateService(int serviceID, int state)
        {
            string query = $"UPDATE Service SET State = {state} WHERE ServiceID = {serviceID}";
            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                // MessageBox.Show() overload number 7
                MessageBox.Show("State updated succesfully", "Service State Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // MessageBox.Show() overload number 7
                MessageBox.Show("Failed to change status: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Only the manager can use this method (or anyone with clearance to update service levels)
        public void UpdateServiceLevel(int serviceLevelID, int state)
        {
            string query = $"UPDATE ServiceLevel SET State = {state} WHERE ServiceLevelID = {serviceLevelID}";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("State updated succesfully", "Service Level State Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to change status: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Only the manager can use this method (or anyone with clearance to update security levels)
        public void UpdateSecurityLevel(int securityLevelID, int availability)
        {
            string query = $"UPDATE SecurityLevel SET Availability = {availability} WHERE SecurityLevelID = {securityLevelID}";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("State updated succesfully", "Security Level State Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to change status: " + ex.Message, "Update Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region GetData
        // Get Service
        public SqlDataReader GetService(int serviceID)
        {
            string query = $"SELECT * FROM [Service] WHERE ServiceID = {serviceID}";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader service = null;
            try
            {
                conn.Open();
                service = command.ExecuteReader();
                // MessageBox.Show() overload number 7
                //MessageBox.Show("New service inserted succesfully", "Service Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Specified Service Found");
            }
            catch (Exception ex)
            {
                // MessageBox.Show() overload number 7
                //MessageBox.Show("Failed to insert new Service: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                Console.WriteLine("Cannot find specified Service");
            }
            finally
            {
                conn.Close();
            }

            return service;
        }

        public SqlDataReader GetServiceLevel(int serviceLevelID)
        {
            string query = $"SELECT * FROM ServiceLevel WHERE ServiceLevelID = {serviceLevelID}";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader service = null;
            try
            {
                conn.Open();
                service = command.ExecuteReader();
                // MessageBox.Show() overload number 7
                //MessageBox.Show("New service inserted succesfully", "Service Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Specified Service Level Found");
            }
            catch (Exception ex)
            {
                // MessageBox.Show() overload number 7
                //MessageBox.Show("Failed to insert new Service: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                Console.WriteLine("Cannot find specified Service Level");
            }
            finally
            {
                conn.Close();
            }

            return service;
        }
        #endregion
    }
}
