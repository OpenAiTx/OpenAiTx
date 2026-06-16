# RemoteVideoCam

Remote Video Camは、2台のデバイスがローカル接続を介して高品質なビデオとオーディオを相互にストリーミングできるオープンソースのAndroidアプリケーションです。ベビーモニター、DIYセキュリティカメラ、またはトランシーバーとして使用する場合でも、RemoteVideoCamはインターネットアクセスやサードパーティのサーバーを必要としない、安全でオフライン優先のソリューションを提供します。

## ✨ 機能

- **ゼロコンフィギュレーション**：デバイスは自動的に互いを検出し接続します。
- **堅牢な接続**：利用可能な最適な接続方法を自動的に交渉します：
  - **ローカルネットワーク（LAN）**：既存のWi-Fiネットワークを使用します。
  - **Wi-Fi Aware / Wi-Fi Direct**：アクセスポイントなしでデバイスを直接接続します（オフライン）。
- **安全かつプライベート**：外部サーバーなし。クラウドなし。ビデオとオーディオのストリームはローカル環境から一切外に出ません。
- **モダンなUI**：**Jetpack Compose**と**Material 3**で構築されており、美しく、応答性が高く、直感的なインターフェースを動的なカラーで提供します。
- **2つのモード**：
  - **カメラモード**：放送側として動作します。
  - **ディスプレイモード**：他のデバイスからの映像を表示します。
    - *ビデオを水平方向に反転する「ミラー」オプションを含みます。*
  - *注：両方のデバイスがディスプレイモードにして相互に映像を見ることも可能です（双方向）。*
- **オーディオサポート**：相手側で起きていることを聞くことができます。

## ⚠️ 重要な注意事項

**医療機器ではありません**：RemoteVideoCamはモニタリング（例：ベビーモニター）に役立つ可能性がありますが、認定された医療機器ではありません。  
- ネットワーク干渉により映像がフリーズすることがあります。  
- 代替のモニタリング方法を必ず用意してください。  
- **ヒント**：映像がライブであることを簡単に確認するために、秒針付きの時計など動く物体を画面内に置いてください。

## 🛠️ 技術スタック

- **言語**：Kotlin  
- **UIフレームワーク**：Jetpack Compose（Material 3）  
- **ビデオ/オーディオ**：WebRTC（ローカル交渉）  
- **コンピュータビジョン**：OpenCV（特定の画像処理タスクに使用）  
- **アーキテクチャ**：MVVMとリアクティブデータストリーム（RxJava/RxAndroid）

## 📥 distinct

[<img src="https://fdroid.gitlab.io/artwork/badge/get-it-on.png"
     alt="Get it on F-Droid"
     height="80">](https://f-droid.org/packages/org.avmedia.remotevideocam/)
[<img src="https://play.google.com/intl/en_us/badges/images/generic/en-play-badge.png"
     alt="Google Play で手に入れよう"
     height="80">](https://play.google.com/store/apps/details?id=org.avmedia.remotevideocam)

## 🤝 貢献について

貢献は歓迎します！開発者でRemoteVideoCamの改善を手伝いたい場合は、リポジトリをフォークしてプルリクエストを送ってください。

大きな変更や質問がある場合は、メンテナ `izivkov@gmail.com` までご連絡ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-16

---