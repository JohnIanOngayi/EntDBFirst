using srx.Contracts;
using srx.Entities;
using srx.Entities.Models;

namespace srx.Repository;

public class AccountRepository : RepositoryBase<Account>, IAccountRepository
{
    public AccountRepository(RepositoryContext repositoryContext)
        : base(repositoryContext) { }
}
