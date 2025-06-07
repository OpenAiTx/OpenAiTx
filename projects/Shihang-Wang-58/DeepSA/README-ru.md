[![Лицензия: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: Прогнозирование синтетической доступности соединений на основе глубокого обучения

С непрерывным развитием технологий искусственного интеллекта всё больше моделей генерации используются для создания молекул. Однако большинство новых молекул, сгенерированных такими моделями, часто сталкиваются с серьёзными трудностями в синтетической доступности.

DeepSA создан для прогнозирования синтетической доступности соединений и показывает гораздо более высокий уровень раннего выявления молекул, которые сложно синтезировать. Это помогает пользователям выбирать менее дорогие в синтезе молекулы, что сокращает время поиска и разработки лекарственных средств. Вы можете воспользоваться DeepSA на веб-сервере по адресу https://bailab.siais.shanghaitech.edu.cn/deepsa<br/>

## Требования
Зависимости можно установить с помощью следующих команд:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# для версии с gpu
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### Новости 🔔 

* 2024-12, поскольку [AutoGluon прекратил поддержку python версии 3.8](https://github.com/autogluon/autogluon/pull/4512) с октября 2024 года, мы обновили DeepSA до версии Python 3.12 и обновили скрипты обучения и инференса для работы с последней версией AutoGluon. Спасибо за интерес к DeepSA!

* 2023-7, выпущена DeepSA_v1.0, будем рады вашим отзывам и вопросам!

## Данные 
Расширенные обучающие и тестовые наборы данных можно легко скачать по ссылке https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing
## Использование для исследователей
Если вы хотите обучить собственную модель, запустите следующую команду из консоли:

Запуск:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
Если вы хотите использовать нашу предложенную модель,

Запуск:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## Онлайн-сервер

Мы развернули предобученную модель на специальном сервере, который доступен по адресу https://bailab.siais.shanghaitech.edu.cn/deepsa, чтобы исследователи в области биомедицины могли легко использовать DeepSA в своей работе.

Пользователи могут загружать свои SMILES или csv-файлы на сервер и быстро получать прогнозируемые результаты.

## <span id="citelink">Цитирование</span>
Если вы находите этот репозиторий полезным для своих исследований, пожалуйста, процитируйте нашу статью:

Wang, S., Wang, L., Li, F. и др. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## Контакты
Если у вас возникли вопросы, пожалуйста, обращайтесь к Shihang Wang (Email: wangshh12022@shanghaitech.edu.cn) или Lin Wang (Email: wanglin3@shanghaitech.edu.cn). 

Pull-реквесты приветствуются!

## Благодарности
Мы благодарим HPC Platform of ShanghaiTech University за поддержку.<br/>
Спасибо всем за внимание к этой работе.

![График истории звёзд](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---