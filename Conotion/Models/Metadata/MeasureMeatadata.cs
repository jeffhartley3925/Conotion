namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class MeasureMetadata
	{
		[Key] [Column("Id")]
		public Guid MeasureId { get; set; }
		[Required]
		public int Width { get; set; }
		[Required]
		public double Duration { get; set; }
		[Required]
		public short Sequence { get; set; }
		[Required]
		public short Index { get; set; }
		[Required]
		public Guid AuthorId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime ModifyDate { get; set; }
		[ForeignKey("StaffId")]
		public Staff Staff { get; set; }
	}
}