using BearApi.Model;

namespace BearApi.Service
{
    public class BearsService:IBears
    {
        private List<Bear> bears = new List<Bear>() {
        new Bear() { Id = 1, Name = "corona", Description="una cerveza con clase"},
        new Bear() { Id = 2, Name = "Precidente", Description="una cerveza Dominicana"}
        };

        public IEnumerable<Bear> GetBears() => bears;
  
        public Bear? getId(int id) => bears.FirstOrDefault(b => b.Id == id);
       
    }
}
