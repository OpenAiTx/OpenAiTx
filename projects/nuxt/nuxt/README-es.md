[![Nuxt banner](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Version"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Descargas"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Licencia"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Sitio web"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Puntuación de Nuxt openssf scorecard"></a>
</p>

Nuxt es un framework gratuito y de código abierto que proporciona una forma intuitiva y extensible de crear aplicaciones web y sitios web full-stack, seguros en tipos, de alto rendimiento y de nivel de producción con Vue.js.

Ofrece una serie de características que facilitan la creación de aplicaciones web rápidas, escalables y optimizadas para SEO, incluyendo:
- Renderizado del lado del servidor, Generación de Sitios Estáticos, Renderizado Híbrido y Renderizado del Lado del Borde
- Enrutamiento automático con división de código y pre-carga
- Obtención de datos y gestión de estado
- Optimización SEO y definición de metaetiquetas
- Importación automática de componentes, composables y utilidades
- TypeScript sin configuración previa
- Fullstack completo con nuestro directorio server/
- Extensible con [más de 200 módulos](https://nuxt.com/modules)
- Despliegue en una variedad de [plataformas de alojamiento](https://nuxt.com/deploy)
- ...[y mucho más](https://nuxt.com) 🚀

### Tabla de Contenidos

- 🚀 [Primeros Pasos](#getting-started)
- 💻 [Desarrollo Vue](#vue-development)
- 📖 [Documentación](#documentation)
- 🧩 [Módulos](#modules)
- ❤️  [Contribuir](#contribute)
- 🏠 [Desarrollo Local](#local-development)
- 🛟 [Soporte Profesional](#professional-support)
- 🔗 [Síguenos](#follow-us)
- ⚖️ [Licencia](#license)

---

## <a name="getting-started">🚀 Primeros Pasos</a>

Utiliza el siguiente comando para crear un nuevo proyecto inicial. Esto creará un proyecto inicial con todos los archivos y dependencias necesarias:

```bash
npm create nuxt <mi-proyecto>
```

> [!TIP]
> Descubre también [nuxt.new](https://nuxt.new): Abre un starter de Nuxt en CodeSandbox, StackBlitz o localmente para comenzar en cuestión de segundos.

## <a name="vue-development">💻 Desarrollo Vue</a>

Simple, intuitivo y potente, Nuxt te permite escribir componentes Vue de una manera lógica. Cada tarea repetitiva está automatizada, para que puedas enfocarte en escribir tu aplicación Vue full-stack con confianza.

Ejemplo de un `app.vue`:

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

## <a name="documentation">📖 Documentación</a>

Te recomendamos encarecidamente que le eches un vistazo a la [documentación de Nuxt](https://nuxt.com/docs) para mejorar tus conocimientos. Es un gran recurso para aprender más sobre el framework. Cubre desde los primeros pasos hasta temas avanzados.

## <a name="modules">🧩 Módulos</a>

Descubre nuestra [lista de módulos](https://nuxt.com/modules) para potenciar tu proyecto Nuxt, creados por el equipo y la comunidad de Nuxt.

## <a name="contribute">❤️ Contribuir</a>

Te invitamos a contribuir y ayudar a mejorar Nuxt 💚

Aquí tienes algunas formas de involucrarte:
- **Reportar errores:** Si encuentras algún error o problema, consulta la [guía para reportar errores](https://nuxt.com/docs/community/reporting-bugs) para aprender cómo enviar un informe.
- **Sugerencias:** ¿Tienes ideas para mejorar Nuxt? ¡Nos encantaría escucharlas! Consulta la [guía de contribución](https://nuxt.com/docs/community/contribution) para compartir tus sugerencias.
- **Preguntas:** Si tienes dudas o necesitas ayuda, la [guía para obtener ayuda](https://nuxt.com/docs/community/getting-help) ofrece recursos para apoyarte.

## <a name="local-development">🏠 Desarrollo Local</a>

Sigue la documentación para [Configurar tu Entorno de Desarrollo Local](https://nuxt.com/docs/community/framework-contribution#setup) y contribuir al framework y la documentación.

## <a name="professional-support">🛟 Soporte Profesional</a>

- Auditoría técnica y consultoría: [Nuxt Experts](https://nuxt.com/enterprise/support)
- Desarrollo a medida y más: [Agencias Partners de Nuxt](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 Síguenos</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ Licencia</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---