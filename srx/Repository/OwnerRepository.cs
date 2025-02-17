using srx.Contracts;
using srx.Entities;
using srx.Entities.Models;

namespace srx.Repository;

public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
{
    public OwnerRepository(RepositoryContext repositoryContext)
        : base(repositoryContext) { }

    public IEnumerable<Owner> GetAllOwners()
    {
        return FindAll().OrderBy(owner => owner.Name).ToList();
    }

    public Owner GetOwnerById(Guid ownerId)
    {
        return FindByCondition(owner => owner.Id == ownerId).FirstOrDefault();
    }
}
