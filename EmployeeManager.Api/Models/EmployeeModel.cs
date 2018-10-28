﻿using EmployeeManager.Shared.Enums;
using System;

namespace EmployeeManager.Api.Models
{
    public class EmployeeModel
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public SalaryEnum SalaryType { get; set; }
        public decimal Salary { get; set; }
        public string Hours { get; set; }
    }
}