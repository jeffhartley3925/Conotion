namespace Conotion.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Conotion.Models.Metadata;

	[MetadataType(typeof(NoteMetadata))]
	public class Note : Entity
    {
		public Guid NoteId { get; set; }
		public Guid ChordId { get; set; }
		public Guid AuthorId { get; set; }
		public Accidental Accidental { get; set; }
		public short InstrumentId { get; set; }
		public short? KeyId { get; set; }
		public short VectorId { get; set; }
		public Octave Octave { get; set; }
		public double Duration { get; set; }
		public string Pitch { get; set; }
		public DurationType Type { get; set; }
		public bool? IsDotted { get; set; }
		public double StartTime { get; set; }
		public Orientation Orientation { get; set; }
		public bool? IsSpanned { get; set; }
		public string Slot { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public Chord Chord { get; set; }
		public Vector Vector { get; set; }
		public Key Key { get; set; }
    }
}
