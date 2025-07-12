# Git Smart Squash

Pare de perder tempo reorganizando commits manualmente. Deixe a IA fazer isso por você.

## O Problema

Você já passou por isso: 15 commits para uma funcionalidade, metade deles são "fix", "typo" ou "WIP". Agora você precisa limpar tudo para a revisão do PR. Fazer squash e reescrever manualmente é tedioso.

## A Solução

O Git Smart Squash analisa suas alterações e as reorganiza em commits lógicos com mensagens apropriadas:

```bash
# Antes: sua branch bagunçada
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation
```
# Depois: commits limpos e lógicos
* feat: implementar sistema de autenticação JWT
* test: adicionar cobertura para endpoint de autenticação
```

## Início Rápido

### 1. Instalação

```bash
# Usando pip
pip install git-smart-squash

# Usando pipx (recomendado para instalação isolada)
pipx install git-smart-squash

# Usando uv (gerenciador de pacotes Python rápido)
uv tool install git-smart-squash
```
### 2. Configurar IA

**Opção A: Local (Grátis, Privado)**
```bash
# Instale o Ollama em https://ollama.com
ollama pull devstral  # Modelo padrão
```

**Opção B: Nuvem (Melhores resultados)**
```bash
export OPENAI_API_KEY="sua-chave"
export ANTHROPIC_API_KEY="sua-chave"
export GEMINI_API_KEY="sua-chave"
```

### 3. Executar

```bash
cd seu-repositorio
git-smart-squash
```
É isso. Revise o plano e aprove.

## Parâmetros de Linha de Comando

| Parâmetro | Descrição | Padrão |
|-----------|-----------|--------|
| `--base` | Branch base para comparar | Arquivo de configuração ou `main` |
| `--ai-provider` | Provedor de IA a ser utilizado (openai, anthropic, local, gemini) | Configurado nas configurações |
| `--model` | Modelo de IA específico a ser utilizado (veja modelos recomendados abaixo) | Padrão do provedor |
| `--config` | Caminho para arquivo de configuração personalizado | `.git-smart-squash.yml` ou `~/.git-smart-squash.yml` |
| `--auto-apply` | Aplicar plano de commit sem prompt de confirmação | `false` |
| `--instructions`, `-i` | Instruções personalizadas para IA (ex.: "Agrupar por área de funcionalidade") | Nenhuma |
| `--no-attribution` | Desabilitar mensagem de atribuição nos commits | `false` |
| `--debug` | Habilitar logs de depuração para informações detalhadas | `false` |

## Modelos Recomendados

### Modelos Padrão
- **OpenAI**: `gpt-4.1` (padrão)
- **Anthropic**: `claude-sonnet-4-20250514` (padrão)
- **Gemini**: `gemini-2.5-pro` (padrão)
- **Local/Ollama**: `devstral` (padrão)

### Seleção de Modelo
```bash
# Especificar um modelo diferente
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# Para Ollama local
git-smart-squash --ai-provider local --model llama-3.1
```

## Instruções Personalizadas

O parâmetro `--instructions` permite que você controle como os commits são organizados:

### Exemplos
```bash
# Adicionar prefixos de ticket
git-smart-squash -i "Prefixe todos os commits com [ABC-1234]"

# Separar por tipo
git-smart-squash -i "Mantenha alterações de backend e frontend em commits separados"
```
# Limitar o número de commits
git-smart-squash -i "Criar no máximo 3 commits no total"
```

### Dicas para Melhores Resultados
- **Seja específico**: "Agrupar migrações de banco de dados separadamente" funciona melhor do que "organizar direitinho"
- **Uma instrução por vez**: Instruções complexas com várias partes podem ser parcialmente ignoradas
- **Use modelos melhores**: Modelos maiores seguem instruções de forma mais confiável do que modelos menores

## Casos de Uso Comuns

### "Preciso limpar antes da revisão de PR"
```bash
git-smart-squash              # Mostra o plano e solicita confirmação
git-smart-squash --auto-apply # Aplica automaticamente sem solicitar
```

### "Trabalho com um branch principal diferente"
```bash
git-smart-squash --base develop
```
### "Quero usar um provedor de IA específico"
```bash
git-smart-squash --ai-provider openai
```

## Segurança

**Seu código está seguro:**
- Mostra o plano antes de fazer alterações
- Cria um branch de backup automático
- Requer diretório de trabalho limpo
- Nunca faz push sem o seu comando

**Se algo der errado:**
```bash
# Encontrar backup
git branch | grep backup

# Restaurar
git reset --hard your-branch-backup-[timestamp]
```

## Provedores de IA

| Provedor   | Custo   | Privacidade |
|------------|---------|-------------|
| **Ollama**     | Grátis  | Local      |
| **OpenAI**     | ~US$0,01| Nuvem      |
| **Anthropic**  | ~US$0,01| Nuvem      |
| **Gemini**     | ~US$0,01| Nuvem      |

## Configuração Avançada (Opcional)

Quer personalizar? Crie um arquivo de configuração:

**Específico do projeto** (`.git-smart-squash.yml` no seu repositório):
```yaml
ai:
  provider: openai  # Use OpenAI para este projeto
base: develop       # Use develop como o branch base para este projeto
```
**Padrão global** (`~/.git-smart-squash.yml`):
```yaml
ai:
  provider: local   # Sempre use IA local por padrão
base: main          # Branch base padrão para todos os projetos
```

## Solução de Problemas

### Erro "JSON Inválido"
Isso geralmente significa que o modelo de IA não conseguiu formatar a resposta corretamente:
- **Com Ollama**: Troque de `llama2` para `mistral` ou `mixtral`
- **Solução**: `ollama pull mistral` e tente novamente
- **Alternativa**: Use um provedor em nuvem com `--ai-provider openai`

### Modelo Não Segue as Instruções
Alguns modelos têm dificuldade com instruções complexas:
- **Use modelos melhores**: `--model gpt-4-turbo` ou `--model claude-3-opus`
- **Simplifique as instruções**: Uma orientação clara funciona melhor do que várias
- **Seja explícito**: "Prefixe com [ABC-123]" e não "adicione o número do ticket"
### "Ollama não encontrado" 
```bash
# Instale de https://ollama.com
ollama serve
ollama pull devstral  # Modelo padrão
```

### Agrupamento Ruim de Commits
Se a IA criar commits demais ou não agrupar bem:
- **Modelo insuficiente**: Use um modelo maior
- **Adicione instruções**: `-i "Agrupe mudanças relacionadas, máximo 3 commits"`
- **Forneça Feedback**: Crie uma issue no GitHub e nos informe o que aconteceu

### Problemas de Instalação (Mac)
Se você não tem pip ou prefere instalações isoladas:
```bash
# Usando pipx (recomendado)
brew install pipx
pipx install git-smart-squash
```
### "Nenhuma alteração para reorganizar"
```bash
git log --oneline main..HEAD  # Verifique se você tem commits
git diff main                 # Verifique se você tem alterações
```

### Diffs Grandes / Limites de Tokens
Modelos locais têm um limite de ~32k tokens. Para alterações grandes:
- Use `--base` com um commit mais recente
- Mude para a nuvem: `--ai-provider openai`
- Divida em PRs menores

### Precisa de mais ajuda?

Confira nossa [documentação detalhada](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md) ou abra uma issue!

## Licença

Licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---