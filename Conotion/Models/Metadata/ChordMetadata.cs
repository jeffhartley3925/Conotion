namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class ChordMetadata
	{
		[Key] [Column("Id")]
		public Guid ChordId { get; set; }
		[Required]
		public double Starttime { get; set; }
		[Required]
		public double Duration { get; set; }
		[Required]
		public Guid AuthorId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime ModifyDate { get; set; }
		[ForeignKey("MeasureId")]
		public Measure Measure { get; set; }
	}
}