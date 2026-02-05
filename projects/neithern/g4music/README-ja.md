<img align="left" alt="Project logo" src="https://raw.githubusercontent.com/neithern/g4music/master/data/icons/hicolor/scalable/apps/app.svg" />

# Gapless
エレガントに音楽を再生しましょう。

<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/window.png" width="1134"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/albums.png" width="1134"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/playing.png" width="462"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/playlist.png" width="466"/>

Gapless（別名：G4Music）はGTK4で書かれた軽量な音楽プレーヤーで、大規模な音楽コレクションに焦点を当てています。

## 特徴
- ほとんどの音楽ファイル形式、Sambaおよびその他のリモートプロトコル（GIOとGStreamerに依存）をサポート。
- 数千の音楽ファイルを数秒で高速に読み込み・解析し、ローカルの変更を監視。
- アルバムカバー（埋め込みおよび外部）付きの大規模音楽コレクションでも低メモリ使用、サムネイルキャッシュの保存不要。
- アルバム／アーティスト／タイトルでグループ化・ソート、シャッフルリスト、全文検索。
- デスクトップ、タブレット、モバイルなど異なる画面に適応する滑らかなユーザーインターフェース。
- 背景にガウスぼかしのカバーを使用し、GNOMEのライト／ダークモードに追従。
- プレイリストの作成・編集をサポート、カバーをドラッグして順序変更や他のプレイリストへの追加が可能。
- 他のアプリとのドラッグ＆ドロップをサポート。
- オーディオピークビジュアライザーをサポート。
- ギャップレス再生をサポート。
- ReplayGainによる音量正規化をサポート。
- 指定したオーディオシンクをサポート。
- MPRISコントロールをサポート。

## Flathubからのインストール
<a href="https://flathub.org/apps/com.github.neithern.g4music">
<img src="https://flathub.org/assets/badges/flathub-badge-en.png" width="240"/></a>

## Snapcraftからのインストール（非公式）
<a href="https://snapcraft.io/g4music">
<img alt="Get it from the Snap Store" src="https://camo.githubusercontent.com/ab077b20ad9938c23fbdac223ab101df5ed27329bbadbe7f98bfd62d5808f0a7/68747470733a2f2f736e617063726166742e696f2f7374617469632f696d616765732f6261646765732f656e2f736e61702d73746f72652d626c61636b2e737667" data-canonical-src="https://snapcraft.io/static/images/badges/en/snap-store-black.svg" width="240" style="max-width: 100%;"> 

## FreeBSDの依存関係

```bash
pkg install vala meson libadwaita gstreamer1-plugins-all gettext gtk4
```
## ビルド方法  
Valaで書かれており、シンプルでクリーンなコードで、サードパーティの依存は少ないです:

1. gitlabからコードをクローンします。  
2. vala、gtk4、libadwaita、gstreamerの開発パッケージをインストールします。  
3. プロジェクトディレクトリで以下を実行します:  

    `meson setup build --buildtype=release`  

    `meson install -C build`  

## 変更履歴  
変更履歴は[リリースタグ](https://gitlab.gnome.org/neithern/g4music/-/tags)を参照してください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-05

---