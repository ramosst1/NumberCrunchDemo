using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NumberCrunchDemo.Models;
using NumberCrunchDemo.Util.Converters;
using NumberCrunchDemo.Util.HttpClientUtil;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace NumberCrunchDemo.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [HttpGet]
    public IActionResult NumberCrunchStep2(NumberCrunchModel aNumberCrunchModel)
    {
      return View(aNumberCrunchModel);
    }

    [HttpPost]
    public IActionResult NumberCrunchStep2(IFormFile fileUpload, NumberCrunchModel aNumberCrunchModel)
    {

      if (fileUpload != null)
      {
        var FileContent = ReadUploadFile(fileUpload);

        aNumberCrunchModel.UploadMessage = FileContent;

      }

      return View(aNumberCrunchModel);
    }

    public async Task<IActionResult> ListNumberCrunchResults(NumberCrunchModel aNumberCrunchModel) {

      var NumberCrunchAPIResponse = await HttpClientUtil.PostAsync("http://localhost:45997/api/v1/HumberCruncher", aNumberCrunchModel);

      dynamic DynamicModel = new ExpandoObject();

      DynamicModel.NumberCrunchModel = aNumberCrunchModel;

      if (!NumberCrunchAPIResponse.IsSuccessStatusCode) {
        // Do some error handling
        return null;
      }

      string DataResponse = NumberCrunchAPIResponse.Content.ReadAsStringAsync().Result;
      var NumberCruncherCalculatorItems = NumberCruncherCalculatorItemsConverter.ConvertJsonToNumberCruncherCalculatorItemList(DataResponse);

      DynamicModel.NumberCruncherCalculatorItems = NumberCruncherCalculatorItems;

      return View(DynamicModel);

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    private string ReadUploadFile(IFormFile fileUpload)
    {

      string FileContent;

      using (var reader = new StreamReader(fileUpload.OpenReadStream()))
      {
        FileContent = reader.ReadToEnd();
      }

      return FileContent;
    }

  }
}
