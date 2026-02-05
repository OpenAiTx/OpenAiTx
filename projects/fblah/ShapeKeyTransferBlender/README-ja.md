## Blender用シェイプキー ツール
<!-- BADGES/ -->
<span class="badge-blenderartists"><a href="https://blenderartists.org/t/free-shape-key-transfer-addon" title="Blender Artistsフォーラム投稿へのリンク"><img src="https://img.shields.io/badge/Blender-Artists-orange.svg?logo=blender&longCache=true&style=popout-square" alt="Blender Artistsフォーラム投稿" /></a></span>
<span class="badge-discord"><a href="https://discord.gg/CmgdEvw" title="Discordに参加"><img src="https://img.shields.io/badge/Discord-Join-768ADC.svg?logo=discord&longCache=true&style=popout-square" alt="Discordサーバーボタン" /></a></span>
<span class="badge-youtube"><a href="https://www.youtube.com/watch?v=-zBlaedkkVs" title="Youtubeでチュートリアルを見る"><img src="https://img.shields.io/badge/Tutorial-Video-F40000.svg?logo=youtube&longCache=true&style=popout-square" alt="Youtubeチュートリアル" /></a></span>

Blender 2.93用シェイプキー転送

このアドオンを使うと、異なるトポロジーのメッシュ間でシェイプキーを簡単に転送できます。

両方のメッシュを原点に配置し、転送先メッシュが転送元メッシュのシェイプキーをコピーしたい位置で重ねます。

このアドオンは元々ManuelBastioniLabキャラクターから他のメッシュにシェイプキーをコピーするために作成されましたが、あらゆる状況で使用できます。

このアドオンは私が作成したこの[StackoverFlow投稿](https://blender.stackexchange.com/questions/119836/scripting-transferring-shape-keys-between-different-meshes/119867#119867)のコードに基づいています。

アドオンは「ツール」 -> 「シェイプキー ツール」の下にあります。

シェイプキーの除外も可能です。

「Increment Radius」を使うと、転送元メッシュから転送先メッシュに影響を与える頂点数を増やせます。

「Use Closest Vertex」がオフの場合、Increment Radius内のすべての近隣頂点の位置を平均化します。

#### 転送元メッシュの頂点数が少ないほど処理は高速になります。

##

### 特徴：

- 異なるトポロジーのメッシュ間でシェイプキーを転送

- 除外リストを追加して転送するシェイプキーを管理

- メッシュのすべてのシェイプキー名をクリップボードにコピー

### 使用例：

- 顔のシェイプキーを口ひげや眉毛のヘアカードにコピーする。

- ベースメッシュからLODへシェイプキーをコピーします。

##

### 注意：
場合によっては、ソースメッシュを複製し、目的のメッシュに影響を与えないと思われる頂点を削除することが有効です。

例えば、口ひげと顔の場合：顔を複製し、口ひげに影響を与える可能性が高い唇周辺の頂点以外をすべて削除し、その結果得られたメッシュをソースとしてシェイプキーを目的の口ひげヘアカードやメッシュにコピーします。

必要に応じて、このアドオンにさらに機能を追加する予定です。このツールを使えば、メッシュ内のすべてのシェイプキーを簡単に削除することもできます。

##

### ライセンス：

Blender用シェイプキー転送アドオン - 著作権 (C) 2018 Ajit Christopher D'Monte

すべてのPythonファイルはGNU General Public License 3の下でリリースされています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-05

---