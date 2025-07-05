# Kelp

Uma biblioteca de UI para pessoas que amam HTML, alimentada por CSS moderno e Web Components.

**[Leia a Documentação &rarr;](https://kelpui.com)**

_**Nota:** O Kelp está atualmente em desenvolvimento em versão alpha. Sinta-se à vontade para usá-lo, experimentar e relatar bugs, mas entenda que as coisas podem e vão mudar com o tempo._



## Início Rápido

O Kelp funciona sem qualquer etapa de build.

[O CDN](https://cdn.jsdelivr.net/npm/kelpui/) é a maneira mais rápida e simples de começar, mas você pode [baixar os arquivos do GitHub](https://github.com/cferdinandi/kelp) se preferir.

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

O Kelp usa versionamento semântico. Você pode obter uma versão major, minor ou patch do CDN com a sintaxe `@1.2.3`. Você pode encontrar todas as versões disponíveis [em releases](https://github.com/cferdinandi/kelp/tags).



## Demo

O arquivo `index.html` incluído é uma demonstração completa do Kelp. Ele inclui todos os recursos e componentes em um único arquivo gigante.

Enquanto estiver em beta, o Kelp não possui etapa de compilação. O web component utiliza ES imports e requer um servidor local para rodar.

Use seu servidor preferido, ou utilize o `http-server` incluído executando `npm run dev`.

```bash
npm install
npm run dev
```

À medida que o Kelp se aproxima da v1, ele usará uma etapa de compilação para tornar isso desnecessário.



## Testes

O Kelp utiliza...

- [Playwright](https://playwright.dev) para testes
- [Biome](https://biomejs.dev) para lint e formatação
- Um processo de integração contínua em deploys e PRs

```bash
# Rodar testes
npm run test

# Rodar linter
npm run lint
```



## Licença

Livre para uso sob a [Licença Kelp Commons](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md). Existem também [opções de licença comercial](/license/) disponíveis.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---