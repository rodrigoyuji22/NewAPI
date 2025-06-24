namespace NewAPI.Dtos;

public class UpdateTaskItemDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Done  { get; set; }
}