using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberCrunchWebApi.Models
{
  public class NumberCrunchV1InputModel: INumberCrunchV1InputModel
  {
      public int SampleMaxCount { get; set; }
      public int PatientScore { get; set; }
      public int DoctorScore { get; set;  
    
    }
  }
}
