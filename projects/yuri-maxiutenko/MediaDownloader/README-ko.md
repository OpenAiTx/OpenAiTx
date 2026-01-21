미디어 다운로드 프로젝트
![Media Downloader 로고](https://raw.githubusercontent.com/yuri-maxiutenko/MediaDownloader/master/MediaDownloader/Images/icon.png)
====================
훌륭한 비디오 다운로드 커맨드라인 유틸리티 [yt-dlp](https://github.com/yt-dlp/yt-dlp)를 기반으로 한 작고 사용자 친화적인 UI 래퍼(C#/WPF, .NET)로, 다양한 인터넷 리소스(YouTube, Vimeo, Facebook 등)에서 여러 품질의 비디오를 다운로드할 수 있습니다. 재생목록 다운로드도 지원합니다.

## 주요 기능

**Media Downloader**는 주요 제공자(YouTube, Vimeo, Facebook 등)의 거의 모든 비디오를 다운로드할 수 있습니다. 링크만 입력하면 끝! 재생목록 링크도 문제없습니다.

현재 애플리케이션은 다음과 같은 다운로드 형식을 지원합니다:

* 최고 품질 비디오
* 최고 품질 MP4 비디오
* 직접 링크로 이용 가능한 최고 품질 비디오
* 오디오만

또한, **Media Downloader**는 다운로드 기록을 지원하며 최근 사용한 폴더 목록을 저장합니다.

애플리케이션 자체, [yt-dlp](https://github.com/yt-dlp/yt-dlp), 그리고 [FFmpeg](https://ffmpeg.org/) 변환기를 포함하는 설치 프로그램과 함께 제공됩니다.

애플리케이션은 현재 사용자의 AppData 폴더에 설치되며 관리자 권한이 필요하지 않습니다.

현재 **Media Downloader**는 영어와 러시아어로 현지화되어 있습니다. 애플리케이션 언어는 현재 Windows 로케일에 따라 자동으로 선택됩니다.

## 요구 사항

버전 **2.1**부터 애플리케이션은 **[.NET 7 데스크톱 런타임](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)**을 사용합니다. 그러나 Media Downloader는 **[셀프 컨테인드 애플리케이션](https://devblogs.microsoft.com/dotnet/app-trimming-in-net-5/)**으로 제공되므로 별도 설치가 필요하지 않습니다.

또한, **yt-dlp**는 **[Microsoft Visual C++ 2010 재배포 패키지 (x86)](https://www.microsoft.com/en-us/download/details.aspx?id=5555)**가 필요합니다.

## 스크린샷

비디오 다운로드 진행 중:
![비디오 다운로드 진행 중](https://github.com/yuri-maxiutenko/MediaDownloader/blob/master/Screenshots/Annotation%202020-06-29%20210558.png?raw=true)

비디오 다운로드 완료:
![비디오 다운로드 완료](https://github.com/yuri-maxiutenko/MediaDownloader/blob/master/Screenshots/Annotation%202020-06-29%20210909.png?raw=true)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-21

---