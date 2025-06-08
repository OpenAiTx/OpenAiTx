# Mamba：快速跨平台套件管理器

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">mamba-org 的一部分</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">套件管理器 <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">套件伺服器 <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![建置狀態](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![加入 Gitter 聊天](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![文件](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` 是用 C++ 重新實現的 conda 套件管理器。

- 透過多執行緒平行下載儲存庫資料和套件檔案
- 使用 libsolv 進行更快速的相依性解析，這是 Red Hat、Fedora 和 OpenSUSE 的 RPM 套件管理器所採用的先進函式庫
- `mamba` 的核心部分以 C++ 實作，以達到最大效率

同時，`mamba` 採用了與 `conda` 相同的命令列解析器、套件安裝與解除安裝程式碼，以及交易驗證流程，以保持最大相容性。

`mamba` 是 [conda-forge](https://conda-forge.org/) 生態系的一部分，該生態系同時也包含 `quetz`，一個開源的 `conda` 套件伺服器。

您可以閱讀我們的[公告部落格文章](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23)。

## micromamba

`micromamba` 是 `mamba` 的靜態連結版本。

它可以作為單一可執行檔安裝，無需任何依賴，非常適合 CI/CD 管線及容器化環境。

詳情請參閱 [micromamba 文件](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html)。

## `mamba` v.s. `micromamba`

建議選用 `mamba` 的情境：

- 其他軟體於同一環境中使用 `libmambapy` 或 `libmamba`。
- 需要定期更新函式庫（尤其是安全性） 的場景。
- 環境著重於減少依賴所需磁碟空間。

建議選用 `micromamba` 的情境：

- 需要依賴單一自包含的可執行檔。
- 沒有 miniforge 發行版。
- 需要最小化執行時需求。

## 安裝

請參閱文件中的 [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
及 [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) 安裝指南。

## Mamba 與 Micromamba 的額外功能

`mamba` 與 `micromamba` 在原生 `conda` 之上提供更多功能。

### `repoquery`

欲高效查詢儲存庫及套件依賴關係，可使用 `mamba repoquery` 或 `micromamba repoquery`。

詳情請參閱 [repoquery 文件](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery)。

### 安裝鎖定檔

`micromamba` 可用於安裝由 [conda-lock](https://conda.github.io/conda-lock/) 產生的鎖定檔，無需安裝 `conda-lock`。

只需以 `-f` 選項呼叫 `micromamba create`，並提供環境鎖定檔，檔名需以
`-lock.yml` 或 `-lock.yaml` 結尾，例如：

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba（setup-miniconda 替代品）

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) 是 [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) 的替代品，採用 `micromamba`。

它可大幅減少您的 CI 設定時間：

- 使用 `micromamba`，安裝僅需約 1 秒。
- 快取套件下載。
- 快取整個 `conda` 環境。

## 與 `conda` 的差異

雖然 `mamba` 和 `micromamba` 通常可直接替換 `conda`，但仍有部分差異：

- `mamba` 與 `micromamba` 不支援修訂（相關討論見 <https://github.com/mamba-org/mamba/issues/803>）
- `mamba` 與 `micromamba` 會將 `MatchSpec` 字串正規化為最簡形式，而 `conda` 使用較冗長的格式
  這可能導致 `conda env export` 與 `mamba env export` 輸出略有不同。

## 開發安裝

請參閱[官方文件](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html)中的說明。

## API 與 ABI 穩定性

Mamba 專案採用 [語意化版本控制](https://semver.org/)（格式為 `MAJOR.MINOR.PATCH`）。
雖然我們盡力為用戶維持穩定，但仍需不時進行破壞性更新以提升 Mamba 並減少技術債。
未來版本將可能提供更強的穩定性保證。

### `libmamba`（C++）

我們尚未發現有 C++ API 的下游使用者，因此保留改進的空間。
對於 `libmamba`，_向後相容_ 定義如下：

- _ABI 向後相容_ 表示可以直接替換函式庫二進位檔，而不需用更新的標頭檔重新編譯您的程式碼。
  除了修復的錯誤（希望如此）及效能，行為應與舊版一致。
- _API 向後相容_ 表示您必須以新版本函式庫的程式碼重新編譯您的程式碼，但無需修改您的程式碼，只需重新建置即可。
  這適用於未使用任何視為私有的宣告，例如在 `detail` 子命名空間中的內容。
  除了修復的錯誤（希望如此）及效能，行為應與舊版一致。
  當宣告已被棄用但未移除且仍可運作時，我們也認為其向後相容，因為僅在編譯時行為發生變化。

基於上述，`libmamba` 提供以下保證：

- `PATCH` 版本為 API 與 ABI 向後相容；
- `MINOR` 版本對 `mamba/api` 宣告維持 API 向後相容；
  其他地方的 API 及任意位置的 ABI 可能會變動；
- `MAJOR` 版本不作任何保證。

### `libmambapy`（Python）

對於 `libmambapy`，_API 向後相容_ 意味著您的 Python 程式碼在新版 `libmambapy` 下能正常運作，只要未使用任何視為私有的宣告（如以 `_` 開頭的名稱）。
除了修復的錯誤（希望如此）及效能，行為應與舊版一致。
當宣告已被棄用但未移除且仍可運作時，我們也認為其向後相容，僅在啟用 Python
`DeprecationWarning` 時才能觀察到變化，通常僅在開發時啟用。

基於上述，`libmambapy` 提供以下保證：

- `PATCH` 版本為 API 向後相容；
- `MINOR` 版本為 API 向後相容；
- `MAJOR` 版本不作任何保證。

### `mamba` 與 `micromamba`（可執行檔）

對於可執行檔，_向後相容_ 應用於可編程輸入與輸出，表示您的程式碼（包含 shell 指令稿）可於新版可執行檔下運作，無需修改。
可編程輸入/輸出包含執行檔名稱、命令列參數、設定檔、環境變數、JSON 命令列輸出及產生的檔案。
_不包含_ 人類可讀的輸出及錯誤訊息，因此人類可讀輸出的棄用警告不在此限。

基於上述，`mamba` 與 `micromamba` 提供以下保證：

- `PATCH` 版本向後相容；
- `MINOR` 版本向後相容；
- `MAJOR` 版本不作任何保證。

## 支持我們

僅 `mamba` 與 `micromamba` 2.0 及以後版本受支持且持續開發。

`1.x` 分支僅針對安全性議題（如 CVE）維護。

如有疑問，歡迎加入 [QuantStack 聊天室](https://gitter.im/QuantStack/Lobby)
或 [Conda 頻道](https://gitter.im/conda/conda)（請注意，本專案與 `conda` 或 Anaconda Inc. 並無官方關聯）。

## 授權

我們採用共享版權模式，使所有貢獻者都可保留其貢獻的版權。

本軟體採用 BSD-3-Clause 授權。詳情請參閱 [LICENSE](https://raw.githubusercontent.com/mamba-org/mamba/main/LICENSE) 檔案。

---

### 雙週開發會議

我們每兩週舉辦一次視訊會議，討論近期進展並互相回饋。

歡迎任何人參加，無論是想討論主題或只是旁聽。

- 時間：週二 [歐洲中歐時間下午 4:00](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- 地點：[Mamba jitsi](https://meet.jit.si/mamba-org)
- 內容：[會議記錄](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---