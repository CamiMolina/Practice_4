using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public static class Auxiliar
    {
        public static List <Group> AuxGroups(List<Data.Group> groups)
        {
            List<Group> AuxiGroups = new List<Group>();
            foreach(Data.Group group in groups)
            {
                AuxiGroups.Add(new Group
                {
                    Cod = group.Cod,
                    Name = group.Name,
                    Spaces = group.Spaces
                });

            }
            return AuxiGroups;
        }
        public static Data.Group AuxGroup(Group group)
        {
            return new Data.Group
            {
                Cod=group.Cod,
                Name=group.Name,
                Spaces=group.Spaces
            };
        }
    }
}
