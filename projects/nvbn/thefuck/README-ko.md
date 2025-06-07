# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck*은 [@liamosaur](https://twitter.com/liamosaur/)의
[tweet](https://twitter.com/liamosaur/status/506975850596536320)에서 영감을 받은 멋진 앱으로, 이전 콘솔 명령어의 오류를 자동으로 수정해줍니다.

*The Fuck*이 너무 느리다고 느끼시나요? [실험적 인스턴트 모드를 시도해보세요!](#experimental-instant-mode)

[![예제 gif][examples-link]][examples-link]

더 많은 예시:

```bash
➜ apt-get install vim
E: Could not open lock file /var/lib/dpkg/lock - open (13: Permission denied)
E: Unable to lock the administration directory (/var/lib/dpkg/), are you root?

➜ fuck
sudo apt-get install vim [enter/↑/↓/ctrl+c]
[sudo] password for nvbn:
Reading package lists... Done
...
```

```bash
➜ git push
fatal: The current branch master has no upstream branch.
To push the current branch and set the remote as upstream, use

    git push --set-upstream origin master


➜ fuck
git push --set-upstream origin master [enter/↑/↓/ctrl+c]
Counting objects: 9, done.
...
```

```bash
➜ puthon
No command 'puthon' found, did you mean:
 Command 'python' from package 'python-minimal' (main)
 Command 'python' from package 'python3' (main)
zsh: command not found: puthon

➜ fuck
python [enter/↑/↓/ctrl+c]
Python 3.4.2 (default, Oct  8 2014, 13:08:17)
...
```

```bash
➜ git brnch
git: 'brnch' is not a git command. See 'git --help'.

Did you mean this?
    branch

➜ fuck
git branch [enter/↑/↓/ctrl+c]
* master
```

```bash
➜ lein rpl
'rpl' is not a task. See 'lein help'.

Did you mean this?
         repl

➜ fuck
lein repl [enter/↑/↓/ctrl+c]
nREPL server started on port 54848 on host 127.0.0.1 - nrepl://127.0.0.1:54848
REPL-y 0.3.1
...
```

수정된 명령어를 무작정 실행하는 것이 두렵지 않다면,
`require_confirmation` [설정](#settings) 옵션을 비활성화할 수 있습니다:

```bash
➜ apt-get install vim
E: Could not open lock file /var/lib/dpkg/lock - open (13: Permission denied)
E: Unable to lock the administration directory (/var/lib/dpkg/), are you root?

➜ fuck
sudo apt-get install vim
[sudo] password for nvbn:
Reading package lists... Done
...
```

## 목차

1. [필수 조건](#requirements)
2. [설치](#installation)
3. [업데이트](#updating)
4. [작동 원리](#how-it-works)
5. [사용자 정의 규칙 만들기](#creating-your-own-rules)
6. [설정](#settings)
7. [서드파티 패키지 규칙](#third-party-packages-with-rules)
8. [실험적 인스턴트 모드](#experimental-instant-mode)
9. [개발](#developing)
10. [라이선스](#license-mit)

## 필수 조건

- python (3.5+)
- pip
- python-dev

##### [목차로 돌아가기](#contents)

## 설치

macOS 또는 Linux에서는 [Homebrew][homebrew]를 이용해 *The Fuck*을 설치할 수 있습니다:

```bash
brew install thefuck
```

Ubuntu / Mint에서는 다음 명령어로 *The Fuck*을 설치하세요:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

FreeBSD에서는 다음 명령어로 *The Fuck*을 설치하세요:
```bash
pkg install thefuck
```

ChromeOS에서는 [chromebrew](https://github.com/skycocker/chromebrew)를 사용하여 설치할 수 있습니다:
```bash
crew install thefuck
```

Arch 기반 시스템에서는 다음 명령어로 설치하세요:
```
sudo pacman -S thefuck
```

기타 시스템에서는 `pip`을 이용해 *The Fuck*을 설치하세요:

```bash
pip install thefuck
```

[또는 OS 패키지 매니저(OS X, Ubuntu, Arch)를 사용할 수도 있습니다.](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
아래 명령어를 `.bash_profile`, `.bashrc`, `.zshrc` 또는 기타 셸 시작 스크립트에 추가하는 것이 권장됩니다:

```bash
eval $(thefuck --alias)
# 원하는 별칭을 사용할 수 있습니다. 예: 월요일에는 이렇게:
eval $(thefuck --alias FUCK)
```

[또는 Bash, Zsh, Fish, Powershell, tcsh 등 셸 설정 파일에 추가하세요.](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

변경 사항은 새 셸 세션에서만 적용됩니다. 즉시 적용하려면 `source ~/.bashrc`(또는 `.zshrc` 등) 명령어를 실행하세요.

확인 없이 수정된 명령어를 실행하려면 `--yeah` 옵션(또는 짧게 `-y`, 또는 특별히 화가 났다면 `--hard`)을 사용하세요:

```bash
fuck --yeah
```

성공할 때까지 명령어를 재귀적으로 수정하려면 `-r` 옵션을 사용하세요:

```bash
fuck -r
```

##### [목차로 돌아가기](#contents)

## 업데이트

```bash
pip3 install thefuck --upgrade
```

**참고: *The Fuck* v1.34부터 별칭 기능이 변경되었습니다.**

## 삭제

*The Fuck*을 제거하려면 설치 과정을 반대로 진행하세요:
- Bash, Zsh, Fish, Powershell, tcsh 등 셸 설정 파일에서 *thefuck* 별칭 줄을 삭제하거나 주석 처리
- 패키지 관리자(brew, pip3, pkg, crew, pip 등)로 바이너리 삭제

## 작동 원리

*The Fuck*은 이전 명령어를 규칙과 비교하여 일치하는 규칙이 있으면 해당 규칙을 적용하여 새로운 명령어를 생성하고 실행합니다. 기본적으로 다음 규칙들이 활성화되어 있습니다:

* `adb_unknown_command` &ndash; `adb logcta`와 같이 잘못 입력된 adb 명령어 수정;
* `ag_literal` &ndash; 필요시 `ag`에 `-Q` 추가;
* `aws_cli` &ndash; `aws dynamdb scan`처럼 잘못 입력된 AWS 명령어 수정;
* `az_cli` &ndash; `az providers`처럼 잘못 입력된 Azure 명령어 수정;
* `cargo` &ndash; `cargo` 대신 `cargo build` 실행;
* `cargo_no_command` &ndash; `cargo buid`처럼 잘못된 cargo 명령어 수정;
* `cat_dir` &ndash; 디렉토리를 `cat`하려고 할 때 `ls`로 대체;
* `cd_correction` &ndash; 오타가 있는 cd 명령어 자동 교정;
* `cd_cs` &ndash; `cs`를 `cd`로 변경;
* `cd_mkdir` &ndash; 디렉토리가 없으면 생성 후 cd 진입;
* `cd_parent` &ndash; `cd..`을 `cd ..`로 변경;
* `chmod_x` &ndash; 실행 권한 추가;
* `choco_install` &ndash; chocolatey 패키지의 일반적인 접미사 추가;
* `composer_not_command` &ndash; composer 명령어 이름 수정;
* `conda_mistype` &ndash; conda 명령어 오타 수정;
* `cp_create_destination` &ndash; 없는 디렉토리로 `cp`나 `mv` 시 디렉토리 생성;
* `cp_omitting_directory` &ndash; 디렉토리 복사 시 `-a` 추가;
* `cpp11` &ndash; `g++` 또는 `clang++`에 누락된 `-std=c++11` 추가;
* `dirty_untar` &ndash; 현재 디렉토리에 압축 해제한 tar 명령어 수정;
* `dirty_unzip` &ndash; 현재 디렉토리에 압축 해제한 unzip 명령어 수정;
* `django_south_ghost` &ndash; ghost migration 실패 시 `--delete-ghost-migrations` 추가;
* `django_south_merge` &ndash; 불일치 south migration 시 `--merge` 추가;
* `docker_login` &ndash; `docker login` 실행 후 이전 명령어 재실행;
* `docker_not_command` &ndash; `docker tags` 등 잘못된 docker 명령어 수정;
* `docker_image_being_used_by_container` &dash; 이미지를 사용 중인 컨테이너를 먼저 삭제 후 이미지 삭제;
* `dry` &ndash; `git git push` 등 중복 명령어 수정;
* `fab_command_not_found` &ndash; fabric 명령어 오타 수정;
* `fix_alt_space` &ndash; Alt+Space를 일반 Space로 대체;
* `fix_file` &ndash; 에러가 난 파일을 `$EDITOR`로 열기;
* `gem_unknown_command` &ndash; 잘못된 `gem` 명령어 수정;
* `git_add` &ndash; *"pathspec 'foo' did not match any file(s) known to git."* 오류 수정;
* `git_add_force` &ndash; `.gitignore`된 경로에 `--force` 추가;
* `git_bisect_usage` &ndash; bisect 과정에서 오타 명령어 수정;
* `git_branch_delete` &ndash; `git branch -d`를 `git branch -D`로 변경;
* `git_branch_delete_checked_out` &ndash; 체크아웃된 브랜치 삭제 시 `git checkout master && git branch -D`로 변경;
* `git_branch_exists` &ndash; 이미 존재하는 브랜치 생성 시 삭제/체크아웃 제안;
* `git_branch_list` &ndash; `git branch list`를 `git branch`로 변경 및 브랜치 삭제;
* `git_branch_0flag` &ndash; `git branch 0v` 등 잘못된 명령어 수정 및 브랜치 삭제;
* `git_checkout` &ndash; 브랜치명 오타 수정 또는 새 브랜치 생성;
* `git_clone_git_clone` &ndash; `git clone git clone ...`을 `git clone ...`으로 변경;
* `git_clone_missing` &ndash; git 저장소 URL에 `git clone` 추가;
* `git_commit_add` &ndash; 스테이징된 파일이 없어 커밋 실패 시 `git commit -a ...` 또는 `git commit -p ...` 제안;
* `git_commit_amend` &ndash; 커밋 후 `git commit --amend` 제안;
* `git_commit_reset` &ndash; 커밋 후 `git reset HEAD~` 제안;
* `git_diff_no_index` &ndash; 추적되지 않은 파일 diff 시 `--no-index` 추가;
* `git_diff_staged` &ndash; 예기치 않은 출력 시 `--staged` 추가;
* `git_fix_stash` &ndash; `git stash` 관련 오타 수정 및 save 누락 보완;
* `git_flag_after_filename` &ndash; `fatal: bad flag '...' after filename` 오류 수정;
* `git_help_aliased` &ndash; <alias>를 실제 명령어로 바꿔서 `git help <alias>` 실행;
* `git_hook_bypass` &ndash; `git am`, `git commit`, `git push` 명령어 앞에 `--no-verify` 추가;
* `git_lfs_mistype` &ndash; `git lfs <command>` 오타 수정;
* `git_main_master` &ndash; `main`과 `master` 브랜치명 혼동 수정;
* `git_merge` &ndash; 원격 브랜치명 추가;
* `git_merge_unrelated` &ndash; 필요 시 `--allow-unrelated-histories` 추가;
* `git_not_command` &ndash; `git brnch` 등 잘못된 git 명령어 수정;
* `git_pull` &ndash; `git pull` 실행 전 upstream 설정;
* `git_pull_clone` &ndash; 저장소가 없을 때 pull 대신 clone 실행;
* `git_pull_uncommitted_changes` &ndash; 변경 사항 stash 후 pull, 이후 pop;
* `git_push` &ndash; 실패한 `git push`에 `--set-upstream origin $branch` 추가;
* `git_push_different_branch_names` &ndash; 로컬/원격 브랜치명이 다를 때 push 수정;
* `git_push_pull` &ndash; push 거부 시 `git pull` 실행;
* `git_push_without_commits` &ndash; 초기 커밋이 없을 때 생성;
* `git_rebase_no_changes` &ndash; 변경 사항 없을 때 `git rebase --skip` 실행;
* `git_remote_delete` &ndash; `git remote delete remote_name`을 `git remote remove remote_name`으로 변경;
* `git_rm_local_modifications` &ndash; 로컬 수정 파일 삭제 시 `-f` 또는 `--cached` 추가;
* `git_rm_recursive` &ndash; 디렉토리 삭제 시 `-r` 추가;
* `git_rm_staged` &ndash; staged 변경 파일 삭제 시 `-f` 또는 `--cached` 추가;
* `git_rebase_merge_dir` &ndash; rebase 중 `.git/rebase-merge` 디렉토리 삭제 또는 관련 명령어 제안;
* `git_remote_seturl_add` &ndash; 존재하지 않는 원격에 `git remote set_url` 실행 시 `git remote add` 실행;
* `git_stash` &ndash; 리베이스나 브랜치 변경 전 변경사항 stash;
* `git_stash_pop` &ndash; stash pop 전 변경사항 추가, 이후 reset;
* `git_tag_force` &ndash; 이미 존재하는 태그에 `--force` 추가;
* `git_two_dashes` &ndash; `git commit -amend`, `git rebase -continue` 등 누락된 대시 추가;
* `go_run` &ndash; Go 프로그램 컴파일/실행 시 `.go` 확장자 추가;
* `go_unknown_command` &ndash; `go bulid` 등 Go 명령어 오타 수정;
* `gradle_no_task` &ndash; 찾을 수 없거나 모호한 gradle 태스크 수정;
* `gradle_wrapper` &ndash; `gradle`을 `./gradlew`로 대체;
* `grep_arguments_order` &ndash; `grep` 인자 순서 수정;
* `grep_recursive` &ndash; 디렉토리 grep 시 `-r` 추가;
* `grunt_task_not_found` &ndash; grunt 명령어 오타 수정;
* `gulp_not_task` &ndash; gulp 태스크 오타 수정;
* `has_exists_script` &ndash; 스크립트/바이너리 존재 시 `./` 추가;
* `heroku_multiple_apps` &ndash; `heroku pg` 등 명령어에 `--app <app>` 추가;
* `heroku_not_command` &ndash; 잘못된 heroku 명령어 수정;
* `history` &ndash; 히스토리에서 가장 유사한 명령어로 대체;
* `hostscli` &ndash; `hostscli` 사용 오류 수정;
* `ifconfig_device_not_found` &ndash; 잘못된 네트워크 디바이스명 수정;
* `java` &ndash; Java 프로그램 실행 시 `.java` 확장자 제거;
* `javac` &ndash; Java 컴파일 시 누락된 `.java` 확장자 추가;
* `lein_not_task` &ndash; 잘못된 lein 태스크 오타 수정;
* `long_form_help` &ndash; 지원되지 않을 때 `-h`를 `--help`로 변경;
* `ln_no_hard_link` &ndash; 디렉토리에 하드링크 생성 시 심볼릭링크 제안;
* `ln_s_order` &ndash; `ln -s` 인자 순서 수정;
* `ls_all` &ndash; ls 출력이 없을 때 `-A` 추가;
* `ls_lah` &ndash; `ls`에 `-lah` 추가;
* `man` &ndash; 메뉴얼 섹션 변경;
* `man_no_space` &ndash; 공백 없는 man 명령어(`mandiff` 등) 수정;
* `mercurial` &ndash; 잘못된 hg 명령어 수정;
* `missing_space_before_subcommand` &ndash; `npminstall` 등 공백 누락 명령어 수정;
* `mkdir_p` &ndash; 부모 디렉토리 없는 디렉토리 생성 시 `-p` 추가;
* `mvn_no_command` &ndash; `mvn`에 `clean package` 추가;
* `mvn_unknown_lifecycle_phase` &ndash; 생명주기 단계 오타 수정;
* `npm_missing_script` &ndash; `npm run-script <script>`에서 스크립트명 수정;
* `npm_run_script` &ndash; 커스텀 npm 스크립트에 `run-script` 추가;
* `npm_wrong_command` &ndash; `npm urgrade` 등 잘못된 npm 명령어 수정;
* `no_command` &ndash; `vom/vim` 등 잘못된 콘솔 명령어 수정;
* `no_such_file` &ndash; `mv`, `cp` 명령어에 누락된 디렉토리 생성;
* `omnienv_no_such_command` &ndash; `goenv`, `nodenv`, `pyenv`, `rbenv` 등 오타 명령어 수정;
* `open` &ndash; 주소에 `http://` 추가 또는 파일/디렉토리 생성 후 open;
* `pip_install` &ndash; `pip install` 권한 오류 시 `--user` 추가 또는 필요시 sudo 추가;
* `pip_unknown_command` &ndash; `pip instatl/pip install` 등 pip 명령어 오타 수정;
* `php_s` &ndash; 로컬 PHP 서버 실행 시 `-s`를 `-S`로 변경;
* `port_already_in_use` &ndash; 포트 사용중인 프로세스 종료;
* `prove_recursively` &ndash; 디렉토리 입력 시 `-r` 추가;
* `python_command` &ndash; 실행 불가/`./` 없는 파이썬 스크립트에 python 추가;
* `python_execute` &ndash; Python 파일 실행 시 누락된 `.py` 추가;
* `python_module_error` &ndash; 모듈 못찾을 때 해당 모듈 pip install 시도;
* `quotation_marks` &ndash; 인용부호(`'`, `"`) 불일치 시 수정;
* `path_from_history` &ndash; 찾을 수 없는 경로를 히스토리에서 유사한 절대경로로 대체;
* `rails_migrations_pending` &ndash; 보류 중인 마이그레이션 실행;
* `react_native_command_unrecognized` &ndash; 인식되지 않는 react-native 명령어 수정;
* `remove_shell_prompt_literal` &ndash; 문서 복사 시 붙는 `$` 프롬프트 기호 제거;
* `remove_trailing_cedilla` &ndash; 유럽 키보드 오타(`ç`) 제거;
* `rm_dir` &ndash; 디렉토리 삭제 시 `-rf` 추가;
* `scm_correction` &ndash; 잘못된 scm 명령어 수정(`hg log`를 `git log` 등으로);
* `sed_unterminated_s` &ndash; `sed`의 `s` 명령어에 누락된 `/` 추가;
* `sl_ls` &ndash; `sl`을 `ls`로 변경;
* `ssh_known_hosts` &ndash; 경고 발생 시 known_hosts에서 호스트 제거;
* `sudo` &ndash; 권한 문제 발생 시 이전 명령어 앞에 sudo 추가;
* `sudo_command_from_user_path` &ndash; 사용자 `$PATH`의 명령어를 sudo로 실행;
* `switch_lang` &ndash; 로컬 키보드 레이아웃에서 en으로 명령어 변환;
* `systemctl` &ndash; 혼동되는 systemctl 인자 순서 조정;
* `terraform_init.py` &ndash; plan이나 apply 전에 `terraform init` 실행;
* `terraform_no_command.py` &ndash; 인식되지 않는 terraform 명령어 수정;
* `test.py` &ndash; `test.py` 대신 `pytest` 실행;
* `touch` &ndash; touch 전에 누락된 디렉토리 생성;
* `tsuru_login` &ndash; 인증 안됐거나 세션 만료 시 `tsuru login` 실행;
* `tsuru_not_command` &ndash; 잘못된 tsuru 명령어 수정;
* `tmux` &ndash; tmux 명령어 수정;
* `unknown_command` &ndash; 하둡 등 hdfs 스타일의 "unknown command" 수정, 예: `hdfs dfs ls`에서 누락된 `-` 추가;
* `unsudo` &ndash; 슈퍼유저 권한 거부 프로세스 발생 시 sudo 제거;
* `vagrant_up` &ndash; vagrant 인스턴스 시작;
* `whois` &ndash; whois 명령어 수정;
* `workon_doesnt_exists` &ndash; virtualenvwrapper 환경 이름 오류 시 새로 생성 제안;
* `wrong_hyphen_before_subcommand` &ndash; 잘못된 하이픈 위치 수정(`apt-install` -> `apt install`, `git-log` -> `git log` 등);
* `yarn_alias` &ndash; yarn 명령어 별칭 오타 수정;
* `yarn_command_not_found` &ndash; yarn 명령어 오타 수정;
* `yarn_command_replaced` &ndash; 변경된 yarn 명령어 수정;
* `yarn_help` &ndash; yarn 문서 쉽게 열기;

##### [목차로 돌아가기](#contents)

아래 규칙들은 특정 플랫폼에서만 기본적으로 활성화됩니다:

* `apt_get` &ndash; 앱이 설치되어 있지 않을 때 apt로 설치(필요: `python-commandnotfound` / `python3-commandnotfound`);
* `apt_get_search` &ndash; `apt-get` 검색 시 `apt-cache`로 변경;
* `apt_invalid_operation` &ndash; 잘못된 `apt` 및 `apt-get` 호출 수정(`apt-get isntall vim` 등);
* `apt_list_upgradable` &ndash; `apt update` 이후 `apt list --upgradable` 실행 안내;
* `apt_upgrade` &ndash; `apt list --upgradable` 이후 `apt upgrade` 실행 안내;
* `brew_cask_dependency` &ndash; cask 의존성 설치;
* `brew_install` &ndash; 잘못된 formula명 수정;
* `brew_reinstall` &ndash; `brew install <formula>`를 `brew reinstall <formula>`로 변경;
* `brew_link` &ndash; 링크 실패 시 `--overwrite --dry-run` 추가;
* `brew_uninstall` &ndash; 여러 버전 설치 시 `brew uninstall`에 `--force` 추가;
* `brew_unknown_command` &ndash; 잘못된 brew 명령어 수정(`brew docto/brew doctor` 등);
* `brew_update_formula` &ndash; `brew update <formula>`를 `brew upgrade <formula>`로 변경;
* `dnf_no_such_command` &ndash; DNF 명령어 오타 수정;
* `nixos_cmd_not_found` &ndash; NixOS에서 앱 설치;
* `pacman` &ndash; 앱이 없을 때 `pacman`으로 설치(가능하면 `yay`, `pikaur`, `yaourt` 사용);
* `pacman_invalid_option` &ndash; 소문자 pacman 옵션을 대문자로 변경;
* `pacman_not_found` &ndash; 패키지명 오타 수정(pacman, yay, pikaur, yaourt 모두 지원);
* `yum_invalid_operation` &ndash; 잘못된 `yum` 호출 수정(`yum isntall vim` 등);

아래 명령어들은 *The Fuck*에 포함되어 있으나 기본적으로 활성화되어 있지 않습니다:

* `git_push_force` &ndash; `git push`에 `--force-with-lease` 추가(단, `git_push_pull`과 충돌할 수 있음);
* `rm_root` &ndash; `rm -rf /` 명령어에 `--no-preserve-root` 추가.

##### [목차로 돌아가기](#contents)

## 사용자 정의 규칙 만들기

자신만의 규칙을 추가하려면, `~/.config/thefuck/rules` 디렉토리에 `your-rule-name.py` 파일을 생성하세요. 규칙 파일에는 두 개의 함수가 포함되어야 합니다:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

추가적으로, 규칙에는 선택적인 함수도 포함할 수 있습니다:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
규칙은 `enabled_by_default`, `requires_output`, `priority`와 같은 선택적 변수도 가질 수 있습니다.

`Command`는 `script`, `output`, `script_parts`라는 세 가지 속성을 가집니다.
규칙에서 `Command` 객체 자체를 변경해서는 안 됩니다.


**3.0 버전부터 규칙 API가 변경됨:** 규칙의 설정에 접근하려면
 `from thefuck.conf import settings`로 임포트하세요.

`settings`는 `~/.config/thefuck/settings.py`와 환경 변수에서 조합된 특수 객체입니다([아래 참고](#settings)).

다음은 `sudo`로 스크립트를 실행하는 간단한 예시입니다:

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# 선택 사항:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # 낮을수록 우선 적용, 기본값 1000

requires_output = True
```

[규칙 예시 더 보기](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[규칙용 유틸 함수 모음](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[앱/OS별 헬퍼](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [목차로 돌아가기](#contents)

## 설정

여러 *The Fuck* 파라미터는 `$XDG_CONFIG_HOME/thefuck/settings.py`
(`$XDG_CONFIG_HOME`의 기본값은 `~/.config`) 파일에서 변경할 수 있습니다:

* `rules` &ndash; 활성화할 규칙 리스트, 기본값은 `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` &ndash; 비활성화할 규칙 리스트, 기본값 `[]`;
* `require_confirmation` &ndash; 새로운 명령어 실행 전 확인 여부, 기본값 `True`;
* `wait_command` &ndash; 이전 명령어 출력을 받기 위한 최대 대기 시간(초);
* `no_colors` &ndash; 컬러 출력 비활성화;
* `priority` &ndash; 규칙 우선순위 딕셔너리, 낮은 값이 먼저 적용;
* `debug` &ndash; 디버그 출력 활성화, 기본값 `False`;
* `history_limit` &ndash; 히스토리에서 검사할 명령어 개수(예: `2000`);
* `alter_history` &ndash; 수정된 명령어를 히스토리에 추가, 기본값 `True`;
* `wait_slow_command` &ndash; `slow_commands` 목록 내 명령어에 대한 최대 대기 시간(초);
* `slow_commands` &ndash; 느린 명령어 리스트;
* `num_close_matches` &ndash; 추천할 유사 명령어 최대 개수, 기본값 `3`;
* `excluded_search_path_prefixes` &ndash; 명령어 탐색 시 무시할 경로 접두사, 기본값 `[]`.

`settings.py` 예시:

```python
rules = ['sudo', 'no_command']
exclude_rules = ['git_push']
require_confirmation = True
wait_command = 10
no_colors = False
priority = {'sudo': 100, 'no_command': 9999}
debug = False
history_limit = 9999
wait_slow_command = 20
slow_commands = ['react-native', 'gradle']
num_close_matches = 5
```

환경 변수로도 설정할 수 있습니다:

* `THEFUCK_RULES` &ndash; 활성화할 규칙 리스트, 예: `DEFAULT_RULES:rm_root` 또는 `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` &ndash; 비활성화할 규칙 리스트, 예: `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; 새 명령어 실행 전 확인, `true/false`;
* `THEFUCK_WAIT_COMMAND` &ndash; 이전 명령어 출력 대기 시간(초);
* `THEFUCK_NO_COLORS` &ndash; 컬러 출력 비활성화, `true/false`;
* `THEFUCK_PRIORITY` &ndash; 규칙 우선순위, 예: `no_command=9999:apt_get=100`, 낮은 값이 먼저 적용;
* `THEFUCK_DEBUG` &ndash; 디버그 출력, `true/false`;
* `THEFUCK_HISTORY_LIMIT` &ndash; 히스토리 검사 개수, 예: `2000`;
* `THEFUCK_ALTER_HISTORY` &ndash; 수정 명령어 히스토리 추가 여부, `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; 느린 명령어 출력 대기 시간(초);
* `THEFUCK_SLOW_COMMANDS` &ndash; 느린 명령어 리스트, 예: `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; 유사 명령어 추천 개수, 예: `5`;
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; 명령어 탐색 시 무시할 경로 접두사, 기본값 `[]`.

예시:

```bash
export THEFUCK_RULES='sudo:no_command'
export THEFUCK_EXCLUDE_RULES='git_pull:git_push'
export THEFUCK_REQUIRE_CONFIRMATION='true'
export THEFUCK_WAIT_COMMAND=10
export THEFUCK_NO_COLORS='false'
export THEFUCK_PRIORITY='no_command=9999:apt_get=100'
export THEFUCK_HISTORY_LIMIT='2000'
export THEFUCK_NUM_CLOSE_MATCHES='5'
```

##### [목차로 돌아가기](#contents)

## 서드파티 패키지 규칙

비공개 규칙 세트를 만들고 싶지만 다른 사람들과 공유하고 싶다면,
아래와 같은 구조로 `thefuck_contrib_*`라는 패키지를 만드세요:

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *third-party rules*
    __init__.py
    *third-party-utils*
  setup.py
```

*The Fuck*은 `rules` 모듈 내의 규칙을 자동으로 찾습니다.

##### [목차로 돌아가기](#contents)

## 실험적 인스턴트 모드

기본적으로 *The Fuck*은 이전 명령어를 다시 실행하므로 시간이 소요됩니다.
인스턴트 모드에서는 [script](https://en.wikipedia.org/wiki/Script_(Unix))로 출력을 기록한 뒤 로그를 읽어 실행 시간을 단축합니다.

[![인스턴트 모드 gif][instant-mode-gif-link]][instant-mode-gif-link]

현재 인스턴트 모드는 Python 3와 bash 또는 zsh만 지원합니다. zsh의 자동 교정 기능도 비활성화해야 정상 동작합니다.

인스턴트 모드를 활성화하려면, `.bashrc`, `.bash_profile` 또는 `.zshrc`에서 별칭 초기화에 `--enable-experimental-instant-mode`를 추가하세요.

예시:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [목차로 돌아가기](#contents)

## 개발

[CONTRIBUTING.md](CONTRIBUTING.md) 참조

## 라이선스 MIT
프로젝트 라이선스는 [여기](LICENSE.md)에서 확인하세요.


[version-badge]:   https://img.shields.io/pypi/v/thefuck.svg?label=version
[version-link]:    https://pypi.python.org/pypi/thefuck/
[workflow-badge]:  https://github.com/nvbn/thefuck/workflows/Tests/badge.svg
[workflow-link]:   https://github.com/nvbn/thefuck/actions?query=workflow%3ATests
[coverage-badge]:  https://img.shields.io/coveralls/nvbn/thefuck.svg
[coverage-link]:   https://coveralls.io/github/nvbn/thefuck
[license-badge]:   https://img.shields.io/badge/license-MIT-007EC7.svg
[examples-link]:   https://raw.githubusercontent.com/nvbn/thefuck/master/example.gif
[instant-mode-gif-link]:   https://raw.githubusercontent.com/nvbn/thefuck/master/example_instant_mode.gif
[homebrew]:        https://brew.sh/

##### [목차로 돌아가기](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---