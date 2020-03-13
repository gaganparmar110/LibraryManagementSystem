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
    [Table("BookEntery",Schema="dbo")]
    public partial class BookEntery
    {
		#region BookEnteryId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion BookEnteryId Annotations

        public int BookEnteryId { get; set; }

		#region BookTitle Annotations

        [Required]
        [MaxLength(50)]
		#endregion BookTitle Annotations

        public string BookTitle { get; set; }

		#region BookName Annotations

        [Required]
        [MaxLength(50)]
		#endregion BookName Annotations

        public string BookName { get; set; }

		#region Copies Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion Copies Annotations

        public int Copies { get; set; }

        public string AuthorName { get; set; }
		#region BookDetails Annotations

        [InverseProperty("BookEntery")]
		#endregion BookDetails Annotations

        public virtual ICollection<BookDetail> BookDetails { get; set; }


        public BookEntery()
        {
			BookDetails = new HashSet<BookDetail>();
        }
	}
}