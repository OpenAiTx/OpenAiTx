# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="el dinosaurio mascota de deno parado bajo la lluvia">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), pronunciado
`dee-no`) es un entorno de ejecución para JavaScript, TypeScript y WebAssembly, con valores predeterminados seguros y una excelente experiencia para desarrolladores. Está construido sobre [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/) y [Tokio](https://tokio.rs/).

Obtén más información sobre el entorno de ejecución de Deno
[en la documentación](https://docs.deno.com/runtime/manual).

## Instalación

Instala el entorno de ejecución de Deno en tu sistema usando uno de los siguientes comandos. Ten en cuenta que hay varias formas de instalar Deno; una lista completa de opciones de instalación se puede encontrar
[aquí](https://docs.deno.com/runtime/manual/getting_started/installation).

Shell (Mac, Linux):

```sh
curl -fsSL https://deno.land/install.sh | sh
```

PowerShell (Windows):

```powershell
irm https://deno.land/install.ps1 | iex
```

[Homebrew](https://formulae.brew.sh/formula/deno) (Mac):

```sh
brew install deno
```

[Chocolatey](https://chocolatey.org/packages/deno) (Windows):

```powershell
choco install deno
```

[WinGet](https://winstall.app/apps/DenoLand.Deno) (Windows):

```powershell
winget install --id=DenoLand.Deno
```

### Compilar e instalar desde el código fuente

Las instrucciones completas para compilar Deno desde el código fuente se pueden encontrar
[aquí](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source).

## Tu primer programa en Deno

Deno se puede usar para muchas aplicaciones diferentes, pero se utiliza más comúnmente para crear servidores web. Crea un archivo llamado `server.ts` e incluye el siguiente código TypeScript:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

Ejecuta tu servidor con el siguiente comando:

```sh
deno run --allow-net server.ts
```

Esto debería iniciar un servidor web local en
[http://localhost:8000](http://localhost:8000).

Obtén más información sobre cómo escribir y ejecutar programas en Deno
[en la documentación](https://docs.deno.com/runtime/manual).

## Recursos adicionales

- **[Deno Docs](https://docs.deno.com)**: guías oficiales y documentación de referencia para el entorno de ejecución de Deno, [Deno Deploy](https://deno.com/deploy) y más allá.
- **[Deno Standard Library](https://jsr.io/@std)**: utilidades comunes oficialmente soportadas para programas en Deno.
- **[JSR](https://jsr.io/)**: el registro de paquetes de código abierto para JavaScript y TypeScript modernos.
- **[Developer Blog](https://deno.com/blog)**: Actualizaciones de producto, tutoriales y más del equipo de Deno.

## Contribuir

¡Agradecemos tu ayuda! Para contribuir, por favor lee nuestras
[instrucciones de contribución](.github/CONTRIBUTING.md).

[Build status - Cirrus]: https://github.com/denoland/deno/workflows/ci/badge.svg?branch=main&event=push
[Build status]: https://github.com/denoland/deno/actions
[Twitter badge]: https://img.shields.io/twitter/follow/deno_land.svg?style=social&label=Follow
[Twitter link]: https://twitter.com/intent/follow?screen_name=deno_land
[Bluesky badge]: https://img.shields.io/badge/Follow-whitesmoke?logo=bluesky
[Bluesky link]: https://bsky.app/profile/deno.land
[YouTube badge]: https://img.shields.io/youtube/channel/subscribers/UCqC2G2M-rg4fzg1esKFLFIw?style=social
[YouTube link]: https://www.youtube.com/@deno_land
[Discord badge]: https://img.shields.io/discord/684898665143206084?logo=discord&style=social
[Discord link]: https://discord.gg/deno

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---