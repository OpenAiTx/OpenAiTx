[![Logo do Electron](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![Status de Build do GitHub Actions](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Convite para o Discord do Electron](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: Traduções disponíveis: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
Veja estes documentos em outros idiomas em nosso projeto no [Crowdin](https://crowdin.com/project/electron).

O framework Electron permite que você crie aplicações desktop multiplataforma
usando JavaScript, HTML e CSS. Ele é baseado no [Node.js](https://nodejs.org/) e
no [Chromium](https://www.chromium.org) e é utilizado pelo
[Visual Studio Code](https://github.com/Microsoft/vscode/) e muitos outros [aplicativos](https://electronjs.org/apps).

Siga [@electronjs](https://twitter.com/electronjs) no Twitter para anúncios importantes.

Este projeto segue o Contributor Covenant
[código de conduta](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md).
Ao participar, espera-se que você cumpra este código. Por favor, reporte comportamentos inaceitáveis para [coc@electronjs.org](mailto:coc@electronjs.org).

## Instalação

Para instalar os binários pré-compilados do Electron, utilize o [`npm`](https://docs.npmjs.com/).
O método preferencial é instalar o Electron como uma dependência de desenvolvimento em seu
aplicativo:

```sh
npm install electron --save-dev
```

Para mais opções de instalação e dicas de solução de problemas, veja a
[instalação](docs/tutorial/installation.md). Para informações sobre como gerenciar versões do Electron em seus aplicativos, veja
[Controle de versões do Electron](docs/tutorial/electron-versioning.md).

## Suporte a Plataformas

Cada lançamento do Electron fornece binários para macOS, Windows e Linux.

* macOS (Big Sur e superiores): O Electron fornece binários Intel 64-bit e Apple Silicon / ARM para macOS.
* Windows (Windows 10 e superiores): O Electron fornece binários `ia32` (`x86`), `x64` (`amd64`) e `arm64` para Windows. O suporte para Windows em ARM foi adicionado no Electron 5.0.8. O suporte para Windows 7, 8 e 8.1 foi [removido no Electron 23, em linha com a política de descontinuação do Chromium para Windows](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* Linux: Os binários pré-compilados do Electron são construídos no Ubuntu 20.04. Eles também foram verificados para funcionar em:
  * Ubuntu 18.04 e superiores
  * Fedora 32 e superiores
  * Debian 10 e superiores

## Electron Fiddle

Use o [`Electron Fiddle`](https://github.com/electron/fiddle)
para criar, executar e empacotar pequenos experimentos com Electron, visualizar exemplos de código para todas as APIs do Electron,
e experimentar diferentes versões do Electron. Ele foi projetado para facilitar o início de sua jornada com
Electron.

## Recursos para aprender Electron

* [electronjs.org/docs](https://electronjs.org/docs) - Toda a documentação do Electron
* [electron/fiddle](https://github.com/electron/fiddle) - Uma ferramenta para criar, executar e empacotar pequenos experimentos com Electron
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - Aplicativos de exemplo criados pela comunidade

## Uso programático

A maioria das pessoas usa o Electron pela linha de comando, mas se você precisar do `electron` dentro do seu **aplicativo Node** (não seu aplicativo Electron), ele retornará o caminho do arquivo do binário. Use isso para iniciar o Electron a partir de scripts Node:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// vai exibir algo semelhante a /Users/maf/.../Electron
console.log(electron)

// inicia o Electron
const child = proc.spawn(electron)
```

### Espelhos

* [China](https://npmmirror.com/mirrors/electron/)

Consulte as [Instruções Avançadas de Instalação](https://www.electronjs.org/docs/latest/tutorial/installation#mirror) para aprender como usar um espelho personalizado.

## Traduções da documentação

Nós realizamos traduções colaborativas da nossa documentação via [Crowdin](https://crowdin.com/project/electron).
Atualmente aceitamos traduções para Chinês (Simplificado), Francês, Alemão, Japonês, Português,
Russo e Espanhol.

## Contribuindo

Se você está interessado em relatar/corrigir problemas e contribuir diretamente para o código-fonte, veja [CONTRIBUTING.md](CONTRIBUTING.md) para mais informações sobre o que procuramos e como começar.

## Comunidade

Informações sobre como relatar bugs, obter ajuda, encontrar ferramentas de terceiros, aplicativos de exemplo,
e muito mais podem ser encontradas na [página da Comunidade](https://www.electronjs.org/community).

## Licença

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Ao usar logos do Electron, certifique-se de seguir a [Política de Marcas Registradas da OpenJS Foundation](https://trademark-policy.openjsf.org/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---