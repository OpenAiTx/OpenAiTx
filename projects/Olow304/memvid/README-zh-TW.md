# Memvid - 基於影片的 AI 記憶 🧠📹

**輕量級、顛覆性的 AI 記憶擴展解決方案**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid 透過將文字資料編碼成影片，徹底改變 AI 記憶管理方式，實現**極速語意搜尋**，即使面對數百萬段文字資料也能**亞秒級檢索**。與傳統向量資料庫需佔用大量記憶體與儲存空間不同，Memvid 可將知識庫壓縮成精簡的影片檔，依然保持對所有資訊的即時存取。

## 🎥 示範

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ 主要特色

- 🎥 **影片即資料庫**：單一 MP4 檔即可儲存數百萬段文字
- 🔍 **語意搜尋**：以自然語言查找相關內容
- 💬 **內建對話**：支援情境感知的對話介面
- 📚 **PDF 支援**：可直接匯入與索引 PDF 文件
- 🚀 **極速檢索**：即使大規模資料集也能亞秒級搜尋
- 💾 **高效儲存**：比傳統資料庫壓縮效能高 10 倍
- 🔌 **可插拔 LLM**：支援 OpenAI、Anthropic 或本地模型
- 🌐 **離線優先**：影片生成後可完全離線運作
- 🔧 **簡易 API**：只需 3 行程式碼即可上手

## 🎯 應用場景

- **📖 數位圖書館**：以單一影片索引數千本書籍
- **🎓 教育內容**：將課程內容製作成可搜尋的影片記憶
- **📰 新聞檔案庫**：將多年新聞壓縮成易管理的影片資料庫
- **💼 企業知識**：打造全公司可搜尋的知識基礎
- **🔬 研究論文**：快速語意搜尋科學文獻
- **📝 個人筆記**：將個人筆記轉化為可搜尋的 AI 助手

## 🚀 為什麼選擇 Memvid？

### 顛覆性創新
- **影片即資料庫**：單一 MP4 檔即可儲存數百萬段文字
- **即時檢索**：大規模資料集也能亞秒級語意搜尋
- **10 倍儲存效率**：影片壓縮大幅減少記憶體佔用
- **零基礎建設**：不需資料庫伺服器，僅需可複製的檔案
- **離線優先**：影片生成後可完全離線運作

### 輕量級架構
- **最小依賴**：核心功能僅約 1000 行 Python 程式
- **CPU 友善**：無需 GPU 也能高效運作
- **可攜帶**：單一影片檔包含所有知識資料
- **可串流**：影片可從雲端儲存串流播放

## 📦 安裝方式

### 快速安裝
```bash
pip install memvid
```

### 啟用 PDF 支援
```bash
pip install memvid PyPDF2
```

### 建議安裝方式（虛擬環境）
```bash
# 建立新專案資料夾
mkdir my-memvid-project
cd my-memvid-project

# 建立虛擬環境
python -m venv venv

# 啟動虛擬環境
# macOS/Linux：
source venv/bin/activate
# Windows：
venv\Scripts\activate

# 安裝 memvid
pip install memvid

# 如需 PDF 支援：
pip install PyPDF2
```

## 🎯 快速開始

### 基本用法
```python
from memvid import MemvidEncoder, MemvidChat

# 以文字段落建立影片記憶體
chunks = ["重要事實 1", "重要事實 2", "歷史事件細節"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# 與你的記憶體對話
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("你知道哪些歷史事件？")
print(response)
```

### 由文件建立記憶體
```python
from memvid import MemvidEncoder
import os

# 載入文件
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# 新增文字檔
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# 建立最佳化影片
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # FPS 越高，每秒可存更多段落
    frame_size=512  # 畫面越大，每格可存更多資料
)
```

### 進階搜尋與檢索
```python
from memvid import MemvidRetriever

# 初始化檢索器
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# 語意搜尋
results = retriever.search("機器學習演算法", top_k=5)
for chunk, score in results:
    print(f"分數: {score:.3f} | {chunk[:100]}...")

# 取得語境視窗
context = retriever.get_context("解釋神經網路", max_tokens=2000)
print(context)
```

### 互動式對話介面
```python
from memvid import MemvidInteractive

# 啟動互動式對話 UI
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # 於 http://localhost:7860 開啟網頁介面
```

### 測試 file_chat.py
`examples/file_chat.py` 腳本可用於全面測試你的文件與 Memvid 整合：

