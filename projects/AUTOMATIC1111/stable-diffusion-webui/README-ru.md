# Stable Diffusion web UI
Веб-интерфейс для Stable Diffusion, реализованный с использованием библиотеки Gradio.

![](screenshot.png)

## Возможности
[Детальный обзор возможностей с изображениями](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- Оригинальные режимы txt2img и img2img
- Скрипт установки и запуска в один клик (но всё равно необходимо установить python и git)
- Outpainting
- Inpainting
- Color Sketch
- Prompt Matrix
- Stable Diffusion Upscale
- Внимание, возможность указать части текста, на которые модель должна обратить больше внимания
    - a man in a `((tuxedo))` — больше внимания к фразе tuxedo
    - a man in a `(tuxedo:1.21)` — альтернативный синтаксис
    - выделите текст и нажмите `Ctrl+Up` или `Ctrl+Down` (или `Command+Up` или `Command+Down` на MacOS), чтобы автоматически изменить уровень внимания к выделенному тексту (код предоставлен анонимным пользователем)
- Loopback, многократная обработка изображения через img2img
- X/Y/Z plot, трёхмерная визуализация изображений с разными параметрами
- Textual Inversion
    - неограниченное количество эмбеддингов с любыми именами
    - поддержка нескольких эмбеддингов с разным количеством векторов на токен
    - работает с половинной точностью чисел с плавающей запятой
    - обучение эмбеддингов на 8 ГБ (также имеются сообщения о работе на 6 ГБ)
- Вкладка Extras с:
    - GFPGAN, нейросеть для исправления лиц
    - CodeFormer, инструмент восстановления лиц в качестве альтернативы GFPGAN
    - RealESRGAN, нейросетевой апскейлер
    - ESRGAN, нейросетевой апскейлер с поддержкой множества сторонних моделей
    - SwinIR и Swin2SR ([см. здесь](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), нейросетевые апскейлеры
    - LDSR, латентное диффузионное сверхразрешение
- Опции изменения соотношения сторон при изменении размера
- Выбор метода сэмплирования
    - Настройка значения eta для сэмплера (множитель шума)
    - Дополнительные опции для настройки шума
- Возможность прервать процесс в любое время
- Поддержка видеокарт 4 ГБ (имеются сообщения о работе на 2 ГБ)
- Корректные сиды для пакетов изображений
- Проверка длины токенов промпта в реальном времени
- Параметры генерации
     - параметры, использованные для генерации, сохраняются вместе с изображением
     - в PNG chunk для PNG, в EXIF для JPEG
     - можно перетащить изображение во вкладку PNG info для восстановления параметров генерации и автоматического копирования их в интерфейс
     - может быть отключено в настройках
     - поддержка drag-and-drop изображения/текста-параметров в окно промпта
- Кнопка Read Generation Parameters, загружает параметры из promptbox в UI
- Страница настроек
- Запуск произвольного python-кода из UI (необходимо запускать с `--allow-code`)
- Подсказки при наведении мыши на большинство элементов UI
- Возможность изменять значения по умолчанию/min/max/step для элементов UI через текстовую конфигурацию
- Поддержка тайлинга — чекбокс для создания текстурируемых изображений
- Прогресс-бар и предварительный просмотр изображения в реальном времени
    - Можно использовать отдельную нейросеть для предпросмотра, почти не требующую VRAM и вычислений
- Negative prompt — дополнительное текстовое поле для указания того, что вы не хотите видеть на изображении
- Стили — возможность сохранять часть промпта и быстро применять их через выпадающий список
- Вариации — генерация похожих изображений с небольшими отличиями
- Seed resizing — генерация того же изображения при слегка изменённом разрешении
- CLIP interrogator — кнопка, пытающаяся угадать промпт по изображению
- Редактирование промпта — возможность изменять промпт во время генерации, например, начать с арбуза и перейти к аниме-девушке
- Пакетная обработка — обработка группы файлов через img2img
- Img2img Alternative — обратный метод Эйлера для управления cross-attention
- Highres Fix — быстрый способ получить изображение высокого разрешения без обычных искажений
- Горячая перезагрузка контрольных точек
- Объединение контрольных точек (Checkpoint Merger) — вкладка для слияния до 3 чекпоинтов в один
- [Пользовательские скрипты](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) с множеством расширений от сообщества
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/) — одновременное использование нескольких промптов
     - разделяйте промпты с помощью заглавного `AND`
     - поддержка весов для промптов: `a cat :1.2 AND a dog AND a penguin :2.2`
- Нет лимита на количество токенов в промпте (оригинальный stable diffusion позволяет до 75 токенов)
- Интеграция DeepDanbooru — автоматическая генерация тегов в стиле danbooru для аниме-промптов
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers) — значительный прирост скорости для определённых видеокарт (добавьте `--xformers` в параметры командной строки)
- через расширение: [History tab](https://github.com/yfszzx/stable-diffusion-webui-images-browser): удобный просмотр, управление и удаление изображений прямо из UI
- Опция бесконечной генерации
- Вкладка Training
     - опции для гиперсетей и эмбеддингов
     - Предобработка изображений: обрезка, отражение, автотегирование с использованием BLIP или deepdanbooru (для аниме)
- Clip skip
- Гиперсети (Hypernetworks)
- Loras (то же, что и Hypernetworks, но более удобные)
- Отдельный интерфейс для выбора с предпросмотром, какие эмбеддинги, гиперсети или Loras добавить в промпт
- Возможность выбрать другой VAE в настройках
- Прогнозируемое время завершения в прогресс-баре
- API
- Поддержка специализированной [inpainting-модели](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) от RunwayML
- через расширение: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients) — генерация изображений с определённой эстетикой с помощью clip-эмбеддингов (реализация [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- Поддержка [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) — инструкции см. на [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20)
- Поддержка [Alt-Diffusion](https://arxiv.org/abs/2211.06679) — инструкции см. на [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion)
- Теперь без "плохих букв"!
- Загрузка чекпоинтов в формате safetensors
- Ослаблено ограничение разрешения: теперь размеры изображения должны быть кратны 8, а не 64
- Теперь с лицензией!
- Перестановка элементов UI из настроек
- Поддержка [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## Установка и запуск
Убедитесь, что выполнены все необходимые [зависимости](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies), и следуйте инструкциям для:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (рекомендуется)
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPU.
- [Intel CPU, Intel GPU (интегрированные и дискретные)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (внешняя wiki-страница)
- [Ascend NPU](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (внешняя wiki-страница)

Или используйте онлайн-сервисы (например, Google Colab):

- [Список онлайн-сервисов](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Установка на Windows 10/11 с NVidia-GPU через релиз-пакет
1. Скачайте `sd.webui.zip` из [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) и распакуйте содержимое.
2. Запустите `update.bat`.
3. Запустите `run.bat`.
> Подробнее см. [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Автоматическая установка на Windows
1. Установите [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (Более новая версия Python не поддерживает torch), отметьте "Add Python to PATH".
2. Установите [git](https://git-scm.com/download/win).
3. Скачайте репозиторий stable-diffusion-webui, например, выполнив `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`.
4. Запустите `webui-user.bat` из проводника Windows как обычный пользователь (не от администратора).

### Автоматическая установка на Linux
1. Установите зависимости:
```bash
# На базе Debian:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# На базе Red Hat:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# На базе openSUSE:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# На базе Arch:
sudo pacman -S wget git python3
```
Если ваша система очень новая, установите python3.11 или python3.10:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # не путать с пакетом python3.11

# Только для 3.11
# Затем установите переменную окружения в launch-скрипте
export python_cmd="python3.11"
# или в webui-user.sh
python_cmd="python3.11"
```
2. Перейдите в каталог, куда хотите установить webui, и выполните команду:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
Или просто клонируйте репозиторий куда хотите:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. Запустите `webui.sh`.
4. Проверьте `webui-user.sh` на наличие опций.
### Установка на Apple Silicon

Инструкции найдёте [здесь](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon).

## Вклад в проект
Как внести свой код в этот репозиторий: [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## Документация

Документация была перенесена из этого README в [wiki проекта](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki).

Чтобы Google и другие поисковики могли индексировать wiki, вот ссылка на (не для людей) [crawlable wiki](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki).

## Благодарности
Лицензии на заимствованный код можно найти в экране `Settings -> Licenses`, а также в файле `html/licenses.html`.

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel реализует
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- Идеи для оптимизации - https://github.com/basujindal/stable-diffusion
- Оптимизация слоя Cross Attention - Doggettx - https://github.com/Doggettx/stable-diffusion, оригинальная идея для редактирования промпта.
- Оптимизация слоя Cross Attention - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (изначально http://github.com/lstein/stable-diffusion)
- Sub-quadratic Cross Attention layer optimization - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textual Inversion - Rinon Gal - https://github.com/rinongal/textual_inversion (мы не используем его код, но используем его идеи).
- Идея для SD upscale - https://github.com/jquesnelle/txt2imghd
- Генерация шума для outpainting mk2 - https://github.com/parlance-zz/g-diffuser-bot
- Идея и часть кода CLIP interrogator - https://github.com/pharmapsychotic/clip-interrogator
- Идея для Composable Diffusion - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru — interrogator для anime diffusers https://github.com/KichangKim/DeepDanbooru
- Сэмплирование в float32 precision из float16 UNet — marunine за идею, Birch-san за пример реализации в Diffusers (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix — Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) — https://github.com/timothybrooks/instruct-pix2pix
- Советы по безопасности — RyotaK
- UniPC sampler — Wenliang Zhao — https://github.com/wl-zhao/UniPC
- TAESD — Ollin Boer Bohan — https://github.com/madebyollin/taesd
- LyCORIS — KohakuBlueleaf
- Restart sampling — lambertae — https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile — tfernd — https://github.com/tfernd/HyperTile
- Начальный скрипт Gradio — выложен на 4chan анонимным пользователем. Спасибо, анонимный пользователь.
- (Вы)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---