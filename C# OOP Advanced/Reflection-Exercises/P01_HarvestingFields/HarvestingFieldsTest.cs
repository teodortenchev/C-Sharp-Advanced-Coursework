 namespace P01_HarvestingFields
{
    using System;
    using System.Reflection;
    using System.Linq;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {

            Type targetClass = typeof(HarvestingFields);

            FieldInfo[] fields = targetClass.GetFields(BindingFlags.Instance
                | BindingFlags.NonPublic | BindingFlags.Public);


            string command = Console.ReadLine();

            while (command != "HARVEST")
            {
                switch (command)
                {
                    case "private":
                        PrintFields(fields.Where(f => f.IsPrivate == true).ToArray());
                        break;
                    case "protected":
                        PrintFields(fields.Where(f => f.IsFamily == true).ToArray());
                        break;
                    case "public":
                        PrintFields(fields.Where(f => f.IsPublic == true).ToArray());
                        break;
                    case "all":
                        PrintFields(fields);
                        break;
                    default:
                        break;
                }


                command = Console.ReadLine();
            }
        }

        public static void PrintFields(FieldInfo[] fields)
        {
            foreach (FieldInfo field in fields)
            {
                string accessModifier = field.Attributes.ToString().ToLower();
                accessModifier =  accessModifier == "family" ? "protected" : accessModifier;
                string fieldType = field.FieldType.Name;
                string fieldName = field.Name;

                Console.WriteLine($"{accessModifier} {fieldType} {fieldName}");
            }
        }
    }
}
