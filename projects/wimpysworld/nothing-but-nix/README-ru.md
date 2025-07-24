
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

**Преобразуйте ваш GitHub Actions runner в [Nix](https://zero-to-nix.com/concepts/nix/) ❄️-мощь, безжалостно избавившись от предустановленного мусора.**

GitHub Actions runner'ы предоставляют очень мало дискового пространства для Nix — всего около ~20ГБ.
*Nothing but Nix* **жестоко очищает** ненужное ПО, предоставляя вам **от 65ГБ до 130ГБ** для вашего Nix store! 💪

## Использование 🔧

Добавьте это действие **до** установки Nix в ваш workflow:

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

- Поддерживаются только официальные раннеры GitHub Actions на **Ubuntu**
- Должен запускаться **до** установки Nix

## Проблема: Освободить место для Nix 🌱

Стандартные раннеры GitHub Actions переполнены *"ненужным ПО"*, которое никогда не пригодится в Nix-воркфлоу:

- 🌍 Веб-браузеры. Много. Прямо все!
- 🐳 Docker-образы, занимающие гигабайты драгоценного дискового пространства
- 💻 Ненужные среды выполнения языков (.NET, Ruby, PHP, Java...)
- 📦 Менеджеры пакетов, собирающие цифровую пыль
- 📚 Документация, которую никто не прочтёт

Этот мусор оставляет лишь ~20ГБ для вашего Nix store — едва хватает для серьёзных сборок Nix! 😞

## Решение: Только Nix ️❄️

**Nothing but Nix** применяет политику выжженной земли к раннерам GitHub Actions и безжалостно освобождает дисковое пространство с помощью двухфазной атаки:

1. **Первый удар:** Мгновенно создаёт большой том `/nix` (~65ГБ), забирая свободное место с `/mnt`
2. **Фоновое наступление:** Пока ваш воркфлоу продолжается, мы безжалостно удаляем ненужное ПО, расширяя том `/nix` до ~130ГБ
   - Веб-браузеры? Нет ⛔
   - Docker-образы? Удалены 🗑️
   - Среды выполнения языков? Уничтожены 💥
   - Менеджеры пакетов? Аннигилированы 💣
   - Документация? Испарена ️👻

Очистка файловой системы выполняется с помощью `rmz` (из проекта [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) — высокопроизводительной альтернативы `rm`, ускоряющей освобождение пространства! ⚡
   - Работает на порядок быстрее стандартного `rm`
   - Параллельно удаляет файлы для максимальной эффективности
   - **Освобождает дисковое пространство за секунды, а не минуты!** ️⏱️

Результат? Раннер GitHub Actions с **65ГБ до 130ГБ** пространства, готового для Nix! 😁

### Динамическое увеличение тома

В отличие от других решений, **Nothing but Nix** динамически увеличивает ваш том `/nix`:

1. **Первичное создание тома (1-10 секунд):** (*в зависимости от протокола Hatchet*)
   - Создаёт loop-устройство из свободного пространства на `/mnt`
   - Настраивает файловую систему BTRFS в конфигурации RAID0
   - Монтирует с компрессией и оптимизацией производительности
   - Сразу предоставляет 65ГБ для `/nix`, даже до начала очистки

2. **Фоновое расширение (30-180 секунд):** (*в зависимости от протокола Hatchet*)
   - Выполняет операции очистки
   - Отслеживает появление нового свободного пространства по мере удаления мусора
   - Динамически добавляет диск расширения в том `/nix`
   - Балансирует файловую систему для включения нового пространства

Том `/nix` автоматически **увеличивается во время выполнения воркфлоу** 🎩🪄

### Выберите своё оружие: Протокол Hatchet 🪓

Управляйте уровнем аннигиляции 💥 с помощью параметра `hatchet-protocol`:

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

Когда параметр `nix-permission-edict` установлен в значение `true`, действие выполнит команду `sudo chown -R "$(id --user)":"$(id --group)" /nix` после монтирования `/nix`.

Теперь вперед, создавайте что-нибудь удивительное, используя всё это великолепное пространство хранилища Nix! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---