using BearApi.Model;

namespace BearApi.Service
{
    public interface IBears
    {
        IEnumerable<Bear> GetBears();
        public Bear? getId(int id);
    }
}
