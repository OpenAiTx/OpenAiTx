
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/WtxwNs/BACH/main/tokenpair.png" width="85%"/>
  <br><br>
  <i>Посмотрите, как BACH превращает исходные токены в структурированную музыку — шаг за шагом.</i>
</p>

# BACH: Помощник по композитору на уровне такта  
<p align="center">
  <a href="https://arxiv.org/abs/2508.01394">
    <img src="https://img.shields.io/badge/arXiv-2508.01394-b31b1b.svg" alt="arXiv"/>
  </a>
  <a href="https://github.com/WtxwNs/BACH/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/WtxwNs/BACH" alt="License"/>
  </a>
  <img src="https://img.shields.io/github/repo-size/WtxwNs/BACH" alt="Repo Size"/>
  <img src="https://img.shields.io/github/stars/WtxwNs/BACH?style=social" alt="Stars"/>
</p>

&gt; *"От партитуры к исполнению: эффективная генерация длинных песен с возможностью управления человеком на уровне тактов с использованием символической нотации"*  
&gt; Заявка на ICASSP 2026 – **Принято**

---

## 🎼 Одно предложение – краткое описание  
BACH — первый **редактируемый человеком** генератор песен с символикой на **уровне тактов**:  
LLM пишет текст → Transformer создает партитуру ABC → стандартные рендереры воспроизводят музыку **минутной длины, уровня Suno**.  
**1 млрд. параметров**, вывод на **уровне минут**, **SOTA с открытым кодом**.

---

## 📦 Что находится в этом репозитории (предварительный релиз)
| Путь | Описание |
|------|-------------|
| `README.md` | Этот файл |
| `code/` | код для вывода |
| `example.mp3` | пример песни |
| `fig/` | Схема архитектуры |

---

## 🏗️ Архитектура модели (быстрый взгляд)

Пользовательский запрос
Qwen3 — теги текста и стиля
BACH-1B Transformer только-декодер
Партитура ABC (Dual-NTP + Chain-of-Score)

ABC → MIDI → FluidSynth + VOCALOID
Стерео-микс


| Компонент | Ключевая идея |
|-----------|--------------|
| **Dual-NTP** | Совместное предсказание `{vocal_patch, accomp_patch}` на каждом шаге |
| **Chain-of-Score** | Теги секций `[START:Chorus] ... [END:Chorus]` для долгосрочной связности |
| **Bar-stream patch** | 16-символьные неперекрывающиеся патчи на такт |

---

## 🧪 Быстрый старт (дружественно к CPU)
```bash
# 1. Clone
git clone https://github.com/your-github/BACH.git
cd BACH

# 2. Install
pip install -r requirements.txt        # transformers>=4.41 mido abcpy fluidsynth

# 3. Generate ABC
python bach/generate.py \
    --prompt "A rainy-day lo-fi hip-hop song about missing the last train" \
    --out_abc demo/rainy_lofi.abc

# 4. Render audio
```

##  🎧 Слушайте сейчас
example.mp3 готов для вас, это целая песня. Вы можете сравнить её с Suno🙂

## Полный релиз после принятия соответствующей статьи
- Полный обучающий набор (ABC + тексты песен + метки структуры)
- Веса BACH-1B (формат Transformers)
- Скрипты для обучения (многоэтапное + многозадачное + ICL)
- Полный код

## 📎 Цитирование
Статья опубликована на Arxiv,
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={От партитуры к исполнению: эффективная генерация длинных музыкальных произведений с возможностью управления человеком на уровне тактов с использованием символической нотации}, 
      author={Тонгси Ван и Янг Ю и Цин Ван и Джунлан Цянь},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---