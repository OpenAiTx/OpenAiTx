
# 概要

[Ultracopier](https://ultracopier.herman-brule.com/) は、GPLv3 ライセンスの下で提供される
無料でオープンソースのソフトウェアで、ファイルコピーのダイアログの代替として機能します。

主な機能は以下の通りです：
- タスクキュー
- 一時停止 / 再開
- 未完了ジョブの再開
- 動的速度制限
- 衝突管理
- プラグインサポート

# 依存関係
- make
- gcc
- C++17 コンパイラ（Qt6.7 のため）

例えば、Debian ベースのディストリビューションでは： 



```bash
sudo apt install make gcc build-essential libssl-dev qtbase6-dev qtchooser qt6-qmake qtbase6-dev-tools qttools6-dev-tools
```
# ビルド

オールインワンバージョンのビルドは、メインのQtプロジェクトをコンパイルするだけで簡単です：


```bash
find ./ -name '*.ts' -exec lrelease {} \;
qmake ultracopier.pro
make -j$(nproc)
```

# Run

```bash
./ultracopier
```
# 翻訳

翻訳は[Qt Linguist](http://doc.qt.io/qt-6/qtlinguist-index.html)を通じて提供されています。

1. `lupdate ultracopier.pro`を実行して翻訳ファイルを更新します
2. 翻訳を`(plugins|resources)/Languages/XX/translation.ts`に入れます
3. `lrelease ultracopier.pro`を実行してファイルをコンパイルします
4. Ultracopierリリース内の`.qm`ファイルを置き換えます


# プラグイン

[プラグイン](https://raw.githubusercontent.com/alphaonex86/Ultracopier/master/plugins/README.md)の形でのカスタマイズも可能です。


# 貢献
このプロジェクトは[Github](https://github.com/alphaonex86/Ultracopier)でホストされています。
そこでイシューやマージリクエストを追加してください！




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---