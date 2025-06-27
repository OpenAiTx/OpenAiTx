# Gitleaks

```
┌─○───┐
│ │╲  │
│ │ ○ │
│ ○ ░ │
└─░───┘
```

[license]: https://raw.githubusercontent.com/gitleaks/gitleaks/master/LICENSE
[badge-license]: https://img.shields.io/github/license/gitleaks/gitleaks.svg
[go-docs-badge]: https://pkg.go.dev/badge/github.com/gitleaks/gitleaks/v8?status
[go-docs]: https://pkg.go.dev/github.com/zricethezav/gitleaks/v8
[badge-build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml/badge.svg
[build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml
[go-report-card-badge]: https://goreportcard.com/badge/github.com/gitleaks/gitleaks/v8
[go-report-card]: https://goreportcard.com/report/github.com/gitleaks/gitleaks/v8
[dockerhub]: https://hub.docker.com/r/zricethezav/gitleaks
[dockerhub-badge]: https://img.shields.io/docker/pulls/zricethezav/gitleaks.svg
[gitleaks-action]: https://github.com/gitleaks/gitleaks-action
[gitleaks-badge]: https://img.shields.io/badge/protected%20by-gitleaks-blue
[gitleaks-playground-badge]: https://img.shields.io/badge/gitleaks%20-playground-blue
[gitleaks-playground]: https://gitleaks.io/playground


[![GitHub Action Test][badge-build]][build]
[![Docker Hub][dockerhub-badge]][dockerhub]
[![Gitleaks Playground][gitleaks-playground-badge]][gitleaks-playground]
[![Gitleaks Action][gitleaks-badge]][gitleaks-action]
[![GoDoc][go-docs-badge]][go-docs]
[![GoReportCard][go-report-card-badge]][go-report-card]
[![License][badge-license]][license]


### 加入我們的 Discord！[![Discord](https://img.shields.io/discord/1102689410522284044.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/8Hzbrnkr7E)

Gitleaks 是一個用於**檢測**密碼、API 金鑰和令牌等秘密資訊的工具，可用於 git 倉庫、檔案，以及任何你想透過 `stdin` 傳入的內容。如果你想進一步了解偵測引擎的運作方式，請參閱這篇部落格：[Regex is (almost) all you need](https://lookingatcomputer.substack.com/p/regex-is-almost-all-you-need)。

```
➜  ~/code(master) gitleaks git -v

    ○
    │╲
    │ ○
    ○ ░
    ░    gitleaks


Finding:     "export BUNDLE_ENTERPRISE__CONTRIBSYS__COM=cafebabe:deadbeef",
Secret:      cafebabe:deadbeef
RuleID:      sidekiq-secret
Entropy:     2.609850
File:        cmd/generate/config/rules/sidekiq.go
Line:        23
Commit:      cd5226711335c68be1e720b318b7bc3135a30eb2
Author:      John
Email:       john@users.noreply.github.com
Date:        2022-08-03T12:31:40Z
Fingerprint: cd5226711335c68be1e720b318b7bc3135a30eb2:cmd/generate/config/rules/sidekiq.go:sidekiq-secret:23
```

## 快速開始

Gitleaks 可以透過 Homebrew、Docker 或 Go 安裝。Gitleaks 也以二進位檔形式，支援多種主流平台與作業系統，請參閱 [發佈頁面](https://github.com/gitleaks/gitleaks/releases)。此外，Gitleaks 可作為 pre-commit hook 直接在你的 repo 中實現，或作為 GitHub Action，使用 [Gitleaks-Action](https://github.com/gitleaks/gitleaks-action)。

### 安裝

```bash
# MacOS
brew install gitleaks

# Docker (DockerHub)
docker pull zricethezav/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path zricethezav/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Docker (ghcr.io)
docker pull ghcr.io/gitleaks/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path ghcr.io/gitleaks/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# 原始碼安裝（請確認已安裝 `go`）
git clone https://github.com/gitleaks/gitleaks.git
cd gitleaks
make build
```

### GitHub Action

請參閱官方的 [Gitleaks GitHub Action](https://github.com/gitleaks/gitleaks-action)

```
name: gitleaks
on: [pull_request, push, workflow_dispatch]
jobs:
  scan:
    name: gitleaks
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v3
        with:
          fetch-depth: 0
      - uses: gitleaks/gitleaks-action@v2
        env:
          GITHUB_TOKEN: ${{ secrets.GITHUB_TOKEN }}
          GITLEAKS_LICENSE: ${{ secrets.GITLEAKS_LICENSE}} # 僅組織需要，個人帳戶不需要。
```

### Pre-Commit

1. 從 https://pre-commit.com/#install 安裝 pre-commit
2. 在你的 repository 根目錄建立 `.pre-commit-config.yaml` 檔案，內容如下：

   ```
   repos:
     - repo: https://github.com/gitleaks/gitleaks
       rev: v8.24.2
       hooks:
         - id: gitleaks
   ```

   如需[原生執行 gitleaks](https://github.com/gitleaks/gitleaks/releases)，或使用 [`gitleaks-docker` pre-commit ID](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.pre-commit-hooks.yaml) 以 [官方 Docker 映像檔](#docker) 執行 gitleaks

3. 執行 `pre-commit autoupdate` 自動更新設定檔至最新版本
4. 使用 `pre-commit install` 安裝
5. 現在一切就緒！

```
➜ git commit -m "this commit contains a secret"
Detect hardcoded secrets.................................................Failed
```

注意：如要停用 gitleaks pre-commit hook，可在提交命令前加上 `SKIP=gitleaks`，即可跳過 gitleaks 的執行

```
➜ SKIP=gitleaks git commit -m "skip gitleaks check"
Detect hardcoded secrets................................................Skipped
```

## 使用方法

```
用法：
  gitleaks [command]

可用指令：
  dir         掃描目錄或檔案中的秘密資訊
  git         掃描 git 倉庫中的秘密資訊
  help        取得任何指令的說明
  stdin       從標準輸入偵測秘密資訊
  version     顯示 gitleaks 版本

選項旗標：
  -b, --baseline-path string          可忽略問題的 baseline 路徑
  -c, --config string                 設定檔路徑
                                      優先順序如下：
                                      1. --config/-c
                                      2. 環境變數 GITLEAKS_CONFIG
                                      3. 環境變數 GITLEAKS_CONFIG_TOML（包含檔案內容）
                                      4. (目標路徑)/.gitleaks.toml
                                      若未使用上述四種方式，gitleaks 將使用預設設定檔
      --diagnostics string            啟用診斷（以逗號分隔：cpu,mem,trace）。cpu=CPU 分析，mem=記憶體分析，trace=執行追蹤
      --diagnostics-dir string        儲存診斷輸出檔案的目錄（預設為目前目錄）
      --enable-rule strings           僅啟用指定 ID 的規則
      --exit-code int                 當檢測到洩漏時的結束碼（預設 1）
  -i, --gitleaks-ignore-path string   .gitleaksignore 檔或包含該檔的資料夾路徑（預設 "."）
  -h, --help                          顯示 gitleaks 說明
      --ignore-gitleaks-allow         忽略 gitleaks:allow 註解
  -l, --log-level string              日誌等級（trace, debug, info, warn, error, fatal）（預設 "info"）
      --max-decode-depth int          允許遞迴解碼至此深度（預設 "0"，不進行解碼）
      --max-archive-depth int         允許深入嵌套壓縮檔掃描的深度（預設 "0"，不遍歷壓縮檔）
      --max-target-megabytes int      超過此大小的檔案將被跳過
      --no-banner                     隱藏橫幅
      --no-color                      關閉詳細輸出時的顏色
      --redact uint[=100]             在日誌和標準輸出中遮蔽秘密資訊。僅遮蔽部分秘密資訊請設定百分比 0..100，例如 --redact=20（預設 100%）
  -f, --report-format string          輸出格式（json, csv, junit, sarif, template）
  -r, --report-path string            報告檔案路徑
      --report-template string        產生報告時使用的模板檔案（等同於 --report-format=template）
  -v, --verbose                       顯示掃描詳細輸出
      --version                       顯示 gitleaks 版本

可使用 "gitleaks [command] --help" 取得各指令的詳細說明。
```

### 指令

⚠️ v8.19.0 推出了更動，將 `detect` 和 `protect` 指令棄用。這些指令仍可用，但在 `--help` 選單中已隱藏。請參閱這份 [gist](https://gist.github.com/zricethezav/b325bb93ebf41b9c0b0507acf12810d2) 以便查找指令對照。
如果你發現 v8.19.0 影響了現有的指令（`detect`/`protect`），請提交 issue。

目前有三種掃描模式：`git`、`dir` 和 `stdin`。

#### Git

`git` 指令可用於掃描本地 git 倉庫。在底層，gitleaks 使用 `git log -p` 指令來掃描補丁。
你可以透過 `log-opts` 選項來調整 `git log -p` 的行為。
例如，若要針對指定的提交區間執行 gitleaks，可以使用如下指令：`gitleaks git -v --log-opts="--all commitA..commitB" path_to_repo`。更多資訊請參閱 [git log](https://git-scm.com/docs/git-log) 文件。
如果未指定目標作為參數，gitleaks 會嘗試將目前工作目錄作為 git 倉庫進行掃描。
#### Dir

`dir`（別名包括 `files`、`directory`）指令可讓你掃描目錄和檔案。例如：`gitleaks dir -v path_to_directory_or_file`。
如果未指定目標作為位置參數，gitleaks 將會掃描目前工作目錄。

#### Stdin

你也可以使用 `stdin` 指令將資料串流給 gitleaks。例如：`cat some_file | gitleaks -v stdin`

### 建立基線

當掃描大型版本庫或歷史悠久的版本庫時，使用基線會很方便。使用基線時，
gitleaks 會忽略任何出現在基線中的舊發現。基線可以是任何 gitleaks 報告。要建立 gitleaks 報告，請使用 `--report-path` 參數執行 gitleaks。

```
gitleaks git --report-path gitleaks-report.json # 這會將報告儲存在名為 gitleaks-report.json 的檔案中
```

建立基線後，可以在再次執行 detect 指令時套用：

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

在使用 --baseline-path 參數執行 detect 指令後，報告輸出（findings.json）只會包含新問題。

## Pre-Commit hook

你可以將 Gitleaks 作為 pre-commit hook 運行，只需將範例 `pre-commit.py` 腳本複製到
你的 `.git/hooks/` 目錄下即可。

## 載入設定

優先順序如下：

1. `--config/-c` 選項：
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. 環境變數 `GITLEAKS_CONFIG`，值為檔案路徑：
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. 環境變數 `GITLEAKS_CONFIG_TOML`，值為檔案內容：
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. 目標路徑中的 `.gitleaks.toml` 檔案：
      ```bash
      gitleaks git .
      ```

如果未使用上述四種方式，gitleaks 將使用預設設定。

## 設定檔

Gitleaks 提供一種設定格式，可用於撰寫自訂的機密檢測規則：

```toml
# gitleaks 設定檔標題。
title = "Custom Gitleaks configuration"

# 你基本上有兩種自訂設定的選擇：
#
# 1. 定義自己的設定，不套用預設規則
#
#    例如，使用預設設定作為起點：
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. 擴展某個設定，規則會被覆蓋或擴展
#
#    當你擴展設定時，擴展規則優先於預設規則。也就是說，如果擴展設定和預設設定中有重複規則，
#    則擴展規則或其屬性會覆蓋預設規則。
#    另一個需要知道的事項是，你可以將多個設定檔串接起來，最多深度為 2。Allowlist 陣列會被附加，可以包含重複項目。

# useDefault 與 path 不能同時使用。請擇一。
[extend]
# useDefault 會擴展內建於二進位檔的預設 gitleaks 設定
# 最新版本位於：
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# 或者你可以提供要擴展的設定檔路徑。
# 路徑是相對於執行 gitleaks 時的位置，
# 而不是 base config 的位置。
# path = "common_config.toml"
# 如果有任何規則你不想繼承，可以在這裡指定。
disabledRules = [ "generic-api-key"]

# 一個包含資訊的表格陣列，用於定義如何檢測機密的指令
[[rules]]
# 此規則的唯一識別碼
id = "awesome-rule-1"

# 規則的人類可讀簡短描述。
description = "awesome rule 1"

# Golang 正規表示式，用於檢測機密。請注意 Golang 的 regex 引擎
# 不支援 lookaheads。
regex = '''one-go-style-regex-for-this-rule'''

# 用於從 regex 匹配中提取機密的整數，會作為群組檢查
# 熵值（如果設置了 `entropy`）。
secretGroup = 3

# 表示 regex 群組必須達到的最小 shannon 熵值（float），才會被視為機密。
entropy = 3.5

# Golang 正規表示式，用於匹配路徑。可作為獨立規則，也可與有效的 `regex` 結合使用。
path = '''a-file-path-regex'''

# 關鍵字用於正則檢查前的過濾。包含關鍵字的規則會先進行快速字串比對，
# 確保關鍵字出現在被掃描內容中。理想情況下，這些值應該
# 是識別碼的一部分，或為該規則正則專屬的唯一字串
#（自 v8.6.0 起引入）
keywords = [
  "auth",
  "password",
  "token",
]

# 用於中繼資料和報告的字串陣列。
tags = ["tag","another tag"]

    # ⚠️ 在 v8.21.0，`[rules.allowlist]` 被 `[[rules.allowlists]]` 取代。
    # 這個變更是向下相容的：`[rules.allowlist]` 仍可使用。
    #
    # 你可以為一個規則定義多個 allowlists，以減少誤判。
    # 如果 _任何_ `[[rules.allowlists]]` 匹配，該發現會被忽略。
    [[rules.allowlists]]
    description = "ignore commit A"
    # 當定義多個條件時，預設為 "OR"。
    # 例如，這可以匹配 |commits| 或 |paths| 或 |stopwords|。
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # 注意：stopwords 只針對提取出的機密，而不是整個 regex 匹配
    #（如 'regexes' 一樣）。(stopwords 於 8.8.0 引入)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # 可以使用 "AND" 條件來確保所有條件都滿足。
    # 例如，當 |regexes| 和 |paths| 都滿足時才匹配。
    condition = "AND"
    # 注意：|regexes| 預設檢查發現中的 _Secret_。
    # 可接受的 |regexTarget| 值有 "secret"（預設）、"match" 和 "line"。
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# 你可以從預設設定擴展某個特定規則。例如 gitlab-pat
# 如果你的 GitLab 實例定義了自訂 token 前綴
[[rules]]
id = "gitlab-pat"
# 其他屬性會從預設規則繼承

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ 在 v8.25.0，`[allowlist]` 被 `[[allowlists]]` 取代。
#
# 全域 allowlists 優先於規則層級的 allowlists。
# 如果在下方 `commits` 欄列出的 commit 被遇到，該 commit 會被略過，
# 不會檢測該 commit 的任何機密。regexes 和 paths 的邏輯相同。
[[allowlists]]
description = "global allow list"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# 注意：（全域）regexTarget 預設檢查發現中的 _Secret_。
# 可接受的 regexTarget 值有 "match" 和 "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# 注意：stopwords 只針對提取出的機密，而不是整個 regex 匹配
#（如 'regexes' 一樣）。(stopwords 於 8.8.0 引入)
stopwords = [
  '''client''',
  '''endpoint''',
]

# ⚠️ 在 v8.25.0，`[[allowlists]]` 增加了一個新欄位 |targetRules|。
#
# 可以只定義一次通用的 allowlists，並通過 |targetRules| 指派給多個規則。
# 這只會在指定的規則上運行，不會全域套用。
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "我們的測試資產在幾個規則中觸發了誤判。"
paths = ['''tests/expected/._\.json$''']
```

請參考預設的 [gitleaks 設定檔](https://raw.githubusercontent.com/gitleaks/gitleaks/master/config/gitleaks.toml) 以獲取範例，或若您希望對預設設定檔作出貢獻，請遵循 [貢獻指南](https://raw.githubusercontent.com/gitleaks/gitleaks/master/CONTRIBUTING.md)。此外，您也可以參考 [這篇 gitleaks 部落格文章](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf)，其中涵蓋了進階設定方法。

### 其他設定

#### gitleaks:allow

如果您明知要提交一個 gitleaks 會捕捉到的測試密鑰，可以在該行加上 `gitleaks:allow` 註解，gitleaks 就會忽略該密鑰。例如：

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

您可以在 repo 根目錄建立 `.gitleaksignore` 檔案來忽略特定的發現。在 v8.10.0 版本，Gitleaks 為報告中的每個發現新增了一個 `Fingerprint` 值。每個洩漏或發現都有一個可唯一識別密鑰的指紋。將這個指紋加入 `.gitleaksignore` 檔案，即可忽略該特定密鑰。請參考 Gitleaks 的 [ .gitleaksignore](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.gitleaksignore) 以獲取範例。注意：此功能屬於實驗性質，未來可能變動。

#### 解碼（Decoding）

有時密鑰會以某種編碼方式儲存，僅靠正規表示式很難發現。
現在您可以讓 gitleaks 自動尋找並解碼已編碼的文本。`--max-decode-depth` 旗標可啟用此功能（預設值為 "0"，表示預設停用）。

支援遞迴解碼，因為解碼後的文本也可能包含編碼文本。`--max-decode-depth` 旗標設定遞迴上限。當沒有新的編碼段可解碼時，遞迴會停止，因此即使設定很高的最大深度，也不代表會做那麼多次遞迴，只會視需要進行。整體而言，解碼功能對掃描時間的影響很小。

對於已編碼文本的發現，與一般發現有以下不同：

- 位置指向編碼文本的範圍
  - 若規則在編碼文本之外也有匹配，範圍會調整以涵蓋該部份
- match 和 secret 會包含解碼後的值
- 會新增兩個標籤 `decoded:<encoding>` 和 `decode-depth:<depth>`

目前支援的編碼：

- **percent** - 所有可列印的 ASCII 百分號編碼值
- **hex** - 所有可列印的 ASCII 十六進位編碼值，長度 ≥ 32 字元
- **base64** - 所有可列印的 ASCII base64 編碼值，長度 ≥ 16 字元

#### 壓縮檔掃描（Archive Scanning）

有時密鑰會打包在 zip 或 tarball 等壓縮檔內，難以發現。
現在您可以讓 gitleaks 自動解壓並掃描壓縮檔內容。`--max-archive-depth` 旗標可啟用此功能，適用於 `dir` 和 `git` 掃描型態。預設值為 "0"，即預設停用。

支援遞迴掃描，因壓縮檔內也可能包含其他壓縮檔。`--max-archive-depth` 旗標設定遞迴上限。當沒有新的壓縮檔可解壓時，遞迴會停止，因此即使設定很高的最大深度，也只會視需要進行。

對於位於壓縮檔內的密鑰，發現內容會包含壓縮檔內部路徑。內部路徑以 `!` 分隔。

範例發現（僅展示重點）：

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

這表示在 `files/.env.prod.` 的第 4 行偵測到一個密鑰，該檔案在
`archives/files.tar` 之內，而 `archives/files.tar` 又在 `testdata/archives/nested.tar.gz` 之內。

目前支援的格式：

支援 [mholt's archives 套件](https://github.com/mholt/archives) 支援的 [壓縮格式](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats) 和 [壓縮檔格式](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats)。

#### 報告（Reporting）

Gitleaks 內建支援多種報告格式：[`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json)、[`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1)、[`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml) 以及 [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif)。

如果這些格式都不符合您的需求，您可以用 [Go `text/template` .tmpl 檔案](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) 搭配 `--report-template` 旗標自訂報告格式。模板可使用 [`Masterminds/sprig` 模板函式庫的擴展功能](https://masterminds.github.io/sprig/)。

例如，下列模板可產生自訂 JSON 輸出：
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

使用方法：
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## 贊助

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## 結束代碼（Exit Codes）

當發現洩漏時，您可使用 --exit-code 旗標設定返回碼。預設返回碼如下：

```
0 - 無洩漏
1 - 發現洩漏或發生錯誤
126 - 不明旗標
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---