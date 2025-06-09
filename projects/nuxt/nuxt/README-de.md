[![Nuxt Banner](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Version"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Downloads"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Lizenz"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Website"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Nuxt openssf scorecard score"></a>
</p>

Nuxt ist ein kostenloses und Open-Source-Framework, das eine intuitive und erweiterbare Möglichkeit bietet, typsichere, leistungsfähige und produktionsreife Full-Stack-Webanwendungen und Websites mit Vue.js zu erstellen.

Es bietet eine Reihe von Funktionen, die den Bau schneller, SEO-freundlicher und skalierbarer Webanwendungen erleichtern, darunter:
- Server-seitiges Rendering, statische Seitengenerierung, hybrides Rendering und Edge-Side Rendering
- Automatisches Routing mit Code-Splitting und Vorabrufen
- Datenabfrage und State-Management
- SEO-Optimierung und Definition von Metatags
- Automatischer Import von Komponenten, Composables und Utils
- TypeScript ohne Konfigurationsaufwand
- Gehe Fullstack mit unserem server/-Verzeichnis
- Erweiterbar mit [200+ Modulen](https://nuxt.com/modules)
- Bereitstellung auf verschiedenen [Hosting-Plattformen](https://nuxt.com/deploy)
- ...[und vieles mehr](https://nuxt.com) 🚀

### Inhaltsverzeichnis

- 🚀 [Erste Schritte](#getting-started)
- 💻 [Vue-Entwicklung](#vue-development)
- 📖 [Dokumentation](#documentation)
- 🧩 [Module](#modules)
- ❤️  [Mitwirken](#contribute)
- 🏠 [Lokale Entwicklung](#local-development)
- 🛟 [Professioneller Support](#professional-support)
- 🔗 [Folge uns](#follow-us)
- ⚖️ [Lizenz](#license)

---

## <a name="getting-started">🚀 Erste Schritte</a>

Nutze den folgenden Befehl, um ein neues Starter-Projekt zu erstellen. Dies erstellt ein Starter-Projekt mit allen notwendigen Dateien und Abhängigkeiten:

```bash
npm create nuxt <mein-projekt>
```

> [!TIPP]
> Entdecke auch [nuxt.new](https://nuxt.new): Öffne ein Nuxt-Starter-Projekt auf CodeSandbox, StackBlitz oder lokal und starte in wenigen Sekunden.

## <a name="vue-development">💻 Vue-Entwicklung</a>

Einfach, intuitiv und leistungsstark: Mit Nuxt kannst du Vue-Komponenten so schreiben, wie es Sinn macht. Jede wiederholende Aufgabe wird automatisiert, sodass du dich darauf konzentrieren kannst, deine Full-Stack-Vue-Anwendung mit Vertrauen zu entwickeln.

Beispiel einer `app.vue`:

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

## <a name="documentation">📖 Dokumentation</a>

Wir empfehlen dir dringend, einen Blick in die [Nuxt-Dokumentation](https://nuxt.com/docs) zu werfen, um dein Wissen zu vertiefen. Sie ist eine großartige Ressource, um mehr über das Framework zu erfahren. Sie deckt alles von den ersten Schritten bis hin zu fortgeschrittenen Themen ab.

## <a name="modules">🧩 Module</a>

Entdecke unsere [Liste der Module](https://nuxt.com/modules), um dein Nuxt-Projekt zu erweitern – erstellt vom Nuxt-Team und der Community.

## <a name="contribute">❤️ Mitwirken</a>

Wir laden dich ein, mitzumachen und Nuxt zu verbessern 💚

Hier sind einige Möglichkeiten, wie du dich einbringen kannst:
- **Fehler melden:** Wenn du auf Bugs oder Probleme stößt, sieh dir bitte den [Leitfaden zum Melden von Fehlern](https://nuxt.com/docs/community/reporting-bugs) an, um zu erfahren, wie du einen Bugreport einreichen kannst.
- **Vorschläge:** Hast du Ideen, um Nuxt zu verbessern? Wir würden uns freuen, davon zu hören! Sieh dir den [Beitrag-Leitfaden](https://nuxt.com/docs/community/contribution) an, um deine Vorschläge zu teilen.
- **Fragen:** Wenn du Fragen hast oder Unterstützung benötigst, findest du im [Hilfe-Leitfaden](https://nuxt.com/docs/community/getting-help) Ressourcen, die dir weiterhelfen.

## <a name="local-development">🏠 Lokale Entwicklung</a>

Folge der Dokumentation, um [deine lokale Entwicklungsumgebung einzurichten](https://nuxt.com/docs/community/framework-contribution#setup), um zum Framework und zur Dokumentation beizutragen.

## <a name="professional-support">🛟 Professioneller Support</a>

- Technisches Audit & Beratung: [Nuxt Experts](https://nuxt.com/enterprise/support)
- Individuelle Entwicklung & mehr: [Nuxt Agentur-Partner](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 Folge uns</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ Lizenz</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---