using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCrunchApi.NumberCruncher.NumberCruncherCalculator
{
  public class NumberCrunchCalculator : INumberCrunchCalculator
  {
    public List<INumberCruncherCalculatorItemDto> Calculate(INumberCruncherDto aNumberCruncher)
    {

      var CalcularList = new List<INumberCruncherCalculatorItemDto>();

      var SampleCounter = 1;

      for (var i = 0; i < aNumberCruncher.SampleMaxCount; i++)
      {

        var DoctorIsDivisible = IsDivisible(SampleCounter, aNumberCruncher.DoctorScore);
        var PatientIsDivisible = IsDivisible(SampleCounter, aNumberCruncher.PatientScore);

        var aCalculatorItem = new NumberCruncherCalculatorItemDto()
        {
          SampleNumber = SampleCounter,
          Score = WhoIsDivisible(DoctorIsDivisible, PatientIsDivisible)
        };

        SampleCounter++;

        CalcularList.Add(aCalculatorItem);
      }

      return CalcularList;
    }

    private static bool IsDivisible(int num1, int num2) {

      if (num1 % num2 == 0) return true;

      return false;

    }

    private static string WhoIsDivisible(bool docIsDivisible, bool patientIsDivisible) {

      if(docIsDivisible == true && patientIsDivisible == true) { return "Both";}
      else if(docIsDivisible == true && patientIsDivisible == false) { return "Doctor";  }
      else if (docIsDivisible == false && patientIsDivisible == true) { return "Patient"; }

      return "None";
    }
  }
}
