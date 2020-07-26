using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;

namespace ServiceLayer.Interfaces
{
    public interface IMobitelService
    {
        IEnumerable<Mobiteli> GetMobiteli();
        Mobiteli GetMobitel(int id);
    }
}
