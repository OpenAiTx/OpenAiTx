
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

Ускорение CDN и защита безопасности для этого проекта предоставляются Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

Автор этого проекта — colin1114.

# 🚀 Конвертер подписок Clash

Эстетичный и мощный онлайн-инструмент для преобразования различных ссылок на прокси-подписки в формат конфигурации Clash. Поддерживает автоматическое развертывание через Cloudflare Workers & Pages, обеспечивая быстрый и надежный сервис конвертации подписок.

## ✨ Особенности

- 🎨 **Современный и эстетичный интерфейс** – использует градиентный фон и карточный дизайн
- 🔄 **Поддержка нескольких протоколов** – поддержка основных протоколов: V2Ray, VLESS, Shadowsocks, Trojan и других
- ☁️ **Облачное развертывание** – глобальное ускорение CDN через Cloudflare Workers
- 📱 **Адаптивный дизайн** – идеальная совместимость с настольными и мобильными устройствами
- ⚡ **Быстрое преобразование** – мгновенное преобразование ссылок подписки в конфигурацию Clash
- 📋 **Умное копирование** – поддержка копирования сгенерированной YAML-конфигурации в один клик, совместимость с любыми браузерами
- 📡 **Генерация ссылок подписки** – автоматическая генерация ссылок для прямого импорта в Clash
- 🌐 **Онлайн-доступ к YAML** – предоставляются различные способы доступа к YAML-файлам:
  - 📡 Ссылка подписки: поддержка автоматического обновления в клиенте Clash
  - 🔗 Онлайн-просмотр: просмотр содержимого конфигурации прямо в браузере
  - 💾 Загрузка файла: скачивание файла .yaml на локальный компьютер
  - ⚡ Быстрый доступ: упрощённая ссылка для скачивания
- 🔧 **Поддержка UTF-8** – отличная поддержка китайских названий узлов и конфигураций
- 🆓 **Полностью бесплатно** – основано на бесплатных сервисах Cloudflare, без ограничений на использование

## 📁 Структура проекта

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
```

## 🚀 Быстрый старт

### Способ 1: Запуск локально

1. **Клонируйте проект**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Запустите локальный сервер**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **Доступ к приложению**
   - Откройте браузер и перейдите по адресу `http://localhost:8000`
   - В локальной среде будет показана примерная конфигурация

### Способ 2: Развертывание через Cloudflare Workers

#### Шаг 1: Создание Worker

