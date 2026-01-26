using ESP.Application.DTOS;
using ESP.Application.Entities;
using ESP.Domain.Interfaces.Repositories;
using FluentValidation;
using FluentValidation.Results;

namespace ESP.Application.UseCase;

public class CreateTodoUseCase : ICreateTodoUseCase
{
    private readonly ITodoRepository _todoRepository;
    private readonly IValidator<CreateTodoDto> _validator;

    public CreateTodoUseCase(ITodoRepository todoRepository, IValidator<CreateTodoDto> validator)
    {
        _todoRepository = todoRepository;
        _validator = validator;
    }

    public async Task<TodoDto> Execute(CreateTodoDto createTodoDto)
    {
        ValidationResult validationResult = await _validator.ValidateAsync(createTodoDto);
        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        var todo = new Todo(
            createTodoDto.Title
        );
        Todo savedTodo = await _todoRepository.Add(todo);
        return new TodoDto(savedTodo);
    }
}