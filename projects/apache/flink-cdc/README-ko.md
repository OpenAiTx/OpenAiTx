<p align="center">
  <a href="https://nightlies.apache.org/flink/flink-cdc-docs-stable/"><img src="https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/flinkcdc-logo.png" alt="Flink CDC" style="width: 375px;"></a>
</p>
<p align="center">
<a href="https://github.com/apache/flink-cdc/" target="_blank">
    <img src="https://img.shields.io/github/stars/apache/flink-cdc?style=social&label=Star&maxAge=2592000" alt="Test">
</a>
<a href="https://github.com/apache/flink-cdc/releases" target="_blank">
    <img src="https://img.shields.io/github/v/release/apache/flink-cdc?color=yellow" alt="Release">
</a>
<a href="https://github.com/apache/flink-cdc/actions/workflows/flink_cdc_ci.yml" target="_blank">
    <img src="https://img.shields.io/github/actions/workflow/status/apache/flink-cdc/flink_cdc_ci.yml?branch=master" alt="Build">
</a>
<a href="https://github.com/apache/flink-cdc/actions/workflows/flink_cdc_ci_nightly.yml" target="_blank">
    <img src="https://img.shields.io/github/actions/workflow/status/apache/flink-cdc/flink_cdc_ci_nightly.yml?branch=master&label=nightly" alt="Nightly Build">
</a>
<a href="https://github.com/apache/flink-cdc/tree/master/LICENSE" target="_blank">
    <img src="https://img.shields.io/static/v1?label=license&message=Apache License 2.0&color=white" alt="License">
</a>
</p>


Flink CDC는 실시간 데이터와 배치 데이터를 위한 분산 데이터 통합 도구입니다. Flink CDC는 YAML을 통한 데이터 이동 및 변환의 단순함과 우아함을 [데이터 파이프라인](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md)에서 제공합니다.

Flink CDC는 효율적인 종단 간 데이터 통합을 우선시하며, 전체 데이터베이스 동기화, 샤딩 테이블 동기화, 스키마 진화, 데이터 변환 등 향상된 기능을 제공합니다.

![Flink CDC 프레임워크 설계](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### 빠른 시작 가이드

Flink CDC는 CdcUp CLI 유틸리티를 제공하여 플레이그라운드 환경을 시작하고 Flink CDC 작업을 실행할 수 있습니다.
Docker와 Docker compose 환경이 필요합니다.

1. `git clone https://github.com/apache/flink-cdc.git --depth=1` 명령어로 Flink CDC 소스 코드를 내려받습니다.
2. `cd tools/cdcup/ && ./cdcup.sh init` 명령어로 CdcUp 도구를 사용하여 플레이그라운드 환경을 시작합니다.
3. `./cdcup.sh up` 명령어로 도커 컨테이너를 부팅하고, 준비될 때까지 기다립니다.
4. `./cdcup.sh mysql` 명령어로 MySQL 세션을 열고, 최소 하나의 테이블을 생성합니다.

```sql
-- 데이터베이스 및 테이블 초기화
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- 테스트 데이터 삽입
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- 데이터가 정상적으로 삽입되었는지 확인
SELECT * FROM test_table;
```

5. `./cdcup.sh pipeline pipeline-definition.yaml` 명령어로 파이프라인 작업을 제출합니다. 추가 설정을 위해 파이프라인 정의 파일을 수정할 수도 있습니다.
6. `./cdcup.sh flink` 명령어로 Flink Web UI에 접근합니다.

### 시작하기

1. [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) 클러스터를 준비하고, `FLINK_HOME` 환경 변수를 설정합니다.
2. [Flink CDC tar 다운로드](https://github.com/apache/flink-cdc/releases) 후 압축을 풀고, 파이프라인 커넥터의 jar 파일을 Flink `lib` 디렉토리에 넣습니다.

> macOS 또는 Linux를 사용하는 경우, `brew install apache-flink-cdc`를 사용하여 Flink CDC와 호환 커넥터를 빠르게 설치할 수 있습니다.

3. **YAML** 파일을 생성하여 데이터 소스와 싱크를 정의합니다. 다음 예시는 MySQL의 app_db 데이터베이스 내 모든 테이블을 Doris로 동기화합니다:
  ```yaml
   source:
     type: mysql
     hostname: localhost
     port: 3306
     username: root
     password: 123456
     tables: app_db.\.*

   sink:
     type: doris
     fenodes: 127.0.0.1:8030
     username: root
     password: ""

   transform:
     - source-table: adb.web_order01
       projection: \*, format('%S', product_name) as product_name
       filter: addone(id) > 10 AND order_id > 100
       description: 필드 매핑 및 필터
     - source-table: adb.web_order02
       projection: \*, format('%S', product_name) as product_name
       filter: addone(id) > 20 AND order_id > 200
       description: 필드 매핑 및 필터

   route:
     - source-table: app_db.orders
       sink-table: ods_db.ods_orders
     - source-table: app_db.shipments
       sink-table: ods_db.ods_shipments
     - source-table: app_db.products
       sink-table: ods_db.ods_products

   pipeline:
     name: Sync MySQL Database to Doris
     parallelism: 2
     user-defined-function:
       - name: addone
         classpath: com.example.functions.AddOneFunctionClass
       - name: format
         classpath: com.example.functions.FormatFunctionClass
  ```
4. `flink-cdc.sh` 스크립트를 사용하여 파이프라인 작업을 제출합니다.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. Flink WebUI 또는 하위 데이터베이스를 통해 작업 실행 상태를 확인합니다.

더 자세한 [튜토리얼](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md)로 직접 실습해보세요.
또한, 현재 제공되는 커넥터의 포괄적인 카탈로그와 더 자세한 설정을 [커넥터 개요](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md)에서 확인할 수 있습니다.

### 커뮤니티 참여하기

Apache Flink CDC 커뮤니티에 참여하는 방법은 다양합니다.
[메일링 리스트](https://flink.apache.org/what-is-flink/community/#mailing-lists)는 모든 Flink 커미터들이 주로 활동하는 공간입니다. 사용자 지원 및 문의는 user 메일링 리스트를 이용해주세요. Flink CDC에서 문제를 발견했다면, [Flink jira](https://issues.apache.org/jira/projects/FLINK/summary)를 생성하고 `Flink CDC` 태그를 달아주세요.   
버그 및 기능 요청은 dev 메일링 리스트 또는 Jira에서 논의할 수 있습니다.

### 기여하기

Flink CDC에 기여를 환영합니다. 자세한 내용은 [개발자 가이드](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)와 [API 가이드](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md)를 참고하세요.

### 라이선스

[Apache 2.0 라이선스](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).

### 특별한 감사

Flink CDC 커뮤니티는 버그 리포트 제출, 문서 개선, 버그 수정·테스트 추가·신기능 개발을 위한 코드 기여 등 다양한 방식으로 기여해주시는 모든 분을 환영합니다.     
열정적으로 기여해주신 모든 분들께 감사드립니다.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---