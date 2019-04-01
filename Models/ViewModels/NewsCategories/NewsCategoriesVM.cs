﻿using System.ComponentModel.DataAnnotations;

namespace Models.ViewModels
{
  public class NewsCategoriesVM
  {
    public int Id { get; set; }

    [Required(ErrorMessage = "Полето е задължително")]
    [Display(Name = "Категория новина")]
    public string Label { get; set; }

    [Display(Name = "Активен")]
    public bool IsActive { get; set; }

    [Display(Name = "Изтрит")]
    public bool IsDeleted { get; set; }

    [Display(Name = "Език")]
    public int LanguageId { get; set; }
  }
}
