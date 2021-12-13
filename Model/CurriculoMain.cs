using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curriculo.Model
{
    public class CurriculoMain : EntityBase
    {
        public string Title { get; set; }
        public User User { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Hobby>  Hobbies { get; set; }

        public CurriculoMain(string title, User user, List<Experience> experiences, List<Hobby> hobbies)
        {
            Title = title;
            User = user;
            Experiences = experiences;
            Hobbies = hobbies;
        }

        public CurriculoMain()
        {
        }
    }
}
