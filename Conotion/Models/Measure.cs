namespace Conotion.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Conotion.Models.Metadata;

	[MetadataType(typeof(MeasureMetadata))]
	public sealed class Measure : Entity
    {
        public Measure()
        {
            this.Chords = new HashSet<Chord>();
        }
		public Guid MeasureId { get; set; }
		public Guid StaffId { get; set; }
		public Guid AuthorId { get; set; }
        public TimeSignature TimeSignature { get; set; }
		public short InstrumentId { get; set; }
		public short? KeyId { get; set; }
        public Bar Bar { get; set; }
		public int Width { get; set; }
        public double Duration { get; set; }
        public short Sequence { get; set; }
        public short Index { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public ICollection<Chord> Chords { get; set; }

        public Staff Staff { get; set; }
    }
}
