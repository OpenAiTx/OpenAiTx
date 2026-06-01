<br />
<br />
<p align="center">
  <a href="https://github.com/mixxorz/DSLR">
    <img width="281" height="84" src="https://user-images.githubusercontent.com/3102758/181914025-44bff27e-aac1-4d1b-a037-9fa98f9fed65.png" alt="The DSLR logo">
  </a>
</p>
<br />

<p align="center">
  <a href=""><img src="" alt=""></a>
  <a href="https://badge.fury.io/py/dslr"><img src="https://badge.fury.io/py/dslr.svg" alt="PyPI version"></a>
  <a href="https://pypi.python.org/pypi/dslr/"><img src="https://img.shields.io/pypi/pyversions/dslr.svg" alt="PyPI Supported Python Versions"></a>
  <a href="https://github.com/mixxorz/dslr"><img src="https://github.com/mixxorz/dslr/actions/workflows/tests.yml/badge.svg" alt="GitHub Actions (Code quality and tests)"></a>

</p>

<p align="center">
  <img src="https://user-images.githubusercontent.com/3102758/190845105-dd2ec4e6-286b-431d-a33d-490805852b68.png" alt="A terminal showing DSLR's command line interface.">
</p>

---

数据库快照、列表和恢复

以极快的速度对本地 Postgres 数据库进行快照。

## 这是什么？

DSLR 是一个工具，允许你在编写数据库迁移、切换分支或操作 SQL 时，快速创建和恢复数据库快照。

