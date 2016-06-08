using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLLib.Windows
{
    public class Environment
    {
        public static void SetEnviroment(string variable, string value)
        {
            System.Environment.SetEnvironmentVariable(variable, value, EnvironmentVariableTarget.Machine);
        }
        public static string GetEnviroment(string variable)
        {
            return System.Environment.GetEnvironmentVariable(variable, EnvironmentVariableTarget.Machine);
        }

    }
}
