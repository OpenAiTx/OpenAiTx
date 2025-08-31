# Whispera

내장 음성 인식을 OpenAI의 Whisper로 대체하여 뛰어난 전사 정확도를 제공하는 네이티브 macOS 앱입니다. 음성, 로컬 파일, 유튜브 동영상, 네트워크 스트림을 전사하며 모두 Neural Engine에서 로컬로 처리됩니다.
<div align="center">
  
  ### [⬇️ 최신 버전 다운로드](https://github.com/sapoepsilon/Whispera/releases/latest)
  
  [![GitHub release (latest by date)](https://img.shields.io/github/v/release/sapoepsilon/Whispera?style=for-the-badge&logo=github&color=0969da&labelColor=1f2328)](https://github.com/sapoepsilon/Whispera/releases/latest)
  
</div>

## 데모

<table>
  <tr>
    <th>음성-텍스트 필드</th>
    <th>타임스탬프가 있는 파일/URL 전사</th>
  </tr>
  <tr>
    <td width="50%">
      <video src="https://github.com/user-attachments/assets/1da72bbb-a1cf-46ee-a997-893f1939e626" controls>
        사용 중인 브라우저는 비디오 태그를 지원하지 않습니다.
      </video>
    </td>
    <td width="50%">
      <video src="https://github.com/user-attachments/assets/d573bef4-a3b2-49ac-a1fd-3c6735648fdc" controls>
        사용 중인 브라우저는 비디오 태그를 지원하지 않습니다.
      </video>
    </td>
  </tr>
</table>

## 기능

- **실시간 전사** (베타)
- **음성-텍스트 변환** - macOS 기본 음성 인식을 WhisperKit(OpenAI의 Whisper 모델, Neural Engine 탑재)으로 대체하여 정확도 향상
- **파일 전사** - 오디오 및 비디오 파일 지원
- **네트워크 미디어 전사** - 스트리밍 비디오/음악 URL 지원
- **유튜브 전사**

모든 처리는 로컬에서 실행됩니다. 초기 모델 다운로드에만 인터넷이 필요합니다.
## 로드맵

- [x] 영어 외 다국어 지원
  - **PR**: https://github.com/sapoepsilon/Whispera/pull/2
  - **릴리스**: https://github.com/sapoepsilon/Whispera/releases/tag/v1.0.3
- [x] 실시간 번역 기능
  - **PR**: https://github.com/sapoepsilon/Whispera/pull/17
  - **릴리스**: https://github.com/sapoepsilon/Whispera/releases/tag/v1.0.18
- [ ] 추가 맞춤 설정 옵션

## 사용법

기본 macOS 받아쓰기 대신 설정한 전역 단축키를 사용하여 Whisper로 전사 작업을 시작하세요.

## 알려진 문제

- 이 앱은 인텔 맥에서 작동하지 않습니다([이슈 15](https://github.com/sapoepsilon/whispera/issues/15) 참고)
- 자동 설치가 작동하지 않으므로, 앱 다운로드 후 수동으로 앱을 `/Application` 폴더로 드래그 앤 드롭하세요
## 요구 사항

- macOS 13.0 이상
- Apple Silicon
- 인텔 맥 지원 작업 중

## 크레딧

다음으로 제작됨:
- [WhisperKit](https://github.com/argmaxinc/WhisperKit) - Apple Silicon용 온디바이스 Whisper 전사
- [YouTubeKit](https://github.com/alexeichhorn/YouTubeKit) - 유튜브 콘텐츠 추출
- [swift-markdown-ui](https://github.com/gonzalezreal/swift-markdown-ui)


이 프로젝트들 덕분에 개인정보 보호 중심의 로컬 전사가 현실화되었습니다.

## 라이선스

MIT 라이선스


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-31

---