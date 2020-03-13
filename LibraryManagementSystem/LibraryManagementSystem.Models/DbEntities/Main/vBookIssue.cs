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

		#region MobileNo Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion MobileNo Annotations

        public int MobileNo { get; set; }


        public System.DateTimeOffset IssueDate { get; set; }


        public System.DateTimeOffset ReturnDate { get; set; }


        public vBookIssue()
        {
        }
	}
}