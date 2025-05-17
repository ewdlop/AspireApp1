using System.Collections.Immutable;
using Fluxor;

namespace AspireApp1.Web.State;

[FeatureState]
public record TodoState(ImmutableList<string> Todos)
{
    public static TodoState Initial => new(ImmutableList<string>.Empty);
}

public static class TodoReducers
{
    [ReducerMethod]
    public static TodoState AddTodo(TodoState state, AddTodoAction action)
    {
        return state with { Todos = state.Todos.Add(action.Todo) };
    }

    [ReducerMethod]
    public static TodoState RemoveTodo(TodoState state, RemoveTodoAction action)
    {
        return state with { Todos = state.Todos.Remove(action.Todo) };
    }
}

public record AddTodoAction(string Todo);
public record RemoveTodoAction(string Todo);