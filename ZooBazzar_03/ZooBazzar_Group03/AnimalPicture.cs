﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using DataAccessLayer;
using Entities;
using LogicLayer;




namespace ZooBazzar_Group03
{
    public partial class AnimalPicture : UserControl
    {
        public AnimalPicture()
        {
            InitializeComponent();

        }

        private Schedule schedule = null;
        public AnimalPicture(int cage, Form callingForm, string date, DateTime currentDate)
        {
            schedule = callingForm as Schedule;
            InitializeComponent();
            this.cageNr = cage;
            this.date = date;
            this.currentDate = currentDate;
        }

        ScheduleManager sm = new ScheduleManager();
        EmployeeManagment em = new EmployeeManagment();
        CageManager cm = new CageManager();

        int cageNr;

        string date;

        DateTime currentDate;


        private void pbAnimal_Click(object sender, EventArgs e)
        {
            Cage cage = cm.GetCageByCageNr(cageNr);

            
            schedule.lblAnimalType.Text = cage.Type.ToString();
            schedule.lblSpecies.Text = cage.Species.ToString();
            schedule.lblCageNumber.Text = cage.ToString();

            int caretakerId = sm.AssignedCaretaker(date, cageNr);

            if (sm.CheckDate(currentDate))
            {
                if (caretakerId == 0)
                {
                    schedule.cmbEmployees.Text = "";
                    schedule.cmbEmployees.Items.Clear();

                    foreach (Caretaker s in sm.GetCaretakers(cageNr))
                    {
                        schedule.cmbEmployees.Items.Add($"Employee: {s.Name} (ID: {s.Id})");
                    }
                    schedule.btnAssign.Enabled = true;
                    schedule.btnEditEmployee.Enabled = false;
                }
                else
                {
                    schedule.cmbEmployees.Items.Clear();

                    

                    schedule.cmbEmployees.Text = $"Employee: {em.GetCaretakerById(caretakerId).Name} (ID: {caretakerId})";
                    foreach (Caretaker s in sm.GetCaretakers(cageNr))
                    {
                        schedule.cmbEmployees.Items.Add($"Employee: {s.Name} (ID: {s.Id})");
                    }
                    schedule.btnAssign.Enabled = false;
                    schedule.btnEditEmployee.Enabled = true;
                }
            }
            else
            {
                schedule.cmbEmployees.Enabled = false;
                schedule.cmbEmployees.Text = "";

                if (caretakerId != 0)
                {
                    schedule.cmbEmployees.Text = $"Employee: {em.GetCaretakerById(caretakerId).Name} (ID: {caretakerId})";
                }
                else
                {
                    schedule.cmbEmployees.Text = "No one fed the poor animal!";
                }
            }

        }

        public void GetPicture(MemoryStream ms, int cage)
        {
            pbAnimal.Image = Image.FromStream(ms);
            lblName.Text = cage.ToString();
        }


    }
}
