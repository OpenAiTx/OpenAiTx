# Spécification du Protocole Universel d’Appel d’Outils (UTCP)

Ce dépôt contient la documentation officielle de la spécification du Protocole Universel d’Appel d’Outils (UTCP). UTCP est une norme moderne, flexible et évolutive pour définir et interagir avec des outils via divers protocoles de communication.

## Qu'est-ce qu'UTCP ?

UTCP fournit une méthode standardisée permettant aux systèmes d’IA et autres clients de découvrir et d’appeler des outils provenant de différents fournisseurs, quel que soit le protocole sous-jacent utilisé (HTTP, WebSocket, CLI, etc.). Cette spécification définit :

- Les mécanismes de découverte d’outils
- Les formats d’appel d’outils
- La configuration des fournisseurs
- Les méthodes d’authentification
- La gestion des réponses

## Contribuer à la Spécification

Nous accueillons volontiers les contributions à la spécification UTCP ! Voici comment vous pouvez contribuer :

1. **Forkez le dépôt** : Créez votre propre fork du dépôt de la spécification
2. **Apportez vos modifications** : Mettez à jour ou ajoutez de la documentation selon les besoins
3. **Soumettez une pull request** : Ouvrez une PR avec vos modifications pour révision
4. **Participez aux discussions** : Rejoignez la conversation sur les modifications proposées

Lorsque vous contribuez, veuillez suivre ces directives :

- Veillez à ce que vos modifications soient conformes à la vision et aux objectifs globaux de l’UTCP
- Suivez la structure et la mise en forme de la documentation existante
- Incluez des exemples lors de l’ajout de nouvelles fonctionnalités ou concepts
- Mettez à jour les sections concernées pour garantir la cohérence de la documentation

## Générer la Documentation en Local

### Prérequis

Pour générer et prévisualiser le site de documentation en local, vous aurez besoin de :

- Ruby version 2.5.0 ou supérieure
- RubyGems
- Bundler

### Installation

1. Clonez le dépôt :
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. Installer les dépendances :

   ```bash
   bundle install
   ```
### Exécution du site de documentation

Pour construire et servir le site localement :


```bash
bundle exec jekyll serve
```
Cela lancera un serveur web local à l'adresse `http://localhost:4000` où vous pourrez prévisualiser la documentation.

## Structure de la documentation

La documentation UTCP est organisée comme suit :

- `index.md` : Page d'accueil et introduction à UTCP
- `docs/`
  - `introduction.md` : Introduction détaillée et concepts de base
  - `for-tool-providers.md` : Guide pour l'implémentation des fournisseurs d'outils
  - `for-tool-callers.md` : Guide pour l'implémentation des appelants d'outils
  - `providers/` : Documentation pour chaque type de fournisseur
    - `http.md` : Fournisseur HTTP
    - `websocket.md` : Fournisseur WebSocket
    - `cli.md` : Fournisseur CLI
    - `sse.md` : Fournisseur Server-Sent Events (SSE)
    - etc.
  - `implementation.md` : Conseils d'implémentation et bonnes pratiques

## Travailler avec la spécification

### Modification de la documentation

La documentation est rédigée en format Markdown avec un front matter Jekyll. Lors de modifications :

1. Assurez-vous que votre Markdown respecte le style établi
2. Prévisualisez vos modifications localement avant de soumettre des PR
3. Maintenez les exemples à jour avec la dernière spécification
4. Mettez à jour les éléments de navigation dans `_config.yml` lors de l'ajout de nouvelles pages

### Organisation des fichiers

Lors de l'ajout de nouvelle documentation :

- Placez la documentation spécifique à un fournisseur dans `docs/providers/`
- Utilisez un front matter cohérent avec un ordre de navigation approprié
- Ajoutez des tags pour améliorer la recherche sur GitHub Pages

## Contrôle de version

La spécification UTCP suit la gestion sémantique des versions :

- Versions majeures (1.0, 2.0) : Changements incompatibles du protocole
- Versions mineures (1.1, 1.2) : Nouvelles fonctionnalités ajoutées de manière rétrocompatible
- Versions correctives (1.0.1, 1.0.2) : Corrections de bugs et clarifications rétrocompatibles

## Licence

Cette spécification est distribuée sous la licence Mozilla Public License 2.0 (MPL-2.0).

## Ressources complémentaires

- [Organisation GitHub UTCP](https://github.com/universal-tool-calling-protocol)
- [Site Web UTCP](https://utcp.io)
- [Implémentations de référence](https://github.com/universal-tool-calling-protocol/python-utcp)
- [Discussions communautaires](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---