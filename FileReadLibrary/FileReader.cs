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
                return "Text file not found.";
            }
        }
        catch (Exception ex)
        {
            return $"An error occurred while reading the text file: {ex.Message}";
        }
    }

    public string ReadXmlFile(string filePath)
    {
        try
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the contents of the XML file as a string
                string xmlContent = File.ReadAllText(filePath);
                return xmlContent;
            }
            else
            {
                return "XML file not found.";
            }
        }
        catch (Exception ex)
        {
            return $"An error occurred while reading the XML file: {ex.Message}";
        }

    }

}