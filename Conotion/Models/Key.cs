using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Conotion.Models.Metadata;

namespace Conotion.Models
{
	[MetadataType(typeof(KeyMetadata))]
	public sealed class Key : Entity
	{
		public short KeyId { get; set; }
		public string Name { get; set; }
	}
}