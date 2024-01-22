using Esce.Application.Interface.Repositories;
using Esce.Application.Interface.UnitOfWorks;
using Esce.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Esce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        readonly private IRoleReadRepository _roleReadRepository;
        readonly private IRoleWriteRepository _roleWriteRepository;
        readonly private IUnitOfWork _IUnitOfWork;

        public HomeController(IRoleWriteRepository roleWriteRepository, IRoleReadRepository roleReadRepository)
        {
            _roleReadRepository= roleReadRepository;
            _roleWriteRepository= roleWriteRepository;
        }

        [HttpGet]
        public async void Index()
        {
            //    var roles = await _roleReadRepository.GetAll();


            //    return View();
        }

    }
}
