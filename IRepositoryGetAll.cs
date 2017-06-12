namespace Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IRespositoryGetAll<T>
    {
        Task<(IEnumerable<T> result, RepositoryOutcomeAction outcomeAction, object error)> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
