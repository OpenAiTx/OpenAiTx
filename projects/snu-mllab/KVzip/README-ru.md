# KVzip: Сжатие KV-кэша без учета запросов с восстановлением контекста

[[Статья](https://arxiv.org/abs/2505.23416)] [[Блог](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## Что нового?
- KVzip сжимает KV-кэш для поддержки **разнообразных будущих запросов**.
- [Зависимое от контекста] Достигается **сокращение размера KV-кэша в 3–4 раза** и **уменьшение задержки декодирования в 2 раза** при минимальном ухудшении производительности.
- [Независимое от контекста] Улучшение сжатия KV на уровне голов, как в [DuoAttention](https://github.com/mit-han-lab/duo-attention), с использованием всего **нескольких проходов вперед в течение одной минуты** для оптимизации важности голов (в 100 раз быстрее).
- Запуск demo.py:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### Тестирование в условиях отсутствия зависимости от запросов
- Задачи: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294). 
- Модель: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## Установка
Использовались CUDA 12.1 и Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- Для использования квантизации [QServe](https://github.com/mit-han-lab/omniserve), пожалуйста, следуйте инструкции в [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model).
### Датасет
- Пожалуйста, скачайте предобработанный датасет SCBench с [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link).
- Если скачаны распакованные файлы, просто переместите папку scbench.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## Быстрый старт
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "This is my basic profile. My name is Kim living in Seoul. My major is computer science."
queries = ["What is my name?", "Do I live in Seoul?"]

kv = model.prefill(context, load_score=False)  # заполнение KV-кэша + оценка важности
kv.prune(ratio=0.3)  # коэффициент сжатия, удаление 70% KV

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # эффективный вывод
    print(q, output)
```
- Поддерживаемые модели перечислены в [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), включая **LLaMA3, Qwen2.5/3, Gemma3**.
- Установите `load_score=True` для устранения накладных расходов сжатия. Это включает независимое от контекста удаление KV с компромиссом в коэффициенте сжатия `ratio=0.6`.
- После генерации пары KV, соответствующие запросам и сгенерированным токенам, выборочно удаляются из кэша для дальнейшей обработки. Установите `update_cache=True` для включения многошагового вывода с сохранением полной истории взаимодействий.

## Профилирование памяти и времени вычислений
### Удаление зависимое от контекста
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- Приведённый код также сравнивает результаты генерации с полным и усечённым KV-кэшем.
- Для быстрого теста используйте `-d squad`. Для тестирования с длинным контекстом — `-d scbench_kv`.
  - Доступные имена датасетов: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - Доступные имена моделей: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), например llama3.1-8b, qwen2.5-7b (или Qwen/Qwen2.5-7B-Instruct-1M).
- Мы адаптировали CUDA-ядро из [AdaKV](https://github.com/FFY0/AdaKV/tree/main), поддерживающее неравномерное распределение бюджета на головы.
  - В настоящее время в нашем коде отсутствует оптимизированное ядро для Gemma3, использующего статический KV-кэш, поэтому код не даёт реальных приростов эффективности. Тем не менее, производительность модели можно оценивать с помощью уменьшенного внимания с подвыборкой KV (`--kv_type retain`).


### Удаление независимое от контекста (без накладных расходов во время работы)
- Используйте флаг `--level head` с `--ratio 0.6` (рекомендуется).
  - Мы удаляем все KV пары контекста, связанные с определённой головой, при сохранении системного промпта и пар KV запросов.
  - Предрасчитанные оценки голов доступны для LLaMA3.1-8B и Qwen2.5-7/14B в `./utils/head_score`.
- Чтобы вычислить оценки голов для других моделей:
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - Результаты сохраняются в `./utils/head_score`.
  - Если задача связана с кодированием, рекомендуем дополнительно запустить команду с `-d scbench_repoqa`. Это позволит модели использовать максимальные оценки голов из естественного и кода, что улучшит производительность.
- Эти оценки могут быть легко интегрированы с оптимизированным движком вывода [DuoAttention](https://github.com/mit-han-lab/duo-attention), заменив их данные об оценке голов нашими.


## Оценка
- Для генерации ответов модели с коэффициентами сжатия KV от 0.1 до 1.0:
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - Результаты сохраняются в `./results/[data_name]`.
  - Поддерживаемые датасеты перечислены в `data/load.py`.
- Для вычисления метрик оценки по сгенерированным результатам:
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## Применение к новым моделям
Для интеграции KVzip с новой моделью необходимо обновить следующие файлы:
- `attention/attn.py`  
  При необходимости изменить логику прямого прохода внимания. В некоторых случаях также потребуется обновление kvcache.py и score.py.
- `model/monkeypatch.py`  
  Реализовать специфичные для модели патчи для интеграции.
- `model/template.py`   
  Определить системный промпт и шаблоны форматирования чата для модели.


## Цитирование
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## Лицензия
MIT License

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---