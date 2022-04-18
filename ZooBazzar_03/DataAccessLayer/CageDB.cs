﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using Entities;

namespace DataAccessLayer
{
    public class CageDB
    {
        private MySqlConnection conn;

        public CageDB()
        {
            conn = ConnectionDB.GetConnection();
        }

        public List<Cage> GetCages()
        {
            List<Cage> cages = new List<Cage>();
            try
            {
                string sql = "SELECT * from cage";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cages.Add(new Cage(Convert.ToInt32(reader["CageNumber"]), Convert.ToInt32(reader["Capacity"]), Convert.ToInt32(reader["AnimalsOutside"]), Convert.ToInt32(reader["AnimalsInside"]), (AnimalType)Enum.Parse(typeof(AnimalType), reader["AnimalType"].ToString()), GetAnimalsInCage(Convert.ToInt32(reader["CageNumber"])), reader["Species"].ToString()));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                conn.Close();
            }
            return cages;
        }

        private List<Animal> GetAnimalsInCage(int cageNumber)
        {
            List<Animal> cageAnimals = new List<Animal>();
            try
            {
                string sql = "Select AnimalCode, CageNumber, Diet, AnimalType, Species, WeeklyFeedigIteration, timeSlot FROM animals a INNER JOIN feedingTime ft ON a.AnimalCode = ft.AnimalCode WHERE CageNumber=@cageNumber";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CageNumber", cageNumber);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cageAnimals.Add(new Animal(Convert.ToString(reader["AnimalCode"]), Convert.ToInt32(reader["CageNumber"]), (Diet)Enum.Parse(typeof(Diet), reader["Diet"].ToString()), (AnimalType)Enum.Parse(typeof(AnimalType), reader["AnimalType"].ToString()), reader["Species"].ToString(), GetFeedingTimes(reader["AnimalCode"].ToString()), Convert.ToInt32(reader["weeklyFeedingIteration"])));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                conn.Close();
            }
            return cageAnimals;

        }


        private List<string> GetFeedingTimes(string animalCode)
        {
            List<string> feedingTimes = new List<string>();
            try
            {
                string sql = "Select timeSlot FROM feedingTime WHERE AnimalCide = @code";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@code", animalCode);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    feedingTimes.Add(reader["animalSlot"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                conn.Close();
            }
            return feedingTimes;
        }


    }
}
