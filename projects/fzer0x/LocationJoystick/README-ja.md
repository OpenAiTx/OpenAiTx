# Location Joystick

## 日本語

Location Joystickは位置情報のシミュレーション用に設計されたXposedモジュールです。ジョイスティックのオーバーレイと様々な位置情報関連の設定を提供し、シミュレーション体験を向上させます。

⚠️ **[新機能] ルート/Xposed不要機能（モックロケーション）** ⚠️

# 最新リリース: https://github.com/fzer0x/LocationJoystick_V4/releases

<div align="center">

## 🚀 コミュニティに参加しよう 🚀

<a href="https://t.me/+LTsF8mOwkRE3YzYy">
  <img src="https://img.shields.io/badge/👉_CLICK_HERE_TO_JOIN-FF0000?style=for-the-badge&logo=telegram&logoColor=white" />
</a>

🔥 参加してサポートと最新情報をゲット！

</div>

![スクリーンショット](https://github.com/fzer0x/LocationJoystick/blob/main/screenshot3.jpg?raw=true)

## 機能

- **ジョイスティックオーバーレイ:** カスタマイズ可能なジョイスティックでリアルタイムにナビゲート。
- **位置情報シミュレーション:** 精密にGPS位置をモック。
- **GNSSモック:** 衛星数、SVID、C/N0などの完全なGNSS状態シミュレーションにより、リアルな位置特性を再現。
- **ランダム化:** より自然な動きを実現するために位置にランダムなオフセット半径を追加。
- **お気に入り:** お気に入りの場所を保存・管理し、素早く切り替え可能。
- **カスタマイズ可能なUI:**
    - ジョイスティックとミニマップの透明度（アルファ）を調整。
    - ジョイスティックの速度設定可能。
    - ジョイスティックの位置を永続的に保存。

## 動作要件

- **Android:** 10以上（最小SDK 30）
- **Root:** Xposed Framework使用時に必要。
- **Xposed Framework:** LSPosed が推奨されます。
- **[新機能] Root/Xposed 不要の機能（モック位置情報）**

## インストールと LSPosed のスコープ設定

1. Location Joystick APK をインストールします。
2. Xposed マネージャー（例：LSPosed）を開きます。
3. **Location Joystick** モジュールを有効にします。
4. **重要:** LSPosed でスコープを設定します：
    - **Android-System**（GNSS とシステム全体のモックに必須）。
    - **対象アプリ**（例：ポケモンGO、マップ）。
5. デバイスを再起動するか（LSPosed 使用時は対象アプリと System UI を強制停止してください）。
6. Location Joystick を開き、必要な権限（オーバーレイ、位置情報）を許可します。

## 使い方

1. アプリを開き、地図上で希望の開始地点を設定します。
2. シミュレーション設定（速度、精度など）を調整します。
3. サービスを開始して、ジョイスティックのオーバーレイを表示します。
4. 対象アプリを開いて、ジョイスティックで移動します。

## 免責事項

このツールは教育および開発目的のみに使用してください。使用は自己責任でお願いします。

## ライセンス

詳細は [LICENSE](LICENSE) ファイルを参照してください。

---

# Location Joystick

## 中文

Location Joystick は位置情報を模擬するための Xposed モジュールです。仮想ジョイスティックの浮動ウィンドウや、位置情報に関連した多様な設定を提供し、模擬体験を強化します。

⚠️ **[新機能] Root や Xposed 不要の模擬位置情報機能** ⚠️


<div align="center">

## 🚀 私たちのコミュニティに参加しよう 🚀

<a href="https://t.me/+LTsF8mOwkRE3YzYy">
  <img src="https://img.shields.io/badge/👉_クリックして参加-FF0000?style=for-the-badge&logo=telegram&logoColor=white" />
</a>

🔥 参加すると無料特典と最新アップデートを入手可能！

# 最新リリース: https://github.com/fzer0x/LocationJoystick_V4/releases

</div>

![スクリーンショット](https://github.com/fzer0x/LocationJoystick/blob/main/screenshot3.jpg?raw=true)

## 機能

- **仮想ジョイスティックのフローティングウィンドウ：** カスタマイズ可能なジョイスティックでリアルタイム移動。
- **位置情報のシミュレーション：** GPSの位置を正確にシミュレート。
- **GNSSシミュレーション：** 完全なGNSS状態（衛星数、SVID、C/N0など）をシミュレートし、高度な位置検出対策に対応。
- **ランダマイズ：** 位置にランダムな偏差範囲を追加し、移動軌跡をより自然に。
- **お気に入り：** よく使う位置を保存・管理し、素早く切り替え可能。
- **カスタマイズ可能なインターフェース：**
    - ジョイスティックとミニマップの透明度（アルファ値）調整。
    - ジョイスティックの移動速度を設定可能。
    - ジョイスティックの位置を自動保存。

## システム要件

- **Android：** 10以上（最低SDK 30）
- **Root：** Xposedフレームワーク使用時はRoot権限が必要。
- **Xposedフレームワーク：** LSPosedの使用を推奨。
- **[新機能] Root/Xposed不要の位置情報シミュレーション機能**

## インストールとLSPosedスコープ設定

1. Location Joystick APKをインストール。
2. Xposedマネージャー（例：LSPosed）を開く。

3. **Location Joystick** モジュールを有効にします。  
4. **重要：** LSPosedでスコープを設定します：  
    - **Android-System**（必ずチェック、GNSSとシステムレベルの位置情報偽装用）。  
    - **対象アプリ**（例：Pokémon GO、地図アプリなど）。  
5. デバイスを再起動します（LSPosed使用時は対象アプリとSystem UIを強制停止しても可）。  
6. Location Joystickを開き、必要な権限（オーバーレイ、位置情報）を付与します。  

## 使用方法  

1. アプリを開き、地図上で開始位置を設定します。  
2. シミュレーションパラメータ（速度、精度など）を設定します。  
3. サービスを開始してジョイスティックのオーバーレイを表示します。  
4. 対象アプリを開き、ジョイスティックで移動操作を行います。  

## 免責事項  

本ツールは学習および開発目的のみに使用してください。使用に伴うリスクは自己責任でお願いします。  

## ライセンス  

ライセンスの詳細は [LICENSE](LICENSE) ファイルをご参照ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-15

---