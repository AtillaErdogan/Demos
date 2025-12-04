using Demo2.Data;
using Demo2.Entities;

namespace Demo2.Repositories
{
    public class CourseRepository: GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(AppDbContext context) : base(context)
        {
        }
    }
}
