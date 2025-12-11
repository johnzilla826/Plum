namespace Plum.Models;

public class Split
{
    public int Id { get; set; }
    
    // Transaction FK
    public required int TransactionId { get; set; }
    public required  Transaction Transaction { get; set; }
    
    // Account FK
    public required int AccountId { get; set; }
    public required Account Account { get; set; }
    
    public decimal Amount { get; set; }
}