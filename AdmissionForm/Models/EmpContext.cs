using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdmissionForm.Models
{
    public class EmpContext : DbContext
    {
       public  DbSet<Emp> empss { get; set; }
    }
}