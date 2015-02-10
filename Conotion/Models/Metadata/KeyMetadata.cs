namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class KeyMetadata
	{
		[Key] [Column("Id")]
		public int KeyId { get; set; }
		[Required]
		public string Name { get; set; }
	}
}