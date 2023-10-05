using AcortURL.Data;
using AcortURL.Entities;
using AcortURL.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Text;
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

        /*
        [HttpGet("get")]
        public IActionResult GetURLs()
        {
            return Ok(_UrlContext.Urls.ToList());
        }*/


        [HttpGet("get/{url}")]
        public IActionResult GetURL(string url)
        {
            var urlEntity = _UrlContext.Urls.FirstOrDefault(u => u.UrlCorta == url);

           if (urlEntity == null)
            {
                return NotFound("la url no existe");
            }

            return Redirect(urlEntity.Url);
        }


        [HttpPost("post")]
         public IActionResult CreateURL([FromQuery] URLForCreationDto newUrl)
        {
            string shortUrl = GenerarShortUrl();

            var urlEntity = new URL()
            {
                Nombre = newUrl.Nombre,
                Url = newUrl.Url,
                UrlCorta = shortUrl
            };
            _UrlContext.Urls.Add(urlEntity);
            _UrlContext.SaveChanges();
            return Ok(urlEntity);
        }
        private string GenerarShortUrl()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var shortUrl = new StringBuilder();

            for (int i = 0; i < 6; i++)
            {
                shortUrl.Append(chars[random.Next(chars.Length)]);
            }

            return shortUrl.ToString();
        }
    }
}



