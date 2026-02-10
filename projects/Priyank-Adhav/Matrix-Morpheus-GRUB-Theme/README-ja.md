# Matrix Morpheus GRUB テーマ  
**レッドピル vs ブルーピル**

Linux と Windows 間で切り替わるフルスクリーンの動的背景を特徴とした、ミニマリストのマトリックス風 GRUB テーマ。

---

**注意：**  
現在、このテーマには **Arch Linux** と **Windows** のアイコンのみが含まれています。  
 
また、アイコンは画面上で **横方向に配置** されていますが、  
通常の GRUB メニューと同様に **上矢印キー** と **下矢印キー** でナビゲートします。

---
![Matrix Morpheus GRUB テーマのプレビュー、Arch と Windows の起動アイコンを表示](https://raw.githubusercontent.com/Priyank-Adhav/Matrix-Morpheus-GRUB-Theme/master/preview.gif)
## インストール

1. リポジトリをクローンする

```shell
git clone https://github.com/Priyank-Adhav/Matrix-Morpheus-GRUB-Theme
```
2. フォルダに移動します  


```shell
cd Matrix-Morpheus-GRUB-Theme
```

3. インストーラーを実行可能にする

```shell
chmod +x install.sh
```

4. 管理者としてインストールスクリプトを実行する

```shell
sudo ./install.sh
```

5. 新しいテーマをテストするために再起動します

---
オプション: GRUBメニューを簡素化する

このテーマは2つのエントリのレイアウト用に設計しており、追加のエントリを視覚的にどのように扱うかはあまり考えていません。

現在のGRUBメニューに以下のような追加エントリがある場合：

- 「Arch Linuxの高度なオプション」
- 「UEFIファームウェア設定」

使用しない場合は、grubの設定から余分なメニューエントリを削除することをお勧めします。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-10

---