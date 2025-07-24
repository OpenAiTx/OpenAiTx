# 렌즈

[![Hex.pm](http://img.shields.io/hexpm/v/lens.svg)](https://hex.pm/packages/lens) [![Hex.pm](http://img.shields.io/hexpm/dt/lens.svg)](https://hex.pm/packages/lens)

중첩된 데이터 구조를 다루기 위한 유틸리티입니다.  
보다 부드러운 소개를 원하시면  
[Nested data structures with functional lenses](https://yapee.svbtle.com/nested-data-structures-with-lens)  
를 참고하세요. 이 블로그 글은 `0.3.1` 버전을 기준으로 작성되었으며, 그 이후 API에  
몇 가지 변경 사항이 있습니다 - 자세한 내용은 [업그레이드](#upgrading)를 참고하세요.

## 설치

패키지는 `mix.exs`의 의존성 목록에 `lens`를 추가하여 설치할 수 있습니다:
```elixir
def deps do
  [
    {:lens, "~> 1.0.0"}
  ]
end
```
## 업그레이드

### 0.6.0 이전 버전에서

0.6.0 버전에서 `Lens.get` 함수가 제거되었습니다. 그 이유는 리스트를 단일 요소로 취급하거나 그 반대로 처리하는 버그가 매우 쉽게 발생했기 때문입니다. `Lens.get`을 사용하던 곳에서는 호출이 항상 정확히 하나의 요소를 반환해야 한다면 `Lens.one!`을 사용해야 하며(요소 수가 다르면 크래시가 발생합니다), 요소 수에 따라 다르게 동작하도록 하려면 `Lens.to_list`를 사용하고 결과에 대해 매칭해야 합니다.

### 0.5.0 이전 버전에서

0.5.0 버전에서 `satisfy` 함수가 `filter`로 이름이 변경되었고 이전 버전의 `filter`는 제거되었습니다. 이는 새로운 구성에서 `filter`/`reject` 함수 쌍이 일치하여 더 직관적이기 때문입니다. `Lens.filter(predicate)`를 사용하던 곳에서는 이제 `Lens.filter(Lens.all(), predicate)`를 사용할 수 있습니다.

## 예제

Lens는 복잡한 데이터 구조의 어느 부분을 처리해야 하는지와 실제 처리를 분리할 수 있게 해줍니다. 다음을 예로 들어보겠습니다:








```elixir
data = %{
  main_widget: %{size: 200.5, subwidgets: [%{size: 120, subwidgets: [%{size: 200, subwidgets: []}]}]},
  other_widgets: [
    %{size: 16.5, subwidgets: [%{size: 120, subwidgets: []}]},
    %{size: 160.5, subwidgets: []},
    %{size: 121.9, subwidgets: []},
  ]
}
```
100보다 큰 모든 위젯(주요 위젯이든 다른 위젯이든)의 크기에 관심이 있다고 가정해 봅시다.  
다음과 같이 데이터 구조 내 이러한 위치를 설명하는 `Lens` 객체를 구성할 수 있습니다:  
  

```elixir
lens = Lens.both(
  Lens.key(:main_widget),
  Lens.key(:other_widgets) |> Lens.all
)
|> Lens.seq_both(Lens.recur(Lens.key(:subwidgets) |> Lens.all))
|> Lens.key(:size)
|> Lens.filter(&(&1 > 100))
```

다음과 같이 할 수 있다고 가정할 때:

* 모든 관련 데이터를 추출한다

```elixir
iex> Lens.to_list(lens, data)
[200.5, 160.5, 121.9, 120, 200, 120]
```
* 데이터 구조 내 설명된 위치들을 업데이트하세요


```elixir
iex> Lens.map(lens, data, &round/1)
%{main_widget: %{size: 201,
    subwidgets: [%{size: 120, subwidgets: [%{size: 200, subwidgets: []}]}]},
  other_widgets: [%{size: 16.5, subwidgets: [%{size: 120, subwidgets: []}]},
   %{size: 161, subwidgets: []}, %{size: 122, subwidgets: []}]}
```

* 데이터의 모든 위치에서 동시에 업데이트하고 무언가를 반환하기

```elixir
iex> Lens.get_and_map(lens, data, fn size -> {size, round(size)} end)
{[200.5, 160.5, 121.9, 120, 200, 120],
 %{main_widget: %{size: 201,
     subwidgets: [%{size: 120, subwidgets: [%{size: 200, subwidgets: []}]}]},
   other_widgets: [%{size: 16.5, subwidgets: [%{size: 120, subwidgets: []}]},
    %{size: 161, subwidgets: []}, %{size: 122, subwidgets: []}]}}
```
렌즈는 또한 `Access` 및 관련 `Kernel` 함수와도 호환됩니다:


```elixir
iex> get_in([1, 2, 3], [Lens.all() |> Lens.filter(&Integer.is_odd/1)])
[1, 3]
iex> update_in([1, 2, 3], [Lens.all() |> Lens.filter(&Integer.is_odd/1)], fn x -> x + 1 end)
[2, 2, 4]
iex> get_and_update_in([1, 2, 3], [Lens.all() |> Lens.filter(&Integer.is_odd/1)], fn x -> {x - 1, x + 1} end)
{[0, 2], [2, 2, 4]}
```

## 형식 지정

보통 `mix format`는 다음과 같은 정의를 변경합니다:

```elixir
deflens a_lens(), do: some() |> implementation()
deflensp a_private_lens(), do: some() |> implementation()
```
~으로:


```elixir
deflens(a_lens(), do: some() |> implementation())
deflensp(a_private_lens(), do: some() |> implementation())
```
이 문제를 피하려면 `formatter.exs`에 lens의 포매터 설정을 가져올 수 있습니다:


```elixir
# my_app/.formatter.exs
[
  import_deps: [:lens]
]
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---