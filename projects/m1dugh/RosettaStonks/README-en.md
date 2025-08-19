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

RosettaStonks is a browser extension that allows one to add time and validate
lessons on rosetta stone learning language platform.

> RosettaStonks, and your rosetta stone goes stonks.

## Install

### Chrome based browsers

➡️ **New to installing Chrome extensions manually?** Check out the [Step-by-Step Visual Guide](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — includes helpful screenshots! 🖼️

#### 1. Using GitHub Release

To use the extension in a chrome-based browser, you need to:

- download the file `rosettastonks-chrome.tar.gz` from the latest release on
  your machine.
- create a folder named `rosettastonks` somewhere on your machine to store the
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
- go to `about:addons` in your browser  
- click the settings button and go to `Debug addons`.  
- click `Load Temporary Add-On`  
- select the `/tmp/rosettastonks.xpi` file in the file picker.  

_Warning: This method only installs the extension temporarily, meaning that if  
you close your browser, the addon will be uninstalled. This is due to firefox  
policies not allowing unverified extensions to be used._  

## How to use  

### Adding time  

#### Adding time in Foundations  

To add time on `foundations` product, you need to go to your exercises, and  
click ignore or resolve one question at least. Once this is done, a time field  
should appear on the extension page on which you can add your time.  

#### Adding time in Fluency builder  

To add time on `fluency builder` product, you need to go to your exercises, and  
answer at least one exercise. If the add time field does not appear, it means  
that no time request was caught, you need to refresh the question and answer it  
once again. To have the time added, you need to finish the lesson you used to  
add time.  

_Note: If you don't see the add time field, it means that the actions you took  
on Rosetta stone website did not lead to adding legitimate time, and therefore,  
you need to answer other questions._  

### Validating lesson  

#### Validating lesson in Foundations  

To validate a lesson, one needs to start a lesson, and go through all of the  
questions through the `ignore` button on the bottom right. Once all the  
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

Which will produce `rosettastonks.xpi`, the file for the extension that can be
loaded in Firefox.

📸 Prefer visuals? Check out the [Chrome Installation Guide with Images](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---