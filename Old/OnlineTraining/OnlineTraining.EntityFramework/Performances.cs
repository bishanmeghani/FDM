﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTraining.EntityFramework
{
    public class Performances
    {
        [Key]
        public virtual int performanceId { get; set; }
        public virtual double performancePercentage { get; set; }
    }
}