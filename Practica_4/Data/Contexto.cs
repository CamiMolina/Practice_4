using System;
using System.Collections.Generic;
using System.Text;


namespace Data
{
    public class Contexto : InterContext
    {
        public List<Group> TablaGrupo { get; set; }
        public Contexto()
        {
            TablaGrupo = new List<Group>()
        {
            new Group(){ Name="",Cod="",Spaces=3},
            new Group(){ Name="",Cod="",Spaces=5},
            new Group(){ Name="",Cod="",Spaces=7}
        };
        }

        public List<Group> GetAll()
        {
            return TablaGrupo;
        }
        public Group GrupoAdd(Group group)
        {
            TablaGrupo.Add(group);
            return group;
        }
        public Group UpdateP(Group groupToUpdate)
        {
            Group GrupoEncontrado = TablaGrupo.Find(group => group.Cod == groupToUpdate.Cod);
            GrupoEncontrado.Name = groupToUpdate.Name;
            GrupoEncontrado.Cod = groupToUpdate.Cod;
            GrupoEncontrado.Spaces = groupToUpdate.Spaces;
            return GrupoEncontrado;
        }
        public Group DeleteGroup(Group groupToDelete)
        {
            TablaGrupo.RemoveAll(group => group.Cod =  groupToDelete);
            return groupToDelete;
        }

        public Group GroupAdd(Group group)
        {
            throw new NotImplementedException();
        }
    }
}

