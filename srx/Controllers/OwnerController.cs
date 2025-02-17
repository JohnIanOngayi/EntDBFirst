using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using srx;
using srx.Contracts;
using srx.Entities.Dtos;

namespace srx.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OwnerController : ControllerBase
{
    private ILoggerManager _logger;
    private IRepositoryWrapper _repository;
    private IMapper _mapper;

    public OwnerController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
    {
        _logger = logger;
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAllOwners()
    {
        try
        {
            var owners = _repository.Owner.GetAllOwners();
            _logger.LogInfo($"Returned All Owners From Database");
            var ownersResult = _mapper.Map<IEnumerable<OwnerDto>>(owners);
            return Ok(ownersResult);
        }
        catch (Exception ex)
        {
            _logger.LogError($"GetAllOwners Error: {ex.Message}");
            return StatusCode(500, "Internal Server Error");
        }
    }

    [HttpGet]
    public IActionResult GetOwnerById(Guid id)
    {
        try
        {
            var owner = _repository.Owner.GetOwnerById(id);
            if (owner is null)
            {
                _logger.LogError($"Owner with id: {id} hasn't been found in db");
                return NotFound();
            }
            else
            {
                _logger.LogInfo($"Returned owner with id: {id}");
                var ownerResult = _mapper.Map<OwnerDto>(owner);
                return Ok(ownerResult);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"GetOwnerById Error: {ex.Message}");
            return StatusCode(500, "Internal Server Error");
        }
    }

    [HttpGet("{id}/account")]
    public IActionResult GetOwnerWithDetails(Guid id)
    {
        try
        {
            var owner = _repository.Owner.GetOwnerWithDetails(id);
            if (owner is null)
            {
                _logger.LogError($"Owner with id: {id} hasn't been found in db");
                return NotFound();
            }
            else
            {
                _logger.LogInfo($"Returned onwner with details for id: {id}");
                var ownerResult = _mapper.Map<OwnerWithAccountDto>(owner);
                return Ok(ownerResult);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"GetOwnerWithDetails Error: {ex.Message}");
            return StatusCode(500, "Internal Server Error");
        }
    }
}
