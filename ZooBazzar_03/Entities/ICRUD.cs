﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public interface ICRUD<T>
    {
        public void Add(T obj);
        public List<T> Read();
        public void Update(int id, T obj);
        public void Delete(int id);
        void ChangePassword(string username, string password);
        string GetEmployeeWorkPositionByAccount(string username);
        void ChangeCredentials(T obj);
    }
}
