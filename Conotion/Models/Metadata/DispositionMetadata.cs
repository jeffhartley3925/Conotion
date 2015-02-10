namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class DispositionMetadata
	{
		[Key] [Column("Id")]
		public Guid DispositionId { get; set; }
		[Required]
		public Guid CollaborationId { get; set; }
	    [Required]
		public Guid EntityId { get; set; }
		[Required]
		public string EntityType { get; set; }
		[Required]
		public short AuthorStatus { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

		[ForeignKey("CollaborationId")]
		public Collaboration Collaboration { get; set; }
	}
}