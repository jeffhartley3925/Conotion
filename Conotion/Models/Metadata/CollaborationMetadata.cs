namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class CollaborationMetadata
	{
		[Key] [Column("Id")]
		public Guid CollaborationId { get; set; }
		[Required]
		public Guid CompositionId { get; set; }
		[Required]
		public string CollaboratorId { get; set; }
		[Required]
		public Guid AuthorId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
		[ForeignKey("CompositionId")]
		public Composition Composition { get; set; }
	}
}