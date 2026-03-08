
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# DIY Умный Домашний Семейный Календарь (Аналог Skylight)

![Календарь Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Введение

Мою жену недавно буквально завалили в социальных сетях рекламой умных домашних календарей (Skylight, Cozyla, Hearth), и она была готова потратить на один из них более $300. Прежде чем дать ей согласие на покупку, я попросил время, чтобы изучить этот вопрос.
Я понял, что большинство предлагаемых решений имеют схожий функционал, но существенно отличаются по цене. Самое главное, я не увидел ни одной выдающейся функции, которую не смог бы реализовать в **Home Assistant**.

**Цель:** Одобренный женой (Wife Acceptance Factor), удобный для размещения на столешнице сенсорный календарь, глубоко интегрированный в наш умный дом и не требующий ежемесячных платежей.

## 💡 Почему DIY?

Выбор DIY-подхода с Home Assistant дал несколько преимуществ по сравнению с покупкой Skylight/Hearth дисплея:

* **Без абонентской платы:** Нет подписки на "премиальные" функции.
* **Бесшовная интеграция:** Работает с нашими лампами, делами (Grocy) и датчиками присутствия.
* **Старое оборудование:** Переиспользован Mini PC и стандартный монитор.
* **Конфиденциальность:** Нет привязки к вендору и риска прекращения поддержки.

## 🛠 Выбор оборудования

В данный момент система построена для отображения дашборда на любом HD (1920x1080) дисплее.

В моем случае требовалось, чтобы устройство "выглядело как" skylight, было сенсорным, стояло на столешнице, и его можно было перемещать. Поэтому я выбрал описанное ниже оборудование.
Тем не менее, ваш случай может отличаться, и потребуется подстроить конфигурацию — например, если вы хотите выводить интерфейс на планшет или что-то другое.

Оборудование я выбрал исходя из вышеописанных требований, а также с расчетом расширить возможности за счет веб-камеры, динамика и микрофона. Сейчас бы я, возможно, собрал систему иначе, поскольку не успел реализовать дополнительные идеи с оборудованием.

* **Монитор:** [HP Engage 15-дюймовый сенсорный экран](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). Я выбрал его вместо обычных портативных мониторов, потому что в нем уже есть **динамик, веб-камера и микрофон**, что позволяет в будущем реализовать голосовое управление или видеозвонки.
* **Компьютер:** Старый Mini PC (NUC/Tiny PC) с Windows/Linux в режиме киоска или Raspberry Pi 4.~~

## ✨ Функции

* **Семейный и индивидуальный режимы:** Можно включать и выключать календари отдельных членов семьи.
* **Двусторонняя синхронизация:** Редактирование событий как с экрана, так и с телефонов (Google Календарь).
* **Всплывающее окно "Добавить событие":** Специальный UI для добавления событий в определённые календари прямо с экрана.
* **Погода и дата:** Красивый и наглядный верхний колонтитул.
* **Адаптивность:** Автоматически меняет количество дней в зависимости от ширины экрана (мобильный/десктоп).

---

## ⚙️ Инструкция по установке

*Примечание: Эта настройка использует **YAML Package**, который автоматически создаёт все необходимые помощники, скрипты и переменные. Создавать их вручную не потребуется.*



### 1. Необходимые компоненты (HACS)

У вас должен быть установлен [HACS](https://hacs.xyz/). Пожалуйста, установите следующие **Frontend** интеграции:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (Требуется для работы всплывающих окон)
* `layout-card` (Требуется для представления Sections)
* `button-card` (Требуется для всплывающего окна добавления события)

*Примечание: В Настройки → Устройства и сервисы убедитесь, что Browser Mod отображается как интеграция (плитка), а не только в HACS.
Если его там нет, нажмите Добавить интеграцию → Browser Mod и завершите настройку, затем перезапустите HA.
Установка через HACS только загружает файлы; вы должны добавить интеграцию, чтобы HA зарегистрировал её действия/сущности.

### 2. Бэкенд (Мозг системы)

1. Откройте ваш файл `configuration.yaml` в Home Assistant.
2. Убедитесь, что у вас добавлена эта строка под `homeassistant:`, чтобы включить пакеты:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. Создайте папку с именем `packages` в вашем каталоге конфигурации HA (если такой ещё нет).
4. Скачайте файл [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) из этого репозитория.
5. Найдите строку [ #<--- UPDATE THIS ENTITY] и обновите ID сущности календаря в соответствии с вашей средой. Подробнее смотрите в разделе 3.
6. Поместите файл в вашу папку `packages/`.
7. **Перезапустите Home Assistant**.

### 3. Календарь

Вы можете использовать **Google Календарь** или **Локальные календари**.

#### Вариант A: Использовать имена календарей повторно (Самый простой)


1. Перейдите в **Настройки > Устройства и сервисы**.
2. Добавьте интеграцию **Локальный календарь**.
3. Создайте календари с точными именами: `calendar1`, `calendar2`, `calendar3`, `calendar4`, `Family`.
    * *Если вы используете эти имена, код будет работать сразу!*

#### Вариант B: Пользовательский календарь

1. Перейдите в **Настройки > Устройства и сервисы**.
2. Добавьте интеграцию **Локальный календарь** или **Google Календарь**.
3. Перейдите в **Конфигурация > Интеграции > Локальный календарь** или **Google Календарь** и выберите "Добавить запись"
4. Для каждой созданной записи получите ID сущности для обновления файла dashboard.yaml.
5. Откройте `dashboard.yaml`.
6. Найдите строку `# <--- UPDATE THIS ENTITY`.
7. Обновите ID сущности в соответствии с вашей средой.


#### Настройка праздников

С последних обновлений Home Assistant праздники добавляются через интерфейс:

1. Перейдите в **Настройки > Устройства и сервисы > Добавить интеграцию > Holiday**.
2. Выберите свою страну.
3. Проверьте ID сущности (например, `calendar.holidays`). Если он отличается от стандартного, обновите его в YAML дашборда.

### 4. Дашборд (Внешний вид)


1. Перейдите в **Настройки > Панель управления**
2. Нажмите **Добавить панель** (выберите вариант "Новая панель с нуля", убедитесь, что выбрано "Добавить в боковую панель").
3. В левом меню выберите только что созданную панель и нажмите на значок карандаша для её редактирования.
5. Выберите значок с тремя точками и выберите "Редактор сырой конфигурации".
6. Скопируйте и вставьте код из [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).

### Шаг 5: Тема (необязательно)

Чтобы получить нужный вид шрифта (Ovo):

1. Убедитесь, что в вашем `configuration.yaml` есть эта строка под `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```

2. Создайте папку с именем `themes` в вашем каталоге конфигурации.
3. Скачайте [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) и поместите его в эту папку.
4. Используйте File Editor и загрузите calbackgrd.png в папку /www/, которая на панели управления отображается как /local.
5. Перезапустите Home Assistant.
6. Перейдите в свой профиль (иконка пользователя внизу слева) и измените **Тему** на `Skylight`.
ПРИМЕЧАНИЕ: Тема не является всесторонней, поэтому учитывайте это

---

## 📐 Как это работает (внутреннее устройство)

### Логика фильтрации

`week-planner-card` не поддерживает скрытие определенных календарей в реальном времени. Для решения этой задачи я использовал **Input Texts** в качестве фильтров Regex.

* Когда вы нажимаете кнопку пользователя, фильтр переключается между `.*` (Показать всё) и `^$` (Не показывать ничего).
* `config-template-card` динамически внедряет эти переменные в карточку календаря.

### Скрипт создания событий

Всплывающее окно "Добавить событие" использует единый скрипт, который обрабатывает логику для нескольких людей и типов событий (Весь день или по времени).

```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## ЗАМЕЧАНИЯ

Мой первоначальный пост был лишь кратким обзором того, как это сделать, чтобы люди могли адаптировать код под свои конкретные задачи.

В частности, я поступил так потому, что каждый дисплей и задача уникальны. Я не могу разрабатывать под все возможные размеры дисплеев, панелей и т.д. Поэтому решение подходит для упомянутого мной дисплея или любого другого (1920x1080), но его можно отредактировать для других вариантов.

Что касается дисплея, я изначально предложил этот вариант, потому что он продавался на Woot и на тот момент был очень экономичным способом получить сенсорный экран. Сейчас это может быть не так, поэтому используйте тот дисплей, который вам подходит. Планшет, сенсорный экран, телефон — что угодно. Главное, что вам нужно будет отредактировать — это панель управления.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---