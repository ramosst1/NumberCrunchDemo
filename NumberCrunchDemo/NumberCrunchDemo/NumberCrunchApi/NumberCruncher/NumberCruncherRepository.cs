using NumberCrunchApi.NumberCruncher.NumberCruncherCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCrunchApi.NumberCruncher
{
  public class NumberCruncherRepository: INumberCruncherRepository
  {

    INumberCrunchCalculator _NumberCrunchCalculator;
    public NumberCruncherRepository(INumberCrunchCalculator numberCrunchCalculator)
    {
      _NumberCrunchCalculator = numberCrunchCalculator;
    }
    public async Task<List<INumberCruncherCalculatorItemDto>> ProcessAsync(INumberCruncherDto aNumberCruncher) {

      try
      {
        return _NumberCrunchCalculator.Calculate(aNumberCruncher);
      }
      catch (Exception ex) {
        throw new Exception("Something went wrong");

      }
    }
  }
}
