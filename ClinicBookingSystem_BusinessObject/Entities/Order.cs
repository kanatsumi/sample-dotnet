﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBookingSystem_BusinessObject.Entities
{
    public class Order : BaseEntities
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        //User
        public int UserId { get; set; }
        public User User { get; set; }
        //Services
        public ICollection<Service> Services { get; set; }
        //Transaction
        public Transaction Transaction { get; set; }
    }
}
