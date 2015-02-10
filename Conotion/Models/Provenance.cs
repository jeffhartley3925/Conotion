namespace Conotion.Models
{
	using System;
	using System.ComponentModel.DataAnnotations;

	using Conotion.Models.Metadata;

	[MetadataType(typeof(ProvenanceMetadata))]
	public class Provenance : Entity
	{
		public Guid ProvenanceId { get; set; }
		public Guid CompositionId { get; set; }
        public Guid AuthorId { get; set; }
		public Guid CollaborationId { get; set; }
		public string Title { get; set; }
		public string Subtitle { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
		public Composition Composition { get; set; }
	}
}
