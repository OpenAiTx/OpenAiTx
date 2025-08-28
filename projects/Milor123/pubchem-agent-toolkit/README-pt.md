
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>

# Servidor MCP PubChem Aprimorado para Assistentes de IA

🧪 Um servidor MCP avançado, robusto e focado em privacidade que permite que assistentes de IA pesquisem e acessem informações de compostos químicos no PubChem de forma inteligente.

Este servidor MCP PubChem funciona como uma ponte poderosa entre assistentes de IA (como os do AnythingLLM) e o vasto banco de dados químico do PubChem. Ele utiliza o Model Context Protocol (MCP) para permitir que modelos de IA realizem buscas inteligentes e resilientes por compostos químicos e recuperem suas propriedades detalhadas programaticamente.

---

## ✨ Funcionalidades Principais

Este não é apenas mais um wrapper do PubChem. Este servidor foi reconstruído do zero para ser altamente robusto e inteligente:

-   **🧠 Busca Inteligente com Fallback**: Se uma busca por um nome comum (como "Vitamina D") falhar, o servidor realiza automaticamente uma busca mais profunda no banco de dados de Substâncias do PubChem para encontrar o composto correto. Isso melhora drasticamente a taxa de sucesso para consultas ambíguas.
-   **🛡️ Tratamento Robusto de Erros & Repetições**: O servidor foi projetado para lidar graciosamente com erros da API. Se encontrar um erro de "Servidor Ocupado" do PubChem, ele irá aguardar e tentar novamente automaticamente, garantindo que suas consultas sejam bem-sucedidas mesmo sob alta carga.
-   **🔒 Suporte Opcional a Proxy Tor**: Você tem controle total sobre sua privacidade. Um simples arquivo `config.ini` permite rotear todas as solicitações pela rede Tor (via proxy SOCKS5 ou HTTP), impedindo que seu endereço IP seja exposto. O servidor é seguro por padrão e **nunca** vaza seu IP se a conexão proxy falhar.
-   **🔎 Busca de Um ou Múltiplos Compostos**: Gerencia facilmente solicitações para um ou vários compostos em um único prompt.
-   **🧪 Recuperação Detalhada de Propriedades**: Acesse propriedades químicas essenciais como Nome IUPAC, Fórmula Molecular, Peso Molecular e, principalmente, **Massa Monoisotópica**.

---

---

### 🚀 Sem Instalação Necessária: Experimente ao Vivo no Smithery.ai

Para quem é novo em servidores MCP ou apenas deseja testar as capacidades desta ferramenta sem qualquer configuração local, uma versão hospedada está disponível no Smithery.ai. Isso permite conversar com o agente diretamente pelo navegador.

