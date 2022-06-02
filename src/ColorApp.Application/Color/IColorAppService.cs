using Abp.Application.Services;
using ColorApp.Color.DTO;
using System.Collections.Generic;

namespace ColorApp.Color
{
    public interface IColorAppService : IApplicationService
    {
        bool AddColors(UserColorListDto userColorList);
        List<ColorDTO> GetColors();
    }
}
