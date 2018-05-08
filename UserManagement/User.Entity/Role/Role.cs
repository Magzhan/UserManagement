using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace User.Entity.Role {
    public class Role {
        [Key]
        public int Id { get; set; }

        public string NormalizedName { get; set; }

        public string NameKz { get; set; }

        public string NameRu { get; set; }

        public string NameEn { get; set; }

        public string DescriptionKz { get; set; }

        public string DescriptionRu { get; set; }

        public string DescriptionEn { get; set; }
    }
}
