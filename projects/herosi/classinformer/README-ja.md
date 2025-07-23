# Class Informer
オリジナルの classinformer を使用してください（以下のURL参照）。  
https://github.com/kweatherman/IDA_ClassInformer_PlugIn

オリジナルの作者である Kevin Weatherman 別名 "Sirmabus" が上記URLで IDA 9 用のプラグインをリリースしました。
したがって、このリポジトリの目的は終了しました！
このリポジトリをアーカイブする時です。
---------------------------------

IDA Pro 9 と 8 用の IDA Class Informer プラグインです。これは IDA 8 と 9 で動作するように移植した[オリジナルの classinformer](https://sourceforge.net/projects/classinformer/)のバージョンに過ぎません。したがって、積極的な開発は行いません。改善したい場合は PR を送ってください。改善要望のためのイシューは開かないでください。

 - このプラグインは IDA Pro の `9.1`、`9.0 SP1`、`9.0`、`8.4 SP2`、`8.2 SP1`、`8.0` の32ビット版および64ビット版でテストされています。
   - ***重要!!!*** IDA Pro 9.0 ***ベータ版*** はサポートしていません。リリース版を使用してください。
   - IDA Pro 7.x ではこのプラグインは読み込めません。[オリジナル版](https://sourceforge.net/projects/classinformer/)を使用してください。
 - **このプラグインは Windows 向け x86、x64、ARM、ARM64 の PE 形式バイナリにおける MSVC++ の RTTI の解析のみをサポートします。** GCC の RTTI やその他のアーキテクチャはサポートしません。
 - IDA 9 では `ClassInformer64.dll` をインストールするだけで良いです。
 - IDA 8 では `ClassInformer_IDA8x64.dll` と `ClassInformer_IDA8x.dll` の両方をインストールする必要があります。
 - もし IDA 8 と 9 の両方がマシンにある場合は、それぞれのバージョンに応じて IDA のディレクトリにコピーするか、すべての DLL を `%IDAUSR%\plugins` にコピーしてください。
   - IDAUSR について知らない場合は[このブログ記事](https://hex-rays.com/blog/igors-tip-of-the-week-33-idas-user-directory-idausr)を参照してください。

## ダウンロード
- コンパイル済みバイナリは [Releases](../../releases) セクションからダウンロードできます。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---