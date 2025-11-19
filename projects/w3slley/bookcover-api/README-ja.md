# インターネットから書籍カバーを取得するためのAPI。

これはGoodreadsから書籍のカバー画像を取得するシンプルなAPIです。書籍のタイトルと著者名、またはISBN番号を使ってカバーを検索できます。アプリケーションで使用できるカバー画像への直接URLを返します。

## ドキュメント

### GET /bookcover

書籍のタイトルと著者名を使って書籍カバーを検索します。

**必須パラメータ:**
- `book_title` (string): 書籍のタイトル
- `author_name` (string): 書籍の著者名

**リクエスト例:**
```bash
curl -X GET "https://bookcover.longitood.com/bookcover?book_title=The+Pale+Blue+Dot&author_name=Carl+Sagan"
```

**例示応答：**
```json
{
  "url": "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1388620656i/55030.jpg"
}
```

### GET /bookcover/:isbn

ISBN-13番号を使用して書籍の表紙を検索します。

**リクエスト例：**
```bash
curl -X GET "https://bookcover.longitood.com/bookcover/978-0345376596"
```

**例示応答：**
```json
{
  "url": "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1500191671i/61663.jpg"
}
```

## 仕組み

このAPIは、Goodreadsから書籍のカバー画像を2つの異なる方法で取得します：

1. **タイトルと著者名で検索**
   - 書籍のタイトルと著者名を入力として受け取る
   - Goodreadsを検索し、一致する書籍を見つける
   - 高品質なカバー画像のURLを抽出する
   - 将来のリクエストを高速化するために結果をキャッシュする

2. **ISBN-13で検索**
   - 13桁のISBN番号を受け取る
   - Goodreadsで直接照会を行う
   - 書籍のカバーURLを返す
   - 成功した結果もキャッシュする


APIはJSON形式で明確なエラーメッセージを提供します：
- 400 Bad Request: パラメータの欠如または無効なISBN
- 404 Not Found: 一致する書籍カバーが見つからない
- すべてのレスポンスには適切なCORSヘッダーが含まれる


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-19

---