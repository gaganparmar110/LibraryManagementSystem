using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using LibraryManagementSystem.BoundedContext.SqlContext;
namespace LibraryManagementSystem.Models.Main
{
    [Table("vBookIssue",Schema="dbo")]
    public partial class vBookIssue
    {

        public string StudentName { get; set; }


        public string BookName { get; set; }


        public string AuthorName { get; set; }


        public long MobileNo { get; set; }


        public System.DateTimeOffset IssueDate { get; set; }


        public System.DateTimeOffset ReturnDate { get; set; }

		#region BookIssueId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion BookIssueId Annotations

        public int BookIssueId { get; set; }


        public vBookIssue()
        {
        }
	}
}