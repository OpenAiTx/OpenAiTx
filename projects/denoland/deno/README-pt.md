# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="o mascote dinossauro do deno em pé na chuva">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), pronunciado
`dee-no`) é um ambiente de execução para JavaScript, TypeScript e WebAssembly com padrões de segurança e uma ótima experiência para desenvolvedores. Ele é construído sobre [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/) e [Tokio](https://tokio.rs/).

Saiba mais sobre o runtime do Deno
[na documentação](https://docs.deno.com/runtime/manual).

## Instalação

Instale o runtime Deno em seu sistema usando um dos comandos abaixo. Note
que existem diversas formas de instalar o Deno - uma lista abrangente de
opções de instalação pode ser encontrada
[aqui](https://docs.deno.com/runtime/manual/getting_started/installation).

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

### Compilar e instalar a partir do código-fonte

Instruções completas para compilar o Deno a partir do código-fonte podem ser encontradas
[aqui](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source).

## Seu primeiro programa em Deno

O Deno pode ser utilizado para diversas aplicações, mas é mais comumente usado para
construir servidores web. Crie um arquivo chamado `server.ts` e inclua o seguinte
código TypeScript:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

Execute seu servidor com o seguinte comando:

```sh
deno run --allow-net server.ts
```

Isso deve iniciar um servidor web local em
[http://localhost:8000](http://localhost:8000).

Saiba mais sobre como escrever e executar programas Deno
[na documentação](https://docs.deno.com/runtime/manual).

## Recursos adicionais

- **[Deno Docs](https://docs.deno.com)**: guias oficiais e documentação de referência para
  o runtime Deno, [Deno Deploy](https://deno.com/deploy) e muito mais.
- **[Deno Standard Library](https://jsr.io/@std)**: utilitários comuns oficialmente suportados
  para programas Deno.
- **[JSR](https://jsr.io/)**: O repositório de pacotes open-source para
  JavaScript e TypeScript modernos.
- **[Developer Blog](https://deno.com/blog)**: Atualizações de produto, tutoriais e
  mais conteúdos do time Deno.

## Contribuindo

Agradecemos sua ajuda! Para contribuir, por favor leia nossas
[instruções de contribuição](.github/CONTRIBUTING.md).

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