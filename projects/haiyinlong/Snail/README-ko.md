<!-- 
Spring Boot 3 마이크로서비스 스캐폴딩, Spring Cloud OAuth2 인증, shadcn ui 백엔드 템플릿, 
Java 빠른 개발 프레임워크, Spring Boot Admin 프론트엔드 및 백엔드 분리, Nacos 구성 센터, 
마이크로서비스 권한 관리, JWT 로그인, Spring Security 6, Vue3 관리 시스템 
-->
<p align="center">
  <h3 align="center">Snail - 엔터프라이즈급 마이크로서비스 빠른 개발 스캐폴딩</h3>
  <p align="center">
    🚀 Spring Boot 3 + Spring Cloud + OAuth2 + shadcn/ui 기반
  </p>
  <p align="center">
    <a href="#-빠른 시작">빠른 시작</a> •
    <a href="#-문서">문서</a> •
    <a href="#-기여">기여</a> •
  </p>
  <p align="center">
    <img src="https://img.shields.io/github/stars/haiyinlong/snail?style=social" alt="GitHub Stars">
    <img src="https://img.shields.io/github/forks/haiyinlong/snail?style=social" alt="GitHub Forks">
  </p>
</p>

# 🐌 Snail - 경량화 Spring Boot 빠른 개발 스캐폴딩

> **Snail** 은 Spring Boot 3 기반의
> 현대적인 마이크로서비스 빠른 개발 프레임워크로, 즉시 사용 가능한 인증, 권한 부여, 게이트웨이, 리소스 서비스 등 핵심 기능을 제공하여 기업이 안전하고 확장 가능한 클라우드 네이티브 애플리케이션을 빠르게 구축할 수 있도록 지원합니다.

🚀 **즉시 사용 가능 | 안전하고 신뢰성 있음 | 확장 용이 | 프론트엔드 및 백엔드 통합**

---

## 🌟 특징

- ✅ **최신 기술 스택 기반**: `Spring Boot 3.5.5` + `Spring Cloud 2025.0.0` +
  `Spring Cloud Alibaba 2023.0.3.3`
- 🔐 **OAuth2 인증 및 권한 부여**: `Spring Security` + `JWT` 통합, 통합 신원 인증 및 세분화된 권한 제어 지원
- 🌐 **마이크로서비스 아키텍처**: 모듈화 분리, 인증, 권한 부여, 게이트웨이, 리소스 서비스 포함, 독립적 배포 및 수평 확장 지원
- ⚡ **고성능 게이트웨이**: `Spring Cloud Gateway` 기반 라우팅, 속도 제한, 회로 차단, 인증 구현
- 🧩 **클라우드 네이티브 지원**: Nacos, Sentinel, Seata 호환, 서비스 발견, 구성 센터, 분산 트랜잭션 지원
- 🎨 **현대적 관리 백엔드**: [shadcn-vue/ui](https://www.shadcn-vue.com/) 기반의 간결하고 반응형 관리 인터페이스 구축

- 📚 **문서 완성**：아키텍처 설계, 배포 가이드, API 문서 및 2차 개발 설명 포함

---

## 🛠 기술 스택

| 카테고리       | 기술                                                                |
|-----------|-------------------------------------------------------------------|
| **백엔드 프레임워크** | Spring Boot 3.5.5, Spring Cloud 2025.0.0, Spring Security, OAuth2 |
| **마이크로서비스 관리** | Nacos（등록 센터 & 구성 센터）,                                               |
| **게이트웨이**    | Spring Cloud Gateway                                              |
| **데이터베이스**   | MySQL 8                                                           |
| **프론트엔드 프레임워크** | Vue 3 + Vite + TypeScript + shadcn/ui                             |
| **빌드 도구**    | Maven, Docker, Docker Compose                                     |
| **모니터링**    | Spring Boot Actuator, Prometheus（선택）, Grafana（선택）                 |

---

## 🏗 프로젝트 구조

```bash
snail/
├── authentication/           # 인증 서비스(OAuth2 권한 서버)
├── authorization/          # 권한 서비스(권한 관리, 역할, 메뉴)
├── gateway/               # API 게이트웨이(라우팅, 인증, 속도 제한)
├── resource/              # 리소스 서비스(비즈니스 API 예제)
├── snail-vue-app/          # 백엔드 관리 인터페이스(Vue3 + shadcn/ui)
└── pom.xml                      # Maven 부모 프로젝트
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---