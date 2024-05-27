# LambdaTest Selenium Driver Testing

This repository contains the testing project for the `LambdaTest.Selenium.Driver` package. The project includes both local and cloud testing scripts using Selenium.

## Getting Started

Follow these instructions to clone the repository, install the necessary packages, and run the tests.

### Prerequisites

- .NET SDK 8.0
- ChromeDriver

### Installation

1. **Clone the repository:**

    ```sh
    git clone https://github.com/yourusername/csharp-sdk-testing.git
    cd csharp-sdk-testing
    ```

2. **Restore the packages:**

    ```sh
    dotnet restore
    ```

### Running Tests

You can run the tests for both local and cloud environments. The `Program.cs` file is configured to run specific tests based on the provided arguments.

```sh 
npm install @lambdatest/smartui-cli 
```

Create a new SmartUI CLI type project and run the following commands. (You will find our credentials on your project page)

```sh
export LT_USERNAME="your_username"
export LT_ACCESS_KEY="your_access_key"
export PROJECT_TOKEN="123456#1234abcd-****-****-****-************"
```

#### Local Test

To run the local test:

```sh
npx smartui exec dotnet run -- local
```

#### Cloud Test

To run the cloud test, ensure you have set the necessary environment variables for LT_USERNAME and LT_ACCESS_KEY.

```sh
npx smartui exec dotnet run -- cloud
```

#### Local Test with Options

To run the local test with options:

```sh
npx smartui exec dotnet run -- localoptions
```

#### Cloud Test with Options

To run the cloud test with options, ensure you have set the necessary environment variables for LT_USERNAME and LT_ACCESS_KEY.


```sh
npx smartui exec dotnet run -- cloudoptions
```