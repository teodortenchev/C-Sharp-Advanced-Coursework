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
}
