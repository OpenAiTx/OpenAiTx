# ECSCombat

UnityのECSフレームワークを使用したSFバトルシミュレーション。

[![プレビュー画像](https://img.youtube.com/vi/S2RJfbJly_A/0.jpg)](https://www.youtube.com/watch?v=S2RJfbJly_A)

無限バトルの動画は[こちら](https://www.youtube.com/watch?v=S2RJfbJly_A)でご覧いただけます。

## 注目すべきポイントの提案：

* 様々なAI挙動は `Battle/AI` にあります。
* 戦闘システムは `Battle/Combat` にあります。これには異なるタイプの武器（投射物/即時）、距離に基づく武器の効果、シールドによる攻撃の迎撃が含まれます。
* 装備やギアは `Battle/Equipment` にあります。船には異なる装備を取り付けることができ、これらは船の速度や旋回率の変更などの効果を持ちます。装備は攻撃を受けると損傷し、無効化されることがあります。例えば、エンジンが損傷すると船が機能不全になります。

## 技術的詳細：

* Unity 2020.1.0b7
* ユニバーサルレンダーパイプライン（シップシェーダーはシェーダーグラフ使用）

## 注意事項！

このプロジェクトはもともと、Unity Entitiesパッケージがまだ非常に若かった頃に、ECS（Entity-Component-System）スタイルのプログラミング練習用として始めました。
開始以来、Unity Entities APIとベストプラクティスには大幅な変更がありました。
可能な限り更新を試みていますが、私の限られた自由時間のため、改善が必要な箇所も必ずあります。
ですので、ぜひ参考にしてください。ただし、より良い方法が存在する可能性があることを念頭に置いてください！

## 最後の謝辞

一部のスプライトは私が作成しましたが、良い見た目のものは[こちら](https://opengameart.org/content/spaceships-1)から取得し、作者は[Wuhu](https://opengameart.org/users/wuhu)としてクレジットされています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---