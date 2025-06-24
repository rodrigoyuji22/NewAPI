namespace NewAPI.Entities;

public class TaskItem
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Done  { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
}