using NumberCrunchApi.NumberCruncher;
using NumberCrunchWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NumberCrunchApi.NumberCruncher.NumberCruncherCalculator;

namespace NumberCrunchWebApi.Util.Converters
{
  public class NumberCruncherConverter
  {
    public static INumberCruncherDto Convert(INumberCrunchV1InputModel aNumberCrunch) {

      var MapperConfig = new MapperConfiguration(cfg => {
        cfg.CreateMap<INumberCrunchV1InputModel, INumberCruncherDto>();
      });

      IMapper IMapper = MapperConfig.CreateMapper();

      var results = IMapper.Map<INumberCrunchV1InputModel, INumberCruncherDto>(aNumberCrunch);

      return results;
    }
  }
}
