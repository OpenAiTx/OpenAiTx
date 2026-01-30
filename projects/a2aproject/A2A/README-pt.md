# Protocolo Agent2Agent (A2A)

[![PyPI - Versão](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Licença Apache](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 Idioma</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Logotipo do Protocolo Agent2Agent" width="100">
    <h1>Protocolo Agent2Agent (A2A)</h1>
  </div>
</div>

**Um protocolo aberto que permite comunicação e interoperabilidade entre aplicações agênticas opacas.**

O protocolo Agent2Agent (A2A) aborda um desafio crítico no cenário de IA: possibilitar que agentes de IA generativos, construídos em diferentes frameworks por diversas empresas e executados em servidores separados, possam se comunicar e colaborar de forma eficaz – como agentes, não apenas como ferramentas. O objetivo do A2A é fornecer uma linguagem comum para agentes, promovendo um ecossistema de IA mais interconectado, poderoso e inovador.

Com o A2A, os agentes podem:

- Descobrir as capacidades uns dos outros.
- Negociar modalidades de interação (texto, formulários, mídia).
- Colaborar com segurança em tarefas de longa duração.
- Operar sem expor seu estado interno, memória ou ferramentas.

## Vídeo de Introdução ao A2A

[![Vídeo de Introdução ao A2A](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## Por que o A2A?

À medida que os agentes de IA se tornam mais comuns, sua capacidade de interoperar é crucial para construir aplicações complexas e multifuncionais. O A2A tem como objetivo:

- **Quebrar Barreiras:** Conectar agentes de diferentes ecossistemas.
- **Permitir Colaboração Complexa:** Permitir que agentes especializados trabalhem juntos em tarefas que um único agente não conseguiria resolver sozinho.
- **Promover Padrões Abertos:** Estimular uma abordagem orientada pela comunidade para a comunicação entre agentes, incentivando inovação e ampla adoção.
- **Preservar Opacidade:** Permitir que agentes colaborem sem precisar compartilhar memória interna, lógica proprietária ou implementações específicas de ferramentas, aumentando a segurança e protegendo a propriedade intelectual.

### Principais Características

- **Comunicação Padronizada:** JSON-RPC 2.0 sobre HTTP(S).
- **Descoberta de Agentes:** Por meio de "Cartões de Agente" detalhando capacidades e informações de conexão.
- **Interação Flexível:** Suporta requisição/resposta síncrona, streaming (SSE) e notificações push assíncronas.
- **Troca Rica de Dados:** Manipula texto, arquivos e dados JSON estruturados.
- **Pronto para Empresas:** Projetado com foco em segurança, autenticação e observabilidade.

## Primeiros Passos
- 📚 **Explore a Documentação:** Visite o [Site de Documentação do Protocolo Agent2Agent](https://a2a-protocol.org) para uma visão completa, especificação do protocolo, tutoriais e guias.
- 📝 **Veja a Especificação:** [Especificação do Protocolo A2A](https://a2a-protocol.org/latest/specification/)
- Use os SDKs:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) usando maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) usando [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Use nossos [exemplos](https://github.com/a2aproject/a2a-samples) para ver o A2A em ação

## Contribuindo

Agradecemos contribuições da comunidade para aprimorar e evoluir o protocolo A2A!

- **Perguntas & Discussões:** Participe das nossas [Discussões no GitHub](https://github.com/a2aproject/A2A/discussions).
- **Problemas & Feedback:** Relate problemas ou sugira melhorias via [Issues do GitHub](https://github.com/a2aproject/A2A/issues).
- **Guia de Contribuição:** Veja nosso [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) para detalhes sobre como contribuir.
- **Feedback Privado:** Use este [Formulário do Google](https://goo.gle/a2a-feedback).
- **Programa de Parceiros:** Clientes Google Cloud podem entrar no programa de parceiros através deste [formulário](https://goo.gle/a2a-partner).

## O que vem a seguir

### Melhorias no Protocolo

- **Descoberta de Agentes:**
    - Formalizar a inclusão de esquemas de autorização e credenciais opcionais diretamente no `AgentCard`.
- **Colaboração entre Agentes:**
    - Investigar um método `QuerySkill()` para verificar dinamicamente habilidades não suportadas ou não antecipadas.
- **Ciclo de Vida da Tarefa & UX:**
    - Suporte à negociação dinâmica de UX _dentro_ de uma tarefa (ex.: agente adicionando áudio/vídeo durante a conversa).
- **Métodos do Cliente & Transporte:**
    - Explorar extensão de suporte a métodos iniciados pelo cliente (além do gerenciamento de tarefas).
    - Melhorias na confiabilidade do streaming e nos mecanismos de notificação push.

## Sobre

O Protocolo A2A é um projeto open source sob a Linux Foundation, contribuído pelo Google. É licenciado sob a [Licença Apache 2.0](LICENSE) e aberto a contribuições da comunidade.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---