using MySecretStash;

var stash = ReadConfig.Read();
foreach (var item in stash)
{
    Console.WriteLine(item);
}

Logger.Log("Hello World!");