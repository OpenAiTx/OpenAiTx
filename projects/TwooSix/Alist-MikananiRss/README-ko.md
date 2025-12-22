<h1 align="center">
  Alist-MikananiRss
</h1>
<p align="center">
  <a href="https://mikanani.me/">미캔 프로젝트</a> 또는 기타 애니메이션 관련 RSS 구독 소스에서 자동으로 애니메이션 업데이트를 가져와 Alist를 통해 해당 클라우드 드라이브에 오프라인 다운로드
</p>  
<p align="center">
  그리고 ChatGPT를 활용해 리소스명을 분석하여 Emby가 인식할 수 있는 형식으로 리소스명을 변경합니다.
</p>  

--- 

[사용 문서](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## 기능
- 애니메이션 업데이트를 자동으로 가져와 해당 클라우드 드라이브에 다운로드
- PushPlus, Telegram 등 채널을 통해 업데이트 알림 전송
- 자동으로 emby가 인식할 수 있는 형식으로 이름 변경, 동시에 자동 파싱 결과에 대해 사용자 정의 재매핑 지원으로 이름 변경 결과를 더욱 정확하게

## 준비 작업 
1. [Alist](https://github.com/alist-org/alist) 프로젝트 문서를 참고하여 Alist(버전>=3.42.0)를 배포하고 Aria2/qBittorrent 오프라인 다운로드 환경 구축
2. 미캔 프로젝트 계정 등록, 애니메이션 구독 및 구독 링크 획득

부록: 기타 RSS 구독 소스도 일부 적응했으며, 이론상 대부분의 애니메이션 관련 구독 소스를 지원합니다. 지원되지 않는 RSS는 issue 제보를 환영합니다.

## 사용 방법
Docker, 소스코드 실행 등 더 많은 실행 방법은 [사용 문서](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B) 참조

pip로 설치 및 실행
1. Python 버전이 3.11 이상인지 확인
2. pip로 설치: `pip install alist-mikananirss`
3. 디렉토리에 `config.yaml` 설정 파일을 새로 만들고 다음과 같이 설정 작성(전체 기능 예시는 [설정 설명](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E) 참조)
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---