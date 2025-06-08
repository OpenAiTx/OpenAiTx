![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/title.png)

## Zbiór danych
> 📦 **[👉 Uzyskaj pełny dostęp do zbioru danych ChartGalaxy na Hugging Face! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

Ze względu na ograniczenia magazynowania, zawieramy jedynie zbiór reprezentatywnych przykładów.  
To repozytorium zawiera powiązany kod do artykułu "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation".

## 🔥 Aktualności
**2025.5**:  🎉🎉 Udostępniliśmy pierwszą wersję naszego zbioru danych, który obejmuje 1 151 087 syntetycznych oraz 104 519 rzeczywistych wykresów infograficznych, pokrywając 75 typów wykresów i 330 wariantów.

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/teaser.png" style="border:none;box-shadow:none;">

![Examples image](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/examples.png)

<!-- ## 🔔 News -->

## Wprowadzenie

### O projekcie

ChartGalaxy to milionowy zbiór syntetycznych i rzeczywistych wykresów infograficznych wraz z tabelami danych, wspierający zastosowania w rozumieniu wykresów infograficznych, generowaniu kodu oraz tworzeniu wykresów. Zbiór danych odpowiada na wyzwanie, że istniejące zbiory danych są głównie ograniczone do prostych wykresów, nie oddając różnorodności stylów projektowych i układów, które są kluczową cechą wykresów infograficznych.

### Statystyki

- **Rozmiar**: 1 255 606 wykresów infograficznych (1 151 087 syntetycznych + 104 519 rzeczywistych)
- **Zawartość**: Każdy wykres infograficzny jest powiązany z tabelarycznymi danymi użytymi do jego stworzenia
- **Typy wykresów**: 75 typów wykresów i 330 wariantów
- **Szablony układów**: 68 szablonów układów

### Zbieranie i tworzenie danych

ChartGalaxy został skonstruowany poprzez:

1. **Zbiór rzeczywistych wykresów infograficznych**: Wykresy zebrano z 19 renomowanych stron bogatych w wykresy, takich jak Pinterest, Visual Capitalist, Statista i Information is Beautiful.

2. **Tworzenie syntetycznych wykresów infograficznych**: Zgodnie z procesem indukcyjnego strukturyzowania, który:
   - Identyfikuje 75 typów wykresów (np. wykresy słupkowe) i 330 wariantów odzwierciedlających różne style elementów wizualnych
   - Ekstrahuje 68 szablonów układów definiujących relacje przestrzenne między elementami
   - Programistycznie generuje syntetyczne wykresy na podstawie tych wzorców

## 🎯 Zastosowania

Użyteczność ChartGalaxy została pokazana poprzez trzy reprezentatywne zastosowania:

### 1. 🧠 Rozumienie wykresów infograficznych

Dostrajanie na ChartGalaxy poprawia wydajność modeli bazowych w zakresie rozumienia wykresów infograficznych.

### 2. 💻 Generowanie kodu wykresów infograficznych

Benchmark do oceny generowania kodu przez LVLM dla wykresów infograficznych. Benchmark ocenia podobieństwo między wykresami renderowanymi przez wygenerowany kod D3.js a wykresami referencyjnymi na dwóch poziomach szczegółowości: wysokim (ogólne podobieństwo wizualne) i niskim (średnie podobieństwo na poziomie szczegółowych elementów SVG).

#### Przegląd

Benchmark ocenia generowanie kodu wykresów na dwóch poziomach:
- **Niskim**: Podobieństwo element-po-elemencie pomiędzy wygenerowanymi i referencyjnymi SVG
- **Wysokim**: Ogólna ocena wierności wizualnej i funkcjonalności

#### Instalacja

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### Użycie

1. Skonfiguruj ustawienia w `code_generation_benchmark/configs/default_config.yaml`:
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
     # Odkomentuj modele, które chcesz ocenić
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

2. Uruchom benchmark:
   ```bash
   python main.py
   ```

#### Struktura danych

Każdy folder wykresu w `data_root_dir` powinien zawierać:
- `chart.svg`: Oryginalny wykres w formacie SVG

System wygeneruje:
- `convert_chart.html`: Renderowanie HTML wykresu referencyjnego
- `convert_chart.png`: Zrzut ekranu PNG wykresu referencyjnego
- `convert_chart.json`: Struktura elementów wykresu referencyjnego
- Wyniki specyficzne dla modelu w podfolderach

#### Wyniki

Wyniki są zapisywane w podfolderach specyficznych dla modelu i zawierają:
- Wygenerowane renderingi HTML/PNG
- Metryki ewaluacyjne w formacie JSON
- Szczegółowe logi w `log_dir`
  

### 3. 🖼️ Generowanie wykresów infograficznych na podstawie przykładu

Metoda bazująca na przykładzie, która przekształca dostarczone przez użytkownika dane tabelaryczne w wykres infograficzny, zachowując układ i styl wizualny wybranego przykładu. Badania z udziałem użytkowników pokazują, że metoda ta przewyższa GPT-Image-1 pod względem wierności, estetyki i kreatywności.

## Kontakt
- chartgalaxy@163.com

## Linki do artykułów

### 📌 Główny artykuł (to repozytorium)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### Powiązane artykuły

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 Cytowanie
Jeśli korzystasz z ChartGalaxy w swoich badaniach, zacytuj proszę:
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