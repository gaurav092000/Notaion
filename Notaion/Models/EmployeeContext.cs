﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Notaion.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set;}   

    }
}