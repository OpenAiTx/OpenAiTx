# EmuReady

Une plateforme communautaire pour suivre la compatibilité de l'émulation sur différents appareils et émulateurs.

Visitez notre site web : [https://emuready.com](https://emuready.com)

---

**Capture d’écran de la page d’accueil**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**Capture d’écran de la page des listes de compatibilité**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**Capture d’écran de la page Jeux**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## Aperçu

EmuReady aide les utilisateurs à partager et découvrir des informations sur la compatibilité de l'émulation sur différentes configurations matérielles et logicielles. Les utilisateurs peuvent contribuer à des rapports de compatibilité, voter sur les listes et discuter de combinaisons spécifiques de jeux/appareils/émulateurs.

![Licence](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Étoiles](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Problèmes](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## Fonctionnalités

- **Base de données de compatibilité complète** : Suivez les performances des jeux sur différents émulateurs et appareils
- **Contributions des utilisateurs** : Rapports et système de vote animés par la communauté
- **Système de discussion** : Fils de commentaires avec fonctionnalité de vote positif/négatif
- **Tableau de bord d’administration** : Gérer les utilisateurs, les listes et la modération du contenu
- **Design réactif** : Fonctionne sur mobile, tablette et ordinateur

## Améliorations récentes

La base de code a été considérablement améliorée avec les évolutions suivantes :

### Composants UI

- Création d’un composant **ErrorBoundary** pour une meilleure gestion et récupération des erreurs
- Ajout d’un composant **OptimizedImage** utilisant le composant Image de Next.js pour de meilleures performances
- Amélioration de la **Pagination** avec des fonctionnalités d’accessibilité, navigation au clavier et meilleure expérience utilisateur
- Amélioration du composant **Badge** avec plus de variantes, de tailles et une option pilule
- Ajout d’un composant **ThemeToggle** pour passer entre les thèmes clair, sombre et système
- Mise en place de **SortableHeader** pour le tri des tableaux avec des indicateurs visuels

### Mise en cache & performance

- Amélioration de la configuration React Query avec de meilleurs paramètres par défaut pour la mise en cache, les temps d’expiration et la logique de réessai
- Optimisation des images pour les appareils
- Implémentation d’une gestion appropriée des erreurs dans toute l’application

### Accessibilité

- Amélioration de la navigation clavier pour les éléments interactifs
- Ajout des labels et rôles ARIA appropriés
- Meilleure gestion du focus
- Contraste des couleurs amélioré dans les composants UI

### Sécurité

- Validation et assainissement des données à plusieurs niveaux (client, serveur, base de données)
- Implémentation d’une politique de sécurité de contenu (Content Security Policy)
- Protection contre les attaques XSS et CSRF
- Authentification sécurisée avec NextAuth.js
- Validation et sécurisation de l’upload de fichiers
- Restrictions de longueur des entrées et assainissement approprié
- Validation UUID pour éviter la falsification de paramètres

### Expérience développeur

- Ajout de scripts npm supplémentaires pour le workflow de développement
- Meilleure structure de projet avec des exports cohérents
- Retour d’erreur amélioré avec un ErrorBoundary personnalisé
- Page 404 améliorée avec des options de navigation utiles

### Thématisation

- Détection de la préférence de thème système ajoutée
- Création d’un commutateur de thème avec plusieurs options d’UI
- Meilleure implémentation du mode sombre dans les composants

## Démarrage

### Prérequis

- Node.js 20+
- `npm`
- PostgreSQL (ou SQLite pour le développement)

### Installation

1. Clonez le dépôt

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. Installez les dépendances

```bash
npm install
```

3. Configurez les variables d’environnement

```bash
cp .env.example .env
```

Puis éditez le fichier `.env` avec vos identifiants de base de données et autres paramètres.

4. Configurez la base de données

```bash
npx prisma generate
npx prisma db push
```

5. Lancez le serveur de développement

```bash
npm run dev
```

6. Ouvrez [http://localhost:3000](http://localhost:3000) dans votre navigateur

## Scripts disponibles

- `npm run dev` - Démarrer le serveur de développement
- `npm run dev:strict` - Démarrer avec React en mode strict
- `npm run build` - Construire pour la production
- `npm run start` - Démarrer le serveur de production
- `npm run test` - Lancer les tests
- `npm run lint` - Lancer ESLint
- `npm run lint:fix` - Corriger les problèmes de lint
- `npm run format` - Formater le code avec Prettier
- `npm run typecheck` - Vérifier les types TypeScript
- `npm run analyze` - Analyser la taille du bundle
- `npm run clean` - Nettoyer le cache de build
- `npm run prepare-deploy` - Préparer le déploiement (lint, typecheck, test, build)

### Commandes Prisma

- `npx prisma db seed` - Alimenter la base de données
- `npx prisma studio` - Ouvrir Prisma Studio
- `npx prisma db pull` - Récupérer le schéma de la base de données
- `npx prisma db push` - Pousser le schéma de la base de données

Voir la [Référence Prisma CLI](https://www.prisma.io/docs/orm/reference/prisma-cli-reference) pour plus de détails.

## Stack technique

- **Framework** : Next.js 15
- **ORM Base de données** : Prisma
- **API** : tRPC
- **Authentification** : NextAuth.js
- **Stylisation** : Tailwind CSS
- **Gestion d’état** : React Query
- **Vérification de type** : TypeScript
- **Animation** : Framer Motion
- **Validation** : Zod, Politique de Sécurité de Contenu, Validation des Entrées

## Contribuer

Les contributions sont les bienvenues ! Merci de consulter nos [Directives de contribution](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) pour plus de détails.

## Licence

Ce projet est sous licence MIT - voir le fichier [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) pour plus d’informations.

## Code de conduite (À FAIRE)

Veuillez noter que ce projet adhère à un [Code de conduite](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md). En participant à ce projet, vous acceptez d’en respecter les termes.

## Sécurité (À FAIRE)

Si vous découvrez une vulnérabilité de sécurité, merci de suivre notre [Politique de sécurité](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) pour la signaler.

## Remerciements

- Tous nos [Contributeurs](https://github.com/Producdevity/emuready/graphs/contributors)
- La communauté de l’émulation pour son inspiration et son soutien

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---