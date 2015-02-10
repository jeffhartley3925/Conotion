namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class AuthorMetadata
	{
		[Key]
		[Column("Id")]
		[Required]
		public Guid AuthorId { get; set; }
		[Required]
		public string ProviderId { get; set; }
		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		public int? Email { get; set; }
	}
}