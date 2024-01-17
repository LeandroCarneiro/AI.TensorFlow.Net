public abstract class BaseFlow
{
    public void Flow()
    {
        try
        {
            Execute();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public abstract void Execute();
}