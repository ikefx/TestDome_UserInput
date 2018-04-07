using System;
using System.Collections.Generic;
/*  (uses inheritance)
 * 
 *  User interface contains two types of user input controls: 
 *      TextInput: which accepts all characters
 *      NumericInput: which accepts only digits.
    Implement the class TextInput that contains:
        Public method void Add(char c) - adds the given character to the current value
        Public method string GetValue() - returns the current value
    Implement the class NumericInput that:
        Inherits TextInput
        Overrides the Add method so that each non-numeric character is ignored
    For example, the following code should output "10":
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue()); 
 *
 */

public class TextInput
{
    public IList<char> list = new List<char>();

    public virtual void Add(char c)
    {
        list.Add(c);
    }

    public string GetValue()
    {
        string r = "";
        foreach (char l in list)
        {
            r = r + l;
        }
        return r;
    }
}
/* Inheritance Example */
public class NumericInput : TextInput
{
    /* NumericInput is a child of TextInput, inherits Add() method */
    public override void Add(char c)
    {
        if (c < '0' || c > '9')
        {
            return;
        }
        else
            list.Add(c);
    }
}

public class TestDome_UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('7');
        Console.WriteLine(input.GetValue());
        Console.ReadKey();
    }
}
