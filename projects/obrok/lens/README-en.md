# Lens

[![Hex.pm](http://img.shields.io/hexpm/v/lens.svg)](https://hex.pm/packages/lens) [![Hex.pm](http://img.shields.io/hexpm/dt/lens.svg)](https://hex.pm/packages/lens)

A utility for working with nested data structures. Take a look at
[Nested data structures with functional lenses](https://yapee.svbtle.com/nested-data-structures-with-lens)
for a gentler introduction. Note that the blogpost was written using version `0.3.1` and there have been some API
changes since then - see [Upgrading](#upgrading) for details.

## Installation

The package can be installed by adding `lens` to your list of dependencies in `mix.exs`:

```elixir
def deps do
  [
    {:lens, "~> 1.0.0"}
  ]
end
```

## Upgrading

### From pre-0.6.0

In 0.6.0 the function `Lens.get` was removed. The reason was that it was very easy to create a bug where a list was
treated as a single element or vice versa. Wherever you used `Lens.get` you should now either use `Lens.one!` if the
invocation should always return exactly one element (this will crash if there is any other number of elements) or
`Lens.to_list` and match on the result if you want to behave differently for different numbers of elements.

### From pre-0.5.0

In 0.5.0 the function `satisfy` was renamed to `filter` while the previous version of `filter` was removed. The reason
was that with the new arrangement there is a matching pair of `filter`/`reject` functions, and this should be more
intuitive. Wherever you used `Lens.filter(predicate)` you can now use `Lens.filter(Lens.all(), predicate)`.

## Example

Lens allows you to separate which parts of a complex data structure need to be processed from the actual
processing. Take the following:

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

Let's say we're interested in the sizes of all widgets (be they the main widget or other widgets) that are larger than 100.
We can construct a `Lens` object that describes these locations in the data structure the following way:

```elixir
lens = Lens.both(
  Lens.key(:main_widget),
  Lens.key(:other_widgets) |> Lens.all
)
|> Lens.seq_both(Lens.recur(Lens.key(:subwidgets) |> Lens.all))
|> Lens.key(:size)
|> Lens.filter(&(&1 > 100))
```

Given that we can:

* Extract all the relevant data

```elixir
iex> Lens.to_list(lens, data)
[200.5, 160.5, 121.9, 120, 200, 120]
```

* Update the described locations in the data structure

```elixir
iex> Lens.map(lens, data, &round/1)
%{main_widget: %{size: 201,
    subwidgets: [%{size: 120, subwidgets: [%{size: 200, subwidgets: []}]}]},
  other_widgets: [%{size: 16.5, subwidgets: [%{size: 120, subwidgets: []}]},
   %{size: 161, subwidgets: []}, %{size: 122, subwidgets: []}]}
```

* Simultaneously update and return something from every location in the data

```elixir
iex> Lens.get_and_map(lens, data, fn size -> {size, round(size)} end)
{[200.5, 160.5, 121.9, 120, 200, 120],
 %{main_widget: %{size: 201,
     subwidgets: [%{size: 120, subwidgets: [%{size: 200, subwidgets: []}]}]},
   other_widgets: [%{size: 16.5, subwidgets: [%{size: 120, subwidgets: []}]},
    %{size: 161, subwidgets: []}, %{size: 122, subwidgets: []}]}}
```

Lenses are also compatible with `Access` and associated `Kernel` functions:

```elixir
iex> get_in([1, 2, 3], [Lens.all() |> Lens.filter(&Integer.is_odd/1)])
[1, 3]
iex> update_in([1, 2, 3], [Lens.all() |> Lens.filter(&Integer.is_odd/1)], fn x -> x + 1 end)
[2, 2, 4]
iex> get_and_update_in([1, 2, 3], [Lens.all() |> Lens.filter(&Integer.is_odd/1)], fn x -> {x - 1, x + 1} end)
{[0, 2], [2, 2, 4]}
```

## Formatting

Normally, `mix format` will change definitions like:

```elixir
deflens a_lens(), do: some() |> implementation()
deflensp a_private_lens(), do: some() |> implementation()
```

into:

```elixir
deflens(a_lens(), do: some() |> implementation())
deflensp(a_private_lens(), do: some() |> implementation())
```

To avoid this, you can import lens's formatter settings in your `formatter.exs`:

```elixir
# my_app/.formatter.exs
[
  import_deps: [:lens]
]
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---