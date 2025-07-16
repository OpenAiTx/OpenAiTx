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

# SparkyFitness - Selfhosted alternative of MyFitnessPal

SparkyFitness is a comprehensive fitness tracking and management application designed to help users monitor their nutrition, exercise, and body measurements. It provides tools for daily progress tracking, goal setting, and insightful reports to support a healthy lifestyle.


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

## 🚀 Getting Started

To get the SparkyFitness application running on your local machine, follow these steps:

### Prerequisites

### Installation

1.  **Configure Environment Variables:**

    Create a `.env` file in the root directory. Copy the template from the example `.env` file and update it with your settings. Refer to the WIKI for the existing configuration that I used. Try not to change the port as they may not work properly with initial releases until the project is stable.

    *   **Admin Panel URL:** To enable the Admin panel and configure OIDC settings, ensure the `SPARKY_FITNESS_ADMIN_EMAIL` environment variable is set to the appropriate URL for your Admin panel.
    

2.  **Run with Docker Compose:**
    Pull the Docker images and start the services. If you've made changes to the `.env` file, you should rebuild the images to ensure the new environment variables are picked up.


    ```sh
    docker-compose pull # Pull the latest Docker images
    docker-compose up -d # Start the services in detached mode
    ```
    Refer to the sample setup as a reference
    https://github.com/CodeWithCJ/SparkyFitness/wiki/Sample-Setup

3.  **Access the Application:**
    Once the services are up and running, access SparkyFitness in your web browser at the URL configured for your frontend (e.g., `http://localhost:3004` or `http://your_frontend_ip_or_domain:3004`).

4.  **AI Chatbot - Optional Configuration:**
    To enable the full functionality of the AI Chatbot, you will need to configure the necessary API keys within the application's settings after logging in.
  
5.  **Initial Application Setup:**
    After logging into the application, navigate to the settings menu to:
    *   Add your preferred food providers (e.g., OpenFoodFacts is a free option).
    *   Adjust your preferences and profile settings.

### ⚠️ Known Issues / Beta Features ⚠️

The following features are currently in beta and may not have been thoroughly tested. Expect potential bugs or incomplete functionality:

*   AI Chatbot
*   Multi-user support
*   Family & Friends access
*   Apple Health Data integration

This application is under heavy development. Things may not work as expected due to the Supabase to PostgreSQL migration. BREAKING CHANGES might be introduced until the application is stable.
You might need to change Docker/environment variables for new releases. Therefore, auto-upgrades using Watchtower or similar apps are not recommended. Read release notes for any BREAKING CHANGES.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---