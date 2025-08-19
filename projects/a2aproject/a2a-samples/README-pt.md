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

Este repositório contém exemplos de código e demonstrações que utilizam o [Protocolo Agent2Agent (A2A)](https://goo.gle/a2a).

## Repositórios Relacionados

- [A2A](https://github.com/a2aproject/A2A) - Especificação e documentação do A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK Python para A2A.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - Ferramenta UI para inspeção de agentes habilitados para A2A.

## Contribuindo

Contribuições são bem-vindas! Veja o [Guia de Contribuição](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Obtendo ajuda

Por favor, utilize a [página de issues](https://github.com/a2aproject/a2a-samples/issues) para sugestões, feedback ou para relatar bugs.

## Aviso

Este repositório não é um produto oficialmente suportado pelo Google. O código nele contido é apenas para fins demonstrativos.

Importante: O código de exemplo fornecido é para fins de demonstração e ilustra a mecânica do protocolo Agent-to-Agent (A2A). Ao desenvolver aplicações para produção, é fundamental tratar qualquer agente fora do seu controle direto como uma entidade potencialmente não confiável.

Todos os dados recebidos de um agente externo—incluindo, mas não se limitando ao AgentCard, mensagens, artefatos e status de tarefas—devem ser tratados como entrada não confiável. Por exemplo, um agente malicioso pode fornecer um AgentCard contendo dados manipulados em seus campos (ex.: descrição, nome, skills.description). Se esses dados forem usados sem sanitização para construir prompts para um Modelo de Linguagem de Grande Porte (LLM), isso pode expor sua aplicação a ataques de injeção de prompt. Falhar em validar e sanitizar adequadamente esses dados antes do uso pode introduzir vulnerabilidades de segurança na sua aplicação.

Os desenvolvedores são responsáveis por implementar medidas de segurança adequadas, como validação de entrada e tratamento seguro de credenciais para proteger seus sistemas e usuários.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---