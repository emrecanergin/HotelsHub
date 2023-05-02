using HotelsHub.API.Application.Results;
using HotelsHub.API.Domain.Models.HotelsHubApiModel.messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsHub.API.Application.Abstractions.Services
{
    public interface ISearchService
    {
        Task<Result<SearchResponse>> Search(SearchRequest searchRequest);
    }
}
