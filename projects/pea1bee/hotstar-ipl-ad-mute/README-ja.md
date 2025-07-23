![HOTSTAR IPL AD Muter](https://raw.githubusercontent.com/pea1bee/hotstar-ipl-ad-mute/main/chrome/128.png?raw=true) 
# Hotstar 広告ミュート

この小さなブラウザ拡張機能は、Hotstarの広告トラッキングピクセルを傍受することで、IPLのようなHotstarのライブスポーツストリーム内の特定の広告を自動的にミュートします。広告識別子から広告の長さを推測して、ミュートする時間も動的に決定します。

以下の広告を標準でミュートし、耳を休ませます：**Parle Marie、Vimal Elaichi、Kamla Pasand、My11 Circle、Poker Baazi、Policy Bazaar**。

注意：このブラウザアドオンは個人用に作成したもので、今後現在の広告ミュートリストから広告の追加や削除を行う可能性があります。リポジトリをフォークして独自のカスタマイズを追加するか、カスタマイズセクションを参照して独自の広告ミュートリストを追加してください。

---

## インストール

 **このリポジトリをコンピュータにクローン** してください 

   ```bash
   git clone https://github.com/pea1bee/hotstar-ipl-ad-mute
   ```

   
   （または、ここからzipファイルをダウンロードできます：https://github.com/pea1bee/hotstar-ipl-ad-mute/archive/refs/heads/main.zip）

## Google Chromeのインストール

1. **Chromeを開き**、`chrome://extensions/`にアクセスします
2. 右上の**デベロッパーモードを有効にする**（まだ有効でない場合）
3. **「パッケージ化されていない拡張機能を読み込む」**をクリック
4. `hotstar-ipl-ad-mute`フォルダ内の`chrome`フォルダを選択
5. ライブスポーツ配信中の広告がミュートされるのをお楽しみください！

注意：**Microsoft Edge**や**Brave**など他のChromiumベースのブラウザの場合も同様の手順です。URLを`edge://extensions/`や`brave://extensions/`に変更してください。

## Mozilla Firefoxのインストール
1. **Firefoxを開き**、`about:debugging`にアクセス
2. **このFirefox**をクリック
3. **一時的なアドオンを読み込む**をクリック
4. `hotstar-ipl-ad-mute/firefox`フォルダ内の`manifest.json`ファイルを選択
5. ライブスポーツ配信中の広告がミュートされるのをお楽しみください！

注意：拡張機能はインストールされ、そのまま残ります。削除するかFirefoxを再起動するまで有効です。

---

## カスタマイズ


### すべての広告をミュート
`background.js`内の`MUTE_ALL_ADS`変数を`true`に設定すると、すべての広告がミュートされます。

### 広告IDによるミュート
`background.js`の`targetAdIds`配列を編集して、ミュートする広告をカスタマイズできます。  
新しい広告キーワードを追加するには：


```js
const targetAdIds = [
  "PARLE_MARIE",
  "KAMLA_PASAND",
  "DREAM11",
  // Add your own here
];
```
### 広告識別子を見つける手順（Google Chrome）：
1. **Chromeを開き**、拡張機能ページ `chrome://extensions/` にアクセスします
2. `Hotstar IPL Ad Muter` 拡張機能を見つけて選択し、「詳細」をクリックします
3. 「Inspect views」とラベル付けされたセクションをクリックします
4. **IPLライブストリーム中に**、コンソールログで `Ad detected:` に続いて `adName` を探します
5. ミュートしたい広告識別子の全体または固有部分を `background.js` の `targetAdIds` 配列に追加します

または、ブラウザのデベロッパーツールを開き、ライブスポーツストリーム中の**ネットワークタブ**で `https://bifrost-api.hotstar.com/v1/events/track/ct_impression` で始まるURLを探し、`adName` クエリパラメータから広告識別子を取得することもできます。

---


## 注意点
- 放送局が次のオーバー開始前にもう一つ広告を挿入しようとすることがあります。広告が急に中断された場合、拡張機能がタブのミュートを解除するまで数秒間ライブ映像がミュートされたままになることがあります
- Hotstarが現在のトラッキングピクセルのURLを変更したり、広告識別子の形式やキーワードを変更した場合、この拡張機能が動作しなくなる可能性があります

## ライセンス

MIT © 2025



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---