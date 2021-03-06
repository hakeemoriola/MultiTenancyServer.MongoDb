﻿using MongoDB.Bson;
using OryxDomainServices;
using System;
using System.ComponentModel.DataAnnotations;


namespace OENT.Entities.General
{
    public class MenuSecurable : IEntityBase<ObjectId>
    {
        public ObjectId Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        [MaxLength(1)]
        public string Status { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserSign { get; set; }
        [Required]
        public ObjectId MenuId { get; set; }
        [Required]
        public int Securable { get; set; }
        public string CreatedBy { get; set; }
    }
}
