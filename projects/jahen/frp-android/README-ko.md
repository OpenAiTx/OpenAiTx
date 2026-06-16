# frp-android

안드로이드용 frp 클라이언트입니다. 一个 Android 平台的 frp 客户端。

## 关于 frp

[frp](https://github.com/fatedier/frp)는 고성능 리버스 프록시 애플리케이션으로, TCP, UDP, HTTP, HTTPS 등 다양한 프로토콜을 지원하는 내트워크 터널링에 특화되어 있습니다.

## 功能特性

- **frpc 와 frps 듀얼 모드**: 클라이언트 또는 서버로 실행 가능
- **다양한 구성 포맷**: INI, TOML, YAML, JSON 지원
- **구성 관리**: 길게 눌러 드래그로 정렬, 구성 내보내기 및 가져오기
- **루트 권한 불필요**: 루트 없이 모바일에서 사용 가능
- **백그라운드 실행**: 백그라운드 서비스 지원, 각 구성 별로 개별 시작/중지 가능

## 构建说明

### 环境要求

- [Android Studio](https://developer.android.com/studio) 3.2 이상
- JDK 8 이상
- Android SDK API 19 이상 (minSdk)
- frp 동적 라이브러리: 직접 준비하거나 앱 내 버전 관리 기능을 통해 다운로드 필요

### 构建步骤

```bash
# 克隆仓库
git clone https://github.com/jahen/frp-android.git
cd frp-android

# 构建 Debug
./gradlew assembleDebug

# 构建 Release（默认使用 debug 签名，如需正式签名请配置 keystore）
./gradlew assembleRelease
```
### Release 서명(선택 사항)

커스텀 keystore로 Release 패키지를 서명하려면:

1. `keystore.properties.example` 파일을 복사하여 `keystore.properties`로 이름을 변경합니다(프로젝트 루트 디렉토리에 위치).
2. 텍스트 편집기로 `keystore.properties`를 열고 keystore 정보를 입력합니다:
   - `storeFile`: keystore 파일 경로(프로젝트 루트 디렉토리를 기준으로, 예: `../release.keystore`는 상위 디렉토리를 의미)
   - `storePassword`: keystore 비밀번호
   - `keyAlias`: 키 별칭
   - `keyPassword`: 키 비밀번호
3. `storeFile`에 지정한 경로에 keystore 파일이 존재하는지 확인합니다


```properties
# keystore.properties 示例
storeFile=../release.keystore
storePassword=your_store_password
keyAlias=your_key_alias
keyPassword=your_key_password
```

**注意：`keystore.properties` 和 `*.keystore` 已加入 `.gitignore`，切勿提交！**

## 许可证

[Apache License 2.0](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-16

---