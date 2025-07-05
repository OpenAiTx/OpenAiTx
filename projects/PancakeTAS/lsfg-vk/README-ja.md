# lsfg-vk
このプロジェクトは [Lossless Scalingのフレーム生成](https://store.steampowered.com/app/993090/Lossless_Scaling/) をLinuxに導入します！
>[!NOTE]
> これは進行中の作業です。フレーム生成はいくつかのゲームで動作していますが、まだ長い道のりがあります。サポートについてはWikiを確認してください（Wikiはまだ作成されていません）

## ビルド、インストール、実行

>[!CAUTION]
> ビルド手順が最近変更されました。必ず確認してください。

LSFGをコンパイルするためには、以下のコンポーネントがシステムにインストールされていることを確認してください:
- 従来のビルドツール（+ sed, git）
- Clangコンパイラ（このプロジェクトはGCCでは簡単にコンパイルできません）
- Vulkanヘッダーファイル
- CMakeビルドシステム
- Mesonビルドシステム（DXVK用）
- Ninjaビルドシステム（CMakeのバックエンド）

lsfg-vkのコンパイルは比較的簡単です。すべてがCMakeにきれいに統合されています:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
これによりlsfg-vkが~/.local/libおよび~/.local/share/vulkanにインストールされます。

次に、SteamからLossless Scalingをダウンロードする必要があります。`legacy_2.13`ブランチに切り替えるか、対応するデポをダウンロードしてください。
ゲームファイルから「Lossless.dll」のパスをコピーするか、メモしておいてください。

最後に、実際にフレーム生成を有効にしてプログラムを起動してみましょう。この例では`vkcube`を使用します:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
パスを必ず調整してください。各パスについて説明します:
- `VK_INSTANCE_LAYERS`: ここに `VK_LAYER_LS_frame_generation` を指定します。これにより任意のVulkanアプリがlsfg-vkレイヤーを読み込みます。
- `LSFG_DLL_PATH`: ここでSteamからダウンロードしたLossless.dllを指定します。lsfg-vkはここからシェーダーを抽出・変換します。
- `LSFG_MULTIPLIER`: お馴染みの倍率です。例えば2を指定するとフレームレートが2倍になります。
- `VK_LAYER_PATH`: `~/.local` または `/usr` 以外にインストールした場合は、ここで `explicit_layer.d` フォルダを指定する必要があります。

>[!WARNING]
> Windowsとは異なり、LSFG_MULTIPLIERはここでは大きく制限されています（現時点では！）。ハードウェアが8枚のスワップチェーンイメージを作成できる場合、LSFG_MULTIPLIERを4に設定するとそのうち4枚が占有され、ゲームには残り4枚しか使えません。ゲームが5枚以上を要求するとクラッシュします。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---