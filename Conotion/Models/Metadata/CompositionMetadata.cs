namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class CompositionMetadata
	{
		[Key] [Column("Id")]
		public Guid CompositionId { get; set; }
		[Required]
		public int InstrumentId { get; set; }
		[Required]
		public Guid AuthorId { get; set; }
		[Required]
		public DateTime CreateDate { get; set; }
		[Required]
		public DateTime ModifyDate { get; set; }
		[Required]
		public short StaffConfiguration { get; set; }
	}
}