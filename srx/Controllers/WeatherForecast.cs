using Microsoft.AspNetCore.Mvc;
using srx.Contracts;

[ApiController]
[Route("/api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILoggerManager _logger;
    private IRepositoryWrapper _repository;

    public WeatherForecastController(ILoggerManager logger, IRepositoryWrapper repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        var domesticAccounts = _repository.Account.FindByCondition(x =>
            x.AccountType.Equals("Domestic")
        );
        var owners = _repository.Owner.FindAll();

        return new string[] { "value1", "value2" };
    }
}
