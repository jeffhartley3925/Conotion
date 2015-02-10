using System;
using System.Collections.Generic;
using System.Linq;
using Conotion.Models;
using Conotion.Models.Context;

namespace Conotion.Controllers.Queries
{
	using System.Data.Entity;
	using System.Threading.Tasks;

	public class ProvenancesQueryAsync
	{
		private IConotionContext _context;

		public ProvenancesQueryAsync(IConotionContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<CollaborationRoot>> Execute(Guid authorId)
		{
			var compositions =
				await
				(from f in _context.Collaborations
				 where
					 f.AuthorId == authorId &&
					 f.CollaboratorId == authorId
				 select f)
				 .Distinct().ToListAsync();



			var roots = new List<CollaborationRoot>();

			foreach (var composition in compositions)
			{
				var root = new CollaborationRoot();
				var compositionSummary = await this.GetRootSummary(authorId, composition);
				root.CompositionSummary = compositionSummary;
				root.Collaborations = new List<CompositionSummary>();

				var composition1 = composition;
				var collaborations =
					await
					(from f in _context.Collaborations
					 where
						 f.AuthorId == authorId &&
						 f.CollaboratorId != authorId &&
						 f.CompositionId == composition1.CompositionId
					 select f).Distinct()
					 .ToListAsync();


				foreach (var collaboration in collaborations)
				{
					var c = await this.GetCollaborationSummary(collaboration);
					root.Collaborations.Add(c);
				}
				roots.Add(root);
			}
			return roots;
		}

		private async Task<CompositionSummary> GetCollaborationSummary(Collaboration collaboration)
		{

			var verses = await (from v in this._context.Verses where collaboration.CollaborationId == v.CollaborationId select v).ToListAsync();

			var author = await (from a in this._context.Authors where a.AuthorId == collaboration.CollaboratorId select a).FirstAsync();

			var provenance =
				await
				(from a in this._context.Provenances where a.AuthorId == collaboration.CollaboratorId && a.CompositionId == collaboration.CompositionId select a)
					.FirstAsync();

			var summary = new CompositionSummary
							  {
								  Lyrics = verses,
								  Title = provenance.Title,
								  Subtitle = provenance.Subtitle,
								  Name = author.Username,
								  AuthorId = collaboration.AuthorId,
								  ModifyDate = collaboration.CreateDate,
								  CollaboratorId = collaboration.CollaboratorId,
								  CompositionId = collaboration.CompositionId,
								  IsSelected = false
							  };
			return summary;
		}

		private async Task<CompositionSummary> GetRootSummary(Guid authorId, Collaboration root)
		{
			var verses =
				await
				(from v in this._context.Verses where root.CollaborationId == v.CollaborationId && root.AuthorId == v.AuthorId select v)
					.ToListAsync();

			var author = await (from a in this._context.Authors where a.AuthorId == root.AuthorId select a).FirstAsync();

			var provenance =
				await
				(from a in this._context.Provenances where a.AuthorId == root.AuthorId && a.CompositionId == root.CompositionId select a)
					.FirstAsync();

			var summary = new CompositionSummary
							  {
								  Lyrics = verses,
								  Title = provenance.Title,
								  Subtitle = provenance.Subtitle,
								  Name = author.Username,
								  AuthorId = authorId,
								  ModifyDate = root.CreateDate,
								  CollaboratorId = Guid.Empty,
								  CompositionId = root.CompositionId,
								  IsSelected = false
							  };

			return summary;
		}
	}

	public class CollaborationRoot
	{
		public CompositionSummary CompositionSummary { get; set; }
		public List<CompositionSummary> Collaborations { get; set; }
	}

	public class CompositionSummary
	{
		public Guid CompositionId { get; set; }
		public Guid AuthorId { get; set; }
		public Guid CollaboratorId { get; set; }
		public string Title { get; set; }
		public string Subtitle { get; set; }
		public string Name { get; set; }
		public DateTime ModifyDate { get; set; }
		public IEnumerable<Verse> Lyrics { get; set; }

		public Boolean IsSelected { get; set; }
	}
}