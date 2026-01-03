# sunsetr

<p align="center">
    <img src="https://raw.githubusercontent.com/psi4j/sunsetr/main/.github/assets/logo.png" alt="sunsetr ロゴ" width="144" />
</p>
<p align="center">
    Hyprland、Niri、そしてすべてのWayland向け自動ブルーライトフィルター
</p>

<p align="center">
  <a href="https://psi4j.github.io/sunsetr/"><img src="https://img.shields.io/badge/Documentation-mdBook-blue" alt="ドキュメント"></a>
  <a href="https://github.com/psi4j/sunsetr/blob/main/LICENSE"><img src="https://img.shields.io/github/license/psi4j/sunsetr" alt="ライセンス"></a>
  <a href="https://github.com/psi4j/sunsetr/releases"><img src="https://img.shields.io/github/v/release/psi4j/sunsetr" alt="リリース"></a>
</p>

<p align="center">
  <a href="https://psi4j.github.io/sunsetr/installation.html">インストール</a> | <a href="https://psi4j.github.io/sunsetr/quick-start.html">クイックスタート</a> | <a href="https://psi4j.github.io/sunsetr/configuration/">設定</a> | <a href="https://psi4j.github.io/sunsetr/commands/">コマンド</a>
</p>

![この画像はsunsetrの効果をシミュレートするシェーダーを使って撮影されました](https://raw.githubusercontent.com/psi4j/sunsetr/main/.github/assets/sunsetr.png)

SunsetrはWaylandコンポジタ向けの自動ブルーライトフィルターです。ニュートラルから暖色系への滑らかな色温度の遷移を自動化し、目の疲れを軽減し睡眠の質を向上させることを目的としています。Sunsetrは位置情報または手動の時間設定に基づいてディスプレイを自動調整します。また、同一の色温度とガンマを無期限に維持したり、ユーザー定義の複数プリセットを切り替えたりすることも可能です。コントローラーはIPCを介してシェルやUIアプリケーションの変更を統合・自動化できます。

## 特徴

- **マルチコンポジタ対応**: Hyprland、Niri、Sway、River、Wayfire、その他のWaylandコンポジタで動作
- **ネイティブHyprland CTMバックエンド**: Hyprland向けの直接的なカラートランスフォーメーションマトリクス対応
- **高度なhyprsunset管理**: hyprsunset（Hyprland）に対してより長く、クリーンで精密な夕焼け・朝焼け遷移を追加
- **滑らかな遷移**: 適応アルゴリズムによる設定可能なフェード効果
- **プリセット管理**: 設定プロファイル間の高速切り替え（例：日中、ゲーム、週末）
- **ホットリロード**: 設定ファイル変更時にライブ更新 - 再起動不要
- **自動化のためのIPC**: スクリプトや外部連携向けのUnixソケットベースIPC
- **位置情報ベースの遷移**: 位置に基づく自動的な日の出・日の入り計算
- **インタラクティブな都市選択**: 世界1万以上の都市から正確な座標を選択可能
- **自動タイムゾーン検出**: ロケーション近似のためにシステムタイムゾーンにフォールバック
- **ユニバーサルWayland対応**: Waylandコンポジタへの直接プロトコル通信
- **スマートデフォルト**: 注意深く調整された設定で初期状態から優れた動作
- **柔軟な設定**: パワーユーザー向けの広範なカスタマイズオプション

## TODO
- [x] AURパッケージの設定
- [x] Nixインストールの利用可能化
- [x] 徐々に移行を実装
- [x] マルチコンポジターWaylandサポート
- [x] 位置情報ベースの移行
- [x] HyprlandネイティブCTMバックエンドの実装
- [x] スクリプティングおよび外部統合のためのIPC実装
- [ ] Fedora Coprインストールの利用可能化
- [ ] Debian/Ubuntuインストールの利用可能化

## 💛 感謝

- wlsunset、hyprsunset、redshiftにインスピレーションを得て
- Hyprlandを可能にしたHyprwmチームに感謝
- 最高のRustベースのWaylandコンポジターを作ったniriチームに感謝
- 強力なプロトコルエコシステムを支えるWaylandコミュニティに感謝



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---