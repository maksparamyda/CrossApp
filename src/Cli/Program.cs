using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var envData = new
{
    OSDescription = RuntimeInformation.OSDescription,
    OSVersion = Environment.OSVersion.ToString(),
    Architecture = RuntimeInformation.ProcessArchitecture.ToString(),
    DotNetVersion = Environment.Version.ToString(),
    Runtime = RuntimeInformation.FrameworkDescription,
    AppDirectory = AppContext.BaseDirectory,
    CurrentDirectory = Environment.CurrentDirectory,
    Domain = "Склад (товари, партії, залишки, переміщення)"
};

if (args.Contains("--json"))
{
    string jsonString = JsonSerializer.Serialize(envData, new JsonSerializerOptions 
    { 
        WriteIndented = false,
        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    });
    Console.WriteLine(jsonString);
}
else
{
    Console.WriteLine("CrossApp - практикум з крос-платформного програмування");
    Console.WriteLine("Студент: Парамаду Максим, ФЕІ-31с");
    Console.WriteLine(new string('-', 52));
    Console.WriteLine($"ОС (OSDescription): {envData.OSDescription}");
    Console.WriteLine($"ОС (Environment)  : {envData.OSVersion}");
    Console.WriteLine($"Архітектура процесу: {envData.Architecture}");
    Console.WriteLine($"Версія .NET (CLR) : {envData.DotNetVersion}");
    Console.WriteLine($"Runtime            : {envData.Runtime}");
    Console.WriteLine($"Каталог застосунку : {envData.AppDirectory}");
    Console.WriteLine($"Поточний каталог   : {envData.CurrentDirectory}");
    Console.WriteLine(new string('-', 52));
    Console.WriteLine($"Предметна область: {envData.Domain}");
}