using System;
using System.Collections.Generic;
using System.Text;
using Logic;
using Data;
namespace Logic
{
    public interface InterGroupMan
    {
        List <Data.Group> GetAll();
        Data.Group CrearGrupo(Data.Group group);
        Data.Group ActualizarGrupo(Data.Group group);
        Data.Group BorrarGrupo(Data.Group group);
    }
}
