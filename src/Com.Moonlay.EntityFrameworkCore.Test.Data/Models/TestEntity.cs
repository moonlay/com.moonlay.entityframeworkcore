﻿using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UnitTest.Models
{
    public class TestEntity : BaseEntity<string>, IAuditEntity, ISoftEntity
    {

        [Key]
        public string Code { get; set; }

        [Key]
        public string Identity { get; set; }
        public DateTime _CreatedUtc { get; set; }
        public string _CreatedBy { get; set; }
        public string _CreatedAgent { get; set; }
        public DateTime _LastModifiedUtc { get; set; }
        public string _LastModifiedBy { get; set; }
        public string _LastModifiedAgent { get; set; }
        public bool _IsDeleted { get; set; }
        public DateTime _DeletedUtc { get; set; }
        public string _DeletedBy { get; set; }
        public string _DeletedAgent { get; set; }
    }
}
