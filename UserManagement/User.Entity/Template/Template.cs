using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace User.Entity.Template {
    public class Template {
    }

    public class TemplateTable {
        [Key]
        public int Id { get; set; }

        public string NormalizedName { get; set; }
        [MaxLength(2000)]
        public string NameKz { get; set; }
        [MaxLength(2000)]
        public string NameRu { get; set; }
        [MaxLength(2000)]
        public string NameEn { get; set; }
        [MaxLength(6000)]
        public string DescriptionKz { get; set; }
        [MaxLength(6000)]
        public string DescriptionRu { get; set; }
        [MaxLength(6000)]
        public string DescriptionEn { get; set; }
    }
}
