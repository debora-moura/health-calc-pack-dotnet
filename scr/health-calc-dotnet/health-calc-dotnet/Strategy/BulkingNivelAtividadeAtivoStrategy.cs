using health_calc_dotnet.Interfaces;
using health_calc_dotnet.Models;
using health_calc_dotnet.Strategy.Base;
using health_calc_pack_dotnet.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_dotnet.Strategy
{
    public class BulkingNivelAtividadeAtivoStrategy : MacronutrienteBase, IMacronutrienteStrategy
    {

        const int PROTEINA = 2;
        const int GORDURA = 2;
        const int CARBOIDRADO = 7;

        public BulkingNivelAtividadeAtivoStrategy(SexoEnum Sexo) : base(Sexo)
        {
        }

        public MacronutrienteModel Calc(double Weight)
        {

            var Result = new MacronutrienteModel()
            {
                Proteinas = (int)(PROTEINA * (int)Weight * GENDER_MULTIPLIER),
                Carboidratos = (int)(CARBOIDRADO * (int)Weight * GENDER_MULTIPLIER),
                Gorduras = (int)(GORDURA * (int)Weight * GENDER_MULTIPLIER),
            };

            return Result;
        }
    }
}