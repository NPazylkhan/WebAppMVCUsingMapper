using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAppMVCUsingMapper.Models;
using WebAppMVCUsingMapper.ViewModels;

namespace WebAppMVCUsingMapper.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var user = GetUserDetails();

            UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);
            return View(userViewModel);
        }

        private static User GetUserDetails()
        {
            return new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Email = "John.Smith@gmail.com",
                Address = new Address() 
                { 
                    City = "US"
                }
            };
        }
    }
}
