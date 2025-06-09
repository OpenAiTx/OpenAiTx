[![Nuxt banner](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Wersja"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Pobrania"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Licencja"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Strona internetowa"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Nuxt openssf scorecard score"></a>
</p>

Nuxt to darmowy i otwartoźródłowy framework umożliwiający w intuicyjny i rozszerzalny sposób tworzenie bezpiecznych typów, wydajnych i produkcyjnych aplikacji oraz stron internetowych full-stack z użyciem Vue.js.

Oferuje wiele funkcji, które ułatwiają budowę szybkich, przyjaznych SEO i skalowalnych aplikacji webowych, w tym:
- Renderowanie po stronie serwera, statyczna generacja stron, renderowanie hybrydowe i renderowanie po stronie krawędzi
- Automatyczne trasowanie z podziałem kodu i prefetchingiem
- Pobieranie danych i zarządzanie stanem
- Optymalizacja SEO i definiowanie metatagów
- Automatyczny import komponentów, composables i narzędzi
- TypeScript bez konfiguracji
- Fullstack z katalogiem server/
- Rozszerzalność dzięki [200+ modułom](https://nuxt.com/modules)
- Wdrażanie na różne [platformy hostingowe](https://nuxt.com/deploy)
- ...[i wiele więcej](https://nuxt.com) 🚀

### Spis treści

- 🚀 [Pierwsze kroki](#getting-started)
- 💻 [Tworzenie w Vue](#vue-development)
- 📖 [Dokumentacja](#documentation)
- 🧩 [Moduły](#modules)
- ❤️  [Współpraca](#contribute)
- 🏠 [Lokalny rozwój](#local-development)
- 🛟 [Wsparcie profesjonalne](#professional-support)
- 🔗 [Śledź nas](#follow-us)
- ⚖️ [Licencja](#license)

---

## <a name="getting-started">🚀 Pierwsze kroki</a>

Użyj poniższego polecenia, aby utworzyć nowy projekt startowy. Stworzy ono projekt startowy ze wszystkimi niezbędnymi plikami i zależnościami:

```bash
npm create nuxt <my-project>
```

> [!TIP]
> Odkryj także [nuxt.new](https://nuxt.new): Otwórz starter Nuxt na CodeSandbox, StackBlitz lub lokalnie, aby rozpocząć w kilka sekund.

## <a name="vue-development">💻 Tworzenie w Vue</a>

Prosty, intuicyjny i potężny — Nuxt pozwala pisać komponenty Vue w logiczny sposób. Każde powtarzalne zadanie jest zautomatyzowane, więc możesz skupić się na tworzeniu swojej aplikacji full-stack w Vue z pewnością siebie.

Przykład `app.vue`:

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

## <a name="documentation">📖 Dokumentacja</a>

Zalecamy zapoznanie się z [dokumentacją Nuxt](https://nuxt.com/docs), aby poszerzyć wiedzę. To doskonałe źródło informacji na temat frameworka — od podstaw po zaawansowane zagadnienia.

## <a name="modules">🧩 Moduły</a>

Odkryj naszą [listę modułów](https://nuxt.com/modules), które przyspieszą Twój projekt Nuxt — stworzone przez zespół Nuxt i społeczność.

## <a name="contribute">❤️ Współpraca</a>

Zachęcamy do współtworzenia i ulepszania Nuxt 💚

Oto kilka sposobów na zaangażowanie się:
- **Zgłaszanie błędów:** Jeśli natkniesz się na błędy lub problemy, zapoznaj się z [przewodnikiem zgłaszania błędów](https://nuxt.com/docs/community/reporting-bugs), aby dowiedzieć się, jak przesłać zgłoszenie.
- **Sugestie:** Masz pomysły na ulepszenie Nuxt? Chętnie je poznamy! Sprawdź [przewodnik dla współtwórców](https://nuxt.com/docs/community/contribution), aby podzielić się swoimi sugestiami.
- **Pytania:** Masz pytania lub potrzebujesz pomocy? [Przewodnik uzyskiwania pomocy](https://nuxt.com/docs/community/getting-help) zawiera przydatne zasoby.

## <a name="local-development">🏠 Lokalny rozwój</a>

Postępuj zgodnie z dokumentacją, aby [skonfigurować środowisko lokalne](https://nuxt.com/docs/community/framework-contribution#setup) i współtworzyć framework oraz dokumentację.

## <a name="professional-support">🛟 Wsparcie profesjonalne</a>

- Audyt techniczny i konsultacje: [Nuxt Experts](https://nuxt.com/enterprise/support)
- Dedykowane wdrożenia i więcej: [Nuxt Agencies Partners](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 Śledź nas</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ Licencja</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---