namespace FileReadLibrary;
using System.IO;
using System.Xml;

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

    public string ReadEncryptedTextFile(string filePath)
    {
        try
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the contents of the encrypted text file as a string
                string content = File.ReadAllText(filePath);

                // Decrypt the content using a simple reverse encryption method
                // Using an array of characters because string is not mutable
                char[] charArray = content.ToCharArray();
                Array.Reverse(charArray);
                string decryptedContent = new string(charArray);
                return decryptedContent;
            }
            else
            {
                return "Encrypted text file not found.";
            }
        }
        catch (Exception ex)
        {
            return $"An error occurred while reading the encrypted text file: {ex.Message}";
        }
    }

    public string ReadXmlFileWithRoleSecurity(string filePath, string role)
    {
        switch (role)
        {
            // Admins have unrestricted access
            case "admin":
                return ReadXmlFile(filePath); 

            // Users can only read .....
            case "user" :
                return ReadXmlFile(filePath);

            // another role will result in a restriction
            default:
                return "Access denied.";
        }
    }

    public string ReadEncryptedXmlFile(string filePath)
    {
        try
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                string xmlContent = File.ReadAllText(filePath);

                // Convert the content to a character array
                char[] charArray = xmlContent.ToCharArray();

                // Reverse the character array
                Array.Reverse(charArray);

                // Create a new string from the reversed character array
                string decryptedXmlContent = new string(charArray);
                return decryptedXmlContent;
            }
            else
            {
                return "Encrypted xml file not found.";
            }
        }
        catch (Exception ex)
        {
            return $"An error occurred while reading the encrypted xml file: {ex.Message}";
        }
    }

    public string ReadTextFileWithRoleSecurity(string filePath, string role)
    {
        switch (role)
        {
            // Admins have unrestricted access
            case "admin":
                return ReadTextFile(filePath);

            // Users can only read .....
            case "user":
                return ReadTextFile(filePath);
            // another role will result in a restriction
            default:
                return "Access denied.";
        }
    }

    public string ReadJsonFile(string filePath)
    {
        try
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the JSON content from the file
                string jsonContent = File.ReadAllText(filePath);
                return jsonContent;
            }
            else
            {
                return "JSON file not found.";
            }
        }
        catch (Exception ex)
        {
            return $"An error occurred while reading the JSON file: {ex.Message}";
        }
    }

    public string ReadEncryptedJsonFile(string filePath)
    {
        try
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the encrypted JSON content from the file
                string encryptedJsonContent = File.ReadAllText(filePath);

                // Decrypt the JSON content by reversing it
                char[] charArray = encryptedJsonContent.ToCharArray();
                Array.Reverse(charArray);
                string decryptedJsonContent = new string(charArray);

                return decryptedJsonContent;
            }
            else
            {
                return "Encrypted JSON file not found.";
            }
        }
        catch (Exception ex)
        {
            return $"An error occurred while reading the encrypted JSON file: {ex.Message}";
        }
    }

    public string ReadJsonFileWithRoleSecurity(string filePath, string role)
    {
        switch (role)
        {
            // Admins have unrestricted access
            case "admin":
                return ReadJsonFile(filePath);

            // Users can only read .....
            case "user":
                return ReadJsonFile(filePath);

            // another role will result in a restriction
            default:
                return "Access denied.";
        }
    }

}