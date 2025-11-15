<!-- 
Spring Boot 3 Microservices Scaffold, Spring Cloud OAuth2 Authentication, shadcn ui Admin Template, 
Java Rapid Development Framework, Spring Boot Admin Frontend-Backend Separation, Nacos Configuration Center, 
Microservices Permission Management, JWT Login, Spring Security 6, Vue3 Management System 
-->
<p align="center">
  <h3 align="center">Snail - Enterprise-level Microservices Rapid Development Scaffold</h3>
  <p align="center">
    🚀 Based on Spring Boot 3 + Spring Cloud + OAuth2 + shadcn/ui
  </p>
  <p align="center">
    <a href="#-快速开始">Quick Start</a> •
    <a href="#-文档">Documentation</a> •
    <a href="#-贡献">Contribute</a> •
  </p>
  <p align="center">
    <img src="https://img.shields.io/github/stars/haiyinlong/snail?style=social" alt="GitHub Stars">
    <img src="https://img.shields.io/github/forks/haiyinlong/snail?style=social" alt="GitHub Forks">
  </p>
</p>

# 🐌 Snail - Lightweight Spring Boot Rapid Development Scaffold

> **Snail** is a modern microservices rapid development framework based on Spring Boot 3,
> providing out-of-the-box core capabilities such as authentication, authorization, gateway, resource services, helping enterprises quickly build secure and scalable cloud-native applications.

🚀 **Out-of-the-box | Secure & Reliable | Easy to Extend | Integrated Frontend & Backend**

---

## 🌟 Features

- ✅ **Based on Latest Tech Stack**: `Spring Boot 3.5.5` + `Spring Cloud 2025.0.0` +
  `Spring Cloud Alibaba 2023.0.3.3`
- 🔐 **OAuth2 Authentication & Authorization**: Integrated `Spring Security` + `JWT`, supports unified identity authentication and fine-grained permission control
- 🌐 **Microservices Architecture**: Modular decomposition, includes authentication, authorization, gateway, resource services, supports independent deployment and horizontal scaling
- ⚡ **High-performance Gateway**: Implements routing, rate limiting, circuit breaking, and authentication based on `Spring Cloud Gateway`
- 🧩 **Cloud-native Support**: Compatible with Nacos, Sentinel, Seata, supports service discovery, configuration center, distributed transactions
- 🎨 **Modern Admin Backend**: Built on [shadcn-vue/ui](https://www.shadcn-vue.com/)
  with a simple, responsive admin interface
- 📚 **Documentation Improvement**: Covers architecture design, deployment guide, API documentation, and secondary development instructions

---

## 🛠 Technology Stack

| Category       | Technology                                                          |
|-----------|-------------------------------------------------------------------|
| **Backend Framework** | Spring Boot 3.5.5, Spring Cloud 2025.0.0, Spring Security, OAuth2 |
| **Microservices Governance** | Nacos (Registration Center & Configuration Center),                 |
| **Gateway**   | Spring Cloud Gateway                                              |
| **Database**  | MySQL 8                                                           |
| **Frontend Framework** | Vue 3 + Vite + TypeScript + shadcn/ui                             |
| **Build Tools** | Maven, Docker, Docker Compose                                     |
| **Monitoring** | Spring Boot Actuator, Prometheus (optional), Grafana (optional)                 |

---

## 🏗 Project Structure

```bash
snail/
├── authentication/           # Authentication service (OAuth2 authorization server)
├── authorization/          # Authorization service (permission management, roles, menus)
├── gateway/               # API gateway (routing, authentication, rate limiting)
├── resource/              # Resource service (business API example)
├── snail-vue-app/          # Backend management interface (Vue3 + shadcn/ui)
└── pom.xml                      # Maven parent project
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---