# Chromeブラウザ拡張機能【Hurry home】、毎日退社時間まであとどれくらいかを計算します
## 気に入ったら右上の `Star` をクリックして星をひとつください~~~

備考：
```
目前收到的issues功能已收到，计划准备重构，Created：20201130 
```
## Chrome公式サイト プラグインダウンロード先:

  chromeストア先：  [ダウンロードはこちら](https://chrome.google.com/webstore/detail/hurry-home-%E4%B8%8B%E7%8F%AD%E5%9B%9E%E5%AE%B6/ndccpjjadppbehafiojmiknfihpmaodj?hl=zh-CN&authuser=0)




### インストールチュートリアル

1. #### 動画デモ先：[bilibili 動画インストールデモ先](http://xianbai.me/learn-md/article/syntax/links.html)   未処理

2. #### インストールドキュメント： [クリックして開く](https://github.com/sbjim/go-home/blob/master/Hurry%20home%20%20%E5%AE%89%E8%A3%85%E6%89%8B%E5%86%8C.md)

   

## 今回の更新説明：

今回の更新は基本的に底層アルゴリズムを書き直し、monent.js、jquery、bootstrap3 サードパーティライブラリを導入

1.  [√] 出退勤時間のカスタマイズ可能
2.  [√] 退勤までの残り時間表示
3.  [√] 週末までの残り時間表示
4.  [√] 月末までの残り時間表示
5.  [√] 週休二日制、単休の週末タイプ追加
6.  [ x ] 給料支払日追加 - 未完成

予定バージョンアップ v2.1.1：

  + 退勤10分前に通知を送信   ユーザーに退勤時間が近いことを知らせる
  




## インターフェーススクリーンショット

![NDOaP1.png](https://s1.ax1x.com/2020/06/26/NDOaP1.png)
![NDOd8x.png](https://s1.ax1x.com/2020/06/26/NDOd8x.png)
![NDON5R.png](https://s1.ax1x.com/2020/06/26/NDON5R.png)
![NDOta9.png](https://s1.ax1x.com/2020/06/26/NDOta9.png)



### プラグイン説明
 + デフォルトの出勤時間は9:00
 + デフォルトの退勤時間は18:00
 + デフォルトの週末タイプは週休二日制


### 新バージョン更新説明
 + moment js 日付フレームワークを導入
 + 底層の日時計算を最適化
 + 出退勤時間のカスタマイズを追加
 + 週末距離タイプを追加



## 終わりに


```
========= version 2.1.1更新 2020/7/9=====
修正 一个隐藏bug，如果HTML中与插件HTML的html - id 出现冲突  -  修复


version 2.1
修复距离月底为负数



Version 2.0
当前版本为2.0，如遇到Bug，请提出Issues。
感谢。
Created By:jim 2020/6/21

===============================================================

Version 1.0
Created By:jim 2020/6/9



```

![visitor badge](https://visitor-badge.glitch.me/badge?page_id=sb.jim.-go-home-.github.2020.06.26)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---