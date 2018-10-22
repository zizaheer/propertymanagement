﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("App_Month")]
    public class AppMonthPoco
    {
        [Key]
        public int MonthId { get; set; }
        public string MonthName { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }

    }
}