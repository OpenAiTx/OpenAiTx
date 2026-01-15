<p align="center">
  <img src="https://raw.githubusercontent.com/toddmaustin/mojo-v/main/./docs/MojoV-logo1.png" alt="Mojo-V ロゴ" width="550"/>
</p>

# Mojo-V: RISC-Vのための秘密計算

**Mojo-V**（発音は *「モジョファイブ」*）は、RISC-V向けのプライバシー指向プログラミング機能を導入する新しいRISC-V拡張です。Mojo-Vは秘密計算を実装し、壊れやすいソフトウェアやプログラマーの信頼に依存せずに、安全で効率的かつデータを秘匿した実行を可能にします。機密データを専用の秘密レジスタに隔離し、メモリを第三者の鍵で暗号化することで、Mojo-Vは情報漏洩を防ぎ、直接的な情報開示を行わない（ブラインド）かつ副チャネル漏洩のない（サイレント）計算を強制します。この設計はモードビットと4つの新命令のみで既存のRISC-V ISAにシームレスに統合され、すべてデコード時に強制されます。初期の結果では、完全準同型暗号（FHE）と比べて5〜7桁以上の性能向上を示しつつ、ほぼネイティブの実行速度を達成しており、CPU、GPU、専用アクセラレータへの統合に向けた明確なロードマップがあります。

詳細はこちら…
- Mojo-Vの紹介動画：https://www.youtube.com/watch?v=HUT46TcNyyM
- Mojo-Vプロジェクトの概要スライド：https://drive.google.com/file/d/1VVzZqYHvQgnKMgXZjg7I_cX2GzF7awSN

現在のMojo-V ISA拡張仕様（リリース0.92）：
- [PDF形式。](https://drive.google.com/file/d/1pargKATFoQdy94i6bI3P_9mfNA_GsYSw)

Mojo-V開発者への連絡先：
- メール：[mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)

# 🧩 Mojo-Vリファレンスプラットフォーム — リリース0.92

## 🚧 プロジェクト状況

Mojo-Vリファレンスプラットフォームリリース0.92は、固定対称鍵暗号を用いた秘密整数および浮動小数点計算を実装しています。Mojo-Vは高速、強力、証明付きの3つの暗号化モードをサポートします。本リリース時点で64ビット秘密計算は完全に秘匿化されており、この初期リファレンスプラットフォームはソフトウェア開発やレッドチーミングに利用可能です。将来のリリースではPKIサポート、LLVMコンパイラサポート、32ビットRISC-V対応、VIP-Benchベンチマークサポートなどの追加機能が展開される予定です。

**仕様バージョン:** 0.92  （2025年11月）  
**連絡先:** [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)

## 現在の構成要素

1. **Mojo-V ISA仕様 v0.92**
   - `doc/`にて公開
2. **Spike（命令セットシミュレータ）実装**
   - Mojo-Vが`riscv-isa-sim`に統合済みでほぼ機能完備
   - 未対応：公開鍵基盤（PKI）サポート（現在はSimon-128暗号を用いた固定鍵を使用）
   - Mojo-V拡張を有効にしてSpikeを実行するには、`spike`実行時に`--isa=rv64gc_zicond_zkmojov_zicntr`フラグを追加
3. **Mojo-V ブリングアップベンチマーク**
   - 手書き例（例：バブルソート）でMojo-Vの秘密計算の動作を示す
   - RV64GC+Mojo-Vの完全なセキュリティテスト群

なお、Bringup-benchベンチマークの残りはまだMojo-Vに移植されていません。

## ⚙️ Mojo-Vリファレンスプラットフォームの構築と実行

### A. RISC-V LLVMコンパイラのインストール
`RV64GC`バイナリを生成できるLLVMベースのRISC-Vクロスコンパイラが必要です。

こちらから始めるのが良いでしょう：https://clang.llvm.org/get_started.html

### B. Mojo-Vリポジトリのクローン
```bash
git clone https://github.com/toddmaustin/mojo-v.git
cd mojo-v
```
### C. Mojo-V対応のRISC-V Spikeシミュレータをビルドする

```bash
sudo apt-get install device-tree-compiler libboost-regex-dev libboost-system-dev
cd riscv-isa-sim
mkdir build
cd build
../configure --prefix=$RISCV
make
```

### D. Mojo-V Bringup-Bench ベンチマークテストのビルドと実行

1. **Spike デバイスドライバをビルドする**

   ```bash
   cd bringup-bench/target
   make
   ```
2. **コンパイラの設定**

   `../Makefile` を編集し、`mojov` ターゲットの `TARGET_CC` をLVMのClangベースのRISC-Vコンパイラの場所に設定します。

3. **ビルドとテスト**


   ```bash
   cd ..                # go to the top-level bringup-bench directory
   make mojov-tests     # run all Mojo-V tests
   ```
別の方法として、各ベンチマークのディレクトリに移動し、以下のコマンドを実行することで個別にベンチマークを行うことができます。


   ```bash
   cd ../mojov-test
   make TARGET=mojov clean build test
   ```

## 🧪 Mojo-V Bringup-Bench ベンチマーク概要

| プログラム | 説明 |
|:---------|:-------------|
| `mojov-test` | スライドからのイントロ例 |
| `mojov-test1` | シークレットレジスタおよび暗号化メモリのセマンティクステスト |
| `mojov-test2` | Mojo-V 高速暗号化を用いた手書きデータ不変整数バブルソートベンチマーク（int,fast） |
| `mojov-test3` | Mojo-V 高速暗号化を用いた手書きデータ不変浮動小数点バブルソートベンチマーク（fp,fast） |
| `mojov-test4` | Mojo-V 強力暗号化を用いた手書きデータ不変整数バブルソートベンチマーク（int,strong） |
| `mojov-test5` | Mojo-V 強力暗号化を用いた手書きデータ不変浮動小数点バブルソートベンチマーク（fp,strong） |
| `mojov-pctests` | RV64GC+Mojo-V用手書き整合性チェックテストスイート。Mojo-Vの証明携帯暗号化フォーマットの正負テストを含む（proofcarrying） |
| `mojov-sectests` | RV64GC+Mojo-V用手書きセキュリティテストスイート。130正 + 245負テスト、合計375（int,fp,fast,strong） |

全てのテストベンチマークはMojo-V ISAルールとセキュリティセマンティクスを示す手書きアセンブリプログラムです。その他のBringup-BenchベンチマークはまだMojo-Vに移植されていません。

---
## コードライセンス
このリポジトリ内のすべてのMojo-V関連コードは、改変したツール（例：Spike、LLVM、Bringup-Bench）のライセンスの下で公開されています。ライセンスの詳細は各ツールのディレクトリをご参照ください。

---

## 💬 質問とフィードバック
ご意見、バグ報告、提案を歓迎します！

📧 **メール:** [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)  
🌐 **プロジェクトホーム:** [https://github.com/toddmaustin/mojo-v](https://github.com/toddmaustin/mojo-v)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---