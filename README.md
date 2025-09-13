# 🔒 PwdAudit
**PwdAudit** is a .NET 9 console application for checking password strength and verifying credentials against known breach data. It’s designed to help developers, security teams, and CI/CD pipelines enforce good password hygiene in a privacy-first way.
## ✨ Features
- **Strength analysis**: Evaluates password length, character variety, patterns, dictionary matches, and entropy.  
- **Breach checking**: Supports offline datasets and optional online checks (k-anonymity style).  
- **Configurable policies**: Enforce minimum length, minimum score, and breach-free requirements.  
- **Multiple modes**: Interactive prompt, batch (file/STDIN), CI-friendly (JSON + exit codes).  
- **Privacy-first**: No plaintext password logging. Offline mode by default.  
## 🚀 Getting Started

### Prerequisites
- [Visual Studio 2022 v17.12+](https://visualstudio.microsoft.com/)  
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)  

### Clone and build
```bash
git clone https://github.com/yourusername/pwdaudit.git
cd pwdaudit
dotnet build
```
### Run
```bash
dotnet run --project src/PwdAudit.App
```

## 🧩 Project Structure
```
src/
  PwdAudit.App    → Console application (CLI shell)
  PwdAudit.Core   → Core library (analysis logic)
tests/
  PwdAudit.Tests  → Unit and integration tests
```
## 🛠 Roadmap
## 🛠 Roadmap
- [ ] Provide clean DTOs + domain models in core 
- [ ] Implement strength scoring rules (length, variety, patterns)  
- [ ] Add breach checker (offline wordlists + optional HIBP API)  
- [ ] Add policy evaluation engine with presets (default, strict, NIST)  
- [ ] Support batch + CI modes with JSON output and exit codes  
- [ ] Improve observability (structured logs, safe masking)  
- [ ] Add GitHub Actions example for CI integration  
- [ ] Write docs with examples for CLI, API, and CI usage  
- [ ] Package as a .NET global tool with config file support   
## 📜 License
GPLv3 License – see [LICENSE](LICENSE.txt) for details.
