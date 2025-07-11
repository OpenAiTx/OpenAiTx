# eBAF - eBPF ベースの広告ファイアウォール
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - eBPF Ad Firewall Banner" width="600"/>
</p>

## 「広告をダウンロードしませんよね」
### でも、ブロックはしますよね！

Spotifyはシンプルな方程式で帝国を築きました：あなたの注意を収益化し、アーティストには適正な報酬を支払わず、あなた自身の時間をプレミアム機能として売り戻すのです。
彼らの世界では、あなたのリスニング体験はあなたのものではありません。そこは巧妙に作られたマーケットプレイス ― あなたの耳は商品、あなたの忍耐は通貨です。

彼らはそれを「無料」プランと呼びます。
でも正直に言いましょう：あなたが時間で支払っているなら、それは無料ではありません。

その一方で、あなたが愛するアーティスト ― プラットフォームを支える人々 ― は、1再生あたりほんのわずかな報酬しか受け取れないことも多いのです。Spotifyは多額の利益を得て、広告主は露出を手に入れ、そしてクリエイターたちは？　わずかな分け前しかもらえません。

これは、ただ迷惑な広告を数本スキップするという話ではありません。
これは、搾取・気を散らすこと・そしてあなたの注意を商品化する仕組みに加担することを拒否するということなのです。

#### これは何ですか？
デジタル抵抗の洗練された小さな行為：Spotify用のクリーンでオープンソースな広告ブロッカー。ノイズを――文字通り――止める。

怪しい改造版も、クラックされたクライアントも、自由を装うマルウェアもなし。ただひとつの目的：広告に人質にされることなく音楽を楽しむこと。

Spotifyは無料ではない――あなたは忍耐で支払っている。

彼らは同じ耳障りな広告を何度も何度も浴びせ、ついにはあなたがあきらめてサブスクするまで続ける。それはPremiumが好きだからではない。ただ、消耗させられたからだ。それはフリーミアムではない――プレイリストを使った心理戦争だ。

その間、アーティストは？相変わらず十分な報酬を受け取れていない。
広告は？さらに大きく、さらに頻繁に。時には文字通り音量も大きく。
あなたは？ただいい雰囲気を楽しみたいだけ。

彼らはあなたの忍耐とクリエイターへの低賃金から利益を得ながら、それが唯一持続可能な方法だと装っている。ネタバレ：そうではない。彼らには選択肢があった――だが人々よりも利益率を選んだのだ。

Spotifyはこれがアクセスの対価だと信じさせたい。
私たちは、それが嘘だと信じている。

私たちは海賊ではない。犯罪者でもない。ただ、ここで線を引いてもいいと考える人々だ。

このプロジェクトは、いくつかの広告をスキップするためのものではない。あなたの沈黙が売り物になり、あなたの体験が中断され、あなたの価値が財布を開けたときにだけ始まる、そんなシステムを拒否するためのものだ。

広告をブロックすることは窃盗ではない。<br>
あなたの時間を奪うことこそが窃盗だ。<br>
私たちは海賊行為をしたいのではない。私たちは「ノー」と言いたいだけだ。<br>
<br>
**あなたは広告をダウンロードしない。でも、ブロックはするだろう。**
## eBAFはどのように機能しますか？

eBAF（eBPF Ad Firewall）は、eBPF（拡張バークレイパケットフィルタ）の力を活用し、不要な広告をカーネルレベルでブロックします。以下は、その機能のハイレベルな概要です。

## eBAFはどのように機能しますか？

eBAF（eBPF Ad Firewall）は、eBPF（拡張バークレイパケットフィルタ）を活用して、カーネルレベルで効率的に広告をブロックします。以下は、その簡単な概要です。

1. **パケットフィルタリング**:
   - 着信ネットワークパケットを検査し、XDP（eXpress Data Path）を使用して、ブラックリストに登録されたIPアドレスに一致するものをブロックします。

2. **動的アップデート**:
   - ドメイン名をIPアドレスに解決し、ブラックリストを動的に更新して、変化する広告サーバーに対して効果を維持します。

3. **Webダッシュボード**:
   - ユーザーフレンドリーなインターフェースを通じて、リアルタイム統計と監視を提供します。

4. **高パフォーマンス**:
   - ネットワークインターフェースレベルで直接動作し、カーネルのネットワークスタックをバイパスすることで、高速な処理と最小限のリソース使用を実現します。

eBAFは、効率性、透明性、使いやすさを兼ね備えた強力な広告ブロックソリューションを提供します。
## シンプルインストール（推奨）

git と curl がインストールされていることを確認してください
```bash
git --version
curl --version
```
### インストール

#### Spotify連携を有効にする（推奨）
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### 明示的に無効にする
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash
```

### アンインストール
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## 開発用インストール
必要な依存関係をインストールするには、以下のコマンドを実行してください:
### Ubuntu/Debian
```bash
sudo apt-get update
sudo apt-get install libbpf-dev clang llvm libelf-dev zlib1g-dev gcc make python3

sudo apt update
sudo apt install net-tools
```

### Fedora/CentOS/RHEL 8+
```bash
sudo dnf update
sudo dnf install -y libbpf-devel clang llvm elfutils-libelf-devel zlib-devel gcc make python3 net-tools bc
```

### Arch
```bash
sudo pacman -Syu
sudo pacman -S --needed libbpf clang llvm libelf zlib gcc make python net-tools bc
```

### eBPFコード実行時の asm/types.h エラーの修正
現在のリンクを確認
`ls -l /usr/include/asm`
正しいリンクを探す
`find /usr/include -name "types.h" | grep asm`
シンボリックリンクを修正
```bash
sudo rm /usr/include/asm
sudo ln -s <current_link> /usr/include/asm
```

### プロジェクトのビルド

eBPF Adblocker をビルドするには、以下の手順に従ってください:

1. リポジトリをクローンします:
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. プロジェクトをビルドする:
   ```bash
   make
   ```

3. （オプション）システム全体にインストールする:
   ```bash
   sudo make install
   ```

4. その他のインストールオプション（ヘルプデスク）
    ```bash
    make help
    ````
5. アンインストール
    ```bash
    make uninstall
    ````
## 使用方法

### 広告ブロッカーの実行
    デフォルトのブラックリストとして spotify-stable.txt を使用します。
    使用法: ebaf [OPTIONS] [INTERFACE...]
    オプション:
    -a, --all               すべてのアクティブなインターフェースで実行
    -d, --default           デフォルトインターフェース（インターネット接続あり）のみで実行
    -i, --interface IFACE   使用するインターフェースを指定
    -D, --dash              Webダッシュボードを開始 (http://localhost:8080)
    -q, --quiet             出力を抑制（静音モード）
    -h, --help              このヘルプメッセージを表示


### ブラックリストの設定
リストを編集してドメインを追加または削除します。各ドメインは別々の行に記載してください。コメントは `#` で始まります。

## 謝辞

特別な感謝を ❤️ <br>
1. [Isaaker's Spotify-AdsList](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [AnanthVivekanand's spotify-adblock](https://github.com/AnanthVivekanand/spotify-adblock)

Spotifyのブロックリストを提供してくださったことに
## ⭐️ プロジェクトをサポートする

eBAF が役立つと感じた場合は、ぜひ GitHub のリポジトリにスターを付けてください！皆様のサポートが可視性の向上や今後の開発の励みになります。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---