1. Перейдите на [Cloudflare Workers](https://workers.cloudflare.com/)
2. Зарегистрируйтесь/войдите в аккаунт Cloudflare
3. Нажмите "Create a Worker"
4. Полностью скопируйте код из `worker.js` в редактор
5. Нажмите "Save and Deploy"

#### Шаг 2: Развертывание с помощью Wrangler CLI

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### Шаг 3: Настройка домена (необязательно)

1. Добавьте пользовательский домен в настройках Worker
2. Или используйте домен по умолчанию, предоставленный Cloudflare

### Способ три: Развертывание через Cloudflare Pages

#### Вариант A: Интеграция с GitHub (рекомендуется)

1. **Подготовка репозитория**
   - Загрузите код в репозиторий GitHub
   - Убедитесь, что все необходимые файлы присутствуют

2. **Создание проекта Pages**
   - Перейдите на [Cloudflare Pages](https://pages.cloudflare.com/)
   - Подключите свой репозиторий GitHub
   - Выберите репозиторий проекта

3. **Настройки сборки**
   - Команда сборки: оставить пустым или `echo "No build required"`
   - Директория вывода сборки: `/` (корневая директория)
   - Переменные среды: не требуется

#### Вариант B: Прямая загрузка

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ Техническая архитектура

### Стек технологий фронтенда
- **HTML5** - современный язык разметки
- **CSS3** - адаптивный дизайн и анимация
- **Vanilla JavaScript** - легковесные фронтенд-скрипты

### Стек технологий бэкенда
- **Cloudflare Workers** - платформа edge-вычислений
- **Web APIs** - стандартные Fetch API и обработка ответов

### Поддерживаемые протоколы
- **VMess** - стандартный протокол V2Ray
- **VLESS** - облегчённый протокол V2Ray (поддержка Reality)
- **Shadowsocks** - классический прокси-протокол
- **Trojan** - современный прокси-протокол

### API-эндпоинты
- `GET /` - главная страница
- `POST /convert` - API для конвертации подписки
- `GET /clash/{config-id}` - получение YAML-конфига (ссылка на подписку)
- `GET /yaml/{config-id}` - скачивание YAML-конфига
- `OPTIONS /*` - предварительный CORS-запрос

## 📖 Руководство пользователя

### Базовое использование

1. **Ввод ссылки на подписку**
   - Вставьте вашу ссылку на прокси-подписку в поле ввода
   - Поддерживаются ссылки подписки в Base64-кодировке

2. **Настройка имени конфигурации**
   - При желании задайте индивидуальное имя для файла конфигурации
   - По умолчанию: "My Clash Config"

3. **Конвертация конфигурации**
   - Нажмите кнопку "Конвертировать подписку"
   - Дождитесь завершения процесса
4. **Использование конфигурации**
   - Скопируйте сгенерированную YAML-конфигурацию
   - Импортируйте в клиент Clash для использования

5. **Использование ссылки на подписку (рекомендуется)**
   - Скопируйте сгенерированную ссылку на подписку
   - Добавьте подписку в клиент Clash
   - Конфигурация будет автоматически синхронизироваться, не требуется ручное обновление

### Расширенная конфигурация

Сгенерированная конфигурация Clash включает следующие особенности:

- **Стратегии групп прокси**
  - 🚀 Выбор узла — ручной выбор прокси
  - ♻️ Автовыбор — автоматический выбор по задержке
  - 🎯 Глобальное прямое подключение — прямое соединение

- **DNS-конфигурация**
  - Включено разрешение DNS
  - Поддерживается режим fake-ip
  - Разделение DNS для внутренних и внешних адресов

- **Маршрутизация**
  - Прямое подключение для локальных адресов
  - Прямое подключение для внутренних IP
  - Остальной трафик через прокси

## 🔧 Устранение неполадок при развертывании

### Частые проблемы

#### 1. Wrangler не может найти точку входа
**Сообщение об ошибке**: `Missing entry-point to Worker script`

**Решение**: 
- Убедитесь, что в корневой директории проекта есть файл `wrangler.jsonc`
- Проверьте, что поле `main` в `wrangler.jsonc` указывает на `worker.js`


#### 2. Ошибка деплоя через GitHub Actions
**Решение**:
- Добавьте в настройках репозитория GitHub следующие Secrets:
  - `CLOUDFLARE_API_TOKEN`: API токен Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID`: ID аккаунта Cloudflare

#### 3. Ошибка сборки Pages
**Решение**:
- Установите команду сборки пустой или `echo "No build required"`
- Убедитесь, что директория вывода сборки установлена на `/`

### Описание файлов конфигурации деплоя

- **`wrangler.jsonc`**: Конфигурация Wrangler CLI для деплоя Worker
- **`_headers`**: Конфигурация HTTP заголовков Cloudflare Pages
- **`.github/workflows/deploy.yml`**: Конфиг автоматического деплоя GitHub Actions

## 🔧 Кастомизация конфигурации

### Изменение групп прокси

Вы можете отредактировать функцию `convertToClash` в `worker.js` для кастомизации групп прокси:

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### Пользовательские правила маршрутизации

Измените массив `rules`, чтобы добавить пользовательские правила маршрутизации:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 Характеристики производительности

- **Глобальный CDN** - Cloudflare с узлами по всему миру
- **Быстрый отклик** - Среднее время отклика < 100 мс
- **Высокая доступность** - 99.9% времени доступности сервиса
- **Бесплатный лимит** - 100 000 запросов в день

## 🔒 Информация о безопасности

- **Конфиденциальность данных** - Данные подписки используются только в процессе конвертации и не сохраняются
- **Шифрование HTTPS** - Вся передача данных происходит по HTTPS
- **Открытый исходный код** - Полный исходный код доступен для самостоятельной проверки

## 🤝 Руководство по внесению вклада

Приглашаем отправлять Issue и Pull Request!

1. Сделайте Fork этого репозитория
2. Создайте ветку для новой функции (`git checkout -b feature/AmazingFeature`)
3. Зафиксируйте изменения (`git commit -m 'Add some AmazingFeature'`)
4. Отправьте ветку (`git push origin feature/AmazingFeature`)
5. Создайте Pull Request

## 📝 Журнал изменений

### v1.1.0
- ✅ Добавлена поддержка протокола VLESS (включая Reality с безопасной передачей)
- ✅ Улучшена совместимость протоколов

### v1.0.0
- ✅ Базовая функция конвертации подписки
- ✅ Эстетичный пользовательский интерфейс
- ✅ Поддержка Cloudflare Workers
- ✅ Многопротокольная поддержка (VMess, Shadowsocks, Trojan)
- ✅ Адаптивный дизайн
- ✅ Функция копирования в один клик

## 📞 Поддержка и обратная связь

Если у вас возникли проблемы или предложения во время использования, пожалуйста:

1. Ознакомьтесь с данным README документом
2. Оставьте [Issue](../../issues)
3. Начните [Discussion](../../discussions)

## 📄 Лицензия

В данном проекте используется лицензия MIT — подробности см. в файле [LICENSE](LICENSE)

## 🙏 Благодарности

- [Cloudflare Workers](https://workers.cloudflare.com/) — предоставляет платформу для edge-компьютинга
- [Clash](https://github.com/Dreamacro/clash) — отличный клиент-прокси
- Всем участникам и пользователям за поддержку

---

⭐ Если этот проект был вам полезен, пожалуйста, поставьте ему Star! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---