# NoneOS - Un système d'exploitation virtuel léger basé sur le navigateur

[中文](https://raw.githubusercontent.com/kirakiray/NoneOS/main/./md/README_CN.md) | [日本語](https://raw.githubusercontent.com/kirakiray/NoneOS/main/./md/README_JP.md)

## Introduction au projet

NoneOS est une solution innovante de système d'exploitation virtuel basée sur le navigateur qui adopte une architecture purement statique et peut fonctionner sans le support d'un serveur backend.

Objectif à court terme : Créer un système NAS léger basé sur le navigateur, permettant une connexion et une collaboration fluides entre les appareils.

- [x] Prise en charge de la gestion des fichiers via le navigateur
- [x] Application de synchronisation de favoris
- [x] Application de synchronisation de notes (similaire à Notion)
- [x] Application de transfert de fichiers (similaire à LocalSend)
- [ ] Reconstruction de l'application de synchronisation de notes

## Démarrage rapide

Visitez directement le site officiel : [https://os.noneos.com/](https://os.noneos.com/)

### Exécution locale
1. Clonez ou téléchargez le projet et assurez-vous que nodejs est installé localement.
2. Installez les dépendances :
```bash
npm install
```
3. Démarrez le serveur :
```bash
npm run static
```
1. Visitez : `http://localhost:5559/`

## Comment créer une application ?

NoneOS adopte une architecture avancée de micro-applications Web, chaque application étant construite sur le puissant framework ofa.js. Les développeurs peuvent facilement créer leurs propres applications en important simplement le répertoire de l'application (comme l'application exemple `others/hello-world.napp`) dans le dossier "Apps" du système pour la déployer et l'exécuter rapidement.

Nous rédigeons actuellement une documentation de développement plus détaillée. En attendant, les développeurs peuvent :
- Se référer à la documentation officielle d'ofa.js pour comprendre les fonctionnalités du framework.
- Consulter les applications exemples dans le répertoire `packages/apps` comme référence pour le développement.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---