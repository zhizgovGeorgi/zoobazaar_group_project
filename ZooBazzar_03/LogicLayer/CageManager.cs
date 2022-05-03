﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entities;

namespace LogicLayer
{
    public class CageManager
    {
        private List<Cage> cages;
        private CageDB db = new CageDB();

        public List<Cage> Cages { get { return cages; } }

        public CageManager()
        {
            cages = db.GetCages();
            InsertAnimalsInCage();
            
        }

        public void GetCages()
        {
            if (cages != null)
            {
                cages.Clear();
            }
            cages = db.GetCages();
        }

        public Cage GetCageByCageNr(int cageNr)
        {
            return cages.Find(x => x.CageNumber == cageNr);
        }

        public void InsertAnimalsInCage()
        {
            //foreach (Cage c in Cages)
            //{
            //    c.CageAnimals = db.GetAnimalsInCage(c.CageNumber);
            //    foreach (Animal a in c.CageAnimals)
            //    {
            //        a.FeedingTimes = db.GetFeedingTimes(a.AnimalCode);
            //    }
            //}

            for (int i = 0; i < cages.Count; i++)
            {
                cages[i].CageAnimals = db.GetAnimalsInCage(cages[i].CageNumber);
                for (int j = 0; j < cages[i].CageAnimals.Count; j++)
                {
                    cages[i].CageAnimals[j].FeedingTimes = db.GetFeedingTimes(cages[i].CageAnimals[j].AnimalCode);
                }
            }


        }

        public void GetCageAnimals(List<DailySchedule> schedules)
        {
            for (int i = 0; i < schedules.Count; i++)
            {
                schedules[i].Cage.CageAnimals = db.GetAnimalsInCage(schedules[i].Cage.CageNumber);
                for (int j = 0; j < schedules[i].Cage.CageAnimals.Count; j++)
                {
                    schedules[i].Cage.CageAnimals[j].FeedingTimes = db.GetFeedingTimes(schedules[i].Cage.CageAnimals[j].AnimalCode);
                }
            }
        }


        //public bool AddAnimalInCage(Animal animal, Cage cage)
        //{
        //    if (animal.AnimalType == cage.Type)
        //    {
        //        cages[]
        //    }
        //}
    }
}
