﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace TVContext
{
    public class UserAddress
    {
        public UserAddress()
        {
             
        }

        //Mark this field as primary key
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //create unique field of user address ???
        [Index(IsUnique = true)]
        [MinLength(5, ErrorMessage = "Too short address (must be 5-100)")]
        [MaxLength(100)]
        [Required]
        public string Address { get; set; }

        //comment for different situations
        [MaxLength(100, ErrorMessage = "Too long comment (must be less than 100 symbols)")]
        public string Comment { get; set; }

        //Make linked entity as virtual for lazy loading work
        [Required]
        public virtual User User { get; set; }

        [Required]
        public virtual TypeConnect TypeConnect { get; set; }

        
    }
}