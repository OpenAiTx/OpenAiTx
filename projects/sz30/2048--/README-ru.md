<div align="right">
  <details>
    <summary >🌐 Другие языки</summary>
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


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

Улучшенная версия классической игры 2048, теперь с еще большим количеством интересных функций! Это небольшой проект, который я сделал в свободное время — надеюсь, он принесет вам радость!

## 🎯 Введение в игру

2048 — простая, но затягивающая игра на объединение чисел. На сетке 4x4 проведите свайп вверх, вниз, влево или вправо, чтобы объединить плитки с одинаковыми числами. Цель? Достигнуть 2048 (но вы можете продолжать и набирать еще больше очков)!

**Как играть:**
- Используйте стрелки или клавиши WASD для перемещения плиток.
- Когда две плитки с одинаковым числом сталкиваются, они сливаются в одну.
- После каждого хода на случайной пустой клетке появляется новая 2 или 4.
- Игра заканчивается, когда не осталось возможных ходов.

## ✨ Особенности

### 1. Функция Отмены
- Сделали неверный ход? Не переживайте!
- Просто нажмите кнопку "Отмена", чтобы вернуться на шаг назад.
- Вы можете отменять сколько угодно раз, вплоть до самого начала.
- Больше ни одна случайная ошибка не испортит вашу игру!

### 2. Секретный чит-режим
- Введите магическую последовательность: ←←→→ →→←← (влево, влево, вправо, вправо,  вправо, вправо, влево, влево)
- Все плитки волшебным образом превратятся в 128!
- Это пасхалка, просто для веселья.
- Лайфхак: использовать читы весело, но не злоупотребляйте! 😉

## 🎯 Демо

🎯 Играть здесь: [2048.765431.xyz](https://2048.765431.xyz/)
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

**Метод 1: Скачать релиз**
1. Скачайте последнюю версию.
2. Убедитесь, что установлен Python 3.x.
3. Установите зависимости: `pip install flask`
4. Запустите: `python 2048.py`
5. Откройте браузер и перейдите по адресу: [http://localhost:9969](http://localhost:9969)

**Метод 2: Клонировать с GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```

## 🎨 Настройка

Хотите сделать это по-своему? Измените `styles.css` для нового оформления или погрузитесь в `script.js`, чтобы поменять игровой процесс. Весь код снабжен комментариями для легкого редактирования!

## 📝 Лицензия

Лицензия GPL-2.0

## 🤝 Вклад

Все еще обновляется! Приветствуются любые Issues и Pull Requests — давайте сделаем эту игру еще круче вместе!


## 🙏 Благодарности

Благодарим следующих спонсоров за поддержку этого проекта:
- [IDC.REST](https://idc.rest/) — предоставление сервера
- [Serv00](https://www.serv00.com/) — предоставление сервера

---
_Последнее обновление: июнь 2025 г._


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---