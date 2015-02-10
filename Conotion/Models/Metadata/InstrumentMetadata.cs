namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class InstrumentMetadata
	{
		[Key]
		[Column("Id")]
		public int InstrumentId { get; set; }
		[Required]
		public string Name { get; set; }
	}
}