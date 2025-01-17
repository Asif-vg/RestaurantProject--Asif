﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.Models
{
    public class FeatureToRestaurant
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RestaurantFeatures")]
        public int FeatureId { get; set; }
        public RestaurantFeatures RestaurantFeatures { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }






    }
}
