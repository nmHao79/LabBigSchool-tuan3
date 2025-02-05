﻿using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabBigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public  string LecturerId { get; set; }
        [Required]
        [StringLength(225)]
        public string Place { get; set; }
        public DateTime Datatime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }

    }
}