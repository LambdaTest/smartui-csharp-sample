# SmartUI SDK Sample for Selenium C# — TestMu AI (Formerly LambdaTest)

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
- TestMu AI account credentials (for Cloud tests)
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
- `Selenium.WebDriver` - Selenium WebDriver
- `Selenium.WebDriver.ChromeDriver` - ChromeDriver for local testing
- `LambdaTest.Sdk.Utils` - TestMu AI SDK utilities


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

- Connects to TestMu AI Cloud using Selenium Remote WebDriver
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

For detailed onboarding instructions, see the [SmartUI Selenium C# Onboarding Guide](https://www.testmuai.com/support/docs/smartui-onboarding-selenium-csharp/).

## 🚀 LambdaTest is Now TestMu AI

👋 Welcome to TestMu AI, the next evolution of LambdaTest. As of January 2026, [LambdaTest is Now TestMu AI](https://www.testmuai.com/lambdatest-is-now-testmuai/) - we have evolved from a cross-browser testing cloud into a unified, AI-native quality engineering platform designed for the modern DevOps era.

Whether you have been part of the LambdaTest community for years or are just discovering TestMu AI, our mission remains the same: to help you ship faster with high-scale test execution, autonomous testing, and deep quality analytics.

### 🔄 Our Rebrand Journey

In 2017, we introduced LambdaTest with a clear mission: to become the world's most trusted cloud testing platform. We built a scalable, high-performance test cloud that eliminated flakiness, improved developer feedback cycles, and accelerated release velocity for teams worldwide.

As LambdaTest grew, we expanded the platform into Test Intelligence, Visual Regression Testing, Accessibility Testing, API Testing, and Performance Testing, covering the entire testing lifecycle. These capabilities enabled teams to test any stack, on any technology, at enterprise scale.

Over time, we rebuilt the architecture to be AI-native from the ground up. What began as LambdaTest's high-performance testing cloud has now evolved into TestMu AI, an AI-native, multi-agent platform redefining modern quality engineering.

We chose the name TestMu AI to reflect our shift towards intelligent, autonomous testing. While our identity has changed, our core technology and commitment to the testing community stay the same.

👉 Find [LambdaTest's New Home](https://www.testmuai.com/).

### 🔭 Explore TestMu AI

The same infrastructure LambdaTest customers relied on, now delivered through autonomous AI agents.

- [KaneAI](https://www.testmuai.com/kane-ai/)
- [Agent-to-Agent Testing](https://www.testmuai.com/agent-to-agent-testing/)
- [HyperExecute](https://www.testmuai.com/hyperexecute/)
- [Real Device Cloud](https://www.testmuai.com/real-device-cloud/)
- [Pricing](https://www.testmuai.com/pricing/)
- [Documentation](https://www.testmuai.com/support/docs/)