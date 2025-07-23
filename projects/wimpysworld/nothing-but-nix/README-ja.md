
# Nothing but Nix

**GitHub Actionsランナーを[ Nix](https://zero-to-nix.com/concepts/nix/) ❄️のパワーハウスに変身させ、プリインストールされた不要なものを容赦なく削減します。**

GitHub ActionsランナーはNix用のディスク容量がわずか約20GBしかありません。
*Nothing but Nix*は**不要なソフトウェアを徹底的に削除し、Nixストア用に**65GBから130GB**を確保します！💪

## 使用方法 🔧

このアクションをNixをインストールする**前に**ワークフローに追加してください：


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

- 公式の**Ubuntu** GitHub Actionsランナーのみ対応
- Nixがインストールされる**前に**実行する必要あり

## 問題点: Nixが快適に動作する空間を確保する 🌱

標準のGitHub Actionsランナーは、Nixワークフローでは決して使わない*「不要なソフト」*で溢れています：

- 🌍 ウェブブラウザが大量に。全部揃ってます！
- 🐳 ギガバイト単位のディスク容量を消費するDockerイメージ
- 💻 不要な言語ランタイム（.NET、Ruby、PHP、Javaなど）
- 📦 使われないパッケージマネージャー
- 📚 誰も読まないドキュメント

この不要なもののせいで、Nixストアには約20GBしか残らず、本格的なNixビルドにはほとんど足りません！😞

## 解決策: Nixだけの環境 ️❄️

**Nothing but Nix**は、GitHub Actionsランナーに対して徹底的な掃討戦を仕掛け、二段階の攻撃でディスク容量を容赦なく奪い返します：

1. **初期削減:** `/mnt`の空き容量を利用して即座に大容量の`/nix`ボリューム（約65GB）を作成
2. **バックグラウンド掃討:** ワークフローが続行している間に不要なソフトを容赦なく排除し、`/nix`ボリュームを最大約130GBまで拡張
   - ウェブブラウザ？ なし ⛔
   - Dockerイメージ？ 削除済み 🗑️
   - 言語ランタイム？ 完全消滅 💥
   - パッケージマネージャー？ 壊滅 💣
   - ドキュメント？ 蒸発️👻

ファイルシステムの掃除は、[Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)プロジェクトの`rmz`を使用しています。`rm`の高速代替で、容量回収が超高速！⚡
   - 標準の`rm`より桁違いに高速
   - 削除処理を並列化して最大効率化
   - **数分ではなく数秒でディスク容量を回復！**️⏱️

結果は？ GitHub Actionsランナーに**65GBから130GB**のNix対応スペースが確保されます！😁

### 動的なボリューム成長

他の解決策と違い、**Nothing but Nix**は`/nix`ボリュームを動的に拡張します：

1. **初期ボリューム作成（1〜10秒）:**（Hatchet Protocolに依存）
   - `/mnt`の空き容量からループデバイスを作成
   - RAID0構成のBTRFSファイルシステムをセットアップ
   - 圧縮とパフォーマンス調整をしてマウント
   - 掃除開始前でも即座に65GBの`/nix`を提供

2. **バックグラウンド拡張（30〜180秒）:**（Hatchet Protocolに依存）
   - 掃除処理を実行
   - 不要物が削除されて空き容量が増えるのを監視
   - `/nix`ボリュームに拡張用ディスクを動的に追加
   - 新容量を取り込むためにファイルシステムを再調整

`/nix`ボリュームはワークフロー実行中に**自動的に拡大**します 🎩🪄

### 武器を選べ: Hatchet Protocol 🪓

`hatchet-protocol`入力で破壊レベルを制御できます 💥:


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

さあ、その素晴らしい Nix ストアのスペースを使って何か素敵なものを作りましょう！ ❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---