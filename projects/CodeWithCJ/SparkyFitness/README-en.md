
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">Simplified Chinese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">Traditional Chinese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">Japanese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">Korean</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">Hindi</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">Thai</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">French</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">German</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Spanish</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italian</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Russian</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Portuguese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Dutch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polish</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">Arabic</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">Persian</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Turkish</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Vietnamese</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Indonesian</a></p>
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

## � Quick Start

Get SparkyFitness running in minutes:

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -o docker-compose.yml https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docker/docker-compose.prod.yml
curl -o .env https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docker/.env.example

# 3. (Optional) Edit .env to customize your setup
# e.g., update database credentials, ports, etc.
# if you require Gamrin integration, uncomment Garmin section from compose file.

# 4. Start the app
docker compose pull && docker compose up -d

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
- Refer WIiki for sample env setup and Mobile App configuration.


## Star History

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Translations

<a href="https://hosted.weblate.org/engage/sparkyfitness/">
<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Translation status" />
</a>

## Repository activity

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Repobeats analytics image")


## Contributors

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

### ⚠️ Known Issues / Beta Features ⚠️

The following features are currently in beta and may not have been thoroughly tested. Expect potential bugs or incomplete functionality:

*   AI Chatbot
*   Multi-user support
*   Family & Friends access
*   Apple Health Data integration

This application is under heavy development. Things may not work as expected due to the Supabase to PostgreSQL migration. BREAKING CHANGES might be introduced until the application is stable.
You might need to change Docker/environment variables for new releases. Therefore, auto-upgrades using Watchtower or similar apps are not recommended. Read release notes for any BREAKING CHANGES.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---