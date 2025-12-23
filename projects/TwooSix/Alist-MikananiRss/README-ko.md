
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<h1 align="center">
  Alist-MikananiRss
</h1>
<p align="center">
  <a href="https://mikanani.me/">미캉 프로젝트</a> 또는 기타 애니메이션 관련 RSS 피드에서 자동으로 애니메이션 업데이트를 가져와 Alist를 통해 해당 클라우드에 오프라인 다운로드
</p>  
<p align="center">
  그리고 ChatGPT를 활용해 리소스명을 분석하여, Emby에서 인식 가능한 형식으로 파일명을 자동으로 변경합니다.
</p>
</p>  

--- 

[사용 설명서](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## 기능
- 애니메이션 업데이트를 자동으로 가져와서 해당 클라우드 드라이브에 다운로드
- PushPlus, Telegram 등 채널을 통해 업데이트 알림 전송
- 자동으로 emby 인식 형식으로 파일명을 변경하며, 자동 해석 결과에 대한 사용자 지정 매핑도 지원하여 이름 변경 결과의 정확도 향상

## 준비 작업 
1. [Alist](https://github.com/alist-org/alist) 프로젝트 문서를 참고하여 Alist를 직접 배포하세요(버전 >=3.42.0 필요), 그리고 Aria2/qBittorrent 오프라인 다운로드도 구축하세요
2. 미칸 플랜 계정을 직접 등록하고 애니메이션을 구독한 뒤, 구독 링크를 획득하세요

참고: 기타 RSS 구독 소스에 대해서도 어느 정도 호환성을 제공하며, 이론적으로 대부분의 구독 소스(애니메이션 관련)를 지원합니다. 지원되지 않는 RSS는 issue 등록을 환영합니다.

## 사용 방법
Docker, 소스 코드 실행 등 다양한 실행 방법은 [사용 설명서](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)에서 확인하세요

pip 설치 및 실행
1. python 버전이 3.11 이상인지 확인하세요
2. pip 설치: `pip install alist-mikananirss`
3. 디렉터리에 `config.yaml` 설정 파일을 새로 만들고, 다음과 같이 설정을 작성하세요(전체 기능 예제와 상세 설명은 [설정 안내](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E) 참고)
   ```yaml
   common:
     interval_time: 300
   
   alist:
     base_url: https://example.com # 修改为你的alist访问地址
     token: alist-xxx # 修改为你的alist token；可在"管理员后台->设置->其他"中找到
     downloader: qBittorrent # 或者 aria2
     download_path: Onedrive/Anime # 修改为你的下载路径(Alist中的路径)

   mikan:
     subscribe_url:
       - https://mikanani.me/RSS/MyBangumi?token=xxx # 修改为你的蜜柑订阅地址
       # - https://mikanani.me/RSS/MyBangumi?token=xxx2 # 多条RSS订阅链接情况
   
     filters:
       - 非合集 # 程序暂不支持合集等形式的重命名，若使用重命名功能推荐使用此过滤器
   ```
4. 코드 실행: `python -m alist_mikananirss --config /path/to/config.yaml`  
5. 즐기세요


## 이름 변경 효과 시연
<div align=center>
<img src="https://github.com/TwooSix/Alist-MikananiRss/blob/master/imgs/show_pic1.png"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---