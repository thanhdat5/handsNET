using handsNET.Data.Infrastructure;
using handsNET.Model.Models;

namespace handsNET.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slider>
    {
    }

    public class SlideRepository : RepositoryBase<Slider>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}