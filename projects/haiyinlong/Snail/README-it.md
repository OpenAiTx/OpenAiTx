
<div align="right">
  <details open>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haiyinlong&project=Snail&lang=zh-CN">简体中文</a>
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
Spring Boot 3 microservizi scaffolding, autenticazione Spring Cloud OAuth2, shadcn ui template backend, 
Java framework di sviluppo rapido, Spring Boot Admin frontend-backend separati, Nacos centro di configurazione, 
Gestione permessi microservizi, login JWT, Spring Security 6, sistema di gestione Vue3 
-->
<p align="center">
  <h3 align="center">Snail - Scaffolding per lo sviluppo rapido di microservizi enterprise</h3>
  <p align="center">
    🚀 Basato su Spring Boot 3 + Spring Cloud + OAuth2 + shadcn/ui
  </p>
  <p align="center">
    <a href="#-inizio-rapido">Inizio rapido</a> •
    <a href="#-documentazione">Documentazione</a> •
    <a href="#-contributi">Contributi</a> •
  </p>
  <p align="center">
    <img src="https://img.shields.io/github/stars/haiyinlong/snail?style=social" alt="GitHub Stars">
    <img src="https://img.shields.io/github/forks/haiyinlong/snail?style=social" alt="GitHub Forks">
  </p>
</p>

# 🐌 Snail - Scaffold leggero per lo sviluppo rapido con Spring Boot

> **Snail** è un moderno framework di sviluppo rapido per microservizi basato su Spring Boot 3,
> che offre funzionalità pronte all’uso per autenticazione, autorizzazione, gateway, servizi di risorse e altro, aiutando le aziende a creare rapidamente applicazioni cloud native sicure e scalabili.

🚀 **Pronto all’uso | Sicuro e affidabile | Facile da estendere | Fullstack**

---

## 🌟 Caratteristiche

- ✅ **Basato sullo stack tecnologico più recente**: `Spring Boot 3.5.5` + `Spring Cloud 2025.0.0` +
  `Spring Cloud Alibaba 2023.0.3.3`
- 🔐 **Autenticazione e autorizzazione OAuth2**: Integrato con `Spring Security` + `JWT`, supporta autenticazione centralizzata e controllo granulare dei permessi
- 🌐 **Architettura a microservizi**: Suddivisione modulare con autenticazione, autorizzazione, gateway, servizi di risorse, supporta distribuzione indipendente ed espansione orizzontale
- ⚡ **Gateway ad alte prestazioni**: Basato su `Spring Cloud Gateway` per routing, rate limit, circuit breaking e autorizzazione
- 🧩 **Supporto cloud native**: Compatibile con Nacos, Sentinel, Seata, supporta service discovery, configuration center, transazioni distribuite
- 🎨 **Pannello di amministrazione moderno**: Interfaccia amministrativa semplice e reattiva realizzata con [shadcn-vue/ui](https://www.shadcn-vue.com/)
- 📚 **Documentazione completa**: Include design architetturale, guida al deploy, documentazione API e istruzioni per lo sviluppo avanzato

---

## 🛠 Stack tecnologico

| Categoria   | Tecnologia                                                          |

|-----------|-------------------------------------------------------------------|
| **Framework backend**  | Spring Boot 3.5.5, Spring Cloud 2025.0.0, Spring Security, OAuth2 |
| **Gestione dei microservizi** | Nacos (Centro di registrazione & Centro di configurazione),                     |
| **Gateway**    | Spring Cloud Gateway                                              |
| **Database**   | MySQL 8                                                           |
| **Framework frontend**  | Vue 3 + Vite + TypeScript + shadcn/ui                             |
| **Strumenti di build**  | Maven, Docker, Docker Compose                                     |
| **Monitoraggio**    | Spring Boot Actuator, Prometheus (opzionale), Grafana (opzionale)         |

---

## 🏗 Struttura del progetto

```bash
snail/
├── authentication/           # Servizio di autenticazione (Server di autorizzazione OAuth2)
├── authorization/          # Servizio di autorizzazione (Gestione permessi, ruoli, menu)
├── gateway/               # API Gateway (Instradamento, autenticazione, limitazione del traffico)
├── resource/              # Servizio risorse (Esempio di API aziendali)
├── snail-vue-app/          # Interfaccia di gestione backend (Vue3 + shadcn/ui)
└── pom.xml                      # Progetto padre Maven


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---