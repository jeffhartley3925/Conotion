namespace Conotion.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Conotion.Models.Metadata;

	[MetadataType(typeof(VerseMetadata))]
	public class Verse : Entity
    {
		public Guid VerseId { get; set; }
		public Guid CompositionId { get; set; }
		public Guid AuthorId { get; set; }
		public Guid CollaborationId { get; set; }
		public short Index { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
		public string Text { get; set; }

        public Composition Composition { get; set; }
    }
}
