namespace Conotion.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Conotion.Models.Metadata;

	[MetadataType(typeof(AuthorMetadata))]
	public sealed class Author : Entity
    {
		public Guid AuthorId { get; set; }
		public string ProviderId { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
        public string Email { get; set; }
    }
}
