# Lens

[![Hex.pm](http://img.shields.io/hexpm/v/lens.svg)](https://hex.pm/packages/lens) [![Hex.pm](http://img.shields.io/hexpm/dt/lens.svg)](https://hex.pm/packages/lens)

ネストされたデータ構造を操作するためのユーティリティです。
[Nested data structures with functional lenses](https://yapee.svbtle.com/nested-data-structures-with-lens)
でより優しく紹介しています。ブログ記事はバージョン `0.3.1` を使って書かれており、その後APIに
変更があります—詳細は [Upgrading](#upgrading) を参照してください。

## インストール

`mix.exs` の依存リストに `lens` を追加することでパッケージをインストールできます：

```elixir
def deps do
  [
    {:lens, "~> 1.0.0"}
  ]
end
```
## アップグレード

### 0.6.0以前から

0.6.0では関数 `Lens.get` が削除されました。理由は、リストを単一要素として扱ったりその逆をしたりするバグを簡単に作成してしまうためです。`Lens.get` を使っていた箇所では、呼び出しが常に正確に1つの要素を返すべき場合は `Lens.one!` を使うべきです（要素数が異なる場合はクラッシュします）。異なる要素数に対して異なる動作をしたい場合は `Lens.to_list` を使い、その結果にマッチさせてください。

### 0.5.0以前から

0.5.0では関数 `satisfy` が `filter` に名前変更され、以前の `filter` は削除されました。理由は、新しい構成では対になる `filter`/`reject` 関数が存在し、より直感的になるためです。`Lens.filter(predicate)` を使っていた箇所は、今では `Lens.filter(Lens.all(), predicate)` を使うことができます。

## 例

Lensは複雑なデータ構造のどの部分を処理するかを、実際の処理から分離することを可能にします。以下を見てください：








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

100より大きいすべてのウィジェット（メインウィジェットであれ他のウィジェットであれ）のサイズに関心があるとします。
これらの場所をデータ構造内で表現する`Lens`オブジェクトを次のように構築できます：

```elixir
lens = Lens.both(
  Lens.key(:main_widget),
  Lens.key(:other_widgets) |> Lens.all
)
|> Lens.seq_both(Lens.recur(Lens.key(:subwidgets) |> Lens.all))
|> Lens.key(:size)
|> Lens.filter(&(&1 > 100))
```

以下のことが可能であるとすると：

* すべての関連データを抽出すること

```elixir
iex> Lens.to_list(lens, data)
[200.5, 160.5, 121.9, 120, 200, 120]
```
* データ構造内の記載された場所を更新する


```elixir
iex> Lens.map(lens, data, &round/1)
%{main_widget: %{size: 201,
    subwidgets: [%{size: 120, subwidgets: [%{size: 200, subwidgets: []}]}]},
  other_widgets: [%{size: 16.5, subwidgets: [%{size: 120, subwidgets: []}]},
   %{size: 161, subwidgets: []}, %{size: 122, subwidgets: []}]}
```

* データ内のすべての場所から同時に何かを更新し返す

```elixir
iex> Lens.get_and_map(lens, data, fn size -> {size, round(size)} end)
{[200.5, 160.5, 121.9, 120, 200, 120],
 %{main_widget: %{size: 201,
     subwidgets: [%{size: 120, subwidgets: [%{size: 200, subwidgets: []}]}]},
   other_widgets: [%{size: 16.5, subwidgets: [%{size: 120, subwidgets: []}]},
    %{size: 161, subwidgets: []}, %{size: 122, subwidgets: []}]}}
```
レンズは `Access` および関連する `Kernel` 関数とも互換性があります：


```elixir
iex> get_in([1, 2, 3], [Lens.all() |> Lens.filter(&Integer.is_odd/1)])
[1, 3]
iex> update_in([1, 2, 3], [Lens.all() |> Lens.filter(&Integer.is_odd/1)], fn x -> x + 1 end)
[2, 2, 4]
iex> get_and_update_in([1, 2, 3], [Lens.all() |> Lens.filter(&Integer.is_odd/1)], fn x -> {x - 1, x + 1} end)
{[0, 2], [2, 2, 4]}
```

## フォーマット

通常、`mix format` は次のような定義を変更します： 

```elixir
deflens a_lens(), do: some() |> implementation()
deflensp a_private_lens(), do: some() |> implementation()
```
へ:


```elixir
deflens(a_lens(), do: some() |> implementation())
deflensp(a_private_lens(), do: some() |> implementation())
```
これを回避するには、`formatter.exs`でlensのフォーマッター設定をインポートできます:


```elixir
# my_app/.formatter.exs
[
  import_deps: [:lens]
]
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---