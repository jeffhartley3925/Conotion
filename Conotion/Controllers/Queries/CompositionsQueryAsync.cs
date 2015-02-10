using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Conotion.Models;
using Conotion.Models.Context;

namespace Conotion.Controllers.Queries
{
	using System.Threading.Tasks;

	public class CompositionsQueryAsync
    {
        private IConotionContext _context;

        public CompositionsQueryAsync(IConotionContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns all compositions for a particular author
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
		public async Task<IEnumerable<Composition>> Execute(Guid id)
		{
			return
				await
				_context.Compositions.Where(a => a.AuthorId == id)
					.Include(c => c.Arcs)
					.Include(c => c.Provenances)
					.Include(c => c.Collaborations)
					.Include(c => c.Verses)
					.Include(
						c =>
						c.Staffgroups.Select(sg => sg.Staffs.Select(s => s.Measures.Select(m => m.Chords.Select(ch => ch.Notes)))))
					.OrderByDescending(d => d.ModifyDate)
					.ToListAsync();
		}
    }
}