# ECS-IAUS-sytstem
Unity向けの無限軸ユーティリティシステム  
ユーティリティシステムは、AIに利用可能なオプションを特定し、状況に基づいて各オプションにスコアを付けて最適なオプションを選択することで機能します。この方法は、いくつかの理由から非常に効果的であることが証明されています。

設計が簡単 - ユーティリティAIは自然言語で設計できることが多く、AIプログラマーがゲームデザイナーと話しやすくなります。条件、状態、シーケンス、デコレーターなどの難解な概念について話す必要はありません。代わりに「AIが攻撃されている場合は、隠れ場所を優先する」などの意図したAI行動を説明できます。「優先する」のような曖昧な用語も使用でき、人間の会話に自然な形で適用されます。

拡張が容易 - ルール（しばしばスコアラーと呼ばれる）は、既存のAIの上に簡単に追加できます。例えば有限状態機械とは異なり、重要な関係を壊すことはありません。代わりにスコアラーは単純に既存のスコアラーの上に追加されるため、AIの機能性と忠実度の拡張が容易です。

品質の向上 - 設計の単純さとAIの拡張の容易さにより、バグが大幅に減少し生産性が劇的に向上します。これにより、予算と期限内でより複雑で良好な動作をするAIの開発により多くの余裕が生まれ、AIの全体的な品質が向上します。

これは、Dave MarkのInfinite Axis Utility SystemをDOTSを使ってUnity3dで作成しようとした試みです。

無限軸ユーティリティシステムとは何か？

要するに、最も高い値を持つ実行すべきアクションを返すシステムです。基本的にはアクションのリストがあり、各アクションには「軸」のリストがあります。Dave Markは数年前のGDCでこの話をしていて、そこで知りました。実際には同じ講演で猫とレーザーポインターのゲームの話もしていて、それがLol Cats I Can Has Lazerの最初の種のアイデアでしたが、私たちのゲームは独自のデザイン方向に進みました。

講演へのリンクはこちら：

http://intrinsicalgorithm.com/IAonAI/2013/02/both-my-gdc-lectures-on-utility-theory-free-on-gdc-vault/

https://www.gdcvault.com/play/1018040/Architecture-Tricks-Managing-Behaviors-in 33分の地点から開始

このリポジトリは主にDOTSとユーティリティAIの学習および記録のためのものです。現状でそのまま使えるアセットをお探しの場合は、以下のリンクをご覧ください。  
https://gitlab.com/lclemens/lightweightdotsutilityai

Unity 6 Beta対応に更新済み  
状態管理のためのGOAPプランニングを追加


Copyright 2019 - 2024 Dreamers Inc Studios Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software. THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-17

---