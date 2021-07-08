using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCrunchApi.NumberCruncher
{
  public interface INumberCruncherDto
  {
    int SampleMaxCount { get; set; }
    int PatientScore { get; set; }
    int DoctorScore { get; set; }

  }
}
