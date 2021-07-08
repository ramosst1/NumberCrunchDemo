using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberCrunchWebApi.Models
{
  public interface INumberCrunchV1InputModel
  {
    int SampleMaxCount { get; set; }
    int PatientScore { get; set; }
    int DoctorScore { get; set; }

  }
}
