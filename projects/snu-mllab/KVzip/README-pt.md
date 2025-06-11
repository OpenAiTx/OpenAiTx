# KVzip: Compressão de Cache KV Agnóstica a Consultas com Reconstrução de Contexto

[[Artigo](https://arxiv.org/abs/2505.23416)] [[Blog](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## Novidades
- KVzip comprime o cache KV para suportar **diversas consultas futuras**.
- [Dependente do contexto] Alcança uma **redução de 3–4× no tamanho do cache KV** e uma **diminuição de 2× na latência de decodificação**, com degradação mínima de desempenho.
- [Independente do contexto] Melhora a compressão KV ao nível de cabeçalho no estilo [DuoAttention](https://github.com/mit-han-lab/duo-attention), usando apenas **algumas passagens de avanço em um minuto** para otimização da pontuação de importância ao nível de cabeçalho (100x mais rápido).
- Execute demo.py:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### Benchmark em configuração agnóstica a consultas
- Tarefas: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294). 
- Modelo: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## Instalação
Usamos CUDA 12.1 e Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- Para usar a quantização do [QServe](https://github.com/mit-han-lab/omniserve), siga [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model).
### Dataset
- Por favor, baixe o dataset SCBench pré-processado do [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link).
- Se você baixou os arquivos descompactados, basta mover a pasta scbench.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## Início Rápido
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "Este é meu perfil básico. Meu nome é Kim e moro em Seul. Minha graduação é ciência da computação."
queries = ["Qual é o meu nome?", "Eu moro em Seul?"]

kv = model.prefill(context, load_score=False)  # preenche cache KV + pontuação de importância
kv.prune(ratio=0.3)  # razão de compressão, remove 70% do KV

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # inferência eficiente
    print(q, output)
```
- Modelos suportados estão listados em [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), incluindo **LLaMA3, Qwen2.5/3, Gemma3**.
- Defina `load_score=True` para eliminar a sobrecarga de compressão. Isso permite a remoção independente do contexto do KV, com troca na razão de compressão para `ratio=0.6`.
- Após a geração, pares KV correspondentes às consultas e tokens gerados são removidos seletivamente do cache para processamento adicional. Defina `update_cache=True` para permitir inferência multi-turno, mantendo todo o histórico de interação durante a inferência. 

## Perfilando Memória e Tempo de Computação
### Remoção dependente do contexto
```bash
python -B test.py -m [nome_modelo] -d [nome_dados] --kv_type evict --ratio 0.3
```
- O código acima também compara saídas geradas com caches KV completos versus podados.
- Para teste rápido, use `-d squad`. Para testes de contexto longo, use `-d scbench_kv`.
  - Nomes de dados disponíveis: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - Nomes de modelos disponíveis: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), por exemplo, llama3.1-8b, qwen2.5-7b (ou Qwen/Qwen2.5-7B-Instruct-1M).
- Adaptamos o kernel CUDA do [AdaKV](https://github.com/FFY0/AdaKV/tree/main), suportando alocação não uniforme de orçamento por cabeça.
  - Atualmente, nosso código não possui um kernel otimizado para Gemma3 que usa cache KV estático, então o código não gera ganhos reais de eficiência. Contudo, o desempenho do modelo pode ser avaliado usando atenção reduzida com subsampling KV (`--kv_type retain`).


### Remoção independente do contexto (sem sobrecarga de compressão em tempo de execução)
- Use a flag `--level head` com `--ratio 0.6` (recomendado).
  - Removemos todos os pares KV de contexto associados a uma cabeça específica enquanto mantemos pares KV do prompt do sistema e da consulta.
  - Pontuações de cabeçalho pré-computadas estão disponíveis para LLaMA3.1-8B e Qwen2.5-7/14B em `./utils/head_score`.
- Para calcular pontuações de cabeçalho para outros modelos:
  ```bash
  python -B test.py -m [nome_modelo] -d scbench_qa_eng --save_head_score
  ```
  - Resultados serão salvos em `./utils/head_score`.
  - Se o alvo for uma tarefa de programação, recomendamos executar adicionalmente o comando com `-d scbench_repoqa`. Isso permite que o modelo use as pontuações máximas de cabeçalho de ambas as linguagens natural e de programação, melhorando o desempenho.
- Essas pontuações podem ser integradas diretamente com o motor de inferência otimizado do [DuoAttention](https://github.com/mit-han-lab/duo-attention) substituindo os dados de pontuação de cabeçalho deles pelos nossos.


## Avaliação
- Para gerar respostas do modelo com razões de compressão KV variando de 0.1 a 1.0:
    ```bash
    python -B eval.py -m [nome_modelo] -d [nome_dados] --kv_type retain --num 100
    ``` 
  - Resultados serão salvos em `./results/[nome_dados]`.
  - Datasets suportados estão listados em `data/load.py`.
- Para calcular métricas de avaliação a partir dos resultados gerados:
  ```bash
  python -B -m results.parse -m [nome_modelo] -d [nome_dados]
  ```

## Aplicando a Novos Modelos
Para integrar o KVzip a um novo modelo, você precisará atualizar os seguintes arquivos:
- `attention/attn.py`  
  Modifique a lógica do forward da atenção conforme necessário. Em certos casos, atualizações em kvcache.py e score.py também podem ser requeridas.
- `model/monkeypatch.py`  
  Implemente monkey patching específico do modelo para integração.
- `model/template.py`   
  Defina o prompt do sistema do modelo e os templates de formatação de chat.


## Citação
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## Licença
Licença MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---