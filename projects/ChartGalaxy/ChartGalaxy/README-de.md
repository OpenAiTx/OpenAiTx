![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/title.png)

## Datensatz
> 📦 **[👉 Greifen Sie auf den vollständigen ChartGalaxy-Datensatz bei Hugging Face zu! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

Aufgrund von Speicherbeschränkungen enthalten wir nur eine Auswahl repräsentativer Beispiele. 
Dieses Repository enthält den zugehörigen Code zum Paper "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation".

## 🔥 Neuigkeiten
**2025.5**:  🎉🎉 Wir haben die erste Version unseres Datensatzes veröffentlicht, der 1.151.087 synthetische und 104.519 reale Infografik-Diagramme umfasst und 75 Diagrammtypen sowie 330 Varianten abdeckt.

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/teaser.png" style="border:none;box-shadow:none;">

![Beispielbild](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/examples.png)

<!-- ## 🔔 Neuigkeiten -->

## Einführung

### Über

ChartGalaxy ist ein millionengroßer Datensatz aus synthetischen und realen Infografik-Diagrammen mit zugehörigen Datentabellen, der Anwendungen im Bereich Infografik-Diagrammverständnis, Code-Generierung und Diagrammerstellung unterstützt. Der Datensatz adressiert die Herausforderung, dass existierende Datensätze meist auf einfache Diagramme beschränkt sind und die vielfältigen Designstile und Layouts, die charakteristisch für Infografik-Diagramme sind, nicht erfassen.

### Statistiken

- **Größe**: 1.255.606 Infografik-Diagramme (1.151.087 synthetisch + 104.519 real)
- **Inhalt**: Jedes Infografik-Diagramm ist mit den zur Erstellung verwendeten Tabellendaten verknüpft
- **Diagrammtypen**: 75 Diagrammtypen mit 330 Diagrammvariationen
- **Layout-Vorlagen**: 68 Layout-Vorlagen

### Datenerhebung und -erstellung

ChartGalaxy wurde aufgebaut durch:

1. **Sammlung realer Infografik-Diagramme**: Diagramme wurden von 19 renommierten, diagrammreichen Webseiten gesammelt, darunter Pinterest, Visual Capitalist, Statista und Information is Beautiful.

2. **Erstellung synthetischer Infografik-Diagramme**: Ein induktiver Strukturierungsprozess, der:
   - 75 Diagrammtypen (z.B. Balkendiagramme) und 330 Diagrammvarianten mit unterschiedlichen visuellen Stilrichtungen identifiziert
   - 68 Layout-Vorlagen extrahiert, die die räumlichen Beziehungen zwischen Elementen definieren
   - Synthetische Diagramme programmatisch basierend auf diesen Mustern generiert

## 🎯 Anwendungen

Die Nützlichkeit von ChartGalaxy wird durch drei repräsentative Anwendungen demonstriert:

### 1. 🧠 Verständnis von Infografik-Diagrammen

Das Feintuning auf ChartGalaxy verbessert die Leistung von Foundation Models beim Verständnis von Infografik-Diagrammen. 

### 2. 💻 Code-Generierung für Infografik-Diagramme

Ein Benchmark zur Bewertung der Code-Generierung von LVLMs für Infografik-Diagramme. Der Benchmark bewertet die Ähnlichkeit zwischen Diagrammen, die durch generierten D3.js-Code dargestellt werden, und den Ground-Truth-Diagrammen auf zwei Granularitätsebenen: Hoch (allgemeine visuelle Ähnlichkeit) und Niedrig (durchschnittliche Ähnlichkeit über feingranulare SVG-Elemente).

#### Übersicht

Der Benchmark bewertet die Diagramm-Code-Generierung auf zwei Ebenen:
- **Niedrig**: Elementweise Ähnlichkeit zwischen generierten und Referenz-SVGs
- **Hoch**: Gesamtbewertung der visuellen Treue und Funktionalität

#### Installation

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### Nutzung

1. Einstellungen in `code_generation_benchmark/configs/default_config.yaml` konfigurieren:
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
     # Kommentieren Sie die Modelle ein, die Sie evaluieren möchten
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

2. Benchmark ausführen:
   ```bash
   python main.py
   ```

#### Datenstruktur

Jeder Diagrammordner im `data_root_dir` sollte enthalten:
- `chart.svg`: Originaldiagramm im SVG-Format

Das System generiert:
- `convert_chart.html`: HTML-Rendering des Referenzdiagramms
- `convert_chart.png`: PNG-Screenshot des Referenzdiagramms
- `convert_chart.json`: Elementstruktur des Referenzdiagramms
- Modell-spezifische Ausgaben in Unterordnern

#### Ergebnisse

Die Ergebnisse werden in modell-spezifischen Unterordnern gespeichert mit:
- Generierten HTML/PNG-Renderings
- Auswertungsmetriken im JSON-Format
- Detaillierten Logs im `log_dir`
  

### 3. 🖼️ Beispielbasierte Infografik-Diagramm-Generierung

Eine beispielbasierte Methode, die vom Benutzer bereitgestellte Tabellendaten in ein Infografik-Diagramm umwandelt, das mit dem Layout und dem visuellen Stil eines Beispiel-Diagramms übereinstimmt. Benutzerstudien zeigen, dass diese Methode GPT-Image-1 in Bezug auf Treue, Ästhetik und Kreativität übertrifft.


## Kontakt
- chartgalaxy@163.com

## Paper-Links

### 📌 Hauptartikel (Dieses Repository)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### Relevante Veröffentlichungen

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 Zitation
Wenn Sie ChartGalaxy in Ihrer Forschung verwenden, zitieren Sie bitte:
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