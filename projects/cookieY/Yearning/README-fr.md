<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

 Une plateforme robuste, déployée localement, conçue pour une détection SQL fluide et une audit des requêtes, spécialement adaptée aux DBA et aux développeurs. Axée sur la confidentialité et l'efficacité, elle offre un environnement intuitif et sécurisé pour l'audit MYSQL.

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Prise en charge de la plateforme](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![Langage principal GitHub](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Téléchargements](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ Fonctionnalités

- **Assistant IA** : Notre assistant IA offre des suggestions d'optimisation SQL en temps réel, améliorant ainsi les performances SQL. Il prend également en charge la conversion texte-vers-SQL, permettant aux utilisateurs d'entrer du langage naturel et de recevoir des instructions SQL optimisées.
  
- **Audit SQL** : Créez des tickets d'audit SQL avec des flux de travail d'approbation et des vérifications automatiques de la syntaxe. Validez les instructions SQL pour leur exactitude, sécurité et conformité. Les instructions de rollback sont générées automatiquement pour les opérations DDL/DML, avec un historique complet pour la traçabilité.

- **Audit des requêtes** : Auditez les requêtes utilisateur, restreignez les sources de données et bases de données, et anonymisez les champs sensibles. Les enregistrements de requêtes sont sauvegardés pour référence future.

- **Règles de vérification** : Notre vérificateur de syntaxe automatique prend en charge un large éventail de règles de vérification, adaptées à la plupart des scénarios de vérification automatique.

- **Confidentialité renforcée** : Yearning est une solution open source déployable localement qui garantit la sécurité de votre base de données et de vos instructions SQL. Elle inclut des mécanismes de chiffrement pour protéger les données sensibles, assurant leur sécurité même en cas d'accès non autorisé.

- **RBAC (Contrôle d'accès basé sur les rôles)** : Créez et gérez des rôles avec des permissions spécifiques, limitant l'accès aux ordres de requête, fonctions d'audit et autres opérations sensibles selon les rôles des utilisateurs.

> \[!TIP]
> Pour plus d'informations détaillées, consultez notre [Guide Yearning](https://next.yearning.io)


## ⚙️ Installation

Téléchargez la [dernière version](https://github.com/cookieY/Yearning/releases/latest) et extrayez-la. Assurez-vous d'avoir configuré `./config.toml` avant de poursuivre.

### Installation manuelle

```bash
## Initialiser la base de données
./Yearning install

## Démarrer Yearning
./Yearning run

## Aide
./Yearning --help
```

### 🚀 Déploiement avec Docker
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## Initialiser la base de données
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Démarrer Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 Assistance IA

Notre Assistant IA exploite un grand modèle linguistique pour fournir des suggestions d'optimisation SQL et la conversion texte-vers-SQL. Que vous utilisiez des prompts par défaut ou personnalisés, l’Assistant IA améliore les performances SQL en optimisant les instructions et en convertissant les entrées en langage naturel en requêtes SQL.

![Texte vers SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 Vérificateur SQL automatique

Le vérificateur SQL automatique évalue les instructions SQL selon des règles et une syntaxe prédéfinies. Il garantit que les instructions respectent des normes de codage spécifiques, les bonnes pratiques et les exigences de sécurité, offrant ainsi une couche de validation robuste.

![Audit SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 Surlignage syntaxique SQL et auto-complétion

Améliorez votre efficacité d’écriture de requêtes grâce au surlignage syntaxique SQL et à l’auto-complétion. Ces fonctionnalités aident les utilisateurs à distinguer visuellement les différents composants d’une requête SQL, tels que les mots-clés, noms de tables, noms de colonnes et opérateurs, facilitant ainsi la lecture et la compréhension de la structure de la requête.

![Requête SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ Enregistrement des ordres/requêtes

Notre plateforme prend en charge l’audit des instructions d’ordre et de requête utilisateur. Cette fonctionnalité vous permet de suivre et d’enregistrer toutes les opérations de requête, y compris les sources de données, bases de données et la gestion des champs sensibles, assurant la conformité aux réglementations et la traçabilité de l’historique des requêtes.

![Enregistrement des ordres/requêtes](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

En se concentrant sur ces fonctionnalités clés, Yearning améliore l’expérience utilisateur, optimise les performances SQL et garantit une conformité et une traçabilité robustes dans les opérations de base de données.

## 🛠️ Outils recommandés

- [Spug - Plateforme open source légère d’automatisation des opérations](https://github.com/openspug/spug)

## ☎️ Contact

Pour toute demande, veuillez nous écrire à : henry@yearning.io
## 📋 Licence

Yearning est sous licence AGPL. Voir [LICENSE](LICENSE) pour plus de détails.

2024 © Henry Yee

---

Avec Yearning, bénéficiez d'une approche rationalisée, sécurisée et efficace de l'audit et de l'optimisation SQL.


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---