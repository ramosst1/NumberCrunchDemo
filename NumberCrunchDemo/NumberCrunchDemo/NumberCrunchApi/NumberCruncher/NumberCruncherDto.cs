using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCrunchApi.NumberCruncher
{
  public class NumberCruncherDto: INumberCruncherDto
  {
    public int SampleMaxCount { get; set; }
    public int PatientScore { get; set; }
    public int DoctorScore { get; set; }

  }
}
