namespace Conotion.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Conotion.Models.Metadata;

	[MetadataType(typeof(CompositionMetadata))]
	public sealed class Composition : Entity
    {
        public Composition()
        {
            this.Arcs = new HashSet<Arc>();
            this.Collaborations = new HashSet<Collaboration>();
            this.Verses = new HashSet<Verse>();
            this.Staffgroups = new HashSet<Staffgroup>();
        }
		public Guid CompositionId { get; set; }
		public short InstrumentId { get; set; }
		public short? KeyId { get; set; }
		public TimeSignature TimeSignature { get; set; }
        public Guid AuthorId { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime ModifyDate { get; set; }
		public StaffConfigurationType StaffConfiguration { get; set; }
        public string Flags { get; set; }
    
        public ICollection<Arc> Arcs { get; private set; }
        public ICollection<Collaboration> Collaborations { get; private set; }
        public ICollection<Verse> Verses { get; private set; }
        public ICollection<Staffgroup> Staffgroups { get; private set; }
        public ICollection<Provenance> Provenances { get; private set; }

		
    }
}
