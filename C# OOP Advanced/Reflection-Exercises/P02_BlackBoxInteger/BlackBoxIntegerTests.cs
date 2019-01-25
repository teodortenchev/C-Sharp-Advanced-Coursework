namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type targetClass = typeof(BlackBoxInteger);
            var instance = Activator.CreateInstance(targetClass, true);

            MethodInfo[] methods = targetClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArgs = command.Split('_');
                string commandName = commandArgs[0];
                int value = int.Parse(commandArgs[1]);


                MethodInfo method = (MethodInfo)methods.FirstOrDefault(m => m.Name == commandName)
                    .Invoke(instance, new object[] { value });

                FieldInfo field = targetClass.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance);

                var result = field.GetValue(instance);

                Console.WriteLine(result);

                command = Console.ReadLine();
            }








        }
    }
}
