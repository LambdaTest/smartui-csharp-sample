# SmartUI SDK Sample for Selenium C#

Welcome to the SmartUI SDK sample for Selenium C#. This repository demonstrates how to integrate SmartUI visual regression testing with Selenium C#.

## Prerequisites

- .NET SDK 8.0 or higher
- LambdaTest account credentials (for Cloud tests)
- Chrome browser (for Local tests)
- Node.js (for SmartUI CLI)

## Repository Structure

```
smartui-csharp-sample/
├── LambdaTest.Selenium.Driver.Test/
│   ├── LTCloudTest.cs          # Cloud test
│   ├── LocalTest.cs            # Local test
│   ├── LTCloudOptionsTest.cs   # Cloud test with options
│   ├── LocalOptionsTest.cs     # Local test with options
│   ├── Program.cs               # Main entry point
│   ├── LambdaTest.Selenium.Driver.Test.csproj
│   └── smartui-web.json        # SmartUI config (create with npx smartui config:create)
└── README.md
```

## Quick Start

### Local Execution

1. **Clone the repository:**
   ```bash
   git clone https://github.com/LambdaTest/smartui-csharp-sample
   cd smartui-csharp-sample/LambdaTest.Selenium.Driver.Test
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   dotnet build
   ```

3. **Install SmartUI CLI:**
   ```bash
   npm install @lambdatest/smartui-cli
   ```

4. **Set your Project Token:**
   ```bash
   export PROJECT_TOKEN='your_project_token'
   ```

5. **Create SmartUI config:**
   ```bash
   npx smartui config:create smartui-web.json
   ```

6. **Run the test:**
   ```bash
   npx smartui exec -- dotnet run -- local
   ```

### Cloud Execution

1. **Clone the repository:**
   ```bash
   git clone https://github.com/LambdaTest/smartui-csharp-sample
   cd smartui-csharp-sample/LambdaTest.Selenium.Driver.Test
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   dotnet build
   ```

3. **Install SmartUI CLI:**
   ```bash
   npm install @lambdatest/smartui-cli
   ```

4. **Set your credentials:**
   ```bash
   export LT_USERNAME='your_username'
   export LT_ACCESS_KEY='your_access_key'
   export PROJECT_TOKEN='your_project_token'
   ```

5. **Create SmartUI config:**
   ```bash
   npx smartui config:create smartui-web.json
   ```

6. **Run the test:**
   ```bash
   npx smartui exec -- dotnet run -- cloud
   ```

## Dependencies

The project uses the following NuGet packages (already configured in `.csproj`):

- `LambdaTest.Selenium.Driver` - SmartUI SDK for Selenium C#
- `Selenium.WebDriver` - Selenium WebDriver
- `Selenium.WebDriver.ChromeDriver` - ChromeDriver for local testing
- `LambdaTest.Sdk.Utils` - LambdaTest SDK utilities
- `Newtonsoft.Json` - JSON handling

## Test Files

### Cloud Test (`LTCloudTest.cs`)

- Connects to LambdaTest Cloud using Selenium Remote WebDriver
- Reads credentials from environment variables (`LT_USERNAME`, `LT_ACCESS_KEY`)
- Takes screenshot with name: `screenshot`

### Local Test (`LocalTest.cs`)

- Runs Selenium locally using Chrome
- Requires Chrome browser installed
- ChromeDriver is automatically managed
- Takes screenshot with name: `screenshot`

### Options Tests

- `LTCloudOptionsTest.cs` - Cloud test with SmartUI options
- `LocalOptionsTest.cs` - Local test with SmartUI options

## Configuration

### SmartUI Config (`smartui-web.json`)

Create the SmartUI configuration file using:
```bash
npx smartui config:create smartui-web.json
```

This will create a default configuration file that you can customize.

## View Results

After running the tests, visit your SmartUI project dashboard to view the captured screenshots and compare them with baseline builds.

## More Information

For detailed onboarding instructions, see the [SmartUI Selenium C# Onboarding Guide](https://www.lambdatest.com/support/docs/smartui-onboarding-selenium-csharp/).
