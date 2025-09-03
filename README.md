# ECoreAutomationAssessment

### Built With

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/pt-br/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![MSTest](https://img.shields.io/badge/MSTest-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://learn.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-mstest)
[![Selenium](https://img.shields.io/badge/Selenium-43B02A?style=for-the-badge&logo=selenium&logoColor=white)](https://www.selenium.dev/)
[![GitHub Actions](https://img.shields.io/badge/GitHub_Actions-2088FF?style=for-the-badge&logo=githubactions&logoColor=white)](https://github.com/features/actions)

<!-- GETTING STARTED -->
## Getting Started


### Prerequisites

* Visual Studio
* .NET
* MSTest
* Selenium

### Installation

1. Clone the repo
   ```
   git clone https://github.com/fabiocardoso87/ECoreAutomationAssessment.git
   ```
2. Run tests
   ```
   cd ECoreAutomationAssessment
   dotnet restore
   dotnet test
   ```
3. Run tests for specific test categories:
   ```
   dotnet test --filter "Category=smoke"
   dotnet test --filter "Category=regression"
   ```

### CI/CD
All tests are run via GitHub Actions

#### 📊 Build Status
| Branch | Status |
|--------|--------|
| master | ![Test Status](https://github.com/fabiocardoso87/ECoreAutomationAssessment/actions/workflows/run-tests-parallel.yml/badge.svg) |

### Test Outputs:
1. Go to "Actions"
2. Select the workflow "Selenium Tests"
3. Scroll down and check out the detailed logs and download the test artifacts

<!-- CONTACT -->
## Contact

Fabio Cardoso - fabiocardoso@live.com

Project Link: [https://github.com/fabiocardoso87/ECoreAutomationAssessment](https://github.com/fabiocardoso87/ECoreAutomationAssessment)

<p align="right">(<a href="#readme-top">back to top</a>)</p>
