# 3D 可按壓按鈕

一個用 HTML、CSS 和 SVG 製作的擬真 3D 按鈕元件，模擬實體按鈕被按壓的手感。此按鈕具有流暢的動畫效果、可自訂顏色，以及響應式互動。

由 [@BalintFerenczy](https://x.com/BalintFerenczy) 製作

靈感來自於 [Resend](https://resend.com/) 的傑出作品

## 功能

- **擬真 3D 外觀**，使用分層 SVG 圖形
- **流暢動畫**，搭配自訂緩動函式
- **互動狀態** - 滑鼠懸停及按壓特效
- **可自訂顏色**，透過 CSS 變數設定
- **響應式設計**，可隨容器大小縮放

## 範例展示
按鈕對用戶互動有三種不同的狀態反應：
- **正常**：按鈕處於靜止狀態
- **懸停**：當滑鼠懸停時，按鈕微微下移
- **啟動**：當按下/點擊時，按鈕顯著下移

## 用法

### 客製化

可使用 CSS 自訂屬性輕鬆自訂按鈕：

```css
.frame {
    /* 按鈕尺寸 */
    width: 400px; 
    height: 400px; 

    /* 移動距離 */
    --hover-travel: 3px;
    --press-travel: 40px;
    
    /* 顏色自訂 */
    --color: black;
    --brightness: 1;
    --blend-mode: color;

    /* 動畫過渡設定 */
    --transition-duration: 0.4s;
    --transition-easing: ease-in-out;
}
```
#### 更改按鈕文字

只需修改文字內容：

```html
<p class="text">點擊我！</p>
```

#### 更改按鈕大小

調整框架尺寸：

```css
.frame {
    width: 200px;
    height: 200px;
}
```
## 授權條款

本專案為開源項目，並採用 MIT 授權條款。

## 貢獻

歡迎分支本專案並提交 pull request 以改進或新增功能！

## 作者

由 [@BalintFerenczy](https://x.com/BalintFerenczy) 創建

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---