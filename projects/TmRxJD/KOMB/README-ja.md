<head><meta name="google-site-verification" content="YTr2AYTpsxIQk7KIOlVTOfKr11dqkzZP-gOUiyhPU5s" />
<body>

<h1>KOMB: Klipperの究極のブラッシングマクロ</h1>

KOMBへようこそ。Klipper最適化ブラッシングマクロです！この多用途マクロは、ベッドおよびガントリーマウントブラシの両方に合わせて設計されたブラッシングシーケンスを簡素化します。既存のマクロの調整や新規作成の手間はもう不要です—これでブラシの3次元での全能力を活用できます！

<h3> インストール: </h3>

KAMPを始める最も簡単でクリーンな方法は、MoonrakerのUpdate Managerユーティリティを使うことです。これにより簡単にインストールでき、将来的な機能追加時のアップデートも提供されます！

1. Klipperデバイスに`ssh`で接続し、以下のコマンドを実行してください:
   ```bash
    cd
    
    git clone https://github.com/TmRxJD/KOMB    

    ln -s ~/KOMB printer_data/config/KOMB

    cp ~/KOMB/_KOMB_Variables.cfg ~/printer_data/config/KOMB_Variables.cfg

    ```
2. `moonraker.conf` ファイルを開き、次の設定を追加してください:

   ```yaml
   [update_manager KOMB]
   type: git_repo
   channel: dev
   path: ~/KOMB
   origin: https://github.com/TmRxJD/KOMB
   managed_services: klipper
   primary_branch: main
    ```
    > **注意:**
    > Moonrakerの設定を変更した場合、変更を反映させるために再起動が必要です。今後KAMPのアップデート通知を受け取りたくない場合は、スキップして構いません。

3. 必要に応じて、KOMB_Variables.cfgにKOMB_Purge.cfgを含めて、そこでマクロを使用してください。

<h3>特徴と機能</h3>

柔軟な動き: KOMBのデフォルトの動作は左下隅から右へのスイープですが、様々な軸や方向に沿った動きを簡単にカスタマイズできます。プリンターやブラシの配置に応じて印刷中にも使用可能です。

多様なパターン: 現在は斜めと円形スイープ（gcode_arcsが有効である必要があります）に対応しており、KOMBのレパートリーは今後さらに多くのパターンが追加される予定です。

3次元ブラッシング: ブラシの可能な範囲と深さを最大限に活用し、ノズルをより清潔に保ち、安定した性能を保証します。ノズルはステップごとにブラシに降りていき、より多くのノズル表面がブラシに接触できます。

印刷中に使用可能: KOMBトリガーで印刷の過程で何度でもマクロを使用でき、ノズルを常に清潔に保てます。

<h3>調整可能なブラシパラメータ: 精密な制御のための変数を調整</h3>
* ブラシの位置を(X, Y, Z)で指定し、サイズと深さをミリメートル単位で設定 <br>
* ステップサイズ: 斜めまたは円形ストローク間の距離 <br>
* Zステップ: 繰り返し使用時に各イテレーション後に下降。無効にするには0に設定。 <br>
* オフセット: ブラシの範囲外で動きを開始・終了させたり、より狭く範囲内に収めたりできます。負の値を使用してください。 <br>
* 繰り返し回数: パターンの繰り返し回数を指定 <br>
* 逆再生: 有効にすると、次の繰り返し前にパターンを逆方向に戻して繰り返します。無効の場合はパターン後に直線的に開始点に戻ります。 <br>
* 反対側および/または隣接側で開始: 反対側を有効にするとノズルは右から左へ動きます。隣接側が有効ならばノズルは反対軸に沿って下から上へ動きます。両方有効ならノズルは上から下へ動きます。 <br>
* 可変速度: mm/sで速度を指定し、繰り返しごとに速度を増減可能。ブラシへの移動速度も制御可能。 <br>
* パターン: 現在は斜めと円形のブラッシングパターンから選択可能です。（クラシックな水平パターンを使用したい場合は、反対軸のブラシサイズを0に設定してください。ステップさせたい場合は角度を0に設定） <br>
* 角度: パターン1の斜めストロークの角度を指定、推奨デフォルトは45度 <br>
* 自動加熱: 有効にして最低温度を指定すると、その温度でブラッシング可能になり、ブラッシング前に自動で予熱されます。 <br>
* 自動ホーム: 必要に応じてプリントヘッドを自動でホームポジションに戻します。既にホームの場合は動作しません。 <br>
* リトラクション: ブラッシングの前、中、後のリトラクションを設定可能。 <br>
* Zホップ: ブラシ位置へ移動前にノズルを上げる高さを指定し、その後降ろします。無効にするには0に設定。 <br>
* 詳細フィードバック: 軸の値、計算、位置ポイントなどブラッシングプロセスの詳細なコンソール出力を有効化。 <br>

