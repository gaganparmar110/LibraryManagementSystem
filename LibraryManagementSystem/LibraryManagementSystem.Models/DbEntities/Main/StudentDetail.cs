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
    [Table("StudentDetails",Schema="dbo")]
    public partial class StudentDetail
    {
		#region StudentId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion StudentId Annotations

        public int StudentId { get; set; }

		#region StudentName Annotations

        [Required]
        [MaxLength(50)]
		#endregion StudentName Annotations

        public string StudentName { get; set; }

		#region MobileNo Annotations

        [Required]
		#endregion MobileNo Annotations

        public long MobileNo { get; set; }

		#region Email Annotations

        [MaxLength(50)]
		#endregion Email Annotations

        public string Email { get; set; }

		#region City Annotations

        [MaxLength(50)]
		#endregion City Annotations

        public string City { get; set; }

		#region Qualification Annotations

        [Required]
        [MaxLength(50)]
		#endregion Qualification Annotations

        public string Qualification { get; set; }

		#region BookIssues Annotations

        [InverseProperty("StudentDetail")]
		#endregion BookIssues Annotations

        public virtual ICollection<BookIssue> BookIssues { get; set; }


        public StudentDetail()
        {
			BookIssues = new HashSet<BookIssue>();
        }
	}
}