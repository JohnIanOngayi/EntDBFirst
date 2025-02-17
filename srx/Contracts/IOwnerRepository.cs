using srx.Entities.Models;

namespace srx.Contracts;

public interface IOwnerRepository
{
    IEnumerable<Owner> GetAllOwners();
    Owner GetOwnerById(Guid ownerId);
    Owner GetOwnerWithDetails(Guid ownerId);
}
