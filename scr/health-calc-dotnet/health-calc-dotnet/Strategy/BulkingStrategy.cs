using health_calc_dotnet.Interfaces;
using health_calc_dotnet.Models;
using health_calc_pack_dotnet.Enums;


namespace health_calc_pack_dotnet.Strategy
{
    public class BulkingStrategy : IMacronutrienteStrategy
    {

        const int PROTEINA = 2;
        const int GORDURA = 2;
        const int CARBOIDRADO = 4;


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
