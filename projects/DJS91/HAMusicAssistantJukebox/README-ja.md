# <img src="https://raw.githubusercontent.com/DJS91/HAMusicAssistantJukebox/main/logo.png" width="25" height="25"> Music Assistant Jukebox 統合（非推奨）

## お知らせ：この統合はもはや積極的にメンテナンスされていません。

Music Assistant には代わりに使用すべきプラグインがあり、多くの同様の機能を提供しています。  
https://beta.music-assistant.io/plugins/party-mode/ をご覧ください。

---

Home Assistant 統合で、Music Assistant と連携したウェブベースの曲リクエストシステムを提供し、ゲスト向けのインタラクティブなジュークボックス体験を作成します！

![ジュークボックスインターフェース](https://raw.githubusercontent.com/DJS91/HAMusicAssistantJukebox/main/showcase.avifs)

## 機能
- 接続されたすべての Music Assistant プロバイダーにわたるリアルタイム曲検索
- アルバムアートワーク表示を備えたミニマリストのレスポンシブデザイン
- 現在再生中と次に再生予定の曲をリアルタイムで確認可能
- ゲストはログイン不要、URLを共有するだけで利用可能
- Home Assistant エンティティを通じたキュー管理
- リクエストキューが空の場合、自動的にデフォルトのパーティプレイリストをキューに追加
- キューイング頻度を制御（キューのスパムを制限）
- Home Assistant を通じたアクセス制御
- セキュリティのためのアクセストークンの自動取り消し／作成

新機能のリクエストや一般的な議論は、[Discussions / FeatureRequests](https://github.com/DJS91/HAMusicAssistantJukebox/discussions)へどうぞ！

## 前提条件

この統合をインストールする前に、以下を確認してください：  
- [Music Assistant](https://github.com/music-assistant/hass-music-assistant) 統合が導入された Home Assistant インスタンス  
- Home Assistant の Music Assistant サーバーアドオン（別ホストの HA/MA インスタンスは動作しない場合があります）  
- Music Assistant に設定された対応音楽プロバイダー（例：Spotify、Apple Music など）  
- Home Assistant に設定されたメディアプレイヤーエンティティ

## インストール

### HACS（推奨）  
[![Home Assistant インスタンスを開き、Home Assistant Community Store 内でリポジトリを開く](https://my.home-assistant.io/badges/hacs_repository.svg)](https://my.home-assistant.io/redirect/hacs_repository/?owner=DJS91&repository=HAMusicAssistantJukebox&category=Integration)

または
1. このリポジトリをHACSにカスタムリポジトリとして追加します
   - HACS > メニュー > カスタムリポジトリ
   - URL: `https://github.com/DJS91/HAMusicAssistantJukebox`
   - カテゴリ: Integration
2. インストールをクリック
3. Home Assistantを再起動

### 手動インストール
1. 最新リリースをダウンロード
2. `custom_components/music_assistant_jukebox` フォルダをHome Assistantの `custom_components` フォルダにコピー
3. Home Assistantを再起動

## 設定

1. 設定 > デバイスとサービス に移動
2. 「インテグレーションを追加」をクリック
3. 「Music Assistant Jukebox」を検索
4. Music Assistantのインスタンスとメディアプレイヤーエンティティを選択
5. 設定 > オートメーションとシーン > ＋オートメーション作成 に移動
6. リストから「Music Assistant Jukebox Controller」を選択
7. ステップ4で選択した同じメディアプレイヤーエンティティを入力し、Music Assistantのデフォルトプレイリストの名前を入力して保存をクリック

## 使い方
「JukeBox: Allow access」スイッチでジュークボックスをオンにします。

新しい「Music Assistant Jukebox」サイドバーパネルからジュークボックスにアクセスするか、

任意のQRコードエンティティをスキャンするか、

直接ジュークボックスインターフェースにアクセスしてください：
```
http://homeassistant:8123/local/jukebox/jukebox.html
```
## エンティティ
このインテグレーションはHome Assistantに以下のエンティティを追加します：

### スイッチ
- `switch.jukebox_queue`: 曲のキューイングを有効/無効にします（手動操作不要。オートメーションで管理。）
- `switch.jukebox_allow_access`: ジュークボックスインターフェースへのアクセスを有効/無効にします
- `switch.music_assistant_jukebox_jukebox_play_music_on_start`: ジュークボックス起動時にデフォルトプレイリストを自動再生するかどうかをオン/オフします。
  
### 数値
- `number.jukebox_queue_length`: 現在のキューの長さを表示します（手動調整不要、オートメーションで管理）
- `number.music_assistant_jukebox_jukebox_queuing_delay`: ゲストの曲リクエスト間の遅延を秒単位で設定します（0＝オフ）
  
### センサー
- `music_assistant_jukebox_external_qr_code`: ネットワーク外のユーザー向けにダッシュボードで簡単に共有できる外部ジュークボックスUIアクセス用QRコード画像
- `music_assistant_jukebox_internal_qr_code`: ネットワーク内のユーザー向けに簡単に共有できる内部ジュークボックスUIアクセス用QRコード画像

## オートメーションブループリント

このインテグレーションには以下を管理するオートメーションブループリントが含まれています：
- キュー長の追跡
- デフォルトプレイリストのフォールバック
- アクセス制御
- メディアプレーヤー制御

ブループリントの使用方法：
1. 設定 > オートメーションとシーン に移動
2. 「+ オートメーションを作成」をクリック
3. 「Music Assistant Jukebox Controller」を選択
4. 設定：
   - メディアプレーヤー：Music Assistantのメディアプレーヤーを選択
   - デフォルトプレイリスト：フォールバック用プレイリスト名を入力

## クレジット
大きな感謝を：
- [OddPirate](https://github.com/TheOddPirate) さん、統合化への貢献に感謝します。

- [PilaScat](https://github.com/PilaScat) さん、クリーンアップ、磨き上げ、UI改善への貢献に感謝します。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-14

---