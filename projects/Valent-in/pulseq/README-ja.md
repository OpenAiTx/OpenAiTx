# PulseQueue

電子音楽をデジタルシンセサイザーで作成するためのミニマルなウェブアプリケーション。  
最初はスケッチツールとして設計されましたが、フルレングスのトラック制作にも使用可能です :musical_note::notes:

**[:link: ブラウザで実行 :link:](https://valent-in.github.io/pulseq)**

- シンプルで使いやすい
- モバイル対応
- クライアントのみ（サーバーでのデータ処理なし）

- さまざまなエフェクト付きのサブトラクティブシンセサイザー
- ハーモニックオシレーター＆基本的なFM
- 多層ステップシーケンサー
- エクスポート可能なシンセプリセット
- WAVオーディオエクスポート
- MIDIエクスポート

## 音楽例（YouTube）
- [Cosmix - part 1](https://www.youtube.com/watch?v=KkLsClq37w4)
- [Cosmix - part 2](https://www.youtube.com/watch?v=8_aYqIMCa2k)
- [Clean Steps](https://www.youtube.com/watch?v=2IaCb21nIZU)

## クイックスタート
開始するには、付属の曲で実験してみてください。起動画面の「Demo」ボタンをクリックし、デモトラックを選択します。再度このメニューに戻るにはページをリロードしてください。

**プログラムタブ：**  
ARRANGE :cd:  
パターンを組み合わせて完全な音楽トラックを作成します。

PATTERN :musical_keyboard:  
ここにノートを配置します。シンセエンジンはモノフォニック（単一音声）で、追加の音声はパターンレイヤーで追加可能です。

SYNTH :control_knobs:  
選択した楽器の設定パネル。プリセットは3点メニューから利用可能です。

LIST :level_slider::level_slider:  
シンセサイザーのリストとミキサーを含みます。

## リファレンスカード
![overview card](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-overview.png)
![controls card](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-controls.png)
![routing card](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-synth.png)

## パフォーマンスノート
- 一部のエフェクトはCPU負荷が高い（特にリバーブとフェイザー）。モバイルデバイスで使用する際はこれを考慮してください。  
- WAVエクスポートの時間はモバイルブラウザで約10分に制限される場合があります。

---
Web Audio API と [Tone.js](https://github.com/Tonejs/Tone.js) を使用  
ファイルエクスポートのソース:  
[bufferToWave](https://github.com/rwgood18/javascript-audio-file-dynamics-compressor)、  
[midi-writer](https://github.com/carter-thaxton/midi-file)。

このプログラムはフリーソフトウェアです。GNU一般公衆利用許諾契約書バージョン3の条件のもと、再配布および改変が可能です。  
本プログラムは有用であることを願って配布されていますが、いかなる保証もありません。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---