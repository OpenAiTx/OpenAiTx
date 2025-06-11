# Django Ninja Shortener - Bitly 유사 단축 URL 서비스

Django, Django Ninja, Tailwind CSS로 제작된 현대적인 단축 URL 서비스로, Bitly에서 영감을 받았습니다.

사용자는 회원가입 및 로그인 후 URL을 단축할 수 있으며, 각 단축 URL의 클릭 수를 추적할 수 있습니다.

본 프로젝트는 [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline)을 활용하여 완성되었으며, [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md) 를 참고하실 수 있습니다.

## 화면 스크린샷

단축 URL 페이지(비회원도 사용 가능)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

회원가입 후에는 클릭 추적 가능

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ 기능 하이라이트

* **사용자 인증**: 사용자 회원가입, 로그인, 로그아웃 지원
* **단축 URL 생성**: 로그인한 사용자는 긴 URL을 고유한 단축 URL로 생성 가능
* **단축 URL 리디렉션**: 단축 URL 클릭 시 원래의 긴 URL로 리디렉션
* **클릭 수 추적**: 각 단축 URL의 클릭 수를 자동 계산
* **개인 대시보드**: 사용자가 생성한 모든 단축 URL 및 클릭 통계를 확인 가능
* **RESTful API**: API 엔드포인트를 통해 프로그래밍 방식으로 단축 URL 생성 지원
* **Docker 지원**: Dockerfile 및 Docker Compose 설정 제공으로 개발 및 배포 간소화

## 🛠️ 기술 스택

* **백엔드 프레임워크**: [Django](https://github.com/twtrubiks/django-tutorial)
* **API 프레임워크**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **프론트엔드 스타일**: [Tailwind CSS](https://tailwindcss.com/) (`django-tailwind`로 통합)
* **데이터베이스**:
  * 개발 환경: SQLite(기본값)
  * 운영 환경: PostgreSQL로 손쉽게 교체 가능(`settings.py`에 설정 제공)
* **단축 URL 코드**: `shortuuid` 사용
* **테스트**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **컨테이너화**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 빠른 시작 (Docker 사용, 추천)

가장 추천하는 시작 방법으로, 개발 환경의 일관성을 보장합니다.

**시작 절차:**

1. **서비스 실행:**

    Docker Compose로 모든 서비스를 한 번에 실행합니다.

    ```bash
    docker compose up --build
    ```

    이 명령어는 Docker 이미지를 빌드하고, 의존성 설치 및 데이터베이스 마이그레이션을 수행한 뒤 개발 서버를 시작합니다.

2. **슈퍼유저 생성(선택 사항):**

    Django Admin에 접근하려면 새로운 터미널에서 다음 명령을 실행하세요.

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **애플리케이션 접속:**

    * **웹사이트 홈**: [http://localhost:8000](http://localhost:8000)

    * **API 문서(Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 로컬 개발 (Docker 미사용)

로컬 환경에 직접 세팅하고 싶으신 경우

**사전 조건:**

* Python 3.12
* Node.js 및 npm(Tailwind CSS용)

**설정 절차:**

1. **가상환경 생성 및 활성화:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # Windows는 `venv\Scripts\activate` 사용
    ```

2. **Python 의존성 설치:**

    ```bash
    pip install -r requirements.txt
    ```

3. **Tailwind CSS 설치 및 설정:**

    대부분의 설정은 `django-tailwind`가 처리합니다.

    ```bash
    python manage.py tailwind install
    ```

    자세한 내용은 [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html) 참고

4. **데이터베이스 마이그레이션 실행:**

    ```bash
    python manage.py migrate
    ```

5. **슈퍼유저 생성(선택 사항):**

    ```bash
    python manage.py createsuperuser
    ```

6. **개발 서버 실행:**

    Django 서버와 Tailwind CSS 빌드 프로세스를 동시에 실행해야 합니다.

    ```bash
    python manage.py runserver
    ```

    다른 터미널에서 다음을 실행:

    ```bash
    python manage.py tailwind start
    ```

7. **애플리케이션 접속:**

    * **웹사이트 홈**: [http://localhost:8000](http://localhost:8000)

    * **API 문서(Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 테스트 실행

본 프로젝트는 `pytest`를 사용하여 테스트 및 커버리지 측정을 진행합니다.

테스트 계획은 [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md) 참고

* **Docker로 테스트 실행:**

    ```bash
    docker compose --profile test up
    ```

    테스트 리포트는 `htmlcov/index.html`에 생성됩니다.

* **로컬에서 테스트 실행:**

    ```bash
    # 개발 의존성 설치 후 진행
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 API 엔드포인트

API는 프로그래밍적으로 단축 URL 서비스를 사용할 수 있게 합니다. 모든 API 엔드포인트는 `/api/` 경로 아래에 있습니다.

**API 문서(Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs) 에서 직접 확인하는 것을 권장합니다.

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

[Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt) 사용, 먼저 `/api/token/pair`에 아이디/비밀번호로 요청해 토큰을 받으세요.

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

그 다음 토큰을 우측 상단에 붙여넣고 api를 호출하면 됩니다.

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 프로젝트 구조

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Django 프로젝트 설정
│   ├── settings.py
│   └── urls.py
├── shortener/            # 핵심 단축 URL 앱
│   ├── models.py         # 데이터베이스 모델(Link)
│   ├── api.py            # Django Ninja API 엔드포인트
│   ├── views.py          # 페이지 뷰 및 리디렉션 로직
│   └── utils.py          # 단축코드 생성 유틸
└── theme/                # Django 테마 및 템플릿
    ├── templates/        # HTML 템플릿
    └── static_src/       # Tailwind CSS 소스
```

## 💡 향후 계획

* **PostgreSQL 전환**: 운영 환경에 더 견고한 데이터베이스 사용(완료)
* **상세 분석 대시보드**: 시간, 소스, 지역 등 다양한 클릭 데이터 제공
* **사용자 지정 단축 URL**: 사용자가 단축 URL의 코드를 직접 지정할 수 있도록 허용합니다.
* **QR 코드 생성**: 각 단축 URL에 대해 대응하는 QR 코드를 생성합니다.
* **비동기 작업**: Celery를 사용하여 데이터 분석 등 시간이 오래 걸리는 작업을 처리합니다.

## 후원

모든 글은 제가 직접 연구하고 내재화하여 창작한 글입니다. 만약 도움이 되셨고 저를 응원하고 싶으시다면, 커피 한 잔 사주시면 감사하겠습니다 :laughing:

이카페이 ECPAY (회원 가입 불필요)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[후원자 결제](http://bit.ly/2F7Jrha)

오프바오 (회원 가입 필요)

![alt tag](https://i.imgur.com/LRct9xa.png)

[후원자 결제](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## 후원 명단

[후원 명단](https://github.com/twtrubiks/Thank-you-for-donate)

## 라이선스

MIT license

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---