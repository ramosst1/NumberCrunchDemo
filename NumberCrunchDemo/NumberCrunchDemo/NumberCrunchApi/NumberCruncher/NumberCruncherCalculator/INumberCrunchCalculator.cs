using System.Collections.Generic;

namespace NumberCrunchApi.NumberCruncher.NumberCruncherCalculator
{
  public interface INumberCrunchCalculator
  {
    List<INumberCruncherCalculatorItemDto> Calculate(INumberCruncherDto aNumberCruncher);
  }
}