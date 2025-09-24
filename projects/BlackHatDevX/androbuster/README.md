# 🚀 AndroBuster

<div align="center">
  <img width="2808" height="699" alt="bannerfinal" src="https://github.com/user-attachments/assets/7f74539f-0af6-40d9-bafb-9207afd80af8" />

</div> 

<div align="center">

**🔒 Pentesting Made Easy**  
*A powerful directory and subdomain enumeration tool built with Flutter*

[![Download APK](https://img.shields.io/badge/Download-APK-blue?style=for-the-badge&logo=android)](https://github.com/BlackHatDevX/androbuster/releases)
[![GitHub stars](https://img.shields.io/github/stars/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![GitHub forks](https://img.shields.io/github/forks/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![GitHub issues](https://img.shields.io/github/issues/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster/issues)

</div>

---

## 📖 Overview

AndroBuster is an **open-source security tool** inspired by GoBuster, providing a modern, cross-platform interface for directory and subdomain enumeration. Built with Flutter, it offers a clean, intuitive user experience while maintaining the power and flexibility expected from professional security tools.

### 🎯 What Makes AndroBuster Special?
- 🚀 **Cross-Platform**: Works on Android, iOS, and Desktop
- 🔒 **Security-Focused**: Built specifically for penetration testers
- 💻 **Modern UI**: Beautiful Flutter-based interface
- ⚡ **High Performance**: Efficient threading and memory management
- 📱 **Mobile-First**: Optimized for mobile security testing

---

## 🖼️ Screenshots

<div align="center">

<img width="339" height="749" alt="Screenshot 2025-08-20 at 1 11 24 AM" src="https://github.com/user-attachments/assets/e12ed93e-876f-408b-9e3d-4a849e8fe2a1" />
<img width="339" height="749" alt="Screenshot 2025-08-20 at 1 11 34 AM" src="https://github.com/user-attachments/assets/17850561-cef9-46e2-8203-8ba29c223fe7" />

</div>

---



## ✨ Features

### 🗂️ Directory Enumeration Mode
- **Target URL Input**: Clean URL handling with automatic trailing slash removal
- **Negative Status Codes**: Filter out unwanted HTTP status codes (default: 404)
- **Negative Page Sizes**: Exclude responses based on content length
- **Wordlist Support**: Large text input with file import capability
- **Threading Control**: Configurable thread count for optimal performance
- **Timeout Settings**: Customizable request timeout in milliseconds

### 🌐 Subdomain Enumeration Mode
- **Domain Input**: Clean domain handling (no http/https required)
- **Subdomain Wordlists**: Dedicated wordlist management for subdomain discovery
- **Protocol Testing**: Automatic HTTPS/HTTP fallback testing
- **Subdomain Validation**: RFC 1123 compliant subdomain name validation
- **Dedicated Filters**: Separate negative status codes and page sizes for subdomains
- **Threading & Timeout**: Independent configuration from directory mode

### 📋 Results Management
- **Unified Results Tab**: View both directory and subdomain scan results
- **Result Formatting**: Clear display of path, status code, size, and URL
- **Copy to Clipboard**: Export results for external analysis
- **Clear Results**: Easy cleanup between scans
- **Result Counts**: Separate tracking for directory and subdomain results

### 📁 File Management
- **Wordlist Import**: Support for .txt files up to 50MB
- **Smart Preview**: File size-aware content display
- **Large File Handling**: Efficient processing of massive wordlists
- **Format Support**: Handles comments (#) and empty lines automatically

### 🚀 Performance & Reliability
- **Background Execution**: App continues running during background scans
- **Memory Optimization**: Efficient handling of large wordlists
- **Error Handling**: Graceful fallback and recovery mechanisms
- **Cross-Platform**: Built with Flutter for Android and iOS



---

## 📱 Installation

### 📦 Release Build
Currently, only Android APK releases are available. Download the latest APK from the releases page.

<div align="center">

[![Download Latest](https://img.shields.io/badge/📥%20Download%20Latest%20Release-blue?style=for-the-badge)](https://github.com/BlackHatDevX/androbuster/releases)

</div>

### 🔧 Building from Source
The source code is now public and available for everyone to use, modify, and contribute to.

---

## 📖 Usage Guide

### 🗂️ Directory Enumeration
1. Navigate to the "Dir" tab
2. Enter your target URL
3. Configure negative status codes and page sizes
4. Paste or import your wordlist
5. Set thread count and timeout
6. Start the scan and monitor progress

### 🌐 Subdomain Enumeration
1. Navigate to the "Subdomain" tab
2. Enter the target domain (without http/https)
3. Configure subdomain-specific filters
4. Import or paste subdomain wordlist
5. Adjust threading and timeout settings
6. Begin subdomain discovery

### 📋 Results Management
- View all results in the "Results" tab
- Copy results to clipboard for external analysis
- Clear results between different scans
- Monitor scan progress and completion

---

## ⚙️ Configuration

### ⚡ Thread Count
- **Recommended**: 10-20 threads for most scenarios
- **High Thread Warning**: Alerts when exceeding 20 threads
- **Considerations**: Higher threads may trigger rate limiting

### ⏱️ Timeout Settings
- **Default**: 5000ms (5 seconds)
- **Adjustment**: Increase for slower networks, decrease for faster responses
- **Range**: 1000ms to 30000ms supported

### 🚫 Negative Filters
- **Status Codes**: Comma-separated list (e.g., 404,403,500)
- **Page Sizes**: Comma-separated list (e.g., 0,1234,5678)
- **Purpose**: Exclude unwanted responses from results

---

## 🤝 Contributing

This project is **open source** and welcomes contributions! The source code is now public and available for everyone.

<div align="center">

[![Star Repository](https://img.shields.io/badge/⭐%20Star%20Repository-yellow?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)

</div>

### 📋 How to Contribute
1. **⭐ Star** the repository (optional but appreciated!)
2. **🍴 Fork** the repository
3. **🌿 Create** a feature branch
4. **📤 Submit** a pull request

---

## 🙏 Credits & Acknowledgments

- **🎯 Inspired by**: [GoBuster](https://github.com/OJ/gobuster) - The original directory enumeration tool
- **🛠️ Built with**: [Flutter](https://flutter.dev/) - Google's UI toolkit for building natively compiled applications
- **🔒 Security Focus**: Designed for penetration testers and security researchers
- **🌍 Community**: Thanks to all contributors and supporters

---

## 📄 License

This project is **open source** and available under the MIT License.

---

## ⚠️ Disclaimer

This tool is designed for **authorized security testing** and **penetration testing purposes only**. Users are responsible for ensuring they have proper authorization before testing any systems. The developers are not responsible for any misuse of this tool.

---
