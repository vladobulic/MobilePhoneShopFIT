using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.Classes
{

    public class KomentarService : IKomentarService
    {
        private IRepository<Komentar> komentarRepository;

        public KomentarService(IRepository<Komentar> komentarRepository)
        {
            this.komentarRepository = komentarRepository;
        }

        public List<Komentar> GetAllKomentariByPhoneId(int id)
        {
            return komentarRepository.GetAllQueryable().Where(x => x.MobitelId == id).OrderByDescending(x => x.Datum).ToList();
        }

        public void InsertKomentar(Komentar komentar)
        {
            komentarRepository.Insert(komentar);
        }
    }
}
