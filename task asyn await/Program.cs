
internal class Program
{
    static async Task Main(string[] args)
    {
        var task = new Task(()=>{
            Thread.Sleep(1000);
            Console.WriteLine("Tarea task interna1");
        });
        var task2 = new Task(()=>{
            Thread.Sleep(1000);
            Console.WriteLine("Tarea task interna2");
        });
        task.Start();
        task2.Start();
        await task;
        await task2;
        Console.WriteLine("Tarea principal");

    }
}