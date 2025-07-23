<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness - Self-hosted alternative to MyFitnessPal

SparkyFitness is a comprehensive fitness tracking and management application designed to help users monitor their nutrition, exercise, and body measurements. It provides tools for daily progress tracking, goal setting, and insightful reports to support a healthy lifestyle.

Docs: https://codewithcj.github.io/SparkyFitness

## ✨ Features

### 🍎 Nutrition Tracking

* **Log your daily meals**
* **Create and manage custom foods and categories**
* **View summaries and analyze trends with interactive charts**

### 💪 Exercise Logging

* **Record your workouts**
* **Browse and search a comprehensive exercise database**
* **Track fitness progress over time**

### 💧 Water Intake Monitoring

* **Track daily hydration goals**
* **Simple, quick water logging**

### 📏 Body Measurements

* **Record body metrics** (e.g. weight, waist, arms)
* **Add custom measurement types**
* **Visualize progress through charts**

### 🎯 Goal Setting

* **Set and manage fitness and nutrition goals**
* **Track progress over time**

### 🗓️ Daily Check-Ins

* **Monitor daily activity**
* **Stay consistent with habit tracking**

### 🤖 AI Nutrition Coach (SparkyAI)

* **Log food, exercise, body stats, and steps via chat**
* **Upload food images to log meals automatically**
* **Includes chat history and personalized guidance**

### 🔒 User Authentication & Profiles

* **Secure login system**
* **Switch between user profiles**
* **Support for family access and management**

### 📊 Comprehensive Reports

* **Generate summaries for nutrition and body metrics**
* **Track long-term trends over weeks or months**

### 🎨 Customizable Themes

* **Switch between light and dark mode**
* **Designed with a minimal, distraction-free interface**

### Need Help?
* **Join discord**
  https://discord.gg/vcnMT5cPEA
* **Post in discussion**




![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)

## 🚀 Quick Start

Get SparkyFitness running in minutes:

```bash
# Clone the repository
git clone https://github.com/CodeWithCJ/SparkyFitness.git
cd SparkyFitness

# Copy environment template and edit as needed
cp docker/.env.example .env

# Start development environment (with live reloading)
./docker/docker-helper.sh dev up

# Access application at http://localhost:8080
```
## 📖 Documentation

For complete installation guides, development setup, and usage instructions, visit our comprehensive documentation:

**👉 [SparkyFitness Documentation Site](https://codewithcj.github.io/SparkyFitness)**

### Quick Links

- **[🚀 Getting Started](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Complete setup guide for development and production
- **[🐳 Docker Guide](https://codewithcj.github.io/SparkyFitness/developer/docker)** - Docker deployment and configuration
- **[🔧 Development Workflow](https://codewithcj.github.io/SparkyFitness/developer/workflow)** - Developer guide and contribution process  
- **[📊 Features Overview](https://codewithcj.github.io/SparkyFitness/features/)** - Complete feature documentation
- **[🏗️ Architecture](https://codewithcj.github.io/SparkyFitness/app-overview)** - Technical architecture and design

## 🐳 Docker Deployment

**Production (recommended):**

```bash
cp docker/.env.example .env  # Edit as needed
./docker/docker-helper.sh prod up
# Access at http://localhost:3004
```
**Development:**

```bash
cp docker/.env.example .env  # Edit as needed  
./docker/docker-helper.sh dev up
# Access at http://localhost:8080 (live reloading)
```
For detailed setup instructions, environment configuration, and troubleshooting, see the [complete documentation](https://codewithcj.github.io/SparkyFitness/developer/getting-started).

### ⚠️ Known Issues / Beta Features ⚠️

The following features are currently in beta and may not have been thoroughly tested. Expect potential bugs or incomplete functionality:

*   AI Chatbot
*   Multi-user support
*   Family & Friends access
*   Apple Health Data integration

This application is under heavy development. Things may not work as expected due to the Supabase to PostgreSQL migration. BREAKING CHANGES might be introduced until the application is stable.
You might need to change Docker/environment variables for new releases. Therefore, auto-upgrades using Watchtower or similar apps are not recommended. Read release notes for any BREAKING CHANGES.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---