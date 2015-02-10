using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Conotion.Models.Metadata;

namespace Conotion.Models
{
	[MetadataType(typeof(InstrumentMetadata))]
	public sealed class Instrument : Entity
	{
		public short InstrumentId { get; set; }
		public string Name { get; set; }
	}
}