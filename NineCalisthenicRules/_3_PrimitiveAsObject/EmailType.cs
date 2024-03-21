using System.Text.RegularExpressions;

namespace NineCalisthenicRules._3_PrimitiveAsObject;

public readonly struct EmailType
{
  private readonly string _email;
  public EmailType(string email)
  {
    Check(email);

    _email = email;
  }

  public static void Check(string email)
  {
    if (string.IsNullOrWhiteSpace(email)) throw new ArgumentNullException(nameof(email));

    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    Match match = regex.Match(email);

    if (!match.Success) throw new ArgumentException();
  }

  public static implicit operator EmailType(string email) => new EmailType(email);
 
}
