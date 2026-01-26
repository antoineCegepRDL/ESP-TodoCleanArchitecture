using ESP.Application.DTOS;

namespace ESP.Application.UseCase;
public interface IGetAllTodosUseCase
{
    Task<IList<TodoDto>> Execute();
}