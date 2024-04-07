namespace NineCalisthenicRules._3_PrimitiveAsObject.BadExample;

public record Customer(string Email);

// Equivalent to:
//public record Customer
//{
//    public string Email { get; set; }
//}