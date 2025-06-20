namespace NewAPI.Dtos;

public class CreateTaskItemDto
{
    public string  Title { get; set; }
    public string Description { get; set; }
    public DateTime TimeLimit { get; set; }
    // corrigir prop
}