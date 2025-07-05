# Kelp

Une bibliothèque d’interface utilisateur pour les personnes qui aiment le HTML, propulsée par le CSS moderne et les Web Components.

**[Lire la documentation &rarr;](https://kelpui.com)**

_**Remarque :** Kelp est actuellement en développement en version alpha. N’hésitez pas à l’utiliser, à expérimenter et à signaler des bugs, mais comprenez que des changements peuvent survenir au fil du temps._



## Démarrage rapide

Kelp fonctionne sans aucune étape de compilation.

[Le CDN](https://cdn.jsdelivr.net/npm/kelpui/) est le moyen le plus rapide et le plus simple pour commencer, mais vous pouvez aussi [télécharger les fichiers depuis GitHub](https://github.com/cferdinandi/kelp) si vous préférez.

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp utilise le versionnage sémantique. Vous pouvez obtenir une version majeure, mineure ou patch depuis le CDN avec la syntaxe `@1.2.3`. Vous trouverez toutes les versions disponibles [dans les releases](https://github.com/cferdinandi/kelp/tags).



## Démo

Le fichier `index.html` inclus est une démonstration complète de Kelp. Il inclut toutes les fonctionnalités et composants dans un seul fichier volumineux.

Pendant la bêta, Kelp n’a pas d’étape de compilation. Les web components utilisent les imports ES, et nécessitent un serveur local pour fonctionner.

Utilisez votre serveur préféré, ou utilisez le `http-server` inclus en lançant `npm run dev`.

```bash
npm install
npm run dev
```

À l’approche de la v1, Kelp utilisera une étape de compilation pour rendre cela inutile.



## Tests

Kelp utilise...

- [Playwright](https://playwright.dev) pour les tests
- [Biome](https://biomejs.dev) pour le linting et le formatage
- Un processus d’intégration continue lors des déploiements et des pull requests

```bash
# Lancer les tests
npm run test

# Lancer le linter
npm run lint
```



## Licence

Libre d’utilisation sous la [Licence Kelp Commons](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md). Des [options de licence commerciale](/license/) sont également disponibles.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---