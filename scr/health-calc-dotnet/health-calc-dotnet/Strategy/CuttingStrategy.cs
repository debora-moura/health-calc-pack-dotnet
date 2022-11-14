using health_calc_dotnet.Interfaces;
using health_calc_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_dotnet.Strategy
{

    public class CuttingStrategy : IMacronutrienteStrategy
    {

        const int PROTEINA = 2;
        const int GORDURA = 1;
        const int CARBOIDRADO = 2;


        public MacronutrienteModel Calc(double Weight)
        {

            var Result = new MacronutrienteModel()
            {
                Proteinas = PROTEINA * (int)Weight,
                Carboidratos = CARBOIDRADO * (int)Weight,
                Gorduras = GORDURA * (int)Weight,
            };

            return Result;
        }
    }
}
