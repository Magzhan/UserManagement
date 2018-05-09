using System.ComponentModel.DataAnnotations;
using User.Entity.Template;

namespace User.Entity.Register {
    public class Register : TemplateTable {
        public int RegisterLevelId { get; set; }
        public RegisterLevel RegisterLevel { get; set; }
    }

    public class RegisterLevel : TemplateTable {
        public bool IsLastChild { get; set; }
        public bool IsFirstAncestor { get; set; }
    }

    public class RegisterHierarchy {
        [Key]
        public long Id { get; set; }
        public int ParentRegisterId { get; set; }
        public int ChildRegisterId { get; set; }
    }

    public class RegisterLevelHierarchy {
        [Key]
        public long Id { get; set; }
        public int ParentLevelId { get; set; }
        public int ChildLevelId { get; set; }
    }
}
