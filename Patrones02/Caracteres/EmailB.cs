using System;
using System.Text.RegularExpressions;

namespace Patrones02.Caracteres
{
    public class EmailB : validable
    {
        @Override
    public Boolean validate(String input)
        {
            return input.Contains("[+*@_.]TYUIO*+_-.,--@");
        }
    }
}