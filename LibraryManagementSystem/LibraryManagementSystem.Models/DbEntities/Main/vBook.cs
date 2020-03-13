using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using LibraryManagementSystem.BoundedContext.SqlContext;
namespace LibraryManagementSystem.Models.Main
{
    [Table("vBooks",Schema="dbo")]
    public partial class vBook
    {

        public string BookTitle { get; set; }


        public string BookName { get; set; }


        public string AuthorName { get; set; }

		#region Copies Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion Copies Annotations

        public int Copies { get; set; }


        public vBook()
        {
        }
	}
}