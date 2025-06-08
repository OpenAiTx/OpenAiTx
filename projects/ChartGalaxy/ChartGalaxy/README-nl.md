![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/title.png)

## Dataset
> 📦 **[👉 Toegang tot de volledige ChartGalaxy dataset op Hugging Face! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

Vanwege opslagbeperkingen bevatten we alleen een verzameling representatieve voorbeelden.  
Deze repository bevat de bijbehorende code voor het paper "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation".

## 🔥 Nieuws
**2025.5**:  🎉🎉 We hebben de eerste versie van onze dataset uitgebracht, die 1.151.087 synthetische en 104.519 echte infografische grafieken bevat, verdeeld over 75 grafiektype en 330 variaties.

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/teaser.png" style="border:none;box-shadow:none;">

![Examples image](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/examples.png)

<!-- ## 🔔 Nieuws -->

## Introductie

### Over

ChartGalaxy is een dataset op miljoenschaal van synthetische en echte infografische grafieken met datatabellen, ter ondersteuning van toepassingen in infografische grafiekbegrip, codegeneratie en grafiekgeneratie. De dataset pakt het probleem aan dat bestaande datasets voornamelijk beperkt zijn tot eenvoudige grafieken, waardoor de diverse stijlen en lay-outs die kenmerkend zijn voor infografische grafieken niet worden vastgelegd.

### Statistieken

- **Omvang**: 1.255.606 infografische grafieken (1.151.087 synthetisch + 104.519 echt)
- **Inhoud**: Elke infografische grafiek is gekoppeld aan de tabulaire data waarmee deze is gemaakt
- **Grafiektypes**: 75 grafiektypes met 330 grafiekvariaties
- **Lay-outsjablonen**: 68 lay-outsjablonen

### Gegevensverzameling en Creatie

ChartGalaxy is opgebouwd door:

1. **Verzameling van echte infografische grafieken**: Grafieken werden verzameld van 19 gerenommeerde websites met veel grafieken, zoals Pinterest, Visual Capitalist, Statista en Information is Beautiful.

2. **Creatie van synthetische infografische grafieken**: Volgens een inductief structureringsproces dat:
   - 75 grafiektypes identificeert (bijv. staafdiagrammen) en 330 variaties die verschillende stijlen van visuele elementen weergeven
   - 68 lay-outsjablonen extraheert die de ruimtelijke relaties tussen elementen definiëren
   - Synthetische grafieken programmeert op basis van deze patronen

## 🎯 Toepassingen

Het nut van ChartGalaxy wordt aangetoond via drie representatieve toepassingen:

### 1. 🧠 Infografische Grafiekbegrip

Fijn afstemmen op ChartGalaxy verbetert de prestaties van basismodellen bij het begrijpen van infografische grafieken.

### 2. 💻 Codegeneratie voor Infografische Grafieken

Een benchmark voor het beoordelen van codegeneratie door LVLM's voor infografische grafieken. De benchmark evalueert de gelijkenis tussen grafieken die door de gegenereerde D3.js-code worden weergegeven en de grondwaarheid op twee niveaus van granulariteit: hoog niveau (algemene visuele gelijkenis) en laag niveau (gemiddelde gelijkenis over fijne SVG-elementen).

#### Overzicht

De benchmark beoordeelt grafiekcodegeneratie op twee niveaus:
- **Laag niveau**: Elementgewijze gelijkenis tussen gegenereerde en referentie-SVG's
- **Hoog niveau**: Algemene visuele getrouwheid en functionele beoordeling

#### Installatie

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### Gebruik

1. Stel de configuratie in `code_generation_benchmark/configs/default_config.yaml` in:
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
     # Haal het commentaar weg bij de modellen die u wilt evalueren
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

2. Voer de benchmark uit:
   ```bash
   python main.py
   ```

#### Datastructuur

Elke grafiekmap in `data_root_dir` dient te bevatten:
- `chart.svg`: Originele grafiek in SVG-formaat

Het systeem genereert:
- `convert_chart.html`: HTML-weergave van de referentiegrafiek
- `convert_chart.png`: PNG-screenshot van de referentiegrafiek
- `convert_chart.json`: Elementstructuur van de referentiegrafiek
- Model-specifieke output in submappen

#### Resultaten

Resultaten worden opgeslagen in model-specifieke submappen met:
- Gegenereerde HTML/PNG-weergaven
- Evaluatiekenmerken in JSON-formaat
- Gedetailleerde logs in `log_dir`
  

### 3. 🖼️ Voorbeeldgebaseerde Generatie van Infografische Grafieken

Een voorbeeldgebaseerde methode die door de gebruiker aangeleverde tabulaire data omzet in een infografische grafiek, in overeenstemming met de lay-out en visuele stijl van een gegeven voorbeeldgrafiek. Gebruikersonderzoeken tonen aan dat deze methode GPT-Image-1 overtreft op getrouwheid, esthetiek en creativiteit.

## Contact
- chartgalaxy@163.com

## Paperlinks

### 📌 Hoofdpublicatie (Deze Repository)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### Relevante Publicaties

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 Referentie
Als u ChartGalaxy gebruikt in uw onderzoek, citeer dan als volgt:
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