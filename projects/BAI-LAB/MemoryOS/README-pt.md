# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 Se você gosta do nosso projeto, por favor, dê uma estrela ⭐ no GitHub para receber as atualizações mais recentes.</h5>
**MemoryOS** foi projetado para fornecer um sistema operacional de memória para agentes de IA personalizados, permitindo interações mais coerentes, personalizadas e sensíveis ao contexto. Inspirado nos princípios de gerenciamento de memória dos sistemas operacionais, adota uma arquitetura de armazenamento hierárquica com quatro módulos principais: Armazenamento, Atualização, Recuperação e Geração, para alcançar um gerenciamento de memória abrangente e eficiente. No benchmark LoCoMo, o modelo alcançou melhorias médias de **49,11%** e **46,18%** nas pontuações F1 e BLEU-1.







## 📣 Últimas Notícias
*   *<mark>[novo]</mark>* 🔥  **[2025-06-15]**:🛠️ **MemoryOS-MCP** de código aberto lançado! Agora configurável nos clientes agentes para integração e personalização perfeitas. [👉 Ver](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: Versão inicial do **MemoryOS** lançada! Inclui Memória de Persona de Curto, Médio e Longo Prazo com atualização automatizada de perfil do usuário e conhecimento.

## Demo
[![Assista ao vídeo](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	Arquitetura do Sistema
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## Estrutura do Projeto

```
memoryos/
├── __init__.py            # Inicializa o pacote MemoryOS
├── __pycache__/           # Diretório de cache do Python (gerado automaticamente)
├── long_term.py           # Gerencia a memória de longa duração da persona (perfil do usuário, conhecimento)
├── memoryos.py            # Classe principal do MemoryOS, orquestra todos os componentes
├── mid_term.py            # Gerencia a memória de médio prazo, consolidando interações de curto prazo
├── prompts.py             # Contém prompts usados para interações com LLM (ex: sumarização, análise)
├── retriever.py           # Recupera informações relevantes de todas as camadas de memória
├── short_term.py          # Gerencia a memória de curto prazo para interações recentes
├── updater.py             # Processa atualizações de memória, incluindo promoção de informações entre camadas
└── utils.py               # Funções utilitárias usadas em toda a biblioteca
```

## Como Funciona

1.  **Inicialização:** `Memoryos` é inicializado com IDs de usuário e assistente, chaves de API, caminhos de armazenamento de dados e várias configurações de capacidade/limite. Ele configura um armazenamento dedicado para cada usuário e assistente.
2.  **Adicionando Memórias:** Entradas do usuário e respostas do agente são adicionadas como pares de perguntas e respostas (QA). Inicialmente, são armazenadas na memória de curto prazo.
3.  **Processamento de Curto para Médio Prazo:** Quando a memória de curto prazo está cheia, o módulo `Updater` processa essas interações, consolidando-as em segmentos significativos e armazenando na memória de médio prazo.
4.  **Análise de Médio Prazo & Atualizações LPM:** Segmentos da memória de médio prazo acumulam "calor" com base em fatores como frequência de visita e duração da interação. Quando o calor de um segmento excede um limite, seu conteúdo é analisado:
    *   Insights do perfil do usuário são extraídos e usados para atualizar o perfil de longo prazo do usuário.
    *   Fatos específicos do usuário são adicionados ao conhecimento de longo prazo do usuário.
    *   Informações relevantes para o assistente são adicionadas à base de conhecimento de longo prazo do assistente.
5.  **Geração de Respostas:** Quando uma consulta do usuário é recebida:
    *   O módulo `Retriever` busca contexto relevante do histórico de curto prazo, segmentos de memória de médio prazo, perfil e conhecimento do usuário, e base de conhecimento do assistente.
    *   Esse contexto abrangente é então usado, junto com a consulta do usuário, para gerar uma resposta coerente e informada via um LLM.

## MemoryOS_PYPI Introdução Rápida

### Pré-requisitos

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### Instalação

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### Uso Básico

```python

import os
from memoryos import Memoryos

# --- Configuração Básica ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # Substitua pela sua chave
BASE_URL = ""  # Opcional: se usar um endpoint OpenAI personalizado
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS Demonstração Simples")
    
    # 1. Inicializar MemoryOS
    print("Inicializando MemoryOS...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOS inicializado com sucesso!\n")
    except Exception as e:
        print(f"Erro: {e}")
        return

    # 2. Adicionar algumas memórias básicas
    print("Adicionando algumas memórias...")
    
    memo.add_memory(
        user_input="Oi! Eu sou o Tom, trabalho como cientista de dados em San Francisco.",
        agent_response="Olá Tom! Prazer em conhecê-lo. Ciência de dados é uma área empolgante. Com que tipo de dados você trabalha?"
    )
     
    test_query = "O que você lembra sobre meu trabalho?"
    print(f"Usuário: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Assistente: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP Introdução Rápida
### 🔧 Ferramentas Principais

#### 1. `add_memory`
Salva o conteúdo da conversa entre o usuário e o assistente de IA no sistema de memória, para construir um histórico de diálogo persistente e registro de contexto.

#### 2. `retrieve_memory`
Recupera diálogos históricos relacionados, preferências do usuário e informações de conhecimento do sistema de memória com base em uma consulta, ajudando o assistente de IA a entender as necessidades e o histórico do usuário.

#### 3. `get_user_profile`
Obtém um perfil de usuário gerado a partir da análise dos diálogos históricos, incluindo traços de personalidade, preferências de interesse e conhecimento relevante do usuário.


### 1. Instale as dependências
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. configuração

Edite `config.json`：
```json
{
  "user_id": "sua_userID",
  "openai_api_key": "sua_chave_API_OpenAI",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. Inicie o servidor
```bash
python server_new.py --config config.json
```
### 4. Teste
```bash
python test_comprehensive.py
```
### 5. Configure no Cline e outros clientes
Copie o arquivo mcp.json, e garanta que o caminho do arquivo está correto.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#Isso deve ser alterado para o interpretador Python do seu ambiente virtual
```
## Contribuindo

Contribuições são bem-vindas! Sinta-se à vontade para enviar issues ou pull requests.

## Citação
Se você quiser ler mais detalhes, clique aqui: [Leia o Artigo Completo](https://arxiv.org/abs/2506.06326)

Se você achar este projeto útil, por favor, considere citar nosso artigo:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## Contate-nos
BAI AI é um grupo de pesquisa orientado pela Professora Associada Bai Ting da Universidade de Correios e Telecomunicações de Pequim, dedicado a criar cérebros emocionais e de memória extraordinária para humanos de silício.<br>
Colaboração e sugestões: baiting@bupt.edu.cn<br>
Siga o canal do BAI Agent no WeChat e junte-se ao nosso grupo para trocar ideias!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="Canal BAI Agent no WeChat" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="QR Code do grupo WeChat" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---