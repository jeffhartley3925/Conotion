namespace Conotion.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Conotion.Models.Metadata;

	[MetadataType(typeof(ChordMetadata))]
	public sealed class Chord : Entity
    {
        public Chord()
        {
            this.Notes = new HashSet<Note>();
        }
		public Guid ChordId { get; set; }
		public Guid MeasureId { get; set; }
		public Guid AuthorId { get; set; }
		public double Starttime { get; set; }
		public double Duration { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public Measure Measure { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
