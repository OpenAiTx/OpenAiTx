# kkTerminal

> kkTerminal, 웹 SSH 연결을 위한 터미널
>
> 저자: [zyyzyykk](https://github.com/zyyzyykk/)
>
> 소스 코드: https://github.com/zyyzyykk/kkTerminal
>
> Docker Hub 주소: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> 미리보기: https://ssh.kkbpro.com/
>
> 업데이트 날짜: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ 빠른 통합

HTML 웹 페이지에서 `iframe` 태그를 사용하여 빠르게 통합할 수 있습니다:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 Docker로 배포하기

1. 이미지 다운로드:

```bash
docker pull zyyzyykk/kkterminal
```

2. 포트 매핑으로 컨테이너 생성 및 실행: `-p 포트:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. 커스텀 아트 워드 설정: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. 브라우저에서 접속: `http://server-ip:3000/`

### 🛸 미리보기

아래 웹사이트에서 확인할 수 있습니다: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**모듈 미리보기 더 보기**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 기능 설명

1. kkTerminal은 웹 SSH 연결을 위한 터미널입니다. 좌측 상단의 터미널 아이콘을 클릭하고 연결 설정을 선택하여 SSH 연결을 설정할 수 있습니다.

2. 웹 페이지에서 `iframe` 태그를 사용하여 타사 웹사이트에 빠르게 통합할 수 있습니다.

3. [URL 파라미터](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)를 통해 터미널 구성을 커스터마이즈할 수 있습니다.

4. 국제화 지원 및 중/영 언어 전환 기능을 지원합니다.

5. 로컬 PC 배포를 지원하며, 시작 시 자동으로 브라우저 창을 엽니다.

6. 창 크기 자동 조정 및 한글 입력을 지원합니다.

7. 사용자별 환경설정(배경/전경색, 글자 크기, 커서 스타일, TCode 활성화 등)을 지원합니다.

8. 재시작 지원: SSH 연결 설정 또는 환경설정 변경 시 자동으로 재시작되며, SSH 연결이 끊어진 후 수동 재시작도 가능합니다.

9. 복사 및 붙여넣기 지원:

   - 복사: `Git` 터미널과 같이 텍스트 선택 시 자동으로 복사됩니다.

   - 붙여넣기: `Cmd` 터미널과 같이 마우스 오른쪽 클릭으로 붙여넣기(브라우저 접근 권한 필요)


9. 파일 관리 지원, 파일 관리 모듈에서 파일/폴더 보기, 압축 해제, 업로드/다운로드 가능

10. 다중/전체 파일 선택, 복사 및 붙여넣기, 잘라내기, 선택 전환, 열기 등 단축키 조작 지원

11. 파일 탐색 및 편집, 파일 수정 후 `ctrl+s`로 원격 서버에 저장 가능

12. [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md) 지원, 사용자 지정 TCode를 통해 Shell 스크립트와 유사한 자동화 워크플로우 구현 가능

13. 작업 기록 및 클라우드 동기화 기능 지원

14. 협업, 모니터링, Docker 기능 지원

### 👨‍💻 업데이트 내역

##### zyyzyykk/kkterminal:3.6.0: latest

- 고급 협업 기능 추가
- 고급 모니터링 기능 추가
- 고급 Docker 기능 추가
- 패키지 용량 및 웹페이지 표시 최적화

##### zyyzyykk/kkterminal:3.5.6: 

- 더 많은 URL 파라미터 지원
- 에디터 텍스트 및 이미지 크기 비율 추가
- 웹페이지 표시 최적화

##### zyyzyykk/kkterminal:3.5.3: 

- 터미널 설정을 커스터마이즈할 수 있는 URL 파라미터 추가
- 다중 윈도우 재시작 버그 수정
- 작업 기록 및 클라우드 동기화 기능 추가
- 일부 코드 로직 리팩토링

[**이전 업데이트 내역**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 아키텍처

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ 프로젝트 소개

사용자 여러분께,

시간과 에너지의 한계로 인해 앞으로 `kkTerminal`의 유지보수를 진행하지 못하게 되었음을 알립니다.

`kkTerminal`에 관심이 있거나 유지보수를 이어가고 싶으신 분은 언제든지 저에게 연락주시거나 issue를 남겨주세요.

버그를 발견하거나 새로운 기능을 개발하고 싶으신 경우에도 issue를 남겨주시기 바랍니다.

마지막으로, 그동안 `kkTerminal`에 보내주신 성원에 감사드리며, 이 프로젝트가 여러분께 실질적인 도움이 되길 진심으로 바랍니다.

감사합니다.

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 스타

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---