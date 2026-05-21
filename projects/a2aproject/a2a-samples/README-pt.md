# Exemplos Agent2Agent (A2A)

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="Experimente no Firebase Studio"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 Idioma</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
    </div>
  </details>
</div>

Bem-vindo aos exemplos oficiais de código e demonstrações do [Protocolo Agent2Agent (A2A)](https://goo.gle/a2a).

Estamos muito felizes em ter você aqui! Seja explorando arquiteturas multiagente pela primeira vez ou construindo redes avançadas de agentes interoperáveis, este repositório oferece recursos de aprendizado simples, inspiradores e acessíveis para acelerar o seu desenvolvimento.

## Por que Agent2Agent?

Em um mundo de diversos frameworks e ecossistemas de IA, os agentes precisam de uma linguagem comum para se comunicar, colaborar e delegar tarefas com segurança. O protocolo A2A estabelece um padrão aberto e padronizado para interoperabilidade entre múltiplos agentes.

Nossos exemplos demonstram como problemas complexos de múltiplos agentes podem ser resolvidos facilmente entre diferentes linguagens e aplicações hospedeiras.

## Início Rápido

Comece imediatamente lançando um agente Helloworld e comunicando-se com ele através do nosso host CLI Python.

1. **Inicie o Servidor de Agentes**:
   Abra um terminal e inicie o servidor do agente Helloworld:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **Execute o Cliente Host**:
   Abra um segundo terminal e execute o cliente CLI para enviar uma tarefa ao agente:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## Estrutura do Repositório

O repositório está organizado em vários diretórios principais por linguagem:

| Diretório | Descrição |
| --- | --- |
| [samples](/samples) | Exemplos principais de A2A organizados por linguagem de programação. |
| [samples/python](/samples/python) | Demonstra implementações de agentes Python usando o SDK Python do A2A. |
| [samples/go](/samples/go) | Demonstra implementações de agentes Go usando o SDK Go do A2A. |
| [samples/dotnet](/samples/dotnet) | Demonstra implementações de agentes C# usando o SDK .NET do A2A. |
| [samples/java](/samples/java) | Demonstra implementações de agentes Java usando o SDK Java do A2A. |
| [samples/js](/samples/js) | Demonstra implementações de agentes Node.js usando o SDK JavaScript do A2A. |

## Contribuindo

Agradecemos e incentivamos contribuições de todos os níveis de habilidade! Se você tem uma ideia para um novo exemplo, uma correção de bug ou uma melhoria na documentação, confira nosso [Guia de Contribuição](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Obtendo Ajuda

Estamos comprometidos em fornecer uma comunidade acolhedora e de apoio. Se você tiver dúvidas, feedback ou encontrar algum problema, entre em contato em nossa [página de issues](https://github.com/a2aproject/a2a-samples/issues).

## Repositórios Relacionados

| Repositório | Categoria | Descrição |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | Especificação Principal | Especificação e documentação do A2A. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | Ferramentas | Ferramenta UI para inspecionar agentes habilitados para A2A. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | Testes | Suíte de testes para validar conformidade com o Protocolo A2A. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | Testes | Kit de ferramentas para verificar compatibilidade entre diferentes implementações e versões de SDK A2A usando modelo de travessia multi-hop e diversos protocolos de transporte. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | SDK oficial Python para A2A. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | SDK oficial Go para A2A. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | SDK oficial Java para A2A. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | SDK oficial Node.js/JavaScript para A2A. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | SDK oficial C#/.NET para A2A. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | SDK oficial Rust para A2A. |

## Aviso Legal

**Importante:** O código de exemplo fornecido é apenas para fins de demonstração e ilustra a mecânica do
Protocolo Agente-para-Agente (A2A). Ao construir aplicações em produção, é fundamental tratar qualquer agente
operando fora do seu controle direto como uma entidade potencialmente não confiável.

Todos os dados recebidos de um agente externo—including mas não se limitando ao seu AgentCard, mensagens,
artefatos e status de tarefas—devem ser tratados como entrada não confiável. Por exemplo, um agente malicioso
poderia fornecer um AgentCard contendo dados manipulados em seus campos (por exemplo, descrição, nome,
skills.description). Se esses dados forem usados sem sanitização para construir prompts para um
Modelo de Linguagem de Grande Porte (LLM), isso pode expor sua aplicação a ataques de injeção de prompt. A falha em
validar e sanitizar adequadamente esses dados antes do uso pode introduzir vulnerabilidades de segurança em
sua aplicação.

> Desenvolvedores são responsáveis por implementar medidas de segurança apropriadas, como validação de entrada
> e tratamento seguro de credenciais para proteger seus sistemas e usuários.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---