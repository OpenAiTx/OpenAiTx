<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - Интеллектуальная система чат-бота для платформы Сянъюй

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

AI-решение для автоматизации дежурства на платформе Сянъюй, обеспечивающее 7×24 часа работы, поддержку коллективного принятия решений экспертами, интеллектуального торга и контекстно-осознанных диалогов.

## 🎮 Playground - Быстрый старт (без настройки)

Не требуется локальная среда или настройка Secrets! **Просто передайте параметры через веб-интерфейс GitHub Actions** и одним кликом запустите бота для Сянъюй.

### Как пользоваться
1. **Fork этого репозитория** → нажмите кнопку `Fork` в правом верхнем углу
2. **Запустите Action**:
   - Перейдите на вкладку `Actions` в вашем репозитории
   - Выберите рабочий процесс **`🚀 Run Service`**
   - Нажмите кнопку **`Run workflow`** и заполните параметры:
      - `API Key`: вставьте ваш API-ключ для LLM (например, Aliyun DashScope)
      - `Cookies`: вставьте полную строку Cookie из веб-версии Сянъюй
3. **Просмотр журнала выполнения**:
   - После запуска бот автоматически начнет слушать сообщения Сянъюй
   - Найдите в логах Action строку `🤖 Reply:` для просмотра истории диалогов

### Важные замечания
⚠️ Временные ограничения запуска:
- По умолчанию работает **30 минут** (ограничение бесплатного аккаунта GitHub)
- Конфиденциальная информация (например, Cookie) **не сохраняется**, действует только для текущего запуска

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 Ключевые особенности

### Интеллектуальный диалоговый движок
| Модуль       | Техническая реализация    | Основные особенности                                            |
| ------------ | ------------------------ | -------------------------------------------------------------- |
| Контекст      | Хранение истории диалогов | Легковесное управление памятью, полный контекст истории для LLM |
| Экспертная маршрутизация | LLM prompt+правила маршрутизации | Распознавание намерения через prompt-инжиниринг → динамическое распределение Agent-экспертов, поддержка сценариев торга/техподдержки/сервиса |

### Бизнес-функционал
| Модуль     | Реализовано                        | В планах                     |
| ---------- | ---------------------------------- | ----------------------- |
| Ядро       | ✅ Автоматический ответ LLM<br>✅ Контекстное управление | 🔄 Улучшение анализа эмоций    |
| Система торга | ✅ Стратегия ступенчатого снижения цены | 🔄 Функция рыночного сравнения цен |
| Техподдержка | ✅ Интеграция с веб-поиском         | 🔄 Усиление знаний с помощью RAG |

## 🚴 Быстрый старт

### Требования к среде
- JDK 21+
- Maven 3.9.10+

### Шаги установки

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 Участие и вклад

Приветствуем предложения через Issue или вклад в код через PR, пожалуйста, следуйте [руководству по вкладу](https://contributing.md/)



## 🛡 Важная информация

⚠️ Внимание: **Данный проект предназначен только для обучения и обмена опытом, при нарушении авторских прав свяжитесь с автором для удаления.**

В связи со спецификой проекта, команда разработчиков может в любое время **прекратить обновления** или **удалить проект**.


## 🧸 Особая благодарность

Данный проект реконструирован на основе следующих open-source проектов:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) — интеллектуальная система поддержки пользователей Xianyu, разработанная [@shaxiu](https://github.com/shaxiu) и [@cv-cat](https://github.com/cv-cat)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---