```bash
# 處理整個文件資料夾
python examples/file_chat.py --input-dir /path/to/documents --provider google

# 處理特定檔案
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# 使用 H.265 壓縮（需 Docker）
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# 大型文件自訂切分
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# 載入既有記憶體
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### 完整範例：與 PDF 書籍對話
```bash
# 1. 建立新資料夾並設定環境
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # Windows: venv\Scripts\activate

# 2. 安裝依賴
pip install memvid PyPDF2

# 3. 建立 book_chat.py
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# 你的 PDF 檔案
book_pdf = "book.pdf"  # 請將此處換成你的 PDF 路徑

# 建立影片記憶體
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# 與書籍對話
api_key = os.getenv("OPENAI_API_KEY")  # 選用：用於 AI 回應
```python
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. 執行
export OPENAI_API_KEY="your-api-key"  # 可選
python book_chat.py
```

## 🛠️ 進階設定

### 自訂嵌入模型
```python
from sentence_transformers import SentenceTransformer

# 使用自訂嵌入模型
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### 影片優化
```python
# 追求最大壓縮率
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # 每秒更多畫格
    frame_size=256,  # 更小的畫格尺寸
    video_codec='h265',  # 更佳的壓縮
    crf=28  # 壓縮品質（越低=品質越好）
)
```

### 分散式處理
```python
# 並行處理大型資料集
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 疑難排解

### 常見問題

**ModuleNotFoundError: No module named 'memvid'**
```bash
# 確認你使用的是正確的 Python
which python  # 應該顯示虛擬環境的路徑
# 如果不是，請啟動你的虛擬環境：
source venv/bin/activate  # Windows 上: venv\Scripts\activate
```

**ImportError: PyPDF2 is required for PDF support**
```bash
pip install PyPDF2
```

**LLM API 金鑰問題**
```bash
# 設定你的 API 金鑰（可至 https://platform.openai.com 取得）
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# 或在 Windows 上：
set GOOGLE_API_KEY=AIzaSyB1-...
```

**大型 PDF 處理**
```python
# 對於非常大的 PDF，請使用較小的區塊大小
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 貢獻指南

歡迎貢獻！請參閱我們的 [Contributing Guide](https://raw.githubusercontent.com/Olow304/memvid/main/CONTRIBUTING.md) 以了解詳情。

```bash
# 執行測試
pytest tests/

# 執行並產生覆蓋率報告
pytest --cov=memvid tests/

# 格式化程式碼
black memvid/
```

## 🆚 與傳統解決方案比較

| 功能 | Memvid | 向量資料庫 | 傳統資料庫 |
|---------|--------|------------|-----------------|
| 儲存效率 | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐ |
| 設定複雜度 | 簡單 | 複雜 | 複雜 |
| 語意搜尋 | ✅ | ✅ | ❌ |
| 離線使用 | ✅ | ❌ | ✅ |
| 可攜性 | 檔案為主 | 伺服器為主 | 伺服器為主 |
| 可擴展性 | 百萬級 | 百萬級 | 十億級 |
| 成本 | 免費 | $$$$ | $$$ |

## 📚 範例

請參考 [examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) 目錄，包含：
- 從維基百科資料集建立記憶
- 創建個人知識庫
- 多語言支援
- 即時記憶更新
- 與主流 LLM 整合

## 🆘 尋求協助

- 📖 [文件](https://github.com/olow304/memvid/wiki) - 全面指南
- 💬 [討論區](https://github.com/olow304/memvid/discussions) - 提問
- 🐛 [問題回報](https://github.com/olow304/memvid/issues) - 回報錯誤
- 🌟 [展示專區](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - 分享你的專案

## 🔗 相關連結

- [GitHub 原始碼庫](https://github.com/olow304/memvid)
- [PyPI 套件](https://pypi.org/project/memvid)
- [更新日誌](https://github.com/olow304/memvid/releases)

## 📄 授權

MIT License - 詳見 [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) 檔案。

## 🙏 鳴謝

由 [Olow304](https://github.com/olow304) 及 Memvid 社群共同打造。

本專案使用以下技術開發 ❤️：
- [sentence-transformers](https://www.sbert.net/) - 最先進的語意嵌入
- [OpenCV](https://opencv.org/) - 電腦視覺與影片處理
- [qrcode](https://github.com/lincolnloop/python-qrcode) - QR code 產生
- [FAISS](https://github.com/facebookresearch/faiss) - 高效相似度搜尋
- [PyPDF2](https://github.com/py-pdf/pypdf) - PDF 文字擷取

特別感謝所有為 Memvid 做出貢獻的夥伴！

---

**準備好革新你的 AI 記憶管理了嗎？立刻安裝 Memvid，開始建立你的記憶！** 🚀
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---