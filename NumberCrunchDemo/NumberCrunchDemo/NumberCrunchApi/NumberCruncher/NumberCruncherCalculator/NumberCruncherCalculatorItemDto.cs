using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCrunchApi.NumberCruncher.NumberCruncherCalculator
{
  public class NumberCruncherCalculatorItemDto : INumberCruncherCalculatorItemDto
  {
    public int SampleNumber { get; set; }
    public string Score { get; set; }

  }
}
