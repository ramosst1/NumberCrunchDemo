using Microsoft.AspNetCore.Mvc;
using NumberCrunchApi.NumberCruncher;
using NumberCrunchApi.NumberCruncher.NumberCruncherCalculator;
using NumberCrunchWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NumberCrunchWebApi.Controllers
{
  [Route("api/v1/HumberCruncher")]
  [ApiController]
  public class HumberCruncherV1Controller : ControllerBase
  {
    INumberCruncherRepository _NumberCruncherRepository; 

    public HumberCruncherV1Controller(INumberCruncherRepository numberCruncherRepository)
    {
      _NumberCruncherRepository = numberCruncherRepository;
    }


    // POST api/v1/<HumberCruncherController>
    [HttpPost]
    public async Task<List<INumberCruncherV1CalculatorItemModel>> CalculateNumberCruncher(NumberCrunchV1InputModel numberCrunch)
    {

      var numberCrunchDto = Util.Converters.NumberCruncherConverter.Convert(numberCrunch);

      var NumberCruncherRepositoryResponse =  await _NumberCruncherRepository.ProcessAsync(numberCrunchDto);

      return Util.Converters.NumberCruncherCalculatorConverter.Convert(NumberCruncherRepositoryResponse);
    }

  }
}
