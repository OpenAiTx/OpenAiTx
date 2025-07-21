<translate-content># 소개

[Ultracopier](https://ultracopier.herman-brule.com/)는 무료 오픈 소스
소프트웨어로 GPLv3 라이선스를 적용받으며 파일 복사 대화상자의
대체 역할을 합니다.

주요 기능은 다음과 같습니다:
- 작업 대기열
- 일시정지 / 재개
- 미완료 작업 재개
- 동적 속도 제한
- 충돌 관리
- 플러그인 지원

# 의존성
- make
- gcc
- C++17 컴파일러 (Qt6.7 때문에 필요)

예를 들어 Debian 기반 배포판에서:

```bash
sudo apt install make gcc build-essential libssl-dev qtbase6-dev qtchooser qt6-qmake qtbase6-dev-tools qttools6-dev-tools
```
# 빌드

통합 버전을 빌드하는 것은 메인 Qt 프로젝트를 컴파일하는 것만큼 간단합니다:


```bash
find ./ -name '*.ts' -exec lrelease {} \;
qmake ultracopier.pro
make -j$(nproc)
```

# Run

```bash
./ultracopier
```
# 번역

번역은 [Qt Linguist](http://doc.qt.io/qt-6/qtlinguist-index.html)를 통해 제공됩니다.

1. `lupdate ultracopier.pro`를 실행하여 번역 파일을 업데이트합니다.
2. 번역을 `(plugins|resources)/Languages/XX/translation.ts`에 넣으세요.
3. `lrelease ultracopier.pro`를 실행하여 파일을 컴파일합니다.
4. Ultracopier 릴리스에 있는 `.qm` 파일을 교체합니다.


# 플러그인

[플러그인](https://raw.githubusercontent.com/alphaonex86/Ultracopier/master/plugins/README.md) 형식의 사용자 정의도 가능합니다.


# 기여
이 프로젝트는 [Github](https://github.com/alphaonex86/Ultracopier)에 호스팅됩니다.
문제점과 병합 요청을 거기에 추가하세요!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---