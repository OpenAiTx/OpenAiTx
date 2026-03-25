# 순수 SQL 레이트레이서

누구나 언젠가는 레이트레이서를 작성합니다. 이것이 저의 작품입니다.

## 예제 출력값들

<img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/dielectricparty.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/oneglassball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onemirrorball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/glassmatrix.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/airy.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onediamondball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/oneantiglassball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/adjacentballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onegreyball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/reflectiontest.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/twodiffuseballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/onegreenball.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/threemirrors.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/twomirrorballs.png" width=200> <img src="https://raw.githubusercontent.com/chunky/sqlraytracer/master/example_outputs/busyday.png" width=200>

## 사용법

```shell
sh create.sh
```

```postgres_connection.sh``` 파일에는 호스트/데이터베이스/사용자/비밀번호 등이 포함되어 있습니다.  
"postgres, 버전 10 이상 같은 것" 외에는 특별한 요구 사항이 없습니다.  

참고로, 저는 우분투 데스크탑에서 다음과 같이 만들었습니다:  
```shell

sudo su - postgres
createuser --pwprompt raytracer
createdb -O raytracer raytracer
```

### 개발 및 렌더링을 위한 조절장치

개발 중에는 몇 분 걸리는 렌더링 시간이 꽤
느린 사이클 타임임이 분명합니다. 속도를 높이고 품질을 낮출 수 있는 몇 가지 조절장치가 있습니다.
이들은 setup.sql의 "camera"와 "img"에 있습니다:

* *samples\_per\_px* - 픽셀당 광선/서브 샘플 수입니다.
  - 디버깅 중에는 1 또는 2가 적당합니다
  - 15-20이면 "실용적인" 그림이 나옵니다
  - 50을 넘으면 눈에 띄는 개선이 거의 없습니다
* *max\_ray\_depth* - 최대 광선 반사 횟수
  - 단순한 장면에서는 보통 5회 내외 반사만 발생합니다
* *res\_x* 및 *res\_y* - 최종 이미지 해상도
  - 작을수록 빠릅니다

주요 CTE는 최종 출력에 불필요한 많은 내용을 포함합니다.
이는 장면을 통과하는 광선 반사를 조사하기 위함입니다:
```sql
SELECT * FROM rays WHERE img_x=100 AND img_y=250
```

gnuplot을 사용하여 장면을 빠르고 간단하게 볼 수 있는 스크립트가 있습니다;
스크립트 ```show_scene.sh```는 출력물이 담긴 폴더를 생성해야 합니다.

## 데이터베이스

이것은 순수 SQL로 구현되었습니다. CREATE FUNCTION 같은 비이식적인 것은 하지 않으며,
애니메이션을 위한 트리거를 제외하면 당연히 포함되지 않습니다.

동시에, 이 SQL에서는 약간 덜 흔한 기능들이 필요합니다:

* JOIN LATERAL
* RECURSIVE CTE 내에서 PARTITION BY
* SIN() 같은 수학 함수

그래서 SQLite로 개발을 시작했지만 결국 PostgreSQL에 의존하게 되었습니다.
이 글을 쓰는 시점에는 postgres에서 작동하며 다른 곳에서는 테스트되지 않았습니다.

## 흥미로운 구현 요소

이 정도이지만, 저는 흥미로운 방식으로 문제를 해결하는 경우가 있었습니다.

### JOIN LATERAL

JOIN LATERAL은 WHERE 절이 아니라 JOIN에서 상관 서브쿼리를 수행하는 방법입니다.
저는 이를 계산을 끌어올리고 여러 번 하는 것을 한 번만 하게 하거나,
경우에 따라 과도한 중복을 피하기 위해 사용합니다.

### 확산 산란 (Diffuse Scattering)

이는 균일한 구체 표본 추출을 필요로 합니다. 저는 많은 난수 샘플을 미리 생성합니다
[거부 샘플링 -> 구체 표면에 점들을 스케일링], 그리고 번호를 매깁니다.

