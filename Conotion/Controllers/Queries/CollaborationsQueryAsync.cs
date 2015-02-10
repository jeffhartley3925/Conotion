using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Conotion.Models;
using Conotion.Models.Context;

namespace Conotion.Controllers.Queries
{
	using System.Data.Entity;
	using System.Threading.Tasks;

	public class CollaborationsQueryAsync
	{
		private IConotionContext _context;

		public CollaborationsQueryAsync(IConotionContext context)
		{
			_context = context;
		}

	    /// <summary>
	    /// Returns dispositions for all composition collaborators.
	    /// </summary>
	    /// <param name="compositionId">Composition Id</param>
	    /// <returns></returns>
	    public async Task<IEnumerable<CollaborationItem>> Execute(Guid compositionId)
	    {
	        return
	            await
	                (from co in _context.Collaborations
	                join di in _context.Dispositions on co.CollaborationId equals di.CollaborationId
                    join au in _context.Authors on co.CollaborationId equals au.AuthorId
                    where co.CompositionId == compositionId
	                select new CollaborationItem
	                {
	                    CompositionId = co.CompositionId, 
                        Name = au.Username, 
                        ObjectType = di.EntityType, 
                        CollaboratorStatus = di.CollaboratorStatus
	                }).ToListAsync();
	    }

	    /// <summary>
		/// Returns composition dispositions for the author and a particular collaborator.
		/// </summary>
		/// <param name="compositionId">Composition Id</param>
		/// <param name="authorId"></param>
		/// <param name="collaboratorId"></param>
		/// <returns></returns>
		public async Task<IEnumerable<Disposition>> Execute(Guid compositionId, Guid authorId, Guid collaboratorId)
		{
			return
				await
				(from co in _context.Collaborations
                join di in _context.Dispositions on co.CollaborationId equals di.CollaborationId
                join au in _context.Authors on co.CollaborationId equals au.AuthorId
                where (co.CompositionId == compositionId && 
                      (co.CollaboratorId == collaboratorId || co.AuthorId == authorId))
                select di).ToListAsync();
		}
	}

    public class CollaborationItem
    {
        public Guid CompositionId { get; set; }
        public Guid AuthorId { get; set; }
        public Guid CollaboratorId { get; set; }
        public string Name { get; set; }
        public string ObjectType { get; set; }
        public Guid ObjectId { get; set; }
        public short AuthorStatus { get; set; }
        public short? CollaboratorStatus { get; set; }
    }
}