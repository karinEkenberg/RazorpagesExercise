# RazorpagesExercise

RazorpagesExercise is a simple web application built using Razor Pages in ASP.NET Core. It provides functionality to manage a list of people.

## Features

- **Add People**: Users can add new people to the list by providing their id, name, and age.
- **View People**: The list of people is displayed in a table format showing their id, name, and age.

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine.
- Basic understanding of Razor Pages and ASP.NET Core.

## Getting Started

1. Clone this repository to your local machine.

   ```bash
   git clone <repository-url>
   ```

2. Navigate to the project directory.

   ```bash
   cd RazorpagesExercise
   ```

3. Run the application.

   ```bash
   dotnet run
   ```

4. Open your web browser and go to `https://localhost:5001/` to view the application.

## Project Structure

- **Pages**: Contains the Razor Pages (.cshtml files) for different functionalities.
- **Models**: Contains the data model classes used in the application.
- **MyDbContext.cs**: Defines the database context for Entity Framework Core.
- **Program.cs**: Configures and starts the web application.
- **Startup.cs**: Configures services and middleware for the application.

## Contributing

Contributions are welcome! If you find any bugs or have suggestions for improvements, please open an issue or submit a pull request.
