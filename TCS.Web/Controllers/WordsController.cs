using Microsoft.AspNetCore.Mvc;
using System;
using TCS.BL.DTOs;
using TCS.BL.Services;

namespace TCS.Web.Controllers
{
    public class WordsController : Controller
    {
        [HttpGet]
        public IActionResult Search()
        {
            return View(new SearchWordDTO());
        }

        [HttpPost]
        public IActionResult Search(SearchWordDTO searchWordDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(searchWordDTO);

                var wordService = new WordService();
                var count = wordService.WordsCount(searchWordDTO.Text.Trim(), searchWordDTO.Word.Trim());
                ViewBag.Count = count;
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            return View(searchWordDTO);
        }
    }
}
