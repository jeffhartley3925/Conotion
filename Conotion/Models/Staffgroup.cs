namespace Conotion.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Metadata;

	[MetadataType(typeof(StaffgroupMetadata))]
	public sealed class Staffgroup : Entity
    {
        public Staffgroup()
        {
            Staffs = new HashSet<Staff>();
        }
		public Guid StaffgroupId { get; set; }
		public Guid CompositionId { get; set; }
		public Guid AuthorId { get; set; }
		public short Sequence { get; set; }
		public short Index { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public Composition Composition { get; set; }

        public ICollection<Staff> Staffs { get; set; }
    }
}
