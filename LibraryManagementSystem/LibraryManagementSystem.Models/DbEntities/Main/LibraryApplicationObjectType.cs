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
    [Table("LibraryApplicationObjectTypes",Schema="dbo")]
    public partial class LibraryApplicationObjectType
    {
		#region ApplicationObjectTypeId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ApplicationObjectTypeId Annotations

        public int ApplicationObjectTypeId { get; set; }

		#region ApplicationObjectTypeName Annotations

        [Required]
        [MaxLength(50)]
		#endregion ApplicationObjectTypeName Annotations

        public string ApplicationObjectTypeName { get; set; }

		#region LibraryApplicationObjects Annotations

        [InverseProperty("LibraryApplicationObjectType")]
		#endregion LibraryApplicationObjects Annotations

        public virtual ICollection<LibraryApplicationObject> LibraryApplicationObjects { get; set; }


        public LibraryApplicationObjectType()
        {
			LibraryApplicationObjects = new HashSet<LibraryApplicationObject>();
        }
	}
}