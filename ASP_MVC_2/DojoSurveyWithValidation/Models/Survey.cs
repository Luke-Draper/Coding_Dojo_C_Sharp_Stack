using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidation.Models
{
	public class Survey
	{
		[Required]
		[MinLength(2)]
		[Display(Name = "Your Name:")]
		public string Name {get;set;}
		[Required]
		public string Location {get;set;}
		[Required]
		public string FavoriteLanguage {get;set;}
		[MaxLength(20)]
		public string Comment {get;set;}
	}
}