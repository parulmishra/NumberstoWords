using Microsoft.AspNetCore.Mvc;
using NumberstoWords.Models;
using System.Collections.Generic;
using System;

namespace NumberstoWords.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/word")]
    public ActionResult WeekDay()
    {
      NumberstoWordsClass number =  new NumberstoWordsClass((Request.Form["number"]));
      string word = number.Words(long.Parse(Request.Form["number"]));
      return View("Index", word);
    }
  }
}
