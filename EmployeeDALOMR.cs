﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using OMRWebApp.Models;
using System.Data.Entity;
using MySql.Data.EntityFramework;

//First By Pranjal
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
