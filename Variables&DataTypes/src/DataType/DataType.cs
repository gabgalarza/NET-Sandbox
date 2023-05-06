class DataType
{
  public void OutputString()
  {
    Console.WriteLine("Just a string"); // Double quotes
  }
  public void OutputCharLiteral()
  {
    Console.WriteLine('b'); // Single quotes
  }
  public void OutputCharLiteralException()
  {
    try
    {
    // Console.WriteLine('This will throw an error'); // error CS1012: Too many characters in character literal 
    }
    catch (Exception ex) 
    {
      Console.WriteLine(ex.ToString());
    }
  }
  public void OutputInt()
  {
    Console.WriteLine(123);
  }
  public void OutputFloatLiteral()
  {
    Console.WriteLine(0.25F);
  }
  public void OutputDoubleLiteral()
  {
    Console.WriteLine(2.625);
  }
  public void OutputDecimalLiteral()
  {
    Console.WriteLine(12.39816m);
  }
  public void OutputBoolLiteral()
  {
    Console.WriteLine(true);
    Console.WriteLine(false);
  }
  public void OutputDataTypes()
  {
    OutputString();
    OutputCharLiteral();
    OutputCharLiteralException();
    OutputInt();
    OutputFloatLiteral();
    OutputDoubleLiteral();
    OutputDecimalLiteral();
    OutputBoolLiteral();
  }
}