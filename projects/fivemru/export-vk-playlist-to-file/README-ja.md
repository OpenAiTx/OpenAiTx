# ВКонтакте（VK）からYandex Musicへの音楽転送方法

VKのプレイリストをテキストファイルにエクスポートし、Yandex Musicにインポートします。
スクリプトは自分のプレイリスト以外でも動作する場合があります。

```quote
Страница импорта в яндекс музыке поменялась на https://music.yandex.ru/newimport
Теперь там вроде можно импортировать через ВК сразу, не проверял.
```

## VKの音楽をテキストファイルにエクスポートする

VKの自分の音楽ページを開き、`F12`を押します。

ページからスクリプトをコピーします
https://raw.githubusercontent.com/fivemru/export-vk-playlist-to-file/main/chrome-snippet.js
VKのページのコンソールに貼り付けて、`Enter`を押します。

*スクリプトはリスト全体が読み込まれるまでページをスクロールし、`vk-playlist.txt`ファイルに保存します*

__スクリーンショット:__
![image](https://user-images.githubusercontent.com/30273470/131132113-f00dc4d0-4bf1-4e96-be4f-5c22ef640695.png)

ファイル内の曲リスト

![image](https://user-images.githubusercontent.com/30273470/131132412-d9f8453f-babd-4d9d-b439-84a9df2ec586.png)

完了。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-03

---