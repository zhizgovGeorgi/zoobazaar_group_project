﻿using MySql.Data.MySqlClient;
using Entities;

namespace DataAccessLayer
{
    public class AnimalDB: IAnimalDB<Animal>
    {
        private MySqlConnection conn;
        private List<Animal> animals; 

        public AnimalDB()
        {
            conn = ConnectionDB.GetConnection();
            animals = new List<Animal>();
        }

        public List<Animal> GetAnimals()
        {
            try
            {
                string sql = "SELECT * from animal";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                List<string> time = new List<string>();


                while (reader.Read())
                {
                    animals.Add(new Animal(Convert.ToString(reader["AnimalCode"]), Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["CageNumber"]), reader["Name"].ToString(), reader["Gender"].ToString(), reader["ReasonForArrival"].ToString(), reader["ReasonOFDeparture"].ToString(), (Diet)Enum.Parse(typeof(Diet), reader["Diet"].ToString()), (AnimalType)Enum.Parse(typeof(AnimalType), reader["AnimalType"].ToString()), reader["Species"].ToString(), reader["YearOfArrival"].ToString(), reader["YearOfDeparture"].ToString(), reader["Birthdate"].ToString(), (Specialization)Enum.Parse(typeof(Specialization), reader["Specialist"].ToString()), null, Convert.ToInt32(reader["WeeklyFeedingIteration"]), null));

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
            return animals;
        }

        public void AddAnimalToDB(Animal animal, Specialization specialization)
        {
            try
            {
                string sql = "INSERT INTO animal (AnimalCode, Name, Gender, AnimalType, Species, CageNumber, Birthdate, ReasonForArrival, YearOfArrival, YearOfDeparture, ReasonOFDeparture, Diet, Specialist, WeeklyFeedingIteration) VALUES(@animalCode, @name, @gender, @animalType, @species, @cageNumber, @birthdate, @reasonForArrival, @yearOfArrival, @yearOfDeparture, @reasonForDeparture, @diet, @specialist, @weeklyFeedingIteration);";

                for (int i = 0; i < animal.FeedingTimes.Count; i++)
                {
                    sql += $"INSERT INTO feedingtime (AnimalCode, timeSlot) VALUES (@animalCode, @time{i});";
                }


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@animalCode", animal.AnimalCode);
                cmd.Parameters.AddWithValue("@name", animal.Name);
                cmd.Parameters.AddWithValue("@gender", animal.Gender);
                cmd.Parameters.AddWithValue("@animalType", animal.AnimalType);
                cmd.Parameters.AddWithValue("@species", animal.Specie);
                cmd.Parameters.AddWithValue("@cageNumber", animal.CageNumber);
                cmd.Parameters.AddWithValue("@birthdate", animal.Birthdate);
                cmd.Parameters.AddWithValue("@reasonForArrival", animal.ReasonForArrival);
                cmd.Parameters.AddWithValue("@yearOfArrival", animal.YearOfArrival);             
                cmd.Parameters.AddWithValue("@diet", animal.Diet);
                cmd.Parameters.AddWithValue("@specialist", specialization);
                cmd.Parameters.AddWithValue("@weeklyFeedingIteration", animal.WeeklyFeedingIteration);

                for (int i = 0; i < animal.FeedingTimes.Count; i++)
                {
                    cmd.Parameters.AddWithValue($"@time{i}", animal.FeedingTimes[i]);
                }

                conn.Open();
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("New animal has been added");
                }
                else
                {
                    MessageBox.Show("Failed to add a new animal");
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

        }


        public void UpdateAnimalInDB(Animal animal, int id)
        {
            try
            {
                string sql = "UPDATE animal set AnimalCode=@animalCode, Name=@name, AnimalType=@animalType, Species=@species, CageNumber=@cageNumber, Birthdate=@birthdate, ReasonForArrival=@reasonForArrival, YearOfArrival = @yearOfArrival, YearOfDeparture=@yearOfDeparture, ReasonOFDeparture=@reasonForDeparture, Diet=@diet WHERE id=@id;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@animalCode", animal.AnimalCode);
                cmd.Parameters.AddWithValue("@name", animal.Name);
                cmd.Parameters.AddWithValue("@animalType", animal.AnimalType);
                cmd.Parameters.AddWithValue("@species", animal.Specie);
                cmd.Parameters.AddWithValue("@cageNumber", animal.CageNumber);
                cmd.Parameters.AddWithValue("@birthdate", animal.Birthdate);
                cmd.Parameters.AddWithValue("@reasonForArrival", animal.ReasonForArrival);
                cmd.Parameters.AddWithValue("@yearOfArrival", animal.YearOfArrival);
                cmd.Parameters.AddWithValue("@yearOfDeparture", animal.YearOfDeparture);
                cmd.Parameters.AddWithValue("@reasonForDeparture", animal.ReasonForDeparture);
                cmd.Parameters.AddWithValue("@diet", animal.Diet);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("The information has been updated");
                }
                else
                {
                    MessageBox.Show("Failed to update the information");
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
        }




        public void DeleteAnimalFromDB(int id, string reasonForDeparture)
        {
            try
            {
                string sql = "UPDATE animal SET ReasonOFDeparture=@reasonForDeparture WHERE id=@id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@reasonForDeparture", reasonForDeparture);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Animal has been deleted from the database");
                }
                else
                {
                    MessageBox.Show("Failed to delete the animal from the database");
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

        }
        public bool HasImage(string animalCode)
        {
            string sql = "SELECT Picture, ap.AnimalCode FROM animalpictures ap INNER JOIN animal a ON ap.AnimalCode = a.AnimalCode WHERE ap.AnimalCode = @animalCode;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@animalCode", animalCode);
            if (cmd.ExecuteScalar() == null)
            {
                conn.Close();
                return false;
            }
            else
            {
                conn.Close();
                return true;
            }
        }

        public MemoryStream GetMemoryStream(string animalCode)
        {
            string sql = "SELECT Picture, ap.AnimalCode FROM animalpictures ap INNER JOIN animal a ON ap.AnimalCode = a.AnimalCode WHERE ap.AnimalCode = @animalCode;";
            MySqlCommand cmd;
            MySqlDataReader dr;

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@animalCode", animalCode);

            conn.Open();

            byte[] img = (byte[])cmd.ExecuteScalar();
            MemoryStream ms = new MemoryStream(img);
            conn.Close();
            return ms;

        }

        public List<string> GetFeeding(Animal animal)
        {
            List<string> feedingTimes = new List<string>();
            try
            {
                string sql = "SELECT timeSlot FROM feedingtime f INNER JOIN animal a on f.AnimalCode = a.AnimalCode where f.AnimalCode = @animalCode";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@animalCode", animal.AnimalCode);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    feedingTimes.Add(dr["timeSlot"].ToString());
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

        public List<string> GetNotes(Animal animal)
        {
            List<string> notes = new List<string>();
            try
            {
                string sql = "SELECT Note from animalnotes an INNER JOIN animal a on a.id=an.ID WHERE an.ID=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", animal.Id);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    notes.Add(dr["Note"].ToString());
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
            return notes;
        }

        public void AddNote(int id, string note)
        {
            try
            {
                string sql = "INSERT INTO animalnotes (ID, Note) VALUES(@id, @note);";
                


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@note", note);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Note added");
                }
                else
                {
                    MessageBox.Show("Failed to add a note");
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
        }


    }

}
