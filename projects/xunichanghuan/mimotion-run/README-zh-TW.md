# mimotion
![ 刷步數](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# 小米運動自動刷步數

> 小米運動自動刷步數

## Github Actions 部署指南

### 一、Fork 此倉庫

### 二、設置帳號密碼
# 20230224新增
新增名為 **CONFIG** 的變數：Settings-->Secrets-->New secret，使用下面的 json 模板配置多帳號，支持郵箱、手機號
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN，如果沒有，請留空",
  "TG_USER_ID": "telegram TG_USER_ID，如果沒有，請留空",
  "SKEY": "酷推skey，如果沒有，請留空",
  "SCKEY": "server醬sckey，如果沒有，請留空",
  "POSITION": "是否開啟企業微信推送，如果沒有，請留空",
  "CORPID": "企業ID， 登錄企業微信，在我的企業-->企業信息裡查看，如果沒有，請留空",
  "CORPSECRET": "企業微信自建自建應用，每個自建應用裡都有單獨的secret，如果沒有，請留空",
  "AGENTID": "填寫你的企業微信自建應用ID，不加引號，是個整型常數,就是AgentId，如果沒有，請留空",
  "TOUSER": "指定接收消息的成員，成員ID列表（多個接收者用”&#166;”分隔，最多支持1000個）。特殊情況：指定為”@all”，則向該企業應用的全部成員發送如果沒有，請留空",
  "TOPARTY": "指定接收消息的部門，部門ID列表，多個接收者用”&#166;”分隔，最多支持100個。當touser為”@all”時填寫”@all”，如果沒有，請留空",
  "TOTAG": "指定接收消息的標籤，標籤ID列表，多個接收者用”&#166;”分隔，最多支持100個。當touser為”@all”時填寫”@all”，如果沒有，請留空",
  "OPEN_GET_WEATHER": "開啟根據地區天氣情況降低步數，如果沒有，請留空",
  "AREA": "設置獲取天氣的地區（上面開啟後必填）如 北京 ，如果沒有，請留空",
  "QWEATHER": "此處填寫和風天氣 Private KEY，申請地址https://console.qweather.com/#/apps，如果沒有，請留空",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "多帳號 最大步數填寫，請參考上面",
      "min_step": "多帳號 最小步數填寫，請參考上面",
      "password": "多帳號 密碼填寫，請參考上面",
      "user": "多帳號 手機號填寫，請參考上面"
    }
  ]
}
```
> 新增名為 **PAT** 的變數：Settings-->Secrets-->New secret

| Secrets |  格式  |
| -------- | ----- |
| PAT |   此處**PAT**需要申請，值為github token，教程詳見：https://www.jianshu.com/p/bb82b3ad1d11 ,需要repo和workflow權限,此項必填，避免git push的權限錯誤。 |

**CONFIG**範例
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
      "max_step": "多帳號 最大步數填寫，請參考上面",
      "min_step": "多帳號 最小步數填寫，請參考上面",
      "password": "多帳號 密碼填寫，請參考上面",
      "user": "多帳號 手機號填寫，請參考上面"
    }
  ]
}
```

### 三、自訂啟動時間

編輯 **random_cron.sh**
修改其中**if**語句的判斷時間為UTC時間，即**北京時間-8**，如北京時間8點為UTC時間0點，需要運行的時間-8就是UTC時間



## 注意事項

1. 每天運行七次，由random_cron.sh控制，分鐘為隨機值

2. 多帳號的數量和密碼請一定要對上 否則無法使用!!!

3. 啟動時間必須是UTC時間!

4. server醬註冊地址 [點我](https://sct.ftqq.com/)

5. 如果支付寶沒有更新步數,到小米運動->設置->帳號->註銷帳號->清空數據,然後重新登錄,重新綁定第三方

6. 小米運動不會更新步數，只有關聯的才會同步！！！！！

7. 請各位在使用時Fork[主分支](https://github.com/xunichanghuan/mimotion-run/)，防止出現不必要的bug.

8. 請注意，帳號不是 [小米帳號]，而是 [小米運動] 的帳號。

## 歷史Star數 

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---