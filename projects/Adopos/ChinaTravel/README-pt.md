<center>
  <h1>ChinaTravel: Um Benchmark do Mundo Real para Agentes de Linguagem no Planejamento de Viagens na China
</h1>
</center>

Base oficial de código para o artigo "ChinaTravel: Um Benchmark do Mundo Real para Agentes de Linguagem no Planejamento de Viagens na China".

<!-- | [Webpage](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [Paper](https://arxiv.org/abs/2412.13682) | [Dataset(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![Webpage](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![Paper](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![Dataset(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![Competition(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![Competition(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![Overview](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 Desafio de Planejamento de Viagens IJCAI 2025 (TPC@IJCAI)

Temos orgulho de anunciar que ChinaTravel foi selecionado como o benchmark oficial para o **Desafio de Planejamento de Viagens (TPC) @ IJCAI 2025**!

**Site Oficial da Competição**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

Os participantes são convidados a desenvolver agentes inovadores capazes de enfrentar cenários reais de planejamento de viagens sob restrições complexas. Esta competição irá apresentar as abordagens mais avançadas em pesquisa de agentes de linguagem.

## 📝 ChangeLog

### 2025.09
1. Upload da solução campeã da trilha DSL do TPC@IJCAI2025. Agradecimentos ao [@evergreenee](https://github.com/evergreenee) por suas contribuições.  


### 2025.06

1. Correção na coleta de erros do código de avaliação de senso comum. 
2. Correção do pipeline do agente puramente neuro.
3. Correção do load_datasets do huggingface.
4. Atualização do tratamento de exceções na verificação de sintaxe.


### 2025.05

1. Atualizar registros para a versão mais recente.
2. Fornecer o código de avaliação para o TPC.

### 2025.04

1. Adicionado carregador de dados local. Usuários agora podem carregar consultas personalizadas localmente. Ao especificar valores não padrão para splits_name (por exemplo, "abc") no "run_exp.py", o sistema carregará automaticamente os arquivos correspondentes de evaluation/default_splits/abc.txt, onde o arquivo TXT contém os nomes dos arquivos de consulta alvo.
2. Classificação detalhada de restrições. Veja a documentação detalhada em [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. Introduzida baseline LLM-modulo
   Implementar o pipeline LLM-modulo com um verificador simbólico de verdadeiros valores.
   Baseado na metodologia de:
   Artigo: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   Repositório de código: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. Suporte à inferência local de LLMs com Qwen3-8B/4B.

## 🚀 Início Rápido

### ⚙️ Configuração

1. Crie um ambiente conda e instale as dependências:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. Baixe o banco de dados e descompacte-o no diretório "chinatravel/environment/"

Links para download: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. Baixe os LLMs de código aberto (opcional).

```bash
bash download_llm.sh
```

4. Baixe os tokenizadores.

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ Execução

Suportamos deepseek (API oficial do deepseek), gpt-4o (chatgpt-4o-latest), glm4-plus e inferências locais com Qwen (Qwen3-8B), llama, mistral (Mistral-7B-Instruct-v0.3), etc.

```bash
export OPENAI_API_KEY=""

python run_exp.py --splits easy --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits medium --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits human --agent LLMNeSy --llm deepseek --oracle_translation

python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B --oracle_translation


python run_exp.py --splits human --agent LLMNeSy --llm deepseek 
python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B 


python run_exp.py --splits human --agent LLM-modulo --llm deepseek --refine_steps 10 --oracle_translation
python run_exp.py --splits human --agent LLM-modulo --llm Qwen3-8B --refine_steps 10 --oracle_translation
```

**Nota**:

- A flag `--oracle_translation` permite acesso à verdade de base anotada incluindo:

  - `hard_logic_py`: Código DSL de verificação executável
  - `hard_logic_nl`: As descrições de restrições correspondentes
  - Estrutura de anotação de exemplo:

  ```python
  {
    "hard_logic_py": [
      "
      total_cost=0 
      for activity in allactivities(plan):
          total_cost+=activity_cost(activity)
              total_cost += innercity_transport_cost(activity_transports(activity))
      result=(total_cost<=1000)
      ", 
      "
      innercity_transport_set=set()
      for activity in allactivities(plan):
          if activity_transports(activity)!=[]:              
              innercity_transport_set.add(innercity_transport_type(activity_transports(activity)))
      result=(innercity_transport_set<={'taxi'})
      "
    ], 
    "hard_logic_nl": ["总预算为1800元", "市内交通选择taxi"], 
  }
  ```
- O método LLM-modulo **requer** o modo oracle_translation para seu processo de refinamento simbólico

### 📊 Avaliação

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```

No TPC@IJCAI2025, o código de avaliação está disponível no arquivo `eval_tpc.py`. Você pode executar o código de avaliação da seguinte forma:

```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 Documentação

[Ambiente](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[Restrições](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ Desenvolvimento Avançado

### 1. Desenvolva Seu Próprio Algoritmo de Agente

Para desenvolver seu próprio algoritmo de agente, você precisa herdar a classe `BaseAgent` de `chinatravel/agent/base.py` e adicionar a lógica do seu algoritmo na função `init_agent` em `chinatravel/agent/load_model.py`. Nós fornecemos um exemplo de agente vazio chamado `TPCAgent`.

Passos:

- **Herde a classe `BaseAgent`**: Crie um novo arquivo Python no diretório `chinatravel/agent` e defina sua própria classe de agente, herdando de `BaseAgent`.

```python:chinatravel/agent/your_agent.py
from .base import BaseAgent

class YourAgent(BaseAgent):
    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Initialization logic

    def act(self, observation):
        # Implement the decision - making logic of the agent
        pass
```

- **Adicione código à função init_agent**: Abra o arquivo chinatravel/agent/load_model.py e adicione suporte para seu novo agente na função init_agent.

```python:
def init_agent(kwargs):
    # ... existing code ...
    elif kwargs["method"] == "YourMethodName":
        agent = YourAgent(
            **kwargs
        )
    # ... existing code ...
    return agent
```

### 2. Desenvolva Seu Próprio LLM Local

Para desenvolver seu próprio modelo de linguagem grande (LLM) local, você precisa herdar a classe AbstractLLM de chinatravel/agent/llms.py e adicionar o código correspondente de inferência do LLM local em llms.py. Fornecemos um exemplo de LLM vazio chamado TPCLLM.
Etapas:

- **Herde a classe AbstractLLM**: Defina sua própria classe LLM no arquivo chinatravel/agent/llms.py, herdando de AbstractLLM.

```python
class YourLLM(AbstractLLM):
    def __init__(self):
        super().__init__()
        # Initialization logic
        self.name = "YourLLMName"

    def _get_response(self, messages, one_line, json_mode):
        # Implement the response logic of the LLM
        response = "Your LLM response"
        if json_mode:
            # Handle JSON mode
            pass
        elif one_line:
            # Handle one - line mode
            response = response.split("\n")[0]
        return response
```

- **Adicione código à função init_agent**: Abra o arquivo chinatravel/agent/load_model.py e adicione suporte ao seu novo llm na função init_llm.

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. Execute Seu Código Usando Scripts de Experimento

Após concluir o desenvolvimento acima, você pode usar os scripts de experimento para executar seu código.

Exemplo de execução:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```

Os resultados serão salvos no diretório `results/YourMethodName_YourLLMName_xxx`, por exemplo, `results/TPCAgent_TPCLLM`.

## ✉️ Contato

Se você tiver algum problema, por favor entre em contato com [Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn).

## 📌 Citação

Se nosso artigo ou recursos relacionados forem valiosos para sua pesquisa, solicitamos gentilmente que seja feita a citação.

```
@misc{shao2024chinatravelrealworldbenchmarklanguage,
      title={ChinaTravel: A Real-World Benchmark for Language Agents in Chinese Travel Planning}, 
      author={Jie-Jing Shao and Xiao-Wen Yang and Bo-Wen Zhang and Baizhi Chen and Wen-Da Wei and Guohao Cai and Zhenhua Dong and Lan-Zhe Guo and Yu-feng Li},
      year={2024},
      eprint={2412.13682},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2412.13682}, 
}
```
[English](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=th) | [Français](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=de) | [Español](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=it) | [Русский](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ru) | [Português](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=as)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-13

---