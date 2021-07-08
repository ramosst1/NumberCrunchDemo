using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberCrunchWebApi.Models
{
  public class NumberCruncherV1CalculatorItemModel : INumberCruncherV1CalculatorItemModel
  {
    public int SampleNumber { get; set; }
    public string Score { get; set; }

  }
}
