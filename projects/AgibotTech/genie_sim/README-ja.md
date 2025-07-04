![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. Genie Sim Benchmark
Genie SimはAgiBotによるシミュレーションフレームワークであり、開発者に効率的なデータ生成機能と評価ベンチマークを提供し、エンボディドインテリジェンス開発を加速させます。Genie Simは、軌道生成、モデル学習、ベンチマーク、デプロイ検証を含む包括的なクローズドループパイプラインを構築しています。ユーザーは、この効率的なシミュレーションツールチェーンを通じてアルゴリズムの性能を迅速に検証し、モデルを最適化できます。単純な把持タスクから複雑な長距離操作まで、Genie Simは非常にリアルなシミュレーション環境と精密な評価指標を提供し、開発者がロボット技術の開発とイテレーションを効率よく完了できるよう支援します。

Genie Sim Benchmarkは、Genie Simのオープンソース評価版として、エンボディドAIモデルの精密な性能テストおよび最適化サポートの提供に特化しています。

# 2. 特徴
- 柔軟でユーザーフレンドリーなシミュレーション設定とインターフェース
- 10種類以上の操作タスク用シミュレーションベンチマークおよび評価タスク
- VRおよびキーボードに基づく遠隔操作機能
- 全ジョイントおよびエンドエフェクタの姿勢記録と再生
- 550以上の高精細かつ物理的に正確な3Dシミュレーション環境とアセット
- エンボディドAIモデルの性能を定量化する標準化された評価指標
- GO-1モデルでシミュレーションから実機評価誤差5%未満を達成
- シミュレーション評価におけるUniVLAベースラインモデルをサポート

# 3. 更新情報
- [2025/6/25] v2.1
  - Agibot World Challenge 2025向けに10個の操作タスク追加（全てのシミュレーションアセット含む）
  - Huggingface上で10操作タスクの合成データセットをオープンソース化
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - UniVLAポリシーを統合し、モデル推論シミュレーション評価をサポート
  - 他のロボット向けクロスエンボディメントIKソルビング対応のIKソルバーSDKを更新
  - 通信フレームワークを最適化し、シミュレーション実行速度を2倍向上
  - 複雑な長距離タスク向け自動評価フレームワークを更新

# 4. 目次

## 4.1 はじめに
Genie Simのエンボディドインテリジェンスシミュレーションベンチマークは、エンボディドAIモデルの開発促進と評価のために設計されています。これらのベンチマークは、現実的な環境、多様なタスク、標準化された指標を提供し、ロボットAIシステムの性能を測定します。これにより高価な物理ハードウェアや実世界テストの必要性を減らし、危険なテストシナリオを回避し、AIエージェントの学習と評価プロセスを加速します。

## 4.2 はじめ方
インストール・ユーザーガイド・APIリファレンスについては[こちらのページ](https://agibot-world.com/sim-evaluation/docs/#/v2)をご参照ください。

## 4.3 サポート
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 TODOリスト
- [x] より長期的なベンチマーク操作タスクのリリース
- [x] 各ベンチマークタスク向けのさらなるシーンとアセット
- [x] Agibot World Challengeベースラインモデルのサポート
- [ ] シナリオレイアウトおよび操作軌道の汎化ツールキット

## 4.5 FAQ
- エラー発生時にisaac simサーバーが応答しなくなった場合のシャットダウン方法は？
  ターミナルで `pkill -9 -f raise_standalone_sim` を使用してプロセスを強制終了してください。
- 異なるレンダーモードの選択方法は？
  デフォルトのレンダーモードは `RaytracedLighting(RealTime)` です。透明オブジェクトを含むタスクの場合は、オブジェクトの視点関係のため `RealTimePathTracing(RealTime-2.0)` をご利用ください。

## 4.6 ライセンスと引用
本リポジトリ内の全データおよびコードはMozilla Public License 2.0のもとで提供されています。
研究等で役立った場合は、以下のいずれかの方法で引用をご検討ください。
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 参考文献
1. PDDL Parser (2020). Version 1.1. [Source code]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Version 1.x.x [Source code]. https://github.com/StanfordVL/bddl
3. CUROBO [Source code]. https://github.com/NVlabs/curobo
4. Isaac Lab [Source code]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Source code]. https://github.com/StanfordVL/OmniGibson


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---