string message = "Find what is (inside the parantheses)";

int openingPosition = message.IndexOf("(");
int closingPosition = message.IndexOf(")");

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));