# [jQuery](https://jquery.com/) — 新一代 JavaScript

會議目前於 [matrix.org 平台](https://matrix.to/#/#jquery_meeting:gitter.im) 舉行。

會議記錄可在 [meetings.jquery.org](https://meetings.jquery.org/category/core/) 找到。

jQuery 的最新版本可於 [https://jquery.com/download/](https://jquery.com/download/) 下載。

## 版本支援

| 版本    | 分支         | 狀態     |
| ------- | ------------ | -------- |
| 4.x     | main         | Beta     |
| 3.x     | 3.x-stable   | 活躍     |
| 2.x     | 2.x-stable   | 不活躍   |
| 1.x     | 1.x-stable   | 不活躍   |

一旦 4.0.0 正式版釋出，3.x 分支將在有限時間內繼續獲得更新。2.x 與 1.x 分支已不再支援。

針對不活躍版本的商業支援可由 [HeroDevs](https://herodevs.com/nes) 提供。

進一步了解我們的[版本支援](https://jquery.com/support/)政策。

## 貢獻指南

秉持開放原始碼軟體開發精神，jQuery 一直鼓勵社群貢獻程式碼。在你開始動手寫程式前，請務必詳讀以下重要的貢獻指引：

1. [參與方式](https://contribute.jquery.org/)
2. [核心風格指南](https://contribute.jquery.org/style-guide/js/)
3. [為 jQuery 專案撰寫程式碼](https://contribute.jquery.org/code/)

### 議題／PR 參考方式

GitHub 的議題／PR 通常以 `gh-NUMBER` 參考，其中 `NUMBER` 為議題或 PR 的數字編號。你可以在 `https://github.com/jquery/jquery/issues/NUMBER` 找到該議題或 PR。

jQuery 以前曾使用另一個基於 Trac 的錯誤追蹤器，位於 [bugs.jquery.com](https://bugs.jquery.com/)。該系統目前為唯讀模式，供查閱過往討論之用。jQuery 原始碼中若參考這些議題，會使用 `trac-NUMBER` 格式，其中 `NUMBER` 為議題編號。你可以在 `https://bugs.jquery.com/ticket/NUMBER` 找到該議題。

## 適用於 jQuery 的執行環境

- [瀏覽器支援](https://jquery.com/browser-support/)
- jQuery 也支援 Node、瀏覽器擴充元件以及其他非瀏覽器環境。

## 建立你自己的 jQuery 所需條件

要建立 jQuery，你需要安裝最新版的 Node.js/npm 與 git 1.7 或以上版本。舊版本可能可用，但不受支援。

Windows 系統需下載並安裝 [git](https://git-scm.com/downloads) 與 [Node.js](https://nodejs.org/en/download/)。

macOS 用戶應安裝 [Homebrew](https://brew.sh/)。安裝 Homebrew 後，執行 `brew install git` 安裝 git，
以及 `brew install node` 安裝 Node.js。

Linux/BSD 用戶應使用適合的套件管理工具安裝 git 與 Node.js，或自行編譯安裝。簡單容易。

## 如何建立你自己的 jQuery

首先，[複製 jQuery git 倉庫](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository)。

然後，進入 jquery 目錄，安裝相依套件，並執行建置腳本：

```bash
cd jquery
npm install
npm run build
```

編譯後的 jQuery 會放在 `dist/` 目錄下，包含壓縮版與相關的 map 檔案。

## 建置所有 jQuery 發行檔案

要建置所有 jQuery 變體，請執行以下指令：

```bash
npm run build:all
```

這會產生所有 jQuery 發行時包含的變體，包括 `jquery.js`、`jquery.slim.js`、`jquery.module.js` 及 `jquery.slim.module.js`，以及對應的壓縮檔和 sourcemaps。

`jquery.module.js` 與 `jquery.slim.module.js` 是 [ECMAScript 模組](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules)，會將 `jQuery` 和 `$` 作為命名匯出，並放在 `dist-module/` 目錄，而不是 `dist/` 目錄。

## 建立自訂 jQuery

建置腳本可用於建立只包含你需要模組的自訂版 jQuery。

除了 `core` 外，任何模組都可以被排除。若排除了 `selector`，它不會被移除，而是用一個基於原生 `querySelectorAll` 的小型包裝器取代（詳情見下文）。

### 建置腳本說明

要查看建置腳本所有可用選項，請執行：

```bash
npm run build -- --help
```

### 模組

要排除某個模組，請將其相對於 `src` 資料夾的路徑（不含 `.js` 副檔名）傳給 `--exclude` 選項。若使用 `--include`，預設包含的模組會被移除，只會建置你指定的模組。

可排除或包含的範例模組如下：

- **ajax**: 所有 AJAX 功能：`$.ajax()`、`$.get()`、`$.post()`、`$.ajaxSetup()`、`.load()`、傳輸方式與如 `.ajaxStart()` 的 ajax 事件簡寫。
- **ajax/xhr**: 僅 XMLHTTPRequest AJAX 傳輸層。
- **ajax/script**: 僅 `<script>` AJAX 傳輸層，用於取得腳本。
- **ajax/jsonp**: 僅 JSONP AJAX 傳輸層，需依賴 ajax/script 傳輸層。
- **css**: `.css()` 方法。也會移除**所有**依賴 css 的模組（包含 **effects**、**dimensions**、**offset**）。
- **css/showHide**: 非動畫的 `.show()`、`.hide()` 和 `.toggle()`；若你使用 class 或明確呼叫 `.css()` 設定 `display` 屬性，可排除此模組。也會移除 **effects** 模組。
- **deprecated**: 標示為已棄用但尚未移除的方法。
- **dimensions**: `.width()` 和 `.height()` 方法，以及 `inner-` 和 `outer-` 變體。
- **effects**: `.animate()` 方法及其簡寫，如 `.slideUp()` 或 `.hide("slow")`。
- **event**: `.on()` 和 `.off()` 方法及所有事件功能。
- **event/trigger**: `.trigger()` 和 `.triggerHandler()` 方法。
- **offset**: `.offset()`、`.position()`、`.offsetParent()`、`.scrollLeft()`、`.scrollTop()` 方法。
- **wrap**: `.wrap()`、`.wrapAll()`、`.wrapInner()`、`.unwrap()` 方法。
- **core/ready**: 若你將腳本放在 body 結尾，可排除此模組。用 `jQuery()` 綁定的 ready callback 會立即呼叫，但 `jQuery(document).ready()` 不會成為函式，`.on("ready", ...)` 或類似寫法也不會觸發。
- **deferred**: 排除 jQuery.Deferred。這也會排除所有依賴 Deferred 的模組，包括 **ajax**、**effects** 和 **queue**，但會用 **core/ready-no-deferred** 取代 **core/ready**。
- **exports/global**: 排除將全域 jQuery 變數（$ 與 jQuery）掛載到 window 上。
- **exports/amd**: 排除 AMD 定義。

- **selector**: 完整的 jQuery 選擇器引擎。若排除此模組，會以基於瀏覽器 `querySelectorAll` 的簡易選擇器引擎取代，不支援 jQuery 選擇器擴充或進階語意。詳情請見 [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) 檔案。

*注意*：排除完整的 `selector` 模組也會排除所有 jQuery 選擇器擴充（如 `effects/animatedSelector` 與 `css/hiddenVisibleSelectors`）。

##### AMD 名稱

你可以設定 jQuery 的 AMD 模組名稱。預設為 "jquery"，這對於插件及第三方函式庫較為友好，但某些情況下你可能會想更改。可將名稱傳給 `--amd` 參數：

```bash
npm run build -- --amd="custom-name"
```

或，若要匿名定義，名稱留空即可。

```bash
npm run build -- --amd
```

##### 檔案名稱與目錄

預設建置後的 jQuery 檔案名稱為 `jquery.js`，存放於 `dist/` 目錄。你可以用 `--filename` 更改檔名，並用 `--dir` 更改目錄。`--dir` 為專案根目錄的相對路徑。

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

這將產生精簡版 jQuery，並放在 `tmp/jquery.slim.js`。

##### ECMAScript 模組（ESM）模式

預設情況下，jQuery 會產生一般的 script JavaScript 檔案。你也可以用 `--esm` 參數產生 ECMAScript 模組，將 `jQuery` 作為預設匯出：

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### Factory 模式

預設情況下，jQuery 依賴全域 `window`。若你的環境沒有 window，可以產生 factory 版本，提供一個可接受 `window` 參數的函式（使用方式請參見[發佈套件的 `README`](https://raw.githubusercontent.com/jquery/jquery/main/build/fixtures/README.md)）。可用 `--factory` 參數產生：

```bash
npm run build -- --filename=jquery.factory.js --factory
```

此選項可與 `--esm` 或 `--slim` 等其他選項結合使用：

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### 自訂建置範例

使用 `npm run build` 並列出要排除的模組，即可建立自訂版本。排除頂層模組同時也會排除其對應目錄下的模組。

排除所有 **ajax** 功能：

```bash
npm run build -- --exclude=ajax
```

排除 **css** 會同時移除依賴 CSS 的模組：**effects**、**offset**、**dimensions**。

```bash
npm run build -- --exclude=css
```

一次排除多個模組（`-e` 為 `--exclude` 的別名）：

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

有一個特殊別名可用來產生與官方 jQuery Slim 版本相同設定的建置：

```bash
npm run build -- --filename=jquery.slim.js --slim
```

或，產生作為 esm 模組的 slim 版本：

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*非官方的自訂組建並未定期測試。請自行承擔使用風險。*

## 執行單元測試

請確保已安裝必要的相依套件：

```bash
npm install
```

啟動 `npm start`，即可在開發時自動建構 jQuery：

```bash
npm start
```

使用支援 PHP 的本地伺服器執行單元測試。請確保從專案根目錄（而非 "test" 目錄）啟動網站。無需資料庫。Windows 與 Mac 已有預先配置的 PHP 本地伺服器可用。以下是一些選項：

- Windows: [WAMP 下載](https://www.wampserver.com/en/)
- Mac: [MAMP 下載](https://www.mamp.info/en/downloads/)
- Linux: [LAMP 安裝教學](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose（多數平台）](https://code.google.com/p/mongoose/)

## 基本 Git 操作

由於原始碼由 Git 版本控制系統管理，瞭解常用功能會很有幫助。

### 清理

如果你想將工作目錄完全回復到上游狀態，可以使用以下指令（請注意，這會清除你目前所有修改）：

```bash
git reset --hard upstream/main
git clean -fdx
```

### 變基（Rebasing）

對於功能／主題分支，應始終在 `git pull` 時加上 `--rebase` 參數；或者，如果經常需要管理許多臨時「準備發送 github pull request」的分支，可執行以下指令自動化設定：

```bash
git config branch.autosetuprebase local
```

（詳情請參見 `man git-config`）

### 處理合併衝突

如果合併時出現衝突，與其手動編輯有衝突的檔案，不如使用 `git mergetool` 功能。雖然預設工具 `xxdiff` 介面較為老舊，但實際上非常實用。

以下是一些可用的操作指令：

- `Ctrl + Alt + M` - 盡可能自動合併
- `b` - 跳至下一個合併衝突
- `s` - 變更衝突行的順序
- `u` - 復原合併
- `滑鼠左鍵` - 標記一個區塊為最終結果
- `滑鼠中鍵` - 標記一行為最終結果
- `Ctrl + S` - 儲存
- `Ctrl + Q` - 離開

## [QUnit](https://api.qunitjs.com) 參考

### 測試方法

```js
expect( numAssertions );
stop();
start();
```

*注意*: QUnit 最終版本可能會對 stop/start 加入參數，但本測試套件忽略這一點，方便直接將 start 和 stop 當作回呼函式使用，而不需擔心其參數。

### 測試斷言

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## 測試套件便捷方法參考

請參見 [test/data/testinit.js](https://raw.githubusercontent.com/jquery/jquery/main/test/data/testinit.js)。

### 返回具有指定 ID 的元素陣列

```js
q( ... );
```

範例：

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### 斷言一個選取集是否符合指定 ID

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

範例：

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### 觸發原生 DOM 事件（不經 jQuery）

```js
fireNative( node, eventType );
```

範例：

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### 為網址加上隨機數以避免快取

```js
url( "some/url" );
```

範例：

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### 在 iframe 中執行測試

部分測試可能需要使用不同於標準測試用例的文件，
這時可以在獨立的 iframe 中執行。實際的測試程式碼與斷言
依然放在 jQuery 的主測試檔案中；iframe 檔案僅需包含最基本的測試用例標記
與設定程式碼。

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

這會載入一個頁面，網址會以 `"./data/" + fileName` 組成。
iframe 頁面會於適當時機呼叫 `/test/data/iframeTest.js` 腳本並執行
`startIframeTest( [ additional args ] )` 來決定何時觸發回呼。通常是在
document ready 或 `window.onload` 事件發生後。

`testCallback` 會收到由 `testIframe` 建立的 QUnit `assert` 物件，
接著依序傳入該 iframe 的全域 `jQuery`、`window` 和 `document`。
若 iframe 端有傳入額外參數給 `startIframeTest`，
則會依序跟在 `document` 之後。

## 有問題嗎？

如果你有任何疑問，歡迎在
[Developing jQuery Core 論壇](https://forum.jquery.com/developing-jquery-core) 發問，
或至 [libera](https://web.libera.chat/) 的 #jquery 頻道提問。
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---