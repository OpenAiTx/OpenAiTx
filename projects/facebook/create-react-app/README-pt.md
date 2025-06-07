## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!CAUTION]
>
> ## Descontinuado
>
> O Create React App foi uma das principais ferramentas para iniciar projetos React entre 2017-2021, mas agora está em estado de manutenção prolongada e recomendamos que você migre para um dos frameworks React documentados em [Inicie um Novo Projeto React](https://react.dev/learn/start-a-new-react-project).
>
> Se você está seguindo um tutorial para aprender React, ainda vale a pena continuar, mas não recomendamos iniciar aplicações de produção baseadas no Create React App.

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

Crie apps React sem configuração de build.

- [Criando um App](#criando-um-app) – Como criar um novo app.
- [Guia do Usuário](https://facebook.github.io/create-react-app/) – Como desenvolver apps inicializados com o Create React App.

O Create React App funciona em macOS, Windows e Linux.<br>
Se algo não funcionar, por favor [registre um problema](https://github.com/facebook/create-react-app/issues/new).<br>
Se você tiver dúvidas ou precisar de ajuda, pergunte em [GitHub Discussions](https://github.com/facebook/create-react-app/discussions).

## Visão Rápida

```sh
npx create-react-app my-app
cd my-app
npm start
```

Se você já instalou o `create-react-app` globalmente via `npm install -g create-react-app`, recomendamos desinstalar o pacote usando `npm uninstall -g create-react-app` ou `yarn global remove create-react-app` para garantir que o npx sempre use a versão mais recente.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) vem com npm 5.2+ e superiores, veja [instruções para versões mais antigas do npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

Depois abra [http://localhost:3000/](http://localhost:3000/) para ver seu app.<br>
Quando estiver pronto para colocar em produção, crie um bundle minificado com `npm run build`.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### Comece Imediatamente

Você **não** precisa instalar ou configurar ferramentas como webpack ou Babel.<br>
Elas já vêm pré-configuradas e ocultas para que você possa focar no código.

Crie um projeto e pronto, você já pode começar.

## Criando um App

**Você precisará ter o Node 14.0.0 ou superior em sua máquina de desenvolvimento local** (não é necessário no servidor). Recomendamos utilizar a versão LTS mais recente. Você pode usar o [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux) ou [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) para alternar versões do Node entre diferentes projetos.

Para criar um novo app, você pode escolher um dos seguintes métodos:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) é uma ferramenta de execução de pacotes que vem com npm 5.2+ e superiores, veja [instruções para versões mais antigas do npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` está disponível no npm 6+_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) está disponível no Yarn 0.25+_

Ele criará um diretório chamado `my-app` dentro da pasta atual.<br>
Dentro desse diretório, será gerada a estrutura inicial do projeto e instaladas as dependências transitivas:

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

Sem configuração ou estruturas de pastas complicadas, apenas os arquivos necessários para construir seu app.<br>
Quando a instalação terminar, você pode abrir a pasta do seu projeto:

```sh
cd my-app
```

Dentro do projeto recém-criado, você pode executar alguns comandos embutidos:

### `npm start` ou `yarn start`

Roda o app em modo de desenvolvimento.<br>
Abra [http://localhost:3000](http://localhost:3000) para vê-lo no navegador.

A página recarregará automaticamente se você fizer alterações no código.<br>
Você verá erros de build e avisos de lint no console.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` ou `yarn test`

Roda o watcher de testes em modo interativo.<br>
Por padrão, executa testes relacionados a arquivos alterados desde o último commit.

[Leia mais sobre testes.](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` ou `yarn build`

Constrói o app para produção na pasta `build`.<br>
Empacota corretamente o React em modo produção e otimiza o build para melhor performance.

O build é minificado e os nomes de arquivos incluem hashes.<br>

Seu app está pronto para ser publicado.

## Guia do Usuário

Você pode encontrar instruções detalhadas sobre como usar o Create React App e várias dicas em [sua documentação](https://facebook.github.io/create-react-app/).

## Como Atualizar para Novas Versões?

Consulte o [Guia do Usuário](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) para isso e outras informações.

## Filosofia

- **Uma Dependência:** Há apenas uma dependência de build. Ele utiliza webpack, Babel, ESLint e outros projetos incríveis, mas proporciona uma experiência integrada e curada sobre eles.

- **Nenhuma Configuração Necessária:** Você não precisa configurar nada. Uma configuração razoavelmente boa para desenvolvimento e produção já é gerenciada para você, permitindo que foque em escrever código.

- **Sem Amarração:** Você pode "ejetar" para uma configuração personalizada a qualquer momento. Execute um único comando e toda a configuração e dependências de build serão movidas diretamente para o seu projeto, para que você possa continuar de onde parou.

## O Que Está Incluído?

Seu ambiente terá tudo que você precisa para criar um app React moderno de página única:

- Suporte a React, JSX, ES6, TypeScript e Flow.
- Extras de linguagem além do ES6, como o operador spread de objetos.
- CSS com autoprefixo, então você não precisa de `-webkit-` ou outros prefixos.
- Um runner de testes unitários interativo rápido, com suporte embutido para relatórios de cobertura.
- Um servidor de desenvolvimento ao vivo que alerta sobre erros comuns.
- Um script de build para empacotar JS, CSS e imagens para produção, com hashes e sourcemaps.
- Um [service worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) com prioridade offline e um [manifesto de web app](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/), atendendo a todos os critérios de uma [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app). (_Nota: O uso do service worker é opt-in a partir do `react-scripts@2.0.0`_)
- Atualizações sem complicação para as ferramentas acima com uma única dependência.

Veja [este guia](https://github.com/nitishdayal/cra_closer_look) para uma visão geral de como essas ferramentas funcionam juntas.

A contrapartida é que **essas ferramentas estão pré-configuradas para funcionar de uma maneira específica**. Se seu projeto precisa de mais customização, você pode ["ejetar"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) e personalizar, mas aí será necessário manter essa configuração.

## Alternativas Populares

O Create React App é ótimo para:

- **Aprender React** em um ambiente de desenvolvimento confortável e repleto de recursos.
- **Começar novas aplicações React de página única.**
- **Criar exemplos** com React para suas bibliotecas e componentes.

Aqui estão alguns casos comuns em que você pode preferir outras opções:

- Se você deseja **experimentar o React** sem centenas de dependências transitivas de ferramentas de build, considere [usar um único arquivo HTML ou um sandbox online](https://reactjs.org/docs/getting-started.html#try-react).

- Se você precisa **integrar código React com um framework de templates server-side** como Rails, Django ou Symfony, ou se você **não está criando um app de página única**, considere usar [nwb](https://github.com/insin/nwb) ou [Neutrino](https://neutrino.js.org/), que são mais flexíveis. Para Rails especificamente, você pode usar o [Rails Webpacker](https://github.com/rails/webpacker). Para Symfony, tente o [Encore do Symfony](https://symfony.com/doc/current/frontend/encore/reactjs.html).

- Se você precisa **publicar um componente React**, o [nwb](https://github.com/insin/nwb) [também faz isso](https://github.com/insin/nwb#react-components-and-libraries), assim como o [preset react-components do Neutrino](https://neutrino.js.org/packages/react-components/).

- Se você quer fazer **renderização no servidor** com React e Node.js, confira o [Next.js](https://nextjs.org/) ou o [Razzle](https://github.com/jaredpalmer/razzle). O Create React App é agnóstico quanto ao backend e só produz bundles estáticos de HTML/JS/CSS.

- Se seu site é **principalmente estático** (por exemplo, um portfólio ou blog), considere usar o [Gatsby](https://www.gatsbyjs.org/) ou o [Next.js](https://nextjs.org/). Diferente do Create React App, o Gatsby pré-renderiza o site em HTML no build. O Next.js suporta renderização no servidor e pré-renderização.

- Por fim, se você precisa de **mais personalização**, confira o [Neutrino](https://neutrino.js.org/) e seu [preset React](https://neutrino.js.org/packages/react/).

Todas as ferramentas acima funcionam com pouca ou nenhuma configuração.

Se preferir configurar o build manualmente, [siga este guia](https://reactjs.org/docs/add-react-to-a-website.html).

## React Native

Procurando algo similar para React Native?<br>
Veja o [Expo CLI](https://github.com/expo/expo-cli).

## Contribuindo

Adoraríamos sua ajuda no `create-react-app`! Veja [CONTRIBUTING.md](CONTRIBUTING.md) para mais informações sobre o que buscamos e como começar.

## Apoie o Create React App

O Create React App é um projeto mantido pela comunidade e todos os colaboradores são voluntários. Se você deseja apoiar o desenvolvimento futuro do Create React App, considere doar para nosso [Open Collective](https://opencollective.com/create-react-app).

## Créditos

Este projeto existe graças a todas as pessoas que [contribuem](CONTRIBUTING.md).<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

Obrigado à [Netlify](https://www.netlify.com/) por hospedar nossa documentação.

## Agradecimentos

Somos gratos aos autores dos projetos relacionados existentes por suas ideias e colaboração:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## Licença

O Create React App é um software de código aberto [licenciado como MIT](https://github.com/facebook/create-react-app/blob/main/LICENSE). O logo do Create React App é licenciado sob uma [Creative Commons Attribution 4.0 International license](https://creativecommons.org/licenses/by/4.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---