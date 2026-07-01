

<img width="1920" height="1080" alt="renut logo" src="https://github.com/user-attachments/assets/273bee28-755f-4494-920f-9333af72091e" />




Originally created with <a href="https://github.com/rexglue/rexglue-sdk">Rexglue-SDK</a>



DISCORD
--------------------------------------------
We have a discord, please join and direct any questions there. Myself or someone else will happily answer them.

https://discord.gg/D5Bz2ZsHdY



Credits
------------------------------------------------
<a href="https://github.com/rexglue/rexglue-sdk">Rexglue team</a> for creating Rexglue-SDK
<br>
the Rexglue SDK discord for helping with any info they have
<br>
SolarCookies for midasm hooks and future use of CRT functions and the reNut Launcher
<br>
ValcomDrifty for the renut logo
<br>
.
<br>
.
<br>
.
<br>
.
<br>
.
<br>
.
<br>
당신, 플레이어인가요?
<br>
.


필수 조건
-------------------------------------------------------------------
북미판 반조-카주이: 넛츠 앤 볼츠 default.xex


빌드 방법
------------------------------------------------------
참고: .gitignore 파일을 모두 삭제해야 합니다. 그렇지 않으면 컴파일한 내용이 해당 파일들이 있는 영역을 인식하지 못합니다.
<br>
참고: <a href="https://git-scm.com/install/windows">GIT</a>를 먼저 설치해야 하며, 그 후에 REXGLUE-SDK를 설치하거나 이 저장소를 빌드할 수 있습니다.
<br>
참고: <a href="https://github.com/rexglue/rexglue-sdk">Rexglue-SDK</a>의 메인 저장소를 먼저 빌드하고 설치해야 계속 진행할 수 있습니다.


1. ```git clone https://github.com/masterspike52/reNut.git``` 명령어로 저장소를 복제합니다.
2. assets 폴더 내에 반조-카주이: 넛츠&볼츠 ISO 내용과 default.xex를 추출해야 합니다. <a href="https://consolemods.org/wiki/images/5/5f/XBOX360_ISO_Extract.zip">iso extract</a> 사용을 추천합니다. (리눅스 사용자는 어떤 걸 쓰는지 모르겠으나, 저는 윈도우를 사용하며 iso extract는 WINE을 통해 리눅스에서도 작동합니다.)
3. 복제한 git 폴더 내에서 터미널을 열고 ```rexglue migrate --app_root .``` 명령을 실행합니다. 이는 Rexglue에서 codegen 관련 변경사항이 있을 경우 올바르게 코드생성을 보장합니다.
   3b. 이후 out 폴더를 삭제하거나 윈도우 사용자는 VS를 열고 cmakelists.txt를 우클릭하여 캐시를 삭제하고 재구성하여 사용하는 버전으로 코드생성을 해야 합니다.
4. 이제 터미널에서 ```rexglue codegen renut_config.toml``` 명령을 실행하면 generated 폴더 내에 다시 컴파일할 ppc 파일이 생성됩니다.
5. 윈도우 사용자는 VS에서 프로젝트를 열고 빌드 타입을 `win-amd64-relwithdebinfo`로 변경한 후 전체 빌드합니다.
   5b. 리눅스 사용자는 VS가 없다면 터미널에서 ```cmake --preset linux-amd64-relwithdebinfo``` 명령을 실행한 뒤 ```cmake --build --preset linux-amd64-relwithdebinfo``` 명령을 실행해야 합니다. (윈도우에서도 가능하며, `linux`를 `windows`로 바꾸면 됩니다.)
6. 컴파일이 완료되면 빌드된 exe 파일을 assets 폴더와 같은 디렉터리에 두어야 게임이 실행됩니다.

리눅스 포크가 있습니다
-------------------------------------------------
리눅스 빌드를 원한다면 etonedemid가 만든 <a href="https://github.com/etonedemid/reNut">reNut 포크</a>를 사용하세요. 이 버전은 그의 <a href="https://github.com/etonedemid/rexglue-sdk">rexglue SDK 포크</a>를 필요로 하며, 그는 이 기능이 메인에 포함되도록 Rexglue에 PR을 제출했습니다.


빌드하고 싶지 않다면
--------------------------------------------
빌드는 주로 게임 개발에 참여하거나 직접 빌드하고 싶은 사람들을 위한 것입니다. 빌드하지 않으려면;
* https://goopie.xyz/ 에 접속해 Goopie 런처를 다운로드하세요.
* 런처에서 반조-카주이: 넛츠 앤 볼츠를 선택하세요.
* ISO 선택을 눌러 북미판 반조-카주이: 넛츠 앤 볼츠 ISO를 선택하고 추출이 완료될 때까지 기다리세요.
* 추출이 완료되면 업데이트 버튼을 클릭하세요, 그러면 런처가 윈도우 버전의 최신 릴리스를 다운로드합니다
* 플레이를 클릭하세요




알려진 문제
-----------------------------------------------
1. 애니메이션이 약간 불안정합니다 (떨림이 있고, 반조와 다른 뼈대가 깨지며, 일부 애니메이션은 절반만 완성되었고, 다른 작은 부속 요소들도 있습니다) 하지만 게임 플레이에는 지장이 없으며, 단지 보는 재미가 있습니다.


문제 제기하기
--------------------------
이슈 탭은 게임 내에서 발생하는 충돌과 같은 아직 기록되지 않은 문제들을 위한 곳입니다, "게임이 열리지 않음" 또는 "ISO를 사용해야 하나요?" 같은 문제 제기는 삼가 주세요.
충돌과 관련된 문제는 반드시 충돌 템플릿을 사용해야 합니다 (다른 템플릿도 만들 예정입니다), 대부분 사용자 오류 게시물로 넘쳐나는 것을 원하지 않기 때문입니다. 충돌과 관련 없는 문제는 디스코드에 가입하여 #help 채널을 이용해 주세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-01

---