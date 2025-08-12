### English | [中文](https://raw.githubusercontent.com/lookoutldz/easy-requester/main/README-zh.md)

# Easy Requester

Easy Requester es una biblioteca ligera de cliente HTTP para Java/Kotlin construida sobre OkHttp3, que proporciona una API simple y fácil de usar para enviar solicitudes HTTP.

---
<div align="center">

[![Maven Central](https://img.shields.io/maven-central/v/io.github.lookoutldz/easy-requester.svg)](https://central.sonatype.com/artifact/io.github.lookoutldz/easy-requester)
[![GitHub](https://img.shields.io/github/license/lookoutldz/easy-requester.svg)](https://github.com/lookoutldz/easy-requester/blob/main/LICENSE)
[![GitHub stars](https://img.shields.io/github/stars/lookoutldz/easy-requester.svg?style=social)](https://github.com/lookoutldz/easy-requester)

</div>

---

## Características

- Diseño de API limpio, fácil de usar
- Soporte para solicitudes HTTP síncronas
- Parámetros personalizados de solicitud, encabezados y cookies
- Serialización y deserialización automática de datos JSON (usando Jackson)
- Mapeo automático para clases de datos Kotlin
- Manejo personalizado de respuestas y excepciones
- Patrón builder con interfaz fluida
- Estilo de programación funcional con funciones de orden superior de Kotlin

## Instalación

### Maven

Agrega la siguiente dependencia a tu archivo `pom.xml`:

```xml
<dependency>
    <groupId>io.github.lookoutldz</groupId>
    <artifactId>easy-requester</artifactId>
    <version>2.3.3</version>
</dependency>
```

### Gradle

Agrega la siguiente dependencia a tu archivo `build.gradle`:

```groovy
implementation 'io.github.lookoutldz:easy-requester:2.3.3'
```
O agregue la siguiente dependencia a su archivo `build.gradle.kts` si está utilizando Kotlin DSL:


```kotlin
implementation("io.github.lookoutldz:easy-requester:2.3.3")
```

## Inicio Rápido

### Uso Básico

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

### Añadiendo Parámetros de Solicitud

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

### Añadiendo Encabezados y Cookies

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

### Manejo Personalizado de Excepciones

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

### Manejo de Respuestas en Crudo

```kotlin
EasyHttpGet.doRequestRaw(url = "https://api.example.com") { response ->
    println("Status code: ${response.code}")
    println("Headers: ${response.headers}")
    println("Body: ${response.body?.string()}")
}
```

### Uso del patrón Builder

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

### ObjectMapper personalizado

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

## Uso Avanzado

### Manejo Personalizado de Respuestas

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

### OkHttpClient Personalizado

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

## Notas

1. Al manejar clases de datos de Kotlin, asegúrate de usar un ObjectMapper con el módulo de Kotlin:
   ```kotlin
   ObjectMapper().registerKotlinModule()
   ```
2. Por defecto, la biblioteca detecta automáticamente si se necesita el módulo Kotlin, pero en algunos casos, puede que necesite especificarlo manualmente.

3. Todas las solicitudes son síncronas. Si necesita operaciones asíncronas, considere ejecutarlas en corutinas o hilos.

## Licencia

[Licencia MIT](./LICENSE)

## Contribuciones

¡Pull Requests y Issues son bienvenidos!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---