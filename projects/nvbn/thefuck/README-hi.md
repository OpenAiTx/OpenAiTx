# द फक [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*द फक* एक शानदार ऐप है, जिसे [@liamosaur](https://twitter.com/liamosaur/) के
[tweet](https://twitter.com/liamosaur/status/506975850596536320) से प्रेरित किया गया है,
जो पिछली कंसोल कमांड्स में हुई गलतियों को सही करता है।

क्या *द फक* बहुत धीमा है? [एक्सपेरिमेंटल इंस्टेंट मोड आज़माएं!](#experimental-instant-mode)

[![उदाहरणों वाला gif][examples-link]][examples-link]

अधिक उदाहरण:

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

यदि आप बिना पुष्टि के सही की गई कमांड्स चलाने से नहीं डरते हैं, तो
`require_confirmation` [सेटिंग्स](#settings) विकल्प को अक्षम किया जा सकता है:

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

## सामग्री

1. [आवश्यकताएँ](#requirements)
2. [इंस्टॉलेशन](#installation)
3. [अपडेट करना](#updating)
4. [यह कैसे काम करता है](#how-it-works)
5. [अपना खुद का रूल बनाना](#creating-your-own-rules)
6. [सेटिंग्स](#settings)
7. [थर्ड पार्टी पैकेजेस](#third-party-packages-with-rules)
8. [एक्सपेरिमेंटल इंस्टेंट मोड](#experimental-instant-mode)
9. [डेवलपिंग](#developing)
10. [लाइसेंस](#license-mit)

## आवश्यकताएँ

- python (3.5+)
- pip
- python-dev

##### [सामग्री पर वापस जाएँ](#contents)

## इंस्टॉलेशन

macOS या Linux पर, आप [Homebrew][homebrew] के माध्यम से *द फक* इंस्टॉल कर सकते हैं:

```bash
brew install thefuck
```

Ubuntu / Mint पर, *द फक* को निम्नलिखित कमांड्स से इंस्टॉल करें:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

FreeBSD पर, *द फक* को निम्नलिखित कमांड्स से इंस्टॉल करें:
```bash
pkg install thefuck
```

ChromeOS पर, [chromebrew](https://github.com/skycocker/chromebrew) का उपयोग करके *द फक* इंस्टॉल करें:
```bash
crew install thefuck
```

Arch बेस्ड सिस्टम्स पर, *द फक* को निम्नलिखित कमांड से इंस्टॉल करें:
```
sudo pacman -S thefuck
```

अन्य सिस्टम्स पर, *द फक* को `pip` का उपयोग करके इंस्टॉल करें:

```bash
pip install thefuck
```

[वैकल्पिक रूप से, आप OS पैकेज मैनेजर (OS X, Ubuntu, Arch) का उपयोग कर सकते हैं।](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
यह अनुशंसा की जाती है कि आप इस कमांड को अपनी `.bash_profile`,
`.bashrc`, `.zshrc` या अन्य स्टार्टअप स्क्रिप्ट में रखें:

```bash
eval $(thefuck --alias)
# आप चाहें तो कोई भी alias इस्तेमाल कर सकते हैं, जैसे सोमवार के लिए:
eval $(thefuck --alias FUCK)
```

[या अपनी शेल कॉन्फ़िग (Bash, Zsh, Fish, Powershell, tcsh) में।](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

परिवर्तन केवल नए शेल सेशन में उपलब्ध होंगे। तुरंत प्रभाव के लिए, `source ~/.bashrc` (या आपकी शेल कॉन्फ़िग फाइल जैसे `.zshrc`) चलाएँ।

पुष्टि के बिना फिक्स्ड कमांड्स चलाने के लिए, `--yeah` विकल्प का उपयोग करें (या केवल `-y` के लिए, या अगर आप बहुत परेशान हैं तो `--hard`):

```bash
fuck --yeah
```

किसी कमांड को सफल होने तक पुनरावृत्त रूप से ठीक करने के लिए, `-r` विकल्प का उपयोग करें:

```bash
fuck -r
```

##### [सामग्री पर वापस जाएँ](#contents)

## अपडेट करना

```bash
pip3 install thefuck --upgrade
```

**नोट: v1.34 में *द फक* की alias कार्यक्षमता बदल गई है**

## अनइंस्टॉल

*द फक* को हटाने के लिए, इंस्टॉलेशन प्रक्रिया को उल्टा करें:
- अपनी Bash, Zsh, Fish, Powershell, tcsh, ... शेल कॉन्फ़िग से *thefuck* alias लाइन मिटाएँ या कमेंट करें
- अपने पैकेज मैनेजर (brew, pip3, pkg, crew, pip) का उपयोग करके बाइनरीज़ को अनइंस्टॉल करें

## यह कैसे काम करता है

*द फक* पिछली कमांड को किसी रूल से मिलाने की कोशिश करता है। यदि मैच मिल जाता है, तो उस नियम का उपयोग करके एक नई कमांड बनाई जाती है और उसे निष्पादित किया जाता है। निम्नलिखित रूल्स डिफ़ॉल्ट रूप से सक्षम हैं:

* `adb_unknown_command` &ndash; गलत लिखी adb कमांड्स जैसे `adb logcta` ठीक करता है;
* `ag_literal` &ndash; सुझाए जाने पर `ag` में `-Q` जोड़ता है;
* `aws_cli` &ndash; गलत लिखी aws कमांड्स जैसे `aws dynamdb scan` ठीक करता है;
* `az_cli` &ndash; गलत लिखी az कमांड्स जैसे `az providers` ठीक करता है;
* `cargo` &ndash; `cargo` की जगह `cargo build` चलाता है;
* `cargo_no_command` &ndash; गलत कमांड्स जैसे `cargo buid` को ठीक करता है;
* `cat_dir` &ndash; जब आप डायरेक्टरी पर `cat` करते हैं, तो उसे `ls` में बदल देता है;
* `cd_correction` &ndash; cd कमांड्स की वर्तनी जांचता और सुधारता है;
* `cd_cs` &ndash; `cs` को `cd` में बदलता है;
* `cd_mkdir` &ndash; डायरेक्टरी बनाने के बाद उसमें जाता है;
* `cd_parent` &ndash; `cd..` को `cd ..` में बदलता है;
* `chmod_x` &ndash; executable बिट जोड़ता है;
* `choco_install` &ndash; chocolatey पैकेजेस के लिए सामान्य suffixes जोड़ता है;
* `composer_not_command` &ndash; composer कमांड नाम को ठीक करता है;
* `conda_mistype` &ndash; conda कमांड्स को ठीक करता है;
* `cp_create_destination` &ndash; जब आप non-existent डायरेक्टरी में `cp` या `mv` करते हैं तो डायरेक्टरी बना देता है;
* `cp_omitting_directory` &ndash; जब आप डायरेक्टरी को `cp` करते हैं तो `-a` जोड़ता है;
* `cpp11` &ndash; `g++` या `clang++` में missing `-std=c++11` जोड़ता है;
* `dirty_untar` &ndash; `tar x` कमांड को ठीक करता है जो current डायरेक्टरी में untar करता है;
* `dirty_unzip` &ndash; `unzip` कमांड को ठीक करता है जो current डायरेक्टरी में unzip करता है;
* `django_south_ghost` &ndash; django south migration में ghost के लिए `--delete-ghost-migrations` जोड़ता है;
* `django_south_merge` &ndash; inconsistent django south migration में `--merge` जोड़ता है;
* `docker_login` &ndash; `docker login` चलाता है और पिछली कमांड दोहराता है;
* `docker_not_command` &ndash; गलत docker कमांड्स जैसे `docker tags` को ठीक करता है;
* `docker_image_being_used_by_container` &dash; इमेज हटाने से पहले उससे जुड़े कंटेनर को हटाता है;
* `dry` &ndash; दोहराव जैसे `git git push` को ठीक करता है;
* `fab_command_not_found` &ndash; गलत fabric कमांड्स को ठीक करता है;
* `fix_alt_space` &ndash; Alt+Space को Space कैरेक्टर में बदलता है;
* `fix_file` &ndash; आपके `$EDITOR` में एरर फाइल खोलता है;
* `gem_unknown_command` &ndash; गलत `gem` कमांड्स को ठीक करता है;
* `git_add` &ndash; *"pathspec 'foo' did not match any file(s) known to git."* को ठीक करता है;
* `git_add_force` &ndash; जब पाथ .gitignore'd है तो `git add <pathspec>...` में `--force` जोड़ता है;
* `git_bisect_usage` &ndash; bisecting के दौरान `git bisect strt`, `git bisect goood`, `git bisect rset` आदि को ठीक करता है;
* `git_branch_delete` &ndash; `git branch -d` को `git branch -D` में बदलता है;
* `git_branch_delete_checked_out` &ndash; जब चेकआउट ब्रांच हटाने की कोशिश करें तो `git branch -d` को `git checkout master && git branch -D` में बदलता है;
* `git_branch_exists` &ndash; पहले से मौजूद ब्रांच बनाने पर विकल्प देता है;
* `git_branch_list` &ndash; `git branch list` को पकड़ता है और बनाई गई ब्रांच हटाता है;
* `git_branch_0flag` &ndash; `git branch 0v` जैसी कमांड्स को ठीक करता है;
* `git_checkout` &ndash; ब्रांच नाम ठीक करता है या नई ब्रांच बनाता है;
* `git_clone_git_clone` &ndash; `git clone git clone ...` को `git clone ...` में बदलता है;
* `git_clone_missing` &ndash; गिट रिपॉजिटरी लिंक वाली URL में `git clone` जोड़ता है;
* `git_commit_add` &ndash; स्टेजिंग न होने पर `git commit -a ...` या `git commit -p ...` का सुझाव देता है;
* `git_commit_amend` &ndash; पिछली commit के बाद `git commit --amend` का सुझाव देता है;
* `git_commit_reset` &ndash; पिछली commit के बाद `git reset HEAD~` का सुझाव देता है;
* `git_diff_no_index` &ndash; अनट्रैक्ड फाइल्स पर पिछले `git diff` में `--no-index` जोड़ता है;
* `git_diff_staged` &ndash; अनपेक्षित आउटपुट पर पिछले `git diff` में `--staged` जोड़ता है;
* `git_fix_stash` &ndash; `git stash` कमांड्स (गलत सबकमांड या missing `save`) को ठीक करता है;
* `git_flag_after_filename` &ndash; `fatal: bad flag '...' after filename` को ठीक करता है;
* `git_help_aliased` &ndash; `<alias>` को वास्तविक कमांड में बदलता है;
* `git_hook_bypass` &ndash; `git am`, `git commit`, या `git push` के पहले `--no-verify` जोड़ता है;
* `git_lfs_mistype` &ndash; गलत टाइप की गई `git lfs <command>` को ठीक करता है;
* `git_main_master` &ndash; `main` और `master` के बीच गलत ब्रांच नाम को ठीक करता है;
* `git_merge` &ndash; ब्रांच नाम में रिमोट जोड़ता है;
* `git_merge_unrelated` &ndash; आवश्यकता होने पर `--allow-unrelated-histories` जोड़ता है;
* `git_not_command` &ndash; गलत git कमांड्स जैसे `git brnch` को ठीक करता है;
* `git_pull` &ndash; upstream सेट करता है;
* `git_pull_clone` &ndash; रिपो ना होने पर pull की बजाय clone करता है;
* `git_pull_uncommitted_changes` &ndash; pull से पहले बदलाव stash करता है और बाद में pop करता है;
* `git_push` &ndash; पिछली असफल `git push` में `--set-upstream origin $branch` जोड़ता है;
* `git_push_different_branch_names` &ndash; जब लोकल और रिमोट ब्रांच नाम अलग हों तो ठीक करता है;
* `git_push_pull` &ndash; push रिजेक्ट होने पर `git pull` चलाता है;
* `git_push_without_commits` &ndash; नई प्रोजेक्ट सेटअप के दौरान भूल से सिर्फ `git add .` करने पर शुरुआती कमिट बनाता है;
* `git_rebase_no_changes` &ndash; बदलाव न होने पर `git rebase --skip` चलाता है;
* `git_remote_delete` &ndash; `git remote delete remote_name` को `git remote remove remote_name` में बदलता है;
* `git_rm_local_modifications` &ndash; लोकल बदलाव वाली फाइल हटाते वक्त `-f` या `--cached` जोड़ता है;
* `git_rm_recursive` &ndash; डायरेक्टरी हटाते समय `-r` जोड़ता है;
* `git_rm_staged` &ndash; स्टेज्ड बदलाव वाली फाइल हटाते वक्त `-f` या `--cached` जोड़ता है;
* `git_rebase_merge_dir` &ndash; rebase के दौरान विकल्प देता है;
* `git_remote_seturl_add` &ndash; non-existent रिमोट पर `git remote set_url` के बजाय `git remote add` चलाता है;
* `git_stash` &ndash; ब्रांच बदलने या rebase से पहले लोकल बदलाव stash करता है;
* `git_stash_pop` &ndash; stash pop से पहले लोकल बदलाव जोड़ता है और फिर reset करता है;
* `git_tag_force` &ndash; टैग पहले से मौजूद होने पर `git tag <tagname>` में `--force` जोड़ता है;
* `git_two_dashes` &ndash; मिसिंग डैश वाली कमांड्स जैसे `git commit -amend` को ठीक करता है;
* `go_run` &ndash; Go प्रोग्राम्स रन/कंपाइल करते समय `.go` एक्सटेंशन जोड़ता है;
* `go_unknown_command` &ndash; गलत `go` कमांड्स जैसे `go bulid` को ठीक करता है;
* `gradle_no_task` &ndash; न मिले या ambiguous `gradle` task को ठीक करता है;
* `gradle_wrapper` &ndash; `gradle` को `./gradlew` में बदलता है;
* `grep_arguments_order` &ndash; `grep` arguments के क्रम को ठीक करता है;
* `grep_recursive` &ndash; डायरेक्टरी में `grep` करते समय `-r` जोड़ता है;
* `grunt_task_not_found` &ndash; गलत टाइप की गई `grunt` कमांड्स को ठीक करता है;
* `gulp_not_task` &ndash; गलत टाइप की गई `gulp` tasks को ठीक करता है;
* `has_exists_script` &ndash; script/binary के मौजूद होने पर `./` जोड़ता है;
* `heroku_multiple_apps` &ndash; `heroku` कमांड्स में `--app <app>` जोड़ता है;
* `heroku_not_command` &ndash; गलत `heroku` कमांड्स जैसे `heroku log` को ठीक करता है;
* `history` &ndash; history से सबसे मिलती-जुलती कमांड के साथ बदलने की कोशिश करता है;
* `hostscli` &ndash; `hostscli` के उपयोग को ठीक करता है;
* `ifconfig_device_not_found` &ndash; गलत डिवाइस नाम जैसे `wlan0` को सही नाम में बदलता है;
* `java` &ndash; Java प्रोग्राम्स रन करते समय `.java` एक्सटेंशन हटाता है;
* `javac` &ndash; Java फाइल्स कंपाइल करते समय मिसिंग `.java` जोड़ता है;
* `lein_not_task` &ndash; गलत `lein` tasks जैसे `lein rpl` को ठीक करता है;
* `long_form_help` &ndash; `-h` को `--help` में बदलता है;
* `ln_no_hard_link` &ndash; डायरेक्टरी पर हार्ड लिंक बनाने की कोशिश पकड़ता है, symbolic link का सुझाव देता है;
* `ln_s_order` &ndash; `ln -s` arguments के क्रम को ठीक करता है;
* `ls_all` &ndash; आउटपुट खाली होने पर `ls` में `-A` जोड़ता है;
* `ls_lah` &ndash; `ls` में `-lah` जोड़ता है;
* `man` &ndash; मैनुअल सेक्शन बदलता है;
* `man_no_space` &ndash; बिना स्पेस वाली man कमांड्स को ठीक करता है;
* `mercurial` &ndash; गलत `hg` कमांड्स को ठीक करता है;
* `missing_space_before_subcommand` &ndash; बिना स्पेस वाली कमांड्स जैसे `npminstall` को ठीक करता है;
* `mkdir_p` &ndash; पैरेंट डायरेक्टरी के बिना डायरेक्टरी बनाते समय `-p` जोड़ता है;
* `mvn_no_command` &ndash; `mvn` में `clean package` जोड़ता है;
* `mvn_unknown_lifecycle_phase` &ndash; गलत टाइप की गई लाइफ साइकिल फेज़ को ठीक करता है;
* `npm_missing_script` &ndash; `npm run-script <script>` में कस्टम स्क्रिप्ट नाम ठीक करता है;
* `npm_run_script` &ndash; कस्टम `npm` scripts में मिसिंग `run-script` जोड़ता है;
* `npm_wrong_command` &ndash; गलत npm कमांड्स जैसे `npm urgrade` को ठीक करता है;
* `no_command` &ndash; गलत कंसोल कमांड्स जैसे `vom/vim` को ठीक करता है;
* `no_such_file` &ndash; `mv` और `cp` कमांड्स के साथ मिसिंग डायरेक्टरी बनाता है;
* `omnienv_no_such_command` &ndash; `goenv`, `nodenv`, `pyenv` और `rbenv` के लिए गलत कमांड्स को ठीक करता है;
* `open` &ndash; एड्रेस में `http://` जोड़ता है या नई फाइल/डायरेक्टरी बनाता है;
* `pip_install` &ndash; परमीशन प्रॉब्लम्स के लिए `--user` या `sudo` जोड़ता है;
* `pip_unknown_command` &ndash; गलत `pip` कमांड्स को ठीक करता है;
* `php_s` &ndash; लोकल php सर्वर चलाते समय `-s` को `-S` में बदलता है;
* `port_already_in_use` &ndash; पोर्ट को बाउंड करने वाली प्रोसेस को मारता है;
* `prove_recursively` &ndash; डायरेक्टरी के साथ कॉल करने पर `-r` जोड़ता है;
* `python_command` &ndash; नॉन-एग्जीक्यूटेबल या बिना `./` python स्क्रिप्ट चलाते समय `python` जोड़ता है;
* `python_execute` &ndash; Python फाइल्स चलाते समय मिसिंग `.py` जोड़ता है;
* `python_module_error` &ndash; ModuleNotFoundError होने पर उस मॉड्यूल को `pip install` करने की कोशिश करता है;
* `quotation_marks` &ndash; `"` और `'` के असमान उपयोग को ठीक करता है;
* `path_from_history` &ndash; न मिल पाने वाले पथ को history से मिलता-जुलता पथ देता है;
* `rails_migrations_pending` &ndash; पेंडिंग माईग्रेशन चलाता है;
* `react_native_command_unrecognized` &ndash; अनरिज़नाइज़्ड `react-native` कमांड्स को ठीक करता है;
* `remove_shell_prompt_literal` &ndash; डॉक्यूमेंटेशन से कमांड कॉपी करते समय `$` हटाता है;
* `remove_trailing_cedilla` &ndash; ट्रेलिंग cedilla `ç` हटाता है;
* `rm_dir` &ndash; डायरेक्टरी हटाते समय `-rf` जोड़ता है;
* `scm_correction` &ndash; गलत scm को सही करता है जैसे `hg log` को `git log`;
* `sed_unterminated_s` &ndash; `sed` के `s` कमांड्स में मिसिंग '/' जोड़ता है;
* `sl_ls` &ndash; `sl` को `ls` में बदलता है;
* `ssh_known_hosts` &ndash; चेतावनी मिलने पर `known_hosts` से होस्ट हटाता है;
* `sudo` &ndash; परमिशन के कारण असफल होने पर पिछली कमांड के आगे `sudo` जोड़ता है;
* `sudo_command_from_user_path` &ndash; यूज़र के `$PATH` से कमांड्स को `sudo` के साथ चलाता है;
* `switch_lang` &ndash; कमांड को आपकी लोकल लेआउट से en में बदलता है;
* `systemctl` &ndash; `systemctl` के confusing parameters को सही क्रम में लगाता है;
* `terraform_init.py` &ndash; plan या apply से पहले `terraform init` चलाता है;
* `terraform_no_command.py` &ndash; अनरिज़नाइज़्ड `terraform` कमांड्स को ठीक करता है;
* `test.py` &ndash; `test.py` के बजाय `pytest` चलाता है;
* `touch` &ndash; "touch" करने से पहले मिसिंग डायरेक्टरी बनाता है;
* `tsuru_login` &ndash; ऑथेंटिकेटेड न होने या सेशन एक्सपायर होने पर `tsuru login` चलाता है;
* `tsuru_not_command` &ndash; गलत `tsuru` कमांड्स जैसे `tsuru shell` को ठीक करता है;
* `tmux` &ndash; `tmux` कमांड्स को ठीक करता है;
* `unknown_command` &ndash; hadoop hdfs-स्टाइल "unknown command" को ठीक करता है;
* `unsudo` &ndash; पिछले कमांड से `sudo` हटाता है यदि प्रोसेस superuser privilege पर चलने से मना करे।
* `vagrant_up` &ndash; vagrant instance चालू करता है;
* `whois` &ndash; `whois` कमांड को ठीक करता है;
* `workon_doesnt_exists` &ndash; `virtualenvwrapper` env नाम को ठीक करता है या नया बनाने का सुझाव देता है।
* `wrong_hyphen_before_subcommand` &ndash; गलत जगह डाले गए हाइफ़न को हटाता है (`apt-install` -> `apt install`, `git-log` -> `git log`, आदि)
* `yarn_alias` &ndash; `yarn` की aliased कमांड्स जैसे `yarn ls` को ठीक करता है;
* `yarn_command_not_found` &ndash; गलत टाइप की गई `yarn` कमांड्स को ठीक करता है;
* `yarn_command_replaced` &ndash; रिप्लेस्ड `yarn` कमांड्स को ठीक करता है;
* `yarn_help` &ndash; `yarn` डाक्यूमेंटेशन खोलना आसान बनाता है;

##### [सामग्री पर वापस जाएँ](#contents)

निम्नलिखित रूल्स केवल विशिष्ट प्लेटफार्मों पर डिफ़ॉल्ट रूप से सक्षम हैं:

* `apt_get` &ndash; यदि ऐप इंस्टॉल नहीं है तो apt से इंस्टॉल करता है;
* `apt_get_search` &ndash; `apt-get` से सर्च करने की कोशिश को `apt-cache` सर्च में बदलता है;
* `apt_invalid_operation` &ndash; गलत `apt` और `apt-get` कॉल्स को ठीक करता है;
* `apt_list_upgradable` &ndash; `apt update` के बाद `apt list --upgradable` चलाने में मदद करता है;
* `apt_upgrade` &ndash; `apt list --upgradable` के बाद `apt upgrade` चलाने में मदद करता है;
* `brew_cask_dependency` &ndash; cask dependencies इंस्टॉल करता है;
* `brew_install` &ndash; `brew install` के लिए formula नाम ठीक करता है;
* `brew_reinstall` &ndash; `brew install <formula>` को `brew reinstall <formula>` में बदलता है;
* `brew_link` &ndash; लिंकिंग फेल होने पर `--overwrite --dry-run` जोड़ता है;
* `brew_uninstall` &ndash; कई वर्शन इंस्टॉल होने पर `brew uninstall` में `--force` जोड़ता है;
* `brew_unknown_command` &ndash; गलत brew कमांड्स को ठीक करता है;
* `brew_update_formula` &ndash; `brew update <formula>` को `brew upgrade <formula>` में बदलता है;
* `dnf_no_such_command` &ndash; गलत टाइप की गई DNF कमांड्स को ठीक करता है;
* `nixos_cmd_not_found` &ndash; NixOS पर ऐप्स इंस्टॉल करता है;
* `pacman` &ndash; यदि ऐप इंस्टॉल नहीं है तो `pacman` से इंस्टॉल करता है;
* `pacman_invalid_option` &ndash; लोअरकेस pacman विकल्पों को अपरकेस में बदलता है।
* `pacman_not_found` &ndash; पैकेज नाम को `pacman`, `yay`, `pikaur` या `yaourt` के साथ ठीक करता है।
* `yum_invalid_operation` &ndash; गलत `yum` कॉल्स को ठीक करता है;

निम्नलिखित कमांड्स *द फक* के साथ बंडल्ड हैं, लेकिन डिफ़ॉल्ट रूप से सक्षम नहीं हैं:

* `git_push_force` &ndash; `git push` में `--force-with-lease` जोड़ता है;
* `rm_root` &ndash; `rm -rf /` कमांड में `--no-preserve-root` जोड़ता है।

##### [सामग्री पर वापस जाएँ](#contents)

## अपना खुद का रूल बनाना

अपना खुद का रूल जोड़ने के लिए, `~/.config/thefuck/rules` में
`your-rule-name.py` नामक फाइल बनाएं। रूल फाइल में दो फंक्शन होने चाहिए:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

इसके अलावा, रूल्स में वैकल्पिक फंक्शन हो सकते हैं:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
रूल्स में वैकल्पिक वेरिएबल्स `enabled_by_default`, `requires_output` और `priority` भी हो सकते हैं।

`Command` में तीन attributes होते हैं: `script`, `output` और `script_parts`।
आपका रूल `Command` को नहीं बदलना चाहिए।

**रूल्स API v3.0 में बदला:** रूल की सेटिंग्स एक्सेस करने के लिए
`from thefuck.conf import settings` इम्पोर्ट करें

`settings` एक विशेष ऑब्जेक्ट है जो `~/.config/thefuck/settings.py`,
और env वेल्यूज़ से बनता है ([नीचे और देखें](#settings))।

एक सिंपल उदाहरण sudo के साथ स्क्रिप्ट चलाने का:

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# वैकल्पिक:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # कम पहले, डिफ़ॉल्ट 1000

requires_output = True
```

[अधिक रूल्स के उदाहरण](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[रूल्स के लिए यूटिलिटी फंक्शन](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[ऐप/ओएस-विशिष्ट हेल्पर्स](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/)।

##### [सामग्री पर वापस जाएँ](#contents)

## सेटिंग्स

कई *द फक* पैरामीटर्स को `$XDG_CONFIG_HOME/thefuck/settings.py`
(`$XDG_CONFIG_HOME` डिफ़ॉल्ट रूप से `~/.config`) में बदला जा सकता है:

* `rules` &ndash; सक्षम रूल्स की लिस्ट, डिफ़ॉल्ट `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` &ndash; अक्षम रूल्स की लिस्ट, डिफ़ॉल्ट `[]`;
* `require_confirmation` &ndash; नई कमांड चलाने से पहले पुष्टि आवश्यक, डिफ़ॉल्ट `True`;
* `wait_command` &ndash; पिछली कमांड के आउटपुट के लिए अधिकतम समय (सेकंड में);
* `no_colors` &ndash; रंगीन आउटपुट अक्षम करें;
* `priority` &ndash; रूल्स की प्राथमिकता, कम `priority` वाला रूल पहले मैच होगा;
* `debug` &ndash; डिबग आउटपुट सक्षम करें, डिफ़ॉल्ट `False`;
* `history_limit` &ndash; कितनी history कमांड्स स्कैन होंगी, जैसे `2000`;
* `alter_history` &ndash; फिक्स्ड कमांड को history में डालना, डिफ़ॉल्ट `True`;
* `wait_slow_command` &ndash; स्लो कमांड्स की लिस्ट में होने पर अधिकतम प्रतीक्षा समय;
* `slow_commands` &ndash; स्लो कमांड्स की लिस्ट;
* `num_close_matches` &ndash; सुझाए जाने वाले अधिकतम करीबी मैचों की संख्या, डिफ़ॉल्ट `3`;
* `excluded_search_path_prefixes` &ndash; कमांड खोजते समय नजरअंदाज किए जाने वाले पाथ प्रीफिक्स, डिफ़ॉल्ट `[]`;

`settings.py` का एक उदाहरण:

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

या एनवायरनमेंट वेरिएबल्स के माध्यम से:

* `THEFUCK_RULES` &ndash; सक्षम रूल्स की लिस्ट;
* `THEFUCK_EXCLUDE_RULES` &ndash; अक्षम रूल्स की लिस्ट;
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; नई कमांड से पहले पुष्टि आवश्यक, `true/false`;
* `THEFUCK_WAIT_COMMAND` &ndash; पिछली कमांड के आउटपुट के लिए अधिकतम समय;
* `THEFUCK_NO_COLORS` &ndash; रंगीन आउटपुट अक्षम करें, `true/false`;
* `THEFUCK_PRIORITY` &ndash; रूल्स की प्राथमिकता;
* `THEFUCK_DEBUG` &ndash; डिबग आउटपुट सक्षम करें, `true/false`;
* `THEFUCK_HISTORY_LIMIT` &ndash; कितनी history कमांड्स स्कैन होंगी;
* `THEFUCK_ALTER_HISTORY` &ndash; फिक्स्ड कमांड को history में डालना `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; स्लो कमांड्स के लिए अधिकतम प्रतीक्षा समय;
* `THEFUCK_SLOW_COMMANDS` &ndash; स्लो कमांड्स की लिस्ट;
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; सुझाए जाने वाले अधिकतम करीबी मैचों की संख्या;
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; कमांड खोजते समय नजरअंदाज किए जाने वाले पाथ प्रीफिक्स, डिफ़ॉल्ट `[]`;

उदाहरण:

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

##### [सामग्री पर वापस जाएँ](#contents)

## थर्ड पार्टी पैकेजेस

यदि आप कुछ खास गैर-पब्लिक रूल्स बनाना चाहते हैं, लेकिन दूसरों के साथ साझा भी करना चाहते हैं,
तो `thefuck_contrib_*` नाम से पैकेज बनाएं, जिसमें निम्नलिखित संरचना हो:

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

*द फक* `rules` मॉड्यूल में मौजूद रूल्स को खोज लेगा।

##### [सामग्री पर वापस जाएँ](#contents)

## एक्सपेरिमेंटल इंस्टेंट मोड

*द फक* का डिफ़ॉल्ट व्यवहार पिछली कमांड्स को फिर से चलाने के लिए समय लेता है।
इंस्टेंट मोड में, *द फक* [script](https://en.wikipedia.org/wiki/Script_(Unix)) के साथ आउटपुट लॉग करता है,
फिर लॉग को पढ़ता है।

[![इंस्टेंट मोड के साथ gif][instant-mode-gif-link]][instant-mode-gif-link]

फिलहाल, इंस्टेंट मोड केवल Python 3 के साथ bash या zsh को सपोर्ट करता है। zsh की autocorrect फ़ंक्शन को भी अक्षम करना आवश्यक है।

इंस्टेंट मोड सक्षम करने के लिए, `.bashrc`, `.bash_profile` या `.zshrc` में alias initialization में `--enable-experimental-instant-mode` जोड़ें।

उदाहरण:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [सामग्री पर वापस जाएँ](#contents)

## डेवलपिंग

देखें [CONTRIBUTING.md](CONTRIBUTING.md)

## लाइसेंस MIT
प्रोजेक्ट का लाइसेंस [यहाँ](LICENSE.md) पाया जा सकता है।

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

##### [सामग्री पर वापस जाएँ](#contents)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---