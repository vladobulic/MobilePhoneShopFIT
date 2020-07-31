using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Mobiteli> GetMobiteliSorted(int page, bool priceDesc, string searchNaziv, string priceFromAndTo, int? ProizvodjacId, int resultsPerPage, ref int TotalPages)
        {
            var mobiteli = mobitelRepository.GetAllQueryable();
            

            if(ProizvodjacId != null && ProizvodjacId != 0)
            {
                mobiteli = mobiteli.Where(x => x.ProizvodjacId == ProizvodjacId.Value);
            }
            if (!string.IsNullOrEmpty(searchNaziv))
                mobiteli = mobiteli.Where(x => x.Naziv.Contains(searchNaziv) || x.Naziv.StartsWith(searchNaziv) || x.Prozivodjac.Naziv.Contains(searchNaziv));
            if (!string.IsNullOrEmpty(priceFromAndTo))
            {
                int priceFrom = Convert.ToInt32(priceFromAndTo.Split(';')[0]);
                int priceTo = Convert.ToInt32(priceFromAndTo.Split(';')[1]);

                
                mobiteli = mobiteli.Where(x =>
                (x.PopustId != null && (x.Cijena - (x.Cijena * x.Popust.PostotakPopusta) >= priceFrom && x.Cijena - (x.Cijena * x.Popust.PostotakPopusta) <= priceTo))
                || x.Cijena >= priceFrom && x.Cijena <= priceTo);
            }

            
            if (priceDesc)
                mobiteli = mobiteli.OrderByDescending(x => x.Cijena);
            else
                mobiteli = mobiteli.OrderBy(x => x.Cijena);

            TotalPages = (int)Math.Ceiling(decimal.Divide(mobiteli.Count(), resultsPerPage));
            
            if (page != 0)
                page -= 1;
            mobiteli = mobiteli.Skip(resultsPerPage * page).Take(resultsPerPage);
           

            return mobiteli.ToList();
        }
    }
}
