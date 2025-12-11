namespace Plum.Models;

public class Transaction
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public DateTime Date { get; set; } = DateTime.Now.Date;
}