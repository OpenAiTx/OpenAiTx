# Xenity Engine

Xenity Engineは、PlayStation Portable、PsVita、PS3およびWindows向けのGameObjectsとComponentsに基づくクロスプラットフォームゲームエンジンです。

[Xenityスクリプトドキュメント](https://fewnity.github.io/Xenity-Engine/script_api_reference/scripting_api_reference.html)

新しいエンジンの開発を計画しており、このエンジンの大きな問題のほとんどを修正する予定です。<br>
したがって、このエンジンに新機能を追加することはおそらくありません。<br>
しかし、プルリクエストは依然として歓迎します。新機能、リファクタリング、バグ修正、最適化、またはドキュメントの改善など、すべて歓迎です！
エンジンを改善したい場合は、こちらが[TODOリスト](https://github.com/Fewnity/Xenity-Engine/blob/crossplatform/TODO.md)です。

![image](https://github.com/Fewnity/Xenity-Engine/assets/39272935/df59e12e-b989-4b0d-93b1-4f95fac7c91f)

![gif](https://github.com/user-attachments/assets/7568e868-e41c-4495-bde7-56bb7b6bc54d)

[ゲームサンプル](https://fewnity.github.io/Xenity-Engine/game_project_samples/game_project_samples.html)はダウンロード可能です！

### 対応プラットフォーム:<br>
✔️ 対応済み<br>
🚧 作業中<br>

| 状態 | プラットフォーム |
|-|-|
✔️ | Windows
✔️ | PlayStation Portable
✔️ | PlayStation Vita
✔️ | PlayStation 3
🚧 | Linux (UIにやや不具合あり、オーディオとビルドシステムが欠落)

機能:

- [X] 基本的な2D
- [X] 基本的な3D
- [X] 2Dオーディオ
- [ ] 3Dオーディオ
- [X] スカイボックス
- [X] シーン
- [ ] アニメーション
- [X] 3D物理演算
- [ ] 2D物理演算
- [X] C++ ホットリロード

> [!WARNING]
> エンジンは完璧ではありません。そのため、ゲーム開発中に以下のような問題が発生する可能性があります：
> - メタファイルを削除するとプロジェクトに影響があります。ファイルを参照している変数は空になります。
> - メタファイルを複製すると問題が発生します。各メタファイルには固有のファイルIDが含まれています。
> - オーディオは44100Hzで「正常」に動作しますが、PS3では48000Hzのオーディオを使用する必要があります。

> [!NOTE]
> エディター内でゲームをコンパイルする場合は、「エンジン設定」メニュー（Window->Engine Settings）で `Compiler path` を設定する必要があります。<br>
> `Compiler path` のデフォルトは `C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build` ですが、Visual Studioのインストール先やバージョンが異なる場合は変更してください。<br>
> PSPビルド用のビルド＆実行には `PPSSPP location` を設定できます。

## エディターの使い方
### エディターでゲームをプレイする方法
- 「Game->Compile Game」でゲームをコンパイルする
- 再生ボタンをクリックする
### ゲームをビルドする方法
- 「File->Build Settings」でビルド設定メニューを開く
- プラットフォームを選択する
- ビルドボタンをクリックする
（PSP、PS3、PsVitaの場合はDocker Desktopをインストールして設定する必要があります）。

## Dockerのセットアップ
PSP、PS3、PsVitaのゲームをコンパイルするにはDocker Desktopが必要です。<br>
Docker Desktopをダウンロード：https://www.docker.com/products/docker-desktop/

その後、XenityでDockerインストールを完了させます。「Window->Docker Configuration」に移動してください。特に遅いパソコンや遅いインターネット接続の場合、処理には数分かかることがあります。（エディターがフリーズします）。

## 対応ファイル
画像：`.png .jpg .bmp .tga`

オーディオ：`.wav .mp3`（PS3以外は44100Hzのオーディオを使用してください。PS3では48000Hzのオーディオが必要です）

メッシュ：`.obj .fbx`

フォント：`.ttf`

## Visual Studioでエンジンをコンパイルする方法
- プロジェクト `Xenity_Engine_Executable` をスタートアッププロジェクトに設定する。
- `Engine`の設定をコンパイルし、次に`Editor`をコンパイルしてすべてのdllファイルを生成します。

## エンジンの内部動作

プロジェクトやゲームが読み込まれると、エンジンは存在するすべてのファイルのリストを作成します。各ファイルには一意のIDがあります。  
`Texture`、`Audio Clip`、`Mesh Data`などの元々ファイルであるクラスは、`File Reference`を継承してファイルへのポインタを持ちます。

`Component`、`GameObject`、`Vector3`などのクラスは`Reflective`を継承しています。これにより基底クラスを知らなくても変数にアクセスできます。これはInspectorでデータを表示・変更したり、ファイルにデータを保存・読み込みするために使われます。

## お問い合わせ
サポートが必要な場合はIssueを開くか、私に連絡してください。

メール: `fewnity@gmail.com`<br>
Discord: `fewnity`

## ライセンス

このリポジトリのコードはMITライセンスの下にあります。

## ゲームコンソールSDK

https://github.com/Fewnity/Xenity-Engine-SDK

## 使用ライブラリ
Stb (使用: stb_image 2.23（後のバージョンはPSPで動作しません）、stb_image_resize 0.97、stb_image_write 1.16): https://github.com/nothings/stb

drmp3 v0.6.40 & drwav v0.13.17: https://github.com/mackron/dr_libs

JSON for Modern C++ v3.11.3: https://github.com/nlohmann/json

GLM（PS2向けに若干修正）: https://github.com/g-truc/glm

Bullet 2.82（コンパイル修正のため若干修正）: https://code.google.com/archive/p/bullet/downloads

### Windows専用:
Assimp (79d451b): https://github.com/assimp/assimp/
<br>`cmake CMakeLists.txt -DASSIMP_BUILD_ZLIB=ON -DASSIMP_NO_EXPORT=ON -DASSIMP_BUILD_ALL_EXPORTERS_BY_DEFAULT=OFF -DASSIMP_BUILD_TESTS=OFF -DASSIMP_BUILD_ASSIMP_VIEW=OFF -DASSIMP_INJECT_DEBUG_POSTFIX=OFF -DASSIMP_INSTALL=OFF -DASSIMP_BUILD_ALL_IMPORTERS_BY_DEFAULT=OFF -DASSIMP_BUILD_OBJ_IMPORTER=ON -DASSIMP_BUILD_FBX_IMPORTER=ON -DCMAKE_BUILD_TYPE=Release`
`cmake --build . --config Release`

FreeType (v2.13.2): https://github.com/ubawurinna/freetype-windows-binaries/

ImGui ドッキングブランチ (1.91.8 WIP): https://github.com/ocornut/imgui

SDL (3.2): https://github.com/libsdl-org/SDL

Glad v2.0.8 (gl 4.6 互換モード): https://gen.glad.sh/

### PsVita 特有: 
VitaGL (029ddbe): (HAVE_GLSL_SUPPORT=1 フラグを有効にしてコンパイル、リリース用に NO_DEBUG=1、デバッグ用に HAVE_SHARK_LOG=1 LOG_ERRORS=2) https://github.com/Rinnegatamante/vitaGL


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-03

---