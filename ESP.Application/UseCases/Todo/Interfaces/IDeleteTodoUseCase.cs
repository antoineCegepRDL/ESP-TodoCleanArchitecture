namespace ESP.Application.UseCase;

public interface IDeleteTodoUseCase
{
    Task Execute(Guid id);
}