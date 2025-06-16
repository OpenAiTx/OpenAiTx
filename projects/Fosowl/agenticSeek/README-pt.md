# AgenticSeek: Alternativa privada e local ao Manus.

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*Uma **alternativa 100% local ao Manus AI**, este assistente de IA habilitado por voz navega autonomamente na web, escreve código e planeja tarefas enquanto mantém todos os dados em seu dispositivo. Projetado para modelos de raciocínio locais, ele roda inteiramente no seu hardware, garantindo total privacidade e nenhuma dependência da nuvem.*

[![Visite AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![Licença](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![Estrelas no GitHub](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### Por que AgenticSeek?

* 🔒 Totalmente Local & Privado - Tudo roda em sua máquina — sem nuvem, sem compartilhamento de dados. Seus arquivos, conversas e pesquisas permanecem privados.

* 🌐 Navegação Inteligente na Web - O AgenticSeek pode navegar na internet sozinho — pesquisar, ler, extrair informações, preencher formulários — tudo sem usar as mãos.

* 💻 Assistente Autônomo de Programação - Precisa de código? Ele pode escrever, depurar e executar programas em Python, C, Go, Java e mais — tudo sem supervisão.

* 🧠 Seleção Inteligente de Agentes - Você pede, ele descobre automaticamente o melhor agente para a tarefa. Como ter uma equipe de especialistas pronta para ajudar.

* 📋 Planeja & Executa Tarefas Complexas - De planejamento de viagens a projetos complexos — ele pode dividir grandes tarefas em etapas e realizar usando múltiplos agentes de IA.

* 🎙️ Habilitado por Voz - Voz limpa, rápida e futurista e conversão de fala para texto, permitindo que você converse como se fosse sua IA pessoal de um filme de ficção científica. (Em desenvolvimento)

### **Demo**

> *Você pode pesquisar pelo projeto agenticSeek, aprender quais habilidades são necessárias, depois abrir o CV_candidates.zip e então me dizer quais candidatos combinam melhor com o projeto*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

Aviso: Esta demonstração, incluindo todos os arquivos que aparecem (ex: CV_candidates.zip), é inteiramente fictícia. Não somos uma corporação, buscamos colaboradores open-source, não candidatos.

> 🛠⚠️️ **Trabalho Ativo em Andamento**

> 🙏 Este projeto começou como um projeto paralelo e não tem roteiro nem financiamento. Cresceu muito além do esperado, chegando ao GitHub Trending. Contribuições, feedback e paciência são profundamente apreciados.

## Pré-requisitos

Antes de começar, certifique-se de ter o seguinte software instalado:

*   **Git:** Para clonar o repositório. [Baixe o Git](https://git-scm.com/downloads)
*   **Python 3.10.x:** Recomendamos fortemente o uso da versão Python 3.10.x. Usar outras versões pode causar erros de dependência. [Baixe o Python 3.10](https://www.python.org/downloads/release/python-3100/) (escolha uma versão 3.10.x).
*   **Docker Engine & Docker Compose:** Para rodar serviços agrupados como o SearxNG.
    *   Instale o Docker Desktop (que inclui Docker Compose V2): [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   Alternativamente, instale o Docker Engine e o Docker Compose separadamente no Linux: [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (certifique-se de instalar o Compose V2, ex: `sudo apt-get install docker-compose-plugin`).

### 1. **Clone o repositório e configure**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. Altere o conteúdo do arquivo .env

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='opcional'
DEEPSEEK_API_KEY='opcional'
OPENROUTER_API_KEY='opcional'
TOGETHER_API_KEY='opcional'
GOOGLE_API_KEY='opcional'
ANTHROPIC_API_KEY='opcional'
```

Atualize o arquivo `.env` com seus próprios valores conforme necessário:

- **SEARXNG_BASE_URL**: Deixe inalterado
- **REDIS_BASE_URL**: Deixe inalterado
- **WORK_DIR**: Caminho para seu diretório de trabalho em sua máquina local. O AgenticSeek poderá ler e interagir com estes arquivos.
- **OLLAMA_PORT**: Número da porta para o serviço Ollama.
- **LM_STUDIO_PORT**: Número da porta para o serviço LM Studio.
- **CUSTOM_ADDITIONAL_LLM_PORT**: Porta para qualquer serviço LLM personalizado adicional.

**As chaves de API são totalmente opcionais para usuários que optam por rodar LLM localmente. Esse é o objetivo principal deste projeto. Deixe em branco se você possuir hardware suficiente**

### 3. **Inicie o Docker**

Certifique-se de que o Docker está instalado e em execução em seu sistema. Você pode iniciar o Docker usando os seguintes comandos:

- **No Linux/macOS:**  
    Abra um terminal e execute:
    ```sh
    sudo systemctl start docker
    ```
    Ou inicie o Docker Desktop a partir do menu de aplicativos, se instalado.

- **No Windows:**  
    Inicie o Docker Desktop pelo menu Iniciar.

Você pode verificar se o Docker está rodando executando:
```sh
docker info
```
Se você visualizar informações sobre sua instalação do Docker, ele está funcionando corretamente.

Veja a tabela de [Provedores Locais](#list-of-local-providers) abaixo para um resumo.

Próximo passo: [Execute o AgenticSeek localmente](#start-services-and-run)

*Veja a seção [Solução de Problemas](#troubleshooting) se estiver tendo problemas.*
*Se seu hardware não conseguir rodar LLMs localmente, veja [Configuração para rodar com uma API](#setup-to-run-with-an-api).*
*Para explicações detalhadas do `config.ini`, veja a [Seção de Configuração](#config).*

---

## Configuração para rodar LLM localmente em sua máquina

**Requisitos de Hardware:**

Para rodar LLMs localmente, você precisará de hardware suficiente. No mínimo, é necessário uma GPU capaz de rodar Magistral, Qwen ou Deepseek 14B. Veja o FAQ para recomendações detalhadas de modelo/desempenho.

**Configure seu provedor local**

Inicie seu provedor local, por exemplo, com o ollama:

```sh
ollama serve
```

Veja abaixo uma lista de provedores locais suportados.

**Atualize o config.ini**

Altere o arquivo config.ini para definir o provider_name para um provedor suportado e provider_model para um LLM suportado por seu provedor. Recomendamos modelos de raciocínio como *Magistral* ou *Deepseek*.

Veja o **FAQ** no final do README para hardware necessário.

```sh
[MAIN]
is_local = True # Sempre que estiver rodando localmente ou com provedor remoto.
provider_name = ollama # ou lm-studio, openai, etc..
provider_model = deepseek-r1:14b # escolha um modelo que se encaixe em seu hardware
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # nome da sua IA
recover_last_session = True # se deseja recuperar a sessão anterior
save_session = True # se deseja lembrar a sessão atual
speak = False # texto para fala
listen = False # fala para texto, apenas para CLI, experimental
jarvis_personality = False # Se deseja usar uma personalidade mais "Jarvis" (experimental)
languages = en zh # Lista de idiomas, Texto para fala usará o primeiro idioma da lista como padrão
[BROWSER]
headless_browser = True # deixe inalterado, a menos que use CLI no host.
stealth_mode = True # Use selenium não detectado para reduzir detecção do navegador
```

**Aviso**:

- O formato do arquivo `config.ini` não suporta comentários. 
Não copie e cole a configuração de exemplo diretamente, pois os comentários causarão erros. Em vez disso, modifique manualmente o arquivo `config.ini` com suas configurações desejadas, excluindo quaisquer comentários.

- *NÃO* defina provider_name como `openai` se estiver usando LM-studio para rodar LLMs. Defina como `lm-studio`.

- Alguns provedores (ex: lm-studio) exigem que você tenha `http://` na frente do IP. Por exemplo, `http://127.0.0.1:1234`

**Lista de provedores locais**

| Provedor   | Local? | Descrição                                                        |
|------------|--------|------------------------------------------------------------------|
| ollama     | Sim    | Rode LLMs localmente com facilidade usando ollama como provedor   |
| lm-studio  | Sim    | Rode LLM localmente com o LM studio (defina `provider_name` como `lm-studio`)|
| openai     | Sim    |  Use API compatível com openai (ex: servidor llama.cpp)           |

Próximo passo: [Inicie os serviços e rode o AgenticSeek](#Start-services-and-Run)  

*Veja a seção [Solução de Problemas](#troubleshooting) se estiver tendo problemas.*
*Se seu hardware não conseguir rodar LLMs localmente, veja [Configuração para rodar com uma API](#setup-to-run-with-an-api).*
*Para explicações detalhadas do `config.ini`, veja a [Seção de Configuração](#config).*

## Configuração para rodar com uma API

Esta configuração usa provedores de LLM externos, baseados em nuvem. Você precisará de uma chave de API do serviço escolhido.

**1. Escolha um Provedor de API e obtenha uma chave de API:**

Consulte a [Lista de Provedores de API](#list-of-api-providers) abaixo. Visite os sites deles para se cadastrar e obter uma chave de API.

**2. Defina sua chave de API como uma variável de ambiente:**


*   **Linux/macOS:**
    Abra seu terminal e use o comando `export`. É melhor adicionar isso ao arquivo de perfil do seu shell (ex: `~/.bashrc`, `~/.zshrc`) para persistência.
    ```sh
    export PROVIDER_API_KEY="sua_chave_api_aqui"
    # Substitua PROVIDER_API_KEY pelo nome da variável específica, ex: OPENAI_API_KEY, GOOGLE_API_KEY
    ```
    Exemplo para TogetherAI:
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **Prompt de Comando (Temporário para a sessão atual):**
    ```cmd
    set PROVIDER_API_KEY=your_api_key_here
    ```
*   **PowerShell (Temporário para a sessão atual):**
    ```powershell
    $env:PROVIDER_API_KEY="your_api_key_here"
    ```
*   **Permanentemente:** Pesquise por "variáveis de ambiente" na barra de pesquisa do Windows, clique em "Editar as variáveis de ambiente do sistema" e, em seguida, clique no botão "Variáveis de Ambiente...". Adicione uma nova variável de Usuário com o nome apropriado (por exemplo, `OPENAI_API_KEY`) e sua chave como valor.

*(Veja o FAQ: [Como configuro chaves de API?](#how-do-i-set-api-keys) para mais detalhes).*


**3. Atualize o `config.ini`:**
```ini
[MAIN]
is_local = False
provider_name = openai # Ou google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # Ou gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 etc.
provider_server_address = # Normalmente ignorado ou pode ser deixado em branco quando is_local = False para a maioria das APIs
# ... outras configurações ...
```
*Atenção:* Certifique-se de que não há espaços no final dos valores no `config.ini`.

**Lista de Provedores de API**

| Provedor      | `provider_name` | Local? | Descrição                                          | Link da chave da API (Exemplos)              |
|---------------|-----------------|--------|----------------------------------------------------|----------------------------------------------|
| OpenAI        | `openai`        | Não    | Usa modelos ChatGPT via API da OpenAI.             | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini | `google`        | Não    | Usa modelos Google Gemini via Google AI Studio.     | [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek      | `deepseek`      | Não    | Usa modelos Deepseek via sua API.                   | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face  | `huggingface`   | Não    | Usa modelos da Hugging Face Inference API.          | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI    | `togetherAI`    | Não    | Usa diversos modelos open-source via TogetherAI API.| [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*Nota:*
*   Não recomendamos o uso de `gpt-4o` ou outros modelos da OpenAI para navegação web complexa e planejamento de tarefas, pois as otimizações atuais de prompt são voltadas para modelos como Deepseek.
*   Tarefas de codificação/bash podem apresentar problemas com o Gemini, pois ele pode não seguir rigorosamente os prompts de formatação otimizados para o Deepseek.
*   O campo `provider_server_address` no `config.ini` geralmente não é usado quando `is_local = False`, pois o endpoint da API normalmente é definido na biblioteca do provedor.

Próxima etapa: [Inicie os serviços e rode o AgenticSeek](#Start-services-and-Run)

*Consulte a seção **Problemas conhecidos** caso esteja enfrentando problemas*

*Consulte a seção **Config** para uma explicação detalhada do arquivo de configuração.*

---

## Inicie os serviços e execute

Por padrão, o AgenticSeek é executado totalmente em docker.

Inicie os serviços necessários. Isso iniciará todos os serviços do docker-compose.yml, incluindo:
    - searxng
    - redis (necessário pelo searxng)
    - frontend
    - backend (se usar `full`)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Windows
```

**Atenção:** Esta etapa irá baixar e carregar todas as imagens do Docker, o que pode levar até 30 minutos. Após iniciar os serviços, aguarde até que o serviço backend esteja totalmente rodando (você deve ver **backend: "GET /health HTTP/1.1" 200 OK** no log) antes de enviar qualquer mensagem. Os serviços backend podem levar até 5 minutos para iniciar na primeira execução.

Acesse `http://localhost:3000/` e você deverá ver a interface web.

*Resolução de problemas ao iniciar o serviço:* Se esses scripts falharem, certifique-se de que o Docker Engine está em execução e que o Docker Compose (V2, `docker compose`) está instalado corretamente. Verifique a saída no terminal para mensagens de erro. Veja [FAQ: Help! I get an error when running AgenticSeek or its scripts.](#faq-troubleshooting)

**Opcional:** Rodar na máquina local (modo CLI):

Para rodar com interface CLI você precisará instalar o pacote na máquina local:

```sh
./install.sh
./install.bat # windows
```

Inicie os serviços:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Windows
```

Use o CLI: `python3 cli.py`


---

## Uso

Certifique-se de que os serviços estão ativos e em execução com `./start_services.sh full` e acesse `localhost:3000` para a interface web.

Você também pode usar reconhecimento de voz (speech to text) configurando `listen = True` no config. Apenas para o modo CLI.

Para sair, simplesmente diga/digite `goodbye`.

Aqui estão alguns exemplos de uso:

> *Crie um jogo da cobrinha em python!*

> *Pesquise na web pelos melhores cafés em Rennes, França, e salve uma lista de três com seus endereços em rennes_cafes.txt.*

> *Escreva um programa em Go para calcular o fatorial de um número, salve como factorial.go em sua área de trabalho*

> *Procure na pasta summer_pictures todos os arquivos JPG, renomeie-os com a data de hoje e salve uma lista dos arquivos renomeados em photos_list.txt*

> *Pesquise online por filmes de ficção científica populares de 2024 e escolha três para assistir hoje à noite. Salve a lista em movie_night.txt.*

> *Pesquise na web os artigos mais recentes sobre IA de 2025, selecione três e escreva um script Python para capturar seus títulos e resumos. Salve o script como news_scraper.py e os resumos em ai_news.txt em /home/projects*

> *Sexta-feira, pesquise na web por uma API gratuita de cotação de ações, registre-se com supersuper7434567@gmail.com, depois escreva um script Python para buscar, usando a API, os preços diários da Tesla, e salve os resultados em stock_prices.csv*

*Observe que as capacidades de preenchimento de formulários ainda são experimentais e podem falhar.*



Após digitar sua consulta, o AgenticSeek irá alocar o melhor agente para a tarefa.

Como este é um protótipo inicial, o sistema de roteamento de agentes pode não alocar sempre o agente correto com base na sua consulta.

Portanto, seja muito explícito no que deseja e em como a IA deve proceder. Por exemplo, se quiser que ela faça uma busca na web, não diga:

`Você conhece alguns bons países para viajar sozinho?`

Em vez disso, peça:

`Faça uma busca na web e descubra quais são os melhores países para viajar sozinho`

---

## **Configuração para rodar o LLM em seu próprio servidor**  

Se você tem um computador potente ou um servidor disponível, mas deseja usá-lo a partir do seu laptop, você pode rodar o LLM em um servidor remoto usando nosso servidor LLM personalizado.

No seu "servidor" que irá rodar o modelo de IA, obtenha o endereço IP

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # ip local
curl https://ipinfo.io/ip # ip público
```

Nota: Para Windows ou macOS, use ipconfig ou ifconfig respectivamente para encontrar o endereço IP.

Clone o repositório e entre na pasta `server/`.


```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

Instale os requisitos específicos do servidor:

```sh
pip3 install -r requirements.txt
```

Execute o script do servidor.

```sh
python3 app.py --provider ollama --port 3333
```

Você pode escolher entre usar `ollama` e `llamacpp` como serviço LLM.


Agora no seu computador pessoal:

Altere o arquivo `config.ini` para definir `provider_name` como `server` e `provider_model` como `deepseek-r1:xxb`.
Defina o `provider_server_address` para o endereço IP da máquina que irá rodar o modelo.

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```


Próxima etapa: [Inicie os serviços e rode o AgenticSeek](#Start-services-and-Run)  

---

## Reconhecimento de fala (Speech to Text)

Atenção: o reconhecimento de fala só funciona no modo CLI no momento.

Por favor, note que atualmente o reconhecimento de fala só funciona em inglês.

A funcionalidade de reconhecimento de fala vem desabilitada por padrão. Para habilitá-la, defina a opção listen como True no arquivo config.ini:

```
listen = True
```

Quando habilitada, a função de reconhecimento de fala escuta por uma palavra-chave de ativação, que é o nome do agente, antes de começar a processar sua entrada. Você pode personalizar o nome do agente atualizando o valor `agent_name` no arquivo *config.ini*:

```
agent_name = Friday
```

Para reconhecimento ideal, recomendamos o uso de um nome comum em inglês como "John" ou "Emma" como nome do agente

Assim que você ver a transcrição começar a aparecer, diga o nome do agente em voz alta para acordá-lo (por exemplo, "Friday").

Fale sua pergunta claramente.

Encerre seu pedido com uma frase de confirmação para sinalizar ao sistema que deve prosseguir. Exemplos de frases de confirmação incluem:
```
"faça isso", "vai em frente", "execute", "rodar", "iniciar", "obrigado", "pode ser?", "por favor", "ok?", "prossiga", "continue", "vá em frente", "faça isso", "entendeu?"
```

## Config

Exemplo de configuração:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Exemplo para Ollama; use http://127.0.0.1:1234 para LM-Studio
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # Lista de idiomas para TTS e potencialmente roteamento.
[BROWSER]
headless_browser = False
stealth_mode = False
```

**Explicação das configurações do `config.ini`**:

*   **Seção `[MAIN]`:**
    *   `is_local`: `True` se estiver usando um provedor LLM local (Ollama, LM-Studio, servidor local compatível com OpenAI) ou a opção de servidor auto-hospedado. `False` se estiver usando uma API em nuvem (OpenAI, Google, etc.).
    *   `provider_name`: Especifica o provedor LLM.
        *   Opções locais: `ollama`, `lm-studio`, `openai` (para servidores locais compatíveis com OpenAI), `server` (para configuração de servidor auto-hospedado).
        *   Opções de API: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`.
    *   `provider_model`: O nome ou ID do modelo específico para o provedor escolhido (por exemplo, `deepseekcoder:6.7b` para Ollama, `gpt-3.5-turbo` para API OpenAI, `mistralai/Mixtral-8x7B-Instruct-v0.1` para TogetherAI).
    *   `provider_server_address`: O endereço do seu provedor LLM.
        *   Para provedores locais: por exemplo, `http://127.0.0.1:11434` para Ollama, `http://127.0.0.1:1234` para LM-Studio.
        *   Para o tipo de provedor `server`: o endereço do seu servidor LLM auto-hospedado (por exemplo, `http://seu_ip_servidor:3333`).
        *   Para APIs em nuvem (`is_local = False`): geralmente é ignorado ou pode ser deixado em branco, pois o endpoint da API é normalmente gerenciado pela biblioteca cliente.
    *   `agent_name`: Nome do assistente de IA (por exemplo, Friday). Usado como palavra de ativação para reconhecimento de fala, se ativado.
    *   `recover_last_session`: `True` para tentar restaurar o estado da sessão anterior, `False` para iniciar do zero.
    *   `save_session`: `True` para salvar o estado da sessão atual para possível recuperação, `False` caso contrário.
    *   `speak`: `True` para ativar saída de voz via texto para fala, `False` para desativar.
    *   `listen`: `True` para ativar entrada de voz via reconhecimento de fala (somente modo CLI), `False` para desativar.
    *   `work_dir`: **Crucial:** O diretório onde o AgenticSeek irá ler/gravar arquivos. **Certifique-se de que este caminho é válido e acessível em seu sistema.**
    *   `jarvis_personality`: `True` para usar um prompt de sistema mais "estilo Jarvis" (experimental), `False` para o prompt padrão.
    *   `languages`: Uma lista de idiomas separada por vírgulas (por exemplo, `en, zh, fr`). Usada para seleção de voz TTS (padrão é o primeiro) e pode auxiliar o roteador LLM. Evite muitos idiomas ou idiomas muito semelhantes para eficiência do roteador.
*   **Seção `[BROWSER]`:**
    *   `headless_browser`: `True` para rodar o navegador automatizado sem janela visível (recomendado para interface web ou uso não interativo). `False` para exibir a janela do navegador (útil para modo CLI ou depuração).
    *   `stealth_mode`: `True` para ativar medidas que dificultam a detecção da automação do navegador. Pode exigir instalação manual de extensões como anticaptcha.

Esta seção resume os tipos de provedores LLM suportados. Configure-os no `config.ini`.

**Provedores Locais (Executados no Seu Próprio Hardware):**

| Nome do Provedor no `config.ini` | `is_local` | Descrição                                                                 | Seção de Configuração                                               |
|-------------------------------|------------|-------------------------------------------------------------------------|---------------------------------------------------------------------|
| `ollama`                      | `True`     | Usa o Ollama para servir LLMs locais.                                   | [Configuração para rodar LLM localmente](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | Usa o LM-Studio para servir LLMs locais.                                | [Configuração para rodar LLM localmente](#setup-for-running-llm-locally-on-your-machine) |
| `openai` (para servidor local)| `True`     | Conecta a um servidor local que expõe uma API compatível com OpenAI (ex.: llama.cpp). | [Configuração para rodar LLM localmente](#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | Conecta ao servidor LLM auto-hospedado do AgenticSeek rodando em outra máquina. | [Configuração para rodar o LLM no seu próprio servidor](#setup-to-run-the-llm-on-your-own-server) |

**Provedores de API (Baseados em Nuvem):**

| Nome do Provedor no `config.ini` | `is_local` | Descrição                                       | Seção de Configuração                               |
|-------------------------------|------------|------------------------------------------------|-----------------------------------------------------|
| `openai`                      | `False`    | Usa a API oficial da OpenAI (ex.: GPT-3.5, GPT-4). | [Configuração para rodar com uma API](#setup-to-run-with-an-api) |
| `google`                      | `False`    | Usa modelos Gemini do Google via API.           | [Configuração para rodar com uma API](#setup-to-run-with-an-api) |
| `deepseek`                    | `False`    | Usa a API oficial Deepseek.                     | [Configuração para rodar com uma API](#setup-to-run-with-an-api) |
| `huggingface`                 | `False`    | Usa a API de Inferência do Hugging Face.        | [Configuração para rodar com uma API](#setup-to-run-with-an-api) |
| `togetherAI`                  | `False`    | Usa a API TogetherAI para vários modelos abertos.| [Configuração para rodar com uma API](#setup-to-run-with-an-api) |

---
## Solução de Problemas

Se você encontrar problemas, esta seção traz orientações.

# Problemas Conhecidos

## Problemas com o ChromeDriver

**Exemplo de Erro:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **Causa:** A versão do ChromeDriver instalada é incompatível com a versão do seu navegador Google Chrome.
*   **Solução:**
    1.  **Verifique a Versão do Chrome:** Abra o Google Chrome, vá em `Configurações > Sobre o Chrome` para encontrar sua versão (exemplo: "Versão 120.0.6099.110").
    2.  **Baixe o ChromeDriver Correspondente:**
        *   Para versões do Chrome 115 ou mais recentes: Acesse os [Endpoints JSON do Chrome for Testing (CfT)](https://googlechromelabs.github.io/chrome-for-testing/). Encontre o canal "stable" e baixe o ChromeDriver para seu SO que corresponda à versão principal do seu Chrome.
        *   Para versões mais antigas (menos comuns): Você pode encontrá-las na página [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads).
        *   A imagem abaixo mostra um exemplo da página CfT:
            ![Baixe a versão específica do Chromedriver na página Chrome for Testing](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **Instale o ChromeDriver:**
        *   Certifique-se de que o `chromedriver` baixado (ou `chromedriver.exe` no Windows) esteja em um diretório listado na variável de ambiente PATH do seu sistema (ex.: `/usr/local/bin` no Linux/macOS ou uma pasta de scripts personalizada adicionada ao PATH no Windows).
        *   Alternativamente, coloque-o no diretório raiz do projeto `agenticSeek`.
        *   Certifique-se de que o driver seja executável (ex.: `chmod +x chromedriver` no Linux/macOS).
    4.  Consulte a seção [Instalação do ChromeDriver](#chromedriver-installation) no guia principal de Instalação para mais detalhes.

Se esta seção estiver incompleta ou você encontrar outros problemas com o ChromeDriver, considere pesquisar nos [Issues do GitHub](https://github.com/Fosowl/agenticSeek/issues) existentes ou abrir um novo.

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

Isso ocorre se houver incompatibilidade entre a versão do navegador e do chromedriver.

Você precisa acessar e baixar a versão mais recente:

https://developer.chrome.com/docs/chromedriver/downloads

Se você estiver usando o Chrome versão 115 ou mais recente, acesse:

https://googlechromelabs.github.io/chrome-for-testing/

E baixe a versão do chromedriver correspondente ao seu SO.

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

Se esta seção estiver incompleta, por favor, abra uma issue.

## Problemas com connection adapters

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (Nota: a porta pode variar)
```

*   **Causa:** O `provider_server_address` no `config.ini` para o `lm-studio` (ou outros servidores locais compatíveis com OpenAI) está sem o prefixo `http://` ou está apontando para a porta errada.
*   **Solução:**
    *   Certifique-se de que o endereço inclua `http://`. O LM-Studio normalmente usa `http://127.0.0.1:1234`.
    *   Corrija no `config.ini`: `provider_server_address = http://127.0.0.1:1234` (ou a porta real do seu servidor LM-Studio).

## SearxNG Base URL Não Fornecido

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## Perguntas Frequentes (FAQ)

**P: Que hardware eu preciso?**  

| Tamanho do Modelo | GPU           | Comentário                                                                                  |
|-------------------|---------------|--------------------------------------------------------------------------------------------|
| 7B                | 8GB Vram      | ⚠️ Não recomendado. Baixo desempenho, alucinações frequentes, agentes planejadores devem falhar. |
| 14B               | 12 GB VRAM (ex.: RTX 3060) | ✅ Utilizável para tarefas simples. Pode ter dificuldades com navegação web e planejamento. |
| 32B               | 24+ GB VRAM (ex.: RTX 4090) | 🚀 Sucesso na maioria das tarefas, pode ainda ter dificuldades com planejamento de tarefas  |
| 70B+              | 48+ GB Vram   | 💪 Excelente. Recomendado para casos de uso avançados.                                      |

**P: Recebo um erro, o que faço?**  

Certifique-se de que o local está rodando (`ollama serve`), que seu `config.ini` corresponde ao seu provedor e que as dependências estão instaladas. Se nada funcionar, sinta-se à vontade para abrir uma issue.

**P: Realmente pode rodar 100% localmente?**  

Sim, com Ollama, lm-studio ou provedores de servidor, todo reconhecimento de fala, LLM e modelo de texto para fala rodam localmente. Opções não locais (OpenAI ou outras APIs) são opcionais.

**P: Por que devo usar o AgenticSeek se já tenho o Manus?**

Ao contrário do Manus, o AgenticSeek prioriza independência de sistemas externos, oferecendo mais controle, privacidade e evitando custos de API.

**P: Quem está por trás do projeto?**

O projeto foi criado por mim, junto com dois amigos que atuam como mantenedores e colaboradores da comunidade open source no GitHub. Somos apenas um grupo de pessoas apaixonadas, não uma startup ou afiliados a qualquer organização.

Qualquer conta do AgenticSeek no X além da minha pessoal (https://x.com/Martin993886460) é uma falsificação.

## Contribua

Estamos procurando desenvolvedores para melhorar o AgenticSeek! Veja as issues abertas ou discussões.

[Guia de contribuição](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## Mantenedores:

 > [Fosowl](https://github.com/Fosowl) | Horário de Paris 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | Horário de Taipei

 > [steveh8758](https://github.com/steveh8758) | Horário de Taipei

## Agradecimentos Especiais:

 > [tcsenpai](https://github.com/tcsenpai) e [plitc](https://github.com/plitc) pela ajuda com dockerização do backend

## Patrocinadores:

Patrocinadores mensais de 5 dólares ou mais aparecem aqui:
- **tatra-labs**

I'm sorry, but you haven't provided the content of Part 4 of 4 to translate. Please provide the text you'd like translated.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---