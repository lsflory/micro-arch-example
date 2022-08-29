using Microsoft.AspNetCore.Mvc;
using PublicHiringRequestAPI.Contracts;
using PublicHiringRequestAPI.Services;

namespace PublicHiringRequestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HiringRequestsController : ControllerBase
{
  private readonly ILogger<HiringRequestsController> _logger;

  public HiringRequestsController(ILogger<HiringRequestsController> logger)
  {
    _logger = logger;
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
