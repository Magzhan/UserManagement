using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using User.Entity.Template;

namespace User.Entity.Project {
    public class Project : TemplateTable{
    }

    public class ProjectRole {
        [Key]
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int RoleId { get; set; }
        public Role.Role Role { get; set; }
    }
}
