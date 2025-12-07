namespace ECommerce.Application.Interfaces
{
    public interface IGenericService<T, TDto, TCreateDto, TUpdateDto>
        where T : class
        where TDto : class
        where TCreateDto : class
        where TUpdateDto : class
    {
        Task<List<TDto>> GetAllAsync();
        Task<TDto> GetByIdAsync(int id);
        Task<TDto> CreateAsync(TCreateDto createDto);
        Task UpdateAsync(int id, TUpdateDto updateDto);
        Task DeleteAsync(int id);
    }
}
