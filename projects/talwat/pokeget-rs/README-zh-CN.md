# pokeget-rs

一个更好的 pokeget Rust 版本。

## 使用方法

`pokeget <pokemon>`

更多信息，请运行 `pokeget --help`。

## 项目状态

我决定虽然会继续修复漏洞等问题，
但除非是严重问题，否则不会再添加或修改精灵图。
这是因为首先，宝可梦正逐渐远离像素精灵图，
其次，pokesprite 已停止更新且尚未找到合适的替代品。

### .bashrc

如果你在 shell 启动时使用 pokeget，比如在 `.bashrc` 中，
那么你可以通过以下方式将输出写入文件，而不是直接运行 `pokeget <pokemon>`：
`pokeget <pokemon> > file.txt`
然后在你的 bashrc 中使用类似 `cat file.txt` 的命令。

这样你的 shell 初始化几乎是瞬时的，但显然
无法用于随机宝可梦。pokeget 已经相当快，
所以在 shell 初始化时使用它也不会成为很大的瓶颈。

### 示例

#### 使用多个宝可梦

`pokeget bulbasaur pikachu random`

#### 使用图鉴 ID

`pokeget 1 2 3`

#### 使用替代形态


`pokeget raichu sandslash meowth --alolan`

#### 使用地区

`pokeget kanto`

## 安装

### Cargo *(推荐)*

推荐的安装方法是使用 cargo:

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

并确保将 `$HOME/.local/bin` 添加到 `$PATH`。

### 将目录添加到 $PATH

#### Bash 和 Zsh

将以下内容追加到你的 `.bashrc` 或 `.zshrc` 文件中：

```sh
export PATH="<path>:$PATH"
```

#### 鱼

在你的命令行界面运行此命令：

```sh
fish_add_path <path>
```

## 更新

只需重新运行 `cargo install pokeget` 或在仓库中执行 `git pull`，然后重新编译即可。

## 为什么？

因为最初的 pokeget 运行缓慢、臃肿且非常复杂，所以我决定用 Rust 制作一个更好的版本。

现在，pokeget 不再预先计算所有精灵并上传到仓库，
而是能够按需计算它们，这使得一切更加灵活。
Rust 使得这种计算比 Python 等语言快得多。

它还将使用半方块绘制精灵，尺寸缩小为原来的 2 倍。

## 其他项目怎么样？

pokeget-rs 相较于旧的 pokeget、pokeshell 等项目有优势，因为它使用 Rust。
它的速度也比另一个非常相似的项目 krabby 快了显著的 5.5 倍。

更多信息，请访问 [OTHER_PROJECTS.md](https://raw.githubusercontent.com/talwat/pokeget-rs/main/OTHER_PROJECTS.md)。

## 大尺寸精灵怎么样？

没有了。缩减为原子级别。

说正经的，我决定不再处理它们，因为这需要额外大量工作，我不想应付。
它们很少被使用，在小终端窗口中看起来也很难看，所以保留它们意义不大。

## 致谢

这次，精灵来自 [pokesprite](https://github.com/msikma/pokesprite)，pokeget 通过 git 子模块使用它们。

精灵被嵌入到二进制文件中，因此 pokeget 不会下载它们。这是一个很好的折衷，
因为虽然二进制文件可能较大，pokeget 可以几乎瞬间执行且支持离线使用。

## 许可证

pokeget 使用 MIT 许可证，欢迎自由分叉并根据需要定制。

如果您对pokeget的任何内部工作原理不确定，[提交一个问题](https://github.com/talwat/pokeget-rs/issues)，  
我会回答您可能有的任何问题。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---