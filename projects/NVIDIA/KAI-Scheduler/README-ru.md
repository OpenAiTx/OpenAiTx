[![Лицензия](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Покрытие](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
KAI Scheduler — это надёжный, эффективный и масштабируемый [Kubernetes-оркестратор](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/), оптимизирующий распределение ресурсов GPU для рабочих нагрузок искусственного интеллекта и машинного обучения.

Он разработан для управления крупномасштабными GPU-кластерами, включающими тысячи узлов и обеспечивающими высокую пропускную способность рабочих нагрузок, что делает KAI Scheduler идеальным выбором для обширных и требовательных сред.
KAI Scheduler позволяет администраторам Kubernetes-кластеров динамически распределять ресурсы GPU между рабочими нагрузками.

KAI Scheduler поддерживает весь жизненный цикл AI: от небольших интерактивных заданий, требующих минимальных ресурсов, до крупных задач обучения и инференса — всё в рамках одного кластера.
Он обеспечивает оптимальное распределение ресурсов при сохранении справедливости между различными потребителями.
Может работать параллельно с другими оркестраторами, установленными в кластере.

## Ключевые возможности
* [Пакетное планирование](docs/batch/README.md): Обеспечивает одновременное планирование всех pod'ов в группе или отказ для всех.
* Упаковка (Bin Packing) и Распределённое планирование (Spread Scheduling): Оптимизация использования узлов путём минимизации фрагментации (упаковка) или повышения отказоустойчивости и балансировки нагрузки (распределённое планирование).
* [Приоритеты рабочих нагрузок](docs/priority/README.md): Эффективное управление приоритетами рабочих нагрузок внутри очередей.
* [Иерархические очереди](docs/queues/README.md): Управление рабочими нагрузками с помощью двухуровневых иерархий очередей для гибкого организационного контроля.
* [Распределение ресурсов](docs/fairness/README.md#resource-division-algorithm): Настройка квот, весов сверх квоты, лимитов и приоритетов для каждой очереди.
* [Политики справедливости](docs/fairness/README.md#reclaim-strategies): Справедливое распределение ресурсов с использованием Dominant Resource Fairness (DRF) и механизмов возврата ресурсов между очередями.
* Консолидация рабочих нагрузок: Интеллектуальное перераспределение выполняющихся задач для снижения фрагментации и повышения утилизации кластера.
* [Эластичные рабочие нагрузки](docs/elastic/README.md): Динамическое масштабирование рабочих нагрузок в пределах заданного минимального и максимального числа pod'ов.
* Динамическое распределение ресурсов (DRA): Поддержка аппаратных ресурсов от разных вендоров через Kubernetes ResourceClaims (например, GPU от NVIDIA или AMD).
* [Шеринг GPU](docs/gpu-sharing/README.md): Эффективное совместное использование одного или нескольких GPU различными рабочими нагрузками для максимизации утилизации ресурсов.
* Поддержка облака и on-premise: Полная совместимость с динамическими облачными инфраструктурами (включая авто-масштабаторы типа Karpenter), а также со статическими on-premise решениями.

## Необходимые условия
Перед установкой KAI Scheduler убедитесь, что у вас есть:

- Запущенный Kubernetes-кластер
- Установленный [Helm](https://helm.sh/docs/intro/install) CLI
- Установленный [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) для планирования рабочих нагрузок, использующих GPU

## Установка
KAI Scheduler будет установлен в пространство имён `kai-scheduler`. При запуске рабочих нагрузок убедитесь, что используете отдельное пространство имён.

### Способы установки
KAI Scheduler можно установить:

- **Из Production-репозитория (рекомендуется)**
- **Из исходников (собрать самостоятельно)**

#### Установка из Production
Найдите последнюю версию в разделе [releases](https://github.com/NVIDIA/KAI-Scheduler/releases).
Выполните следующую команду, заменив `<VERSION>` на нужную версию:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### Сборка из исходников
Следуйте инструкции [здесь](docs/developer/building-from-source.md)

## Быстрый старт
Чтобы начать планирование рабочих нагрузок с помощью KAI Scheduler, перейдите к [примеру быстрого старта](docs/quickstart/README.md)

## Дорожная карта

### Основные приоритеты на 2025 год
* Рефакторинг кода для повышения независимости от поставщиков оборудования
* Поддержка Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Исследование возможности интеграции с Kueue https://github.com/NVIDIA/KAI-Scheduler/issues/68
* Добавление поддержки Topology Aware Scheduling для pod-group https://github.com/NVIDIA/KAI-Scheduler/issues/66
* Поддержка минимального времени выполнения для рабочих нагрузок
* Поддержка максимального времени выполнения для рабочих нагрузок (с отложенной повторной постановкой в очередь)
* Добавление большего числа PriorityClasses в стандартную установку KAI
* Поддержка JobSet
* Поддержка LWS (LeaderWorkerSet)
* Добавление метрик для вытеснения pod'ов и pod-group
* Разделение приоритетов и вытеснения

### Долгосрочные цели
* Поддержка time decay для каждой очереди
* Улучшения для гипермасштабирования
* Поддержка консолидации инференс-работ для дефрагментации кластера
* Поддержка n-уровневых иерархий очередей
* Плавное обновление инференс-работ (новая ревизия с временным превышением квоты очереди)

## Сообщество, обсуждения и поддержка

Мы будем рады обратной связи! Вот лучшие способы связаться с нами:

### Slack
Присоединяйтесь к [CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf) и посетите канал [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler).

### Созвоны сообщества (раз в две недели)  
**Когда:** Каждый второй понедельник в 17:00 CEST  
[Преобразовать во временную зону](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [Добавить в календарь](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [Заметки и повестка встречи](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### Почтовая рассылка  
Присоединяйтесь к [списку рассылки kai-scheduler](https://groups.google.com/g/kai-scheduler), чтобы получать обновления о встречах.

### Технические вопросы и предложения по функциям  
Пожалуйста, создайте [GitHub issue](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) для сообщений об ошибках, предложений по функциям или технической помощи. Это помогает нам отслеживать запросы и эффективно реагировать.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---