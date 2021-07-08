using NumberCrunchDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberCrunchDemo.Util.Converters
{
  public class NumberCruncherCalculatorItemsConverter
  {
    public static List<NumberCruncherCalculatorItemModel> ConvertJsonToNumberCruncherCalculatorItemList(string json) {

      var NumberCruncherCalculatorItems = Newtonsoft.Json.JsonConvert.DeserializeObject<List<NumberCruncherCalculatorItemModel>>(json);

      return NumberCruncherCalculatorItems;
    }
  }
}
