﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Employee.API.Models
{
    public class TblEmployee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }

        [StringLength(250)]
        public string Email { get; set; }
        public int Age { get; set; }

        [StringLength(20)]
        public DateTime Doj { get; set; }

        public string Gender { get; set; }

        public int IsMarried { get; set; }

        public int IsActive { get; set; }

        public int DesignationID { get; set; }

        [NotMapped]
        public string Designation { get; set; }


    }
}

