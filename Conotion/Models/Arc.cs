namespace Conotion.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Conotion.Models.Metadata;

	[MetadataType(typeof(ArcMetadata))]
	public class Arc : Entity
    {
		public Guid ArcId { get; set; }
		public Guid CompositionId { get; set; }
        public Guid AuthorId { get; set; }
        public Guid ChordId1 { get; set; }
        public Guid ChordId2 { get; set; }
        public ArcType Type { get; set; }
		public string ArcSweep { get; set; }
		public string FlareSweep { get; set; }
		public double Angle { get; set; }
		public short X1 { get; set; }
		public short Y1 { get; set; }
		public short X2 { get; set; }
		public short Y2 { get; set; }
		public double Top { get; set; }
		public double Left { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public Composition Composition { get; set; }
    }
}
