
<div align="right">
  <details open>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

<!-- 
Spring Boot 3 微服務腳手架，Spring Cloud OAuth2 認證，shadcn ui 後台模板，
Java 快速開發框架，Spring Boot Admin 前後端分離，Nacos 配置中心，
微服務權限管理，JWT 登入，Spring Security 6，Vue3 管理系統
-->
<p align="center">
  <h3 align="center">Snail - 企業級微服務快速開發腳手架</h3>
  <p align="center">
    🚀 基於 Spring Boot 3 + Spring Cloud + OAuth2 + shadcn/ui
  </p>
  <p align="center">
    <a href="#-快速開始">快速開始</a> •
    <a href="#-文件">文件</a> •
    <a href="#-貢獻">貢獻</a> •
  </p>
  <p align="center">
    <img src="https://img.shields.io/github/stars/haiyinlong/snail?style=social" alt="GitHub Stars">
    <img src="https://img.shields.io/github/forks/haiyinlong/snail?style=social" alt="GitHub Forks">
  </p>
</p>

# 🐌 Snail - 輕量級 Spring Boot 快速開發腳手架

> **Snail** 是一個基於 Spring Boot 3
> 的現代化微服務快速開發框架，提供開箱即用的認證、授權、閘道、資源服務等核心能力，協助企業快速構建安全、可擴展的雲原生應用。

🚀 **開箱即用 | 安全可靠 | 易於擴展 | 前後端一體化**

---

## 🌟 特色

- ✅ **基於最新技術棧**：`Spring Boot 3.5.5` + `Spring Cloud 2025.0.0` +
  `Spring Cloud Alibaba 2023.0.3.3`
- 🔐 **OAuth2 認證授權**：整合 `Spring Security` + `JWT`，支援統一身份認證與細粒度權限控管
- 🌐 **微服務架構**：模組化拆分，包含認證、授權、閘道、資源服務，支援獨立部署與橫向擴展
- ⚡ **高效能閘道**：基於 `Spring Cloud Gateway` 實現路由、限流、熔斷、鑑權
- 🧩 **雲原生支援**：相容 Nacos、Sentinel、Seata，支援服務發現、配置中心、分散式交易
- 🎨 **現代化管理後台**：基於 [shadcn-vue/ui](https://www.shadcn-vue.com/)
  建構的簡潔、響應式後台管理介面
- 📚 **完善文件**：涵蓋架構設計、部署指南、API 文件與二次開發說明

---

## 🛠 技術棧

| 類別        | 技術                                                                |
|-----------|-------------------------------------------------------------------|
| **後端框架**  | Spring Boot 3.5.5、Spring Cloud 2025.0.0、Spring Security、OAuth2 |
| **微服務治理** | Nacos（註冊中心 & 配置中心）,                                               |
| **網關**    | Spring Cloud Gateway                                              |
| **資料庫**   | MySQL 8                                                           |
| **前端框架**  | Vue 3 + Vite + TypeScript + shadcn/ui                             |
| **建構工具**  | Maven、Docker、Docker Compose                                     |
| **監控**    | Spring Boot Actuator、Prometheus（可選）、Grafana（可選）                 |

---

## 🏗 專案結構

```bash
snail/
├── authentication/           # 認證服務（OAuth2 授權伺服器）
├── authorization/          # 授權服務（權限管理、角色、選單）
├── gateway/               # API 閘道（路由、驗權、限流）
├── resource/              # 資源服務（業務 API 範例）
├── snail-vue-app/          # 後台管理介面（Vue3 + shadcn/ui）
└── pom.xml                      # Maven 父工程


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---