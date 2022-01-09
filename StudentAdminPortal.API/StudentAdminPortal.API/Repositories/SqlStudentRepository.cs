using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminDBContext context;

        public SqlStudentRepository(StudentAdminDBContext context)
        {
            this.context = context;
        }
    
        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {

            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
