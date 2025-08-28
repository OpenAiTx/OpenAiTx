<details align="right">
<summary>🌐 Язык</summary>

[English](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=th) | [Français](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=de) | [Español](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=it) | [Русский](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ru) | [Português](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=as)
</details>

# OnionHoster v2.2

> **Лучший инструмент для хостинга Tor Hidden Service** - Разверните свои веб-проекты в даркнете за считанные минуты!
> 
[![Версия](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Платформа](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Лицензия](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

<img width="1023" height="551" alt="ChatGPT Image Aug 27, 2025, 03_32_08 PM (1)-modified" src="https://github.com/user-attachments/assets/92b6e834-2d4f-4cc7-8f77-82b9bafba8a5" />


---

## 🚀 Что такое OnionHoster?

OnionHoster — это мощный кроссплатформенный bash-скрипт, который превращает любой веб-проект в Tor Hidden Service всего одной командой. Не важно, размещаете ли вы приложение Next.js, бэкенд Flask или статический сайт — OnionHoster автоматически настроит Tor за вас.

### ✨ Почему стоит выбрать OnionHoster?

- **🔧 Без настройки** — Работает с любым веб-проектом "из коробки"
- **🌍 Кроссплатформенность** — Поддержка Linux, macOS и основных дистрибутивов
- **⚡ Быстрая установка** — От нуля до Hidden Service менее чем за 2 минуты
- **🔄 Автообновление** — Встроенная проверка обновлений поддерживает актуальность
- **💾 Резервное копирование и восстановление** — Никогда не теряйте свои onion-адреса
- **🎯 Профессиональный интерфейс** — Красочный UI с интуитивными меню

---
## Превью

[![IMAGE ALT TEXT HERE](https://github.com/user-attachments/assets/4b35dfb0-0059-4cc5-99c7-a5b9467a385d)](https://www.youtube.com/watch?v=oPvhA54Tp8w)


# ⚠️ Внимание: OnionHoster НЕ является магическим инструментом анонимности — соблюдайте лучшие практики, иначе рискуете потерять анонимность

**Укрепление системы**

* Запускайте сервис внутри виртуальной машины или контейнера для изоляции.

* Держите ОС и пакеты обновленными.
* Отключайте ненужные сервисы/порты, чтобы только Tor-трафик проходил внутрь/наружу.

**Практики OpSec**

* Не используйте одну и ту же машину для личных аккаунтов или деятельности.
* Избегайте раскрытия идентифицирующих метаданных (имена файлов, заголовки, сообщения об ошибках).
* Внимательно относитесь к журналам — что вы записываете, как долго храните и не содержат ли они утечек информации.

**Сетевой гигиеной**

* Не связывайте ваш скрытый сервис с вашей «чистой» личностью или доменом.
* Используйте файрвол для предотвращения случайных утечек вне Tor.
* Рассмотрите обратные прокси для дополнительной изоляции.

**Тестирование и мониторинг**

* Используйте torsocks или Tor Browser, чтобы убедиться, что ваш сервис доступен только через его `.onion`-адрес.
* Регулярно тестируйте на утечки (например, пытается ли ваше приложение обращаться к обычному интернету).

**Осознанность в использовании**

* Для хобби/тестирования/образовательных целей: вышеописанного обычно достаточно.
* Для ситуаций с высоким риском и реальной анонимностью (журналисты, осведомители, активисты): требуется более глубокая операционная безопасность и моделирование угроз, поскольку одна ошибка может раскрыть вашу личность.


---
## 🎯 Идеально для

- **Разработчиков**, которые хотят тестировать свои приложения в Tor
- **Защитников приватности**, размещающих анонимные сервисы (
- **Исследователей**, изучающих технологии даркнета
- **Бизнеса**, которым требуется анонимный хостинг
- **Любителей**, исследующих сеть Tor

---

## 🚀 Быстрый старт

### Предварительные требования
- Доступ root/sudo
- Подключение к интернету
- Любой веб-проект (HTML, Next.js, Flask и т.д.)

### Установка и использование

```bash
# 1. Clone the repository
git clone https://github.com/BlackHatDevX/onionhoster.git

# 2. Navigate to the directory
cd onionhoster

# 3. Make the script executable
chmod +x onionhoster.sh

# 4. Run with sudo
sudo bash onionhoster.sh
```

**Вот и всё!** 🎉

Вы получите полный проект OnionHoster, включая:
- Основной скрипт `onionhoster.sh`
- Профессиональный шаблон `index.html` для размещения
- Всю документацию и примеры

Скрипт автоматически:
- Определяет вашу операционную систему
- Устанавливает все необходимые зависимости (Tor, Apache и др.)
- Настраивает сервисы Tor
- Предлагает интуитивное меню

---

## 🎮 Обзор возможностей

### 🌐 Варианты хостинга
- **Статичный HTML** — размещайте любой файл `index.html`
- **Проброс портов** — перенаправление на любой локальный порт приложения
- **Динамические приложения** — поддержка Next.js, Flask, Node.js и др.

### 🛠️ Инструменты управления
- **Управление сервисом** — запуск, остановка и управление скрытым сервисом
- **Резервное копирование и восстановление** — безопасное резервирование и восстановление onion-доменов
- **Обновление URL** — генерация новых onion-адресов по необходимости
- **Мониторинг статуса** — проверка работоспособности и состояния сервиса

### 🔄 Умные обновления
- **Автообнаружение** — автоматически находит последнюю версию
- **Обновление в один клик** — обновление через одну опцию меню
- **Безопасные обновления** — отсутствие риска потери конфигурации

---

## 📱 Поддерживаемые операционные системы

| ОС | Менеджер пакетов | Статус |
|----|------------------|--------|
| **Ubuntu/Debian** | `apt-get` | ✅ Полная поддержка |
| **CentOS/RHEL** | `yum` | ✅ Полная поддержка |
| **Fedora** | `dnf` | ✅ Полная поддержка |
| **Arch Linux** | `pacman` | ✅ Полная поддержка |
| **macOS** | `brew` | ✅ Полная поддержка |

---

## 🎯 Сценарии использования

### 🏠 Личные проекты
- Разместите портфолио анонимно
- Тестируйте веб-приложения приватно
- Делитесь контентом, не раскрывая свою личность

### 🏢 Бизнес-приложения
- Анонимные порталы поддержки клиентов
- Защищённые внутренние системы связи
- Веб-сайты бизнеса с акцентом на конфиденциальность

### 🔬 Научные исследования и разработки
- Исследования технологий даркнета
- Разработка инструментов для приватности
- Тестирование анонимных сервисов

---

## 📖 Подробное использование

### Основные пункты меню

1. **Хостинг index.html** - Обслуживание статического HTML-файла
2. **Переадресация на порт приложения** - Прокси на любой локальный сервис
3. **Резервное копирование tor-домена** - Сохранение конфигурации onion
4. **Восстановление tor-домена** - Восстановление из резервной копии
5. **Просмотр текущего tor-домена** - Просмотр активного onion-адреса
6. **Обновить tor-домен** - Генерация нового onion-адреса
7. **Проверить обновления** - Обновление до последней версии
8. **Статус веб-сервера** - Мониторинг состояния сервиса
9. **О программе OnionHoster** - Информация о версии и функциях

### Пример рабочего процесса

```bash
# Start the service
sudo ./onionhoster.sh

# Choose option 1 to host index.html
# Your onion address will be displayed
# Access it via Tor Browser or similar
```

---

## 🔧 Расширенная конфигурация

### Пользовательская переадресация портов
```bash
# Forward your Next.js app running on port 3000
# The script will handle all Tor configuration automatically
```

### Управление резервным копированием
```bash
# Automatic backups are stored in ~/onion_backups/
# Each backup includes your onion keys and configuration
```

---

## 🛡️ Функции безопасности

- **Автоматическая настройка Tor** - Безопасные параметры по умолчанию
- **Корректные права доступа к файлам** - Безопасное владение и доступ к файлам
- **Изоляция сервисов** - Каждый скрытый сервис работает независимо
- **Без ведения журналов** - Ваша деятельность остается приватной

---

## 🚨 Важные примечания

- **Требуются права root** - Для настройки сервисов Tor необходим системный доступ
- **Сеть Tor** - Ваш сервис будет доступен через Tor Browser
- **Onion-адреса** - Каждый сервис получает уникальный адрес `.onion`
- **Регулярное резервное копирование** - Onion-адреса меняются при обновлении

---

## 🤝 Вклад в проект

Мы приветствуем ваш вклад! Это может быть:
- 🐛 Сообщения об ошибках
- 💡 Предложения по функциям
- 📝 Улучшение документации
- 🔧 Вклад в код

**Начните с:**
1. Форкните репозиторий
2. Создайте ветку для функции
3. Внесите изменения
4. Отправьте pull-запрос

---

## 📄 Лицензия

Этот проект распространяется по лицензии MIT - см. файл [LICENSE](LICENSE) для подробностей.

---

## 🙏 Благодарности

- **Tor Project** - За потрясающую сеть анонимности
- **Сообщество Open Source** - За постоянные улучшения
- **Пользователи и участники** - За отзывы и предложения

---

## 🔗 Ссылки

- **GitHub**: [https://github.com/BlackHatDevX/onionhoster](https://github.com/BlackHatDevX/onionhoster)
- **Вопросы**: [https://github.com/BlackHatDevX/onionhoster/issues](https://github.com/BlackHatDevX/onionhoster/issues)
- **Обсуждения**: [https://github.com/BlackHatDevX/onionhoster/discussions](https://github.com/BlackHatDevX/onionhoster/discussions)

---

## ⭐ Поддержите проект

Если OnionHoster помогает вам, пожалуйста, поставьте звезду! Это мотивирует нас развиваться дальше и помогает другим находить этот инструмент.

---

**Готовы к анонимности?** 🕵️‍♂️

```bash
git clone https://github.com/BlackHatDevX/onionhoster.git
cd onionhoster
sudo bash onionhoster.sh
```

*Ваш путь к анонимному хостингу начинается прямо сейчас!* 🚀


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---