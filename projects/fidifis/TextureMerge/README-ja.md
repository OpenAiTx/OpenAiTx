# TextureMerge

[![GitHub latest release version](https://img.shields.io/github/v/release/Fidifis/TextureMerge.svg?style=flat)](https://github.com/Fidifis/TextureMerge/releases/latest)
[![Github All Releases download count](https://img.shields.io/github/downloads/Fidifis/TextureMerge/total.svg?style=flat)](https://github.com/Fidifis/TextureMerge/releases/latest)

[![Main](https://github.com/Fidifis/TextureMerge/actions/workflows/main.yml/badge.svg)](https://github.com/Fidifis/TextureMerge/actions/workflows/main.yml)
[![CodeQL](https://github.com/Fidifis/TextureMerge/actions/workflows/codeql.yml/badge.svg)](https://github.com/Fidifis/TextureMerge/actions/workflows/codeql.yml)

## テクスチャを画像チャンネルに統合またはパックし、最大4つのテクスチャを持つ1つの画像を生成するソフトウェア。

このプログラムは、個別のグレースケールテクスチャを1つの画像にパックしたい場合に最適です。

![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img1.jpg)

## 必要条件
このプログラムを実行するには [.NET Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48) が必要です（ほとんどのWindowsコンピューターに標準でインストールされています）

## 使い方
1. [リリース](https://github.com/Fidifis/TextureMerge/releases) からソフトウェアをダウンロードしてください。\
*セットアップでインストールするか、zipフォルダーを解凍してください。*
2. TextureMerge.exe を開きます
3. テクスチャを挿入したいカラーチャンネルの下にある「ロード」をクリックします。\
**ファイルをスロットに*ドラッグ＆ドロップ*することもできます。**

![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img2.jpg)

4. Windowsのダイアログが表示されます。テクスチャを選択し、「開く」をクリックします。

![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img3.jpg)

5. 他のテクスチャについても同様に繰り返します。空のチャンネルは黒になりますが、白に変更することも可能です（画像が提供されなければアルファチャンネルは追加されません）。
6. 完了したら「Merge」をクリックします。

![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img4.jpg)

7. Windowsのダイアログが表示されます。ファイル名を入力し、「保存」をクリックします。

![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img5.jpg)


## テクスチャがパックされました

![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img6.jpg)


## Unreal Engineでの使用例
![image](https://github.com/Fidifis/TextureMerge/raw/master/Tutorial-images/img7.jpg)

## 質問
ご質問やご提案、何か動作しないことがあれば、[issue](https://github.com/Fidifis/TextureMerge/issues)を作成してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-28

---