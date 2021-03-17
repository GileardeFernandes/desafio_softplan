using API1.Persistence.Contexts;

namespace API1.Persistence.Repositories
{
    public class BaseRepository {

        protected readonly AppDBContext _context;
        public BaseRepository(AppDBContext context){

            _context = context;
        }
    }
}