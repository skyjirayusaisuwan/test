using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/[controller]")]
public class PoliciesController : ControllerBase
{
    private readonly PolicyService _policyService;

    public PoliciesController(PolicyService policyService)
    {
        _policyService = policyService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Policy request)
    {
        if (request.PolicyType != "Auto")
        {
            return BadRequest("Currently only Auto policies are supported.");
        }

        var createdPolicy = await _policyService.CreatePolicyAsync(request);
        return Created($"/api/v1/policies/{createdPolicy.Id}", createdPolicy);
    }
}