<!-- 
Spring Boot 3 微服务脚手架, Spring Cloud OAuth2 认证, shadcn ui 后台模板, 
Java 快速开发框架, Spring Boot Admin 前后端分离, Nacos 配置中心, 
微服务权限管理, JWT 登录, Spring Security 6, Vue3 管理系统 
-->
<p align="center">
  <h3 align="center">Snail - 企业级微服务快速开发脚手架</h3>
  <p align="center">
    🚀 基于 Spring Boot 3 + Spring Cloud + OAuth2 + shadcn/ui
  </p>
  <p align="center">
    <a href="#-快速开始">快速开始</a> •
    <a href="#-文档">文档</a> •
    <a href="#-贡献">贡献</a> •
  </p>
  <p align="center">
    <img src="https://img.shields.io/github/stars/haiyinlong/snail?style=social" alt="GitHub Stars">
    <img src="https://img.shields.io/github/forks/haiyinlong/snail?style=social" alt="GitHub Forks">
  </p>
</p>

# 🐌 Snail - 轻量级 Spring Boot 快速开发脚手架

> **Snail** 是一个基于 Spring Boot 3
> 的现代化微服务快速开发框架，提供开箱即用的认证、授权、网关、资源服务等核心能力，助力企业快速构建安全、可扩展的云原生应用。

🚀 **开箱即用 | 安全可靠 | 易于扩展 | 前后端一体化**

---

## 🌟 特性

- ✅ **基于最新技术栈**：`Spring Boot 3.5.5` + `Spring Cloud 2025.0.0` +
  `Spring Cloud Alibaba 2023.0.3.3`
- 🔐 **OAuth2 认证授权**：集成 `Spring Security` + `JWT`，支持统一身份认证与细粒度权限控制
- 🌐 **微服务架构**：模块化拆分，包含认证、授权、网关、资源服务，支持独立部署与横向扩展
- ⚡ **高性能网关**：基于 `Spring Cloud Gateway` 实现路由、限流、熔断、鉴权
- 🧩 **云原生支持**：兼容 Nacos、Sentinel、Seata，支持服务发现、配置中心、分布式事务
- 🎨 **现代化管理后台**：基于 [shadcn-vue/ui](https://www.shadcn-vue.com/)
  构建的简洁、响应式后台管理界面
- 📚 **完善文档**：涵盖架构设计、部署指南、API 文档与二次开发说明

---

## 🛠 技术栈

| 类别        | 技术                                                                |
|-----------|-------------------------------------------------------------------|
| **后端框架**  | Spring Boot 3.5.5, Spring Cloud 2025.0.0, Spring Security, OAuth2 |
| **微服务治理** | Nacos（注册中心 & 配置中心）,                                               |
| **网关**    | Spring Cloud Gateway                                              |
| **数据库**   | MySQL 8                                                           |
| **前端框架**  | Vue 3 + Vite + TypeScript + shadcn/ui                             |
| **构建工具**  | Maven, Docker, Docker Compose                                     |
| **监控**    | Spring Boot Actuator, Prometheus（可选）, Grafana（可选）                 |

---

## 🏗 项目结构

```bash
snail/
├── authentication/           # 认证服务（OAuth2 授权服务器）
├── authorization/          # 授权服务（权限管理、角色、菜单）
├── gateway/               # API 网关（路由、鉴权、限流）
├── resource/              # 资源服务（业务 API 示例）
├── snail-vue-app/          # 后台管理界面（Vue3 + shadcn/ui）
└── pom.xml                      # Maven 父工程
