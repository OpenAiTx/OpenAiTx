<!-- 
Spring Boot 3 microservicios scaffold, Spring Cloud OAuth2 autenticación, plantilla de administración shadcn ui, 
Marco de desarrollo rápido Java, Spring Boot Admin separación frontend-backend, Nacos centro de configuración, 
Gestión de permisos de microservicios, inicio de sesión JWT, Spring Security 6, sistema de administración Vue3 
-->
<p align="center">
  <h3 align="center">Snail - Scaffold rápido de desarrollo de microservicios a nivel empresarial</h3>
  <p align="center">
    🚀 Basado en Spring Boot 3 + Spring Cloud + OAuth2 + shadcn/ui
  </p>
  <p align="center">
    <a href="#-快速开始">Inicio rápido</a> •
    <a href="#-文档">Documentación</a> •
    <a href="#-贡献">Contribuciones</a> •
  </p>
  <p align="center">
    <img src="https://img.shields.io/github/stars/haiyinlong/snail?style=social" alt="Estrellas GitHub">
    <img src="https://img.shields.io/github/forks/haiyinlong/snail?style=social" alt="Bifurcaciones GitHub">
  </p>
</p>

# 🐌 Snail - Scaffold ligero para desarrollo rápido con Spring Boot

> **Snail** es un marco moderno para desarrollo rápido de microservicios basado en Spring Boot 3,
> que ofrece capacidades centrales listas para usar como autenticación, autorización, gateway, servicios de recursos, 
> ayudando a las empresas a construir rápidamente aplicaciones cloud-native seguras y escalables.

🚀 **Listo para usar | Seguro y confiable | Fácil de extender | Integración frontend-backend**

---

## 🌟 Características

- ✅ **Basado en la pila tecnológica más reciente**: `Spring Boot 3.5.5` + `Spring Cloud 2025.0.0` +
  `Spring Cloud Alibaba 2023.0.3.3`
- 🔐 **Autenticación y autorización OAuth2**: Integración de `Spring Security` + `JWT`, soporta autenticación unificada y control de permisos detallado
- 🌐 **Arquitectura de microservicios**: Modular, incluye autenticación, autorización, gateway, servicios de recursos, soporta despliegue independiente y escalabilidad horizontal
- ⚡ **Gateway de alto rendimiento**: Implementa enrutamiento, limitación, circuit breaker, y autorización basado en `Spring Cloud Gateway`
- 🧩 **Soporte cloud-native**: Compatible con Nacos, Sentinel, Seata, soporte para descubrimiento de servicios, centro de configuración y transacciones distribuidas
- 🎨 **Panel administrativo moderno**: Interfaz administrativa limpia y responsiva construida con [shadcn-vue/ui](https://www.shadcn-vue.com/)
- 📚 **Documentación completa**: Cubre diseño de arquitectura, guía de despliegue, documentación API y explicación para desarrollo secundario

---

## 🛠 Pila tecnológica

| Categoría       | Tecnología                                                          |
|-----------------|--------------------------------------------------------------------|
| **Framework backend** | Spring Boot 3.5.5, Spring Cloud 2025.0.0, Spring Security, OAuth2 |
| **Gobernanza microservicios** | Nacos (registro y configuración)                                 |
| **Gateway**     | Spring Cloud Gateway                                               |
| **Base de datos** | MySQL 8                                                           |
| **Framework frontend** | Vue 3 + Vite + TypeScript + shadcn/ui                             |
| **Herramientas de construcción** | Maven, Docker, Docker Compose                                |
| **Monitoreo**   | Spring Boot Actuator, Prometheus (opcional), Grafana (opcional)    |

---

## 🏗 Estructura del proyecto

```bash
snail/
├── authentication/           # Servicio de autenticación (Servidor de autorización OAuth2)
├── authorization/          # Servicio de autorización (Gestión de permisos, roles, menús)
├── gateway/               # Gateway API (Enrutamiento, autenticación, limitación de tasa)
├── resource/              # Servicio de recursos (Ejemplo de API de negocio)
├── snail-vue-app/          # Interfaz de administración (Vue3 + shadcn/ui)
└── pom.xml                      # Proyecto padre Maven
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---