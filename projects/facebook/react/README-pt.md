# [React](https://react.dev/) &middot; [![Licença do GitHub](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![Versão npm](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React é uma biblioteca JavaScript para construir interfaces de usuário.

* **Declarativo:** O React torna fácil criar interfaces de usuário interativas. Projete visualizações simples para cada estado da sua aplicação, e o React atualizará e renderizará eficientemente apenas os componentes certos quando seus dados mudarem. Visualizações declarativas tornam seu código mais previsível, fácil de entender e de depurar.
* **Baseado em Componentes:** Construa componentes encapsulados que gerenciam seu próprio estado, depois componha-os para criar interfaces complexas. Como a lógica dos componentes é escrita em JavaScript em vez de templates, você pode facilmente passar dados avançados por toda a sua aplicação e manter o estado fora do DOM.
* **Aprenda Uma Vez, Escreva em Qualquer Lugar:** Não fazemos suposições sobre o restante da sua stack de tecnologia, então você pode desenvolver novas funcionalidades em React sem reescrever código existente. O React também pode renderizar no servidor usando [Node](https://nodejs.org/en) e potencializar aplicativos móveis usando [React Native](https://reactnative.dev/).

[Saiba como usar React em seu projeto](https://react.dev/learn).

## Instalação

O React foi projetado para adoção gradual desde o início, e **você pode usar o quanto quiser de React**:

* Use o [Guia Rápido](https://react.dev/learn) para experimentar o React.
* [Adicione React a um Projeto Existente](https://react.dev/learn/add-react-to-an-existing-project) para usar o quanto quiser de React.
* [Crie um Novo App React](https://react.dev/learn/start-a-new-react-project) se você procura uma ferramenta JavaScript poderosa.

## Documentação

Você pode encontrar a documentação do React [no site](https://react.dev/).

Confira a página [Primeiros Passos](https://react.dev/learn) para uma visão geral rápida.

A documentação está dividida em várias seções:

* [Guia Rápido](https://react.dev/learn)
* [Tutorial](https://react.dev/learn/tutorial-tic-tac-toe)
* [Pensando em React](https://react.dev/learn/thinking-in-react)
* [Instalação](https://react.dev/learn/installation)
* [Descrevendo a UI](https://react.dev/learn/describing-the-ui)
* [Adicionando Interatividade](https://react.dev/learn/adding-interactivity)
* [Gerenciando Estado](https://react.dev/learn/managing-state)
* [Guias Avançados](https://react.dev/learn/escape-hatches)
* [Referência da API](https://react.dev/reference/react)
* [Onde Obter Suporte](https://react.dev/community)
* [Guia de Contribuição](https://legacy.reactjs.org/docs/how-to-contribute.html)

Você pode melhorá-la enviando pull requests para [este repositório](https://github.com/reactjs/react.dev).

## Exemplos

Temos vários exemplos [no site](https://react.dev/). Aqui está o primeiro para você começar:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

Este exemplo irá renderizar "Hello Taylor" em um container na página.

Você notará que usamos uma sintaxe semelhante ao HTML; [nós a chamamos de JSX](https://react.dev/learn#writing-markup-with-jsx). JSX não é obrigatório para usar o React, mas torna o código mais legível e escrevê-lo se parece com escrever HTML.

## Contribuindo

O principal objetivo deste repositório é continuar evoluindo o núcleo do React, tornando-o mais rápido e fácil de usar. O desenvolvimento do React acontece de forma aberta no GitHub, e somos gratos à comunidade pelas correções de bugs e melhorias. Leia abaixo para saber como você pode participar da melhoria do React.

### [Código de Conduta](https://code.fb.com/codeofconduct)

O Facebook adotou um Código de Conduta que esperamos que os participantes do projeto sigam. Por favor, leia [o texto completo](https://code.fb.com/codeofconduct) para entender quais ações serão e não serão toleradas.

### [Guia de Contribuição](https://legacy.reactjs.org/docs/how-to-contribute.html)

Leia nosso [guia de contribuição](https://legacy.reactjs.org/docs/how-to-contribute.html) para aprender sobre nosso processo de desenvolvimento, como propor correções de bugs e melhorias, e como construir e testar suas alterações no React.

### [Boas Primeiras Issues](https://github.com/facebook/react/labels/good%20first%20issue)

Para ajudar você a começar e se familiarizar com nosso processo de contribuição, temos uma lista de [boas primeiras issues](https://github.com/facebook/react/labels/good%20first%20issue) que contêm bugs de escopo relativamente limitado. Este é um ótimo lugar para começar.

### Licença

React é licenciado sob a [licença MIT](./LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---