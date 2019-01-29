using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
	public class Registration
	{

		[Required]
		[MinLength(4)]
		[Display(Name = "Your First Name:")]
		public string FirstName {get;set;}
		
		[Required]
		[MinLength(4)]
  	[Display(Name = "Your Last Name:")]
		public string LastName {get;set;}
		
		[Required]
		[Range(0,128)]
  	[Display(Name = "Your Age:")]
		public int Age {get;set;}

		[Required]
		[EmailAddress]
  	[Display(Name = "Your Email Address:")]
		public string EmailAddress {get;set;}

		[Required]
		[MinLength(8)]
		[DataType(DataType.Password)]
  	[Display(Name = "Your Password:")]
		public string Password {get;set;}
	}
}