它旨在成为
[Stellar](https://github.com/fastmonkeys/stellar) 的精神继承者。

**重要提示：** DSLR 仅供开发使用。不建议在生产数据库上使用 DSLR。

## 性能



DSLR 比标准的 `pg_dump`/`pg_restore` 快得多。

<p align="center">
  <img src="https://user-images.githubusercontent.com/3102758/182014327-1b13da6e-63ad-4bbe-817e-7d6c66befc98.png" alt="一张比较 DSLR 和 pg_dump/pg_restore 执行时间的图表。快照和恢复时，DSLR 分别用了 4.125 秒和 4.431 秒。pg_dump/pg_restore 分别用了 36.602 秒和 13.257 秒。">
</p>

DSLR 在拍摄快照时快 8 倍，恢复快照时快 3 倍，相比于 `pg_dump`/`pg_restore` 方法。

<details>
  <summary>测试方法论</summary>
  
  我使用 Docker 启动了 Postgres 12.3，创建了一个测试数据库，并使用此脚本填充了 1GB 的随机数据：
  

  ```SQL
  CREATE TABLE large_test (num1 bigint, num2 double precision, num3 double precision);

INSERT INTO large*test (num1, num2, num3)
SELECT round(random() * 10), random(), random() \_ 142
FROM generate_series(1, 20000000) s(i);

```
我使用以下命令来测量执行时间：


```

time dslr snapshot my-snapshot
time dslr restore my-snapshot
time pg_dump -Fc -f export.dump
time pg_restore --no-acl --no-owner export.dump

```
我对每个命令运行了三次，并在图表中绘制了平均值。

以下是原始数据：

| 命令          | 运行 | 执行时间（秒）           |
| ------------- | ---- | ------------------------ |
| dslr snapshot | 1    | 4.797                    |
|               | 2    | 4.650                    |
|               | 3    | 2.927                    |
| dslr restore  | 1    | 5.840                    |
|               | 2    | 4.122                    |
|               | 3    | 3.331                    |
| pg_dump       | 1    | 37.345                   |
|               | 2    | 36.227                   |
|               | 3    | 36.233                   |
| pg_restore    | 1    | 13.304                   |
|               | 2    | 13.148                   |
|               | 3    | 13.320                   |
</details>

## 安装


```

pip install DSLR psycopg2 # or psycopg2-binary, or psycopg

```

**使用 pipx 安装**

```

pipx install DSLR[psycopg2] # or psycopg2-binary, or psycopg

````

**使用 uv 安装**

```

uv tool install 'DSLR[psycopg2]' # or psycopg2-binary, or psycopg

```

注意：DSLR 的 `export` 和 `import` 快照命令需要 `pg_dump` 和
`pg_restore` 在您的 `PATH` 中，因此如果您想使用这些命令，
需要安装 Postgres 命令行工具。

<details>
  <summary><strong>Shell 补全</strong></summary>

**Bash**

将以下内容添加到 `~/.bashrc`：

```
eval "$(_DSLR_COMPLETE=bash_source dslr)"
```

**Zsh**

Add this to `~/.zshrc`:

```
eval "$(_DSLR_COMPLETE=zsh_source dslr)"
```

**Fish**

将此添加到 `~/.config/fish/completions/dslr.fish`：

```
eval (env _DSLR_COMPLETE=fish_source dslr)
```

这与下面激活脚本方法使用的是同一个文件。对于 Fish 来说，使用那个方法可能总是更简单。

使用 eval 意味着每次启动 shell 时都会调用并执行该命令，这可能会延迟 shell 的响应速度。为了加快速度，可以将生成的脚本写入文件，然后再 source 它。

**Bash**

将脚本保存到某个地方。

```
_DSLR_COMPLETE=bash_source dslr > ~/.dslr-complete.bash
```

在 ~/.bashrc 中引用该文件。

```
. ~/.dslr-complete.bash
```

**Zsh**

Save the script somewhere.

```
_DSLR_COMPLETE=zsh_source dslr > ~/.dslr-complete.zsh
```

在 ~/.zshrc 中加载该文件。

```
. ~/.dslr-complete.zsh
```

**Fish**

将脚本保存到 ~/.config/fish/completions/foo-bar.fish：

```
_DSLR_COMPLETE=fish_source dslr > ~/.config/fish/completions/dslr.fish
```

</details>



## 配置

您可以通过几种方式告诉 DSLR 对哪个数据库进行快照：

**DATABASE_URL**

如果设置了 `DATABASE_URL` 环境变量，DSLR 将使用它来连接
到您的目标数据库。

```bash
export DATABASE_URL=postgres://username:password@host:port/database_name
````

**dslr.toml**

如果当前目录中存在 `dslr.toml` 文件，DSLR 将从中读取其设置。DSLR 会优先使用此文件而非环境变量。


```toml
url = 'postgres://username:password@host:port/database_name'
```

**`--url` 选项**

最后，您可以通过 `--url` 选项显式传递连接字符串。  
这将覆盖上述任何设置。

## 用法

```
$ dslr snapshot my-first-snapshot
Created new snapshot my-first-snapshot

$ dslr restore my-first-snapshot
Restored database from snapshot my-first-snapshot

$ dslr list

  Name                Created            Size
 ─────────────────────────────────────────────
  my-first-snapshot   2 minutes ago   3253 kB

$ dslr rename my-first-snapshot fresh-db
Renamed snapshot my-first-snapshot to fresh-db

$ dslr delete some-old-snapshot
Deleted some-old-snapshot

$ dslr export my-feature-test
Exported snapshot my-feature-test to my-feature-test_20220730-075650.dump

$ dslr import snapshot-from-a-friend_20220730-080632.dump friend-snapshot
Imported snapshot friend-snapshot from snapshot-from-a-friend_20220730-080632.dump
```

要在非交互式 shell 中强制覆盖现有快照，请使用标志 `-y`：

```
$ dslr snapshot my-first-snapshot -y
Updated snapshot my-first-snapshot
```

## 它是如何工作的？

DSLR 通过使用 Postgres 的 [模板数据库](https://www.postgresql.org/docs/current/manage-ag-templatedbs.html) 功能克隆数据库来拍摄快照。  
这是 DSLR 速度的主要来源。

这意味着拍摄快照只是使用主数据库作为模板创建一个新数据库。  
恢复快照只是删除主数据库并使用快照数据库作为模板创建一个新数据库。  
依此类推。

## 贡献者

[![贡献者](https://contrib.rocks/image?repo=mixxorz/DSLR)](https://github.com/mixxorz/DSLR/graphs/contributors)

## 许可证

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-01

---