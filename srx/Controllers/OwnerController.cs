using Microsoft.AspNetCore.Mvc;
using srx.Contracts;

namespace srx.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OwnerController : ControllerBase
{
    private ILoggerManager _logger;
    private IRepositoryWrapper _repository;

    public OwnerController(ILoggerManager logger, IRepositoryWrapper repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetAllOwners()
    {
        try
        {
            var owners = _repository.Owner.GetAllOwners();
            _logger.LogInfo($"Returned All Owners From Database");
            return Ok(owners);
        }
        catch (Exception ex)
        {
            _logger.LogError($"GetAllOwners Error: {ex.Message}");
            return StatusCode(500, "Internal Server Error");
        }
    }
}
