using TecNM.Practica3.Core.Services.Interfaces;
using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Enums;

namespace TecNM.Practica3.Core.Services;

public class IsrService : IIsrService
{

    public ISR ProcessISR(Person person)
    {
        var cuota = new Cuota();
        var limites = new Limites();
        var porcentaje = new Porcentaje();
        var isr = new ISR();
        
        if(person.Salary >= 0.01 && person.Salary <= 7735)
        {
            limites.limite_inferior = 0.01f;
            cuota.Cuota_Fija = 0;
            porcentaje.porcentaje = 1.92f;
            isr.IsrType = IsrType.First;
        }
        else if(person.Salary >= 7735.01 && person.Salary <= 65651.07)
        {
            limites.limite_inferior = 7735.01f;
            cuota.Cuota_Fija = 148.51f;
            porcentaje.porcentaje = 6.40f;
            isr.IsrType = IsrType.Second;
        }else if(person.Salary >= 65651.08 && person.Salary <= 115375.90)
        {
            limites.limite_inferior = 65651.08f;
            cuota.Cuota_Fija = 3855.14f;
            porcentaje.porcentaje = 10.88f;
            isr.IsrType = IsrType.Third;
        }else if(person.Salary >= 115375.91 && person.Salary <= 134119.41)
        {
            limites.limite_inferior = 115375.91f;
            cuota.Cuota_Fija = 9265.20f;
            porcentaje.porcentaje = 16f;
            isr.IsrType = IsrType.Fourth;
        }else if(person.Salary >= 134119.42 && person.Salary <= 160577.65)
        {
            limites.limite_inferior = 134119.42f;
            cuota.Cuota_Fija = 12262.16f;
            porcentaje.porcentaje = 17.92f;
            isr.IsrType = IsrType.Fifth;
        }else if(person.Salary >= 160577.66 && person.Salary <= 323862)
        {
            limites.limite_inferior = 160577.66f;
            cuota.Cuota_Fija = 17005.47f;
            porcentaje.porcentaje = 21.36f;
            isr.IsrType = IsrType.Sixth;
        }else if(person.Salary >= 323862.01 && person.Salary <= 510451)
        {
            limites.limite_inferior = 323862.01f;
            cuota.Cuota_Fija = 51883.01f;
            porcentaje.porcentaje = 23.52f;
            isr.IsrType = IsrType.Seventh;
        }else if(person.Salary >= 510451.01 && person.Salary <= 974535.04)
        {
            limites.limite_inferior = 510451.01f;
            cuota.Cuota_Fija = 92768.74f;
            porcentaje.porcentaje = 30f;
            isr.IsrType = IsrType.Eighth;
        }else if(person.Salary >= 974535.04 && person.Salary <= 1299380.04)
        {
            limites.limite_inferior = 974535.04f;
            cuota.Cuota_Fija = 234993.95f;
            porcentaje.porcentaje = 32f;
            isr.IsrType = IsrType.Nineth;
        }else if(person.Salary >= 1299380.05 && person.Salary <= 3898140.12)
        {
            limites.limite_inferior = 1299380.05f;
            cuota.Cuota_Fija = 338944.34f;
            porcentaje.porcentaje = 34f;
            isr.IsrType = IsrType.Tenth;
        }else if(person.Salary >= 3898140.13)
        {
            limites.limite_inferior = 3898140.13f;
            cuota.Cuota_Fija = 1222522.76f;
            porcentaje.porcentaje = 35f;
            isr.IsrType = IsrType.Eleventh;
        }

        var _base = person.Salary - limites.limite_inferior;
        var resultado = _base * (porcentaje.porcentaje / 100);
        isr.isr = ((float)resultado + cuota.Cuota_Fija);
        return isr;
    }    
}