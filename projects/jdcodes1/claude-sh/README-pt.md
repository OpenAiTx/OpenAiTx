
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

Código Claude reescrito como um script bash. ~1.500 linhas. Zero pacotes npm.

## Por quê

O Claude Code original possui ~380.000 linhas de TypeScript com 266 dependências npm. Este faz o mesmo trabalho principal em bash usando apenas `curl` e `jq`.

## Funcionalidades

- **Transmissão em tempo real** via FIFO pipe — o texto aparece conforme Claude o gera
- **6 ferramentas**: Bash, Ler, Editar, Escrever, Glob, Grep
- **Encadeamento de ferramentas** — até 25 chamadas de ferramenta por turno
- **Solicitação de permissão** — pede antes de executar comandos não seguros (`s/n/t`)
- **Carregamento de CLAUDE.md** — lê instruções do projeto a partir de arquivos CLAUDE.md na árvore de diretórios
- **Contexto sensível ao Git** — branch, status e commits recentes no prompt do sistema
- **Salvar/retomar sessão** — salva automaticamente ao sair, retome com `--resume <id>`
- **Tentar novamente com backoff** — nova tentativa exponencial em limites 429/529
- **Rastreamento de custos** — totais por turno e por sessão
- **Spinner** — com os verbos originais do spinner (Clauding, Flibbertigibbeting, etc.)
- **Comandos de barra** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **Modo pipe** — `echo "explique isto" | ./claude.sh`

## Instalação

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## Dependências

- `curl`
- `jq`
- Opcional: `rg` (ripgrep) para uma busca aprimorada
- Opcional: `python3` para a ferramenta de edição

As versões de runtime estão fixadas em `.tool-versions`. Instale-as com [mise](https://mise.jdx.dev/):

```bash
mise install
```

## Uso

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### Variáveis de Ambiente

| Variável | Padrão | Descrição |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (obrigatório) | Sua chave de API da Anthropic |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | Modelo a ser usado |
| `CLAUDE_MAX_TOKENS` | `8192` | Máximo de tokens de saída |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | URL base da API |
| `CLAUDE_SH_PERMISSIONS` | `ask` | Modo de permissão: `ask`, `allow` ou `deny` |

### Comandos

```txt
/help      — Show help
/cost      — Show session cost
/model     — Show/change model
/clear     — Clear conversation
/save      — Save current session
/resume    — List/resume saved sessions
/commit    — Auto-generate a git commit
/diff      — Show git diff
/quit      — Exit
```

### Retomar uma Sessão

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## Arquitetura

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## Como Funciona

1. Ler a entrada do usuário
2. Construir a requisição JSON com `jq` (mensagens, ferramentas, prompt do sistema)
3. Transmitir a resposta via `curl` através de um pipe FIFO
4. Analisar eventos SSE linha por linha, imprimir deltas de texto em tempo real
5. Quando blocos tool_use chegarem, executar as ferramentas
6. Retornar os resultados das ferramentas como mensagens
7. Repetir até que o Claude pare de chamar ferramentas

## Comparação

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| Linhas de código | ~1.500 | ~380.000 |
| Dependências | curl, jq | 266 pacotes npm |
| Tamanho do binário | 0 (script) | ~200MB node_modules |
| Tempo de inicialização | Instantâneo | ~500ms |

### Testes

Os testes usam [bats](https://github.com/bats-core/bats-core) (Sistema Automatizado de Testes Bash):

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---