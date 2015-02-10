namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class NoteMetadata
	{
		[Key] [Column("Id")]
		public Guid NoteId { get; set; }
		[Required]
		public double Duration { get; set; }
		[Required]
		public Guid AuthorId { get; set; }
		[Required]
		public short VectorId { get; set; }
		[Required]
		public short InstrumentId { get; set; }
		[Required]
		public short? Type { get; set; }
		[Required]
		public bool? IsDotted { get; set; }
		[Required]
		public double StartTime { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime ModifyDate { get; set; }
		[ForeignKey("ChordId")]
		public Chord Chord { get; set; }
	}
}