using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class MobitelService : IMobitelService
    {
        private IRepository<Mobiteli> mobitelRepository;

        public MobitelService(IRepository<Mobiteli> mobitelRepository)
        {
            this.mobitelRepository = mobitelRepository;
        }
        public IEnumerable<Mobiteli> GetMobiteli()
        {
            return mobitelRepository.GetAll();
        }

        public Mobiteli GetMobitel(int id)
        {
            return mobitelRepository.Get(id);
        }
    }
}
