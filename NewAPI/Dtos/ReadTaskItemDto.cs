namespace NewAPI.Dtos;

public class ReadTaskItemDto
{
    public Guid  Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime TimeLimit { get; set; }
    public bool Done  { get; set; }
    
}