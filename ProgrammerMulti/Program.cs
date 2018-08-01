using System;
using System.Text;
using ReProBuild;
//Using Tag

namespace Application
{
    public class AppRe
    {
        public static void Main(string[] args)
        {
            StringBuilder fixedStart = new StringBuilder();
            fixedStart.Append("using System;");
            fixedStart.Append("namespace newworld");
            fixedStart.Append("{");
            fixedStart.Append(" class MainNew");
            fixedStart.Append(" {");
            fixedStart.Append("    public static void Main(string[] args)");
            fixedStart.Append("    {");
            string[] midpart = new string[] {
                "Console.WriteLine(\"Hello new world);",
                "Console.WriteLine(\"Hello new world\");",
                "Console.WriteLie(\"Hello new world\");",
                "Console.WriteLine(\"Hello new world\");Console.WriteLine(\"Hello new world\");"};
 
            StringBuilder fixedEnd = new StringBuilder();
            fixedEnd.Append("    }");
            fixedEnd.Append(" }");
            fixedEnd.Append("}");

            for (int i = 0; i < 4; i++)
            {
				Console.WriteLine(CompileDecompiles.CompileExecutable("test" + i.ToString(), fixedStart.ToString() + midpart[i] + fixedEnd.ToString()));
            }
        }
    }
}
