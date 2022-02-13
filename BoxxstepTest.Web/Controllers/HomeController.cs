using BoxxstepTest.Repository.Data.Models;
using BoxxstepTest.Service;
using BoxxstepTest.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BoxxstepTest.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IContactService _contactService;

        public HomeController(ILogger<HomeController> logger, IContactService contactService)
        {
            _logger = logger;
            _contactService = contactService;
        }

        public async Task<IActionResult> Index()
        {
            //var data = await _contactService.GetContactList();
            return View();
        }

        [HttpPost("saveContact")]
        public async Task<IActionResult> SaveContact([FromForm] Contact contact)
        {
            try
            {
                await _contactService.SaveContact(contact);
                await _contactService.CompleteAsync();
                return Json(contact);
            }
            catch(Exception ex)
            {
                _logger.LogError("AddContact: " + ex.Message);
                return null;
            }           
        }
        [HttpPost("updateRelation")]
        public async Task<IActionResult> UpdateRelation([FromForm] long contactId, [FromForm] long parentId)
        {
            try
            {
                var contact = await _contactService.UpdateRelation(contactId, parentId);
                await _contactService.CompleteAsync();
                return Json(contact);
            }
            catch (Exception ex)
            {
                _logger.LogError("AddContact: " + ex.Message);
                return null;
            }
        }
        
       [HttpGet("getContacts")]
        public async Task<IActionResult> GetContacts()
        {
            try
            {
                var list = await _contactService.GetContactList();
                return Json(list);
            }
            catch (Exception ex)
            {
                _logger.LogError("getContacts: " + ex.Message);
                return null;
            }
        }
        [HttpPost("deleteContact")]
        public async Task<IActionResult> DeleteContact([FromForm] long id)
        {
            try
            {
                _contactService.DeleteContact(id);
                await _contactService.CompleteAsync();
                return Json(id);
            }
            catch (Exception ex)
            {
                _logger.LogError("DeleteContact: " + ex.Message);
                return null;
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
