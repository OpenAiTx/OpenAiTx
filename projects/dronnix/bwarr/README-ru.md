
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

## Что это такое?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

Black-White Array (или BWArr) — это быстрая, упорядоченная структура данных на основе массивов с ***$O(\log N)$*** **выделениями памяти**.

## Структура данных
Идея Black-White Array была изобретена и опубликована профессором [Z. George Mou](https://www.cs.brandeis.edu/~mou/) в работе [Black-White Array: A New Data Structure for
Dynamic Data Sets](https://arxiv.org/abs/2004.09051). Данный репозиторий содержит первую публичную реализацию.

![Профессор Z. George Mou](https://www.cs.brandeis.edu/~mou/mou.gif)

### Ключевые особенности:
- $O(\log N)$ выделений памяти при вставке — низкая нагрузка на GC;
- Быстрые операции вставки, удаления и поиска с амортизированной сложностью $O(\log N)$;
- Основан на массивах и не использует указатели, что делает его дружественным к CPU: локальность кэша / последовательная итерация / и т.д.;
- Нативная поддержка дублирующихся элементов (поведение multiset) — не требуется оборачивать значения в структуры для уникальности;
- Полная замена для `github.com/google/btree` и `github.com/petar/GoLLRB`;
- Низкие накладные расходы по памяти — нет указателей на элемент, компактное представление памяти;
- Легко сериализуется;

### Компромиссы
- Раз в $N$ операций вставки сложность падает до $O(N)$, хотя в среднем остается $O(\log N)$. Для систем реального времени это может вызвать скачки задержки при коллекциях с миллионами элементов. Может быть смягчено асинхронными/фоновыми вставками.
- Для небольшого числа элементов операции `Search()/Delete()` могут занимать $O((\log N)^2)$. 50% элементов обрабатываются за $O(\log N)$, 75% — за $O(2\log N)$, 87.5% — за $O(3\log N)$ и т.д.
- При удалении длинных серий элементов операция `Max()/Min()` может занимать $O(N/4)$. Амортизированная сложность для серии вызовов остается $O(\log N)$.
- При удалении длинных серий элементов шаг итерации может занимать $O(N/4)$. Амортизированная сложность итерации по всей коллекции составляет $O(\log N)$ на элемент.

### Сценарии использования
Коллекции в памяти с соотношением чтения к записи 1:1 < r:w < 10:1. BWArr оптимизирован для интенсивных вставок и удалений (с низким числом выделений и фрагментацией), при этом обеспечивает быстрый поиск и итерацию.

###  Бенчмарки

Бенчмарки в сравнении с [Google BTree](https://github.com/google/btree).

#### Вставка 
Измеряет время, количество аллокаций и выделенные КБ при вставке N уникальных случайных значений int64 в пустую структуру данных. И BWArr, и BTree стартуют пустыми и вставляют все значения по одному.

![Производительность вставки](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![Вставка Allocs](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![Вставка Alloc_Bytes](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

Выделения памяти при меньших значениях: 

![Вставка Allocs small](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)


#### Получение (Get)
Измеряет время поиска N значений по их ключам в заранее заполненной структуре данных. Структура данных заполняется всеми значениями до начала измерения времени, затем каждое значение извлекается по ключу.

![Производительность получения](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### Итерация
Измеряет время обхода всех N значений в отсортированном и неотсортированном порядке.
![Производительность упорядоченной итерации](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![Производительность неупорядоченной итерации](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### Дополнительные бенчмарки
Дополнительные тесты и подробности доступны в репозитории [bwarr-bench](https://github.com/dronnix/bwarr-bench).
Будут добавлены новые методы, а также ожидаются отдельные тесты для архитектур AMD64 и ARM64.

## Установка

Требуется Go версии 1.22 или выше.

```bash
go get github.com/dronnix/bwarr
```

Затем импортируйте в вашем коде:

```go
import "github.com/dronnix/bwarr"
```

## Использование

### Базовый пример

```go
package main

import (
    "cmp"
    "fmt"

    "github.com/dronnix/bwarr"
)

func main() {
    // Create a BWArr with an integer comparison function
    // The second parameter (10) is the initial capacity hint
    bwa := bwarr.New(func(a, b int64) int {
        return cmp.Compare(a, b)
    }, 10)

    // Insert elements
    bwa.Insert(42)
    bwa.Insert(17)
    bwa.Insert(99)
    bwa.Insert(23)
    bwa.Insert(8)

    fmt.Printf("Length: %d\n", bwa.Len()) // Output: Length: 5

    // Get an element
    val, found := bwa.Get(42)
    if found {
        fmt.Printf("Found: %d\n", val) // Output: Found: 42
    }

    // Delete an element
    deleted, found := bwa.Delete(17)
    if found {
        fmt.Printf("Deleted: %d\n", deleted) // Output: Deleted: 17
    }

    // Iterate in ascending order
    fmt.Println("Elements in sorted order:")
    bwa.Ascend(func(item int64) bool {
        fmt.Printf("  %d\n", item)
        return true // return false to stop iteration early
    })
    // Output:
    //   8
    //   23
    //   42
    //   99
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-19

---