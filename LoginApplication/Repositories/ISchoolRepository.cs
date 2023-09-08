using LoginApplication.Models.DTO;


namespace LoginApplication.Repositories
{
    public interface ISchoolRepository<T> where T : class
    {

        public List<T> Get(string path);
        void Add(string path, List<T> ReadAllUsers);

        public List<T> GetById(string path, int id);


    }
}