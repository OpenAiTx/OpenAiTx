# Containerization

Containerization 套件允許應用程式使用 Linux 容器。  
Containerization 是用 [Swift](https://www.swift.org) 撰寫，並在 Apple silicon 上使用 [Virtualization.framework](https://developer.apple.com/documentation/virtualization)。

Containerization 提供以下 API：

- [管理 OCI 映像](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/)。
- [與遠端註冊中心互動](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/)。
- [建立並填充 ext4 檔案系統](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/)。
- [與 Netlink socket 類別互動](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/)。
- [建立優化的 Linux 核心以加快啟動速度](https://raw.githubusercontent.com/apple/containerization/main/kernel/)。
- [啟動輕量級虛擬機並管理執行時環境](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift)。
- [啟動並互動容器化程序](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift)。
- 使用 Rosetta 2 在 Apple silicon 上執行 linux/amd64 容器。

請參閱 [API 文件](https://apple.github.io/containerization/documentation/) 以了解 Containerization 提供的 Swift 套件資訊。

## 設計

Containerization 將每個 Linux 容器執行在其自身的輕量級虛擬機中。客戶端可以為每個容器建立專用 IP 位址，免除個別端口轉發的需求。容器透過優化的 [Linux 核心設定](/kernel) 和搭配輕量級 init 系統的最小根檔案系統，實現秒級啟動時間。

[vminitd](/vminitd) 是一個小型 init 系統，是 Containerization 的子專案。  
`vminitd` 作為虛擬機中的初始程序啟動，並透過 vsock 提供 GRPC API。  
該 API 允許配置執行時環境並啟動容器化程序。  
`vminitd` 在程序執行時為呼叫程序提供 I/O、訊號及事件。

## 系統需求

您需要 Apple silicon Mac 來建構與執行 Containerization。

建構 Containerization 套件需要符合以下條件之一：

- macOS 15 或更新版本，且 Xcode 26 beta
- macOS 26 beta 或更新版本

使用此套件建置的應用程式可在 macOS 15 或更新版本執行，但 macOS 15 上不支援以下功能：

- 非隔離容器網路 — 在 macOS 15 上，同一 vmnet 網路中的容器無法相互通訊

## 範例使用

若要了解如何使用部分函式庫介面，cctl 可執行檔是一個不錯的起點。此工具主要作為 API 試驗場，包含測試各產品核心功能的指令，例如：

1. [操作 OCI 映像](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)  
2. [登入容器註冊中心](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)  
3. [建立根檔案系統區塊](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)  
4. [執行簡單的 Linux 容器](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)  

## Linux 核心

在 macOS 上啟動輕量級虛擬機需要 Linux 核心。  
Containerization 提供位於 [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel) 目錄下的優化核心設定。

此目錄包含容器化建置環境，可輕鬆編譯用於 Containerization 的核心。

核心設定為支援快速啟動及輕量環境的最小功能集。

雖然此設定可適用於多數工作負載，但我們了解部分需求可能需額外功能。  
為此，Containerization 提供一級 API，允許每個容器使用不同的核心設定與版本。  
此功能使容器可針對不同核心版本進行開發與驗證。

請參閱 kernel 目錄中的 [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) 以了解如何編譯優化核心。

### 預建核心

若您想使用預建核心，核心必須將 `VIRTIO` 驅動編譯進核心中，不能作為模組。

[Kata Containers](https://github.com/kata-containers/kata-containers) 專案提供容器用的優化核心，所有必要的配置選項皆已啟用，並可在其 [releases](https://github.com/kata-containers/kata-containers/releases/) 頁面取得。

核心映像檔 `vmlinux.container` 位於釋出檔案的 `/opt/kata/share/kata-containers/` 目錄中。

## 建構套件準備

安裝 Swiftly、[Swift](https://www.swift.org) 與 [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html)：

```bash
make cross-prep
```

若使用自訂終端機應用程式，可能需要將此指令從 `.zprofile` 移至 `.zshrc`（請替換 `<USERNAME>`）：

```bash
# Added by swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

重新啟動終端機應用程式。確保此指令回傳 `/Users/<USERNAME>/.swiftly/bin/swift`（請替換 `<USERNAME>`）：

```bash
which swift
```

若之前安裝或使用過 Static Linux SDK，可能需移除系統中的舊版 SDK（請替換 `<SDK-ID>`）：

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## 建構套件

從原始碼建構 Containerization：

```bash
make all
```

## 測試套件

建構後執行基本與整合測試：

```bash
make test integration
```

執行整合測試需有核心。  
若本地沒有可用核心，可使用 `make fetch-default-kernel` 指令下載預設核心。

下載預設核心只需在初次建構後或執行 `make clean` 後執行一次。

```bash
make fetch-default-kernel
make all test integration
```

## Protobufs

Containerization 依賴特定版本的 `grpc-swift` 與 `swift-protobuf`。您可安裝並重新產生 RPC 介面：

```bash
make protos
```

## 文件

產生本機瀏覽的 API 文件：

```bash
make docs
make serve-docs
```

在另一個終端機執行以下指令預覽文件：

```bash
open http://localhost:8000/documentation/
```

## 貢獻

歡迎並鼓勵為 Containerization 貢獻。詳細資訊請參閱 [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md)。

## 專案狀態

版本 0.1.0 是 Containerization 的首個正式發行版本。早期版本不保證原始碼穩定性。

由於 Containerization 正處於積極開發階段，原始碼穩定性僅在次版本內保證（例如 0.1.1 與 0.1.2 之間）。若您不希望遭遇可能破壞原始碼的套件更新，可使用 .upToNextMinorVersion(from: "0.1.0") 指定套件相依版本。

未來次版本可能視需求調整這些規則。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---