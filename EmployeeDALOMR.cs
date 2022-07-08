using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using OMRWebApp.Models;
using System.Data.Entity;
using MySql.Data.EntityFramework;
// this a emp class
namespace OMRWebApp.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EmployeeDALOMR: DbContext
    {
    // sample edit
        public DbSet<EmployeeBOL> emp { get; set; }
        public DbSet<EmployeeBOL> emp { get; set; }
        public EmployeeDALOMR() : base("WebDataCon")
        {
        }
    }
}
