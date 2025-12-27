![preview](https://github.com/user-attachments/assets/e6762b5a-479a-4261-8e5c-e6b5d04344c5)
# Garde-manger
[![build](https://github.com/imRohan/Pantry/actions/workflows/continuous_integration.yml/badge.svg)](https://github.com/imRohan/Pantry/actions/workflows/continuous_integration.yml)
![Maintenabilité](https://api.codeclimate.com/v1/badges/8f1460270ced1f60744c/maintainability)
![Problèmes ouverts](https://img.shields.io/github/issues/imrohan/Pantry?&logo=github)
![Problèmes fermés](https://img.shields.io/github/issues-closed-raw/imrohan/pantry?color=green&logo=github)
[![Couverture des tests](https://coveralls.io/repos/github/imRohan/Pantry/badge.svg?branch=master)](https://coveralls.io/github/imRohan/Pantry?branch=master)

[Pantry](https://getpantry.cloud/) est un service gratuit qui fournit un stockage de données périssables pour les petits projets. Les données sont stockées en toute sécurité aussi longtemps que vous et vos utilisateurs en avez besoin et sont supprimées après une période d'inactivité. Utilisez simplement l'API RESTful pour poster des objets JSON et nous nous occupons du reste.

Il a été conçu pour offrir une solution de stockage simple et réutilisable pour des projets de taille plus modeste. Il a été créé par des développeurs pour des développeurs, pour être là quand vous en avez besoin et pour vous aider à prototyper rapidement votre prochain projet.

## Développement

#### Cloner le dépôt
`git clone https://github.com/imRohan/Pantry.git && cd Pantry`

#### Installer les dépendances
`yarn`

#### Installer Redis
Vous devrez installer Redis (v^6.2.0) sur votre machine et avoir un serveur en fonctionnement
en utilisant ses paramètres par défaut

#### Créer et éditer un `.env` et `config.ts`
`cp env.sample .env`
`cp src/app/config.dev.ts src/app/config.ts`

#### Compiler les assets frontend et lancer le serveur (port par défaut 3000)

`yarn run dev`

#### Ouvrir la page HTML d'exemple

Ouvrez `http://localhost:3000/` dans le navigateur de votre choix


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-27

---