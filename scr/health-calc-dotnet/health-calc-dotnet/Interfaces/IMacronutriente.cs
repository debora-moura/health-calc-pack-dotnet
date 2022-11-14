using health_calc_dotnet.Models;
using health_calc_pack_dotnet.Enums;

namespace health_calc_dotnet.Interfaces
{
   public interface IMacronutriente
    {
        MacronutrienteModel Calc(
            SexoEnum Sexo,
            double Height,
            double Weight,
            NivelAtividadeFisicaEnum NivelAtividadeFisica,
            ObjetivoFisicoEnum ObjetivoFisico);

        bool IsValidData(double Weight);
    }
}
