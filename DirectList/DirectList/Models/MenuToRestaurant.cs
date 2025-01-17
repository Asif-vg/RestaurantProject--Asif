﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Models
{
    public class MenuToRestaurant
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(1000)]
        public string Spices { get; set; }
        [Column(TypeName ="money")]
        public decimal Price { get; set; }
        [ForeignKey("Menu")]
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }






    }
}
