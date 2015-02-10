namespace Conotion.Models.Metadata
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class StaffMetadata
	{
		[Key]
		[Column("Id")]

		public Guid StaffId { get; set; }
		[Required]
		public short Sequence { get; set; }
		[Required]
		public Guid AuthorId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime ModifyDate { get; set; }
		[Required]
		public short Index { get; set; }

		public ICollection<Measure> Measures { get; set; }

		[ForeignKey("StaffgroupId")]
		public Staffgroup Staffgroup { get; set; }
	}
}