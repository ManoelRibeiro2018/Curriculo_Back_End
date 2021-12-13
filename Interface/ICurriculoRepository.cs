using Curriculo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curriculo.Interface
{
    public interface ICurriculoRepository
    {
        public CurriculoMain Insert(CurriculoMain model);
        public void Update(int id, CurriculoMain model);
        public void Delete(int id);
        public CurriculoMain GetById(int id);
        public List<CurriculoMain> GetAll();

    }
}
