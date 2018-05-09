using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using User.Entity.Template;

namespace User.Entity.Role {
    public class Role : TemplateTable{
    }

    public class Controller : TemplateTable { }

    public class Action : TemplateTable {
        public int ControllerId { get; set; }
        public Controller Controller { get; set; }
    }
}
