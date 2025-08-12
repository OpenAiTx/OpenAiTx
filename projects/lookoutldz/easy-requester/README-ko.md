### English | [中文](https://raw.githubusercontent.com/lookoutldz/easy-requester/main/README-zh.md)

# Easy Requester

Easy Requester는 OkHttp3 기반으로 구축된 가벼운 Java/Kotlin HTTP 클라이언트 라이브러리로, HTTP 요청을 보내기 위한 간단하고 사용하기 쉬운 API를 제공합니다.

---
<div align="center">

[![Maven Central](https://img.shields.io/maven-central/v/io.github.lookoutldz/easy-requester.svg)](https://central.sonatype.com/artifact/io.github.lookoutldz/easy-requester)
[![GitHub](https://img.shields.io/github/license/lookoutldz/easy-requester.svg)](https://github.com/lookoutldz/easy-requester/blob/main/LICENSE)
[![GitHub stars](https://img.shields.io/github/stars/lookoutldz/easy-requester.svg?style=social)](https://github.com/lookoutldz/easy-requester)

</div>

---

## 특징

- 깔끔한 API 설계, 사용하기 쉬움
- 동기식 HTTP 요청 지원
- 맞춤형 요청 매개변수, 헤더 및 쿠키 지원
- JSON 데이터 자동 직렬화 및 역직렬화(Jackson 사용)
- Kotlin 데이터 클래스 자동 매핑
- 맞춤형 응답 및 예외 처리
- 빌더 패턴과 유창한 인터페이스
- Kotlin 고차 함수와 함께하는 함수형 프로그래밍 스타일

## 설치

### Maven

`pom.xml` 파일에 다음 의존성을 추가하세요:

```xml
<dependency>
    <groupId>io.github.lookoutldz</groupId>
    <artifactId>easy-requester</artifactId>
    <version>2.3.3</version>
</dependency>
```

### Gradle

다음 의존성을 `build.gradle` 파일에 추가하세요:

```groovy
implementation 'io.github.lookoutldz:easy-requester:2.3.3'
```
또는 Kotlin DSL을 사용하는 경우 `build.gradle.kts` 파일에 다음 의존성을 추가하십시오:


```kotlin
implementation("io.github.lookoutldz:easy-requester:2.3.3")
```
## 빠른 시작

### 기본 사용법


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

### 요청 매개변수 추가하기

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

### 헤더 및 쿠키 추가하기

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

### 사용자 정의 예외 처리

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

### 원시 응답 처리

```kotlin
EasyHttpGet.doRequestRaw(url = "https://api.example.com") { response ->
    println("Status code: ${response.code}")
    println("Headers: ${response.headers}")
    println("Body: ${response.body?.string()}")
}
```

### 빌더 패턴 사용하기

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

### 사용자 정의 ObjectMapper

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

## 고급 사용법

### 맞춤 응답 처리

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

### 사용자 지정 OkHttpClient

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

## 참고 사항

1. Kotlin 데이터 클래스를 처리할 때는 Kotlin 모듈이 포함된 ObjectMapper를 사용해야 합니다:
   ```kotlin
   ObjectMapper().registerKotlinModule()
   ```

2. 기본적으로 라이브러리는 Kotlin 모듈이 필요한지 자동으로 감지하지만, 경우에 따라 수동으로 지정해야 할 수도 있습니다.

3. 모든 요청은 동기식입니다. 비동기 작업이 필요하면 코루틴이나 스레드에서 실행하는 것을 고려하세요.

## 라이선스

[MIT 라이선스](./LICENSE)

## 기여

풀 리퀘스트와 이슈는 언제나 환영합니다!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---