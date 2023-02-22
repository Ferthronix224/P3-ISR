using TecNM.Practica3.Core.Entities;

namespace TecNM.Practica3.Core.Services.Interfaces;

public interface IIsrService
{
    ISR ProcessISR(Person person);
}