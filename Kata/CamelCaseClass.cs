using System;
using System.Globalization;

namespace Kata
{
  public static class CamelCaseClass
  {
    public static string CamelCase(this string str)  
    {  
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str).Replace(" ", String.Empty);
    }
  }
}