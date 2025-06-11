# コンテナ化

ContainerizationパッケージはアプリケーションがLinuxコンテナを使用できるようにします。  
Containerizationは[Swift](https://www.swift.org)で書かれており、Appleシリコン上で[Virtualization.framework](https://developer.apple.com/documentation/virtualization)を使用しています。

Containerizationは以下のAPIを提供します:

- [OCIイメージの管理](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/)。
- [リモートレジストリとのやり取り](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/)。
- [ext4ファイルシステムの作成と内容の設定](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/)。
- [Netlinkソケットファミリーとのやり取り](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/)。
- [高速起動のために最適化されたLinuxカーネルの作成](https://raw.githubusercontent.com/apple/containerization/main/kernel/)。
- [軽量仮想マシンの生成とランタイム環境の管理](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift)。
- [コンテナ化されたプロセスの生成と操作](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift)。
- Appleシリコン上でlinux/amd64コンテナを実行するためのRosetta 2の使用。

Containerizationが提供するSwiftパッケージに関する情報は[APIドキュメント](https://apple.github.io/containerization/documentation/)をご覧ください。

## 設計

Containerizationは各Linuxコンテナを独自の軽量仮想マシン内で実行します。  
クライアントは各コンテナに専用のIPアドレスを割り当てることができ、個別のポート転送は不要です。  
コンテナは最適化された[Linuxカーネル構成](https://raw.githubusercontent.com/apple/containerization/main/kernel)と軽量なinitシステムを備えた最小限のルートファイルシステムを使用し、サブ秒単位での起動時間を実現しています。

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd)はContainerizationのサブプロジェクトである小さなinitシステムです。  
`vminitd`は仮想マシン内で最初に生成されるプロセスで、vsockを介したGRPC APIを提供します。  
このAPIにより、ランタイム環境の設定やコンテナ化されたプロセスの起動が可能です。  
`vminitd`はプロセス実行時に呼び出し元プロセスへI/O、シグナル、およびイベントを提供します。

## 要件

Containerizationのビルドと実行にはAppleシリコンMacが必要です。

Containerizationパッケージをビルドするには、システムに以下のいずれかが必要です:

- macOS 15以降およびXcode 26ベータ
- macOS 26ベータ以降

このパッケージでビルドされたアプリケーションはmacOS 15以降で動作しますが、macOS 15では以下の機能は利用できません:

- 非分離コンテナネットワーキング - macOS 15では同一vmnetネットワーク上のコンテナ同士が通信できません

## 使用例

一部のライブラリの使用例として、cctl実行可能ファイルが良い出発点です。  
このツールはAPIの試用場としての役割を持ち、さまざまな製品のコア機能を試すコマンドを含みます:

1. [OCIイメージの操作](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)
2. [コンテナレジストリへのログイン](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)
3. [ルートファイルシステムブロックの作成](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)
4. [シンプルなLinuxコンテナの実行](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)

## Linuxカーネル

macOS上で軽量仮想マシンを生成するにはLinuxカーネルが必要です。  
Containerizationは最適化されたカーネル構成を[kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel)ディレクトリに提供しています。

このディレクトリにはContainerization用カーネルを簡単にコンパイルするためのコンテナ化されたビルド環境が含まれています。

カーネル構成は高速起動と軽量環境をサポートするための最小限の機能セットです。

この構成は大多数のワークロードで動作しますが、一部には追加機能が必要な場合もあります。  
これを解決するために、Containerizationはコンテナ単位で異なるカーネル構成やバージョンを使用できるファーストクラスのAPIを提供しています。  
これにより、コンテナを異なるカーネルバージョンで開発・検証可能です。

最適化カーネルのコンパイル方法についてはkernelディレクトリ内の[README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md)を参照してください。

### 事前ビルド済みカーネル

事前ビルド済みカーネルを使用する場合、`VIRTIO`ドライバーがモジュールではなくカーネルに組み込まれている必要があります。

[Kata Containers](https://github.com/kata-containers/kata-containers)プロジェクトは必要な設定オプションをすべて有効にしたコンテナ用最適化カーネルを[リリースページ](https://github.com/kata-containers/kata-containers/releases/)で提供しています。

`vmlinux.container`というカーネルイメージはリリースアーティファクトの`/opt/kata/share/kata-containers/`ディレクトリにあります。

## パッケージビルド準備

Swiftly、[Swift](https://www.swift.org)、および[Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html)をインストールします:

```bash
make cross-prep
```

カスタムのターミナルアプリケーションを使用している場合、このコマンドを`.zprofile`から`.zshrc`に移す必要があるかもしれません（`<USERNAME>`は置き換えてください）:

```bash
# Added by swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

ターミナルを再起動してください。次のコマンドが`/Users/<USERNAME>/.swiftly/bin/swift`を返すことを確認してください（`<USERNAME>`は置き換えてください）:

```bash
which swift
```

以前にStatic Linux SDKをインストールまたは使用している場合、古いSDKバージョンを削除する必要があるかもしれません（`<SDK-ID>`は置き換えてください）:

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## パッケージのビルド

ソースからContainerizationをビルドします:

```bash
make all
```

## パッケージのテスト

ビルド後、基本テストと統合テストを実行します:

```bash
make test integration
```

統合テストを実行するにはカーネルが必要です。  
ローカルにカーネルがない場合は、`make fetch-default-kernel`ターゲットを使ってデフォルトカーネルを取得できます。

デフォルトカーネルの取得は初回ビルド後または`make clean`後にのみ必要です。

```bash
make fetch-default-kernel
make all test integration
```

## Protobufs

Containerizationは特定バージョンの`grpc-swift`と`swift-protobuf`に依存しています。これらをインストールし、RPCインターフェイスを再生成するには:

```bash
make protos
```

## ドキュメント

APIドキュメントをローカルで生成して閲覧するには:

```bash
make docs
make serve-docs
```

別のターミナルで以下を実行し、ドキュメントをプレビューします:

```bash
open http://localhost:8000/documentation/
```

## コントリビュート

Containerizationへの貢献は歓迎されており推奨されています。詳細は[CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md)をご覧ください。

## プロジェクトの状況

バージョン0.1.0はContainerizationの最初の公式リリースです。以前のバージョンにはソースの安定性保証はありません。

Containerizationライブラリは活発に開発されているため、ソースの安定性はマイナーバージョン間（例：0.1.1から0.1.2）でのみ保証されます。  
ソース破壊的なパッケージ更新を避けたい場合は、パッケージ依存関係を`.upToNextMinorVersion(from: "0.1.0")`で指定できます。

将来的なマイナーバージョンでこれらのルールに変更が加えられる可能性があります。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---