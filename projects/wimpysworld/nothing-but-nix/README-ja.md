
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**GitHub Actions ランナーを [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ のパワーハウスへ変貌させ、プリインストールされた不要なソフトウェアを徹底的に排除します。**

GitHub Actions ランナーは Nix 用のディスク容量がわずか約20GBしかありません。
*Nothing but Nix* は不要なソフトウェアを **徹底的に削除** し、Nix ストア用に **65GBから130GB** を確保します！ 💪

## 使用方法 🔧

このアクションをワークフロー内でNixをインストールする**前に**追加してください:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### 要件 ️✔️

- 公式の**Ubuntu** GitHub Actionsランナーのみサポート
- Nixがインストールされる**前**に実行する必要があります
- **macOS/Darwinランナー**：macOSで実行された場合、このアクションは警告とともにスキップします。macOSランナーはすでにNixに十分なスペースを提供しており、このアクションは不要です
- **Windowsランナー**：Windowsで実行された場合、このアクションは警告とともにスキップします。Windowsランナーは異なるファイルシステム構造と制約があります

## 問題: Nixが繁栄するためのスペース作り 🌱

標準のGitHub Actionsランナーには、Nixワークフローで使わない*"不要ソフトウェア"*が詰め込まれています：

- 🌍 ウェブブラウザ。たくさん。全部揃えなきゃ！
- 🐳 Dockerイメージが貴重なディスク容量を何GBも消費
- 💻 不要な言語ランタイム（.NET、Ruby、PHP、Java...）
- 📦 パッケージマネージャーがデジタル塵を集める
- 📚 誰も読まないドキュメント

この不要物のせいでNixストアには~20GBしか残りません—本格的なNixビルドには全然足りません！😞

## 解決策: Nixだけ ️❄️

**Nixだけ**はGitHub Actionsランナーに徹底的なアプローチを取り、2段階攻撃でディスクスペースを容赦なく取り戻します：

1. **初期スラッシュ:** `/mnt`の空きスペースを確保し、大きな`/nix`ボリューム（約65GB）を即座に作成
2. **バックグラウンド猛攻:** ワークフローが進行する間に不要ソフトウェアを容赦なく削除し、`/nix`ボリュームを最大約130GBまで拡張
   - ウェブブラウザ？ダメ ⛔
   - Dockerイメージ？消去 🗑️
   - 言語ランタイム？完全消滅 💥
   - パッケージマネージャー？殲滅 💣
   - ドキュメント？蒸発 ️👻

ファイルシステムの浄化は`rmz`（[Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)プロジェクト）の力によるもの—`rm`の高性能代替で高速なスペース回収を実現！⚡
   - 標準の`rm`より一桁速いパフォーマンス
   - 削除処理を並列化し最大効率化
   - **ディスクスペースを分単位ではなく秒単位で回収！** ️⏱️

最終結果は？Nix対応スペースが**65GBから130GB**のGitHub Actionsランナー！😁

### ダイナミックなボリューム拡張
他のソリューションとは異なり、**Nothing but Nix** は `/nix` ボリュームを動的に拡張します：

1. **初期ボリューム作成（1-10秒）：**（*Hatchet Protocol に依存*）
   - `/mnt` の空き領域からループデバイスを作成
   - RAID0 構成で BTRFS ファイルシステムをセットアップ
   - 圧縮とパフォーマンスチューニングでマウント
   - パージが始まる前でも即座に 65GB の `/nix` を提供

2. **バックグラウンド拡張（30-180秒）：**（*Hatchet Protocol に依存*）
   - パージ操作を実行
   - 膨張が解消されて新たに解放された空き領域を監視
   - `/nix` ボリュームに拡張ディスクを動的に追加
   - 新しい空き領域を取り込むためファイルシステムをリバランス

`/nix` ボリュームはワークフロー実行中に自動で**成長します** 🎩🪄

### 武器を選べ：Hatchet Protocol 🪓

`hatchet-protocol` 入力で破壊レベル💥をコントロール：


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```
#### プロトコル比較 ⚖️

| プロトコル | `/nix` | 説明                                             | aptの削除   | dockerの削除 | snapの削除 | 削除されるファイルシステム  |
|------------|--------|--------------------------------------------------|------------|--------------|------------|-----------------------------|
| Holster    | 約65GB | 斧を鞘に収め、`/mnt` のスペースを使用               | いいえ     | いいえ       | いいえ     | なし                        |
| Carve      | 約85GB | `/` と `/mnt` の空きスペースを作成・結合            | いいえ     | いいえ       | いいえ     | なし                        |
| Cleave     | 約115GB| 大きなパッケージに強力で決定的な切断を行う          | 最小限     | はい         | はい       | `/opt` と `/usr/local`      |
| Rampage    | 約130GB| 容赦ない、徹底的な無駄の排除                        | 積極的     | はい         | はい       | ムハハハ！ 🔥🌎              |

賢く選択してください：
- **Holster** はランナーのツールを完全に機能させたい場合
- **Carve** は機能的なランナーツールを維持しつつ、Nixのために全ての空きスペースを確保したい場合
- **Cleave** （*デフォルト*）はスペースと機能のバランスが良い場合
- **Rampage** は最大のNixスペースが必要で、何が壊れても気にしない場合 `#nix-is-life`

### 大虐殺の目撃者 🩸

デフォルトでは、削除プロセスはバックグラウンドで静かに実行され、ワークフローは継続されます。ですが、リアルタイムで虐殺を見たい場合は：


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```
### セーフヘイブンのカスタマイズ 🛡️

カスタムセーフヘイブンのサイズでNixストアの土地取得からどれだけのスペースを確保するかを制御します：


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```


これらのセーフヘイブンは、スペース回収時にどれだけの容量（MB単位）が慈悲深く確保されるかを定義します：
- デフォルトの `root-safe-haven` は2048MB（2GB）
- デフォルトの `mnt-safe-haven` は1024MB（1GB）

ファイルシステムにもっと余裕が必要な場合はこれらの値を増やし、容赦なくスペースを確保したい場合は減らしてください！😈

### /nixのユーザー所有権を付与する（Nixパーミッション布告）🧑‍⚖️

一部のNixインストーラーや設定では、`/nix` ディレクトリが現在のユーザーによって書き込み可能であることを想定しています。デフォルトでは `/nix` はroot所有です。ユーザー所有権が必要な場合（例：`/nix` 内で全操作に `sudo` を使わない特定のNixインストーラースクリプトなど）、`nix-permission-edict` を有効にできます：


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```

`nix-permission-edict` が `true` に設定されている場合、アクションは `/nix` をマウントした後に `sudo chown -R "$(id --user)":"$(id --group)" /nix` を実行します。

### Nix を /nix/build を使うように設定する

このアクションは Nix 派生ビルドが再利用されたスペースを利用できるように `/nix/build` を作成します。Nix 設定に `build-dir` を追加してください:

```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

または DeterminateSystems を使用して:

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```
これは、Nixがシステムのデフォルト一時ディレクトリではなく、大容量のBTRFSボリューム上でビルドを実行するよう指示します。

## トラブルシューティング 🔍

### 大規模ビルド時の「デバイスに空き容量がありません」

ビルドが空き容量不足で失敗する場合、Nothing but Nixを使用していても、バックグラウンドでのパージ処理がビルド開始前に完了していないことが原因である可能性が高いです。これは以下の場合によく発生します：

- 大容量ディスクイメージを組み立てるNixOSのVMテスト
- キャッシュされていない多くの依存関係を持つビルド
- Rustツールチェーンやその他の大規模コンパイル

**解決策:** `witness-carnage: true` を使用して同期パージを強制してください。これにより、ビルド開始*前*にすべての空き容量が確保されます。


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```
これにより、ワークフローのセットアップに30～180秒追加されますが、ビルド開始時に最大限のスペースが確保されることが保証されます。

さあ、その素晴らしいNixストアスペースを使って素晴らしいものを作りましょう！ ❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---