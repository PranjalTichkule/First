﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using OMRWebApp.Models;
using System.Data.Entity;
using MySql.Data.EntityFramework;
//Commit by Pranjal
namespace OMRWebApp.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EmployeeDALOMR: DbContext
    {
        public DbSet<EmployeeBOL> emp { get; set; }
        public EmployeeDALOMR() : base("WebDataCon")
        {
        }
    }
}
