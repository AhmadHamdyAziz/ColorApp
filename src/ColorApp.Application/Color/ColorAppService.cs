using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using ColorApp.Color.DTO;
using System.Collections.Generic;
using System.Linq;

namespace ColorApp.Color
{
    [AbpAuthorize]
    public class ColorAppService : ApplicationService, IColorAppService
    {
        IRepository<Color> _colorRepository;
        public ColorAppService(IRepository<Color> repository)
        {
            _colorRepository = repository;
        }

        public bool AddColors(UserColorListDto userColorList)
        {
            try
            {
                List<Color> colors = userColorList.ColorsList
            .Select(c => new Color { Code = c.Code, Name = c.Name })
            .ToList();
                List<Color> oldColors = _colorRepository.GetAll()
                    .Where(c => c.CreatorUserId == AbpSession.UserId)
                    .ToList();
                foreach (var oldColor in oldColors)
                    _colorRepository.Delete(oldColor);
                foreach (var color in colors)
                {
                    _colorRepository.Insert(color);
                }
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public List<ColorDTO> GetColors()
        {
            return
                _colorRepository.GetAll()
                .Where(c => c.CreatorUserId == AbpSession.UserId)
                .ToList()
                .Select(cd=> new ColorDTO { Code = cd.Code, Name = cd.Name })
                .ToList()
                ;
        }
    }
}
