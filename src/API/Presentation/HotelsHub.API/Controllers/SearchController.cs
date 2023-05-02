using HotelsHub.API.Application.Abstractions.Services;
using HotelsHub.API.Domain.Models.HotelsHubApiModel.messages;
using HotelsHub.API.Responses;
using Microsoft.AspNetCore.Mvc;

namespace HotelsHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService; 

        }
        [HttpPost]
        public async Task<IActionResult> Search([FromBody] SearchRequest searchRequest)
        {
            var response = await _searchService.Search(searchRequest);
            if (response.Success)
            {
                return Ok(new ApiResponse<SearchResponse>(response.Data));
            }

            return BadRequest(new ApiResponse<object> { ErrorMessage = response.Message });
        }
    }
}
