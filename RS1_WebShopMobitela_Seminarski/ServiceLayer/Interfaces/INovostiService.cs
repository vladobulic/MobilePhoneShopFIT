using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface INovostiService
    {
        public IEnumerable<Novosti> GetNovosti();
        public int InsertNovost(Novosti entitity);
        public void InsertNovost2(Novosti entitity);
        public void ObrisiNovost(Novosti entity);
        public Novosti GetNovost(int Id);
        public void SaveChanges(Novosti entity);
    }
}
