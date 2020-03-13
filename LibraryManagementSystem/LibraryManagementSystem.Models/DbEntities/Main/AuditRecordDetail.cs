using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using LibraryManagementSystem.Models.Enums.Main;
using LibraryManagementSystem.BoundedContext.SqlContext;
namespace LibraryManagementSystem.Models.Main
{
    [Table("AuditRecordDetails",Schema="dbo")]
    public partial class AuditRecordDetail
    {
		#region AuditRecordDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion AuditRecordDetailId Annotations

        public int AuditRecordDetailId { get; set; }

		#region AuditRecordId Annotations

        [RelationshipTableAttribue("AuditRecords","dbo","","AuditRecordId")]
		#endregion AuditRecordId Annotations

        public Nullable<int> AuditRecordId { get; set; }

		#region ColumnName Annotations

        [Required]
        [MaxLength(100)]
		#endregion ColumnName Annotations

        public string ColumnName { get; set; }


        public string OldValue { get; set; }


        public string NewValue { get; set; }

		#region AuditRecord Annotations

        [ForeignKey(nameof(AuditRecordId))]
        [InverseProperty(nameof(LibraryManagementSystem.Models.Main.AuditRecord.AuditRecordDetails))]
		#endregion AuditRecord Annotations

        public virtual AuditRecord AuditRecord { get; set; }


        public AuditRecordDetail()
        {
        }
	}
}