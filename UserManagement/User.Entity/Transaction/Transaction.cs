using System;
using System.ComponentModel.DataAnnotations;
using User.Common.Constants.Transaction;

namespace User.Entity.Transaction {
    public class Transaction {
        [Key]
        public long Id { get; set; }
        public string Guid { get; set; }
        public int UserId { get; set; }
        public User.User User { get; set; }
        public DateTime TransactionDateTime { get; set; }

        public int ProjectId { get; set; }
        public Project.Project Project { get; set; }

        public int OperationId { get; set; }
        public Operation.Operation Operation { get; set; }

        public TransactionStatus TransactionStatus { get; set; }
    }
}
