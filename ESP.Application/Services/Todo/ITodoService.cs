using ESP.Application.DTOS;

namespace ESP.Application.Service.Todo;

public interface ITodoService
{
    public Task<TodoDto> FindById(Guid id);

}
