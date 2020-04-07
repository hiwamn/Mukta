using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface ISearch : IApplicationService
    {
        SearchResultDto Execute(SearchDto dto);
    }
}
