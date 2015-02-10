using System.Collections.Generic;
using System.Web.Http;
using Conotion.Controllers.Queries;
using Conotion.Models.Context;

namespace Conotion.Controllers
{
	using System;
	using System.Linq;
	using System.Threading.Tasks;
	using System.Web.Mvc;

	using Models;

	[System.Web.Http.Authorize]
	[System.Web.Http.RoutePrefix("api/composition")]
	[RequireHttps]
	public class CompositionController : ApiController
	{
		private IConotionContext _context;
		public CompositionController(IConotionContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Return all compositions for a particular author
		/// </summary>
		/// <param name="id">Author Id</param>
		/// <returns></returns>
		[System.Web.Http.HttpGet()]
		[System.Web.Http.ActionName("GetAll")]
		public async Task<IHttpActionResult> GetAllCompositions(string id)
		{
			Guid authorId;

			if (!Guid.TryParse(id, out authorId)) return NotFound();

			var query = await new CompositionsQueryAsync(_context).Execute(authorId);

			var compositions = query as IList<Composition> ?? query.ToList();

			if (!compositions.Any()) return NotFound();

			return Ok(compositions);
		}

		/// <summary>
		/// It is anticipated that we will want a way to view lyrics only without loading the entire composition.
		/// </summary>
		/// <param name="compositionId">Composition Id</param>
		/// <returns></returns>
		[System.Web.Http.HttpGet()]
		[System.Web.Http.ActionName("GetLyrics")]
		public async Task<IHttpActionResult> GetCompositionLyrics(string compositionId)
		{
			Guid id;

			if (!Guid.TryParse(compositionId, out id)) return NotFound();

			if (_context == null) _context = new ConotionContext();

			var query = await new LyricsQueryAsync(_context).Execute(id);

			var lyrics = query as IList<Verse> ?? query.ToList();

			if (!lyrics.Any()) return NotFound();

			return Ok(lyrics);
		}

	    /// <summary>
	    /// Returns a list of composition Provenances for a particular author
	    /// </summary>
	    /// <param name="id"></param>
	    /// <returns></returns>
	    [System.Web.Http.HttpGet()]
		[System.Web.Http.ActionName("GetList")]
		public async Task<IHttpActionResult> GetCompositionList(string id)
		{
			Guid authorId;

			if (!Guid.TryParse(id, out authorId)) return NotFound();

			var query = await new ProvenancesQueryAsync(_context).Execute(authorId);

            var provenances = query as IList<CollaborationRoot> ?? query.ToList();

			if (!provenances.Any()) return NotFound();

			return Ok(provenances);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="compositionId">Composition Id</param>
		/// <returns></returns>
		[System.Web.Http.HttpGet()]
		[System.Web.Http.ActionName("GetOne")]
		public async Task<IHttpActionResult> GetComposition(string id)
		{
			Guid compositionId;

			if (!Guid.TryParse(id, out compositionId)) return NotFound();

			if (_context == null) _context = new ConotionContext();

			var composition = await new CompositionQueryAsync(_context).Execute(compositionId);

			if (composition == null) return NotFound();

			return Ok(composition);
		}

		[System.Web.Http.HttpGet()]
		[System.Web.Http.ActionName("Dispositions")]
		public async Task<IHttpActionResult> GetDispositions(string compositionId)
		{
			Guid id;

			if (!Guid.TryParse(compositionId, out id)) return NotFound();

			if (_context == null) _context = new ConotionContext();

			var dispositions = await new CollaborationsQueryAsync(_context).Execute(id);

			if (dispositions == null) return NotFound();

			return Ok(dispositions);
		}

		[System.Web.Http.HttpGet()]
		[System.Web.Http.ActionName("Dispositions")]
		public async Task<IHttpActionResult> GetCollaboratorDispositions(string compositionId, string authorId, string collaboratorId)
		{
			Guid cId, aId, coId;

			if (!Guid.TryParse(compositionId, out cId)) return NotFound();
			if (!Guid.TryParse(authorId, out aId)) return NotFound();
			if (!Guid.TryParse(collaboratorId, out coId)) return NotFound();

			if (_context == null) _context = new ConotionContext();

			var dispositions = await new CollaborationsQueryAsync(_context).Execute(cId, aId, coId);

			if (dispositions == null) return NotFound();

			return Ok(dispositions);
		}
	}
}
