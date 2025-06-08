![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/title.png)

## Dataset
> 📦 **[👉 Accedi al dataset completo di ChartGalaxy su Hugging Face! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

A causa di limitazioni di spazio, includiamo solo una raccolta di esempi rappresentativi.  
Questo repository contiene il codice associato all’articolo "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation".

## 🔥 Novità
**2025.5**:  🎉🎉 Abbiamo rilasciato la prima versione del nostro dataset, che include 1.151.087 grafici infografici sintetici e 104.519 reali, coprendo 75 tipologie di grafici e 330 varianti.

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/teaser.png" style="border:none;box-shadow:none;">

![Immagine esempi](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/examples.png)

<!-- ## 🔔 News -->

## Introduzione

### Informazioni

ChartGalaxy è un dataset su scala milione di grafici infografici sintetici e reali con tabelle dati, che supporta applicazioni nella comprensione di grafici infografici, generazione di codice e generazione di grafici. Il dataset affronta la sfida che i dataset esistenti sono per lo più limitati a grafici semplici, non riuscendo a catturare la vasta gamma di stili di design e layout che sono caratteristiche chiave dei grafici infografici.

### Statistiche

- **Dimensione**: 1.255.606 grafici infografici (1.151.087 sintetici + 104.519 reali)
- **Contenuto**: Ogni grafico infografico è abbinato ai dati tabellari utilizzati per crearlo
- **Tipi di grafici**: 75 tipologie di grafici con 330 varianti
- **Template di layout**: 68 template di layout

### Raccolta e Creazione dei Dati

ChartGalaxy è stato costruito attraverso:

1. **Raccolta di grafici infografici reali**: I grafici sono stati raccolti da 19 siti web ricchi di grafici, come Pinterest, Visual Capitalist, Statista e Information is Beautiful.

2. **Creazione di grafici infografici sintetici**: Segue un processo di strutturazione induttiva che:
   - Identifica 75 tipologie di grafici (ad esempio, grafici a barre) e 330 varianti che riflettono diversi stili di elementi visivi
   - Estrae 68 template di layout che definiscono le relazioni spaziali tra gli elementi
   - Genera programmaticamente grafici sintetici basati su questi schemi

## 🎯 Applicazioni

L’utilità di ChartGalaxy è dimostrata attraverso tre applicazioni rappresentative:

### 1. 🧠 Comprensione dei grafici infografici

Il fine-tuning su ChartGalaxy migliora le prestazioni dei modelli di base nella comprensione dei grafici infografici.

### 2. 💻 Generazione di codice per grafici infografici

Un benchmark per valutare la generazione di codice da parte dei LVLM per i grafici infografici. Il benchmark valuta la somiglianza tra i grafici resi dal codice D3.js generato e quelli reali su due livelli di granularità: alto livello (somiglianza visiva complessiva) e basso livello (somiglianza media tra elementi SVG di dettaglio).

#### Panoramica

Il benchmark valuta la generazione di codice per grafici su due livelli:
- **Basso livello**: Somiglianza elemento per elemento tra SVG generati e di riferimento
- **Alto livello**: Valutazione della fedeltà visiva e funzionalità complessiva

#### Installazione

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### Utilizzo

1. Configura le impostazioni in `code_generation_benchmark/configs/default_config.yaml`:
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # Decommenta i modelli che vuoi valutare
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. Esegui il benchmark:
   ```bash
   python main.py
   ```

#### Struttura dei dati

Ogni cartella di grafico in `data_root_dir` deve contenere:
- `chart.svg`: Grafico originale in formato SVG

Il sistema genererà:
- `convert_chart.html`: Rendering HTML del grafico di riferimento
- `convert_chart.png`: Screenshot PNG del grafico di riferimento
- `convert_chart.json`: Struttura degli elementi del grafico di riferimento
- Output specifici per modello in sottocartelle

#### Risultati

I risultati sono salvati in sottocartelle specifiche per modello con:
- Render HTML/PNG generati
- Metriche di valutazione in formato JSON
- Log dettagliati in `log_dir`
  

### 3. 🖼️ Generazione di grafici infografici basata su esempio

Un metodo basato su esempio che trasforma dati tabellari forniti dall’utente in un grafico infografico, allineandosi con il layout e lo stile visivo di un grafico di esempio fornito. Studi con utenti dimostrano che questo metodo supera GPT-Image-1 in fedeltà, estetica e creatività.


## Contatti
- chartgalaxy@163.com

## Link dell’articolo

### 📌 Articolo principale (Questo repository)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### Articoli correlati

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 Citazione
Se utilizzi ChartGalaxy nella tua ricerca, cita:
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---