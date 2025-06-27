# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

Este repositório contém o Gemini CLI, uma ferramenta de fluxo de trabalho de IA em linha de comando que se conecta às suas ferramentas, entende seu código e acelera seus fluxos de trabalho.

Com o Gemini CLI você pode:

- Consultar e editar grandes bases de código dentro e além da janela de contexto de 1 milhão de tokens do Gemini.
- Gerar novos aplicativos a partir de PDFs ou esboços, usando as capacidades multimodais do Gemini.
- Automatizar tarefas operacionais, como consultar pull requests ou lidar com rebases complexos.
- Usar ferramentas e servidores MCP para conectar novas capacidades, incluindo [geração de mídia com Imagen, Veo ou Lyria](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia).
- Fundamentar suas consultas com a ferramenta [Google Search](https://ai.google.dev/gemini-api/docs/grounding), integrada ao Gemini.

## Início Rápido

1. **Pré-requisitos:** Certifique-se de que você possui o [Node.js versão 18](https://nodejs.org/en/download) ou superior instalado.
2. **Execute o CLI:** Execute o seguinte comando no seu terminal:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   Ou instale com:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **Escolha um tema de cor**
4. **Autentique-se:** Quando solicitado, faça login com sua conta pessoal do Google. Isso lhe concederá até 60 solicitações de modelo por minuto e 1.000 solicitações de modelo por dia usando o Gemini.

Agora você está pronto para usar o Gemini CLI!

### Para uso avançado ou limites aumentados:

Se você precisar usar um modelo específico ou exigir uma capacidade de solicitação maior, pode usar uma chave de API:

1. Gere uma chave em [Google AI Studio](https://aistudio.google.com/apikey).
2. Defina-a como uma variável de ambiente no seu terminal. Substitua `YOUR_API_KEY` pela chave gerada.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

Para outros métodos de autenticação, incluindo contas do Google Workspace, veja o guia de [autenticação](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md).

## Exemplos

Depois que o CLI estiver em execução, você pode começar a interagir com o Gemini a partir do seu shell.

Você pode iniciar um projeto a partir de um novo diretório:

```sh
cd new-project/
gemini
> Escreva para mim um bot do Gemini para Discord que responda perguntas usando um arquivo FAQ.md que eu vou fornecer
```

Ou trabalhar com um projeto existente:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> Dê-me um resumo de todas as mudanças que foram feitas ontem
```

### Próximos passos

- Aprenda como [contribuir ou construir a partir do código-fonte](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md).
- Explore os **[Comandos CLI disponíveis](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**.
- Se você encontrar algum problema, consulte o **[Guia de Solução de Problemas](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**.
- Para uma documentação mais abrangente, veja a [documentação completa](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md).
- Dê uma olhada em algumas [tarefas populares](#tarefas-populares) para mais inspiração.

### Solução de Problemas

Acesse o guia de [solução de problemas](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md) se você estiver enfrentando problemas.

## Tarefas populares

### Explorar uma nova base de código

Comece dando um `cd` em um repositório existente ou recém-clonado e executando `gemini`.

```text
> Descreva as principais partes da arquitetura deste sistema.
```

```text
> Quais mecanismos de segurança estão implementados?
```

### Trabalhe com seu código existente

```text
> Implemente um primeiro rascunho para o issue #123 do GitHub.
```

```text
> Ajude-me a migrar esta base de código para a versão mais recente do Java. Comece com um plano.
```

### Automatize seus fluxos de trabalho

Use servidores MCP para integrar as ferramentas do seu sistema local com sua suíte de colaboração empresarial.

```text
> Crie um slide deck mostrando o histórico do git dos últimos 7 dias, agrupado por funcionalidade e membro da equipe.
```

```text
> Faça um aplicativo web em tela cheia para um painel de parede que mostre nossos issues do GitHub mais interagidos.
```

### Interaja com seu sistema

```text
> Converta todas as imagens neste diretório para png e renomeie-as usando as datas dos dados exif.
```

```text
> Organize minhas faturas PDF por mês de despesa.
```

## Termos de Serviço e Aviso de Privacidade

Para detalhes sobre os termos de serviço e o aviso de privacidade aplicáveis ao uso do Gemini CLI, consulte os [Termos de Serviço e Aviso de Privacidade](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---