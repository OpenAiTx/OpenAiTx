# Davinci Resolve プロジェクトサーバー

![Lint](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/lint.yml/badge.svg)
![Healthcheck](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/stack-healthcheck.yml/badge.svg)
![Docker Build](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/docker.yml/badge.svg)

自動バックアップ機能付きのシンプルなResolveプロジェクトサーバー

## 目次

- [Davinci Resolve プロジェクトサーバー](#davinci-resolve-project-server)
  - [目次](#table-of-contents)
  - [紹介](#introduction)
    - [特徴](#features)
  - [設定](#configuration)
    - [データベース](#database)
    - [バックアップ](#backups)
    - [PGAdmin](#pgadmin)
    - [ボリュームの場所](#volume-locations)
  - [インストール](#installation)
    - [QNAP インストール](#qnap-installation)
    - [Synology](#synology)
    - [Linux](#linux)
  - [異なるPostgreSQLバージョン](#different-postgresql-versions)
    - [PostgreSQL 9.5または11のプロジェクトサーバー設定](#setting-up-a-postgresql-95-or-11-project-server)
  - [感謝](#thanks)

## 紹介

Resolveプロジェクトサーバーをホストする方法は多くありますが、それぞれに独自の問題点があります。公式のプロジェクトサーバーは手動バックアップが必要であり、他のオプションはITチームにアクセスできない人には複雑な場合があります。これが小規模チームにとってより信頼性が高くシンプルなソリューションになることを願っています！

### 特徴

- **軽量** - Dockerベースなので、完全なmacOSやWindowsマシンやVMを必要としません。
- **プラットフォーム独立** - Windows、Mac、Linux、QNAP、Synology、RPi、Dockerが動作するほぼすべての環境にインストール可能。
- **Resolveの既存のバックアップ/復元機能と互換性あり** - すべてのバックアップファイルは標準のResolve \*.backupファイル構文を使用し、ResolveのUIから復元可能。
- **組み込みPGAdminサーバー** - PGAdminはPostgreSQLサーバーの管理ツールであり、問題の診断やサーバー全体の移行/更新に役立ちます。

## 設定

docker-compose.ymlファイルの先頭で、インストールを構成するために編集が必要な項目がいくつかあります：

```yaml
---
version: "3.8"
x-common:
  database: &db-environment
    POSTGRES_DB: database
    POSTGRES_USER: &pg-user postgres
    POSTGRES_PASSWORD: DaVinci
    TZ: America/Chicago
    POSTGRES_LOCATION: &db-location "???:/var/lib/postgresql/data"
  backup: &backup-environment
    SCHEDULE: "@daily"
    BACKUP_KEEP_DAYS: 7
    BACKUP_KEEP_WEEKS: 4
    BACKUP_KEEP_MONTHS: 6
    BACKUP_LOCATION: &bk-location "???:/backups"
  admin: &admin-environment
    PGADMIN_DEFAULT_EMAIL: admin@admin.com
    PGADMIN_DEFAULT_PASSWORD: root
    PGADMIN_PORT: &pgadmin-port "3001:80"
```
### データベース

サーバー自体を設定するには、以下の環境変数を設定します：
| 環境変数 | 意味 |
|---|---|
| POSTGRES_DB | データベース名。好きな名前を付けてください。 |
| POSTGRES_USER | データベースに接続するためのユーザー名。Resolveのデフォルトは「postgres」です。 |
| POSTGRES_PASSWORD | データベースに接続するためのパスワード。Resolveのデフォルトは「DaVinci」です。 |
| TZ | タイムゾーン。こちらは[リスト](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones)です。 |
| POSTGRES_LOCATION | データベースが保存される場所。[ボリュームの場所](#volume-locations)を参照してください。 |

### バックアップ

バックアップを設定するには、以下の変数を設定します：
| 環境変数 | 意味 |
|---|---|
| SCHEDULE | バックアップ作成の頻度を示す[cron文字列](https://www.freeformatter.com/cron-expression-generator-quartz.html)。例：「@daily」、「@every 1h」など。 |
| BACKUP_KEEP_DAYS | 削除前に保持する日次バックアップの数。 |
| BACKUP_KEEP_WEEKS | 削除前に保持する週次バックアップの数。 |
| BACKUP_KEEP_MONTHS | 削除前に保持する月次バックアップの数。 |
| BACKUP_LOCATION | バックアップが保存される場所。[ボリュームの場所](#volume-locations)を参照してください。 |

### PGAdmin

PGAdminを設定するには、以下の変数を設定します：
| 環境変数 | 意味 |
|---|---|
| PGADMIN_DEFAULT_EMAIL | PGAdminログインに使用するメールアドレス。デフォルトは「admin@admin.com」です。 |
| PGADMIN_DEFAULT_PASSWORD | PGAdminログインに使用するパスワード。デフォルトは「root」です。 |
| PGADMIN_PORT | PGAdminを公開するポートを設定する文字列。書式は「YOUR_PORT:80」です。 |

### ボリュームの場所

データベースおよびバックアップの保存場所は、インストールするプラットフォームによって異なります。保存したいフォルダのフルパスが必要です。例えばQNAP NASの場合、バックアップの場所として「Videos」という共有フォルダ内の「Backups」というフォルダを使いたい場合、パスは`/shares/Videos/Backups/`となり、`BACKUP_LOCATION`の値は次のようになります：


```yaml
BACKUP_LOCATION: &bk-location "/shares/Videos/Backups/:/backups"
```

Ubuntuでは、ユーザー名が「johndoe」のホームディレクトリにある「database」という名前のフォルダをデータベースの場所として使用したい場合、パスは`/home/johndoe/database/`となり、`POSTGRES_LOCATION`の値は次のようになります。

```yaml
POSTGRES_LOCATION: &db-location "johndoe/database/:/var/lib/postgresql/data"
```
データベースはSSDに配置することをお勧めします。回転式ドライブではアクセス速度が明らかに遅くなります。

これらの設定を構成したら、変更したdocker-compose.ymlファイルを保存して、インストールに進みましょう！

## インストール

### QNAP インストール

QNAP NASへのインストールは比較的簡単です。ひとつ注意点として、データベースファイルはSSDに置いてください。後で感謝されるはずです。

1. まだインストールしていなければ、QNAPアプリストアからContainer Stationをインストールします。
2. Container Stationで「作成」をクリックし、「アプリケーションの作成」をクリックします。
3. アプリケーション名は好きな名前を付けてください（例：ResolveServer）。
4. 変更したdocker-compose.ymlファイルをコピー＆ペーストし、「YAMLを検証」をクリックしてテストし、問題なければ「作成」をクリックします。
5. Container Stationが必要なファイルをダウンロードし、アプリを起動します。完了したら、データベース名と認証情報を使ってQNAPのIPアドレスにResolveから接続できるはずです。

### Synology

[こちらのディスカッション](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/discussions/15#discussioncomment-4615278)を参照してください。

### Linux

1. [Linuxディストリビューション向けDockerインストール手順](https://docs.docker.com/engine/install/)に従ってください。
2. [Docker Composeをインストール](https://docs.docker.com/compose/install/)します。
3. 変更したdocker-compose.ymlファイルをLinuxマシンのフォルダに移動し、ターミナルでそのフォルダに移動します。
4. 以下を実行します：
   `docker-compose up -d`
5. Docker-composeが必要なファイルをダウンロードし、アプリを起動します。完了したら、データベース名と認証情報を使ってLinuxサーバーのIPアドレスにResolveから接続できるはずです。

## 異なるPostgreSQLバージョンについて

一般的に、ResolveはPostgreSQLのバージョン不一致に非常に寛容ではありません。Resolve 18はPostgreSQL 13を使用しており、このリポジトリは現在これをデフォルトとしています。Resolve 17以下はPostgreSQL 9.5を使用しています。残念ながら、メジャーリリース9.5はEOLであり、特に9.5.4には多くの脆弱性があり安全ではありません。
ほとんどのユーザーはサーバーにデフォルトのResolve認証情報を使っているため、セキュリティは大きな問題ではありませんが、古いバージョンのResolveでプロジェクトサーバーを保護しようとしている場合は、サポートされているPostgreSQLのバージョンに移行することをお勧めします。

Resolve 17以下はPostgreSQL 12で削除されたレガシー機能をまだ使用しているため、使用可能な最新のメジャーバージョンは11であり、2023年11月9日までメンテナンスされます。

### PostgreSQL 9.5または11のプロジェクトサーバーのセットアップ

PostgreSQL 13ではなく9.5または11のサーバーをセットアップするには、docker_compose.yml内の2行を変更する必要があります：


```yaml
services:
  postgres:
    image: postgres:13
    ...
  pgbackups:
    image: prodrigestivill/postgres-backup-local:13
    ...
...
```
次のように：


```yaml
services:
  postgres:
    image: postgres:9.5
    ...
  pgbackups:
    image: prodrigestivill/postgres-backup-local:9.5
    ...
...
```

## ありがとう

-[prodrigestivill](https://github.com/prodrigestivill/) 彼の [PostgreSQL バックアップ docker イメージ](https://github.com/prodrigestivill/docker-postgres-backup-local) に感謝します


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---