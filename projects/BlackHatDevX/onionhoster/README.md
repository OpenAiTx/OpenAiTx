<details align="right">
<summary>🌐 Language</summary>

[English](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=th) | [Français](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=de) | [Español](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=it) | [Русский](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ru) | [Português](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=as)

</details>

# OnionHoster v2.2

> **The Ultimate Tor Hidden Service Hosting Tool** - Deploy your web projects to the dark web in minutes!
> 
[![Version](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

<img width="1023" height="551" alt="ChatGPT Image Aug 27, 2025, 03_32_08 PM (1)-modified" src="https://github.com/user-attachments/assets/92b6e834-2d4f-4cc7-8f77-82b9bafba8a5" />


---

## 🚀 What is OnionHoster?

OnionHoster is a powerful, cross-platform bash script that transforms any web project into a Tor hidden service with just one command. Whether you're hosting a Next.js app, Flask backend, or static website, OnionHoster handles all the complex Tor configuration automatically.

### ✨ Why Choose OnionHoster?

- **🔧 Zero Configuration** - Works out of the box with any web project
- **🌍 Cross-Platform** - Supports Linux, macOS, and major distributions
- **⚡ One-Click Setup** - From zero to hidden service in under 2 minutes
- **🔄 Auto-Updates** - Built-in update checker keeps you current
- **💾 Backup & Restore** - Never lose your onion addresses
- **🎯 Professional UI** - Beautiful colored interface with intuitive menus

---
## Preview

[![IMAGE ALT TEXT HERE](https://github.com/user-attachments/assets/4b35dfb0-0059-4cc5-99c7-a5b9467a385d)](https://www.youtube.com/watch?v=oPvhA54Tp8w)


# ⚠️ Warning: OnionHoster is NOT a magic anonymity tool — follow best practices or risk deanonymization

**System Hardening**

* Run the service inside a VM or container for isolation.
* Keep the OS and packages updated.
* Disable unnecessary services/ports so only Tor traffic goes in/out.

**OpSec Practices**

* Don’t use the same machine for personal accounts or activities.
* Avoid exposing identifying metadata (filenames, headers, error messages).
* Be mindful of logs — what you log, how long you keep them, and whether they leak info.

**Network Hygiene**

* Don’t bridge your hidden service with your clearnet identity or domain.
* Use a firewall to ensure no accidental leaks outside Tor.
* Consider reverse proxies for extra isolation.

**Testing & Monitoring**

* Use torsocks or the Tor Browser to verify that your service is only reachable via its `.onion` address.
* Test regularly for leaks (e.g., whether your app is trying to fetch from the clearnet).

**Use Case Awareness**

* For hobby/testing/educational use: the above is usually sufficient.
* For high-risk, real-world anonymity (journalists, whistleblowers, activists): it requires deeper operational security and threat modeling, since a single misstep can de-anonymize you.


---
## 🎯 Perfect For

- **Developers** who want to test their apps on Tor
- **Privacy Advocates** hosting anonymous services (
- **Researchers** studying dark web technologies
- **Businesses** requiring anonymous hosting solutions
- **Hobbyists** exploring the Tor network

---

## 🚀 Quick Start

### Prerequisites
- Root/sudo access
- Internet connection
- Any web project (HTML, Next.js, Flask, etc.)

### Installation & Usage

```bash
# 1. Clone the repository
git clone https://github.com/BlackHatDevX/onionhoster.git

# 2. Navigate to the directory
cd onionhoster

# 3. Make the script executable
chmod +x onionhoster.sh

# 4. Run with sudo
sudo bash onionhoster.sh
```

**That's it!** 🎉

You'll get the complete OnionHoster project including:
- The main `onionhoster.sh` script
- A professional `index.html` template to host
- All documentation and examples

The script will automatically:
- Detect your operating system
- Install all required dependencies (Tor, Apache, etc.)
- Configure Tor services
- Present you with an intuitive menu

---

## 🎮 Features Overview

### 🌐 Hosting Options
- **Static HTML** - Host any `index.html` file
- **Port Forwarding** - Forward to any local application port
- **Dynamic Apps** - Support for Next.js, Flask, Node.js, and more

### 🛠️ Management Tools
- **Service Control** - Start, stop, and manage your hidden service
- **Backup & Restore** - Safely backup and restore your onion domains
- **URL Refresh** - Generate new onion addresses when needed
- **Status Monitoring** - Check service health and status

### 🔄 Smart Updates
- **Auto-Detection** - Automatically finds the latest version
- **One-Click Updates** - Update with a single menu option
- **Safe Updates** - No risk of losing your configuration

---

## 📱 Supported Operating Systems

| OS | Package Manager | Status |
|----|----------------|---------|
| **Ubuntu/Debian** | `apt-get` | ✅ Full Support |
| **CentOS/RHEL** | `yum` | ✅ Full Support |
| **Fedora** | `dnf` | ✅ Full Support |
| **Arch Linux** | `pacman` | ✅ Full Support |
| **macOS** | `brew` | ✅ Full Support |

---

## 🎯 Use Cases

### 🏠 Personal Projects
- Host your portfolio anonymously
- Test web applications privately
- Share content without revealing your identity

### 🏢 Business Applications
- Anonymous customer support portals
- Secure internal communication systems
- Privacy-focused business websites

### 🔬 Research & Development
- Dark web technology research
- Privacy tool development
- Anonymous service testing

---

## 📖 Detailed Usage

### Main Menu Options

1. **Host index.html** - Serve a static HTML file
2. **Forward to Application Port** - Proxy to any local service
3. **Backup tor domain** - Save your onion configuration
4. **Restore tor domain** - Restore from backup
5. **View current tor domain** - See your active onion address
6. **Refresh tor domain** - Generate a new onion address
7. **Check for updates** - Update to the latest version
8. **Web Server Status** - Monitor service health
9. **About OnionHoster** - Version and feature information

### Example Workflow

```bash
# Start the service
sudo ./onionhoster.sh

# Choose option 1 to host index.html
# Your onion address will be displayed
# Access it via Tor Browser or similar
```

---

## 🔧 Advanced Configuration

### Custom Port Forwarding
```bash
# Forward your Next.js app running on port 3000
# The script will handle all Tor configuration automatically
```

### Backup Management
```bash
# Automatic backups are stored in ~/onion_backups/
# Each backup includes your onion keys and configuration
```

---

## 🛡️ Security Features

- **Automatic Tor Configuration** - Secure defaults out of the box
- **Proper File Permissions** - Secure file ownership and access
- **Service Isolation** - Each hidden service runs independently
- **No Data Logging** - Your activities remain private

---

## 🚨 Important Notes

- **Root Access Required** - Tor services need system-level configuration
- **Tor Network** - Your service will be accessible via Tor Browser
- **Onion Addresses** - Each service gets a unique `.onion` address
- **Backup Regularly** - Onion addresses change when refreshing

---

## 🤝 Contributing

We welcome contributions! Whether it's:
- 🐛 Bug reports
- 💡 Feature requests
- 📝 Documentation improvements
- 🔧 Code contributions

**Get started by:**
1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Submit a pull request

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 🙏 Acknowledgments

- **Tor Project** - For the amazing anonymity network
- **Open Source Community** - For continuous improvements
- **Users & Contributors** - For feedback and suggestions

---

## 🔗 Links

- **GitHub**: [https://github.com/BlackHatDevX/onionhoster](https://github.com/BlackHatDevX/onionhoster)
- **Issues**: [https://github.com/BlackHatDevX/onionhoster/issues](https://github.com/BlackHatDevX/onionhoster/issues)
- **Discussions**: [https://github.com/BlackHatDevX/onionhoster/discussions](https://github.com/BlackHatDevX/onionhoster/discussions)

---

## ⭐ Star This Project

If OnionHoster helps you, please give it a star! It motivates us to keep improving and helps others discover this tool.

---

**Ready to go anonymous?** 🕵️‍♂️

```bash
git clone https://github.com/BlackHatDevX/onionhoster.git
cd onionhoster
sudo bash onionhoster.sh
```

*Your journey to anonymous hosting starts now!* 🚀
