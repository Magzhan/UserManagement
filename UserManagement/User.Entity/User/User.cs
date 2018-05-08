using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace User.Entity.User {
    public class User {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(12)]
        public string Xin { get; set; }

        
    }
}
