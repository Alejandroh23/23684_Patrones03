using System;
namespace Patrones02.Caracteres
{
    public class NumberB:validable
    {
        @Override
    public Boolean validate(String input)
        {
            return input.Contains("+*-/");
        }
    }
}