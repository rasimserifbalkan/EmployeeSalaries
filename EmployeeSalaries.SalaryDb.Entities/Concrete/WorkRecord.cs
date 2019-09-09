using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaries.Core.Entities;

namespace EmployeeSalaries.SalaryDb.Entities.Concrete
{
    [Table("SalaryDb.WorkRecords")]
    public partial class WorkRecord : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public DateTime WorkStart { get; set; }

        public DateTime? WorkEnd { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
