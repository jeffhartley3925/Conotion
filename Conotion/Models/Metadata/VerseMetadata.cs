namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class VerseMetadata
	{
		[Key] [Column("Id")]
		public Guid VerseId { get; set; }
		[Required]
		public short Index { get; set; }
		[Required]
		public Guid AuthorId { get; set; }
		[Required]
		public string Text { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime ModifyDate { get; set; }
		[ForeignKey("CompositionId")]
		public Composition Composition { get; set; }
	}
}