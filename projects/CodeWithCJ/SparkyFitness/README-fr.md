<div align="right">
  <details>
    <summary >🌐 Langue</summary>
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

# SparkyFitness

Une alternative auto-hébergée et axée sur la confidentialité à MyFitnessPal. Suivez votre nutrition, vos exercices, vos métriques corporelles et vos données de santé tout en gardant un contrôle total sur vos données.

![Capture d’écran](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness est une plateforme de suivi fitness auto-hébergée composée de :

- Un serveur backend (API + stockage des données)
- Une interface web
- Applications mobiles natives pour iOS et Android

Elle stocke et gère les données de santé sur une infrastructure que vous contrôlez, sans dépendre de services tiers.

## Fonctionnalités principales

- Suivi de la nutrition, de l'exercice, de l'hydratation, du sommeil, du jeûne, de l'humeur et des mesures corporelles
- Définition d’objectifs et bilans quotidiens
- Graphiques interactifs et rapports à long terme
- Profils utilisateurs multiples et accès familial
- Thèmes clair et sombre
- OIDC, TOTP, Passkey, MFA etc.

## Intégrations Santé & Appareils

SparkyFitness peut synchroniser les données de plusieurs plateformes de santé et de fitness :

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (partiellement testé)
- **Hevy** (non testé)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (partiellement testé)

Les intégrations synchronisent automatiquement les données d’activité telles que les pas, les entraînements et le sommeil, ainsi que les mesures de santé comme le poids et les mesures corporelles, vers votre serveur SparkyFitness.

## Fonctionnalités IA optionnelles (Bêta)

SparkyAI propose une interface conversationnelle pour enregistrer des données et consulter vos progrès.

- Enregistrez alimentation, exercice, statistiques corporelles et pas via chat
- Téléchargez des photos de repas pour un journal alimentaire automatique
- Conserve l’historique des conversations pour les suivis

Remarque : Les fonctionnalités d’IA sont actuellement en version bêta.

## Démarrage rapide (Serveur)

Lancez un serveur SparkyFitness en quelques minutes avec Docker Compose.

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```


## 🎥 Tutoriel vidéo

[![Regarder la vidéo](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

Tutoriel rapide de 2 minutes montrant comment installer SparkyFitness (suivi de fitness auto-hébergé).


## Documentation

Pour des guides d'installation complets, des options de configuration et la documentation de développement, veuillez visiter notre [Site de Documentation](https://codewithcj.github.io/SparkyFitness/).

### Liens rapides

- **[Guide d'installation](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - Déploiement et configurations
- **[Aperçu des fonctionnalités](https://codewithcj.github.io/SparkyFitness/features)** - Documentation complète des fonctionnalités
- **[Flux de travail de développement](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Guide du développeur et processus de contribution
- **[Infos sur l'app iOS](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** et **[Infos sur l'app Android](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### Besoin d'aide ?

- Publiez dans les issues/discussions Github.
- Pour une réponse plus rapide et obtenir l'aide d'autres membres de la communauté **[Rejoignez notre Discord](https://discord.gg/vcnMT5cPEA)**

## Historique des étoiles

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Graphique de l'historique des étoiles" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Traductions

**[Traductions Weblate](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">
<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Statut de la traduction" />
</a>

## Activité du dépôt

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Image d'analyse Repobeats")

## Contributeurs

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ Problèmes connus / Fonctionnalités en bêta ⚠️

SparkyFitness est en cours de développement actif.
Des changements majeurs peuvent survenir entre les versions.

- La mise à jour automatique des conteneurs n'est pas recommandée
- Lisez toujours les notes de version avant de faire une mise à niveau

Les fonctionnalités suivantes sont actuellement en bêta et n'ont peut-être pas été entièrement testées. Attendez-vous à des bugs potentiels ou à une fonctionnalité incomplète :

- Chatbot IA
- Accès Famille & Amis
- Documentation de l’API


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---