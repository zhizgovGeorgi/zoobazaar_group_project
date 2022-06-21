﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using MySql.Data.MySqlClient;


namespace DataAccessLayer
{
    public class VacationsDB : IVacations
    {
        private MySqlConnection conn;

        public VacationsDB()
        {
            conn = ConnectionDB.GetConnection();
        }
        public void AcceptVacation(Vacation vacation)
        {
            try
            {
                string sql = "UPDATE vacations SET Status=@Status WHERE RequestID=@ID";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ID", vacation.ID);
                cmd.Parameters.AddWithValue("@Status", "Accepted");
            }
            catch (MySqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void DenyVacation(Vacation vacation)
        {
            try
            {
                string sql = "UPDATE vacations SET Status=@Status WHERE RequestID=@ID";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@ID", vacation.ID);
                cmd.Parameters.AddWithValue("@Status", "Denied");
            }
            catch (MySqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Vacation> ReadVacations()
        {
            List<Vacation> vacations = new List<Vacation>();
            try
            {
                string sql = "Select RequestID, EmployeeID, StartDate, EndDate, Status FROM vacations WHERE Status=@Status AND CURRENT_DATE() BETWEEN StartDate AND EndDate";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                cmd.Parameters.AddWithValue("@Status", "Accepted");


                conn.Open();

                while (dr.Read())
                {
                    vacations.Add(new Vacation(Convert.ToInt32(dr["RequestID"]), Convert.ToInt32(dr["EmployeeID"]), Convert.ToDateTime(dr["StartDate"]), Convert.ToDateTime(dr["EndDate"])));
                }
            }
            catch (MySqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return vacations;
        }

        public void RequestVacation(Vacation vacation)
        {
            try
            {
                string sql = "INSERT INTO vacations (EmployeeID, StartDate, EndDate, Status) VALUES (@EmployeeID, @StartDate, @EndDate, @Status)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@EmployeeID", vacation.EmployeeID);
                cmd.Parameters.AddWithValue("@StartDate", vacation.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", vacation.EndDate);
                cmd.Parameters.AddWithValue("@Status", "Awaiting");
            }
            catch (MySqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
