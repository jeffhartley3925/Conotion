namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class ProvenanceMetadata
	{
		[Key] [Column("Id")]
		public Guid ProvenanceId { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
		[Required]
		public string Title { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime ModifyDate { get; set; }
		[ForeignKey("CompositionId")]
		public Composition Composition { get; set; }
	}
}