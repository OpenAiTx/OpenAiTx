# Especificação do Protocolo Universal de Chamada de Ferramentas (UTCP)

Este repositório contém a documentação oficial da especificação do Protocolo Universal de Chamada de Ferramentas (UTCP). O UTCP é um padrão moderno, flexível e escalável para definir e interagir com ferramentas através de vários protocolos de comunicação.

## O que é o UTCP?

O UTCP fornece uma maneira padronizada para sistemas de IA e outros clientes descobrirem e acionarem ferramentas de diferentes provedores, independentemente do protocolo subjacente utilizado (HTTP, WebSocket, CLI, etc.). Esta especificação define:

- Mecanismos de descoberta de ferramentas
- Formatos de chamada de ferramentas
- Configuração do provedor
- Métodos de autenticação
- Manipulação de respostas

## Contribuindo para a Especificação

Agradecemos contribuições para a especificação UTCP! Veja como você pode contribuir:

1. **Faça um fork do repositório**: Crie seu próprio fork do repositório da especificação
2. **Faça suas alterações**: Atualize ou adicione documentação conforme necessário
3. **Envie um pull request**: Abra um PR com suas alterações para revisão
4. **Participe das discussões**: Junte-se à conversa sobre as mudanças propostas

Ao contribuir, siga estas diretrizes:

- Certifique-se de que suas alterações estejam alinhadas com a visão e os objetivos gerais do UTCP
- Siga a estrutura e a formatação estabelecidas da documentação
- Inclua exemplos ao adicionar novos recursos ou conceitos
- Atualize as seções relevantes para manter a consistência em toda a documentação

## Construindo a Documentação Localmente

### Pré-requisitos

Para construir e visualizar o site da documentação localmente, você precisará de:

- Ruby versão 2.5.0 ou superior
- RubyGems
- Bundler

### Configuração

1. Clone o repositório:
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. Instale as dependências:

   ```bash
   bundle install
   ```
### Executando o Site de Documentação

Para compilar e servir o site localmente:


```bash
bundle exec jekyll serve
```
Isso iniciará um servidor web local em `http://localhost:4000`, onde você pode visualizar a documentação.

## Estrutura da Documentação

A documentação do UTCP está organizada da seguinte forma:

- `index.md`: Página inicial e introdução ao UTCP
- `docs/`
  - `introduction.md`: Introdução detalhada e conceitos centrais
  - `for-tool-providers.md`: Guia para implementação de provedores de ferramentas
  - `for-tool-callers.md`: Guia para implementação de chamadores de ferramentas
  - `providers/`: Documentação para cada tipo de provedor
    - `http.md`: Provedor HTTP
    - `websocket.md`: Provedor WebSocket
    - `cli.md`: Provedor CLI
    - `sse.md`: Provedor Server-Sent Events
    - etc.
  - `implementation.md`: Diretrizes de implementação e melhores práticas

## Trabalhando com a Especificação

### Modificando a Documentação

A documentação é escrita em formato Markdown com front matter do Jekyll. Ao fazer alterações:

1. Certifique-se de que seu Markdown siga o estilo estabelecido
2. Visualize as alterações localmente antes de enviar PRs
3. Mantenha os exemplos atualizados com a especificação mais recente
4. Atualize os itens de navegação em `_config.yml` ao adicionar novas páginas

### Organização dos Arquivos

Ao adicionar nova documentação:

- Coloque a documentação específica do provedor em `docs/providers/`
- Use front matter consistente com a ordem de navegação apropriada
- Inclua tags para melhor pesquisa no GitHub Pages

## Controle de Versão

A especificação UTCP segue versionamento semântico:

- Versões principais (1.0, 2.0): Mudanças incompatíveis no protocolo
- Versões secundárias (1.1, 1.2): Novos recursos adicionados de forma retrocompatível
- Versões de correção (1.0.1, 1.0.2): Correções de bugs e esclarecimentos retrocompatíveis

## Licença

Esta especificação é distribuída sob a Licença Pública Mozilla 2.0 (MPL-2.0).

## Recursos Adicionais

- [Organização UTCP no GitHub](https://github.com/universal-tool-calling-protocol)
- [Site do UTCP](https://utcp.io)
- [Implementações de Referência](https://github.com/universal-tool-calling-protocol/python-utcp)
- [Discussões da Comunidade](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---