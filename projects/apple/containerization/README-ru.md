# Контейнеризация

Пакет Containerization позволяет приложениям использовать Linux-контейнеры.  
Containerization написан на [Swift](https://www.swift.org) и использует [Virtualization.framework](https://developer.apple.com/documentation/virtualization) на Apple silicon.

Containerization предоставляет API для:

- [Управления OCI-образами](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).
- [Взаимодействия с удалёнными регистрами](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).
- [Создания и заполнения файловых систем ext4](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).
- [Взаимодействия с семейством сокетов Netlink](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).
- [Создания оптимизированного ядра Linux для быстрого запуска](https://raw.githubusercontent.com/apple/containerization/main/kernel/).
- [Запуска облегчённых виртуальных машин и управления средой выполнения](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).
- [Запуска и взаимодействия с контейнеризованными процессами](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).
- Использования Rosetta 2 для запуска linux/amd64 контейнеров на Apple silicon.

Пожалуйста, ознакомьтесь с [документацией API](https://apple.github.io/containerization/documentation/) для информации о Swift-пакетах, которые предоставляет Containerization.

## Дизайн

Containerization выполняет каждый Linux-контейнер внутри собственной облегчённой виртуальной машины. Клиенты могут создавать выделенные IP-адреса для каждого контейнера, чтобы избежать необходимости индивидуальной переадресации портов. Контейнеры достигают времени запуска менее одной секунды благодаря оптимизированной [конфигурации ядра Linux](https://raw.githubusercontent.com/apple/containerization/main/kernel) и минимальной корневой файловой системе с лёгкой системой инициализации.

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd) — это небольшая init-система, являющаяся подсистемой Containerization.  
`vminitd` запускается как начальный процесс внутри виртуальной машины и предоставляет GRPC API через vsock.  
API позволяет настраивать среду выполнения и запускать контейнеризованные процессы.  
`vminitd` обеспечивает ввод/вывод, сигналы и события вызывающему процессу при запуске процесса.

## Требования

Для сборки и запуска Containerization требуется Mac на Apple silicon.

Для сборки пакета Containerization ваша система должна поддерживать:

- macOS 15 или новее и Xcode 26 beta
- macOS 26 beta или новее

Приложения, собранные с использованием пакета, будут работать на macOS 15 или новее, но следующие функции недоступны в macOS 15:

- Неизолированная сетевая работа контейнеров — в macOS 15 контейнеры в одной сети vmnet не могут взаимодействовать друг с другом.

## Пример использования

Для примеров использования некоторых библиотек полезно начать с исполняемого файла cctl. Основная задача этого инструмента — площадка для проб API. Он содержит команды, использующие ключевой функционал различных продуктов, например:

1. [Манипуляция OCI-образами](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)  
2. [Вход в контейнерные регистры](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)  
3. [Создание блоков корневой файловой системы](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)  
4. [Запуск простых Linux-контейнеров](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)  

## Ядро Linux

Для запуска облегчённых виртуальных машин на macOS требуется ядро Linux.  
Containerization предоставляет оптимизированную конфигурацию ядра, расположенную в директории [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel).

Эта директория включает контейнеризованную среду сборки для удобной компиляции ядра для использования с Containerization.

Конфигурация ядра содержит минимальный набор функций для обеспечения быстрого запуска и лёгкой среды.

Хотя эта конфигурация подходит для большинства рабочих нагрузок, мы понимаем, что некоторым нужны дополнительные функции.  
Для решения этой задачи Containerization предоставляет первоклассные API для использования различных конфигураций и версий ядра на уровне каждого контейнера.  
Это позволяет разрабатывать и тестировать контейнеры на разных версиях ядра.

Смотрите [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) в директории ядра для инструкций по компиляции оптимизированного ядра.

### Предварительно собранное ядро

Если вы хотите использовать предварительно собранное ядро, в нём должны быть встроены драйверы `VIRTIO` в виде модулей ядра, а не отдельных модулей.

Проект [Kata Containers](https://github.com/kata-containers/kata-containers) предоставляет оптимизированное ядро для контейнеров со всеми необходимыми опциями конфигурации, доступное на странице [релизов](https://github.com/kata-containers/kata-containers/releases/).

Образ ядра с именем `vmlinux.container` можно найти в директории `/opt/kata/share/kata-containers/` среди артефактов релиза.

## Подготовка к сборке пакета

Установите Swiftly, [Swift](https://www.swift.org) и [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html):

```bash
make cross-prep
```

Если вы используете нестандартное терминальное приложение, возможно, потребуется переместить эту команду из `.zprofile` в `.zshrc` (замените `<USERNAME>`):

```bash
# Добавлено Swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

Перезапустите терминал. Убедитесь, что команда возвращает `/Users/<USERNAME>/.swiftly/bin/swift` (замените `<USERNAME>`):

```bash
which swift
```

Если вы ранее устанавливали или использовали Static Linux SDK, возможно, потребуется удалить старые версии SDK из системы (замените `<SDK-ID>`):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## Сборка пакета

Соберите Containerization из исходников:

```bash
make all
```

## Тестирование пакета

После сборки запустите базовые и интеграционные тесты:

```bash
make test integration
```

Для запуска интеграционных тестов требуется ядро.  
Если у вас нет локального ядра, по умолчанию можно загрузить ядро с помощью цели `make fetch-default-kernel`.

Загрузка ядра требуется только после первоначальной сборки или после `make clean`.

```bash
make fetch-default-kernel
make all test integration
```

## Протобуфы

Containerization зависит от определённых версий `grpc-swift` и `swift-protobuf`. Вы можете установить их и заново сгенерировать RPC-интерфейсы с помощью:

```bash
make protos
```

## Документация

Сгенерируйте документацию API для локального просмотра:

```bash
make docs
make serve-docs
```

Предварительный просмотр документации можно открыть в другом терминале:

```bash
open http://localhost:8000/documentation/
```

## Вклад в проект

Вклад в Containerization приветствуется и поощряется. Пожалуйста, смотрите [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) для дополнительной информации.

## Статус проекта

Версия 0.1.0 — первый официальный релиз Containerization. Более ранние версии не гарантируют стабильность исходного кода.

Поскольку библиотека Containerization находится в активной разработке, стабильность исходного кода гарантируется только в пределах минорных версий (например, между 0.1.1 и 0.1.2). Если вы не хотите получать обновления, которые могут нарушить совместимость, вы можете указать зависимость пакета с помощью `.upToNextMinorVersion(from: "0.1.0")`.

В будущих минорных версиях пакета эти правила могут быть изменены при необходимости.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---