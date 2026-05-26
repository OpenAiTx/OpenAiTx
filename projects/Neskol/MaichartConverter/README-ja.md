# MaichartConverter

## SimaiとMa2間でmaimaiチャートを変換する機能を提供するシンプルなプログラムです。

> 元のサポートクラスは現在このリポジトリから分離されています。詳細は
> [MaiLib](https://github.com/Neskol/MaiLib)をご覧ください。

### ビルド

    git clone
    git submodule update --init --recursive
    dotnet build

### 使用法と利用可能なコマンド

> 各コマンドの詳細マニュアルは 'MaichartConverter help' と入力してください。

- `CompileDatabase`([英語](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileDatabase.md)/[中国語](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileDatabase_CN.md)): Ma2の全データベースをsimaiへ
  コンパイルします
- `CompileMa2`([英語](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileMa2.md)/[中国語](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileMa2_CN.md)): 指定されたMa2の
  チャートを指定フォーマットにコンパイルします
- `CompileMa2ID`([英語](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileMa2ID.md)/[中国語](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileMa2ID_CN.md)): IDで指定された
  Ma2チャートを指定フォーマットにコンパイルします
- `CompileSimai`([英語](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileSimai.md)/[中国語](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileSimai_CN.md)): 指定された
  simaiチャートを指定フォーマットにコンパイルします
-
`ReverseMa2FromSimaiDatabase`([英語](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/ReverseMa2FromSimaiDatabase.md)/[中国語](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/ReverseMa2FromSimaiDatabase_CN.md)):
指定フォルダのSimaiデータベースをMaiAnalysisフォルダへ逆変換してコンパイル用にします

### パラメータ注意事項

- 音楽ファイルはmusicxxxxxx.mp3と命名してください。xxxxxxは各a000フォルダ内のmusic.xmlで指定されている音楽IDに
  対応し、6桁になるよう先頭に0を補います
- bgaファイルはxxxxxx.mp4と命名してください。xxxxxxは各a000フォルダ内のmusic.xmlで指定されている音楽IDに対応し、
  6桁になるよう先頭に0を補います
- 画像フォルダはimage/Texture2D/の構造とし、ファイル名はUI_Jacket_xxxxxx.jpgで始まるようにしてください。xxxxxxは
  各a000フォルダ内のmusic.xmlで指定されている音楽IDに対応し、6桁になるよう先頭に0を補います
- 上記すべてのルールは、適切な方法でデータを取得した後に直接使用しやすくするための便宜上のものです
- 難易度パラメータは0-4でBasicからRe:Masterまでを表します。MaiLibではEasyとUtageのルールも指定していますが、これは

  理解するのに時間がかかりますが、MaiLibのコードを参照してご自身で実装することもできます。
- すべてのパスは「/」または「\」のようなパス区切り文字で終わる必要があります。パス内に引用符を含めることはできません。
- コマンドの使い方に困った場合は、いくつかの例を含めたVSCodeのlaunch.jsonを参照してください。
- 元々このプログラムはma2からsimaiへの変換を目的として計画されており、その他の機能はその後に開発されたため、
  コード設計には大量の妥協があり読みづらくなっています（しかし現状は動作します）。もし修正を手伝っていただけると
  とてもありがたいです。

### 免責事項

- 作品の著作権は各権利者に帰属します。このツールは純粋に非商用かつ学習目的で使用されています。
  使用されるリソースについては各自で調査し、自己責任で適切にご利用ください。
- パーサーをプロジェクトで使用したい場合は、[MaiLib](https://github.com/Neskol/MaiLib)を参照してください。
  それがお役に立てば幸いです！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---