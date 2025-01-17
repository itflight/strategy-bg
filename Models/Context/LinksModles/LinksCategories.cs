﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Context.LinksModels
{
	[Table("LinksCategories", Schema = "dbo")]
	public class LinksCategories
	{
		[Key]
		[Display(Name = "Id")]
		public int Id { get; set; }

		[Display(Name = "Name")]
		public string Name { get; set; }

		[Display(Name = "Priority")]
		public int Priority { get; set; }

		[Display(Name = "IsDeleted")]
		public bool IsDeleted { get; set; }

		[Display(Name = "IsActive")]
		public bool IsActive { get; set; }

		[Display(Name = "IsApproved")]
		public bool IsApproved { get; set; }

		[Display(Name = "LanguageId")]
		public int LanguageId { get; set; }

		[Display(Name = "CreatedByUserId")]
		public int CreatedByUserId { get; set; }

		[Display(Name = "ModifiedByUserId")]
		public int ModifiedByUserId { get; set; }

		[Display(Name = "DateCreated")]
		public DateTime DateCreated { get; set; }

		[Display(Name = "DateModified")]
		public DateTime DateModified { get; set; }

		[Display(Name = "ViewOrder")]
		public int ViewOrder { get; set; }

		[Display(Name = "ColumnsCount")]
		public int ColumnsCount { get; set; }

        public List<Links> Links { get; set; }

        public LinksCategories()
        {
            Links = new List<Links>();
        }
    }
}
