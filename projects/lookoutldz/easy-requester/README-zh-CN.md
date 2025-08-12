### English | [中文](https://raw.githubusercontent.com/lookoutldz/easy-requester/main/README-zh.md)

# Easy Requester

Easy Requester 是一个基于 OkHttp3 构建的轻量级 Java/Kotlin HTTP 客户端库，提供简单易用的 API 用于发送 HTTP 请求。

---
<div align="center">

[![Maven Central](https://img.shields.io/maven-central/v/io.github.lookoutldz/easy-requester.svg)](https://central.sonatype.com/artifact/io.github.lookoutldz/easy-requester)
[![GitHub](https://img.shields.io/github/license/lookoutldz/easy-requester.svg)](https://github.com/lookoutldz/easy-requester/blob/main/LICENSE)
[![GitHub stars](https://img.shields.io/github/stars/lookoutldz/easy-requester.svg?style=social)](https://github.com/lookoutldz/easy-requester)

</div>

---

## 功能特点

- 清晰的 API 设计，易于使用
- 支持同步 HTTP 请求
- 自定义请求参数、头部和 Cookie
- 自动序列化和反序列化 JSON 数据（使用 Jackson）
- Kotlin 数据类的自动映射
- 自定义响应和异常处理
- 使用流畅接口的构建者模式
- 使用 Kotlin 高阶函数的函数式编程风格

## 安装

### Maven

在你的 `pom.xml` 文件中添加以下依赖：

```xml
<dependency>
    <groupId>io.github.lookoutldz</groupId>
    <artifactId>easy-requester</artifactId>
    <version>2.3.3</version>
</dependency>
```

### Gradle

将以下依赖添加到您的 `build.gradle` 文件中：

```groovy
implementation 'io.github.lookoutldz:easy-requester:2.3.3'
```

或者如果您使用 Kotlin DSL，请将以下依赖项添加到您的 `build.gradle.kts` 文件中：

```kotlin
implementation("io.github.lookoutldz:easy-requester:2.3.3")
```

## 快速开始

### 基本用法

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

### 添加请求参数

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

### 添加头部和Cookie

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

### 自定义异常处理

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

### 处理原始响应

```kotlin
EasyHttpGet.doRequestRaw(url = "https://api.example.com") { response ->
    println("Status code: ${response.code}")
    println("Headers: ${response.headers}")
    println("Body: ${response.body?.string()}")
}
```

### 使用建造者模式

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

### 自定义 ObjectMapper

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

## 高级用法

### 自定义响应处理

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

### 自定义 OkHttpClient

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

## 备注

1. 处理 Kotlin 数据类时，确保使用带有 Kotlin 模块的 ObjectMapper：
   ```kotlin
   ObjectMapper().registerKotlinModule()
   ```
2. 默认情况下，库会自动检测是否需要 Kotlin 模块，但在某些情况下，您可能需要手动指定。

3. 所有请求都是同步的。如果您需要异步操作，建议在协程或线程中执行。

## 许可证

[MIT 许可证](./LICENSE)

## 贡献

欢迎提交拉取请求和问题！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---