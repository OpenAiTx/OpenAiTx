<!-- 
Spring Boot 3 microservices scaffold, Spring Cloud OAuth2 authentication, shadcn ui backend template, 
Java rapid development framework, Spring Boot Admin frontend-backend separation, Nacos configuration center, 
microservices permission management, JWT login, Spring Security 6, Vue3 management system 
-->
<p align="center">
  <h3 align="center">Snail - Scaffold de développement rapide de microservices d'entreprise</h3>
  <p align="center">
    🚀 Basé sur Spring Boot 3 + Spring Cloud + OAuth2 + shadcn/ui
  </p>
  <p align="center">
    <a href="#-démarrage-rapide">Démarrage rapide</a> •
    <a href="#-documentation">Documentation</a> •
    <a href="#-contribution">Contribution</a> •
  </p>
  <p align="center">
    <img src="https://img.shields.io/github/stars/haiyinlong/snail?style=social" alt="GitHub Stars">
    <img src="https://img.shields.io/github/forks/haiyinlong/snail?style=social" alt="GitHub Forks">
  </p>
</p>

# 🐌 Snail - Scaffold léger de développement rapide Spring Boot

> **Snail** est un cadre moderne de développement rapide de microservices
> basé sur Spring Boot 3, offrant des capacités clés prêtes à l'emploi telles que l'authentification, l'autorisation, la passerelle, le service de ressources, aidant les entreprises à construire rapidement des applications cloud natives sécurisées et extensibles.

🚀 **Prêt à l'emploi | Sécurisé et fiable | Facile à étendre | Frontend et backend intégrés**

---

## 🌟 Caractéristiques

- ✅ **Basé sur les dernières technologies** : `Spring Boot 3.5.5` + `Spring Cloud 2025.0.0` +
  `Spring Cloud Alibaba 2023.0.3.3`
- 🔐 **Authentification et autorisation OAuth2** : Intégration de `Spring Security` + `JWT`, prise en charge de l'authentification unifiée et du contrôle fin des permissions
- 🌐 **Architecture microservices** : Modularisation avec authentification, autorisation, passerelle, services de ressources, prise en charge du déploiement indépendant et de l'extension horizontale
- ⚡ **Passerelle haute performance** : Mise en œuvre des routes, limitation de débit, circuit breaker, authentification via `Spring Cloud Gateway`
- 🧩 **Support cloud native** : Compatible avec Nacos, Sentinel, Seata, prise en charge de la découverte de services, du centre de configuration, des transactions distribuées
- 🎨 **Interface d'administration moderne** : Interface d'administration simple et réactive construite avec [shadcn-vue/ui](https://www.shadcn-vue.com/)

- 📚 **Documentation complète** : Couvre la conception de l'architecture, le guide de déploiement, la documentation API et les instructions de développement secondaire

---

## 🛠 Pile technologique

| Catégorie       | Technologie                                                      |
|--------------|----------------------------------------------------------------|
| **Framework back-end** | Spring Boot 3.5.5, Spring Cloud 2025.0.0, Spring Security, OAuth2 |
| **Gestion microservices** | Nacos (centre d’enregistrement & centre de configuration),         |
| **Passerelle**    | Spring Cloud Gateway                                            |
| **Base de données** | MySQL 8                                                       |
| **Framework front-end** | Vue 3 + Vite + TypeScript + shadcn/ui                         |
| **Outils de build** | Maven, Docker, Docker Compose                                  |
| **Surveillance**   | Spring Boot Actuator, Prometheus (optionnel), Grafana (optionnel) |

---

## 🏗 Structure du projet

```bash
snail/
├── authentication/           # Service d'authentification (serveur d'autorisation OAuth2)
├── authorization/          # Service d'autorisation (gestion des permissions, rôles, menus)
├── gateway/               # Passerelle API (routage, authentification, limitation de débit)
├── resource/              # Service de ressources (exemple d'API métier)
├── snail-vue-app/          # Interface d'administration (Vue3 + shadcn/ui)
└── pom.xml                      # Projet parent Maven
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---