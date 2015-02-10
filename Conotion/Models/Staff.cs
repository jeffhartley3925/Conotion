namespace Conotion.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Conotion.Models.Metadata;

	[MetadataType(typeof(StaffMetadata))]
	public sealed class Staff : Entity
    {
        public Staff()
        {
            this.Measures = new HashSet<Measure>();
        }
		public Guid StaffId { get; set; }
		public Guid StaffgroupId { get; set; }
		public Guid AuthorId { get; set; }
		public Clef ClefType { get; set; }
		public Bar Bar { get; set; }
		public short? KeyId { get; set; }
		public TimeSignature TimeSignature { get; set; }
		public short InstrumentId { get; set; }
		public short Sequence { get; set; }
		public short Index { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public ICollection<Measure> Measures { get; set; }

        public Staffgroup Staffgroup { get; set; }
    }
}
