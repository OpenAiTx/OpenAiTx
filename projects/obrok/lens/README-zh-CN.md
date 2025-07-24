# Lens

[![Hex.pm](http://img.shields.io/hexpm/v/lens.svg)](https://hex.pm/packages/lens) [![Hex.pm](http://img.shields.io/hexpm/dt/lens.svg)](https://hex.pm/packages/lens)

一个用于处理嵌套数据结构的工具。请查看
[Nested data structures with functional lenses](https://yapee.svbtle.com/nested-data-structures-with-lens)
以获得更温和的介绍。请注意，该博客文章使用的是版本 `0.3.1` 撰写的，自那以后 API 有一些变更——详情请参见[升级](#upgrading)。

## 安装

该包可以通过在 `mix.exs` 中的依赖列表中添加 `lens` 来安装：


```elixir
def deps do
  [
    {:lens, "~> 1.0.0"}
  ]
end
```
## 升级指南

### 从 0.6.0 之前版本升级

在 0.6.0 版本中，函数 `Lens.get` 被移除。原因是它很容易导致将列表当作单个元素处理，反之亦然的错误。无论何处使用 `Lens.get`，现在应改用 `Lens.one!`，如果调用应始终返回且仅返回一个元素（如果元素数量不是一个则会崩溃），或者使用 `Lens.to_list` 并根据结果进行匹配，以便对不同数量的元素做不同处理。

### 从 0.5.0 之前版本升级

在 0.5.0 版本中，函数 `satisfy` 被重命名为 `filter`，而之前版本的 `filter` 被移除。原因是新的安排中，`filter` 和 `reject` 形成了一对匹配的函数，这样更直观。无论何处使用 `Lens.filter(predicate)`，现在可以使用 `Lens.filter(Lens.all(), predicate)`。

## 示例

Lens 允许你将复杂数据结构中需要处理的部分与实际处理过程分离。示例如下：








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

假设我们对所有大于100的部件（无论是主部件还是其他部件）的大小感兴趣。  
我们可以构造一个 `Lens` 对象，以以下方式描述数据结构中的这些位置：  

```elixir
lens = Lens.both(
  Lens.key(:main_widget),
  Lens.key(:other_widgets) |> Lens.all
)
|> Lens.seq_both(Lens.recur(Lens.key(:subwidgets) |> Lens.all))
|> Lens.key(:size)
|> Lens.filter(&(&1 > 100))
```

鉴于我们可以：

* 提取所有相关数据

```elixir
iex> Lens.to_list(lens, data)
[200.5, 160.5, 121.9, 120, 200, 120]
```

* 更新数据结构中描述的位置

```elixir
iex> Lens.map(lens, data, &round/1)
%{main_widget: %{size: 201,
    subwidgets: [%{size: 120, subwidgets: [%{size: 200, subwidgets: []}]}]},
  other_widgets: [%{size: 16.5, subwidgets: [%{size: 120, subwidgets: []}]},
   %{size: 161, subwidgets: []}, %{size: 122, subwidgets: []}]}
```

* 同时更新并从数据中的每个位置返回内容

```elixir
iex> Lens.get_and_map(lens, data, fn size -> {size, round(size)} end)
{[200.5, 160.5, 121.9, 120, 200, 120],
 %{main_widget: %{size: 201,
     subwidgets: [%{size: 120, subwidgets: [%{size: 200, subwidgets: []}]}]},
   other_widgets: [%{size: 16.5, subwidgets: [%{size: 120, subwidgets: []}]},
    %{size: 161, subwidgets: []}, %{size: 122, subwidgets: []}]}}
```
镜头也兼容 `Access` 及相关的 `Kernel` 函数：


```elixir
iex> get_in([1, 2, 3], [Lens.all() |> Lens.filter(&Integer.is_odd/1)])
[1, 3]
iex> update_in([1, 2, 3], [Lens.all() |> Lens.filter(&Integer.is_odd/1)], fn x -> x + 1 end)
[2, 2, 4]
iex> get_and_update_in([1, 2, 3], [Lens.all() |> Lens.filter(&Integer.is_odd/1)], fn x -> {x - 1, x + 1} end)
{[0, 2], [2, 2, 4]}
```

## 格式化

通常，`mix format` 会更改如下定义： 

```elixir
deflens a_lens(), do: some() |> implementation()
deflensp a_private_lens(), do: some() |> implementation()
```
进入：


```elixir
deflens(a_lens(), do: some() |> implementation())
deflensp(a_private_lens(), do: some() |> implementation())
```
为了避免这种情况，您可以在 `formatter.exs` 中导入 lens 的格式化设置：


```elixir
# my_app/.formatter.exs
[
  import_deps: [:lens]
]
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---