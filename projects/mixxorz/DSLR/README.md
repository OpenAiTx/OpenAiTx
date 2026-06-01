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

Database Snapshot, List, and Restore

Take lightning fast snapshots of your local Postgres databases.

## What is this?

DSLR is a tool that allows you to quickly take and restore database snapshots
when you're writing database migrations, switching branches, or messing with
SQL.

It's meant to be a spiritual successor to
[Stellar](https://github.com/fastmonkeys/stellar).

**Important:** DSLR is intended for development use only. It is not advisable to
use DSLR on production databases.

## Performance

DSLR is much faster than the standard `pg_dump`/`pg_restore` approach to snapshots.

<p align="center">
  <img src="https://user-images.githubusercontent.com/3102758/182014327-1b13da6e-63ad-4bbe-817e-7d6c66befc98.png" alt="A chart comparing the execution time between DSLR and pg_dump/pg_restore. For snapshot and restore, DSLR took 4.125 seconds and 4.431 seconds respectively. pg_dump/pg_restore took 36.602 seconds and 13.257 seconds respectively.">
</p>

DSLR is 8x faster at taking snapshots and 3x faster at restoring snapshots compared to the `pg_dump`/`pg_restore` approach.

<details>
  <summary>Testing methodology</summary>
  
  I spun up Postgres 12.3 using Docker, created a test database, and filled it with 1GB of random data using this script:
  
  ```SQL
  CREATE TABLE large_test (num1 bigint, num2 double precision, num3 double precision);

INSERT INTO large*test (num1, num2, num3)
SELECT round(random() * 10), random(), random() \_ 142
FROM generate_series(1, 20000000) s(i);

```

I used the following commands to measure the execution time:

```

time dslr snapshot my-snapshot
time dslr restore my-snapshot
time pg_dump -Fc -f export.dump
time pg_restore --no-acl --no-owner export.dump

```

I ran each command three times and plotted the mean in the chart.

Here's the raw data:

| Command       | Run | Execution time (seconds) |
| ------------- | --- | ------------------------ |
| dslr snapshot | 1   | 4.797                    |
|               | 2   | 4.650                    |
|               | 3   | 2.927                    |
| dslr restore  | 1   | 5.840                    |
|               | 2   | 4.122                    |
|               | 3   | 3.331                    |
| pg_dump       | 1   | 37.345                   |
|               | 2   | 36.227                   |
|               | 3   | 36.233                   |
| pg_restore    | 1   | 13.304                   |
|               | 2   | 13.148                   |
|               | 3   | 13.320                   |
</details>

## Install

```

pip install DSLR psycopg2 # or psycopg2-binary, or psycopg

```

**Install using pipx**

```

pipx install DSLR[psycopg2] # or psycopg2-binary, or psycopg

````

**Install using uv**

```

uv tool install 'DSLR[psycopg2]' # or psycopg2-binary, or psycopg

```

Note: The DSLR `export` and `import` snapshot commands require `pg_dump` and
`pg_restore` to be present in your `PATH`, so you will need the Postgres CLI
utilities if you want to use those commands.

<details>
  <summary><strong>Shell completion</strong></summary>

**Bash**

Add this to `~/.bashrc`:

```
eval "$(_DSLR_COMPLETE=bash_source dslr)"
```

**Zsh**

Add this to `~/.zshrc`:

```
eval "$(_DSLR_COMPLETE=zsh_source dslr)"
```

**Fish**

Add this to `~/.config/fish/completions/dslr.fish`:

```
eval (env _DSLR_COMPLETE=fish_source dslr)
```

This is the same file used for the activation script method below. For Fish it’s probably always easier to use that method.

Using eval means that the command is invoked and evaluated every time a shell is started, which can delay shell responsiveness. To speed it up, write the generated script to a file, then source that.

**Bash**

Save the script somewhere.

```
_DSLR_COMPLETE=bash_source dslr > ~/.dslr-complete.bash
```

Source the file in ~/.bashrc.

```
. ~/.dslr-complete.bash
```

**Zsh**

Save the script somewhere.

```
_DSLR_COMPLETE=zsh_source dslr > ~/.dslr-complete.zsh
```

Source the file in ~/.zshrc.

```
. ~/.dslr-complete.zsh
```

**Fish**

Save the script to ~/.config/fish/completions/foo-bar.fish:

```
_DSLR_COMPLETE=fish_source dslr > ~/.config/fish/completions/dslr.fish
```

</details>



## Configuration

You can tell DSLR which database to take snapshots of in a few ways:

**DATABASE_URL**

If the `DATABASE_URL` environment variable is set, DSLR will use this to connect
to your target database.

```bash
export DATABASE_URL=postgres://username:password@host:port/database_name
````

**dslr.toml**

If a `dslr.toml` file exists in the current directory, DSLR will read its
settings from there. DSLR will prefer this over the environment variable.

```toml
url = 'postgres://username:password@host:port/database_name'
```

**`--url` option**

Finally, you can explicitly pass the connection string via the `--url` option.
This will override any of the above settings.

## Usage

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

To force overwriting an existing snapshot in non-interactive shell use the flag `-y`:

```
$ dslr snapshot my-first-snapshot -y
Updated snapshot my-first-snapshot
```

## How does it work?

DSLR takes snapshots by cloning databases using Postgres' [Template
Databases](https://www.postgresql.org/docs/current/manage-ag-templatedbs.html)
functionality. This is the main source of DSLR's speed.

This means that taking a snapshot is just creating a new database using the main
database as the template. Restoring a snapshot is just deleting the main
database and creating a new database using the snapshot database as the
template. So on and so forth.

## Contributors

[![Contributors](https://contrib.rocks/image?repo=mixxorz/DSLR)](https://github.com/mixxorz/DSLR/graphs/contributors)

## License

MIT
