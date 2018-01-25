﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConsoleApp1.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime ? BirthDate { get; set; }
        public DateTime ? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePage { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public int ? ReportsTo { get; set; }
        public string PhotoPath { get; set; }
        public virtual ICollection<Employee> Employees1 { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Territory> Territories { get; set; }
        public Employee()
        {
            Orders = new List<Orders>();
            Territories = new List<Territory>();
        }
    }
}