[**<-- Explore o Agente PubChem Ao Vivo no Smithery.ai -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**Como começar:**

1.  Clique no link acima para acessar a página do servidor.
2.  Faça login usando sua conta **GitHub** ou **Google**.
3.  Clique no botão **"Explore capabilities"** para abrir a interface de chat e começar os testes!

> **✅ Modelos Recomendados para Melhores Resultados**
>
> Para obter a maior precisão, especialmente com números decimais longos, recomendamos fortemente o uso de modelos poderosos. Os seguintes foram testados e funcionam excelentemente com esta ferramenta:
>
> *   **Claude 3 Sonnet da Anthropic**
> *   **GPT-4 Turbo da OpenAI** (ou versões mais recentes como GPT-4o)
>
> Confirmamos que ambos os modelos processaram corretamente toda a precisão dos números decimais retornados pela ferramenta, sem qualquer arredondamento.

---

## 🚀 Início Rápido & Instalação

Este servidor foi projetado para ser executado localmente, seja no seu desktop ou dentro do ambiente Docker do AnythingLLM.

### 1. Dependências

Este projeto depende de algumas bibliotecas Python. Certifique-se de que elas estejam instaladas em seu ambiente.

Crie um arquivo `requirements.txt` com o seguinte conteúdo:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

Instale-os usando `uv` ou `pip`:
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(Nota: `PySocks` só é necessário se você pretende usar o recurso de proxy Tor SOCKS5.)*

### 2. Configuração

O servidor é configurado através de um arquivo `config.ini` que é **criado automaticamente** na primeira vez que você executá-lo. Este arquivo aparecerá no mesmo diretório do script `pubchem_server.py`.

**`config.ini` padrão:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. Integração com AnythingLLM

Siga a documentação oficial para adicionar isto como um servidor MCP personalizado. O segredo é apontar o `command` para o seu executável Python e o script `pubchem_server.py`.

**Exemplo para AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 Exemplos de Implementação com AnythingLLM

Aqui estão alguns exemplos de como interagir com o agente. Esses testes foram realizados usando o AnythingLLM Desktop, conectando-se a vários Modelos de Linguagem de Grande Porte via OpenRouter.

Uma descoberta crucial de nossos testes é a importância do modelo escolhido. **Recomendamos fortemente que você não utilize modelos pequenos ou locais** para esta tarefa. Modelos menores frequentemente têm dificuldades para interpretar corretamente os dados retornados pela ferramenta, levando a erros como valores inventados, formatação incorreta ou, mais criticamente, **arredondamento de números decimais**, o que compromete a finalidade desta ferramenta de alta precisão.

Para garantir a integridade de seus resultados, sempre é uma boa prática verificar os dados brutos retornados pelo MCP. Você pode aprender como fazer isso na próxima seção: [3.2 Como verificar saídas do MCP nos logs](#32-como-verificar-saídas-do-mcp-nos-logs).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

Por outro lado, vários modelos demonstraram excelente desempenho. Obtivemos resultados excepcionais com **Google `Gemini 2.5 Flash lite`**, que mostrou precisão notável ao lidar com números decimais longos e formatar corretamente a tabela Markdown final.

Google gemini 2.5 flash lite sem prompt e com prompt mantém decimais perfeitos (no exemplo usa 0.6 de temperatura)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

Para esta tarefa específica, meu favorito pessoal é o **`Gemini 2.5 Flash lite`** devido à sua precisão e confiabilidade consistentes.

### 3.2 Como Verificar Saídas do MCP nos Logs

A melhor maneira de confirmar que o agente está recebendo os dados corretos e que o LLM não está cometendo erros é verificar o arquivo de log de depuração gerado pelo servidor MCP.

Este servidor está configurado para criar automaticamente um arquivo de log em uma subpasta dentro do diretório do seu projeto. O local será:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

Dentro do arquivo `mcp_debug.log`, você encontrará os dados JSON exatos que a ferramenta envia de volta para o LLM *antes* do modelo processá-los. Você pode inspecionar manualmente esse JSON para verificar quaisquer valores, especialmente números decimais longos de propriedades como `monoisotopic_mass`, garantindo que o LLM não introduziu erros de arredondamento ou alucinações em sua resposta final.

---

## 📊 Uso

Após a integração, seu assistente de IA usará automaticamente esta ferramenta quando solicitado sobre informações químicas. A principal ferramenta exposta é `search_compounds_by_name`.

### Exemplo de Prompt

Este prompt demonstra a capacidade da ferramenta de lidar com uma lista de compostos com diferentes tipos de nomes e recuperar múltiplas propriedades.

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```

O agente irá chamar a ferramenta `search_compounds_by_name`, que irá encontrar cada composto de forma inteligente, recuperar seus dados e retorná-los ao LLM para formatação.

---

## 🛠 Ferramenta MCP Exposta

### `search_compounds_by_name`

Procura por múltiplos compostos pelo nome, um a um, usando uma estratégia inteligente de fallback com pausas e tentativas para máxima confiabilidade.

**Parâmetros:**
-   `names` (List[str]): Uma lista de nomes de compostos. Exemplo: `["Aspirina", "Ibuprofeno"]`

**Retorna:** Uma lista de dicionários, onde cada dicionário contém ou as informações do composto encontrado ou uma mensagem de erro detalhando por que a busca falhou para aquele composto específico.

---

## 🙏 Agradecimentos

Este projeto foi fortemente inspirado e construído sobre a fundação do original [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) criado por **JackKuo666**.

Embora este repositório não seja um fork direto, o projeto original foi o ponto de partida crucial. Esta versão aprimora o conceito original com foco em extrema robustez, estratégias de busca inteligentes e privacidade do usuário através da integração opcional com Tor 🧅.

Muito obrigado ao autor original pelo excelente trabalho e por compartilhá-lo com a comunidade.

---

## ⚠️ Aviso Legal

Esta ferramenta é destinada para fins de pesquisa e educação. Por favor, respeite os termos de serviço do PubChem e use esta ferramenta de forma responsável.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---