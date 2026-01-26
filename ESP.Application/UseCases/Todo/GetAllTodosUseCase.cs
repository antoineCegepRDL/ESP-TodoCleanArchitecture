using ESP.Application.DTOS;
using ESP.Domain.Interfaces.Repositories;

namespace ESP.Application.UseCase;

public class GetAllTodosUseCase : IGetAllTodosUseCase
{
    private readonly ITodoRepository _todoRepository;

    public GetAllTodosUseCase(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public async Task<IList<TodoDto>> Execute()
    {
        var todos = await _todoRepository.GetAll();
        return todos.Select(x => new TodoDto(x)).ToList();
    }
}