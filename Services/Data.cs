using laserApp.Models;

namespace laserApp.Services;

public static class laserService
{
    static List<Data> DataEntries { get; }
    static int nextId = 3;
    static laserService()
    {
        DataEntries = new List<Data>
        {
            new Data { Id = 1, Text = "This is a laser record"},
            new Data { Id = 2, Text = "This is not a laser record"}
        };
    }

    public static List<Data> GetAll() => DataEntries;

    public static Data? Get(int id) => DataEntries.FirstOrDefault(p => p.Id == id);

    public static void Add(Data entry)
    {
        entry.Id = nextId++;
        DataEntries.Add(entry);
    }

    public static void Delete(int id)
    {
        var dataId = Get(id);
        if(dataId is null)
            return;

        DataEntries.Remove(dataId);
    }

    public static void Update(Data dataEntry)
    {
        var index = DataEntries.FindIndex(p => p.Id == dataEntry.Id);
        if(index == -1)
            return;

        DataEntries[index] = dataEntry;
    }
}
