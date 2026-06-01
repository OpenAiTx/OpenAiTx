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

데이터베이스 스냅샷, 목록 및 복원

로컬 Postgres 데이터베이스의 스냅샷을 번개처럼 빠르게 찍으세요.

## 이것이 무엇인가요?

DSLR은 데이터베이스 마이그레이션을 작성하거나, 브랜치를 전환하거나, SQL을 다룰 때
빠르게 데이터베이스 스냅샷을 찍고 복원할 수 있게 해주는 도구입니다.

이는
[Stellar](https://github.com/fastmonkeys/stellar)의 정신적 후계자를 목표로 합니다.

**중요:** DSLR은 개발 용도로만 사용하도록 설계되었습니다. 운영 데이터베이스에 DSLR을 사용하는 것은 권장되지 않습니다.

## 성능


DSLR은 스냅샷 생성에 있어 표준 `pg_dump`/`pg_restore` 방식보다 훨씬 빠릅니다.

<p align="center">
  <img src="https://user-images.githubusercontent.com/3102758/182014327-1b13da6e-63ad-4bbe-817e-7d6c66befc98.png" alt="DSLR과 pg_dump/pg_restore 간 실행 시간 비교 차트입니다. 스냅샷과 복원에서 DSLR은 각각 4.125초와 4.431초가 걸렸고, pg_dump/pg_restore는 각각 36.602초와 13.257초가 걸렸습니다.">
</p>

DSLR은 스냅샷 생성 시 8배, 스냅샷 복원 시 3배 더 빠릅니다.

<details>
  <summary>테스트 방법론</summary>
  
  Docker를 사용해 Postgres 12.3을 실행하고, 테스트 데이터베이스를 생성한 뒤, 다음 스크립트로 1GB의 랜덤 데이터를 채웠습니다:
  

  ```SQL
  CREATE TABLE large_test (num1 bigint, num2 double precision, num3 double precision);

INSERT INTO large*test (num1, num2, num3)
SELECT round(random() * 10), random(), random() \_ 142
FROM generate_series(1, 20000000) s(i);

```
다음 명령어를 사용하여 실행 시간을 측정했습니다:


```

time dslr snapshot my-snapshot
time dslr restore my-snapshot
time pg_dump -Fc -f export.dump
time pg_restore --no-acl --no-owner export.dump

```
각 명령어를 세 번 실행하고 차트에 평균값을 그렸습니다.

원시 데이터는 다음과 같습니다:

| 명령어         | 실행 | 실행 시간(초)           |
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

## 설치


```

pip install DSLR psycopg2 # or psycopg2-binary, or psycopg

```

**pipx를 사용하여 설치하기**

```

pipx install DSLR[psycopg2] # or psycopg2-binary, or psycopg

````

**uv를 사용하여 설치**

```

uv tool install 'DSLR[psycopg2]' # or psycopg2-binary, or psycopg

```

Note: DSLR `export` 및 `import` 스냅샷 명령은 `pg_dump`와
`pg_restore`가 `PATH`에 있어야 하므로, 해당 명령어를 사용하려면 Postgres CLI
유틸리티가 필요합니다.

<details>
  <summary><strong>셸 완성</strong></summary>

**Bash**

`~/.bashrc`에 다음을 추가하세요:

```
eval "$(_DSLR_COMPLETE=bash_source dslr)"
```

**Zsh**

Add this to `~/.zshrc`:

```
eval "$(_DSLR_COMPLETE=zsh_source dslr)"
```

**Fish**

이 내용을 `~/.config/fish/completions/dslr.fish`에 추가하세요:

```
eval (env _DSLR_COMPLETE=fish_source dslr)
```
이 파일은 아래 활성화 스크립트 방법에 사용된 동일한 파일입니다. Fish에서는 아마도 그 방법을 사용하는 것이 항상 더 쉬울 것입니다.

eval을 사용하면 셸이 시작될 때마다 명령이 호출되고 평가되어 셸 반응 속도가 느려질 수 있습니다. 속도를 높이려면 생성된 스크립트를 파일에 저장한 다음 소스하십시오.

**Bash**

스크립트를 어딘가에 저장하십시오.


```
_DSLR_COMPLETE=bash_source dslr > ~/.dslr-complete.bash
```
~/.bashrc 파일을 소스합니다.


```
. ~/.dslr-complete.bash
```

**Zsh**

Save the script somewhere.

```
_DSLR_COMPLETE=zsh_source dslr > ~/.dslr-complete.zsh
```

~/.zshrc 파일을 소스하세요.

```
. ~/.dslr-complete.zsh
```

**Fish**

스크립트를 ~/.config/fish/completions/foo-bar.fish에 저장하세요:

```
_DSLR_COMPLETE=fish_source dslr > ~/.config/fish/completions/dslr.fish
```

</details>



## 구성

DSLR에게 스냅샷을 찍을 데이터베이스를 지정하는 방법은 여러 가지가 있습니다:

**DATABASE_URL**

`DATABASE_URL` 환경 변수가 설정되어 있으면, DSLR은 이를 사용하여
대상 데이터베이스에 연결합니다.

```bash
export DATABASE_URL=postgres://username:password@host:port/database_name
````

**dslr.toml**

현재 디렉토리에 `dslr.toml` 파일이 있으면 DSLR은 해당 파일에서 설정을 읽습니다.  
DSLR은 환경 변수보다 이 파일을 우선시합니다.

```toml
url = 'postgres://username:password@host:port/database_name'
```

**`--url` 옵션**

마지막으로, `--url` 옵션을 통해 명시적으로 연결 문자열을 전달할 수 있습니다.  
이 옵션은 위의 모든 설정을 무시합니다.

## 사용법

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

비대화형 셸에서 기존 스냅샷을 강제로 덮어쓰려면 `-y` 플래그를 사용하세요:

```
$ dslr snapshot my-first-snapshot -y
Updated snapshot my-first-snapshot
```
## 작동 원리

DSLR은 Postgres의 [템플릿 데이터베이스](https://www.postgresql.org/docs/current/manage-ag-templatedbs.html) 기능을 사용하여 데이터베이스를 복제함으로써 스냅샷을 찍습니다. 이것이 DSLR의 속도의 주요 원천입니다.

즉, 스냅샷을 찍는다는 것은 메인 데이터베이스를 템플릿으로 사용하여 새 데이터베이스를 생성하는 것과 같습니다. 스냅샷을 복원하는 것은 메인 데이터베이스를 삭제하고 스냅샷 데이터베이스를 템플릿으로 사용하여 새 데이터베이스를 생성하는 것입니다. 이런 식으로 반복됩니다.

## 기여자

[![Contributors](https://contrib.rocks/image?repo=mixxorz/DSLR)](https://github.com/mixxorz/DSLR/graphs/contributors)

## 라이선스

MIT








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-01

---