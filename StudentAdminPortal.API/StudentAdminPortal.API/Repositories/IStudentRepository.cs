using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        public Task<IEnumerable<Student>> GetStudentsAsync();
    }
}
