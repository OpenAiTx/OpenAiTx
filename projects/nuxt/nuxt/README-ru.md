[![Nuxt banner](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Version"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Downloads"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="License"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Website"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Nuxt openssf scorecard score"></a>
</p>

Nuxt — это бесплатный и открытый фреймворк с интуитивно понятным и расширяемым способом создания типобезопасных, производительных и готовых к промышленной эксплуатации полноценных веб-приложений и сайтов на основе Vue.js.

Он предоставляет ряд функций, которые упрощают создание быстрых, SEO-оптимизированных и масштабируемых веб-приложений, включая:
- Рендеринг на стороне сервера, статическую генерацию сайтов, гибридный рендеринг и рендеринг на границе
- Автоматическую маршрутизацию с разделением кода и предварительной подгрузкой
- Получение данных и управление состоянием
- SEO-оптимизацию и определение метатегов
- Автоматический импорт компонентов, composables и утилит
- TypeScript без дополнительной настройки
- Полноценный fullstack с помощью каталога server/
- Расширяемость с помощью [200+ модулей](https://nuxt.com/modules)
- Развертывание на различных [хостинг-платформах](https://nuxt.com/deploy)
- ...[и многое другое](https://nuxt.com) 🚀

### Содержание

- 🚀 [Начало работы](#getting-started)
- 💻 [Разработка на Vue](#vue-development)
- 📖 [Документация](#documentation)
- 🧩 [Модули](#modules)
- ❤️  [Вклад в проект](#contribute)
- 🏠 [Локальная разработка](#local-development)
- 🛟 [Профессиональная поддержка](#professional-support)
- 🔗 [Следите за нами](#follow-us)
- ⚖️ [Лицензия](#license)

---

## <a name="getting-started">🚀 Начало работы</a>

Используйте следующую команду для создания нового стартового проекта. Это создаст стартовый проект со всеми необходимыми файлами и зависимостями:

```bash
npm create nuxt <my-project>
```

> [!TIP]
> Также ознакомьтесь с [nuxt.new](https://nuxt.new): откройте стартовый проект Nuxt на CodeSandbox, StackBlitz или локально, чтобы начать работу за несколько секунд.

## <a name="vue-development">💻 Разработка на Vue</a>

Простой, интуитивно понятный и мощный, Nuxt позволяет писать компоненты Vue так, как это кажется логичным. Все рутинные задачи автоматизированы, чтобы вы могли с уверенностью сосредоточиться на создании полноценных Vue-приложений.

Пример `app.vue`:

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

## <a name="documentation">📖 Документация</a>

Мы настоятельно рекомендуем ознакомиться с [документацией Nuxt](https://nuxt.com/docs), чтобы повысить свой уровень. Это отличный ресурс для изучения фреймворка — от основ до продвинутых тем.

## <a name="modules">🧩 Модули</a>

Ознакомьтесь с нашим [списком модулей](https://nuxt.com/modules), чтобы прокачать свой проект Nuxt. Модули созданы командой Nuxt и сообществом.

## <a name="contribute">❤️ Вклад в проект</a>

Мы приглашаем вас внести вклад и помочь сделать Nuxt лучше 💚

Вот несколько способов, как вы можете принять участие:
- **Сообщение об ошибках:** Если вы столкнулись с ошибками или проблемами, ознакомьтесь с [руководством по сообщению об ошибках](https://nuxt.com/docs/community/reporting-bugs), чтобы узнать, как правильно отправить баг-репорт.
- **Предложения:** Есть идеи по улучшению Nuxt? Мы будем рады их услышать! Ознакомьтесь с [руководством по участию](https://nuxt.com/docs/community/contribution), чтобы поделиться своими предложениями.
- **Вопросы:** Если у вас есть вопросы или нужна помощь, [руководство по получению помощи](https://nuxt.com/docs/community/getting-help) подскажет, где её найти.

## <a name="local-development">🏠 Локальная разработка</a>

Следуйте инструкции по [настройке локальной среды разработки](https://nuxt.com/docs/community/framework-contribution#setup), чтобы внести вклад в развитие фреймворка и документации.

## <a name="professional-support">🛟 Профессиональная поддержка</a>

- Технический аудит и консультации: [Nuxt Experts](https://nuxt.com/enterprise/support)
- Индивидуальная разработка и другое: [Nuxt Agencies Partners](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 Следите за нами</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ Лицензия</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---