# BoostServerTech Chat

Ce dépôt contient le code d'une application de chat écrite en C++.

Lisez la documentation complète [ici](https://anarthal.github.io/servertech-chat/).

| Build                                                                                              | Docs                                                                                                                                            | Serveur en ligne               |
| -------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------ |
| ![Build Status](https://github.com/anarthal/servertech-chat/actions/workflows/build.yml/badge.svg) | [![Build Status](https://github.com/anarthal/servertech-chat/actions/workflows/doc.yml/badge.svg)](https://anarthal.github.io/servertech-chat/) | [Essayez-le !](http://16.171.43.27/) |

## Le projet BoostServerTech

Ceci est le premier des [projets BoostServerTech](https://docs.google.com/document/d/1ZQrod1crs8EaNLLqSYIRMacwR3Rv0hC5l-gfL-jOp2M),
une collection de projets qui démontrent comment C++ et Boost peuvent être utilisés pour du code côté serveur.

## Architecture

Le serveur est basé sur Boost.Beast, asynchrone (coroutines C++20)
et mono-thread. Il nécessite C++20 pour être compilé. Il utilise Redis et MySQL pour
la persistance.

Le client est web-based et utilise Next.js. Il communique avec le serveur
via websockets.

Vous pouvez en lire davantage sur l'architecture
[dans cette section de la documentation](https://anarthal.github.io/servertech-chat/01-architecture.html).

## Développement local

Vous pouvez rapidement lancer l'application de chat en local en utilisant Docker Compose,
en exécutant dans un terminal à la racine du dépôt :

```
docker compose up --build
```

Ou vous pouvez apprendre comment configurer un environnement de développement traditionnel
[ici](https://anarthal.github.io/servertech-chat/02-local-dev.html).

## Mise en ligne en quelques minutes

Ce projet comprend un pipeline CI/CD qui peut déployer votre code sur votre serveur en
quelques minutes. Tout ce dont vous avez besoin est un serveur Linux avec SSH activé, ou un compte AWS pour en créer un.
Vous pouvez en savoir plus [ici](https://anarthal.github.io/servertech-chat/03-fork-modify-deploy.html).

## Vous voulez contribuer ?

Envoyez-nous un message dans [le Slack cpplang](https://cpplang.slack.com/archives/C06BRML5EFK) !
Les contributeurs sont les bienvenus !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-27

---