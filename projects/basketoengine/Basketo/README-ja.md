<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Basketo Game Engine Logo" width="200"/>
</p>

<h2 align="center">創造し、遊び、インスパイアする。ゲームに命を吹き込む。 ✨</h2>

<h1 align="center">Basketo ゲームエンジン</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- Replace your_discord_server_id with your actual server ID -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (formerly Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
Basketo エンジンへようこそ。これは私たちが情熱を注ぎ、最高の努力で素晴らしく高性能なエンジンを作り上げるプロジェクトです。AIネイティブなゲームエンジンを目指すというエキサイティングな計画も進行中です。Unityのようなエディタインターフェース、Gemini AI統合、先進的なマルチサウンドエフェクトシステム、強力なECSアーキテクチャを備えています。貢献したい方も、アイデアを提案したい方も、成長を見守りたい方も、この旅の一員です！🚀
</p>
## 🚀 エンジンの現在の状態
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Basketoエンジンの現在の状態" width="700"/>
</p>

<p align="center">
  <em>最新の開発状況や機能を実際にチェックしてみましょう！</em> 🎮
</p>

## ✨ 主な特徴

### 🎮 **Unity風エディターインターフェース**
- **デュアルウィンドウ構成**：シーンエディターとゲームビューを並列表示
- **ライブ編集**：ゲーム実行中にシーンを編集可能
- **インスペクターパネル**：ドラッグ＆ドロップによるビジュアルコンポーネント編集
- **階層ビュー**：エンティティの整理と管理
- **アセットブラウザー**：テクスチャやオーディオの簡単管理

### 🤖 **AIネイティブ開発**
- **Gemini AI統合**：ゲーム開発のための自然言語コマンド
- **スマートスクリプト生成**：AIによるLuaスクリプト自動作成
- **エンティティ修正**：変更内容を英語で記述可能
- **簡単API設定**：組み込みのGemini APIキー設定
### 🔊 **高度なオーディオシステム**
- **マルチサウンドエフェクト**: エンティティごとに複数の名前付きサウンド（歩行、ジャンプ、攻撃など）
- **従来型オーディオ**: バックグラウンドミュージックと環境音
- **Lua連携**: スクリプトから `PlaySound(entity, "action")` でサウンドをトリガー
- **ビジュアルエディタ**: インスペクターを通じてサウンドエフェクトを管理

### 🎯 **エンティティ・コンポーネント・システム（ECS）**
- **高パフォーマンス**: 多数のエンティティに最適化
- **モジュール設計**: 必要に応じてコンポーネントを組み合わせ可能
- **スクリプト連携**: LuaスクリプトでECS全体にアクセス
- **リアルタイム更新**: コンポーネントのライブ編集

### 🎨 **グラフィックス＆アニメーション**
- **スプライトレンダリング**: 効率的な2Dグラフィックスパイプライン
- **アニメーションシステム**: ループ対応のフレームベースアニメーション
- **トランスフォームシステム**: 位置、回転、スケーリング
- **カメラシステム**: 複数カメラのサポート

### ⚡ **物理演算＆衝突判定**
- **衝突検出**: 空間最適化されたAABB衝突
- **リジッドボディ物理**: 重力、速度、力
- **衝突コールバック**: スクリプトからアクセス可能な衝突イベント
- **空間分割**: パフォーマンス向上のためのクワッドツリー最適化
## 🎬 下の画像をクリックするとビデオデモをご覧いただけます：
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Basketo Engine Demo" width="500"/>
  </a>
</p>

## � クイックスタートガイド

### 1. **Gemini APIキーを取得する**（オプションですが推奨）
- [Google AI Studio](https://aistudio.google.com/app/apikey) にアクセス
- サインインして無料のAPIキーを作成
- これにより自然言語コマンドなどのAI機能が利用可能になります

### 2. **ビルドと実行**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **AI機能の設定**
- エンジン内で、AIプロンプトパネル（下部）に移動します
- 「🤖 Gemini AI Configuration」を探します
- APIキーを入力して「保存」をクリックします

### 4. **作成を始める**
- AIコマンドを試す: `"create a player at 100 200"`
- インスペクターでエンティティに効果音を追加する
- Luaスクリプトを書く、またはAIに生成させる
- ライブ開発のためのデュアルウィンドウエディタを使用する

## �🛠️ エンジンのビルド（Linux）🐧

### 前提条件
- CMake 3.26.0以上が必要です。
- SDL2、SDL2_image、SDL2_ttf、SDL2_mixer
- Lua 5.4
- g++（C++17）
- libcurl（AI機能用）
- nlohmann/json（サブモジュールとして含まれています）
- ImGui（サブモジュールとして含まれています）
### ビルド手順
```bash
# リポジトリをクローン
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### 実行方法
```bash
./BasketoGameEngine

```
物理テストを実行したい場合:
```bash
./PhysicsTest

```

## 🛠️ エンジンのビルド（Windows） 💻

### 必要条件

1. **Visual Studio 2022（Community Edition以上）**  
   以下のワークロードをインストールしてください:
   - C++によるデスクトップ開発
   - Windows用C++ CMakeツール
   - Windows 10または11 SDK

2. **CMake**（Visual Studioに同梱、または https://cmake.org/download/ からダウンロード）

3. **vcpkg**（依存関係のインストールに使用）

### 依存関係のインストール

```bash
# VS 2022用のDeveloper Command PromptまたはPowerShellを開く

# vcpkgをクローン

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# 必要なライブラリをインストール
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### ビルド手順
```bash
# Basketo リポジトリをクローン
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# CMake で構成
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/path/to/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# "C:/path/to/vcpkg" を vcpkg ディレクトリへのフルパスに置き換えてください

# エンジンをビルド
cmake --build . --config Release
```

---

### 実行

```bash
# build/Release ディレクトリから
```
./BasketoGameEngine.exe

# 物理テストの実行方法
./PhysicsTest.exe
```

## 📚 ドキュメント

### コア機能
- **[サウンドエフェクトシステム](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**: 複数サウンドエフェクトの完全ガイド
- **[Gemini API 設定](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**: ステップバイステップのAI設定
- **[Lua スクリプト](assets/Scripts/)**: サンプルスクリプトとAPIリファレンス

### 使用例

#### AIによる開発
```bash
# 自然言語コマンド
"プレイヤーキャラクターを位置 100 200 に作成"
"プレイヤーにジャンプ動作を追加"
"敵をより速く移動させる"

# スクリプト生成
gemini_script プラットフォーマーコントローラーをダブルジャンプ付きで作成
```

#### マルチサウンドエフェクト
```lua
-- Luaスクリプト内で
PlaySound(entity, "jump")    -- ジャンプ音を再生
PlaySound(entity, "walk")    -- 歩行音を再生
PlaySound(entity, "attack")  -- 攻撃音を再生

-- サウンドが存在するかチェック
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### コンポーネントシステム
- **Transform**: 位置、回転、スケール
- **Sprite**: テクスチャレンダリング
- **Animation**: フレームベースのアニメーション
- **Script**: Lua動作スクリプト
- **Collider**: 物理衝突
- **Rigidbody**: 物理シミュレーション
- **Audio**: バックグラウンドミュージック
- **SoundEffects**: 複数の名前付きサウンド
- **Camera**: ビュー管理
## 🤝 参加しよう

私たちはコミュニティからの貢献を大歓迎しています ❤️。貢献方法や開発用にプロジェクトを実行する詳細については、[貢献ガイドライン](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md) をご覧ください。 <!-- このファイルがあることを想定しています -->

- 🐛 バグを発見しましたか？ イシューを作成してください！
- ✨ すごい機能のアイデアがありますか？ ぜひ聞かせてください！
- 💻 貢献したいですか？ フォークして、コードを書いて、プルリクエストを作成しましょう！

このエンジンを一緒に作り上げ、ゲーム開発を誰にとっても楽しく簡単なものにしましょう。🌍

## 👥 コミュニティ
大きなハグで歓迎します 🤗。コードの改善 📝、ドキュメントの更新 📚、イシュー報告 🐞、機能リクエスト 💡、Discordでのディスカッション 🗣️ など、あらゆる形のコミュニティからの貢献をとても楽しみにしています。

こちらからコミュニティに参加してください：

- 👋 [Discordコミュニティに参加する](https://discord.gg/F3DswRMW)
- ⭐ [GitHubでスターをつける](https://github.com/basketoengine/Basketo)

## 🙏 サポートのお願い:
私たちは常に改善を続けており、今後さらに多くの機能やサンプルが追加される予定です 🌟。このプロジェクトを気に入っていただけた場合は、GitHubリポジトリ [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo) でスター ⭐ を付けていただけると嬉しいです。フォローして、成長を応援してください。🌱

---

ハッピーコーディング＆ゲーム制作！🎉🎮


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---