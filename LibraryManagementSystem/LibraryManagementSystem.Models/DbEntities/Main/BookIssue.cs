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
    [Table("BookIssues",Schema="dbo")]
    public partial class BookIssue
    {
		#region BookIssueId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion BookIssueId Annotations

        public int BookIssueId { get; set; }

		#region StudentId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("StudentDetails","dbo","","StudentId")]
		#endregion StudentId Annotations

        public int StudentId { get; set; }

		#region BookDetailId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("BookDetails","dbo","","BookDetailId")]
		#endregion BookDetailId Annotations

        public int BookDetailId { get; set; }

		#region IssueDate Annotations

        [Required]
		#endregion IssueDate Annotations

        public System.DateTimeOffset IssueDate { get; set; }

		#region ReturnDate Annotations

        [Required]
		#endregion ReturnDate Annotations

        public System.DateTimeOffset ReturnDate { get; set; }

		#region BookDetail Annotations

        [ForeignKey(nameof(BookDetailId))]
        [InverseProperty(nameof(LibraryManagementSystem.Models.Main.BookDetail.BookIssues))]
		#endregion BookDetail Annotations

        public virtual BookDetail BookDetail { get; set; }

		#region StudentDetail Annotations

        [ForeignKey(nameof(StudentId))]
        [InverseProperty(nameof(LibraryManagementSystem.Models.Main.StudentDetail.BookIssues))]
		#endregion StudentDetail Annotations

        public virtual StudentDetail StudentDetail { get; set; }

		#region BookReturns Annotations

        [InverseProperty("BookIssue")]
		#endregion BookReturns Annotations

        public virtual ICollection<BookReturn> BookReturns { get; set; }


        public BookIssue()
        {
			BookReturns = new HashSet<BookReturn>();
        }
	}
}