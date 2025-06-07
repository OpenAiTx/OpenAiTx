# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> Seja bem-vindo a participar para tornar o prompt flow melhor
> participando de [discussões](https://github.com/microsoft/promptflow/discussions),
> abrindo [issues](https://github.com/microsoft/promptflow/issues/new/choose),
> enviando [PRs](https://github.com/microsoft/promptflow/pulls).

**Prompt flow** é um conjunto de ferramentas de desenvolvimento projetadas para simplificar o ciclo de desenvolvimento de ponta a ponta de aplicações de IA baseadas em LLM, desde a ideação, prototipagem, testes, avaliação até a implantação e monitoramento em produção. Facilita a engenharia de prompts e permite construir aplicativos LLM com qualidade de produção.

Com o prompt flow, você poderá:

- **Criar e desenvolver fluxos iterativamente**
    - Crie [fluxos](https://microsoft.github.io/promptflow/concepts/concept-flows.html) executáveis que conectam LLMs, prompts, código Python e outras [ferramentas](https://microsoft.github.io/promptflow/concepts/concept-tools.html).
    - Depure e itere seus fluxos, especialmente [rastreamento de interações com LLMs](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) com facilidade.
- **Avaliar a qualidade e o desempenho do fluxo**
    - Avalie a qualidade e o desempenho do seu fluxo com conjuntos de dados maiores.
    - Integre os testes e avaliações ao seu sistema CI/CD para garantir a qualidade do seu fluxo.
- **Ciclo de desenvolvimento simplificado para produção**
    - Implemente seu fluxo na plataforma de serviço de sua escolha ou integre facilmente ao código do seu aplicativo.
    - (Opcional, mas altamente recomendado) Colabore com sua equipe aproveitando a versão em nuvem do [Prompt flow no Azure AI](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2).

------

## Instalação

Para começar rapidamente, você pode usar um ambiente de desenvolvimento pré-configurado. **Clique no botão abaixo** para abrir o repositório no GitHub Codespaces e continue lendo o readme!

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

Se desejar começar em seu ambiente local, primeiro instale os pacotes:

Certifique-se de ter um ambiente python, recomenda-se `python>=3.9, <=3.11`.

```sh
pip install promptflow promptflow-tools
```

## Início Rápido ⚡

**Crie um chatbot com prompt flow**

Execute o comando para iniciar um prompt flow a partir de um template de chat, que cria a pasta `my_chatbot` e gera os arquivos necessários dentro dela:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**Configure uma conexão para sua chave de API**

Para a chave OpenAI, estabeleça uma conexão executando o comando abaixo, usando o arquivo `openai.yaml` na pasta `my_chatbot`, que armazena sua chave OpenAI (substitua as chaves e o nome com --set para evitar alterações no arquivo yaml):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Para a chave Azure OpenAI, estabeleça a conexão executando o comando abaixo, usando o arquivo `azure_openai.yaml`:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**Converse com seu fluxo**

Na pasta `my_chatbot`, há um arquivo `flow.dag.yaml` que descreve o fluxo, incluindo entradas/saídas, nós, conexão, modelo LLM, etc.

> Observe que no nó `chat`, estamos usando uma conexão chamada `open_ai_connection` (especificada no campo `connection`) e o modelo `gpt-35-turbo` (especificado no campo `deployment_name`). O campo deployment_name serve para especificar o modelo OpenAI ou o recurso de implantação do Azure OpenAI.

Interaja com seu chatbot executando: (pressione `Ctrl + C` para encerrar a sessão)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**Valor central: garantir "Alta Qualidade" do protótipo à produção**

Explore nosso [**tutorial de 15 minutos**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md) que orienta você pelo ajuste de prompt ➡ testes em lote ➡ avaliação, tudo projetado para garantir alta qualidade pronta para produção.

Próximo passo! Continue na seção **Tutorial** 👇 para se aprofundar no prompt flow.

## Tutorial 🏃‍♂️

Prompt flow é uma ferramenta projetada para **construir aplicativos LLM de alta qualidade**, e o processo de desenvolvimento segue estas etapas: desenvolver um fluxo, melhorar a qualidade do fluxo, implantar o fluxo em produção.

### Desenvolva seus próprios aplicativos LLM

#### Extensão para VS Code

Também oferecemos uma extensão para o VS Code (um designer de fluxos) para uma experiência interativa de desenvolvimento de fluxos com interface gráfica.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

Você pode instalá-la no <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">marketplace do Visual Studio</a>.

#### Aprofunde-se no desenvolvimento de fluxos

[Começando com prompt flow](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): Um guia passo a passo para executar seu primeiro fluxo.

### Aprenda com casos de uso

[Tutorial: Chat com PDF](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): Um tutorial de ponta a ponta sobre como construir um aplicativo de chat de alta qualidade com prompt flow, incluindo desenvolvimento do fluxo e avaliação com métricas.
> Mais exemplos podem ser encontrados [aqui](https://microsoft.github.io/promptflow/tutorials/index.html#samples). Contribuições de novos casos de uso são bem-vindas!

### Configuração para colaboradores

Se você deseja contribuir, comece com nosso guia de configuração de desenvolvimento: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md).

Próximo passo! Continue na seção **Contribuindo** 👇 para contribuir com o prompt flow.

## Contribuindo

Este projeto recebe contribuições e sugestões. A maioria das contribuições exige que você concorde com um
Contrato de Licença de Colaborador (CLA), declarando que você tem o direito de, e realmente concede,
os direitos de uso da sua contribuição. Para detalhes, visite https://cla.opensource.microsoft.com.

Ao enviar um pull request, um bot de CLA determinará automaticamente se você precisa fornecer
um CLA e marcará o PR apropriadamente (por exemplo, status check, comentário). Basta seguir as instruções
fornecidas pelo bot. Você só precisará fazer isso uma vez em todos os repositórios que usam nosso CLA.

Este projeto adotou o [Código de Conduta de Código Aberto da Microsoft](https://opensource.microsoft.com/codeofconduct/).
Para mais informações, consulte o [FAQ do Código de Conduta](https://opensource.microsoft.com/codeofconduct/faq/) ou
entre em contato com [opencode@microsoft.com](mailto:opencode@microsoft.com) para quaisquer dúvidas ou comentários adicionais.

## Marcas Registradas

Este projeto pode conter marcas registradas ou logotipos de projetos, produtos ou serviços. O uso autorizado de marcas ou logotipos da Microsoft está sujeito e deve seguir as
[Diretrizes de Marca Registrada e Marca da Microsoft](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
O uso de marcas ou logotipos da Microsoft em versões modificadas deste projeto não deve causar confusão ou sugerir patrocínio da Microsoft.
Qualquer uso de marcas ou logotipos de terceiros está sujeito às políticas desses terceiros.

## Código de Conduta

Este projeto adotou o
[Código de Conduta de Código Aberto da Microsoft](https://opensource.microsoft.com/codeofconduct/).
Para mais informações, consulte o
[FAQ do Código de Conduta](https://opensource.microsoft.com/codeofconduct/faq/)
ou entre em contato com [opencode@microsoft.com](mailto:opencode@microsoft.com)
para quaisquer dúvidas ou comentários adicionais.

## Coleta de Dados

O software pode coletar informações sobre você e seu uso do software e
enviá-las à Microsoft se configurado para habilitar a telemetria.
A Microsoft pode usar essas informações para fornecer serviços e melhorar nossos produtos e serviços.
Você pode ativar a telemetria conforme descrito no repositório.
Há também alguns recursos no software que podem permitir que você e a Microsoft
coletar dados dos usuários de suas aplicações. Se você usar esses recursos, você
deve cumprir a legislação aplicável, incluindo fornecer avisos apropriados aos
usuários de suas aplicações juntamente com uma cópia da declaração de privacidade da Microsoft.
Nossa declaração de privacidade está localizada em
https://go.microsoft.com/fwlink/?LinkID=824704. Você pode saber mais sobre a coleta
e uso de dados na documentação de ajuda e em nossa declaração de privacidade. O uso
do software implica seu consentimento para essas práticas.

### Configuração de Telemetria

A coleta de telemetria está ativada por padrão.

Para desativar, execute `pf config set telemetry.enabled=false` para desligar.

## Licença

Copyright (c) Microsoft Corporation. Todos os direitos reservados.

Licenciado sob a licença [MIT](LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---