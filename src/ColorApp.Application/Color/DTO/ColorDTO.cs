using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorApp.Color.DTO
{
    public class ColorDTO
    {
        [Required]
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
