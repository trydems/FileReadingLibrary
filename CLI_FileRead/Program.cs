using CLI_FileRead;
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of your FileReader class
        FileReader fileReader = new FileReader();

        bool useEncryption = false;
        bool useRoleSecurity = false;
        string role = "";

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Enable/Disable Decryption Algorithm");
            Console.WriteLine("2. Enable/Disable role-based security");
            Console.WriteLine("3. Read a file");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        useEncryption = useEncryption ? false : true;
                        string text = useEncryption ? "\n The decryption algorithm is enabled \n " : "\n The decryption algorithm is disabled \n";
                        Console.WriteLine(text);
                        break;

                    case 2:
                        useRoleSecurity = useRoleSecurity ? false : true;
                        if (useRoleSecurity)
                        {
                            Console.Write("\n Enter your role: ");
                            role = Console.ReadLine();
                            Console.WriteLine($"your role is : {role} \n");
                        }
                        else
                        {
                            Console.WriteLine("\n RoleSecurity was disabled \n");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nWhat file do you want to read?");
                        Console.WriteLine("1. TXT  file");
                        Console.WriteLine("2. XML  file");
                        Console.WriteLine("3. JSON file");
                        Console.Write("Enter your choice: ");

                        if (int.TryParse(Console.ReadLine(), out int choice2))
                        {
                            switch (choice2)
                            {
                                case 1:
                                    ReadFile("TXT", useEncryption, useRoleSecurity, role);
                                    break;
                                case 2:
                                    ReadFile("XML", useEncryption, useRoleSecurity, role);
                                    break;
                                case 3:
                                    ReadFile("JSON", useEncryption, useRoleSecurity, role);
                                    break;
                                default:
                                    Console.WriteLine("\n Invalid choice. Please try again.\n");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("\n Invalid choice. Please try again later... \n");
                        }
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\n Invalid choice. Please try again.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\n Invalid choice. Please enter a number. \n");
            }
        }
    }

    static void ReadFile(string type, bool useEncryption, bool useRoleSecurity, string role)
    {
        FileReader fileReader = new FileReader();
        Console.Write("Enter the path to the file: ");
        string filePath = Console.ReadLine();

        Console.WriteLine("\nReading file.......... ");
        Thread.Sleep(1500);

        // The user choose for encryption AND rolesecurity
        if (useEncryption && useRoleSecurity)
        {
            switch (type)
            {
                case "TXT":
                    string returnedValueTXT = fileReader.ReadTextFileWithRoleSecurity(filePath, role);
                    if (returnedValueTXT == "Access denied.")
                    {
                        Console.WriteLine(returnedValueTXT + "You don't have access to this file with your current role");
                    }
                    else
                    {
                        Console.WriteLine(returnedValueTXT);
                        Console.WriteLine("\nhmmmm seems like the file is encrypted!");
                        Console.WriteLine("Let me fix it....\n");
                        Thread.Sleep(5000);
                        Console.WriteLine(fileReader.ReadEncryptedTextFile(filePath));
                    }
                    break;

                case "XML":
                    string returnedValueXML = fileReader.ReadTextFileWithRoleSecurity(filePath, role);
                    if (returnedValueXML == "Access denied.")
                    {
                        Console.WriteLine(returnedValueXML + "You don't have access to this file with your current role");
                    }
                    else
                    {
                        Console.WriteLine(returnedValueXML);
                        Console.WriteLine("\nhmmmm seems like the file is encrypted!");
                        Console.WriteLine("Let me fix it....\n");
                        Thread.Sleep(5000);
                        Console.WriteLine("\n");
                        Console.WriteLine(fileReader.ReadEncryptedXmlFile(filePath));
                    }
                    break;

                case "JSON":
                    string returnedValueJSON = fileReader.ReadTextFileWithRoleSecurity(filePath, role);
                    if (returnedValueJSON == "Access denied.")
                    {
                        Console.WriteLine(returnedValueJSON + "You don't have access to this file with your current role");
                    }
                    else
                    {
                        Console.WriteLine(returnedValueJSON);
                        Console.WriteLine("\nhmmmm seems like the file is encrypted!");
                        Console.WriteLine("Let me fix it....\n");
                        Thread.Sleep(5000);
                        Console.WriteLine("\n");
                        Console.WriteLine(fileReader.ReadEncryptedJsonFile(filePath));
                    }
                    break;
            }
        }

        // The user choose for encryption BUT NOT for rolesecurity 
        if (useEncryption && !useRoleSecurity)
        {
            switch (type)
            {
                case "TXT":
                    Console.WriteLine("\nhmmmm seems like the file is encrypted!");
                    Console.WriteLine("Let me fix it....\n");
                    Thread.Sleep(5000);
                    Console.WriteLine("\n");
                    Console.WriteLine(fileReader.ReadEncryptedTextFile(filePath));
                    break;

                case "XML":
                    Console.WriteLine("\nhmmmm seems like the file is encrypted!");
                    Console.WriteLine("Let me fix it....\n");
                    Thread.Sleep(5000);
                    Console.WriteLine("\n");
                    Console.WriteLine(fileReader.ReadEncryptedXmlFile(filePath));
                    break;

                case "JSON":
                    Console.WriteLine("\nhmmmm seems like the file is encrypted!");
                    Console.WriteLine("Let me fix it....\n");
                    Thread.Sleep(5000);
                    Console.WriteLine("\n");
                    Console.WriteLine(fileReader.ReadEncryptedJsonFile(filePath));
                    break;
            }

        }

        // The user choose for rolesecurity BUT NOT for encryption
        if (!useEncryption && useRoleSecurity)
        {
            switch (type)
            {
                case "TXT":
                    Console.WriteLine(fileReader.ReadTextFileWithRoleSecurity(filePath, role));
                    break;

                case "XML":
                    Console.WriteLine(fileReader.ReadXmlFileWithRoleSecurity(filePath, role));
                    break;

                case "JSON":
                    Console.WriteLine(fileReader.ReadJsonFileWithRoleSecurity(filePath, role));
                    break;
            }
        }

        // The user choose NOT for encryption NOT for rolesecurity
        if (!useEncryption && !useRoleSecurity)
        {
            switch (type)
            {
                case "TXT":
                    Console.WriteLine(fileReader.ReadTextFile(filePath));
                    break;

                case "XML":
                    Console.WriteLine(fileReader.ReadXmlFile(filePath));
                    break;

                case "JSON":
                    Console.WriteLine(fileReader.ReadJsonFile(filePath));
                    break;
            }
        }

    }
}
