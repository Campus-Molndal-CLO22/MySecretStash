using MySecretStash;

var stash = ReadConfig.Read();
foreach (var item in stash)
{
    Console.WriteLine(item);
}