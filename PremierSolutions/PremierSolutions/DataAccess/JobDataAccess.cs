﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using PremierSolutions.BussinesLogic;

namespace PremierSolutions.DataAccess
{
    class JobDataAccess
    {
        //Constuctor
        public JobDataAccess()
        {
        }

        //Set Connection String
        string connect = "Data Source=.; Initial Catalog= CallCenterDatabase; Integrated Security= SSPI";
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader readers;

        //Objects
        Job objJob = new Job();

        public void InsertJob(int jobStatus, int incidentRef, int assignedWorkerID)
        {
            string query = @"INSERT INTO Job VALUES ( '" + jobStatus + "', '" + incidentRef + "', '" + assignedWorkerID + "')";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.BeginExecuteNonQuery();
                MessageBox.Show("Job Made!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Job wasn't made: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateJob(int jobRef, int jobStatus, int assignedWorkerID)
        {
            string query = @"UPDATE Job SET JobStatus = '" + jobStatus + "', AssignedWorkerID = '" + assignedWorkerID + "' WHERE IncidentRef = '" + jobRef + "'";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.BeginExecuteNonQuery();
                MessageBox.Show("Job updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Job not updated: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void CloseJob(int jobID)
        {
            string query = @"UPDATE Job SET JobStatus = '" + 1 + "' WHERE IncidentRef = '" + jobID + "'";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.BeginExecuteNonQuery();
                MessageBox.Show("Job Closed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Job wasn't closed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void FindAvailableWorkers()
        {
        }

        public List<Job> DisplayJob()
        {
            string query = @"SELECT * FROM Jobs";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);
            List<Job> jobData = new List<Job>();

            try
            {
                readers = command.ExecuteReader();

                if (readers.Read())
                {
                    objJob.CallWorkerID = int.Parse(readers[2].ToString());
                    objJob.IncedentID = int.Parse(readers[1].ToString());

                    if (int.Parse(readers[2].ToString()) == 1)
                    {
                        objJob.JobStatus = true;
                    }
                    else
                    {
                        objJob.JobStatus = false;
                    }

                    jobData.Add(new Job(objJob.CallWorkerID, objJob.JobStatus, objJob.IncedentID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return jobData;
        }

        public List<Job> DisplayJob(int employeeID)
        {
            string query = @"SELECT * FROM Jobs WHERE employeeID = ( '" + employeeID + "' )";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);
            List<Job> jobData = new List<Job>();

            try
            {
                readers = command.ExecuteReader();

                if (readers.Read())
                {
                    objJob.CallWorkerID = int.Parse(readers[2].ToString());
                    objJob.IncedentID = int.Parse(readers[1].ToString());

                    if (int.Parse(readers[2].ToString()) == 1)
                    {
                        objJob.JobStatus = true;
                    }
                    else
                    {
                        objJob.JobStatus = false;
                    }

                    jobData.Add(new Job(objJob.CallWorkerID, objJob.JobStatus, objJob.IncedentID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return jobData;
        }
    }
}
