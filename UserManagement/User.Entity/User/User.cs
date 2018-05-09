using System;
using System.ComponentModel.DataAnnotations;
using User.Entity.Template;

namespace User.Entity.User {
    public class User {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(12)]
        [MinLength(12)]
        public string Xin { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public string NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool LockoutEnabled { get; set; }

        public DateTime LockoutEnd { get; set; }

        public int AccessFailedCount { get; set; }
    }

    public class UserRole {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int RoleId { get; set; }
        public Role.Role Role { get; set; }
    }    

    public class UserInfo {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Xin { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Gender { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int UserTypeId { get; set; }

        public UserType UserType { get; set; }

        public UserStatus UserStatus { get; set; }
    }

    public class UserType : TemplateTable { }

    public class UserStatus : TemplateTable { }
}
