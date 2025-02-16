namespace srx.Contracts;

public interface IRepositoryWrapper
{
    IOwnerRepository Owner { get; }
    IAccountRepository Account { get; }
    void Save();
}
