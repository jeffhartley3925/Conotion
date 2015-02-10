namespace Conotion.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Conotion.Models.Metadata;

	[MetadataType(typeof(CollaborationMetadata))]
	public sealed class Collaboration : Entity
    {
        public Collaboration()
        {
            this.Dispositions = new HashSet<Disposition>();
        }
		public Guid CollaborationId { get; set; }
		public Guid CompositionId { get; set; }
		public Guid CollaboratorId { get; set; }
        public Guid AuthorId { get; set; }
        public DateTime CreateDate { get; set; }

        public ICollection<Disposition> Dispositions { get; set; }

        public Composition Composition { get; set; }
    }
}
