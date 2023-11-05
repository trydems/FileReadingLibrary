# File Reading Utility

This C# utility provides a simple way to read and process various file types. It evolves with additional features over different versions.

## Features

- **Version 1**: Initial version that allows users to read plain text files.

- **Version 2**: Added support for reading XML files.

- **Version 3**: Introduced the ability to read encrypted text files. The encryption algorithm is an reverse-text-mechanism and can be easily switched.

- **Version 4**: Extended the utility to include role-based security for XML files. Administrators (=admin) have unrestricted access, while other roles (=user,...) have limited access.

- **Version 5**: Added support for reading encrypted XML files.

- **Version 6**: Enhanced role-based security to include text files.

- **Version 7**: Added support for reading JSON files.

- **Version 8**: Enabled reading of encrypted JSON files.

- **Version 9**: Included role-based security for JSON files.

- **Adding CLI**: A simple CLI application that allows users to specify the file type, enable encryption, and enable role-based security. Users can read multiple files with different settings without restarting the application.

- **Creating Readme.md**: README.md file was created.
  
## Included Files

The repository contains six example files that you can use for testing:

- `sample1.txt`: Plain text file.
- `sample1Encrypted.txt`: Encrypted text file.
- `sample1.xml`: XML file.
- `sample1Encrypted.xml`: Encrypted XML file.
- `sample1.json`: JSON file.
- `sample1Encrypted.json`: Encrypted JSON file.

## Note

- This utility is a demonstration of evolving a simple file reader to handle additional features over different versions.
- The utility could have been optimized for efficiency, but we were required to adhere to a strict business-driven development order.


