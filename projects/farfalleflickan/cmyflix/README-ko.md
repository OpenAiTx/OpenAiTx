# cmyflix
*넷플릭스 클론, 이제 C로!*

cmyflix는 또한 원본 ![Myflix](https://github.com/farfalleflickan/Myflix/)를 C로 완전히 다시 작성한 것으로, 원본보다 약 30배 **더 빠르며** 거의 모든 기능을 유지합니다.

cmyflix는 NAS용으로 라즈베리 파이/오드로이드/기타 생태계에 특히 초점을 맞춘 Plex, streama 또는 Emby와 유사한 다소 간단하고 가벼운 "DIY 넷플릭스"가 되려고 합니다. 하드웨어가 충분하고 많은 기능을 원한다면 다른 솔루션을 사용하세요 :) , 하지만 어느 정도 예쁘고 빠르며 사용할 수 있는 최소한의 기능만 제공합니다. 이 프로그램은 파일 위치와 메타데이터를 저장하는 json 데이터베이스를 생성하며, 이 데이터베이스를 사용하여 어떤 웹 서버에서든 제공할 수 있는 정적 웹 페이지를 만듭니다!    

다음 라이브러리들에 큰 감사를 드립니다: ![cwalk](https://github.com/likle/cwalk), ![cjson](https://github.com/DaveGamble/cJSON).  
cmyflix 파일을 비밀번호로 보호하고 싶다면 ![이것](https://github.com/farfalleflickan/JSONlogin)을 참고하세요!  

제 작업이 마음에 드시나요? 기부는 언제나 환영입니다 :)  
[<img src="https://raw.githubusercontent.com/andreostrovsky/donate-with-paypal/master/dark.svg" alt="donation" width="150"/>](https://www.paypal.com/donate?hosted_button_id=YEAQ4WGKJKYQQ)

# 스크린샷:  
TV 쇼 페이지
![TV shows](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/ec53e53f252f908bc8bac7f8c4486790.jpg)   

TV 쇼 시즌/에피소드 모달
![TV show episodes](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/fb31129a22d81b732ce88f02cae27fea.jpg)  


TV 쇼 에피소드 플레이어
![TV show episode player](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/102b3df4924efeae7476d6ceee79bec9.png)

영화 페이지
![Movies](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/d4271907a9af78d8dd84f3941ca1e56a.jpg)  

영화 플레이어
![Movies player](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/2eb41c935d1c11e19adb66466bcdf97e.png)

# 컴파일 방법:
make 명령어를 실행하여 간단히 컴파일하세요. 필요한 라이브러리는 (우분투 기준) `libbsd-dev libcjson-dev libcurl4-openssl-dev`입니다.

# 설치 방법:
소스에서 make install로 설치하거나 릴리스 탭에서 미리 컴파일된 패키지를 사용하세요.

주의: 미리 컴파일된 `deb` 파일은 기본 `libcurl4-openssl-dev` 백엔드를 사용하여 빌드되었습니다.

# 실행 요구 사항:
cmyflix는 libcjson(>=1.7.15), libcurl(>=7.68), imagemagick, ffmpeg 및 TMDB API 키를 사용합니다. 또한 cmyflix는 HTML5 및 지원되는 형식 사용으로 인해 `mp4`, `mkv`, `ogv`, `webm` 파일을 검색한다는 점을 유의하세요.
# 구성 및 사용법:
우선, cmyflix는 바이너리와 동일한 폴더에서 `cmyflix.cfg`를 먼저 찾고, 그 다음으로 `$HOME/.config/cmyflix/` 그리고 마지막으로 `/etc/cmyflix/`에서 찾습니다. `html` 폴더와 그 내용물도 동일한 규칙이 적용됩니다.

추가 옵션 및 정보는 구성 파일을 참고하거나 `--help` 옵션을 사용해 도움말 메뉴를 확인할 수 있습니다.

# 폴더 구조 기대 사항
cmyflix는 모든 것이 정리된 폴더에 있어야 한다는 점에서 다소 까다롭습니다.
TV 쇼의 경우, 각 쇼가 자체 폴더에 있어야 하며, 각 시즌마다 하위 폴더가 있어야 합니다(추가 콘텐츠는 "Season.Extras" 폴더에). 예: `/path/to/files/Name.of.TV.show/Season.1/Name.Of.TV.show.S01E01.mp4`.
영화는 이상적으로 각 영화마다 하위 폴더에 있어야 하며, 예: `/path/to/files/Name.of.Movie/Name.Of.Movie.mp4`. 여러 영화가 동일한 하위 폴더에 있을 수도 있습니다. 예: `/path/to/files/Movies/Star.Wars/Revenge.of.The.Sith.mp4` 및 `/path/to/files/Movies/Star.Wars/Empire.Strikes.Back.mp4`.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-27

---