using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NumberCrunchApi.NumberCruncher.NumberCruncherCalculator;
using NumberCrunchWebApi.Models;

namespace NumberCrunchWebApi.Util.Converters
{
  public class NumberCruncherCalculatorConverter
  {
    public static List<INumberCruncherV1CalculatorItemModel> Convert(List<INumberCruncherCalculatorItemDto> aNumberCrunchCalculatorItems)
    {

      var results = new List<INumberCruncherV1CalculatorItemModel>();

      foreach (var item in aNumberCrunchCalculatorItems)
      {
        results.Add(Convert(item));
      }

      return results;

    }

    private static INumberCruncherV1CalculatorItemModel Convert(INumberCruncherCalculatorItemDto aNumberCrunchCalculatorItem)
    {

      var MapperConfig = new MapperConfiguration(cfg => {
        cfg.CreateMap<INumberCruncherCalculatorItemDto, INumberCruncherV1CalculatorItemModel>();
      });

      IMapper IMapper = MapperConfig.CreateMapper();

      var results = IMapper.Map<INumberCruncherCalculatorItemDto, INumberCruncherV1CalculatorItemModel>(aNumberCrunchCalculatorItem);

      return results;
    }

  }
}
