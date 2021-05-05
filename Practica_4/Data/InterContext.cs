using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace Data
{
    public interface InterContext
    {
        List<Group> GetAll();
        Group GroupAdd(Group group);
        Group UpdateP(Group groupToUpdate);
        Group DeleteGroup(Group group);

    }
}
