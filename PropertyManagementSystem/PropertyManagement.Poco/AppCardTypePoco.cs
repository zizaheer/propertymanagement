﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Poco
{
    [Table("App_CardType")]
    public class AppCardTypePoco : IPoco
    {
        [Key]
        public int CardTypeId { get; set; }
        public string CardTypeName { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
