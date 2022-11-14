using health_calc_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_dotnet.Interfaces
{
   public interface IMacronutrienteStrategy
    {
        MacronutrienteModel Calc(double Weight);
    }
}
