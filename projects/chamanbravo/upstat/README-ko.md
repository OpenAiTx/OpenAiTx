
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# Upstat

> 간단하고 사용하기 쉬운 자체 호스팅 상태 모니터링 도구

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 라이브 데모

직접 사용해보세요.

데모 서버 (위치: 싱가포르): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

사용자명: `demo`
비밀번호: `demodemo`

## ⭐ 특징

아직 더 많은 기능이 필요하지만, 현재는...

- HTTP(s) 가용성 모니터링
- 상태 및 지연 시간 차트
- Discord를 통한 알림
- 60초 간격
- 세련되고 반응 빠른 UI/UX
- 다중 상태 페이지 지원
- 특정 도메인에 상태 페이지 매핑
- 핑 차트
- 인증서 정보
- PWA
- Sqlite 및 Postgres 데이터베이스 지원

그리고 앞으로 추가될 수십 가지의 작은 기능들.

## 🔧 설치 방법

### 🐳 도커

Sqlite 용

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```
Postgres용  


```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```
Upstat는 이제 http://localhost:3000 에서 실행 중입니다

> [!IMPORTANT]
> 배포 전에 환경 변수를 반드시 변경하세요.

### 💪🏻 Non-Docker

요구 사항:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (선택 사항)


```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```
## 기술 스택

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 기여하기

기여를 환영합니다! 기여는 오픈 소스 커뮤니티를 배우고, 영감을 얻고, 창조하는 놀라운 장소로 만드는 원동력입니다. 여러분이 하는 모든 기여는 **매우 감사드립니다**.

이 프로젝트를 더 좋게 만들 제안이 있다면, 리포지토리를 포크하고 변경 사항을 만든 후 풀 리퀘스트를 생성해 주세요. "enhancement" 태그를 붙여 이슈를 열어도 됩니다.
프로젝트에 별도 꼭 눌러주세요! 다시 한번 감사합니다!

1. 프로젝트 포크하기
2. 기능 브랜치 생성 (`git checkout -b feature/AmazingFeature`)
3. 변경 사항 커밋 (`git commit -m 'Add some AmazingFeature'`)
4. 브랜치에 푸시 (`git push origin feature/AmazingFeature`)
5. 풀 리퀘스트 열기

## 기여자

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 라이선스

이 프로젝트는 [MIT 라이선스](https://opensource.org/license/mit/) 하에 라이선스가 부여되었습니다.

## 🖼 추가 스크린샷

모니터 생성

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

모니터 페이지

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />


Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---