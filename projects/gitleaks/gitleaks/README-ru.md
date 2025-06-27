
#### Dir

Команда `dir` (алиасы: `files`, `directory`) позволяет сканировать директории и файлы. Пример: `gitleaks dir -v path_to_directory_or_file`.
Если целевой путь не указан как позиционный аргумент, gitleaks просканирует текущую рабочую директорию.

#### Stdin

Вы также можете передавать данные в gitleaks с помощью команды `stdin`. Пример: `cat some_file | gitleaks -v stdin`

### Создание базовой линии (baseline)

При сканировании больших репозиториев или репозиториев с длинной историей может быть удобно использовать базовую линию. При использовании базовой линии
gitleaks будет игнорировать все старые находки, которые присутствуют в baseline. В качестве baseline может выступать любой отчет gitleaks. Чтобы создать отчет gitleaks, запустите gitleaks с параметром `--report-path`.

```
gitleaks git --report-path gitleaks-report.json # Это сохранит отчет в файл с именем gitleaks-report.json
```

После создания baseline его можно применить при повторном запуске команды detect:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

После запуска команды detect с параметром --baseline-path, отчет (findings.json) будет содержать только новые проблемы.

## Pre-Commit hook

Вы можете запускать Gitleaks как pre-commit hook, скопировав пример скрипта `pre-commit.py` в
ваш каталог `.git/hooks/`.

## Загрузка конфигурации

Порядок приоритета следующий:

1. Опция `--config/-c`:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. Переменная окружения `GITLEAKS_CONFIG` с путем к файлу:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. Переменная окружения `GITLEAKS_CONFIG_TOML` с содержимым файла:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. Файл `.gitleaks.toml` в целевом пути:
      ```bash
      gitleaks git .
      ```

Если ни один из четырех вариантов не используется, gitleaks применит конфигурацию по умолчанию.

## Конфигурация

Gitleaks предлагает формат конфигурации, которому вы можете следовать для написания собственных правил обнаружения секретов:

```toml
# Заголовок для файла конфигурации gitleaks.
title = "Custom Gitleaks configuration"

# У вас есть по сути два варианта для вашей пользовательской конфигурации:
#
# 1. определить свою собственную конфигурацию, стандартные правила не применяются
#
#    используйте, например, стандартную конфигурацию как отправную точку:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. расширить конфигурацию, правила будут перезаписаны или дополнены
#
#    При расширении конфигурации расширенные правила имеют приоритет над
#    стандартными правилами. То есть, если есть дублирующие правила в расширенной
#    конфигурации и в стандартной, расширенные правила или их атрибуты
#    переопределяют стандартные. 
#    Еще один важный момент: при расширении конфигураций вы можете объединять
#    несколько файлов конфигурации с глубиной до 2. Массивы allowlist объединяются
#    и могут содержать дубликаты.

# useDefault и path НЕ МОГУТ использоваться одновременно. Выберите один вариант.
[extend]
# useDefault расширяет стандартную конфигурацию gitleaks, встроенную в бинарник
# последняя версия находится по адресу:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# или вы можете указать путь к конфигурации, от которой расширяться.
# Путь указывается относительно директории запуска gitleaks,
# а не расположения базовой конфигурации.
# path = "common_config.toml"
# Если есть какие-либо правила, которые вы не хотите наследовать, их можно указать здесь.
disabledRules = [ "generic-api-key"]

# Массив таблиц, содержащих информацию, определяющую инструкции
# по обнаружению секретов
[[rules]]
# Уникальный идентификатор для этого правила
id = "awesome-rule-1"

# Краткое человеко-читаемое описание правила.
description = "awesome rule 1"

# Регулярное выражение Golang для обнаружения секретов. Обратите внимание: движок regex Golang
# не поддерживает lookahead.
regex = '''one-go-style-regex-for-this-rule'''

# Int, используемый для извлечения секрета из совпадения regex и как группа, на которую будет
# проверяться энтропия, если задано `entropy`.
secretGroup = 3

# Число с плавающей точкой, представляющее минимальную энтропию по Шеннону, которую группа regex должна иметь, чтобы считаться секретом.
entropy = 3.5

# Регулярное выражение Golang для сопоставления путей. Может использоваться как отдельное правило или
# совместно с валидной записью `regex`.
path = '''a-file-path-regex'''

# Ключевые слова используются для предварительной фильтрации перед проверкой регулярным выражением. 
# Правила, содержащие ключевые слова, выполняют быструю проверку на наличие
# ключевого слова(слов) в сканируемом контенте. Желательно, чтобы эти значения
# были частью идентификатора или уникальными строками, специфичными для regex данного правила
# (введено в v8.6.0)
keywords = [
  "auth",
  "password",
  "token",
]

# Массив строк, используемый для метаданных и отчетности.
tags = ["tag","another tag"]

    # ⚠️ В v8.21.0 `[rules.allowlist]` был заменен на `[[rules.allowlists]]`.
    # Это изменение обратно-совместимо: экземпляры `[rules.allowlist]` по-прежнему работают.
    #
    # Можно определить несколько allowlists для правила, чтобы снизить количество ложных срабатываний.
    # Находка будет проигнорирована, если _ЛЮБОЙ_ из `[[rules.allowlists]]` совпадает.
    [[rules.allowlists]]
    description = "ignore commit A"
    # Если определено несколько критериев, по умолчанию условие "ИЛИ".
    # Например, это может совпасть по |commits| ИЛИ |paths| ИЛИ |stopwords|.
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # примечание: stopwords применяется к извлеченному секрету, а не ко всему совпадению regex
    # как 'regexes'. (stopwords введено в 8.8.0)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # Условие "AND" можно использовать, чтобы все критерии совпали.
    # Например, это совпадет, если удовлетворяются |regexes| И |paths|.
    condition = "AND"
    # примечание: |regexes| по умолчанию проверяет _Secret_ в находке.
    # Допустимые значения для |regexTarget|: "secret" (по умолчанию), "match", "line".
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# Можно расширить конкретное правило из стандартной конфигурации, например, gitlab-pat
# если у вас определен собственный префикс токена в вашей инстанции GitLab
[[rules]]
id = "gitlab-pat"
# все остальные атрибуты наследуются из стандартного правила

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ В v8.25.0 `[allowlist]` был заменен на `[[allowlists]]`.
#
# Глобальные allowlists имеют более высокий приоритет, чем специфичные для правила allowlists.
# Если commit из поля `commits` ниже будет найден, этот коммит будет пропущен, и никакие
# секреты для него обнаружены не будут. Такая же логика применяется к regexes и paths.
[[allowlists]]
description = "global allow list"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# примечание: (глобальный) regexTarget по умолчанию проверяет _Secret_ в находке.
# Допустимые значения для regexTarget: "match" и "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# примечание: stopwords применяется к извлеченному секрету, а не ко всему совпадению regex
# как 'regexes'. (stopwords введено в 8.8.0)
stopwords = [
  '''client''',
  '''endpoint''',
]

# ⚠️ В версии v8.25.0 у `[[allowlists]]` появилось новое поле |targetRules|.
#
# Общие списки разрешённых можно определить один раз и назначить нескольким правилам с помощью |targetRules|.
# Это будет применяться только к указанным правилам, а не глобально.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "Наши тестовые активы вызывают ложные срабатывания в нескольких правилах."
paths = ['''tests/expected/._\.json$''']
```

