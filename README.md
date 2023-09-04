# WARNING

If you download the release your antivirus will very likely detect a virus. There is no virus. I might be lying. Or I might not be.
Good Luck.

# Seshat - File Sorting Application

Seshat is a simple file sorting application built using C# and Windows Forms. It allows you to specify source and destination directories and define rules for sorting files based on their extensions. You can also customize the sorting rules by setting different destination directories for specific file extensions.

## Features

- Select source and destination directories using a folder browser dialog.
- Define custom rules for sorting files based on their extensions.
- Automatically move files from the source directory to the specified destination directories based on the defined rules.
- Clear the sorting rules for specific extensions and destinations.

## Usage

1. **Source Directory**: Select the source directory from which files will be sorted.

2. **Destination Directories**: Select destination directories for specific file extensions.

3. **Sorting Rules**: Define sorting rules by specifying file extensions and their corresponding destination directories. Leave a textbox empty if you don't want to sort files with a specific extension.

4. **Sort Button**: Click the sort to start the sorting process based on the defined rules.

5. **Trash Icons**: Use the trash icons to clear the sorting rules for specific extensions and destinations.

6. **Play Icons**: Click the play icons to manually trigger sorting for specific extensions without running the sorting process for all extensions.

## Important Note

- Make sure the source directory exists before attempting to sort files.
- When using the play icons, the sorting is performed only for the specific extension associated with that icon.

## Dependencies

This project relies on the following libraries:

- .NET Framework
- Windows Forms

## Getting Started

To get started with this project, follow these steps:

1. Clone the repository to your local machine.

2. Open the project in Visual Studio or your preferred C# development environment.

3. Build and run the application.

You could also just download the release

Enjoy using Seshat for efficient file sorting!
