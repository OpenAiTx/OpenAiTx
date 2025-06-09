[![Bannière Nuxt](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Version"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Téléchargements"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Licence"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Site web"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Nuxt openssf scorecard score"></a>
</p>

Nuxt est un framework gratuit et open-source, intuitif et extensible, pour créer des applications web et sites web full-stack, performants, prêts pour la production et sûrs en typage, avec Vue.js.

Il propose de nombreuses fonctionnalités qui facilitent la création d'applications web rapides, optimisées pour le SEO et évolutives, telles que :
- Rendu côté serveur, génération de site statique, rendu hybride et rendu côté Edge
- Routage automatique avec découpage du code et préchargement
- Récupération de données et gestion d’état
- Optimisation SEO et définition des balises Meta
- Import automatique des composants, composables et utilitaires
- TypeScript sans configuration
- Passez au fullstack avec notre répertoire server/
- Extensible avec [200+ modules](https://nuxt.com/modules)
- Déploiement sur une variété de [plateformes d’hébergement](https://nuxt.com/deploy)
- ...[et bien plus encore](https://nuxt.com) 🚀

### Table des matières

- 🚀 [Bien démarrer](#getting-started)
- 💻 [Développement Vue](#vue-development)
- 📖 [Documentation](#documentation)
- 🧩 [Modules](#modules)
- ❤️  [Contribuer](#contribute)
- 🏠 [Développement local](#local-development)
- 🛟 [Support professionnel](#professional-support)
- 🔗 [Suivez-nous](#follow-us)
- ⚖️ [Licence](#license)

---

## <a name="getting-started">🚀 Bien démarrer</a>

Utilisez la commande suivante pour créer un nouveau projet de démarrage. Cela créera un projet de démarrage avec tous les fichiers et dépendances nécessaires :

```bash
npm create nuxt <mon-projet>
```

> [!TIP]
> Découvrez aussi [nuxt.new](https://nuxt.new) : Ouvrez un starter Nuxt sur CodeSandbox, StackBlitz ou en local pour démarrer en quelques secondes.

## <a name="vue-development">💻 Développement Vue</a>

Simple, intuitif et puissant, Nuxt vous permet d’écrire des composants Vue de façon logique. Toutes les tâches répétitives sont automatisées, afin que vous puissiez vous concentrer sur le développement de votre application Vue full-stack en toute confiance.

Exemple d’un `app.vue` :

```vue
<script setup lang="ts">
useSeoMeta({
  title: 'Meet Nuxt',
  description: 'The Intuitive Vue Framework.'
})
</script>

<template>
  <div id="app">
    <AppHeader />
    <NuxtPage />
    <AppFooter />
  </div>
</template>

<style scoped>
#app {
  background-color: #020420;
  color: #00DC82;
}
</style>
```

## <a name="documentation">📖 Documentation</a>

Nous vous recommandons vivement de consulter la [documentation Nuxt](https://nuxt.com/docs) pour monter en compétence. C’est une excellente ressource pour en savoir plus sur le framework. Elle couvre tout, des premiers pas aux sujets avancés.

## <a name="modules">🧩 Modules</a>

Découvrez notre [liste de modules](https://nuxt.com/modules) pour booster votre projet Nuxt, créés par l’équipe Nuxt et la communauté.

## <a name="contribute">❤️ Contribuer</a>

Nous vous invitons à contribuer et à aider à améliorer Nuxt 💚

Voici quelques façons de participer :
- **Signaler des bugs :** Si vous rencontrez des bugs ou problèmes, veuillez consulter le [guide de signalement de bugs](https://nuxt.com/docs/community/reporting-bugs) pour apprendre à soumettre un rapport de bug.
- **Suggestions :** Vous avez des idées pour améliorer Nuxt ? Nous serions ravis de les entendre ! Consultez le [guide de contribution](https://nuxt.com/docs/community/contribution) pour partager vos suggestions.
- **Questions :** Si vous avez des questions ou besoin d’aide, le [guide d’aide](https://nuxt.com/docs/community/getting-help) vous propose des ressources pour vous accompagner.

## <a name="local-development">🏠 Développement local</a>

Suivez la documentation pour [Configurer votre environnement de développement local](https://nuxt.com/docs/community/framework-contribution#setup) afin de contribuer au framework et à la documentation.

## <a name="professional-support">🛟 Support professionnel</a>

- Audit technique & consulting : [Experts Nuxt](https://nuxt.com/enterprise/support)
- Développement sur-mesure & plus : [Partenaires agences Nuxt](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 Suivez-nous</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ Licence</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---