using System;
using System.Diagnostics;
using System.IO;

/// <summary>
/// MÃ©thodes d'extension pour le cours d'introduction Ã  la programmation du CÃ©gep de Sainte-Foy
/// <author>Pierre-FranÃ§ois LÃ©on</author>
/// </summary>
public static class FctEntreesIP
{
    public static bool ReadBool(this TextReader p_tr)
    {
        return Read<bool>(p_tr, bool.TryParse);
    }

    public static int ReadInt(this TextReader p_tr)
    {
        return Read<int>(p_tr, int.TryParse);
    }

    public static float ReadFloat(this TextReader p_tr)
    {
        return Read<float>(p_tr, float.TryParse);
    }

    public static double ReadDouble(this TextReader p_tr)
    {
        return Read<double>(p_tr, double.TryParse);
    }

    public static decimal ReadDecimal(this TextReader p_tr)
    {
        return Read<decimal>(p_tr, decimal.TryParse);
    }

    public static char ReadChar(this TextReader p_tr)
    {
        return Read<char>(p_tr, char.TryParse);
    }

    private static TypeDonnees Read<TypeDonnees>(TextReader p_tr, TryParseHandler<TypeDonnees> p_handler)
    {
        string str = Console.In.ReadLine();
        TypeDonnees parsedValue = default(TypeDonnees);

        if (!p_handler(str, out parsedValue))
        {
            string methodName = (new StackTrace()).GetFrame(1).GetMethod().Name;
            Console.Error.WriteLine($"Impossible de lire le type demandÃ© par la mÃ©thode {methodName} !");
            Environment.Exit(1);
        }

        return parsedValue;
    }

    private delegate bool TryParseHandler<T>(string value, out T result);
}