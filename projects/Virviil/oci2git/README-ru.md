
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
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![Документация](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![Лицензия](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![Загрузки](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (макет для будущего test.yaml)
[//]: # ([![Статус теста]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

Приложение на Rust, которое преобразует образы контейнеров (Docker и др.) в Git-репозитории и генерирует спецификацию файловой системы (fsbom) в YAML. Каждый слой контейнера представлен как коммит в Git, сохраняя историю и структуру исходного образа.

![Демонстрация OCI2Git конвертирующего образ nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Возможности

- Анализировать Docker-образы и извлекать информацию о слоях
- Создавать Git-репозиторий, где каждый слой образа представлен отдельным коммитом
- Генерировать YAML-спецификацию файловой системы (fsbom) с перечнем файлов по слоям
- Поддержка пустых слоев (ENV, WORKDIR и др.) как пустых коммитов
- Полное извлечение метаданных в формате Markdown
- Расширяемая архитектура для поддержки различных контейнерных движков

## Сценарии использования

### Сравнение слоев
При устранении неполадок контейнеров можно использовать мощные инструменты сравнения Git для точного выявления изменений между любыми двумя слоями. Выполняя `git diff` между коммитами, инженеры видят, какие файлы были добавлены, изменены или удалены, что значительно облегчает понимание воздействия каждой инструкции Dockerfile и поиск проблемных изменений.
![Пример сравнения слоев](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Отслеживание происхождения
Используя `git blame`, разработчики могут быстро определить, какой слой добавил конкретный файл или строку кода. Это особенно важно при диагностике проблем с конфигурационными файлами или зависимостями. Вместо ручной проверки каждого слоя можно сразу проследить происхождение любого файла до исходного слоя и соответствующей инструкции Dockerfile.

### Отслеживание жизненного цикла файлов
OCI2Git позволяет отслеживать путь конкретного файла на протяжении всей истории образа контейнера. Можно наблюдать момент создания файла, как он изменялся на разных слоях и когда был удалён. Такой комплексный обзор помогает понять эволюцию файлов без необходимости вручную отслеживать изменения через десятки слоев.

Чтобы отслеживать историю файла в вашем контейнерном образе — когда он впервые появился, изменялся или был удалён — после конвертации используйте эти команды Git:

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

OCI2Git автоматически обнаруживает общие слои между образами и создает ветвящуюся структуру, отражающую их общий базис. История Git будет показывать:
- Общий ствол, содержащий все общие слои
- Отдельные ветки, которые расходятся только там, где образы действительно различаются
- Четкую визуализацию того, где образы имеют общих предков и где они становятся уникальными
- Умное управление дубликатами: если один и тот же образ обрабатывается дважды, алгоритм обнаруживает это до финального коммита метаданных и пропускает создание дублирующей ветки

Этот подход особенно ценен для:
- **Анализа семейства образов**: Понимания того, как различные варианты образа (версии, архитектуры или конфигурации) связаны друг с другом
- **Влияния базового образа**: Возможности увидеть, как изменения базового образа влияют на множество производных образов
- **Возможностей для оптимизации**: Выявления общих компонентов, которые можно более эффективно использовать в разных вариантах образов

![Структура репозитория с несколькими образами, показывающая общий базис и расходящиеся ветви](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Дополнительные сценарии использования

- **Аудит безопасности**: Определение точного момента, когда были внедрены уязвимые пакеты или конфигурации, и отслеживание их до конкретных инструкций сборки.
- **Оптимизация образов**: Анализ структуры слоев для поиска избыточных операций или крупных файлов, которые можно объединить, чтобы уменьшить размер образа.
- **Управление зависимостями**: Отслеживание, когда зависимости были добавлены, обновлены или удалены в истории образа.
- **Улучшение процесса сборки**: Изучение состава слоев для оптимизации инструкций Dockerfile с целью лучшего кеширования и уменьшения размера образа.
- **Сравнение образов**: Конвертация нескольких связанных образов в репозитории Git и использование инструментов сравнения Git для анализа их различий и общих черт.

## Установка

### Менеджеры пакетов

#### macOS / Linux (Homebrew)

```bash
brew tap virviil/oci2git
brew install oci2git
```

#### Debian / Ubuntu

Скачайте и установите пакет .deb из [последнего релиза](https://github.com/virviil/oci2git/releases/latest):

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### Arch Linux (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### Предварительно собранные бинарные файлы

Скачайте подходящий бинарный файл для вашей платформы из [последнего релиза](https://github.com/virviil/oci2git/releases/latest):

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```

### С Crates.io

```bash
cargo install oci2git
```

### Из источника

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

## Использование

```
oci2git [OPTIONS] <IMAGE>
oci2git convert [OPTIONS] <IMAGE>
oci2git fsbom [OPTIONS] <IMAGE>
```

### `convert` — OCI-образ → Git-репозиторий

```bash
oci2git convert [OPTIONS] <IMAGE>
# or simply:
oci2git <IMAGE>
```

Параметры:
  `-o, --output <OUTPUT>`  Каталог вывода для репозитория Git [по умолчанию: ./container_repo]
  `-e, --engine <ENGINE>`  Контейнерный движок для использования (docker, nerdctl, tar) [по умолчанию: docker]
  `-v, --verbose`          Подробный режим (-v для информации, -vv для отладки, -vvv для трассировки)

### `fsbom` — Спецификация состава файловой системы

```bash
oci2git fsbom [OPTIONS] <IMAGE>
```

Опции:
  `-o, --output <OUTPUT>`  Путь вывода для файла YAML BOM [по умолчанию: ./fsbom.yml]
  `-e, --engine <ENGINE>`  Используемый контейнерный движок (docker, nerdctl, tar) [по умолчанию: docker]
  `-v, --verbose`          Подробный режим (-v для info, -vv для debug, -vvv для trace)

Переменные среды:
  `TMPDIR`  Установите эту переменную среды для изменения стандартного расположения, используемого для промежуточной обработки данных. Зависит от платформы (например, `TMPDIR` на Unix/macOS, `TEMP` или `TMP` на Windows).

## Примеры

### Конвертация

Использование движка Docker (по умолчанию):
```bash
oci2git ubuntu:latest
# or explicitly:
oci2git convert ubuntu:latest -o ./ubuntu-repo
```
Использование уже загруженного tarball-образа:

```bash
oci2git convert -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

Движок tar ожидает действительный tarball в формате OCI, который обычно создается с помощью `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git convert -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Это создаст репозиторий Git в `./ubuntu-repo`, содержащий:
- `Image.md` — Полные метаданные об образе в формате Markdown
- `rootfs/` — Содержимое файловой системы из контейнера

История Git отражает историю слоёв контейнера:
- Первый коммит содержит только файл `Image.md` с полной метаинформацией
- Каждый последующий коммит соответствует одному слою из исходного образа
- Коммиты включают команду Dockerfile в качестве сообщения коммита

### Ведомость файловой системы (fsbom)

Генерируйте YAML, перечисляющий каждый файл, добавленный или изменённый в каждом слое:
```bash
oci2git fsbom ubuntu:latest -o ubuntu.yml
```
Использование tarball:

```bash
oci2git fsbom -e tar image.tar -o image-bom.yml
```

Выходной YAML перечисляет каждый слой с его элементами, отмеченными по типу (`file`, `hardlink`, `symlink`, `directory`) и статусу (`n:uid:gid` для новых, `m:uid:gid` для изменённых). Удалённые файлы (OCI whiteouts) исключены.

```yaml
layers:
  - index: 0
    command: "ADD rootfs.tar.gz / # buildkit"
    digest: "sha256:45f3ea58..."
    entries:
      - type: file
        path: "bin/busybox"
        size: 919304
        mode: 493
        stat: "n:0:0"
      - type: hardlink
        path: "bin/sh"
        target: "bin/busybox"
        stat: "n:0:0"
      - type: symlink
        path: "lib64"
        target: "lib"
        stat: "n:0:0"
  - index: 1
    command: "RUN apk add --no-cache curl"
    digest: "sha256:..."
    entries:
      - type: file
        path: "usr/bin/curl"
        size: 204800
        mode: 493
        stat: "n:0:0"
      - type: file
        path: "etc/apk/world"
        size: 32
        mode: 420
        stat: "m:0:0"
```

## Структура репозитория

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
## Требования

- Rust редакция 2021
- Docker CLI (для поддержки Docker engine)
- Git

## Лицензия

MIT

[документация]: https://docs.rs/oci2git/




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---