
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# Upstat

> outil de surveillance de statut auto-hébergé simple et facile à utiliser

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 Démonstration en direct

Essayez-le.

Serveur de démonstration (Emplacement : Singapour) : [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

Nom d'utilisateur : `demo`
Mot de passe : `demodemo`

## ⭐ Fonctionnalités

Il nécessite plus de fonctionnalités mais pour l’instant...

- Surveillance de la disponibilité pour HTTP(s)
- Diagramme de statut et de latence
- Notifications via Discord
- Intervalles de 60 secondes
- Interface utilisateur/expérience élégante, réactive et rapide
- Pages de statut multiples
- Associer des pages de statut à des domaines spécifiques
- Diagramme de ping
- Infos sur le certificat
- PWA
- Prise en charge des bases de données Sqlite & Postgres

Et des dizaines de petites fonctionnalités à ajouter.

## 🔧 Comment installer

### 🐳 Docker

Pour Sqlite

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```
Pour Postgres


```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

Upstat fonctionne maintenant sur http://localhost:3000

> [!IMPORTANT]
> Assurez-vous de modifier les valeurs de l'environnement avant le déploiement.

### 💪🏻 Non-Docker

Prérequis :

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (Optionnel)

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## Stack technologique

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 Contribution

Je vous invite à contribuer ! Les contributions sont ce qui fait de la communauté open source un endroit incroyable pour apprendre, inspirer et créer. Toutes les contributions que vous apportez sont **grandement appréciées**.

Si vous avez une suggestion pour améliorer ce projet, veuillez forker le dépôt, faire vos modifications et créer une pull request. Vous pouvez également simplement ouvrir un ticket avec le tag "enhancement".
N'oubliez pas de donner une étoile au projet ! Merci encore !

1. Forkez le projet
2. Créez votre branche de fonctionnalité (`git checkout -b feature/AmazingFeature`)
3. Commitez vos modifications (`git commit -m 'Add some AmazingFeature'`)
4. Poussez la branche (`git push origin feature/AmazingFeature`)
5. Ouvrez une Pull Request

## Contributeurs

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 Licence

Ce projet est sous licence [MIT License](https://opensource.org/license/mit/).

## 🖼 Plus de captures d’écran

Créer un moniteur

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

Page Moniteur

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---