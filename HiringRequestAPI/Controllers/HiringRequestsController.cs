using Microsoft.AspNetCore.Mvc;
using HiringRequestAPI.Models;
using HiringRequestAPI.Services;

namespace HiringRequestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HiringRequestsController : ControllerBase
{
  private readonly ILogger<HiringRequestsController> _logger;

  public HiringRequestsController(ILogger<HiringRequestsController> logger)
  {
    _logger = logger;
  }

  [HttpGet()]
  public ActionResult Get()
  {
     IEnumerable<HiringRequest> requests = HiringRequestsService.GetAll();

    return Ok(requests);
  }

    [HttpGet("{id}")]
  public ActionResult GetSingle(int id)
  {
    HiringRequest? request = HiringRequestsService.Get(id);

    if(request == null)
      return NotFound();

    return Ok(request);
  }

  [HttpPost()]
  public IActionResult Create(HiringRequest HiringRequest)
  {

    HiringRequest.CreatedDate = DateTime.Now;
    HiringRequest.LastModifiedDate = DateTime.Now;

    HiringRequest savedRequest = HiringRequestsService.Add(HiringRequest);

    return CreatedAtAction(nameof(Create), new { id = savedRequest.Id }, savedRequest);
  }

  [HttpPut("{id}")]
  public IActionResult Update(int id, HiringRequest request)
  {
    HiringRequestsService.Update(request);

    return NoContent();
  }

  [HttpDelete("{id}")]
  public IActionResult Delete(int id)
  {
    var request = HiringRequestsService.Get(id);
   
    if (request is null)
        return NotFound();
       
    HiringRequestsService.Delete(id);
    
    return NoContent();
  }
}
