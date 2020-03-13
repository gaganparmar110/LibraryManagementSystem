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
    [Table("BookDetails",Schema="dbo")]
    public partial class BookDetail
    {
		#region BookDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion BookDetailId Annotations

        public int BookDetailId { get; set; }

		#region BookEnteryId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("BookEntery","dbo","","BookEnteryId")]
		#endregion BookEnteryId Annotations

        public int BookEnteryId { get; set; }

		#region AuthorName Annotations

        [Required]
        [MaxLength(50)]
		#endregion AuthorName Annotations

        public string AuthorName { get; set; }

		#region BookEntery Annotations

        [ForeignKey(nameof(BookEnteryId))]
        [InverseProperty(nameof(LibraryManagementSystem.Models.Main.BookEntery.BookDetails))]
		#endregion BookEntery Annotations

        public virtual BookEntery BookEntery { get; set; }

		#region BookIssues Annotations

        [InverseProperty("BookDetail")]
		#endregion BookIssues Annotations

        public virtual ICollection<BookIssue> BookIssues { get; set; }


        public BookDetail()
        {
			BookIssues = new HashSet<BookIssue>();
        }
	}
}