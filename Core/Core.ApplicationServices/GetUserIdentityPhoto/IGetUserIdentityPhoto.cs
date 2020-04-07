using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IGetUserIdentityPhoto : IApplicationService
    {
        GetUserIdentityPhotoResultDto Execute(BaseByIdDto dto);
    }
}
