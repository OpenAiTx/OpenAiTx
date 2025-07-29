# httpc
httpcは、最小限のコードで関数ベースのAPIを構築し、エンドツーエンドの型安全性を実現するJavaScript/TypeScriptフレームワークです。
- [ドキュメントとチュートリアル](https://httpc.dev/docs)
- [コミュニティ](https://httpc.dev/discord)
- [問題報告と機能リクエスト](https://httpc.dev/issues)

## クイックガイド
関数を書いてエクスポートするだけです。サーバーがそれらをどう実行するかを心配する必要はありません。
```ts
function add(a: number, b: number) {
    return a + b;
}

function greet(name: string) {
    return `Hello ${name}`;
}

export default {
    add,
    greet,
}
```
クライアントからは、通常のJavaScript関数のように自然な構文でサーバー関数を呼び出すことができます。

```ts
import createClient from "@your-package/api-client";

const client = createClient({
    endpoint: "http://api.domain.com"
});

let result = await client.add(1, 2);
// result: 3

let message = await client.greet("Edith");
// message: "Hello Edith"
```
## 主要原則
**httpc** は標準のHTTPプロトコルの抽象化です。**httpc** を使うと、HTTPの動詞やヘッダー、リソースパス、データのシリアライズではなく、関数、引数、戻り値でAPIを構築できます。

**httpc** フレームワークは、基盤となるHTTPの複雑さを隠しつつ、重要な関数ロジックに集中できるようにします。


## 主な機能
### ミドルウェア
共通のロジックをミドルウェアで実行します。

```ts
import { httpCall } from "@httpc/server";

const getPostById = httpCall(
    Authenticated(),    // <-- authentication check
    Validate(String),   // <-- parameters validation
    Cache("5m"),        // <-- result caching
    async (postId: string) => {
        const post = await db.select("posts").where("id", postId);
        if (!post) {
            throw new NotFoundError();
        }

        return post;
    }
);
```

### コンテキストの遍在性
アプリケーション内のどこからでもリクエストコンテキストにアクセスできます。ハンドラー、ミドルウェア、サービスロジックのいずれであっても、パラメーターを渡す必要なく常にコンテキストが利用可能です。
```ts
async function getPosts() {
    const { user } = useContext();

    let category = "news";
    if (user) {
        category = user.preferredCategory;
        trace("Getting user preferred posts");
    }
    
    return await db.select("posts").where("category", category);
}

function trace(message: string) {
    const { requestId } = useContext();
    console.log(`[req:${requestId}] ${message}`);
}
```

### フック
フックはリクエストコンテキストに関する共通のロジックをカプセル化します。慣例として、フックは `use` プレフィックスを採用します。
```ts
async function addNewComment(postId: string, message: string) {
    const user = useUser();

    if (!useIsAuthorized("comment:create")) {
        throw new ForbiddenError("Cannot add comments");
    }

    return await db.createComment({
        userId: user.id,
        postId,
        message
    });
}
```
**@httpc/kit** は、データのキャッシュ、認証チェックの実行、トランザクションの処理など、いくつかの組み込みフックを提供します。

### サーバーレス
Vercel、AWS Lambda、Netlify Functionsなどのサーバーレス環境内に完全な **httpc** API をホストできます。
これにより、API全体を処理する単一のサーバーレス関数をデプロイする利点があります。

例えばVercelを使うと、すべてのAPI関数を公開できます:
```ts
//file: api/index.ts

import { createHttpCVercelAdapter } from "@httpc/adapter-vercel";
import calls from "../calls";

export default createHttpCVercelAdapter({
    calls,
    log: "info"
});
```

次に、完全な型チェックを行いながらページからAPI関数を呼び出すことができます：
```ts
//file: pages/home.tsx

import { createClient, ClientDef } from "@httpc/client";
import { useQuery, useMutation } from "react-query";
import type calls from "../calls"; // <-- import calls definition

// create a typed client
const client = createClient<ClientDef<typeof calls>>();

export default function Home() {
  const posts = useQuery(["posts"], () => client.posts.getLatest());

  return (
    <div class="container">
      {posts.data.map(post =>
        <div class="post">
          <h2>{post.title}</h2>
          <p>{post.text}</p>
        </div>
      )}
    </div>
  );
}
```    

### 広範な型安全性
組み込みオブジェクトをニーズに合わせてカスタマイズしながら、オートコンプリートと型チェックを維持します。

リクエストコンテキストを拡張できます：
```ts
/// <reference types="@httpc/kit/env" />

interface IHttpCContext {
    // example custom property
    environment: string

    // other custom properties here
    // ...
}
```
拡張可能なエンティティは多数あります。例えば、ユーザーオブジェクトをカスタムプロパティで再定義することができます：
```ts
interface IUser {
    firstName: string
    lastName: string
}
```
組み込み関数とフックはカスタム定義を取得し、型チェック付きで使用できるようにします。
```ts
const { firstName } = useUser();
```

### カスタムクライアント生成
**@httpc/cli** を使うと、API専用のクライアントを生成できます。生成されたクライアントは型安全性を保証し、開発者が馴染みのある自然な構文で快適に操作できます。
```ts
const user = await client.users.search("some@email.com");
const posts = await client.posts.getByUser(user.id);
const newComment = await client.posts.addComment(posts[0].id, {
    text: "Hello",
    userId: user.id
});
```
### httpc を超えて
httpc サーバーは関数呼び出しに限定されません。ブラウザのフォーム送信、ウェブフックのコールバック、標準的なリダイレクト…一般に、あらゆる HTTP リクエストを処理できます。`Parsers`（多数の組み込みがあります）を使うことで、サーバーがリクエストを処理する方法をカスタマイズできます。

標準的な HTTP リクエストの処理は、クライアントを制御できないシナリオで不可欠です。**httpc サーバー**は、関数と一般的な HTTP リクエストの両方に応答できます。


## httpc ファミリー
**@httpc/server**: 標準の HTTP プロトコル上で関数呼び出しを可能にする httpc コアコンポーネント

**@httpc/client**: httpc サーバーが公開する関数と安全に対話するために利用者が使う型付きインターフェース

**@httpc/kit**: 認証、検証、キャッシュ、ロギングなどの一般的なユースケースやビジネス課題を管理するための豊富な組み込みコンポーネントのツールボックス

**@httpc/cli**: プロジェクトのセットアップ、クライアントの生成、バージョン管理、一般的なタスク支援のためのコマンド群

**@httpc/adapter-\***: vercel、netlify functions、aws lambda などの環境内で httpc API をホストするための様々な[アダプター](https://httpc.dev/docs/adapters)


## プロジェクトの状況
**httpc** は実験的です。まだ初期段階にあります。試してみたり、趣味のプロジェクトで採用したりできますが、本番環境にはまだ適していません。
<br />
API はまだ安定していません。破壊的な変更が発生する可能性があります。
<br />
**httpc** は活発に開発中です。将来の機能については[変更履歴](https://httpc.dev/changelog)や[ロードマップ](https://httpc.dev/roadmap)を参照してください。


## 参加方法
### コミュニティ
[Discord](https://httpc.dev/discord)に参加して開発を追いかけたり、貢献について議論したり、サポートを受けたり、助けを求めたりできます。[Github discussion](https://httpc.dev/discuss)への参加も歓迎です。

### イシューの提出
バグ、機能要望、提案などは[イシューを提出](https://httpc.dev/issues/new)してください。すべてのイシューは[Github](https://httpc.dev/issues)で閲覧可能です。

### コントリビューション
すべての貢献を歓迎します。PR、イシュー、フィードバックはありがたいです。[コントリビューションガイド](https://httpc.dev/contribute)をご覧ください。


## ライセンス
MIT © [Giuseppe La Torre](https://github.com/giuseppelt)




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---