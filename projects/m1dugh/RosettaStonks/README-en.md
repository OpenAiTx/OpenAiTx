
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>

# Rosetta Stonks

- [Introduction](#introduction)
- [Install](#install)
  - [Chrome](#chrome-based-browsers)
    - [Visual Guide](#chrome-based-browsers)
  - [Firefox](#firefox-based-browsers)
- [How to use](#how-to-use)
  - [Adding time](#adding-time)
    - [Foundations](#adding-time-in-foundations)
    - [Fluency builder](#adding-time-in-fluency-builder)
  - [Validating lesson](#validating-lesson)
    - [Foundations](#validating-lesson-in-foundations)
    - [Fluency builder](#validating-lesson-in-fluency-builder)

## Introduction

RosettaStonks is a browser extension that allows you to add time and validate
lessons on the Rosetta Stone language learning platform.

> RosettaStonks, and your Rosetta Stone goes stonks.

## Install

### Chrome based browsers

➡️ **New to installing Chrome extensions manually?** Check out the [Step-by-Step Visual Guide](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — includes helpful screenshots! 🖼️

#### 1. Using GitHub Release

To use the extension in a Chrome-based browser, you need to:

- download the file `rosettastonks-chrome.tar.gz` from the latest release onto
  your computer.
- create a folder named `rosettastonks` somewhere on your computer to store the
  extension
- run the following command in the `rosettastonks` folder.

```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. Using nix package manager

Instead of the previous commands, if you are on a nix system **supporting
flakes**, you can run the following commands, which will install a folder
under the path `/tmp/rosettastonks` with all the files.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

The folder is now installed under `/tmp/rosettastonks/`

**This part is for all users independently of whether you are using the github method
or nix method.**

In your browser:

- go to `chrome://extensions`
- check the `Developer mode` toggle
- click `Load unpacked`
- Select your `rosettastonks` folder

### Firefox based browsers

- download the file `rosettastonks.xpi` from the latest release.
- alternatively, if using nix package manager with flake support, you can run
  the following command.

```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```

- go to `about:debugging#/runtime/this-firefox` in your browser
- click the settings button and go to `Debug addons`.
- click `Load Temporary Add-On`
- select the `/tmp/rosettastonks.xpi` file in the file picker.

_Warning: This method only installs the extension temporarily, meaning that if
you close your browser, the addon will be uninstalled. This is due to firefox
policies not allowing unverified extensions to be used._

## How to use

### Adding time

#### Adding time in Foundations

To add time on the `foundations` product, you need to go to your exercises, and
click ignore or resolve at least one question. Once this is done, a time field
should appear on the extension page where you can add your time.

#### Adding time in Fluency builder

To add time on the `fluency builder` product, you need to go to your exercises, and
answer at least one exercise. If the add time field does not appear, it means
that no time request was caught; you need to refresh the question and answer it
again. To have the time added, you need to finish the lesson where you used to
add time.

_Note: If you don't see the add time field, it means that the actions you took
on the Rosetta Stone website did not lead to adding legitimate time, and therefore,
you need to answer other questions._

### Validating lesson

#### Validating lesson in Foundations

To validate a lesson, you need to start a lesson and go through all of the
questions using the `ignore` button on the bottom right. Once all the
questions have been seen, clicking the `validate lesson` button should validate
the lesson. If not, go back to your home page, click on the same lesson, it
should ask you `Do you want to continue or reset ?`, you can choose both, and  
validate lesson again until it works. It should work after 3/4 times maximum.  

#### Validating lesson in Fluency builder  

Right now, the validate lesson feature is not available on rosetta stonks.  

## Building the application  

### Building the worker  

The worker can be packaged using the following command  

```
$ deno task build:worker
```

Which creates the packaged file `/dist/worker.esm.js` which is the packaged
file for the worker.

### Building the frontend

The worker can be packaged using the following command

```
$ deno task build:frontend
```

Which creates the packaged file `/dist/frontend.esm.js` which is the packaged
file for the frontend.

## Packaging the extension

### Chrome

To package the extension for Chrome, the following command can be run:

```
$ make chrome
```

### Firefox

To package the extension for Firefox, the following command can be run:

```
$ make firefox
```

This will produce `rosettastonks.xpi`, the file for the extension that can be
loaded in Firefox.

📸 Prefer visuals? Check out the [Chrome Installation Guide with Images](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---