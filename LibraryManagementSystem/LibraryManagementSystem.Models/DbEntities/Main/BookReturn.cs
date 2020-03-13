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
    [Table("BookReturns",Schema="dbo")]
    public partial class BookReturn
    {
		#region BookReturnId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion BookReturnId Annotations

        public int BookReturnId { get; set; }

		#region BookIssueId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("BookIssues","dbo","","BookIssueId")]
		#endregion BookIssueId Annotations

        public int BookIssueId { get; set; }


        public Nullable<int> ReturnStatusAO { get; set; }

		#region BookIssue Annotations

        [ForeignKey(nameof(BookIssueId))]
        [InverseProperty(nameof(LibraryManagementSystem.Models.Main.BookIssue.BookReturns))]
		#endregion BookIssue Annotations

        public virtual BookIssue BookIssue { get; set; }


        public BookReturn()
        {
        }
	}
}