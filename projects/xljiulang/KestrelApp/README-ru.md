# KestrelApp
Примеры сетевого программирования на основе Kestrel

### 1 Цели проекта
1. Понять, что для сетевого программирования больше не нужно начинать с Socket
2. Понять, что для сетевого программирования больше не нужны сторонние фреймворки (включая Dotnetty)
3. Понять концепцию "telnet через websocket через tls через xxx частное шифрование через tcp" в сетевом программировании-матрёшке
4. Возможность разрабатывать сетевые приложения на основе KestrelFramework

### 2 Документация
**Внутренняя документация**: [docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**Внешняя документация**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
Некоторые необходимые базовые библиотеки для сетевого программирования на kestrel
1. Интерфейс промежуточного ПО (middleware) в Kestrel и его регистрация
2. System.Buffers: Классы для работы с буферами
3. System.IO: Классы для работы с потоками
4. System.IO.Pipelines: Классы для работы с дуплексными каналами
5. Middleware: Некоторые промежуточные ПО для kestrel

### 4 KestrelApp
Приложения Kestrel, включая:
1. Конфигурация прослушиваемого EndPoint
2. Конфигурация протокола, используемого EndPoint

### 5 KestrelApp.Middleware
Библиотека промежуточного ПО для KestrelApp
#### 5.1 Echo
Пример простого приложения-протокола Echo

#### 5.2 FlowAnalyze
Пример промежуточного ПО для статистики трафика на транспортном уровне

#### 5.3 FlowXor
Пример промежуточного ПО для обработки трафика на транспортном уровне с помощью XOR

#### 5.4 HttpProxy
Пример приложения-протокола http-прокси

#### 5.5 Telnet
Пример простого приложения-протокола Telnet

#### 5.6 TelnetProxy
Пример пересылки трафика на telnet-сервер

#### 5.6 Redis
Сервер протокола redis, демонстрирующий использование промежуточного ПО в приложении

### Открытый исходный код — вместе мы делаем его лучше!
![打赏](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---