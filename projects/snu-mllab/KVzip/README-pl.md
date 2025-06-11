# KVzip: Kompresja pamięci podręcznej KV niezależna od zapytań z rekonstrukcją kontekstu

[[Artykuł](https://arxiv.org/abs/2505.23416)] [[Blog](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## Co nowego?
- KVzip kompresuje pamięć podręczną KV, aby wspierać **różnorodne przyszłe zapytania**.
- [Zależne od kontekstu] Osiągnięcie **3–4× redukcji rozmiaru pamięci podręcznej KV** oraz **2× skrócenia czasu dekodowania**, przy minimalnej degradacji wydajności.
- [Niezależne od kontekstu] Ulepszenie kompresji na poziomie głów DuoAttention-style, wykorzystując tylko **kilka przejść w przód w ciągu minuty** do optymalizacji ważności głów (100x szybciej).
- Uruchom demo.py:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### Benchmark w ustawieniu niezależnym od zapytań
- Zadania: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294). 
- Model: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## Instalacja
Używaliśmy CUDA 12.1 i Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- Aby używać kwantyzacji [QServe](https://github.com/mit-han-lab/omniserve), proszę postępować zgodnie z [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model).
### Zbiór danych
- Proszę pobrać przetworzony zbiór danych SCBench z [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link).
- Jeśli pobrałeś rozpakowane pliki, po prostu przenieś folder scbench.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## Szybki start
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "To jest mój podstawowy profil. Nazywam się Kim i mieszkam w Seulu. Mój kierunek to informatyka."
queries = ["Jak mam na imię?", "Czy mieszkam w Seulu?"]

kv = model.prefill(context, load_score=False)  # wstępne wypełnienie pamięci KV + ocena ważności
kv.prune(ratio=0.3)  # współczynnik kompresji, usuwamy 70% KV

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # wydajne wnioskowanie
    print(q, output)
```
- Obsługiwane modele są wymienione w [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), w tym **LLaMA3, Qwen2.5/3, Gemma3**.
- Ustaw `load_score=True`, aby wyeliminować narzut kompresji. Pozwala to na niezależne od kontekstu usuwanie KV, kosztem gorszego współczynnika kompresji `ratio=0.6`.
- Po generacji, pary KV odpowiadające zapytaniom i wygenerowanym tokenom są selektywnie usuwane z pamięci podręcznej do dalszego przetwarzania. Ustaw `update_cache=True`, aby włączyć wnioskowanie wieloetapowe, zachowując pełną historię interakcji przez cały czas inferencji.

## Profilowanie pamięci i czasu obliczeń
### Usuwanie zależne od kontekstu
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- Powyższy kod porównuje także wyniki generowane przy pełnej i przyciętej pamięci KV.
- Do szybkich testów użyj `-d squad`. Do testów długiego kontekstu użyj `-d scbench_kv`.
  - Dostępne nazwy danych: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - Dostępne nazwy modeli: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), np. llama3.1-8b, qwen2.5-7b (lub Qwen/Qwen2.5-7B-Instruct-1M).
- Adaptujemy jądro CUDA z [AdaKV](https://github.com/FFY0/AdaKV/tree/main), wspierające nierównomierną alokację budżetu głów.
  - Obecnie nasz kod nie zawiera zoptymalizowanego jądra dla Gemma3, które używa statycznej pamięci KV, więc kod nie przynosi faktycznych zysków wydajnościowych. Jednak wydajność modelu można nadal ocenić, używając zredukowanej uwagi z podpróbkowaniem KV (`--kv_type retain`).


### Usuwanie niezależne od kontekstu (bez narzutu kompresji w czasie działania)
- Użyj flagi `--level head` z `--ratio 0.6` (zalecane).
  - Usuwamy wszystkie pary KV kontekstu powiązane z daną głową, pozostawiając pary KV systemowego promptu i zapytań.
  - Wstępnie obliczone oceny głów są dostępne dla LLaMA3.1-8B i Qwen2.5-7/14B w `./utils/head_score`.
- Aby obliczyć oceny głów dla innych modeli:
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - Wyniki zostaną zapisane w `./utils/head_score`.
  - Jeśli celem jest zadanie programistyczne, zalecamy dodatkowo uruchomić polecenie z `-d scbench_repoqa`. Pozwala to modelowi korzystać z maksymalnych ocen głów z języka naturalnego i programowania, co poprawia wydajność.
- Te oceny można płynnie zintegrować z zoptymalizowanym silnikiem inferencji [DuoAttention](https://github.com/mit-han-lab/duo-attention), zastępując ich dane ocen głowami naszymi.


## Ewaluacja
- Aby wygenerować odpowiedzi modelu z współczynnikami kompresji KV od 0.1 do 1.0:
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - Wyniki zostaną zapisane w `./results/[data_name]`.
  - Obsługiwane zbiory danych są wymienione w `data/load.py`.
- Aby obliczyć metryki ewaluacyjne na podstawie wygenerowanych wyników:
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## Zastosowanie do nowych modeli
Aby zintegrować KVzip z nowym modelem, należy zaktualizować następujące pliki:
- `attention/attn.py`  
  Modyfikacja logiki przekazywania uwagi (forward pass) według potrzeb. W niektórych przypadkach wymagane są również zmiany w kvcache.py i score.py.
- `model/monkeypatch.py`  
  Implementacja specyficznego dla modelu monkey patchingu do integracji.
- `model/template.py`   
  Definicja systemowego promptu modelu oraz szablonów formatowania czatu.


## Cytowanie
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## Licencja
Licencja MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---