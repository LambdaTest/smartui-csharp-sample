# SmartUI SDK Sample for Selenium C#

Welcome to the SmartUI SDK sample for Selenium C#. This repository demonstrates how to integrate SmartUI visual regression testing with Selenium C#.

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

## 1. Prerequisites and Environment Setup

### Prerequisites

- .NET SDK 8.0 or higher
- Node.js installed (for SmartUI CLI)
- LambdaTest account credentials (for Cloud tests)
- Chrome browser (for Local tests)

### Environment Setup

**For Cloud:**
```bash
export LT_USERNAME='your_username'
export LT_ACCESS_KEY='your_access_key'
export PROJECT_TOKEN='your_project_token'
```

**For Local:**
```bash
export PROJECT_TOKEN='your_project_token'
```

## 2. Initial Setup and Dependencies

### Clone the Repository

```bash
git clone https://github.com/LambdaTest/smartui-csharp-sample
cd smartui-csharp-sample/LambdaTest.Selenium.Driver.Test
```

### Install Dependencies

The repository already includes the required dependencies in `LambdaTest.Selenium.Driver.Test.csproj`. Restore them:

```bash
dotnet restore
dotnet build
```

**Dependencies included:**
- `LambdaTest.Selenium.Driver` - SmartUI SDK for Selenium C#
- `Selenium.WebDriver` - Selenium WebDriver (version 4.21.0 or higher required)
- `Selenium.WebDriver.ChromeDriver` - ChromeDriver for local testing
- `LambdaTest.Sdk.Utils` - LambdaTest SDK utilities
- `Newtonsoft.Json` - JSON handling

**Note**: If you're currently using Selenium 3.x, you'll need to upgrade to Selenium 4.x to use SmartUI. See [Selenium 4 Migration Guide](https://www.selenium.dev/documentation/webdriver/getting_started/upgrade_to_selenium_4/) for migration steps.

### Install SmartUI CLI

```bash
npm install @lambdatest/smartui-cli
```

### Create SmartUI Configuration

```bash
npx smartui config:create smartui-web.json
```

## 3. Steps to Integrate Screenshot Commands into Codebase

The SmartUI screenshot function is already implemented in the repository.

**Cloud Test** (`LTCloudTest.cs`):
```csharp
driver.Navigate().GoToUrl("https://www.lambdatest.com");
await SmartUISnapshot.CaptureSnapshot(driver, "screenshot");
```

**Local Test** (`LocalTest.cs`):
```csharp
driver.Navigate().GoToUrl("https://www.lambdatest.com");
await SmartUISnapshot.CaptureSnapshot(driver, "screenshot");
```

**Note**: The code is already configured and ready to use. You can modify the URL and screenshot name if needed.

## 4. Execution and Commands

### Local Execution

```bash
npx smartui exec -- dotnet run -- local
```

### Cloud Execution

```bash
npx smartui exec -- dotnet run -- cloud
```

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

## View Results

After running the tests, visit your SmartUI project dashboard to view the captured screenshots and compare them with baseline builds.

## More Information

For detailed onboarding instructions, see the [SmartUI Selenium C# Onboarding Guide](https://www.lambdatest.com/support/docs/smartui-onboarding-selenium-csharp/).
