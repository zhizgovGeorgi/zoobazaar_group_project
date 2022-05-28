﻿using Entities;


namespace LogicLayer
{
    public class EmployeeManagment
    {
        public delegate void ChangedEmployeeEventHandler();
        public event ChangedEmployeeEventHandler ChangedEmployee;


        private static List<Employee> employees = new List<Employee>();
        ICRUD<Employee> crud;
        public EmployeeManagment(ICRUD<Employee> crud)
        {
            this.crud = crud;
            employees = crud.Read();
        }

        public Caretaker GetCaretakerById(int id)
        {
            return AllCaretakers().Find(c => c.Id == id);
        }

        
        public bool AddEmployee(Employee employee)
        {
            if(employees == null)
                employees = new List<Employee>();

            if (!employees.Contains(employee))
            {
                crud.Add(employee);
                employees.Add(employee);
                OnChangedEmployee();
                return true;
            }
            return false;
        }       
        public List<Employee> GetEmployees()
        {
            return employees;
        }
        public List<Caretaker> AllCaretakers()
        {
            List<Caretaker> result = new List<Caretaker>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] is Caretaker)
                {
                    result.Add((Caretaker)employees[i]);
                }
            }
            return result;
        }
        public List<Caretaker> CaretakersBySpecialization(Specialization specialization)
        {
            List<Caretaker> result = new List<Caretaker>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] is Caretaker)
                {
                    Caretaker caretaker = (Caretaker)employees[i];
                    if(caretaker.GetSpecialization() == specialization)
                    {
                       result.Add(caretaker);
                    }
                }
            }
            return result;
        }

        protected virtual void OnChangedEmployee()
        {
            if (ChangedEmployee != null)
                ChangedEmployee();
        }

        private string positionCheck(Employee employee)
        {
            if (employee is Caretaker caretaker)
            {

                return caretaker.GetSpecialization().ToString();
            }
            else if (employee is ResourcePlanner)
            {
                return "Resource planner";
            }
            else
            {
                return "Manager";
            }
        }
        public void DataRefresh()
        {
            employees = crud.Read();
        }

        public void UpdateEmployee(int index,Employee employee)
        {
            if(index >= 0)
            {
                crud.Update(employees[index].Id, employee);
                employees[index] = employee;
                OnChangedEmployee();
            }
        }

        public Employee GetEmployee(string EmployeeName)
        {
            return employees.Find(x => x.Name == EmployeeName);
        }

        public Employee GetEmployeeById(int id)
        {
            return employees.Find(x => x.Id == id);
        }

        public Employee GetEmployeeByUsername(string username)
        {
            return employees.Find(x => x.Account.Username == username);
        }
    }
}
