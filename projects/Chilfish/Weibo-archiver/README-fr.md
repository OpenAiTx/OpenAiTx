<div align="center">
  <img
    alt="logo"
    width="100"
    src="https://p.chilfish.top/weibo/icon.webp"
  />

  <div>
    <a href="https://deepwiki.com/Chilfish/Weibo-archiver"><img src="https://deepwiki.com/badge.svg" alt="Ask DeepWiki"></a>
    <img src="https://wakatime.com/badge/user/0842a71f-c026-4b09-8aa0-f8398b4c3423/project/3416f224-f0dc-4b08-805c-af30dbd396b2.svg" alt="wakatime">
    <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/chilfish/weibo-archiver">
    <img alt="GitHub Downloads" src="https://img.shields.io/github/downloads/chilfish/weibo-archiver/total">
    <img alt="beta build" src="https://github.com/Chilfish/Weibo-archiver/actions/workflows/beta-build.yml/badge.svg">
  </div>
</div>

## Weibo-archiver

Archivez vos souvenirs Sina Weibo, préparez-vous avant que votre compte ne soit complètement supprimé 😭 Site officiel : [weibo-archiver.chilfish.top](https://weibo-archiver.chilfish.top)

![Couverture](https://p.chilfish.top/weibo/cover.webp)

### Mode d'emploi

Voir les instructions détaillées dans la [documentation en ligne]

> Les anciennes versions sont disponibles sur la [branche v0.5](https://github.com/Chilfish/Weibo-archiver/tree/v0.5) ou sur https://weibo.chilfish.top/, voir la section [Documentation : migration depuis les anciennes versions](https://weibo-archiver.chilfish.top/docs/intro.html#从旧版本迁移)

### Pour les développeurs

Le projet utilise une structure monorepo, gérée avec pnpm, il faut donc d'abord installer pnpm : `npm i -g pnpm`

Dans le répertoire packages :

- [/core](packages/core/) contient les fonctions utilitaires et le cœur du traitement des données

Dans le répertoire apps, les applications finales

- [/web](apps/web-v2/) est la page web pour consulter les données Weibo, actuellement hébergée sur [vercel]
- [/monkey](apps/monkey/) sert à empaqueter le script Tampermonkey
- [/cli](apps/cli) Version en ligne de commande Nodejs

> Avant de déployer directement sur vercel, il faut d'abord aller dans les paramètres du projet vercel et définir le répertoire racine (`Root Directory`) sur `apps/web-v2` pour que le projet soit correctement reconnu et construit

Dans le répertoire server se trouve un serveur local écrit en langage go, utilisé pour télécharger des images et parcourir les données Weibo, pour les instructions d'utilisation voir [Instructions d'utilisation du serveur local](https://raw.githubusercontent.com/Chilfish/Weibo-archiver/main/server/README.md)

### Remerciements

- Merci à [speechless] pour l'idée de base
- [vite-plugin-monkey] a fourni l'outil pour empaqueter en script Tampermonkey
- Shadcn/ui pour la belle bibliothèque de composants UI
- [vercel] pour la plateforme cloud en ligne 😚
- Github Copilot & v0.dev 😇

### Sponsoring

Si ce projet vous aide, vous pouvez envisager de me sponsoriser 😇 cela me donnera plus de motivation pour maintenir ce projet : [Adresse de sponsoring]

[releases]: https://raw.githubusercontent.com/Chilfish/Weibo-archiver/monkey/weibo-archiver.user.js
[scripts.zip]: https://github.com/Chilfish/Weibo-archiver/raw/monkey/scripts.zip
[speechless]: https://github.com/meterscao/Speechless
[naive-ui]: https://www.naiveui.com/zh-CN/os-theme
[#1]: https://github.com/Chilfish/Weibo-archiver/issues/1
[#5]: https://github.com/Chilfish/Weibo-archiver/issues/5
[Node.js 官网]: https://nodejs.org/en/download
[vite-plugin-monkey]: https://github.com/lisonge/vite-plugin-monkey
[镜像地址]: https://p.chilfish.top/weibo-archiver.user.js
[项目的 Todo]: https://github.com/Chilfish/Weibo-archiver/issues/7
[赞助地址]: https://chilfish.top/sponsors
[vercel]: https://vercel.com
[使用教程]: https://docs.qq.com/doc/DTWttbXlMUGxZZnZq
[actions]: https://github.com/Chilfish/Weibo-archiver/actions/workflows/beta-build.yml?query=branch:main+event:push+is:success
[微博网页版]: https://weibo.com
[在线文档]: https://weibo-archiver.chilfish.top/docs/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---