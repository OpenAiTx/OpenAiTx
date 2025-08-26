
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

Приложение на Rust, которое преобразует образы контейнеров (Docker и др.) в репозитории Git. Каждый слой контейнера представлен как коммит Git, сохраняя историю и структуру исходного образа.

![Демонстрация работы OCI2Git по преобразованию образа nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Возможности

- Анализируйте образы Docker и извлекайте информацию о слоях
- Создайте Git-репозиторий, где каждый слой образа представлен отдельным коммитом
- Поддержка пустых слоев (ENV, WORKDIR и др.) в виде пустых коммитов
- Полное извлечение метаданных в формате Markdown
- Расширяемая архитектура для поддержки различных контейнерных движков

## Сценарии использования

### Сравнение слоев
При устранении проблем с контейнерами вы можете использовать мощные возможности сравнения Git, чтобы определить, что именно изменилось между любыми двумя слоями. Выполнив `git diff` между коммитами, инженеры могут точно увидеть, какие файлы были добавлены, изменены или удалены, что значительно облегчает понимание влияния каждой инструкции Dockerfile и поиск проблемных изменений.
![Пример сравнения слоев](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Отслеживание происхождения
С помощью `git blame` разработчики могут быстро определить, какой слой добавил определённый файл или строку кода. Это особенно важно при диагностике проблем с конфигурационными файлами или зависимостями. Вместо ручной проверки каждого слоя вы сразу можете проследить происхождение любого файла до его исходного слоя и соответствующей инструкции Dockerfile.

### Отслеживание жизненного цикла файла
OCI2Git позволяет отслеживать путь конкретного файла на протяжении всей истории образа контейнера. Вы можете увидеть, когда файл был создан, как он изменялся на разных слоях, и если/когда он был удалён. Такой комплексный обзор помогает понять эволюцию файла без необходимости вручную отслеживать изменения по десяткам слоев.

Чтобы проследить историю файла в вашем образе контейнера — включая момент его появления, изменения или удаления — используйте эти команды Git после конвертации:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```
Эти команды позволяют легко проследить полную историю любого файла по слоям контейнера без необходимости вручную извлекать и сравнивать архивы слоёв.

### Многоуровневый анализ
Иногда самые ценные сравнения получаются при изучении изменений между несколькими неконкретными слоями. С OCI2Git вы можете использовать инструменты сравнения Git для анализа эволюции компонентов на различных этапах сборки, выявляя закономерности, которые могут быть незаметны при анализе только соседних слоёв.

### Исследование слоёв
Используя команду `git checkout` для перехода к определённому коммиту, вы можете изучить файловую систему контейнера в точности такой, какой она была на этом слое. Это позволяет разработчикам исследовать точное состояние файлов и каталогов на любом этапе создания образа, предоставляя ценный контекст для отладки или анализа поведения контейнера.
![Переход к предыдущему коммиту](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### Анализ нескольких образов

При работе с несколькими контейнерными образами, имеющими общий предок, OCI2Git интеллектуально создаёт ветки только в случае реального расхождения образов. Это позволяет анализировать несколько связанных образов в одном репозитории, сохраняя их общую историю.


```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```
OCI2Git автоматически обнаруживает общие слои между образами и создает разветвленную структуру, отражающую их общий базовый слой. История Git будет показывать:
- Общий ствол, содержащий все общие слои
- Отдельные ветви, которые расходятся только тогда, когда образы действительно различаются
- Наглядную визуализацию, где образы имеют общее происхождение и где становятся уникальными
- Умную обработку дубликатов: если точно такой же образ обрабатывается дважды, алгоритм обнаруживает это до финального коммита метаданных и пропускает создание дублирующей ветки

Этот подход особенно полезен для:
- **Анализ семейства образов**: понимание того, как различные варианты образа (разные версии, архитектуры или конфигурации) соотносятся друг с другом
- **Влияние базового образа**: возможность точно увидеть, как изменения в базовом образе влияют на несколько производных образов
- **Возможности для оптимизации**: выявление общих компонентов, которые можно более эффективно использовать между вариантами образов

![Структура репозитория с несколькими образами, показывающая общий базовый слой и расходящиеся ветви](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Дополнительные сценарии использования

- **Аудит безопасности**: точное определение момента внедрения уязвимых пакетов или конфигураций с возможностью отслеживания до конкретных инструкций сборки.
- **Оптимизация образов**: анализ структуры слоев для поиска избыточных операций или крупных файлов, которые можно объединить, чтобы уменьшить размер образа.
- **Управление зависимостями**: отслеживание времени добавления, обновления или удаления зависимостей на протяжении всей истории образа.
- **Улучшение процесса сборки**: исследование состава слоев для оптимизации инструкций Dockerfile ради лучшего кэширования и меньшего размера образа.
- **Сравнение между образами**: преобразование нескольких связанных образов в Git-репозитории и использование инструментов сравнения Git для анализа их различий и общих черт.

## Установка

### Из исходников


```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### С Crates.io

```bash
cargo install oci2git
```

## Использование

```bash
oci2git [OPTIONS] <IMAGE>
```

Аргументы:
  `<IMAGE>`  Имя образа для конвертации (например, 'ubuntu:latest') или путь к tar-архиву при использовании tar-движка

Опции:
  `-o, --output <o>`  Каталог для вывода Git-репозитория [по умолчанию: ./container_repo]
  `-e, --engine <ENGINE>`  Движок контейнера для использования (docker, nerdctl, tar) [по умолчанию: docker]
  `-h, --help`            Вывести справочную информацию
  `-V, --version`         Вывести информацию о версии

Переменные окружения:
  `TMPDIR`  Установите эту переменную окружения для изменения стандартного расположения, используемого для промежуточной обработки данных. Это зависит от платформы (например, `TMPDIR` на Unix/macOS, `TEMP` или `TMP` на Windows).

## Примеры

Использование Docker-движка (по умолчанию):
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```
Использование уже загруженного tarball-образа:

```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

Движок tar ожидает действительный tarball в формате OCI, который обычно создается с помощью `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Это создаст репозиторий Git в `./ubuntu-repo`, содержащий:
- `Image.md` — Полные метаданные об образе в формате Markdown
- `rootfs/` — Содержимое файловой системы из контейнера

История Git отражает историю слоев контейнера:
- Первый коммит содержит только файл `Image.md` с полными метаданными
- Каждый последующий коммит представляет слой из исходного образа
- Коммиты включают команду Dockerfile в качестве сообщения коммита

## Структура репозитория

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```


## Требования

- Rust редакция 2021 года
- Docker CLI (для поддержки движка Docker)
- Git

## Лицензия

MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---