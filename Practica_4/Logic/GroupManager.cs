using System;
using System.Collections.Generic;
using Data;
using Logic;
using Regex = System.Text.RegularExpressions.Regex;

namespace Logic
{
    public class GroupManager : InterGroupMan
    {   private readonly Contexto _Contexto;
        private int CodNum;
        private Regex gruporegrex;
        public GroupManager(Contexto dbContexto)
        {
            _Contexto = dbContexto;
            CodNum = _Contexto.GetAll().Count;
            gruporegrex = new Regex(@"^Group\-[0-9]{3}$");
        }
        public List<Group> GetAllGroups()
        {
            List<Data.Group> groups = _Contexto.GetAll();
            return Auxiliar.AuxGroups(groups);
        }
        public Group CrearGrupo (Group group)
        {
            if (String.IsNullOrEmpty(group.Name))
            {
                throw new Exception();
            }
            else if (group.Name.Length>50 || group.Spaces<1)
            {
                throw new Exception();
            }
            CodNum++;
            group.Cod = $"Group - {CodNum.ToString().PadLeft(3, '0')}";
            _Contexto.GroupAdd(Auxiliar.AuxGroup(group));
            return group;
        }
        public Group ActualizarGrupo(Group group)
        {
            if (String.IsNullOrEmpty(group.Name) || String.IsNullOrEmpty(group.Cod)){
                throw new Exception();
            }
            else if (group.Name.Length>50 || group.Spaces<1 || !gruporegrex.IsMatch(group.Cod)){
                throw new Exception();
            }
            group.Name = "Actualizado";
            return group;
        }
        public Group BorrarGrupo(Group group)
        {
            if (String.IsNullOrEmpty(group.Name) || String.IsNullOrEmpty(group.Cod)){
                throw new Exception();
            }
            else if (group.Name.Length > 50 || group.Spaces < 1 || !gruporegrex.IsMatch(group.Cod)){
                throw new Exception();
            }
            group = Auxiliar.AuxGroup(_Contexto.BorrarGrupo(Auxiliar.AuxGroup(group)));
            group.Name = "Borrado";
            return group;
        }

    }
}
