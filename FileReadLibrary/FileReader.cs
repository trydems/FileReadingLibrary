namespace FileReadLibrary;
using System.IO;

public class FileReader
{
    public string ReadTextFile(string filePath)
    {
        try
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the contents of the file
                string content = File.ReadAllText(filePath);
                return content;
            }
            else
            {
                return "File not found.";
            }
        }
        catch (Exception ex)
        {
            return $"An error occurred while reading the text file: {ex.Message}";
        }
    }
}

