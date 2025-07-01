# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## Установка

```
yarn install
```

### Запуск

```
yarn run serve
```

### Описание

```
График Ганта, разработанный на основе vue, может использоваться для командной работы, распределения задач и других гибких сценариев

Поддержка группировки
Поддержка перетаскивания
Поддержка растяжения
Поддержка процентов
Поддержка временных интервалов: день, неделя, месяц
В настоящее время реализована только одноуровневая группировка; чтобы избежать проблем с возможными требованиями к двух- или многоуровневой группировке, в последней версии часть кода была рефакторирована для поддержки многоуровневой группировки, но в текущей версии это не реализовано

Преимущества: при перетаскивании, растяжении, изменении прогресса данные не обновляются в реальном времени, а обновляются только после завершения действия, что снижает нагрузку на производительность
              При редактировании, удалении, добавлении не происходит рекурсивного изменения всего экземпляра, а только изменяются, добавляются или удаляются затронутые части

Ведётся подготовка к реорганизации и компонентированию. На данный момент для использования в проекте достаточно импортировать `gant.vue` из данного проекта
Методы массового импорта и экспорта данных уже реализованы, можно копировать напрямую!~

```

### История обновлений

- Поддержка редактирования
- Поддержка удаления
- Исправлен баг с невозможностью вертикальной прокрутки (одновременно добавлена двунаправленная прокрутка) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Исправлен баг, вызванный elementUI
- Вопросы по временным интервалам [#5](https://github.com/GGBeng1/Gantt/issues/5)
- В настоящее время нельзя реализовать другие интервалы, например, добавить часы, путём изменения конфигурации интервала. Некоторые параметры задаются фиксированно при инициализации, в будущем это будет изменено и вынесено в API


### Просмотр примера

См. [демо](https://ggbeng1.github.io/Gantt/#/)

### Пример отображения

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---