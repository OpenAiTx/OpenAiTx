### English | [中文](https://raw.githubusercontent.com/lookoutldz/easy-requester/main/README-zh.md)

# Easy Requester

Easy Requester est une bibliothèque cliente HTTP légère en Java/Kotlin basée sur OkHttp3, offrant une API simple et facile à utiliser pour l'envoi de requêtes HTTP.

---
<div align="center">

[![Maven Central](https://img.shields.io/maven-central/v/io.github.lookoutldz/easy-requester.svg)](https://central.sonatype.com/artifact/io.github.lookoutldz/easy-requester)
[![GitHub](https://img.shields.io/github/license/lookoutldz/easy-requester.svg)](https://github.com/lookoutldz/easy-requester/blob/main/LICENSE)
[![GitHub stars](https://img.shields.io/github/stars/lookoutldz/easy-requester.svg?style=social)](https://github.com/lookoutldz/easy-requester)

</div>

---

## Fonctionnalités

- Conception d'API claire, facile à utiliser
- Support des requêtes HTTP synchrones
- Paramètres, en-têtes et cookies personnalisés pour les requêtes
- Sérialisation et désérialisation automatiques des données JSON (avec Jackson)
- Mapping automatique pour les classes de données Kotlin
- Gestion personnalisée des réponses et des exceptions
- Pattern builder avec interface fluide
- Style de programmation fonctionnelle avec des fonctions d'ordre supérieur Kotlin

## Installation

### Maven

Ajoutez la dépendance suivante à votre fichier `pom.xml` :

```xml
<dependency>
    <groupId>io.github.lookoutldz</groupId>
    <artifactId>easy-requester</artifactId>
    <version>2.3.3</version>
</dependency>
```

### Gradle

Ajoutez la dépendance suivante à votre fichier `build.gradle` :

```groovy
implementation 'io.github.lookoutldz:easy-requester:2.3.3'
```

Ou ajoutez la dépendance suivante à votre fichier `build.gradle.kts` si vous utilisez Kotlin DSL :

```kotlin
implementation("io.github.lookoutldz:easy-requester:2.3.3")
```

## Démarrage rapide

### Utilisation de base

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

### Ajout de paramètres de requête

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

### Ajout d’en-têtes et de cookies

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

### Gestion personnalisée des exceptions

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

### Gestion des réponses brutes

```kotlin
EasyHttpGet.doRequestRaw(url = "https://api.example.com") { response ->
    println("Status code: ${response.code}")
    println("Headers: ${response.headers}")
    println("Body: ${response.body?.string()}")
}
```

### Utilisation du modèle Builder

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

### ObjectMapper personnalisé

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

## Utilisation avancée

### Gestion personnalisée des réponses

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

### OkHttpClient personnalisé

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

1. Lors de la gestion des classes de données Kotlin, assurez-vous d'utiliser un ObjectMapper avec le module Kotlin :
   ```kotlin
   ObjectMapper().registerKotlinModule()
   ```

2. Par défaut, la bibliothèque détecte automatiquement si le module Kotlin est nécessaire, mais dans certains cas, vous devrez peut-être le spécifier manuellement.

3. Toutes les requêtes sont synchrones. Si vous avez besoin d'opérations asynchrones, envisagez de les exécuter dans des coroutines ou des threads.

## Licence

[Licence MIT](./LICENSE)

## Contribution

Les Pull Requests et les Issues sont les bienvenues !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---