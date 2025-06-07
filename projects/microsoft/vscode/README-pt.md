# Visual Studio Code - Open Source ("Code - OSS")

[![Solicitações de Recursos](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![Bugs](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## O Repositório

Este repositório ("`Code - OSS`") é onde nós (Microsoft) desenvolvemos o produto [Visual Studio Code](https://code.visualstudio.com) junto com a comunidade. Aqui, além de trabalharmos no código e nas issues, também publicamos nosso [roteiro](https://github.com/microsoft/vscode/wiki/Roadmap), [planos de iteração mensal](https://github.com/microsoft/vscode/wiki/Iteration-Plans) e nossos [planos de finalização](https://github.com/microsoft/vscode/wiki/Running-the-Endgame). Este código-fonte está disponível para todos sob a licença padrão [MIT](https://github.com/microsoft/vscode/blob/main/LICENSE.txt).

## Visual Studio Code

<p align="center">
  <img alt="VS Code em ação" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

O [Visual Studio Code](https://code.visualstudio.com) é uma distribuição do repositório `Code - OSS` com personalizações específicas da Microsoft lançadas sob uma [licença tradicional de produto da Microsoft](https://code.visualstudio.com/License/).

O [Visual Studio Code](https://code.visualstudio.com) combina a simplicidade de um editor de código com o que os desenvolvedores precisam para seu ciclo principal de editar-compilar-depurar. Ele oferece edição de código abrangente, navegação e suporte à compreensão, juntamente com depuração leve, um rico modelo de extensibilidade e integração leve com ferramentas existentes.

O Visual Studio Code é atualizado mensalmente com novos recursos e correções de bugs. Você pode baixá-lo para Windows, macOS e Linux no [site do Visual Studio Code](https://code.visualstudio.com/Download). Para obter as versões mais recentes diariamente, instale a [versão Insiders](https://code.visualstudio.com/insiders).

## Contribuindo

Há várias maneiras de participar deste projeto, por exemplo:

* [Enviar bugs e solicitações de recursos](https://github.com/microsoft/vscode/issues), e nos ajudar a verificar conforme são resolvidos
* Revisar [alterações no código-fonte](https://github.com/microsoft/vscode/pulls)
* Revisar a [documentação](https://github.com/microsoft/vscode-docs) e fazer pull requests para qualquer coisa, desde erros de digitação até conteúdo adicional e novo

Se você estiver interessado em corrigir issues e contribuir diretamente para a base de código,
consulte o documento [Como Contribuir](https://github.com/microsoft/vscode/wiki/How-to-Contribute), que aborda o seguinte:

* [Como compilar e executar a partir do código-fonte](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [O fluxo de trabalho de desenvolvimento, incluindo depuração e execução de testes](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [Diretrizes de codificação](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [Como enviar pull requests](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [Como encontrar uma issue para trabalhar](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [Contribuindo com traduções](https://aka.ms/vscodeloc)

## Feedback

* Faça uma pergunta no [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode)
* [Solicite um novo recurso](CONTRIBUTING.md)
* Vote em [solicitações de recursos populares](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
* [Reporte um problema](https://github.com/microsoft/vscode/issues)
* Conecte-se com a comunidade de autores de extensões em [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions) ou [Slack](https://aka.ms/vscode-dev-community)
* Siga [@code](https://twitter.com/code) e nos diga o que você acha!

Veja nosso [wiki](https://github.com/microsoft/vscode/wiki/Feedback-Channels) para uma descrição de cada um desses canais e informações sobre outros canais disponíveis conduzidos pela comunidade.

## Projetos Relacionados

Muitos dos componentes centrais e extensões do VS Code vivem em seus próprios repositórios no GitHub. Por exemplo, os repositórios [node debug adapter](https://github.com/microsoft/vscode-node-debug) e [mono debug adapter](https://github.com/microsoft/vscode-mono-debug) são separados entre si. Para uma lista completa, visite a página de [Projetos Relacionados](https://github.com/microsoft/vscode/wiki/Related-Projects) em nosso [wiki](https://github.com/microsoft/vscode/wiki).

## Extensões Inclusas

O VS Code inclui um conjunto de extensões internas localizadas na pasta [extensions](extensions), incluindo gramáticas e trechos de código para várias linguagens. Extensões que fornecem suporte avançado de linguagem (autocompletar, Ir para Definição) para uma linguagem têm o sufixo `language-features`. Por exemplo, a extensão `json` fornece destaque de sintaxe para `JSON` e a extensão `json-language-features` fornece suporte avançado de linguagem para `JSON`.

## Contêiner de Desenvolvimento

Este repositório inclui um contêiner de desenvolvimento Visual Studio Code Dev Containers / GitHub Codespaces.

* Para [Dev Containers](https://aka.ms/vscode-remote/download/containers), use o comando **Dev Containers: Clone Repository in Container Volume...**, que cria um volume Docker para melhor I/O de disco no macOS e Windows.
  * Se você já possui o VS Code e Docker instalados, também pode clicar [aqui](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode) para começar. Isso fará com que o VS Code instale automaticamente a extensão Dev Containers, se necessário, clone o código-fonte em um volume de contêiner e inicie um contêiner de desenvolvimento para uso.

* Para Codespaces, instale a extensão [GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces) no VS Code e use o comando **Codespaces: Create New Codespace**.

O Docker / Codespace deve ter pelo menos **4 núcleos e 6 GB de RAM (8 GB recomendados)** para executar a build completa. Veja o [README do contêiner de desenvolvimento](.devcontainer/README.md) para mais informações.

## Código de Conduta

Este projeto adotou o [Código de Conduta de Código Aberto da Microsoft](https://opensource.microsoft.com/codeofconduct/). Para mais informações, veja o [FAQ do Código de Conduta](https://opensource.microsoft.com/codeofconduct/faq/) ou entre em contato pelo [opencode@microsoft.com](mailto:opencode@microsoft.com) para dúvidas ou comentários adicionais.

## Licença

Copyright (c) Microsoft Corporation. Todos os direitos reservados.

Licenciado sob a licença [MIT](LICENSE.txt).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---