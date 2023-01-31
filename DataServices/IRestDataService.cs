using Todo.Client.Models;

namespace Todo.Client.DataServices
{
    public interface IRestDataService
    {
        Task<List<ToDo>> GetAllToDosAsync();
        Task AddToDoAsync(ToDo toDo);
        Task UpdateToDoAsync(ToDo toDo);
        Task DeleteToDoAsync(int id);
    }
}