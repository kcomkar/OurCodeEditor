using Intellisense.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace RoslynIntellisense
{
    class Program
    {
        static int Main(string[] args)
        {
            //AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            //Debug.Assert(false);

            //new Engine().Preload();

            //Formatting(args);
            //IntellisenseSimple();
            //return 1;
            //Intellisense();
            if (args.Contains("/test") || args.Contains("-test"))
                return Test();
            else if (args.Contains("/detect") || args.Contains("-detect"))
                return Detect();
            else
                return 0;
        }

        //private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        //{
        //    var file = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), args.Name.Split(',').First() + ".dll");
        //    if (File.Exists(file))
        //        return Assembly.LoadFrom(file);
        //    return null;
        //}

        static int Test()
        {
            //var engine
            //Autocompleter.FindMissingUsings();
            //Autocompleter.FindMissingUsings11();
            //Intellisense2();
            //IntellisenseSimple();
            //SyntaxServer();
            Formatting(null);
            //Console.ReadLine();
            //SyntaxServer();
            //Console.ReadLine();
            //ResolveNamespaces();
            //IntellisenseVb();
            return 0;
        }

        static void SyntaxServer()
        {
            new Engine().Preload();
            var code = @"class Script
{
    static void Main()
    {
        var test = ""ttt"";
        System.Console.Wr|iteLine($""Hello World!{test.Ends";

            int caret = code.IndexOf("|");
            code = code.Replace("|", "");

            var completions = Autocompleter.GetAutocompletionFor(code, caret);
            foreach (ICompletionData item in completions)
                Console.WriteLine($"{item.DisplayText}\t{item.CompletionType},{item.DisplayText}");
        }

        static int ResolveNamespaces()
        {
            string code = @"class Test
            {
                void Foo()
                {
                    Form
                }
            }";

            var sources = new Tuple<string, string>[0];
            var asms = new[] { typeof(object).Assembly.Location, typeof(Form).Assembly.Location };

            var engine = new Engine();
            engine.Preload();
            engine.ResetProject(sources, asms);

            var result = engine.GetPossibleNamespaces(code, "Form", "script.cs");
            result = engine.GetPossibleNamespaces(code, "Form", "script.cs");
            return 0;
        }

        static int Detect()
        {
            try
            {
                Console.WriteLine("success");
                return 0;
            }
            catch (Exception)
            {
                Console.WriteLine("failure");
                return 1;
            }
        }

        static void Formatting(string[] args)
        {
            string file = @"C:\Users\%USERNAME%\Documents\C# Scripts\New Script34.cs";
            file = Environment.ExpandEnvironmentVariables(file);
            file = @"E:\Galos\Projects\CS-Script\GitHub\cs-script\Source\TestPad\test_script.cs";
            args = new[] { file };
            var code = File.ReadAllText(args.First());

            string formattedCode = RoslynIntellisense.Formatter.FormatHybrid(code, "code.cs");

            Console.WriteLine(formattedCode);
        }

        static void Intellisense()
        {
            string script = @"E:\Galos\Projects\CS-Script.Npp\CSScript.Npp\bin\Plugins\CSScriptNpp\NLog.test.cs";
            var sources = new[] { new Tuple<string, string>(File.ReadAllText(script), script) };
            var asms = new[] { @"C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll",
                               @"C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System.IO\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.IO.dll",
                               @"C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Reflection\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Reflection.dll" };

            var engine = new Engine();
            engine.Preload();
            engine.ResetProject(sources, asms);

            var code = File.ReadAllText(script);

            var result = engine.GetCompletionData(code, 598, script);
        }

        static int IntellisenseVb()
        {
            var asms = new[]
            {
                @"C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System.Text.RegularExpressions\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Text.RegularExpressions.dll",
                @"C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System.Linq\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Linq.dll",
                @"C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System.IO\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.IO.dll",
                @"C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll",
                typeof(Form).Assembly.Location
            };

            var code = @"
Imports System
Imports System.Windows.Forms

Module Module1
    Sub Main()
        Console.|WriteLine(""Hello World!(VB)"")
        MessageBox.Show(""Hello World! (VB)"")
    End Sub
End Module";

            var sources = new List<Tuple<string, string>> { };

            int caret = code.IndexOf("|");
            code = code.Replace("|", "");

            var result = Autocompleter.GetAutocompletionFor(code, caret, asms.ToArray(), sources);

            Console.WriteLine("----------------------------------");
            Console.ReadLine();
            return 0;
        }

        static int Intellisense2()
        {
            var asms = new[]
            {
                @"C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System.Text.RegularExpressions\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Text.RegularExpressions.dll",
                @"C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System.Linq\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Linq.dll",
                @"C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System.IO\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.IO.dll",
                @"C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll",
            };

            var code = @"
using System;
class Script
{
    static public void Main(string[] args)
    {
        TestA.|Who();
    }
}";
            var sources = new List<Tuple<string, string>> { new Tuple<string, string>("", "code.cs") };

            int caret = code.IndexOf("|");
            code = code.Replace("|", "");

            var result = Autocompleter.GetAutocompletionFor(code, caret, asms.ToArray(), sources);

            Console.WriteLine("----------------------------------");
            Console.ReadLine();
            return 0;
        }

        static void IntellisenseSimple()
        {
            new Engine().Preload();
            var code = @"class Script
{
    static void Main()
    {
        var test = ""ttt"";
        System.Console.WriteLine($""Hello World!{test.Ends";

            var ttt = Autocompleter.GetAutocompletionFor(code, 131);
            Console.WriteLine("----------------------------------");
            Console.ReadLine();

            var ttt3 = Autocompleter.GetAutocompletionFor(code, 131);
            Console.ReadLine();
        }
    }
}