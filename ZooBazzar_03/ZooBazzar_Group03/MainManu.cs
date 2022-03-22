﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazzar_Group03.Employeee;

namespace ZooBazzar_Group03
{
    public partial class MainManu : Form
    {
        private EmployeeManagment employeeManagment = new EmployeeManagment();
        private AccountManager accountManager = new AccountManager();
        AnimalDB animalDB = new AnimalDB();
        AnimalManager animalManager = new AnimalManager();
        
        public EmployeeManagment EmployeeManagment { get { return employeeManagment; } }
        public MainManu(Account account)
        {
            InitializeComponent();
            updateEmployeeUI();         
            lblHello.Text = $"Hello, {account.Username}!";
            employeeManagment.ChangedEmployee += OnChangedEmployee;
            tbUsernameSettings.Text = account.Username;
            tbPasswordSettings.Text = account.Password;
            cbSpecialization.DataSource = Enum.GetValues(typeof(Specialization));
            updateEmployee();
            GetDate(0);
        }




        int index = 0;
        public void GetDate(int index)
        {
            calendar.Controls.Clear();

            for (int i = 0; i < 7; i++)
            {
                DateTime day = DateTime.Now;

                day = day.AddDays(i + index);
                Date uc = new Date();

                string date = $"{day.Day} {day.ToString("MMM")} {day.Year}";
                string weekday = day.DayOfWeek.ToString();
                uc.GetDate(weekday, date);

                calendar.Controls.Add(uc);

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index -= 7;
            GetDate(index);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index += 7;
            GetDate(index);
        }



        private void btnShowAll_Click(object sender, EventArgs e)
        {
            updateEmployeeUI();
        }
        private void btnFindBySpecialization_Click(object sender, EventArgs e)
        {
            updateEmployeeUIbySpecialization((Specialization)cbSpecialization.SelectedItem);
        }

        private void updateEmployeeUI()
        {
           List<Employee> employees = employeeManagment.GetEmployees();

           flpEmployees.Controls.Clear();
           foreach(Employee e in employees)
            {
                flpEmployees.Controls.Add(new ucEmployee(e));

            }           
        }
        private void updateEmployeeUIbySpecialization(Specialization specialization)
        {
            List<Caretaker> caretakers = employeeManagment.CaretakersBySpecialization(specialization);
            flpEmployees.Controls.Clear();
            foreach (Caretaker c in caretakers )
            {
                flpEmployees.Controls.Add(new ucEmployee(c));
            }
        }

        private void updateEmployeeUIbyFirstName(string name)
        {
            List<Employee> employees = employeeManagment.GetEmployees();

            flpEmployees.Controls.Clear();
            foreach (Employee e in employees)
            {
                if(string.Equals(e.Name,name,StringComparison.OrdinalIgnoreCase) || e.Name.Contains(name,StringComparison.OrdinalIgnoreCase))
                {                
                    flpEmployees.Controls.Add(new ucEmployee(e));
                }

            }
        }
        

        private void btnFindByFirstName_Click(object sender, EventArgs e)
        {
            updateEmployeeUIbyFirstName(tbFirstName.Text);
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
           
        }

        public void OnChangedEmployee()
        {
            employeeManagment.DataRefresh();
            updateEmployee();
            updateEmployeeUI();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAllAnimals_Click(object sender, EventArgs e)
        {
            flpAnimals.Controls.Clear();
            for (int i = 0; i < animalManager.animals.Count; i++)
            {
                AnimalPic animalPic = new AnimalPic(animalManager.animals[i]);
                flpAnimals.Controls.Add(animalPic);
            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            FormAddAnimal frmAddAnimal = new FormAddAnimal();
            frmAddAnimal.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.Show();
        }

        private void updateEmployee()
        {
            lbEmployees.Items.Clear();
            foreach (Employee employee in employeeManagment.GetEmployees())
            {
                lbEmployees.Items.Add(employee.ToString());
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if(lbEmployees.SelectedIndex >= 0 && lbEmployees.SelectedIndex < employeeManagment.GetEmployees().Count)
            {
                EditEmployee editEmployee = new EditEmployee(lbEmployees.SelectedIndex);
                editEmployee.Show();
            }
        }

        private void btnRemoveEmployee_Click_1(object sender, EventArgs e)
        {
            if(lbEmployees.SelectedIndex>=0 && lbEmployees.SelectedIndex < employeeManagment.GetEmployees().Count)
            {
                employeeManagment.RemoveEmployee(lbEmployees.SelectedIndex);
            }
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            accountManager.UpdatePassword(tbUsernameSettings.Text, tbPasswordSettings.Text);
        }
    }
}
