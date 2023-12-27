using System;
using System.Text;
using UnityEditor;
using UnityEngine;

public class SwizzleMethodGenerator
{
    public static string GenerateSwizzleMethods()
    {
        StringBuilder methods = new StringBuilder();
        string[] components = new string[] { "x", "y", "z", "w" };

        // Generate for Vector2 from Vector2
        GenerateMethodsForTwoComponents("Vector2", "Vector2", components, 2, methods);

        // Generate for Vector3 from Vector3
        GenerateMethodsForThreeComponents("Vector3", "Vector3", components, 3, methods);

        // Generate for Vector4 from Vector4
        GenerateMethodsForFourComponents("Vector4", "Vector4", components, 4, methods);

        // Generate for Vector2 from Vector3
        GenerateMethodsForTwoComponents("Vector2", "Vector3", components, 3, methods);

        // Generate for Vector3 from Vector4
        GenerateMethodsForThreeComponents("Vector3", "Vector4", components, 4, methods);

        // Generate for Vector2 from Vector4
        GenerateMethodsForTwoComponents("Vector2", "Vector4", components, 4, methods);

        return methods.ToString();
    }

    private static void GenerateMethodsForTwoComponents(string returnType, string inputType, string[] components, int componentCount, StringBuilder methods)
    {
        for (int i = 0; i < componentCount; i++)
        {
            for (int j = 0; j < componentCount; j++)
            {
                methods.AppendLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                methods.AppendLine($"public static {returnType} {components[i].ToUpperInvariant()}{components[j].ToUpperInvariant()}(this {inputType} v)");
                methods.AppendLine("{");
                methods.AppendLine($"    return new {returnType}(v.{components[i]}, v.{components[j]});");
                methods.AppendLine("}");
                methods.AppendLine();
            }
        }
    }

    private static void GenerateMethodsForThreeComponents(string returnType, string inputType, string[] components, int componentCount, StringBuilder methods)
    {
        for (int i = 0; i < componentCount; i++)
        {
            for (int j = 0; j < componentCount; j++)
            {
                for (int k = 0; k < componentCount; k++)
                {
                    methods.AppendLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                    methods.AppendLine($"public static {returnType} {components[i].ToUpperInvariant()}{components[j].ToUpperInvariant()}{components[k].ToUpperInvariant()}(this {inputType} v)");
                    methods.AppendLine("{");
                    methods.AppendLine($"    return new {returnType}(v.{components[i]}, v.{components[j]}, v.{components[k]});");
                    methods.AppendLine("}");
                    methods.AppendLine();
                }
            }
        }
    }

    private static void GenerateMethodsForFourComponents(string returnType, string inputType, string[] components, int componentCount, StringBuilder methods)
    {
        for (int i = 0; i < componentCount; i++)
        {
            for (int j = 0; j < componentCount; j++)
            {
                for (int k = 0; k < componentCount; k++)
                {
                    for (int l = 0; l < componentCount; l++)
                    {
                        methods.AppendLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                        methods.AppendLine($"public static {returnType} {components[i].ToUpperInvariant()}{components[j].ToUpperInvariant()}{components[k].ToUpperInvariant()}{components[l].ToUpperInvariant()}(this {inputType} v)");
                        methods.AppendLine("{");
                        methods.AppendLine($"    return new {returnType}(v.{components[i]}, v.{components[j]}, v.{components[k]}, v.{components[l]});");
                        methods.AppendLine("}");
                        methods.AppendLine();
                    }
                }
            }
        }
    }

    [MenuItem("Tools/Generate Swizzle Metyhods")]
    public static void Main()
    {
        string generatedMethods = GenerateSwizzleMethods();
        Debug.Log(generatedMethods);
    }
}