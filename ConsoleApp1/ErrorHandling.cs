namespace ConsoleApp1;

public class ErrorHandling
{
    public void ReadFile(string filePath)
    {
        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine($"Directory not found: {ex.Message}");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File not found: {ex.Message}");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Access denied: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}