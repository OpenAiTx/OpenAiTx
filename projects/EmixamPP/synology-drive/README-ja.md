# <p align=center>synology-drive</p>

Synology Drive Client の非公式 RPM パッケージ <https://www.synology.com>。

FlatHub で提供されているパッケージは完全に機能しない上、Alien による deb から rpm への変換方法は多くの操作を必要とするため、  
私は Synology Drive Client のクリーンで 100% 機能する RPM パッケージを自分で作成することにしました。

ファイル共有メニューにアクセスし、ファイル同期状態インジケーター（Windows や Ubuntu と同様）を表示するために、依存関係としてファイルマネージャ Nautilus を含めています。\
また、トレイアイコンを表示するため（KDE ではネイティブに動作）に、依存関係として GNOME シェル拡張機能も含めています。\
GNOME を使用しないユーザー向けに、上記の二つの依存関係を含まない別のパッケージも作成しました（後から必要に応じてインストール可能です）。



## インストール
Alien や Flatpak（私のリポジトリ以外のソース）で以前に Synology Drive Client をインストールしている場合は、アンインストールしてください。

このプロジェクトを気に入ったら、リポジトリにスターを付けて支援していただけると嬉しいです。ありがとうございます！

### 方法 1：COPR リポジトリからインストール（更新を受け取るには推奨）
ページリンク : [COPR パッケージ](https://copr.fedorainfracloud.org/coprs/emixampp/synology-drive/)。

1. `sudo dnf copr enable emixampp/synology-drive`
2. GNOME 用：`sudo dnf --refresh install synology-drive`
3. 他のデスクトップ環境用：`sudo dnf --refresh install synology-drive-noextra`

### 方法 2：ローカルでパッケージをビルド（更新なし）
1. ビルドツールをインストール : `sudo dnf install rpm-build rpmdevtools`
2. `git clone https://github.com/EmixamPP/synology-drive.git`
3. `cd synology-drive`
4. 任意でバージョンを変更する場合：
   1. [リリースノート](https://www.synology.com/en-global/releaseNote/SynologyDriveClient) を参照し、希望のバージョン (>= 3.2.1-13271) を選択
   2. GNOME またはその他のデスクトップ環境を使っているかに応じて、`synology-drive.spec` または `synology-drive-noextra.spec` の最初の二行を編集
5. GNOME 用：
   1. `spectool -g -R synology-drive.spec`
   2. `rpmbuild -ba synology-drive.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-*.x86_64.rpm`
6. 他のデスクトップ環境用：
   1. `spectool -g -R synology-drive-noextra.spec`
   2. `rpmbuild -ba synology-drive-noextra.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-noextra-*.x86_64.rpm`
7. ビルドルートをクリーンアップ : `rm -r ~/rpmbuild`

### 実験的: Aarch64/ARM64プロセッサ（例: Apple Silicon、Qualcomm Snapdragon）向けにパッケージをローカルでビルドする方法
1. ビルドツールをインストール : `sudo dnf install rpm-build rpmdevtools`
2. `git clone https://github.com/EmixamPP/synology-drive.git`
3. `cd synology-drive`
4. バージョンを変更したい場合（任意）:
   1. [リリースノート](https://www.synology.com/en-global/releaseNote/SynologyDriveClient)を参照し、希望のバージョン（>= 3.2.1-13271）を選択
   2. GNOMEか他のデスクトップ環境かに応じて、`synology-drive.spec` または `synology-drive-noextra.spec` の最初の2行を編集
5. GNOMEの場合:
   1. `spectool -g -R synology-drive-aarch64.spec`
   2. `rpmbuild -ba synology-drive-aarch64.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-*.aarch64.rpm`
6. その他のデスクトップ環境の場合:
   1. `spectool -g -R synology-drive-aarch64-noextra.spec`
   2. `rpmbuild -ba synology-drive-aarch64-noextra.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-noextra-*.aarch64.rpm`
7. ビルドルートをクリーンアップ : `rm -r ~/rpmbuild`
**注意**_**: この方法はFEXエミュレーターを使用しています。QEMUエミュレーターを使用している場合、binfmt_miscはx86_64バイナリに対して1つのエミュレーターのみを登録できるため、動作しない可能性があります。

## 法的情報
[LICENSE](https://github.com/EmixamPP/synology-drive/blob/main/LICENSE)を参照してください。

このプロジェクトはSynology Inc.によって承認されています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-29

---