using srx.Contracts;
using srx.Entities;
using srx.Entities.Models;

namespace srx.Repository;

public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
{
    public OwnerRepository(RepositoryContext repositoryContext)
        : base(repositoryContext) { }
}
