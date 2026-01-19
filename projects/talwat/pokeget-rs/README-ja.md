# pokeget-rs

pokegetのより良いRust版。

## 使用法

`pokeget <pokemon>`

詳細は、`pokeget --help`を実行してください。

## プロジェクトの状況

バグ修正などは引き続き行いますが、
重大な問題でない限り、スプライトの追加や変更は行いません。
これは第一に、ポケモンがピクセルスプライトから離れていること、
第二に、pokespriteの更新が停止しており
適切な代替が見つかっていないためです。

### .bashrc

もし`.bashrc`などのシェル起動時にpokegetを使う場合は、
`pokeget <pokemon>`を実行する代わりに、
出力をファイルに書き込むことができます：`pokeget <pokemon> > file.txt`
そしてbashrcに`cat file.txt`のようなコマンドを入れます。

これによりシェルの初期化がほぼ瞬時になりますが、
当然ランダムなポケモンには対応しません。pokegetは既にかなり高速なので、
シェル初期化時に使っても大きなボトルネックにはなりません。

### 例

#### 複数のポケモンを使う

`pokeget bulbasaur pikachu random`

#### ポケモン図鑑番号を使う

`pokeget 1 2 3`

#### 代替フォルムを使う

`pokeget raichu sandslash meowth --alolan`

#### 地域の指定

`pokeget kanto`

## インストール

### Cargo *(推奨)*

推奨されるインストール方法はcargoを使用することです:

```sh
cargo install pokeget
```

and making sure `$HOME/.cargo/bin` is added to `$PATH`.

### AUR

If you're on Arch, you can also use the AUR:

```sh
yay -S pokeget
```

### Git

You can also clone the repository and compile manually by doing:

```sh
git clone --recurse-submodules https://github.com/talwat/pokeget-rs.git
cd pokeget-rs
cargo build --release
mv target/release/pokeget ~/.local/bin
```

そして `$HOME/.local/bin` が `$PATH` に追加されていることを確認します。

### $PATH にディレクトリを追加する方法

#### Bash & Zsh

これを `.bashrc` または `.zshrc` に追記してください：

```sh
export PATH="<path>:$PATH"
```

#### 魚

CLIでこれを実行してください:

```sh
fish_add_path <path>
```
## 更新

単に `cargo install pokeget` を再実行するか、リポジトリで `git pull` してから再コンパイルしてください。

## なぜ？

最初の pokeget は遅く、肥大化していて非常に複雑だったため、より良いバージョンを Rust で作ることにしました。

今では、すべてのスプライトを事前計算してリポジトリにアップロードする代わりに、pokeget は必要に応じて計算できるようになり、すべてがはるかに柔軟になります。
Rust は Python のような言語よりもはるかに高速にその計算を実行できます。

また、半分の正方形を使用してスプライトを2倍小さく描画します。

## 他のプロジェクトは？

pokeget-rs は Rust で書かれているため、古い pokeget や pokeshell などのプロジェクトに対して優位性があります。
また、非常に似たプロジェクトである krabby よりも 5.5 倍高速です。

詳細は [OTHER_PROJECTS.md](https://raw.githubusercontent.com/talwat/pokeget-rs/main/OTHER_PROJECTS.md) を参照してください。

## 大きなスプライトは？

なくなりました。原子レベルに縮小されました。

冗談はさておき、大きなスプライトは扱わないことにしました。なぜなら、それはかなりの追加作業であり、私が対応したくないからです。ほとんど使用されず、小さな端末ウィンドウでは見栄えが悪かったため、保持する意味がほとんどありませんでした。

## クレジット

今回はスプライトは [pokesprite](https://github.com/msikma/pokesprite) からのもので、pokeget は git サブモジュールとしてそれらを使用しています。

スプライトはバイナリに埋め込まれているため、pokeget はそれらをダウンロードしません。これは良い妥協点で、バイナリは大きいかもしれませんが、pokeget はほぼ瞬時にオフラインでも実行可能です。

## ライセンス

pokeget は MIT ライセンスを使用しているので、自由にフォークしてカスタマイズしてください。





pokegetの内部動作について不明な点があれば、[issueを開いてください](https://github.com/talwat/pokeget-rs/issues)、  
どんな質問にもお答えします。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---