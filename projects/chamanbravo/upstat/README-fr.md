<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# Upstat

> outil simple et facile à utiliser pour la surveillance de statut auto-hébergé

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 Démo en direct

Essayez-le.

Serveur de démo (Emplacement : Singapour) : [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

Nom d'utilisateur : `demo`
Mot de passe : `demodemo`

## ⭐ Fonctionnalités

Il faut encore plus de fonctionnalités mais pour l'instant...

- Surveillance du temps de disponibilité pour HTTP(s)
- Graphique de statut et de latence
- Notifications via Discord
- Intervalles de 60 secondes
- Interface utilisateur/expérience utilisateur élégante, réactive et rapide
- Pages de statut multiples
- Association des pages de statut à des domaines spécifiques
- Graphique de ping
- Informations sur les certificats
- PWA
- Support des bases de données Sqlite et Postgres

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-24

---