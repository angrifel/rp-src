namespace Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IRepositoryGetById<T, TKey>
    {
        Task<(T result, RepositoryOutcomeAction outcomeAction, object error)> GetByIdAsync(TKey key, CancellationToken cancellationToken = default(CancellationToken));
    }
}
