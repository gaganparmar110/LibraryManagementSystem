using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using LibraryManagementSystem.BoundedContext.SqlContext;
namespace LibraryManagementSystem.Models.Main
{
    [Table("vReturnBook",Schema="dbo")]
    public partial class vReturnBook
    {

        public string StudentName { get; set; }


        public string BookTitle { get; set; }


        public string BookName { get; set; }


        public System.DateTimeOffset ReturnDate { get; set; }


        public long MobileNo { get; set; }


        public Nullable<int> ReturnStatusAO { get; set; }

		#region BookReturnId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion BookReturnId Annotations

        public int BookReturnId { get; set; }


        public vReturnBook()
        {
        }
	}
}