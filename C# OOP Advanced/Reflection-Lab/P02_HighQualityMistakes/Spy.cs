using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string target, params string[] fieldNames)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Class under investigation: {target}");

        Type targetClass = Type.GetType(target);

        FieldInfo[] classFields = targetClass.GetFields(BindingFlags.NonPublic | BindingFlags.Instance
            | BindingFlags.Public | BindingFlags.Static);

        //creates an instance of the target class object with no parameters in constructor.
        object instance = Activator.CreateInstance(targetClass, new object[] { });

        foreach (FieldInfo field in classFields.Where(f => fieldNames.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(instance)}");
           
        }

        return sb.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        StringBuilder sb = new StringBuilder();

        Type targetClass = Type.GetType(className);

        FieldInfo[] targetClassFields = targetClass.GetFields();


        foreach (var field in targetClassFields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        MethodInfo[] publicGetters = targetClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
            .Where(f => f.Name.StartsWith("get")).ToArray();

        //Judge unit test expects "have to be public" and needs to be changed
        foreach (var getter in publicGetters)
        {
            sb.AppendLine($"{getter.Name} has to be public!");
        }

        MethodInfo[] privateSetters = targetClass.GetMethods()
            .Where(f => f.Name.StartsWith("set")).ToArray();

        //Judge unit test expects "have to be public" and needs to be changed
        foreach (var setter in privateSetters)
        {
            sb.AppendLine($"{setter.Name} has to be private!");
        }

        return sb.ToString().Trim();
    }
}
