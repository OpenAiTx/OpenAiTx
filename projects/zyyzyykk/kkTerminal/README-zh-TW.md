# kkTerminal

> kkTerminal，一個用於 Web SSH 連線的終端機
>
> 作者: [zyyzyykk](https://github.com/zyyzyykk/)
>
> 原始碼: https://github.com/zyyzyykk/kkTerminal
>
> Docker Hub 地址: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> 線上預覽: https://ssh.kkbpro.com/
>
> 更新時間: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >簡體中文</a></p>

### ⚡ 快速整合

在 HTML 網頁中使用 `iframe` 標籤即可快速整合：

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 使用 Docker 部署

1. 拉取鏡像：

```bash
docker pull zyyzyykk/kkterminal
```

2. 建立並運行容器，進行端口映射：`-p port:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. 自訂藝術字：`-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. 瀏覽器訪問：`http://server-ip:3000/`

### 🛸 線上預覽

訪問以下網站：https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**更多模組預覽**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 功能說明

1. kkTerminal 是一個用於 Web SSH 連線的終端機，點擊左上角終端機圖示並選擇連線設置，即可建立 SSH 連線

2. 支援在網頁中使用 `iframe` 標籤，快速整合至第三方網站

3. 支援通過 [URL 參數](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md) 自訂終端機配置

4. 支援國際化及中英文語言切換

5. 支援本地 PC 部署，啟動時自動開啟瀏覽器視窗

6. 支援視窗大小自適應及中文輸入

7. 支援自訂偏好設置，允許用戶選擇背景/前景色、字體大小、游標顯示樣式、終端機啟用 TCode 等

8. 支援重啟：修改 SSH 連線設置或自訂偏好設置後會自動重啟，或 SSH 連線斷開後可手動重啟

9. 支援複製與貼上：

   - 複製：與 `Git` 終端機一致，選取文字即自動複製
   - 貼上：與 `Cmd` 終端機一致，右鍵貼上（需瀏覽器授權）

9. 支援檔案管理，開啟檔案管理模組可查看、解壓、上傳及下載檔案/資料夾

10. 支援快捷鍵操作，如多選/全選、複製貼上、剪下、選擇切換、開啟等

11. 支援檔案瀏覽與編輯，修改檔案後可通過 `ctrl+s` 儲存至遠端伺服器

12. 支援 [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md)，可通過自訂 TCode 實現類 Shell 腳本的自動化工作流

13. 支援操作記錄及雲端同步功能

14. 支援協作、監控及 Docker 功能

### 👨‍💻 更新記錄

##### zyyzyykk/kkterminal:3.6.0: latest

- 新增高級協作功能
- 新增高級監控功能
- 新增高級 Docker 功能
- 優化打包體積及網頁展示

##### zyyzyykk/kkterminal:3.5.6: 

- 支援更多 URL 參數
- 新增編輯器文字及圖片尺寸百分比
- 優化網頁展示

##### zyyzyykk/kkterminal:3.5.3: 

- 新增 URL 參數自訂終端機配置
- 修復多視窗重啟 bug
- 新增操作記錄及雲端同步功能
- 部分代碼邏輯重構

[**歷史更新記錄**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 架構

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ 關於本項目

親愛的用戶，

很遺憾地通知大家，由於時間和精力有限，未來將無法繼續維護 `kkTerminal`。

如果你對 `kkTerminal` 感興趣或願意繼續維護，歡迎隨時聯繫我或提交 issue。

如有發現 bug 或希望開發新功能，也請提交 issue。

最後，感謝你對 `kkTerminal` 的支持，真誠希望 `kkTerminal` 能真正幫助到你。

此致

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 Star 數

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---