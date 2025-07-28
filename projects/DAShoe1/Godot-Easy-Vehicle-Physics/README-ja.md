# Godot-Easy-Vehicle-Physics
Godot 4.2以降対応のレイキャストベースの剛体車両システム

## 説明
キーボード操作に適した、設定が簡単な物理ベースの車両コントローラーです。すべてのパラメータは1つのスクリプト（vehicle.gd）にまとめられており、すべてにツールチップが付いています。

## 特徴
このコントローラーには、以下のような優れた車両を作るための多くの支援システムが搭載されています：
- ステアリングアシスト
- カウンターステアアシスト
- トラクションコントロール
- アンチロックブレーキ
- 安定性アシスト
- 空中アシスト
- 自動ギアボックス
- ロッキングディファレンシャル
- タイヤグリップアシスト
- 計算されたサスペンションパラメータ；適切なサスペンションパラメータの設定は難しいため、このコントローラーは比率と重量配分に基づいてバネ定数と減衰率を計算します。

## 例
4つのサンプル車両が含まれています：
- demo_arcade.tscn: アーケードスタイルのレーシングカーのような操作感。グリップが強く、操作が簡単で多くのアシストを搭載。
- demo_simcade.tscn: 実車に近い操作感で、車の制御を助けるアシスト付き。
- demo_monster_truck.tscn: モンスタートラックのような操作感で、アシストはほとんどなし。
- demo_drift.tscn: 簡単にドリフトできるように設定。

## 操作方法
- ステアリング：左：← または a 右：→ または d
- アクセル：↑ または w
- ブレーキ：↓ または s
- ハンドブレーキ：スペース
- クラッチ：C
- ギアボックス切替（オート/マニュアル）：T
- ギアアップ：F または +
- ギアダウン：R または -
- デバッグ情報表示：~
- デバッグ画面切替：< または >

## 物理エンジン
このコントローラーはGodotとJoltの両方の物理エンジンで良好に動作します。物理ティックレートは少なくとも120を推奨しており、より高い値も使用可能ですが、ティックレートを変更すると車両挙動が異なることに注意してください。

## 謝辞
Dechode氏とWolfe氏がGodotコミュニティにプロジェクトを共有してくれたことに大きく感謝します。このプロジェクトを共有することは恩返しの一つです。このコードの一部は[DechodeのGodot Advanced Vehicle](https://github.com/Dechode/Godot-Advanced-Vehicle)および[SERIES: Driving Simulator Workshop](https://lupine-vidya.itch.io/gdsim/devlog/677572/series-driving-simulator-workshop-mirror)に基づいており、適切なソースファイルに帰属情報を記載しています。
デモ用の車両モデルは[Kenney.nl Car Kit](https://www.kenney.nl/assets/car-kit)から提供されています。

## Godot Easy Vehicle Physicsを使用したプロジェクト
このアドオンを使用したプロジェクトをここに掲載したい場合は、Issueを開いてお知らせください。
- [Jack of all Cars](https://dashoe1.itch.io/jack-of-all-cars)
- [Another Lap](https://store.steampowered.com/app/3550210/Another_Lap/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---