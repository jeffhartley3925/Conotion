using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Conotion.Models.Metadata;

namespace Conotion.Models
{
	[MetadataType(typeof(VectorMetadata))]
	public sealed class Vector : Entity
	{
		public short VectorId { get; set; }
		public string Name { get; set; }
		public string Category { get; set; }
		public string Data { get; set; }
	}
}