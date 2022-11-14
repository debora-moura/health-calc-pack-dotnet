using health_calc_dotnet.Interfaces;
using health_calc_dotnet.Models;


namespace health_calc_pack_dotnet
{
    public class MacronutrienteContext
    {
        private IMacronutrienteStrategy MacronutrienteStrategy;

        public MacronutrienteContext(IMacronutrienteStrategy Strategy)
        {
            MacronutrienteStrategy = Strategy;
        }
        public void SetStrategy(IMacronutrienteStrategy Strategy)
        {
            MacronutrienteStrategy = Strategy;
        }

        public MacronutrienteModel Execute(double Weight)
        {
            return MacronutrienteStrategy.Calc(Weight);
        }
    }
}
