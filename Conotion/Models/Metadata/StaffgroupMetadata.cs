namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class StaffgroupMetadata
	{
		[Key] [Column("Id")]
		public Guid StaffgroupId { get; set; }
		[Required]
		public Guid AuthorId { get; set; }
		[Required]
		public short Sequence { get; set; }
		[Required]
		public short Index { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime ModifyDate { get; set; }
		[ForeignKey("CompositionId")]
		public Composition Composition { get; set; }
	}
}