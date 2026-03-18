
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Только Nix

**Преобразуйте ваш GitHub Actions runner в мощную [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ машину, безжалостно избавившись от предустановленного мусора.**

GitHub Actions runner-ы предоставляют очень мало места на диске для Nix — всего около ~20ГБ.
*Только Nix* **жестко очищает** ненужное ПО, давая вам **65ГБ до 130ГБ** для вашего Nix store! 💪

## Использование 🔧

Добавьте это действие **до** установки Nix в вашем рабочем процессе:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### Требования ️✔️

- Поддерживаются только официальные раннеры **Ubuntu** для GitHub Actions
- Должен запускаться **до** установки Nix
- **Раннеры macOS/Darwin**: при запуске на macOS действие будет пропущено с предупреждением. Раннеры macOS уже предоставляют достаточно места для Nix и не требуют этого действия
- **Раннеры Windows**: при запуске на Windows действие будет пропущено с предупреждением. Раннеры Windows имеют другую структуру файловой системы и ограничения

## Проблема: Освободить место для процветания Nix 🌱

Стандартные раннеры GitHub Actions переполнены *"мусорным ПО"*, которое никогда не понадобится в процессе работы с Nix:

- 🌍 Веб-браузеры. Много. Просто все!
- 🐳 Docker-образы, занимающие гигабайты ценного дискового пространства
- 💻 Ненужные окружения языков программирования (.NET, Ruby, PHP, Java...)
- 📦 Пакетные менеджеры, собирающие цифровую пыль
- 📚 Документация, которую никто не будет читать

Всё это оставляет лишь ~20ГБ для вашего Nix store — едва ли достаточно для серьёзных Nix-сборок! 😞

## Решение: Только Nix ️❄️

**Nothing but Nix** применяет радикальный подход к раннерам GitHub Actions и безжалостно возвращает дисковое пространство с помощью двухэтапной атаки:

1. **Начальный удар:** Мгновенно создаёт большой том `/nix` (~65ГБ), забирая свободное место из `/mnt`
2. **Фоновая зачистка:** Пока ваш workflow продолжается, мы безжалостно удаляем ненужное ПО, чтобы расширить ваш том `/nix` до ~130ГБ
   - Веб-браузеры? Нет ⛔
   - Docker-образы? Удалены 🗑️
   - Окружения языков? Уничтожены 💥
   - Пакетные менеджеры? Аннигилированы 💣
   - Документация? Испарена ️👻

Очистка файловой системы выполняется с помощью `rmz` (из проекта [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) — высокопроизводительной альтернативы `rm`, ускоряющей возврат пространства! ⚡
   - Работает на порядок быстрее стандартного `rm`
   - Выполняет параллельное удаление для максимальной эффективности
   - **Возвращает дисковое пространство за секунды, а не минуты!** ️⏱️

Результат? Раннер GitHub Actions с **65ГБ до 130ГБ** пространства, готового для Nix! 😁

### Динамический рост тома
В отличие от других решений, **Nothing but Nix** динамически увеличивает ваш том `/nix`:

1. **Первичное создание тома (1-10 секунд):** (*в зависимости от протокола Hatchet*)
   - Создает loop-устройство из свободного пространства на `/mnt`
   - Настраивает файловую систему BTRFS в конфигурации RAID0
   - Монтирует с включенным сжатием и оптимизацией производительности
   - Сразу предоставляет 65ГБ на `/nix`, даже до начала очистки

2. **Фоновое расширение (30-180 секунд):** (*в зависимости от протокола Hatchet*)
   - Выполняет операции по очистке
   - Отслеживает появление нового свободного пространства по мере удаления мусора
   - Динамически добавляет диск расширения к тому `/nix`
   - Перебалансирует файловую систему для включения нового пространства

Том `/nix` автоматически **увеличивается в процессе выполнения рабочих задач** 🎩🪄

### Выберите своё оружие: Протокол Hatchet 🪓

Управляйте уровнем уничтожения 💥 с помощью входного параметра `hatchet-protocol`:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### Сравнение протоколов ⚖️

| Протокол | `/nix` | Описание                                         | Очистка apt | Очистка docker | Очистка snap | Очищенные файловые системы |
|----------|--------|--------------------------------------------------|-------------|----------------|--------------|----------------------------|
| Holster  | ~65ГБ  | Топор в ножнах, используем место с `/mnt`        | Нет         | Нет            | Нет          | Нет                        |
| Carve    | ~85ГБ  | Объединяем свободное место с `/` и `/mnt`        | Нет         | Нет            | Нет          | Нет                        |
| Cleave   | ~115ГБ | Решительно удаляем крупные пакеты                | Минимально  | Да             | Да           | `/opt` и `/usr/local`      |
| Rampage  | ~130ГБ | Безжалостно уничтожаем весь мусор                | Агрессивно  | Да             | Да           | Мухахаха! 🔥🌎              |

Выбирайте с умом:
- **Holster**, если нужно сохранить полную работоспособность runner'а
- **Carve** для сохранения инструментов и максимального пространства для Nix
- **Cleave** (*по умолчанию*) — хороший баланс между пространством и функционалом
- **Rampage**, если нужен максимум места под Nix и не важно, что сломается `#nix-is-life`

### Свидетельствуйте резню 🩸

По умолчанию процесс очистки выполняется тихо в фоновом режиме, пока ваш workflow продолжается. Но если хотите наблюдать за процессом в реальном времени:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### Настройте безопасные зоны 🛡️

Управляйте тем, сколько пространства выделять для защиты от захвата хранилища Nix, с помощью настраиваемых размеров безопасных зон:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```

Эти безопасные пороги определяют, сколько пространства (в МБ) будет милостиво сохранено при очистке пространства:
- Значение по умолчанию для `root-safe-haven` — 2048 МБ (2 ГБ)
- Значение по умолчанию для `mnt-safe-haven` — 1024 МБ (1 ГБ)

Увеличьте эти значения, если вам нужно больше свободного места на файловых системах, или уменьшите их, чтобы не оставлять пощады! 😈

### Передача прав владения пользователю для /nix (Указ о правах Nix) 🧑‍⚖️

Некоторые установщики или конфигурации Nix ожидают, что каталог `/nix` будет доступен для записи текущему пользователю. По умолчанию `/nix` принадлежит root. Если вам нужно передать владение пользователю (например, для некоторых скриптов установки Nix, которые не используют `sudo` для всех операций в `/nix`), вы можете включить `nix-permission-edict`:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```

Когда `nix-permission-edict` установлен в значение `true`, действие выполнит `sudo chown -R "$(id --user)":"$(id --group)" /nix` после монтирования `/nix`.

### Настройте Nix для использования /nix/build

Это действие создаёт `/nix/build` для сборок derivation в Nix, чтобы использовать освобождённое пространство. Добавьте `build-dir` в вашу конфигурацию Nix:

```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

Или с DeterminateSystems:

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```

Это указывает Nix выполнять сборки на большом разделе BTRFS, а не во временной директории по умолчанию системы.

## Устранение неполадок 🔍

### "На устройстве не осталось места" при больших сборках

Если у вас заканчивается место при сборке, несмотря на использование только Nix, вероятно, фоновое удаление не завершилось до того, как сборка заняла все доступное пространство. Обычно это затрагивает:

- Тесты NixOS VM, которые собирают большие образы дисков
- Сборки с множеством зависимостей, которые не кэшируются
- Компиляторы Rust и другие крупные сборки

**Решение:** Используйте `witness-carnage: true`, чтобы принудительно выполнить синхронное удаление. Это гарантирует, что всё пространство будет освобождено *до* начала сборки:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```

Это добавляет 30-180 секунд к настройке вашего рабочего процесса, но гарантирует максимальное доступное пространство, когда начинается ваша сборка.

Теперь идите и создайте что-нибудь потрясающее с этим великолепным пространством хранилища Nix! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---