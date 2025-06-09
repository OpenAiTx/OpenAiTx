[![Nuxt banner](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Versione"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Download"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Licenza"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Sito Web"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Nuxt openssf scorecard score"></a>
</p>

Nuxt è un framework gratuito e open-source che offre un modo intuitivo ed estendibile per creare applicazioni e siti web full-stack, type-safe, performanti e di livello produttivo con Vue.js.

Fornisce numerose funzionalità che facilitano la creazione di applicazioni web veloci, SEO-friendly e scalabili, tra cui:
- Rendering lato server, generazione di siti statici, rendering ibrido e rendering edge-side
- Routing automatico con code-splitting e pre-fetching
- Fetch dei dati e gestione dello stato
- Ottimizzazione SEO e definizione dei meta tag
- Auto-import di componenti, composables e utilità
- TypeScript senza alcuna configurazione
- Fullstack con la nostra directory server/
- Estendibile con [oltre 200 moduli](https://nuxt.com/modules)
- Deploy su diverse [piattaforme di hosting](https://nuxt.com/deploy)
- ...[e molto altro ancora](https://nuxt.com) 🚀

### Indice

- 🚀 [Per Iniziare](#getting-started)
- 💻 [Sviluppo Vue](#vue-development)
- 📖 [Documentazione](#documentation)
- 🧩 [Moduli](#modules)
- ❤️  [Contribuisci](#contribute)
- 🏠 [Sviluppo Locale](#local-development)
- 🛟 [Supporto Professionale](#professional-support)
- 🔗 [Seguici](#follow-us)
- ⚖️ [Licenza](#license)

---

## <a name="getting-started">🚀 Per Iniziare</a>

Usa il seguente comando per creare un nuovo progetto starter. Questo creerà un progetto starter con tutti i file e le dipendenze necessarie:

```bash
npm create nuxt <my-project>
```

> [!TIP]
> Scopri anche [nuxt.new](https://nuxt.new): Apri un progetto starter Nuxt su CodeSandbox, StackBlitz o in locale per iniziare in pochi secondi.

## <a name="vue-development">💻 Sviluppo Vue</a>

Semplice, intuitivo e potente, Nuxt ti permette di scrivere componenti Vue in modo naturale. Ogni attività ripetitiva è automatizzata, così puoi concentrarti sullo sviluppo della tua applicazione Vue full-stack con sicurezza.

Esempio di un `app.vue`:

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

## <a name="documentation">📖 Documentazione</a>

Ti consigliamo vivamente di consultare la [documentazione di Nuxt](https://nuxt.com/docs) per migliorare le tue competenze. È una grande risorsa per approfondire il framework, dalle basi agli argomenti avanzati.

## <a name="modules">🧩 Moduli</a>

Scopri la nostra [lista di moduli](https://nuxt.com/modules) per potenziare il tuo progetto Nuxt, creati dal team Nuxt e dalla community.

## <a name="contribute">❤️ Contribuisci</a>

Ti invitiamo a contribuire e a migliorare Nuxt 💚

Ecco alcuni modi per partecipare:
- **Segnalazione Bug:** Se trovi bug o problemi, consulta la [guida alla segnalazione bug](https://nuxt.com/docs/community/reporting-bugs) per sapere come inviare una segnalazione.
- **Suggerimenti:** Hai idee per migliorare Nuxt? Ci piacerebbe ascoltarle! Consulta la [guida al contributo](https://nuxt.com/docs/community/contribution) per condividere i tuoi suggerimenti.
- **Domande:** Se hai domande o hai bisogno di assistenza, la [guida per ottenere aiuto](https://nuxt.com/docs/community/getting-help) ti offre risorse utili.

## <a name="local-development">🏠 Sviluppo Locale</a>

Segui la documentazione per [configurare il tuo ambiente di sviluppo locale](https://nuxt.com/docs/community/framework-contribution#setup) e contribuire al framework e alla documentazione.

## <a name="professional-support">🛟 Supporto Professionale</a>

- Audit tecnico & consulenza: [Esperti Nuxt](https://nuxt.com/enterprise/support)
- Sviluppo su misura e altro: [Agenzie Partner Nuxt](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 Seguici</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ Licenza</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---