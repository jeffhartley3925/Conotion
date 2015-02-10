using System;
using System.Collections.Generic;
using System.Linq;
using Conotion.Models;
using Conotion.Models.Context;

namespace Conotion.Controllers.Queries
{
	using System.Data.Entity;
	using System.Threading.Tasks;

	public class LyricsQueryAsync
	{
		private IConotionContext _context;

		public LyricsQueryAsync(IConotionContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Returns all composition lyrics
		/// </summary>
		/// <param name="compositionId"></param>
		/// <returns></returns>
		public async Task<IEnumerable<Verse>> Execute(Guid compositionId)
		{
			return
				await
				_context.Verses
					.Where(a => a.CompositionId == compositionId)
					.OrderByDescending(d => d.Index).ToListAsync();
		}
	}
}