using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IGetPartiesLocation : IApplicationService
    {
        GetPartiesLocationResultDto Execute(GetPartiesLocationDto dto);
    }
}
