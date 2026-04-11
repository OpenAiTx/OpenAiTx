# <img src="https://github.com/user-attachments/assets/b81b9503-948e-4cba-b0a1-f5f809588aad" width="48"> SwitchWave
Nintendo Switch向けのハードウェアアクセラレーション対応メディアプレーヤーで、mpvおよびFFmpegをベースに構築されています。

## 機能
- FFmpeg用のカスタムハードウェアアクセラレーションバックエンド、動的周波数スケーリング対応。以下のコーデックをデコード可能：
    - MPEG1/2/4
    - VC1
    - H.264/AVC（ハードウェアでは10ビット以上非対応）
    - H.265/HEVC（ハードウェアでは12ビット以上非対応）
    - VP8
    - VP9（ハードウェアでは10ビット以上非対応）
- [deko3d](https://github.com/devkitPro/deko3d)を使用したmpv用カスタムグラフィックスバックエンド、対応内容：
    - 4k60fpsでの再生
    - 直接レンダリング（ソフトウェアデコードの高速化）
    - カスタムポストプロセスシェーダー
- ネイティブNintendo APIを使用したmpv用カスタムオーディオバックエンド、5.1サラウンドまでのレイアウトに対応
- HTTP/S、Samba、NFS、SFTPを介したネットワーク再生
- [libusbhsfs](https://github.com/DarkMatterCore/libusbhsfs)を利用した外部ドライブサポート
- 負荷がかかっていても豊富でレスポンシブなユーザーインターフェース

## スクリーンショット

<p float="center">
    <img src="https://github.com/user-attachments/assets/09aed446-148a-4276-8b07-336890c224a3" width="413" />
    <img src="https://github.com/user-attachments/assets/6e354511-47bc-4898-881c-348d5a9e6fbc" width="413" />
    <img src="https://github.com/user-attachments/assets/b86eb7c6-4229-46c6-8709-86d1a6ee8eed" width="413" />
    <img src="https://github.com/user-attachments/assets/70f4be3e-fa1e-434a-b76c-4fb6b671f80e" width="413" />
</p>

## セットアップ
- [最新リリース](https://github.com/averne/SwitchWave/releases/latest)をダウンロードし、SDカードのルートに展開してください（フォルダを上書きせずにマージするよう注意）
- ネットワーク共有はアプリから設定可能で、mpvの設定も内蔵エディタで編集可能です（[マニュアル](https://mpv.io/manual/master/)参照）
- 再生中にメニューや、メニューが使えない場合はコンソールから動的にほとんどのランタイムパラメータを調整可能です（[マニュアル](https://mpv.io/manual/master/#console)）

## ビルド

### Docker（推奨）
```sh
./build-docker.sh
```
これはツールチェーンイメージを構築し、すべてを自動的にコンパイルします。出力は `build/` にあります。

デフォルトの GIMP 2 ではなく GIMP 3 でビルドするには：
```sh
GIMP_VERSION=3 ./build-docker.sh
```
### マニュアル
- Switchホームブリュー開発用に[devkitpro](https://devkitpro.org/wiki/devkitPro_pacman)環境をセットアップします。
- 次のパッケージをインストールします：`switch-bzip2`、`switch-dav1d`、`switch-freetype`、`switch-glm`、`switch-harfbuzz`、`switch-libarchive`、`switch-libass`、`switch-libfribidi`、`switch-libjpeg-turbo`、`switch-libpng`、`switch-libwebp`、`switch-curl`、`switch-libssh2`、`switch-mbedtls`、`switch-ntfs-3g`、および`switch-lwext4`。さらに、次のビルド依存関係が必要です：`switch-pkg-config`、`dkp-meson-scripts`、`dkp-toolchain-vars`、および[GIMP](https://www.gimp.org/)（2または3）。
- [libusbhsfs](https://github.com/DarkMatterCore/libusbhsfs)のGPLビルドをコンパイルしてインストールします。
- [libsmb2](misc/libsmb2/)と[libnfs](misc/libnfs/)をコンパイルしてインストールします。
- FFmpegを設定、コンパイル、インストールします：`make configure-ffmpeg && make build-ffmpeg -j$(nproc)`。
- libuamを設定、コンパイル、インストールします：`make configure-uam && make build-uam`。
- mpvを設定、コンパイル、インストールします：`make configure-mpv && make build-mpv`。
- 最後に、メインアプリケーションをコンパイルし、リリース配布物をビルドします：`make dist -j$(nproc)`。
- 出力は`build/`に生成されます。

## クレジット
- スクリーンショットボタンのオーバーライド方法については[Behemoth](https://github.com/HookedBehemoth)に感謝します。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---