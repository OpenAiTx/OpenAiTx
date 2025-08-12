### English | [中文](https://raw.githubusercontent.com/lookoutldz/easy-requester/main/README-zh.md)

# Easy Requester

Easy Requesterは、OkHttp3をベースに構築された軽量なJava/Kotlin HTTPクライアントライブラリで、HTTPリクエストを送信するためのシンプルで使いやすいAPIを提供します。

---
<div align="center">

[![Maven Central](https://img.shields.io/maven-central/v/io.github.lookoutldz/easy-requester.svg)](https://central.sonatype.com/artifact/io.github.lookoutldz/easy-requester)
[![GitHub](https://img.shields.io/github/license/lookoutldz/easy-requester.svg)](https://github.com/lookoutldz/easy-requester/blob/main/LICENSE)
[![GitHub stars](https://img.shields.io/github/stars/lookoutldz/easy-requester.svg?style=social)](https://github.com/lookoutldz/easy-requester)

</div>

---

## 特徴

- クリーンなAPI設計で使いやすい
- 同期HTTPリクエストのサポート
- カスタムリクエストパラメータ、ヘッダー、クッキー
- JSONデータの自動シリアライズとデシリアライズ（Jackson使用）
- Kotlinデータクラスへの自動マッピング
- カスタムレスポンスおよび例外処理
- フルーエントインターフェースを持つビルダーパターン
- Kotlinの高階関数を用いた関数型プログラミングスタイル

## インストール

### Maven

以下の依存関係を`pom.xml`ファイルに追加してください：

```xml
<dependency>
    <groupId>io.github.lookoutldz</groupId>
    <artifactId>easy-requester</artifactId>
    <version>2.3.3</version>
</dependency>
```

### Gradle

`build.gradle` ファイルに以下の依存関係を追加してください:

```groovy
implementation 'io.github.lookoutldz:easy-requester:2.3.3'
```

または、Kotlin DSL を使用している場合は、次の依存関係を `build.gradle.kts` ファイルに追加してください:

```kotlin
implementation("io.github.lookoutldz:easy-requester:2.3.3")
```

## クイックスタート

### 基本的な使い方

```kotlin
// Simplest way - returns a string
EasyHttpGet.doRequestDefault(url = "https://api.example.com") { response ->
    println("Response content: $response")
}

// Using a data class to receive the response
data class User(val id: Int, val name: String)

EasyHttpGet.doRequest<User>(url = "https://api.example.com/users/1") { user ->
    println("Username: ${user?.name}")
}
```

### リクエストパラメータの追加

```kotlin
// Adding query parameters
val params = mapOf("page" to "1", "limit" to "10")

EasyHttpGet.doRequest<User>(
    url = "https://api.example.com/users",
    params = params
) { users ->
    println("Retrieved ${users?.size} users")
}
```

### ヘッダーとクッキーの追加

```kotlin
val headers = mapOf("Authorization" to "Bearer token123")
val cookies = mapOf("sessionId" to "abc123")

EasyHttpGet.doRequest<User>(
    url = "https://api.example.com/users",
    headers = headers,
    cookies = cookies
) { user ->
    println("User info: $user")
}
```

### カスタム例外処理

```kotlin
EasyHttpGet.doRequest<User>(
    url = "https://api.example.com/users/1",
    exceptionHandler = { throwable, request ->
        println("Request failed: ${request.url}, Error: ${throwable?.message}")
        // Handle exceptions here, e.g., retry or log
    }
) { user ->
    println("User info: $user")
}
```

### 生のレスポンスの処理

```kotlin
EasyHttpGet.doRequestRaw(url = "https://api.example.com") { response ->
    println("Status code: ${response.code}")
    println("Headers: ${response.headers}")
    println("Body: ${response.body?.string()}")
}
```

### ビルダーパターンの使用方法

```kotlin
// Using Class to specify return type
EasyHttpGet
    .Builder(User::class.java)
    .setUrl("https://api.example.com/users/1")
    .setHeaders(mapOf("Authorization" to "Bearer token123"))
    .onSuccess { user ->
        println("Username: ${user?.name}")
    }
    .onException { throwable, request ->
        println("Request failed: ${throwable.message}")
    }
    .build()
    .execute()

// Using TypeReference to handle generic types
EasyHttpGet
    .Builder(object : TypeReference<List<User>>() {})
    .setUrl("https://api.example.com/users")
    .setParams(mapOf("page" to "1"))
    .onSuccess { users ->
        println("User list: $users")
    }
    .build()
    .execute()
```

### カスタム ObjectMapper

```kotlin
val objectMapper = ObjectMapper().registerKotlinModule()
// Configure ObjectMapper here, e.g., date format, serialization options, etc.

EasyHttpGet.doRequest<User>(
    url = "https://api.example.com/users/1",
    objectMapper = objectMapper
) { user ->
    println("User info: $user")
}
```

## 高度な使用法

### カスタムレスポンス処理

```kotlin
EasyHttpGet.doRequest<User>(
    url = "https://api.example.com/users/1",
    responseSuccessHandler = { response ->
        // Handle successful responses
        println("Success: ${response.code}")
        // Execute custom logic here, e.g., extract specific headers
    },
    responseFailureHandler = { response ->
        // Handle failed responses
        println("Failure: ${response.code} - ${response.message}")
    }
) { user ->
    println("User info: $user")
}
```

### カスタム OkHttpClient

```kotlin
val okHttpClient = OkHttpClient.Builder()
    .connectTimeout(30, TimeUnit.SECONDS)
    .readTimeout(30, TimeUnit.SECONDS)
    .writeTimeout(30, TimeUnit.SECONDS)
    .build()

EasyHttpGet.doRequest<User>(
    url = "https://api.example.com/users/1",
    okHttpClient = okHttpClient
) { user ->
    println("User info: $user")
}
```

## 注意事項

1. Kotlinのデータクラスを扱う場合は、Kotlinモジュールを組み込んだObjectMapperを使用してください:
   ```kotlin
   ObjectMapper().registerKotlinModule()
   ```
2. デフォルトでは、ライブラリはKotlinモジュールが必要かどうかを自動的に検出しますが、場合によっては手動で指定する必要があります。

3. すべてのリクエストは同期的です。非同期処理が必要な場合は、コルーチンやスレッドで実行することを検討してください。

## ライセンス

[MIT ライセンス](./LICENSE)

## コントリビュート

プルリクエストと問題報告は歓迎します！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---