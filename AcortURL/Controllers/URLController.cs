using AcortURL.Data;
using AcortURL.Entities;
using AcortURL.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace AcortURL.Controllers
{
    [ApiController]
    [Route(template: "api/[controller]")]

    public class URLController : ControllerBase
    {
        private UrlsShortenerContext _UrlContext;

        public URLController(UrlsShortenerContext UrlContext)
        {
            _UrlContext = UrlContext;
        }

        [HttpGet("get")]
        public IActionResult GetURLs()
        {
            return Ok(_UrlContext.Urls.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetURL(int id)
        {
            var url = _UrlContext.Urls.Find(id);
            if (url == null)
            {
                return NotFound();
            }
            return Ok(url);
        }

        [HttpPost("post")]
         public IActionResult CreateURL([FromQuery] URLForCreationDto newUrl)
        {
            var urlEntity = new URL()
            {
                Nombre = newUrl.Nombre,
                Url = newUrl.Url
            };

            _UrlContext.Urls.Add(urlEntity);
            _UrlContext.SaveChanges();
            return Ok(urlEntity);
        }

    }
}
