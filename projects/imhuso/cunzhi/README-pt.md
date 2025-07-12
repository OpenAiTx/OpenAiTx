# CunZhi 🛑

> **O "fim precoce" das conversas com IA — faça o diálogo durar até o fim**

Ainda fica frustrado porque o assistente de IA sempre encerra a conversa antes da hora? Mesmo com muito assunto pendente, ele já pergunta "posso ajudar em mais alguma coisa?" **CunZhi** resolve esse problema!

Quando a IA tenta "encerrar rapidamente", o CunZhi exibe uma janela de diálogo no momento certo, permitindo que você continue a conversa até que a questão seja realmente resolvida.

## 🌟 Principais Características

- 🛑 **Interceptação Inteligente**: aparece automaticamente a opção de continuar quando a IA tenta encerrar
- 🧠 **Gestão de Memória**: armazena normas de desenvolvimento e preferências por projeto
- 🎨 **Interação Elegante**: suporte a Markdown, vários métodos de entrada
- ⚡ **Pronto para Usar**: instalação em 3 segundos, suporte multiplataforma

## 📸 Veja o Resultado

### 🛑 Janela de Interceptação Inteligente
![Demonstração da janela CunZhi](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*Quando a IA tenta encerrar a conversa, a janela inteligente do CunZhi aparece no momento certo, oferecendo opções predefinidas para seleção rápida, mantendo o diálogo fluido e aprofundado*
### ⚙️ Interface de Gerenciamento de Configurações
![Interface de Configurações do Cunzhi](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*Interface de configurações elegante, com suporte para gerenciamento de memória, alternância de funções, troca de tema e geração inteligente de prompts*

## 🚀 Começando a Usar

### Método 1: Instalação Rápida (Recomendado)

**Usuários macOS:**
```bash
# Instalação em 3 segundos, sem necessidade de aguardar compilação
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **Solução de problemas**: Se encontrar erro 404 ao baixar, siga os passos abaixo:
>
> ```bash
> # Limpar o cache antigo do tap
> brew untap imhuso/cunzhi
> # Reinstalar
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **Exemplo de erro comum:**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> Isso geralmente acontece devido a problemas de cache de versões anteriores, causando incompatibilidade de versão. Limpe o tap e reinstale para resolver.

**Usuários Windows/Linux:**
Recomenda-se utilizar o Método 2 para download manual, simples e rápido!
### Método 2: Download Manual

1. Acesse a [página de Releases](https://github.com/imhuso/cunzhi/releases)
2. Baixe a versão adequada para o seu sistema:
   - 🐧 **Linux**: `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)**: `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)**: `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows**: `cunzhi-cli-v*-windows-x86_64.zip`

3. Após extrair, adicione `寸止` e `等一下` ao PATH do sistema

## ⚡ Primeiros Passos Rápidos

### Passo 1: Configurar o Cliente MCP

No arquivo de configuração do seu cliente MCP (como o Claude Desktop), adicione:

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### Segundo Passo: Abrir a interface de configurações

```bash
# Execute o comando de configuração
Espere um momento
```

### Terceiro Passo: Configurar os prompts

Na aba "Prompts de Referência" da interface de configurações:
1. Veja os prompts gerados automaticamente
2. Clique no botão de copiar
3. Adicione os prompts ao seu assistente de IA

### Quarto Passo: Comece a usar

Agora seu assistente de IA possui funções de interceptação inteligente, gerenciamento de memória e interação por pop-up!

> 💡 **Dica**: Você pode personalizar os prompts gerados para criar uma experiência de interação com IA exclusiva.
## 🤝 Contribuindo

Cunzhi é um projeto open source, e damos boas-vindas a todos os tipos de contribuições!

### 🐛 Encontrou um problema?
- [Abra uma Issue](https://github.com/imhuso/cunzhi/issues) para descrever o problema
- Forneça etapas de reprodução e informações sobre o ambiente

### 💡 Tem uma boa ideia?
- [Inicie uma discussão](https://github.com/imhuso/cunzhi/discussions) para compartilhar sua ideia
- Envie um Pull Request para implementar novas funcionalidades

### 🛠️ Desenvolvimento local
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 Contate-nos

- 🐛 **Relatar Problemas**: [GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **Discussão de Funcionalidades**: [GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **Gostou do projeto**: Nos dê uma estrela para apoiar!

## 📄 Licença Open Source

MIT License - Uso livre, contribuições são bem-vindas!

---

<div align="center">

**Diga adeus à "ejaculação precoce" em diálogos com IA | Faça cada conversa durar até o fim**

[⭐ Star](https://github.com/imhuso/cunzhi) · [🐛 Reportar Bug](https://github.com/imhuso/cunzhi/issues) · [💡 Sugerir Funcionalidade](https://github.com/imhuso/cunzhi/discussions)

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---