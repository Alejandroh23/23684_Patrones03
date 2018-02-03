using System;
namespace Patrones02.Caracteres
{
    public class PhoneB: validable
    {
        @Override
    public Boolean validate(String input)
        {
            return input.Contains("()0987654321-");
        }
    }
}