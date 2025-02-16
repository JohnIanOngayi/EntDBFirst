using srx.Entities.Models;

namespace srx.Contracts;

public interface IOwnerRepository
{
    IEnumerable<Owner> GetAllOwners();
}