<h4>KOMBトリガー</h4>


You can use KOMB at a specified frequency throughout the print to ensure your nozzle stays clean for the entire duration. Include `KOMB_trigger` in the 'at layer change' section of your slicer configuration to effortlessly trigger the macro at your preferred frequency. Additionally, integrate this macro name into your start print routine to use the macro before starting printing. This feature is not intended for per-object printing and is tailored for use with gantry and frame-mounted brushes. While functional with bed-mounted brushes, cautious use is advised, as attention to your printer's clearances is essential to prevent potential collisions. If utilizing Z hop, the nozzle will ascend before maneuvering over the brush, descend for brushing, and subsequently reascend to its initial height before resuming printing. Configure Z hop settings to provide added clearance during elevation and descent. It is strongly recommended not to set the Z hop value below 2. Additionally, ensure that your axis limits are accurately defined for the macro's effective operation. For guidance on setting axis limits, refer to the guide provided at the end of this readme.
<h4>KOMB パージ</h4>

KOMBのパージオプションは、ブラッシングシーケンスを開始する前に制御された材料パージを実行する能力を提供します。この機能は、Zオフセットキャリブレーションやその他の測定依存操作のように精度が重要な場合に特に有用で、余分なパージラインを引く必要がありません。この機能を利用することで、パージ容器の位置、希望するフィラメント押出量、ブラッシングシーケンスに移行する前の待機時間を簡単に定義できます。パージオプションはマクロの他の部分とは独立しても有効にでき、特定の要件に応じて印刷プロセスを調整する柔軟性を提供します。マクロをスタートプリントで使用するには、設定に「KOMB_purge」を追加してください。

<h3>KOMBの特徴</h3>

KOMBは多様なプリンター設定にシームレスに適応し、異なるブラシサイズや位置に対応するよう設計されています。従来のマクロがノズルを特定の位置に無理やり動かすのとは異なり、KOMBは変数に基づいてプリンターの制限内に収まるよう事前調整された座標の一連のシーケンスを生成します。この先取りしたアプローチにより、ユーザーの誤操作にかかわらずブラッシングの成功をほぼ確実にし、エラーのリスクをほぼ排除します。プリンターの境界を超える生成点は自動的に範囲内に調整され、スムーズな実行を保証します。リストが即座に生成されると、KOMBはノズルを決められた座標にスムーズに案内します。

<h3>KOMBの始め方</h3>

3DプリンターにKlipperファームウェアがインストールされていることを確認してください。

付属のKOMBマクロコード「KOMB.cfg」をKlipperの設定ファイル「printer.cfg」に、他のマクロと一緒に統合します。ユーザーの利便性を高めるために、KOMB変数は別ファイルに分けて`[include _KOMB_Variables.cfg]`で読み込むことを推奨します。あるいは、より便利であればメインの設定ファイルと統合しても構いません。

KOMB_Variablesセクションで、ブラッシングの要件に合わせて変数を指定してください。

プリンターのUIを使ってXYのブラシ位置を正確に決定します。左下隅から始め、必要に応じて0.1mm単位で調整します。

ブラシのサイズを測定するか、右上隅に移動して左下位置との差をX軸とY軸で計算します。
Z位置についても同様の手順を繰り返し、各繰り返しでノズルを段階的に下げるオプション（z_step）を考慮してください。

設定ファイルを保存し、Klipperをリロードして変更を適用します。

コンソール、UIのマクロボタン、またはスタートプリントマクロに「KOMB」を追加して実行します。実行前に変数が正確に設定されていることを確認してください。

詳細出力を有効にしている場合はコンソール出力で進行状況を監視します。

KOMBで強化されたブラッシングをお楽しみください！

<h3>重要な注意事項</h3>

このマクロは多くの変数とパラメーターを使用して動作するよう設計されています。プリンターの仕様やブラッシングのニーズに応じてそれらを調整してください。各変数の役割と使用方法を理解することが重要です。

このマクロが正常に機能するには軸の制限が正しく設定されている必要があります。不明な場合は以下のガイドを参照してください：https://github.com/rootiest/zippy_guides/blob/main/guides/axis_limits.md

このマクロはプリンターのノズルを移動させるため、ブラッシング中の衝突を避けるために注意し、すべての値が正しいことを確認してください。ノズルをブラシ上方の低速でテストし、位置に下ろす前に動作確認を行うことを推奨します。

将来のアップデートや新しいパターンのために、ぜひまたチェックしてください！


KOMBは開発途中であり、すべての変数の組み合わせが完全にテストされているわけではありません。マクロの改善に向けたフィードバックや貢献を大変歓迎します。

問題が発生した場合、改善の提案がある場合、またはKOMBの開発に参加したい場合は、お気軽にメッセージを送るか、GitHubリポジトリでイシューを開くかプルリクエストを提出してください。

楽しいKOMBライフを！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-14

---