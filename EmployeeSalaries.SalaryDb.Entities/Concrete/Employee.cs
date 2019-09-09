using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaries.Core.Entities;

namespace EmployeeSalaries.SalaryDb.Entities.Concrete
{
    [Table("SalaryDb.Employees")]
    public partial class Employee : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            WorkRecords = new HashSet<WorkRecord>();
        }

        public int Id { get; set; }

        public long IdentityNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public int SalaryTypeId { get; set; }

        public virtual SalaryType SalaryType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkRecord> WorkRecords { get; set; }
    }
}
