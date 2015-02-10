namespace Conotion.Models.Metadata
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class ArcMetadata
	{
		[Key] [Column("Id")]
		public Guid ArcId { get; set; }
		[Required]
		public Guid AuthorId { get; set; }
		[Required]
		public Guid ChordId1 { get; set; }
		[Required]
		public Guid ChordId2 { get; set; }
		[Required]
		public short Type { get; set; }
		[Required]
		public string ArcSweep { get; set; }
		[Required]
		public string FlareSweep { get; set; }
		[Required]
		public double Angle { get; set; }
		[Required]
		public short X1 { get; set; }
		[Required]
		public short Y1 { get; set; }
		[Required]
		public short X2 { get; set; }
		[Required]
		public short Y2 { get; set; }
		[Required]
		public double Top { get; set; }
		[Required]
		public double Left { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime ModifyDate { get; set; }
		[ForeignKey("CompositionId")]
		public Composition Composition { get; set; }
	}
}