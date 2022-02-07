// See https://aka.ms/new-console-template for more information
using ProtobufTest;
using System.Diagnostics;

Console.WriteLine("Started!");

var random = new Random();

TestDTO CreateTestDTO() =>
    new TestDTO
    {
        Text = new string('a', 50),
        Text2 = new string('a', 300),
        Text3 = new string('a', 10),
        Text4 = new string('a', 25),
        Int5 = random.Next(),
        Int6 = random.Next(),
        Int7 = random.Next(),
        Int8 = random.Next(),
        Int9 = random.Next(),
        Int10 = random.Next()
    };

var stopWatch = new Stopwatch();
stopWatch.Start();

var testDTOs = Enumerable.Range(0, 1000000).Select(_ => CreateTestDTO()).ToArray();

Console.Write("Creation time: ");
Console.WriteLine(stopWatch.ElapsedMilliseconds);
stopWatch.Restart();

var memoryStream = new MemoryStream();

foreach(var testDTO in testDTOs)
{
    ProtoBuf.Serializer.Serialize(memoryStream, testDTO);
}

Console.Write("Serialize time: ");
Console.WriteLine(stopWatch.ElapsedMilliseconds);


stopWatch.Restart();

memoryStream.Position = 0;

foreach (var testDTO in testDTOs)
{
    ProtoBuf.Serializer.Deserialize<TestDTO>(memoryStream);
}

Console.Write("Deserialize time: ");
Console.WriteLine(stopWatch.ElapsedMilliseconds);