각 광선을 미리 계산된 산란 샘플 중 하나에 연결하는 방법을 찾는 것이 이상했는데;
RANDOM()에 단순히 조인하면 모든 광선이 같은, 임의의 산란에 연결됩니다.
일반적인 법선 계산으로 선택하면 그림에 줄무늬가 생깁니다.
그래서 대신, 법선의 한 차원의 소수점 이하 몇 자리를 꺼내어 거기에 조인합니다.
이것은 "무작위"이면서도 광선마다 충분히 고유합니다.

### 재귀 CTE

레이 트레이싱은 재귀 CTE가 작동하는 방식을 매우 자연스럽게 따릅니다.
제가 만난 것 중 하나는 어떤 광선을 처리할지 깔끔하게 식별하는 방법이었습니다.
절편(t)으로 정렬하는 윈도우 함수가 잘 작동했습니다.
매 반복마다, 이 쿼리는 광선을 앞에 있는 *모든* 것과 교차시키고
연관된 모든 계산을 수행하지만, WHERE 절에서는 광선이 실제로 맞은 것만 남깁니다.

또한, 최종 집계의 핵심 부분의 단순함에는 정말 아름다운 점이 있습니다 [명확성을 위해 편집됨]:
```sql
```









 SELECT img_x, img_y,
         SUM(POW(color_mult * ray_col_r/samples_per_px, gamma)) col_r,
         SUM(POW(color_mult * ray_col_g/samples_per_px, gamma)) col_g,
         SUM(POW(color_mult * ray_col_b/samples_per_px, gamma)) col_b
    FROM rays
    GROUP BY img_y, img_x
```

### 장면, 재료 등

이것이 SQL로 되어 있기 때문에 데이터베이스에 여러 장면을 저장할 수 있습니다. 실제로 렌더링되는 장면은 "camera" 테이블에서 선택됩니다.

## 거인의 어깨 위에 서서

이 글을 쓰기 2년 전에 "현재 시장에서 가장 진보된 MySQL 레이 트레이서"가 소셜 미디어에서 화제를 모았습니다:
https://www.pouet.net/prod.php?which=83222

제가 다르게 하고 싶었던 몇 가지가 있었습니다 [더 나쁘게?]:

* 데모신은 예술 형태입니다. 저는 골프 치는 게 아니고, 이건 압축된 코드가 아닙니다
* 단일 쿼리 사용 안 함; CTE로 할 수는 있지만, 음...
* 최종 목표로 애니메이션 구현 [```anim.sh``` 참고]
* 주로, 저는 단지 부적절한 도구로 장난치는 중입니다

### 저는 Claude에게 의견을 물었습니다

*"왜 누군가가 처음에 이런 것을 썼을까요?"*

> 이것은 SQL을 범용 프로그래밍 언어로 극단적으로 활용한 흥미로운 사례입니다. 누군가가 PostgreSQL SQL로 완전한 레이 트레이서를 작성했는데, 이는 인상적이면서도... 의심스럽습니다.
> 
> [...]
> 
> 이것은 아마도 뛰어난 컴퓨터 과학 학생의 논문 프로젝트, 시니어 엔지니어의 주말 실험, 또는 매우 제한적인 데이터베이스 전용 환경에 갇혀 레이 트레이싱 꿈을 포기하지 않은 누군가의 작품처럼 느껴집니다.
> 
> 레고로 경주용 차를 만드는 프로그래밍의 비유와 같습니다 - 기술적으로 인상적이지만, 실제로 운전해서는 안 됩니다.

칭찬인지 모욕인지 알 수가 없습니다.

## 참고 문헌

대부분은 "Ray Tracing in One Weekend" 시리즈를 따라 작성되었습니다:
https://raytracing.github.io/ , 그리고 제가 일부러 난해하게 코딩하는 방식을 감안하여 조정하였습니다.


Gary <chunky@icculus.org>

```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-25

---