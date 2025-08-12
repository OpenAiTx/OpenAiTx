### English | [中文](https://raw.githubusercontent.com/lookoutldz/easy-requester/main/README-zh.md)

# Easy Requester

Easy Requester is a lightweight Java/Kotlin HTTP client library built on OkHttp3, providing a simple and easy-to-use API for sending HTTP requests.

---
<div align="center">

[![Maven Central](https://img.shields.io/maven-central/v/io.github.lookoutldz/easy-requester.svg)](https://central.sonatype.com/artifact/io.github.lookoutldz/easy-requester)
[![GitHub](https://img.shields.io/github/license/lookoutldz/easy-requester.svg)](https://github.com/lookoutldz/easy-requester/blob/main/LICENSE)
[![GitHub stars](https://img.shields.io/github/stars/lookoutldz/easy-requester.svg?style=social)](https://github.com/lookoutldz/easy-requester)

</div>

---

## Features

- Clean API design, easy to use
- Support for synchronous HTTP requests
- Custom request parameters, headers, and cookies
- Automatic serialization and deserialization of JSON data (using Jackson)
- Automatic mapping for Kotlin data classes
- Custom response and exception handling
- Builder pattern with fluent interface
- Functional programming style with Kotlin higher-order functions

## Installation

### Maven

Add the following dependency to your `pom.xml` file:

```xml
<dependency>
    <groupId>io.github.lookoutldz</groupId>
    <artifactId>easy-requester</artifactId>
    <version>2.3.3</version>
</dependency>
```

### Gradle

Add the following dependency to your `build.gradle` file:

```groovy
implementation 'io.github.lookoutldz:easy-requester:2.3.3'
```

Or add the following dependency to your `build.gradle.kts` file if you are using Kotlin DSL:

```kotlin
implementation("io.github.lookoutldz:easy-requester:2.3.3")
```

## Quick Start

### Basic Usage

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

### Adding Request Parameters

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

### Adding Headers and Cookies

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

### Custom Exception Handling

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

### Handling Raw Responses

```kotlin
EasyHttpGet.doRequestRaw(url = "https://api.example.com") { response ->
    println("Status code: ${response.code}")
    println("Headers: ${response.headers}")
    println("Body: ${response.body?.string()}")
}
```

### Using the Builder Pattern

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

### Custom ObjectMapper

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

## Advanced Usage

### Custom Response Handling

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

### Custom OkHttpClient

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

## Notes

1. When handling Kotlin data classes, ensure you use an ObjectMapper with the Kotlin module:
   ```kotlin
   ObjectMapper().registerKotlinModule()
   ```
2. By default, the library automatically detects if the Kotlin module is needed, but in some cases, you may need to specify it manually.

3. All requests are synchronous. If you need asynchronous operations, consider executing them in coroutines or threads.

## License

[MIT License](./LICENSE)

## Contributing

Pull Requests and Issues are welcome!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---