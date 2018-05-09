using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using User.Entity.Operation;
using User.Entity.Project;
using User.Entity.Role;
using User.Entity.Transaction;
using User.Entity.User;

namespace User.Data.Context {
    public class ApplicationDbContext : DbContext{

        public DbSet<Operation> Operations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ProjectRole> ProjectRoles { get; set; }
        public DbSet<Controller> Controllers { get; set; }
        public DbSet<Entity.Role.Action> Actions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Entity.User.User> Users { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<UserStatus> UserStatuses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
            
        }
    }
}
