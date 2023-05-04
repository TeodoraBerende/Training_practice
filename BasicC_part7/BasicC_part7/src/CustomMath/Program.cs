// See https://aka.ms/new-console-template for more information
using CustomMath;
using CustomMath.Services;

Console.WriteLine("Hello, World!");

var fileService = new FileService();

var math = new MathOperations(fileService);

var result = math.Max(5, 4);
Console.WriteLine(result);