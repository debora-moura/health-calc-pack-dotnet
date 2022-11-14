using health_calc_pack_dotnet.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_dotnet.Strategy.Base
{
    public abstract class MacronutrienteBase
    {
        public double GENDER_MULTIPLIER;
        public MacronutrienteBase(SexoEnum Sexo)
        {
            GENDER_MULTIPLIER = (Sexo == SexoEnum.Feminino) ? 0.8 : 1;
        }

    }
}
