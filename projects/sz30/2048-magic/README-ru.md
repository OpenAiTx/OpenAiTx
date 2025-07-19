<div align="right">
  <details>
    <summary >🌐 Другой язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

Улучшенная версия классической игры 2048, теперь с еще большим количеством интересных функций! Это небольшой проект, который я сделал в свободное время — надеюсь, он принесет вам удовольствие!

## 🎯 Введение в игру

2048 — простая, но захватывающая игра на объединение чисел. На сетке 4x4 сдвигайте плитки вверх, вниз, влево или вправо, чтобы объединять плитки с одинаковыми числами. Цель? Достичь 2048 (но вы можете играть дальше и набирать еще больше очков)!

**Как играть:**
- Используйте стрелки или клавиши WASD для перемещения плиток.
- Когда две плитки с одинаковым числом сталкиваются, они объединяются в одну.
- После каждого хода на пустом месте случайным образом появляется новая плитка 2 или 4.
- Игра заканчивается, когда больше не остается возможных ходов.

## ✨ Особые функции

### 1. Функция отмены
- Сделали неверный ход? Не беда!
- Просто нажмите кнопку "Отмена", чтобы вернуться на шаг назад.
- Можно отменять неограниченное количество раз, вплоть до самого начала.
- Не позволяйте ошибке испортить вашу партию!

### 2. Секретный режим читов
- Введите магическую последовательность: ←←→→ →→←← (влево, влево, вправо, вправо, вправо, вправо, влево, влево)
- Все плитки магически превратятся в 128!
- Это пасхалка, просто для веселья.
- Совет: Читить весело, но не переусердствуйте! 😉

## 🎯 Демо

🎯 Играть здесь: [http://2048.ct8.pl](http://2048.ct8.pl:9969/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 Структура проекта
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**Описание файлов:**
- `2048.py`: Серверная часть на Flask, обрабатывает игровую логику и API-запросы.
- `script.js`: Логика игры на фронтенде, включая ходы, анимации и специальные функции.
- `styles.css`: Стили игры, обеспечивающие красивый и адаптивный внешний вид.
- `index.html`: Главная страница, объединяющая все компоненты.

## 🚀 Начало работы

**Способ 1: Скачать релиз**
1. Скачайте последний релиз.
2. Убедитесь, что установлен Python 3.x.
3. Установите зависимости: `pip install flask`
4. Запустите: `python 2048.py`
5. Откройте браузер и перейдите по адресу: [http://localhost:9969](http://localhost:9969)

**Способ 2: Клонировать с GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 Настройка

Хотите сделать это по-своему? Изменяйте `styles.css` для нового внешнего вида или редактируйте `script.js`, чтобы изменить игровой процесс. Весь код подробно прокомментирован для удобства модификации!

## 📝 Лицензия

Лицензия GPL-2.0

## 🤝 Вклад

Проект всё ещё обновляется! Ошибки и Pull Requests очень приветствуются — давайте сделаем эту игру ещё лучше вместе!


## 🙏 Благодарности

Благодарим следующих спонсоров за поддержку этого проекта:
- [Serv00](https://www.serv00.com/) за предоставление сервера

---
_Последнее обновление: июнь 2025_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---