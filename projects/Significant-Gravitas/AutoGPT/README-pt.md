# AutoGPT: Construa, Implemente e Execute Agentes de IA

[![Discord Follow](https://dcbadge.vercel.app/api/server/autogpt?style=flat)](https://discord.gg/autogpt) &ensp;
[![Twitter Follow](https://img.shields.io/twitter/follow/Auto_GPT?style=social)](https://twitter.com/Auto_GPT) &ensp;
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**AutoGPT** é uma plataforma poderosa que permite criar, implementar e gerenciar agentes de IA contínuos que automatizam fluxos de trabalho complexos.

## Opções de Hospedagem 
   - Baixe para hospedar por conta própria
   - [Entre na lista de espera](https://bit.ly/3ZDijAI) para o beta hospedado na nuvem  

## Como Configurar para Auto-Hospedagem
> [!NOTA]
> Configurar e hospedar a Plataforma AutoGPT por conta própria é um processo técnico. 
> Se preferir algo que funcione imediatamente, recomendamos [entrar na lista de espera](https://bit.ly/3ZDijAI) para o beta hospedado na nuvem.

### Requisitos do Sistema

Antes de prosseguir com a instalação, certifique-se de que seu sistema atenda aos seguintes requisitos:

#### Requisitos de Hardware
- CPU: 4+ núcleos recomendados
- RAM: Mínimo de 8GB, 16GB recomendado
- Armazenamento: Pelo menos 10GB de espaço livre

#### Requisitos de Software
- Sistemas Operacionais:
  - Linux (Ubuntu 20.04 ou mais recente recomendado)
  - macOS (10.15 ou mais recente)
  - Windows 10/11 com WSL2
- Softwares Necessários (com versões mínimas):
  - Docker Engine (20.10.0 ou mais recente)
  - Docker Compose (2.0.0 ou mais recente)
  - Git (2.30 ou mais recente)
  - Node.js (16.x ou mais recente)
  - npm (8.x ou mais recente)
  - VSCode (1.60 ou mais recente) ou qualquer editor de código moderno

#### Requisitos de Rede
- Conexão de internet estável
- Acesso às portas necessárias (serão configuradas no Docker)
- Capacidade de realizar conexões HTTPS de saída

### Instruções de Configuração Atualizadas:
Migramos para um site de documentação totalmente mantido e atualizado regularmente.

👉 [Siga o guia oficial de auto-hospedagem aqui](https://docs.agpt.co/platform/getting-started/)

Este tutorial assume que você já possui Docker, VSCode, git e npm instalados.

### 🧱 AutoGPT Frontend

O frontend do AutoGPT é onde os usuários interagem com nossa poderosa plataforma de automação de IA. Ele oferece várias formas de engajar e aproveitar nossos agentes de IA. Esta é a interface onde você dará vida às suas ideias de automação de IA:

   **Construtor de Agentes:** Para quem deseja personalizar, nossa interface intuitiva e de baixo código permite projetar e configurar seus próprios agentes de IA. 
   
   **Gestão de Fluxos de Trabalho:** Construa, modifique e otimize seus fluxos de automação com facilidade. Você cria seu agente conectando blocos, onde cada bloco executa uma única ação.
   
   **Controles de Implantação:** Gerencie o ciclo de vida de seus agentes, do teste à produção.
   
   **Agentes Prontos para Uso:** Não quer construir? Basta selecionar em nossa biblioteca de agentes pré-configurados e colocá-los para trabalhar imediatamente.
   
   **Interação com Agentes:** Seja você quem construiu ou esteja usando agentes pré-configurados, execute e interaja facilmente com eles por meio de nossa interface amigável.

   **Monitoramento e Análise:** Acompanhe o desempenho de seus agentes e obtenha insights para melhorar continuamente seus processos de automação.

[Leia este guia](https://docs.agpt.co/platform/new_blocks/) para aprender a construir seus próprios blocos personalizados.

### 💽 AutoGPT Server

O Servidor AutoGPT é o núcleo da nossa plataforma. É aqui que seus agentes são executados. Uma vez implantados, os agentes podem ser acionados por fontes externas e operar continuamente. Ele contém todos os componentes essenciais que fazem o AutoGPT funcionar sem problemas.

   **Código Fonte:** A lógica central que impulsiona nossos agentes e processos de automação.
   
   **Infraestrutura:** Sistemas robustos que garantem desempenho confiável e escalável.
   
   **Marketplace:** Um marketplace abrangente onde você pode encontrar e implantar uma ampla gama de agentes pré-construídos.

### 🐙 Exemplos de Agentes

Aqui estão dois exemplos do que você pode fazer com o AutoGPT:

1. **Gerar Vídeos Virais a partir de Tópicos em Alta**
   - Este agente lê tópicos no Reddit.
   - Identifica tópicos em tendência.
   - Em seguida, cria automaticamente um vídeo de formato curto com base no conteúdo. 

2. **Identificar as Melhores Frases de Vídeos para Redes Sociais**
   - Este agente assina seu canal do YouTube.
   - Quando você publica um novo vídeo, ele faz a transcrição.
   - Usa IA para identificar as citações mais impactantes e gerar um resumo.
   - Depois, escreve uma publicação para publicar automaticamente em suas redes sociais. 

Esses exemplos mostram apenas uma amostra do que você pode alcançar com o AutoGPT! Você pode criar fluxos de trabalho personalizados para construir agentes para qualquer caso de uso.

---
### Missão e Licenciamento
Nossa missão é fornecer as ferramentas para que você possa focar no que importa:

- 🏗️ **Construir** - Lançar as bases para algo incrível.
- 🧪 **Testar** - Aperfeiçoe seu agente até a perfeição.
- 🤝 **Delegar** - Deixe a IA trabalhar por você e dê vida às suas ideias.

Faça parte da revolução! **AutoGPT** veio para ficar, na vanguarda da inovação em IA.

**📖 [Documentação](https://docs.agpt.co)**
&ensp;|&ensp;
**🚀 [Contribuindo](CONTRIBUTING.md)**

**Licenciamento:**

Licença MIT: A maior parte do repositório AutoGPT está sob a Licença MIT.

Licença Polyform Shield: Esta licença se aplica à pasta autogpt_platform.

Para mais informações, veja https://agpt.co/blog/introducing-the-autogpt-platform

---
## 🤖 AutoGPT Clássico
> Abaixo estão informações sobre a versão clássica do AutoGPT.

**🛠️ [Construa seu próprio Agente - Guia Rápido](classic/FORGE-QUICKSTART.md)**

### 🏗️ Forge

**Forje seu próprio agente!** &ndash; Forge é um kit de ferramentas pronto para construir sua própria aplicação de agente. Ele lida com a maior parte do código padrão, permitindo que você concentre toda sua criatividade nas características que tornam *seu* agente único. Todos os tutoriais estão localizados [aqui](https://medium.com/@aiedge/autogpt-forge-e3de53cc58ec). Componentes do [`forge`](/classic/forge/) também podem ser usados individualmente para acelerar o desenvolvimento e reduzir o código padrão em seu projeto de agente.

🚀 [**Primeiros Passos com Forge**](https://github.com/Significant-Gravitas/AutoGPT/blob/master/classic/forge/tutorials/001_getting_started.md) &ndash;
Este guia irá conduzi-lo pelo processo de criação do seu próprio agente e utilização do benchmark e da interface do usuário.

📘 [Saiba Mais](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/forge) sobre o Forge

### 🎯 Benchmark

**Meça o desempenho do seu agente!** O `agbenchmark` pode ser usado com qualquer agente que suporte o protocolo de agente, e a integração com o [CLI] do projeto facilita ainda mais o uso com AutoGPT e agentes baseados no forge. O benchmark oferece um ambiente de teste rigoroso. Nosso framework permite avaliações autônomas e objetivas de desempenho, garantindo que seus agentes estejam prontos para ação no mundo real.

<!-- TODO: inserir visual demonstrando o benchmark -->

📦 [`agbenchmark`](https://pypi.org/project/agbenchmark/) no Pypi
&ensp;|&ensp;
📘 [Saiba Mais](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/benchmark) sobre o Benchmark

### 💻 UI

**Facilita o uso dos agentes!** O `frontend` oferece uma interface amigável para controlar e monitorar seus agentes. Ele se conecta aos agentes através do [protocolo de agente](#-agent-protocol), garantindo compatibilidade com muitos agentes tanto de dentro quanto de fora do nosso ecossistema.

<!-- TODO: inserir captura de tela da interface -->

O frontend funciona imediatamente com todos os agentes do repositório. Basta usar o [CLI] para executar o agente de sua escolha!

📘 [Saiba Mais](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/frontend) sobre o Frontend

### ⌨️ CLI

[CLI]: #-cli

Para tornar o uso de todas as ferramentas oferecidas pelo repositório o mais fácil possível, um CLI está incluído na raiz do repositório:

```shell
$ ./run
Usage: cli.py [OPTIONS] COMMAND [ARGS]...

Options:
  --help  Show this message and exit.

Commands:
  agent      Commands to create, start and stop agents
  benchmark  Commands to start the benchmark and list tests and categories
  setup      Installs dependencies needed for your system.
```

Basta clonar o repositório, instalar as dependências com `./run setup`, e estará pronto para começar!

## 🤔 Dúvidas? Problemas? Sugestões?

### Obtenha ajuda - [Discord 💬](https://discord.gg/autogpt)

[![Junte-se a nós no Discord](https://invidget.switchblade.xyz/autogpt)](https://discord.gg/autogpt)

Para relatar um bug ou solicitar um recurso, crie uma [Issue no GitHub](https://github.com/Significant-Gravitas/AutoGPT/issues/new/choose). Por favor, certifique-se de que ninguém já criou uma issue para o mesmo assunto.

## 🤝 Projetos Irmãos

### 🔄 Protocolo de Agentes

Para manter um padrão uniforme e garantir compatibilidade perfeita com muitas aplicações atuais e futuras, o AutoGPT utiliza o padrão [agent protocol](https://agentprotocol.ai/) da AI Engineer Foundation. Isso padroniza os caminhos de comunicação do seu agente com o frontend e o benchmark.

---

## Estatísticas de estrelas

<p align="center">
<a href="https://star-history.com/#Significant-Gravitas/AutoGPT">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
  </picture>
</a>
</p>


## ⚡ Contribuidores

<a href="https://github.com/Significant-Gravitas/AutoGPT/graphs/contributors" alt="View Contributors">
  <img src="https://contrib.rocks/image?repo=Significant-Gravitas/AutoGPT&max=1000&columns=10" alt="Contributors" />
</a>


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---