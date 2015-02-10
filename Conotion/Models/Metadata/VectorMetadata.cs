namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class VectorMetadata
	{
		[Key]
		[Column("Id")]
		public short VectorId { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Data { get; set; }
	}
}