using NumberCrunchApi.NumberCruncher.NumberCruncherCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCrunchApi.NumberCruncher
{
  public interface INumberCruncherRepository
  {
     Task<List<INumberCruncherCalculatorItemDto>> ProcessAsync(INumberCruncherDto aNumberCruncher);
  }
}
