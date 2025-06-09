[![Nuxt banner](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Versão"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Downloads"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Licença"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Site"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Pontuação Nuxt openssf scorecard"></a>
</p>

Nuxt é um framework gratuito e open-source com uma forma intuitiva e extensível de criar aplicações web full-stack e sites de alto desempenho, prontos para produção e com tipagem segura, utilizando Vue.js.

Ele oferece diversos recursos que facilitam a construção de aplicações web rápidas, escaláveis e otimizadas para SEO, incluindo:
- Renderização do lado do servidor, Geração de Site Estático, Renderização Híbrida e Renderização no Edge
- Roteamento automático com divisão de código e pré-carregamento
- Busca de dados e gerenciamento de estado
- Otimização de SEO e definição de metatags
- Auto importação de componentes, composables e utils
- TypeScript sem configuração
- Fullstack completo com nosso diretório server/
- Extensível com [200+ módulos](https://nuxt.com/modules)
- Deploy em diversas [plataformas de hospedagem](https://nuxt.com/deploy)
- ...[e muito mais](https://nuxt.com) 🚀

### Índice

- 🚀 [Primeiros Passos](#getting-started)
- 💻 [Desenvolvimento Vue](#vue-development)
- 📖 [Documentação](#documentation)
- 🧩 [Módulos](#modules)
- ❤️  [Contribua](#contribute)
- 🏠 [Desenvolvimento Local](#local-development)
- 🛟 [Suporte Profissional](#professional-support)
- 🔗 [Siga-nos](#follow-us)
- ⚖️ [Licença](#license)

---

## <a name="getting-started">🚀 Primeiros Passos</a>

Utilize o comando abaixo para criar um novo projeto inicial. Isso criará um projeto já com todos os arquivos e dependências necessários:

```bash
npm create nuxt <meu-projeto>
```

> [!TIP]
> Descubra também o [nuxt.new](https://nuxt.new): Abra um projeto starter Nuxt no CodeSandbox, StackBlitz ou localmente para começar em poucos segundos.

## <a name="vue-development">💻 Desenvolvimento Vue</a>

Simples, intuitivo e poderoso, o Nuxt permite que você escreva componentes Vue de forma lógica. Todas as tarefas repetitivas são automatizadas, para que você possa focar em desenvolver sua aplicação Vue full-stack com confiança.

Exemplo de um `app.vue`:

```vue
<script setup lang="ts">
useSeoMeta({
  title: 'Conheça o Nuxt',
  description: 'O Framework Vue Intuitivo.'
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

## <a name="documentation">📖 Documentação</a>

Recomendamos fortemente que você consulte a [documentação do Nuxt](https://nuxt.com/docs) para se aprofundar. É um excelente recurso para aprender mais sobre o framework, cobrindo desde os primeiros passos até tópicos avançados.

## <a name="modules">🧩 Módulos</a>

Descubra nossa [lista de módulos](https://nuxt.com/modules) para potencializar seu projeto Nuxt, criados pela equipe e comunidade Nuxt.

## <a name="contribute">❤️ Contribua</a>

Convidamos você a contribuir e ajudar a melhorar o Nuxt 💚

Aqui estão algumas formas de se envolver:
- **Reportar Bugs:** Se encontrar bugs ou problemas, confira o [guia de relato de bugs](https://nuxt.com/docs/community/reporting-bugs) para saber como enviar um relatório.
- **Sugestões:** Tem ideias para melhorar o Nuxt? Adoraríamos ouvir! Veja o [guia de contribuição](https://nuxt.com/docs/community/contribution) para compartilhar suas sugestões.
- **Dúvidas:** Se tiver dúvidas ou precisar de ajuda, o [guia de obtenção de ajuda](https://nuxt.com/docs/community/getting-help) oferece recursos para auxiliar você.

## <a name="local-development">🏠 Desenvolvimento Local</a>

Siga a documentação para [Configurar seu Ambiente de Desenvolvimento Local](https://nuxt.com/docs/community/framework-contribution#setup) e contribuir com o framework e a documentação.

## <a name="professional-support">🛟 Suporte Profissional</a>

- Auditoria técnica e consultoria: [Nuxt Experts](https://nuxt.com/enterprise/support)
- Desenvolvimento personalizado e mais: [Parceiros Nuxt Agencies](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 Siga-nos</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ Licença</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---