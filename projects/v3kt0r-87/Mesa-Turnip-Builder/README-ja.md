# Freedreno Turnip ビルダー 

## Stable / RC Mesa  + Android NDK <br> 安定性のためにこのビルドを使用してください ✅ 

**MAGISK/KERNELSU または エミュレーター**向けの turnip ドライバーをビルドするシンプルな Bash スクリプトです。

# 新着情報 : 🔥

**[こちらをクリック](//github.com/v3kt0r-87/Mesa-Turnip-Builder/blob/main/UPDATES.md)**
 
## ローカルでのビルド方法 🤔

このリポジトリをクローンし、**BASH** を使ってビルドしてください 

``` 
bash build-turnip.sh
``` 
以下の[Notes](//github.com/v3kt0r-87/Mesa-Turnip-Builder?tab=readme-ov-file#notes-)セクションもご覧ください

# アプリ互換性

| 名前                                            | 状態   | 備考                                                                                                                     |
|-------------------------------------------------|--------|---------------------------------------------------------------------------------------------------------------------------|
| 3D Mark                                         | ✅     |                                                                                                                           |
| GRID™ Autosport                                 | ✅     | [V3KT0R-87](//github.com/V3KT0R-87)によるテスト<br>動作中。(60fps)                                                        |
| SpongeBob SquarePants Battle For Bikini Bottom  | ✅     | [V3KT0R-87](//github.com/V3KT0R-87)によるテスト<br>動作中。(30 - 45 fps)                                                   |
| Carx Street                                     | ✅     | [V3KT0R-87](//github.com/V3KT0R-87)によるテスト<br>動作中。(30 - 45 fps)                                                   |
| Dolphin Emulator                                | ✅     | [V3KT0R-87](//github.com/V3KT0R-87)によるテスト<br>動作中。                                                               |
| PPSSPP                                          | ✅     | [V3KT0R-87](//github.com/V3KT0R-87)によるテスト<br>動作中。                                                               |
| EggNS                                           | ✅     | [V3KT0R-87](//github.com/V3KT0R-87)によるテスト<br>動作中。                                                               |
| ANGLE (com.android.angle)                       | ✅     |                                                                                                                           |
| GTA Triology-Definitive Edition                 | ✅     | [@Ryder_7777](//t.me/Ryder_7777)によるテスト<br>動作中、パフォーマンス不良。                                              |
| Call of Duty WarZone Mobile                     | ✅     | [@SeniorFurry](//t.me/SeniorFurry)によるテスト<br>動作中、テクスチャバグ、パフォーマンス不良。                              |
| Hitman Blood Money : Reprisal                   | ✅     | [@V3KT0R-87](//github.com/V3KT0R-87)によるテスト<br>動作中、60 fps 中画質。                                                |


### 注意事項 :

### 重要：完全なVulkan 1.4サポートにはAndroid 15 (SDK 35)が必要です

## Ubuntu 24.04またはそれをベースにした他のディストリビューションを使用してください

**進行前に安定したインターネット接続があることを確認してください**

**ISPが速度制限を行う場合はVPNを使用してください**

Androidのバージョンが``14``以上であることを確認してください。そうでないとインストールできません

インストール前に最新の**MAGISK / KERNELSU**があることを確認してください


# クレジット 🙏

### このプロジェクトは以下の素晴らしい方々の助けなしには実現できませんでした：
 
 **[@MrMiy4mo](//github.com/ilhan-athn7)** に感謝します。turnipビルドスクリプトを作成し、私がそれを改良し学ぶことを許可してくれました。

 
 **[@Mesa3D チーム](//gitlab.freedesktop.org/mesa/mesa)** に感謝します。素晴らしいドライバーを提供していただき、私たちのデバイス性能の向上に役立てることができました。

 **[Adreno ドライバーサポートグループ](//t.me/adreno_driver)** に感謝します。テストとベンチマークの共有を行っていただきました。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-27

---