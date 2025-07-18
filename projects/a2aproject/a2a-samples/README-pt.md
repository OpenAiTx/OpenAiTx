# Exemplos Agent2Agent (A2A)

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

Este repositório contém exemplos de código e demonstrações que utilizam o [Protocolo Agent2Agent (A2A)](https://goo.gle/a2a).

## Repositórios Relacionados

- [A2A](https://github.com/a2aproject/A2A) - Especificação e documentação do A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK Python do A2A.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - Ferramenta UI para inspecionar agentes habilitados para A2A.

## Contribuindo

Contribuições são bem-vindas! Veja o [Guia de Contribuição](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Obtendo ajuda

Por favor, use a [página de issues](https://github.com/a2aproject/a2a-samples/issues) para enviar sugestões, feedback ou relatar um bug.

## Aviso Legal

Este repositório não é um produto oficialmente suportado pelo Google. O código neste repositório é apenas para fins demonstrativos.

Importante: O código de exemplo fornecido é apenas para demonstração e ilustra a mecânica do protocolo Agent-to-Agent (A2A). Ao construir aplicações de produção, é fundamental tratar qualquer agente que opere fora do seu controle direto como uma entidade potencialmente não confiável.

Todos os dados recebidos de um agente externo—incluindo, mas não se limitando ao seu AgentCard, mensagens, artefatos e status de tarefas—devem ser tratados como entrada não confiável. Por exemplo, um agente malicioso pode fornecer um AgentCard contendo dados manipulados em seus campos (por exemplo, descrição, nome, skills.description). Se esses dados forem usados sem sanitização para construir prompts para um Modelo de Linguagem de Grande Escala (LLM), sua aplicação pode ficar exposta a ataques de injeção de prompt. Não validar e sanitizar adequadamente esses dados antes do uso pode introduzir vulnerabilidades de segurança em sua aplicação.

Os desenvolvedores são responsáveis por implementar medidas de segurança adequadas, como validação de entrada e tratamento seguro de credenciais para proteger seus sistemas e usuários.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---