<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# AI Novel Editor

AI-редактор романов на базе PyQt6, предоставляющий профессиональные инструменты для письма, такие как интеллектуальное автодополнение, управление проектами, организация концепций и др.

## Установка

1. Клонировать проект
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Создать виртуальное окружение
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```
Использование uv
```bash
uv venv -p 3.11
```
3. Установка зависимостей
```bash
pip install -r requirements.txt
```
Использование uv
```bash
uv sync
```


4. Запуск программы
```bash
python -m src
```

## Основные функции

### Управление проектами
- Иерархическая структура документа (Произведение > Глава > Сцена)
- Импорт и экспорт проектов (поддержка форматов TEXT, MARKDOWN, DOCX, PDF, HTML)
- Автоматическое резервное копирование и контроль версий
- Управление несколькими проектами
### Функция AI-дополнения
- Три режима дополнения: автоматическое дополнение, ручное дополнение (рекомендуется: одно нажатие Tab для вызова, еще одно нажатие Tab для применения дополнения), отключение дополнения
- Три режима контекста:
  - Быстрый режим: легковесный контекст, быстрая реакция
  - Сбалансированный режим: средний контекст, баланс качества и скорости
  - Глобальный режим: полный контекст проекта, наилучший эффект
- Поддержка различных AI-сервисов: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq и др.

### Управление оглавлением
- Визуализированная древовидная структура оглавления
- Перетаскивание для сортировки и изменения иерархии
- Быстрая навигация по документу
- Анализ оглавления и рекомендации по оптимизации

### Настройка API
- Единый центр настройки AI
- Предустановленные настройки для разных провайдеров
- Функция тестирования соединения
- Сохранение и импорт/экспорт конфигураций
### Настройки интеллектуального автодополнения
- Регулируемая задержка срабатывания
- Ограничение длины автодополнения
- Настройка длины контекста
- Поддержка потоковой передачи ответов

### Редактирование промптов
- Встроенные шаблоны для письма
- Пользовательские шаблоны промптов
- Управление категориями шаблонов
- Настройка шаблонов для определённых режимов

### Функции интерфейса
- Светлая и тёмная темы
- Трёхколоночная компоновка (дерево проектов, редактор, панель концепций)
- Сворачиваемая боковая панель
- Режим полноэкранного письма
- Режим фокусировки (предложение, абзац, машинка, дзэн-режим, иммерсивный режим)

### Поиск и замена
- Поиск по всему проекту
- Поддержка регулярных выражений
- Функция пакетной замены
- Расширенные параметры поиска

### Управление концепциями
- Автоматическое обнаружение ролей, мест, предметов
- Управление связями между концепциями
- Система тегов и классификации
- Быстрая вставка концепций

## Горячие клавиши

- `Ctrl+N`: Создать новый проект
- `Ctrl+O`: Открыть проект
- `Ctrl+S`: Сохранить документ
- `F11`: Полноэкранный режим
- `Tab`: Вручную вызвать автодополнение AI (в ручном режиме)
- `Ctrl+F`: Поиск
- `Ctrl+H`: Найти и заменить
- `Ctrl+Shift+H`: Расширенный поиск и замена
## Системные требования

- Python 3.8+
- PyQt6
- Операционная система: Windows, macOS, Linux

## Автор

**inliver**
- Электронная почта: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---