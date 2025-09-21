<a href="https://buymeacoffee.com/koromix" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>

# 概要

KoffiはNode.js向けの高速かつ使いやすいC FFIモジュールで、以下の特徴があります：

* 低オーバーヘッドで高速なパフォーマンス（[ベンチマーク](https://koffi.dev/benchmarks)参照）
* プリミティブおよび集約データ型（構造体や固定サイズ配列）に対応し、参照（ポインタ）および値渡しの両方をサポート
* Javascript関数をCのコールバックとして使用可能（バージョン1.2.0以降）
* 人気のあるOS/アーキテクチャの組み合わせに対して十分にテスト済みのコードベース

現在、以下のOSとアーキテクチャの組み合わせが__公式にサポートおよびテスト済み__です：

ISA / OS           | Windows     | Linux    | macOS       | FreeBSD     | OpenBSD
------------------ | ----------- | -------- | ----------- | ----------- | --------
x86 (IA32) [^1]    | ✅ はい     | ✅ はい  | ⬜️ *該当なし* | ✅ はい     | ✅ はい
x86_64 (AMD64)     | ✅ はい     | ✅ はい  | ✅ はい     | ✅ はい     | ✅ はい
ARM32 LE [^2]      | ⬜️ *該当なし* | ✅ はい  | ⬜️ *該当なし* | 🟨 おそらく  | 🟨 おそらく
ARM64 (AArch64) LE | ✅ はい     | ✅ はい  | ✅ はい     | ✅ はい     | 🟨 おそらく
RISC-V 64 [^3]     | ⬜️ *該当なし* | ✅ はい  | ⬜️ *該当なし* | 🟨 おそらく  | 🟨 おそらく

[^1]: サポートされている呼び出し規約：cdecl、stdcall、MS fastcall、thiscall。
[^2]: 事前ビルド済みバイナリはハードフロートABIを使用し、VFPコプロセッサを必要とします。異なるABI（softfp、soft）で使用するにはソースからビルドしてください。
[^3]: 事前ビルド済みバイナリはLP64D（二重精度浮動小数点）ABIを使用します。LP64 ABIは理論上はソースからビルドすればサポートされますが未検証です。LP64F ABIはサポートされていません。

詳細情報は以下のリンクをご利用ください：

- ドキュメント: https://koffi.dev/
- 変更履歴: https://koffi.dev/changelog
- ソースコード: https://codeberg.org/Koromix/rygel/ （説明は下記参照）

# ソースコード

このリポジトリにはKoffiのコードは含まれておらず、フロントとして存在しています。実用的な理由から、2018年よりすべてのプロジェクトを単一リポジトリで管理し始めました。管理が容易になるためです。

ソースコードはこちらで入手可能です：https://codeberg.org/Koromix/rygel/ （*src/koffi*サブディレクトリ内）。

モノリポジトリには私にとって二つの強力な特徴があります：

* 複数プロジェクトにまたがるリファクタリング
* 依存関係管理の簡素化

詳細な理由はこちらをご覧ください: https://danluu.com/monorepo/

# 手動ビルド

KoffiはCNokeというカスタムCMakeラッパーでビルドされており、これもモノリポジトリ内にあります。CMakeを手動で実行しようとしないでください。失敗します。

[Koffiをソースからビルドするためのドキュメント化された手順](https://koffi.dev/contribute#build-from-source)に従ってください。

# ライセンス

このプログラムはフリーソフトウェアです。**MITライセンス**の条件の下で再配布および改変が可能です。

詳細はこちらをご覧ください: https://choosealicense.com/licenses/mit/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-21

---