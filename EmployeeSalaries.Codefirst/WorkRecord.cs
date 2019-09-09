namespace EmployeeSalaries.Codefirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalaryDb.WorkRecords")]
    public partial class WorkRecord
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public DateTime WorkStart { get; set; }

        public DateTime? WorkEnd { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
