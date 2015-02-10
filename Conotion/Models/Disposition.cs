namespace Conotion.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Conotion.Models.Metadata;

	[MetadataType(typeof(DispositionMetadata))]
	public class Disposition : Entity
    {
		public Guid DispositionId { get; set; }
		public Guid CollaborationId { get; set; }
        public Guid EntityId { get; set; }
        public string EntityType { get; set; }
        public short? CollaboratorStatus { get; set; }
		public short AuthorStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public Collaboration Collaboration { get; set; }
    }
}
