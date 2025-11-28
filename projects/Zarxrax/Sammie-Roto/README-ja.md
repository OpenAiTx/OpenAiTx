
# Sammie-Roto
**S**egment **A**nything **M**odel with **M**atting **I**ntegrated **E**legantly

![Sammie-Roto screenshot](https://raw.githubusercontent.com/Zarxrax/Sammie-Roto/main/sammie/sammie_screenshot.webp)

Sammie-Rotoは、ビデオクリップのAI支援マスキングのためのユーザーフレンドリーなツールとして設計されています。これは、AdobeのRoto BrushやDaVinci ResolveのMagic Maskのような商用ソリューションの無料代替として機能します。手動ロトスコーピングよりも一般的には精度は劣りますが、通常は少ない労力でかなり良い結果を得ることができます。

## 新しい[Sammie-Roto 2](https://github.com/Zarxrax/Sammie-Roto-2)をチェックしてください！

### 更新情報
- [2025/10/31] [Sammie-Roto 2](https://github.com/Zarxrax/Sammie-Roto-2)がリリースされました！今後のすべての更新はこのバージョンで行われます。
- [2025/09/22] PNGエクスポートの追加、画像シーケンスのインポート、マッティングエクスポートのバグ修正、CLI経由での動画読み込みを追加。
- [2025/08/23] エクスポートタブにファイル名に様々な情報を入れるオプションを追加。
- [2025/08/16] フレーム端のマスクを修正するためのボーダーフィックススライダーを追加。マッティング中のVRAM使用量を削減。
- [2025/08/03] アニメコンテンツのエッジ周りのチャタリングを減らすための重複排除を追加。
- [2025/05/10] 単一画像のインポート/エクスポート対応を追加。エクスポート設定は記憶されるように。
- [2025/04/23] Linux/Mac用インストーラーを追加、VRAM消費を削減、複数の改善とバグ修正。
- [2025/04/04] マッティングページに調整用スライダーをいくつか追加。
- [2025/02/26] [MatAnyone](https://github.com/pq-yang/MatAnyone)による人間ビデオマッティングサポートを追加、その他多くの改善。
- [2025/01/26] 初回リリース

### 機能
- Windows、Linux、Macをサポート
- 簡単なインストーラーがすべての依存関係とモデルを自動ダウンロード
- 4GB VRAMやCPUだけでも動作可能（ただし6GBのNvidia GPU推奨）
- 3つのセグメンテーションモデルを含む：Sam 2.1 Large、Sam 2.1 Base+、EfficientTAM_s_512x512。
- 人間ビデオマッティングにMatAnyoneモデルをサポート。
- 使いやすいインターフェース。
- 複数オブジェクトのサポート。
- エッジスムージングを含む様々なマスク後処理オプション。
- アニメコンテンツのエッジ周りのチャタリングを減らす重複排除をサポート。
- 複数のエクスポートオプション：白黒マット、アルファチャンネル、グリーンスクリーン。

### インストール（Windows）：
- [リリース](https://github.com/Zarxrax/Sammie-Roto/releases)から最新のWindows版をダウンロード
- ZIPアーカイブを解凍
- 'install_dependencies.bat' を実行し、指示に従う
- 'run_sammie.bat' を実行してソフトウェアを起動

すべてはSammie-Rotoフォルダ内に自己完結しています。アプリケーションを削除したい場合は、このフォルダを削除するだけです。フォルダを移動することも可能です。

### インストール（Linux、Mac）
- [Python](https://www.python.org/)がインストールされていることを確認してください（バージョン3.10以上）
- 最新のLinux/Macバージョンを[リリース](https://github.com/Zarxrax/Sammie-Roto/releases)からダウンロード
- zipアーカイブを解凍してください。
- ターミナルを開き、zipから解凍したSammie-Rotoフォルダに移動します。
- 次のコマンドを実行してください：`bash install_dependencies.sh` その後、プロンプトに従ってください。
- MacOSユーザー：プログラムを起動するには「run_sammie.command」をダブルクリックしてください。Linuxユーザー：`bash run_sammie.command` またはお好みの方法でファイルを実行してください。

### チュートリアル
[![Sammie-Rotoチュートリアル](https://img.youtube.com/vi/042uKTqlJ_c/0.jpg)](https://www.youtube.com/watch?v=042uKTqlJ_c)

### 謝辞
* [SAM 2](https://github.com/facebookresearch/sam2)
* [EfficientTAM](https://github.com/yformer/EfficientTAM)
* [MatAnyone](https://github.com/pq-yang/MatAnyone)
* [Wan2GP](https://github.com/deepbeepmeep/Wan2GP)（MatAnyoneの最適化版）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-28

---