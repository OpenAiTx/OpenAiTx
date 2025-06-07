# mimotion
![ Step Count Spoofing](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# Xiaomi Sports Automatic Step Count Spoofing

> Xiaomi Sports Automatic Step Count Spoofing

## Github Actions Deployment Guide

### 1. Fork this repository

### 2. Set account and password
# Newly added on 2023-02-24
Add a variable named **CONFIG**: Settings-->Secrets-->New secret, configure multiple accounts using the JSON template below. Supports email and phone number.
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN, leave blank if not available",
  "TG_USER_ID": "telegram TG_USER_ID, leave blank if not available",
  "SKEY": "CoolPush skey, leave blank if not available",
  "SCKEY": "ServerChan sckey, leave blank if not available",
  "POSITION": "Enable WeCom push, leave blank if not available",
  "CORPID": "Enterprise ID, log in to WeCom, check under My Company-->Company Info, leave blank if not available",
  "CORPSECRET": "WeCom self-built app secret, each app has its own secret, leave blank if not available",
  "AGENTID": "Fill in your WeCom self-built app ID, do not use quotes, it's an integer (AgentId), leave blank if not available",
  "TOUSER": "Specify the recipient member(s), user ID list (separated by “&#166;”, up to 1000). For all members, set to “@all”. Leave blank if not available.",
  "TOPARTY": "Specify recipient departments, department ID list, separated by “&#166;”, up to 100. When touser is “@all”, fill in “@all”. Leave blank if not available.",
  "TOTAG": "Specify recipient tags, tag ID list, separated by “&#166;”, up to 100. When touser is “@all”, fill in “@all”. Leave blank if not available.",
  "OPEN_GET_WEATHER": "Enable reducing step count based on local weather. Leave blank if not available.",
  "AREA": "Set the region to get weather (required if enabled above), e.g., Beijing. Leave blank if not available.",
  "QWEATHER": "Fill in QWeather Private KEY, apply at https://console.qweather.com/#/apps. Leave blank if not available.",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "For multiple accounts, fill in max steps as above",
      "min_step": "For multiple accounts, fill in min steps as above",
      "password": "For multiple accounts, fill in password as above",
      "user": "For multiple accounts, fill in phone number as above"
    }
  ]
}
```
> Add a variable named **PAT**: Settings-->Secrets-->New secret

| Secrets |  Format  |
| -------- | ----- |
| PAT |   **PAT** needs to be applied for here, the value is a GitHub token. Tutorial: https://www.jianshu.com/p/bb82b3ad1d11. Requires repo and workflow permissions. This is mandatory to avoid git push permission errors. |

**CONFIG** Example
```
{
  "TG_BOT_TOKEN": "",
  "TG_USER_ID": "",
  "SKEY": "",
  "SCKEY": "",
  "POSITION": "",
  "CORPID": "",
  "CORPSECRET": "",
  "AGENTID": "",
  "TOUSER": "",
  "TOPARTY": "",
  "TOTAG": "",
  "OPEN_GET_WEATHER": "",
  "AREA": "",
  "QWEATHER": "",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "For multiple accounts, fill in max steps as above",
      "min_step": "For multiple accounts, fill in min steps as above",
      "password": "For multiple accounts, fill in password as above",
      "user": "For multiple accounts, fill in phone number as above"
    }
  ]
}
```

### 3. Customize the start time

Edit **random_cron.sh**
Modify the **if** statement’s time condition to UTC time, which is **Beijing Time - 8**. For example, Beijing time 8:00 is UTC 0:00. The time you want to run minus 8 is the UTC time.

## Notes

1. Runs seven times a day, controlled by random_cron.sh, with random minutes.

2. Make sure the number of accounts and passwords match, otherwise it won't work!!!

3. Start time must be in UTC time!

4. ServerChan registration address [click here](https://sct.ftqq.com/)

5. If Alipay has not updated the step count, go to Xiaomi Sports -> Settings -> Account -> Log out -> Clear data, then log in again and rebind third-party.

6. Xiaomi Sports itself does not update the step count, only the linked apps will sync!!!!!!

7. When using, please fork from the [main branch](https://github.com/xunichanghuan/mimotion-run/) to avoid unnecessary bugs.

8. Please note, the account is not [Mi Account], but the [Xiaomi Sports] account.

## Historical Star Count

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---