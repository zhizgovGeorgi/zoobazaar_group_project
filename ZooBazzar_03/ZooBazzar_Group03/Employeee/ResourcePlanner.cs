﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazzar_Group03
{
    public class ResourcePlanner : Employee
    {
        public ResourcePlanner(Account account, string name, string lastname, string address, DateTime birthdate, string email, string phone, string emergencyContact, string bsn) : base(account, name, lastname, address, birthdate, email, phone, emergencyContact, bsn)
        {

        }
    }
}