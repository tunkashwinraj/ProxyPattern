# ProxyPattern Project

This project demonstrates the use of the Proxy design pattern in C#. It implements a virtual proxy to defer loading images until they are actually needed, optimizing memory usage. The project simulates loading images and related information from local folders while using a proxy to handle the deferred image loading.

## Features
- Virtual Proxy: Delays loading images until required, improving memory efficiency.
- Image Display: Shows images and related information (name, path) from local folders.
- Local Folder Simulation: Reads images and data from a designated local folder.
  
## Setup and Usage

### Prerequisites
- .NET Framework or .NET Core
- Visual Studio or any other C# compatible IDE

### Installation
1. Clone the repository to your local machine.
   ```bash
   git clone https://github.com/your-username/ProxyPattern.git
   ```

2. Open the project in your preferred IDE (e.g., Visual Studio).

3. Build and run the project.

### Usage
1. The application will display a list of image paths from the local folder.
2. Click on any image to load and display it.
3. The image is only loaded when clicked, demonstrating the proxy pattern in action.

## Code Overview
- `IImage`: Interface for image operations.
- `RealImage`: Class implementing the IImage interface that performs the actual loading of an image.
- `ProxyImage`: A proxy class that controls access to `RealImage` and defers the image loading until necessary.
- `ImageDisplay`: The client application that utilizes `ProxyImage` to load images.

## Example Code
```csharp
class Program
{
    static void Main(string[] args)
    {
        IImage image1 = new ProxyImage("image1.jpg");
        IImage image2 = new ProxyImage("image2.jpg");

        // Image will only be loaded when displayed
        image1.Display();
        image2.Display();
    }
}
```

## License
This project is open-source and available under the [MIT License](LICENSE).

## Contributing
Feel free to fork this project, submit issues, or open pull requests.

---

For any inquiries or feedback, please reach out to the project maintainer via GitHub issues.
