﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Garage25.Models
{
    public class VehiclesDb : DbContext
    {
        public DbSet<vehicle> vehicles { get; set; }
    }
}