Обратитесь к [конфигурации gitleaks по умолчанию](https://raw.githubusercontent.com/gitleaks/gitleaks/master/config/gitleaks.toml) для примеров или следуйте [руководству по внесению изменений](https://raw.githubusercontent.com/gitleaks/gitleaks/master/CONTRIBUTING.md), если вы хотите внести вклад в конфигурацию по умолчанию. Кроме того, вы можете ознакомиться с [этой статьей в блоге gitleaks](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf), в которой рассматриваются расширенные настройки конфигурации.

### Дополнительная конфигурация

#### gitleaks:allow

Если вы осознанно коммитите тестовый секрет, который будет обнаружен gitleaks, вы можете добавить комментарий `gitleaks:allow` к этой строке, чтобы gitleaks проигнорировал этот секрет. Пример:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

Вы можете игнорировать определённые находки, создав файл `.gitleaksignore` в корне вашего репозитория. В релизе v8.10.0 в отчёт Gitleaks был добавлен параметр `Fingerprint`. Каждая утечка или находка имеет Fingerprint, который уникально идентифицирует секрет. Добавьте этот fingerprint в файл `.gitleaksignore`, чтобы игнорировать конкретный секрет. Смотрите [.gitleaksignore](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.gitleaksignore) Gitleaks для примера. Примечание: эта функция экспериментальная и может измениться в будущем.

#### Декодирование

Иногда секреты закодированы таким образом, что их трудно найти только с помощью регулярных выражений. Теперь вы можете указать gitleaks автоматически находить и декодировать закодированный текст. Флаг `--max-decode-depth` включает эту функцию (значение по умолчанию "0" означает, что функция отключена).

Поддерживается рекурсивное декодирование, так как декодированный текст также может содержать закодированный текст. Флаг `--max-decode-depth` устанавливает лимит рекурсии. Рекурсия останавливается, когда нет новых сегментов закодированного текста для декодирования, поэтому установка очень большого максимального значения глубины не означает, что будет столько проходов. Будет выполнено только столько проходов, сколько нужно для декодирования текста. В целом, декодирование минимально увеличивает время сканирования.

Находки для закодированного текста отличаются от обычных находок следующим образом:

- Местоположение указывает границы закодированного текста
  - Если правило совпадает за пределами закодированного текста, границы корректируются так, чтобы включать и его
- Поля match и secret содержат декодированное значение
- Добавляются два тега: `decoded:<encoding>` и `decode-depth:<depth>`

В настоящее время поддерживаемые кодировки:

- **percent** – любые печатаемые ASCII значения, закодированные в percent-формате
- **hex** – любые печатаемые ASCII hex значения длиной ≥ 32 символа
- **base64** – любые печатаемые ASCII base64 значения длиной ≥ 16 символов

#### Сканирование архивов

Иногда секреты упакованы в архивные файлы, такие как zip или tarball, что делает их труднодоступными. Теперь вы можете указать gitleaks автоматически извлекать и сканировать содержимое архивов. Флаг `--max-archive-depth` включает эту функцию для типов сканирования `dir` и `git`. Значение по умолчанию "0" означает, что функция отключена.

Поддерживается рекурсивное сканирование, поскольку архивы могут содержать другие архивы. Флаг `--max-archive-depth` устанавливает лимит рекурсии. Рекурсия останавливается, когда нет новых архивов для извлечения, поэтому установка очень большого значения глубины просто задаёт потенциальную глубину. Будет выполнено только столько проходов, сколько необходимо.

Находки для секретов, обнаруженных внутри архива, будут включать путь к файлу внутри архива. Внутренние пути разделяются с помощью `!`.

Пример находки (сокращённо):

```
Finding:     DB_PASSWORD=8ae31cacf141669ddfb5da
...
File:        testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod
Line:        4
Commit:      6e6ee6596d337bb656496425fb98644eb62b4a82
...
Fingerprint: 6e6ee6596d337bb656496425fb98644eb62b4a82:testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod:generic-api-key:4
Link:        https://github.com/leaktk/gitleaks/blob/6e6ee6596d337bb656496425fb98644eb62b4a82/testdata/archives/nested.tar.gz
```

Это означает, что секрет был обнаружен на строке 4 файла `files/.env.prod.`, который находится в
`archives/files.tar`, который в свою очередь находится в `testdata/archives/nested.tar.gz`.

В настоящее время поддерживаются форматы:

Поддерживаются [форматы сжатия](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats)
и [форматы архивов](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats),
поддерживаемые пакетом [archives от mholt](https://github.com/mholt/archives).

#### Отчётность

Gitleaks поддерживает несколько встроенных форматов отчёта: [`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json), [`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml) и [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif).

Если ни один из этих форматов вам не подходит, вы можете создать свой собственный формат отчёта с помощью [Go-файла шаблона `text/template` .tmpl](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) и флага `--report-template`. В шаблоне можно использовать [расширенные функции библиотеки шаблонов `Masterminds/sprig`](https://masterminds.github.io/sprig/).

Например, следующий шаблон обеспечивает пользовательский вывод в формате JSON:
```gotemplate
# jsonextra.tmpl
[{{ $lastFinding := (sub (len . ) 1) }}
{{- range $i, $finding := . }}{{with $finding}}
    {
        "Description": {{ quote .Description }},
        "StartLine": {{ .StartLine }},
        "EndLine": {{ .EndLine }},
        "StartColumn": {{ .StartColumn }},
        "EndColumn": {{ .EndColumn }},
        "Line": {{ quote .Line }},
        "Match": {{ quote .Match }},
        "Secret": {{ quote .Secret }},
        "File": "{{ .File }}",
        "SymlinkFile": {{ quote .SymlinkFile }},
        "Commit": {{ quote .Commit }},
        "Entropy": {{ .Entropy }},
        "Author": {{ quote .Author }},
        "Email": {{ quote .Email }},
        "Date": {{ quote .Date }},
        "Message": {{ quote .Message }},
        "Tags": [{{ $lastTag := (sub (len .Tags ) 1) }}{{ range $j, $tag := .Tags }}{{ quote . }}{{ if ne $j $lastTag }},{{ end }}{{ end }}],
        "RuleID": {{ quote .RuleID }},
        "Fingerprint": {{ quote .Fingerprint }}
    }{{ if ne $i $lastFinding }},{{ end }}
{{- end}}{{ end }}
]
```

Пример использования:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## Спонсорство

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## Коды завершения

Вы всегда можете задать код завершения при обнаружении утечек с помощью флага --exit-code. Коды завершения по умолчанию ниже:

```
0 - утечек нет
1 - обнаружены утечки или ошибка
126 - неизвестный флаг
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---