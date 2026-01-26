using ESP.Application.DTOS;

namespace ESP.Application.UseCase;

public interface ICreateTodoUseCase
{
    Task<TodoDto> Execute(CreateTodoDto createTodoDto);
}