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
    [Table("LibraryApplicationObjects",Schema="dbo")]
    public partial class LibraryApplicationObject
    {
		#region ApplicationObjectId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ApplicationObjectId Annotations

        public int ApplicationObjectId { get; set; }

		#region ApplicationObjectName Annotations

        [Required]
        [MaxLength(50)]
		#endregion ApplicationObjectName Annotations

        public string ApplicationObjectName { get; set; }

		#region ApplicationObjectTypeId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("LibraryApplicationObjectTypes","dbo","","ApplicationObjectTypeId")]
		#endregion ApplicationObjectTypeId Annotations

        public int ApplicationObjectTypeId { get; set; }

		#region LibraryApplicationObjectType Annotations

        [ForeignKey(nameof(ApplicationObjectTypeId))]
        [InverseProperty(nameof(LibraryManagementSystem.Models.Main.LibraryApplicationObjectType.LibraryApplicationObjects))]
		#endregion LibraryApplicationObjectType Annotations

        public virtual LibraryApplicationObjectType LibraryApplicationObjectType { get; set; }


        public LibraryApplicationObject()
        {
        }
	}
}