﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartialViewDemo.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [ScaffoldColumn(false)]
        public int EmpId { get; set; }
        [Required]
        public string? Empname { get; set; }
        [Required]
        public string? Deptname { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
