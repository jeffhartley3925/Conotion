using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Conotion.Models;
using Conotion.Models.Context;

namespace Conotion.Controllers.Queries
{
	using System.Threading.Tasks;

	public class CompositionQueryAsync
	{
		private IConotionContext _context;

		public CompositionQueryAsync(IConotionContext context)
		{
			_context = context;
		}

		public async Task<Composition> Execute(Guid compositionId)
		{
			return
				await
				_context.Compositions.Where(a => a.CompositionId == compositionId)
					.Include(c => c.Arcs)
					.Include(c => c.Provenances)
					.Include(c => c.Collaborations)
					.Include(c => c.Verses)
					.Include(c => c.Staffgroups
						.Select(sg => sg.Staffs
							.Select(s => s.Measures
								.Select(m => m.Chords
									.Select(ch => ch.Notes)
								)
							)
						)
					).SingleOrDefaultAsync();
		}
	}
}