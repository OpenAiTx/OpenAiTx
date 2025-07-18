<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# AlphaEvolve Writing

![Quy trình Viết AlphaEvolve](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

Bạn có thể xem giải thích đầy đủ [tại đây](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)

Bạn có thể tham khảo một truyện mẫu đã nộp cho cuộc thi viết [tại đây](https://blog.reedsy.com/short-story/wo9iuy/#comments)

Một hệ thống viết hiện đại, tiến hóa sử dụng các mô hình AI để tạo ra, đánh giá và phát triển những câu chuyện sáng tạo hoặc các tác phẩm viết thông thường thông qua các vòng thi lặp lại. Được xây dựng với kiến trúc Python sạch sẽ, theo các nguyên tắc thiết kế hiện đại.




## ✨ Tính năng

- 🧬 **Thuật toán tiến hóa**: Câu chuyện tiến hóa thông qua các giải đấu do AI điều khiển
- 🎯 **Hai chế độ viết**: Tối ưu hóa kể chuyện sáng tạo và viết chung
- 🏆 **Hệ thống giải đấu ELO**: Xếp hạng tinh vi bằng so sánh cặp đôi
- 🌐 **Giao diện Web**: Công cụ xác thực và so sánh truyện do con người thực hiện
- 🔧 **Tùy chỉnh cao**: Tùy biến sâu rộng thông qua cấu hình JSON

## 🚀 Bắt đầu nhanh

### Cài đặt


```bash
# Clone the repository
git clone https://github.com/your-org/alphaevolve-writing
cd alphaevolve-writing

# Install with uv (recommended)
uv sync

# Or install with pip
pip install -e .

# Configure your API keys (see Configuration section below)
```
### Chạy Tiến Hóa


```bash
# Run 5 evolution iterations
python evolve.py 5

# Fresh start with 3 iterations
python evolve.py 3 --fresh

# Use general writing mode
python evolve.py 5 --general

# Show help
python evolve.py --help
```
## 🏗️ Kiến trúc

Hệ thống tuân theo các nguyên tắc thiết kế Python hiện đại với sự phân tách rõ ràng các mối quan tâm:


```
├── src/
│   ├── core/           # Pipeline orchestration
│   │   └── pipeline.py # Main EvolutionPipeline class
│   ├── generators/     # Story generation logic
│   │   ├── story_generator.py      # Initial & next batch generators
│   │   ├── generate_response.py    # Creative writing generation
│   │   ├── generate_response_general.py # General writing generation
│   │   └── judge_response.py       # AI judging system
│   ├── rankers/        # ELO ranking system
│   │   ├── elo_rank.py            # Core ELO algorithm
│   │   └── tournament_runner.py    # Tournament management
│   └── utils/          # Utility functions
│       └── inference.py           # Multi-provider LLM interface
├── evolve.py           # Clean CLI entry point
├── pyproject.toml      # Modern Python packaging
├── config.json         # Configuration
└── web_interface/      # Web UI for validation
```
### Các Thành Phần Chính

- **`EvolutionPipeline`**: Bộ điều phối chính quản lý toàn bộ chu kỳ tiến hóa
- **`InitialStoryGenerator`**: Tạo thế hệ truyện đầu tiên từ các lời nhắc
- **`NextBatchGenerator`**: Tiến hóa các tác phẩm xuất sắc thành các biến thể được cải tiến
- **`TournamentRunner`**: Quản lý các giải đấu ELO để xếp hạng truyện
- **`EloRankingSystem`**: Triển khai thuật toán xếp hạng tinh vi

## 📖 Cách Hoạt Động

Hệ thống tuân theo chu kỳ tiến hóa ba giai đoạn:

### 1. **Tạo Lô Ban Đầu**
- Tạo nhiều truyện từ lời nhắc của bạn
- Sử dụng các mô hình AI có thể cấu hình (GPT, Claude, Llama, v.v.)
- Gán xếp hạng ELO ban đầu

### 2. **Chạy Giải Đấu ELO**
- Các truyện cạnh tranh theo cặp
- AI chấm điểm dựa trên tiêu chí của bạn
- Cập nhật điểm ELO dựa trên thắng/thua

### 3. **Tạo Lô Kế Tiếp**
- Chọn ra các truyện có hiệu suất tốt nhất
- Tạo ra các biến thể với cải tiến
- Quá trình lặp lại qua nhiều thế hệ

Quy trình lặp này giúp cải thiện chất lượng tác phẩm theo thời gian.

## ⚙️ Cấu Hình

### Cài Đặt Cơ Bản

Chỉnh sửa các tệp quan trọng sau:

- **`prompt.txt`** - Lời nhắc/chủ đề viết của bạn
- **`rubric.txt`** - Tiêu chí chấm điểm để đánh giá
- **`config.json`** - Cấu hình hệ thống

### Thiết Lập API Keys

Hệ thống hỗ trợ nhiều nhà cung cấp AI khác nhau cấu hình qua `config.json`. Cấu hình này ánh xạ các mô hình đến nhà cung cấp và chỉ định biến môi trường chứa API keys:


```json
{
  "llm_providers": {
    "openai": {
      "type": "openai",
      "base_url": "https://api.openai.com/v1",
      "api_key_env": "OPENAI_API_KEY"
    },
    "anthropic": {
      "type": "anthropic", 
      "api_key_env": "ANTHROPIC_API_KEY"
    },
    "deepinfra": {
      "type": "openai_compatible",
      "base_url": "https://api.deepinfra.com/v1/openai",
      "api_key_env": "DEEPINFRA_API_KEY"
    },
    "deepseek": {
      "type": "openai_compatible",
      "base_url": "https://api.deepseek.com/v1",
      "api_key_env": "DEEPSEEK_API_KEY"
    },
    "gemini": {
      "type": "openai_compatible",
      "api_key_env": "GEMINI_API_KEY",
      "base_url": "https://generativelanguage.googleapis.com/v1beta/openai/"
    }
  },
  "model_provider_mapping": {
    "gpt-4": "openai",
    "gpt-3.5-turbo": "openai", 
    "claude-3-sonnet-20240229": "anthropic",
    "meta-llama/Meta-Llama-3-70B-Instruct": "deepinfra",
    "deepseek-chat": "deepseek",
    "gemini-2.5-flash": "gemini"
  }
}
```
Sau đó, đặt các khóa API của bạn dưới dạng biến môi trường:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
Bạn chỉ cần thiết lập các khóa cho các nhà cung cấp mà bạn dự định sử dụng. Hệ thống sẽ tự động chuyển các yêu cầu mô hình đến đúng nhà cung cấp dựa trên cấu hình.

### Tùy chọn cấu hình

Tệp `config.json` kiểm soát toàn bộ hành vi của hệ thống:


```json
{
  "batch_generation": {
    "num_stories": 10,
    "model": "gpt-4",
    "initial_elo": 1500
  },
  "elo_ranking": {
    "tournament_rounds": 50,
    "judge_model": "claude-3-sonnet-20240229",
    "k_factor": 32
  },
  "next_batch_generation": {
    "top_stories_to_select": 3,
    "variants_per_story": 2,
    "include_original_stories": true
  },
  "evolution_pipeline": {
    "max_iterations": 5,
    "auto_continue_from_existing": true
  }
}
```
## 🎭 Chế Độ Viết

### Chế Độ Viết Sáng Tạo (Mặc Định)
- Tập trung vào kể chuyện, phát triển nhân vật và kỹ thuật tường thuật
- Sử dụng các chiến lược tạo nội dung dựa trên nhiệm vụ
- Tối ưu hóa cho sự sáng tạo và cuốn hút

### Chế Độ Viết Chung (`--general`)
- Tập trung vào bài báo khoa học, tiểu luận, báo cáo và viết chuyên nghiệp
- Sử dụng phương pháp phân tích và có cấu trúc
- Tối ưu hóa cho sự rõ ràng và thuyết phục

## 🔧 Cấu Hình Nâng Cao

### Tùy Chỉnh Chiến Lược Tạo Nội Dung

Đối với người dùng nâng cao, bạn có thể tùy chỉnh các prompt tạo nội dung, phong cách tác giả, và tập nhiệm vụ bằng cách chỉnh sửa các file trong thư mục `src/generators/`:

#### Tùy Chỉnh Viết Sáng Tạo (`src/generators/generate_response.py`)

**Tập Nhiệm Vụ** - Định nghĩa các phương pháp và mục tiêu sáng tạo:

```python
mission_sets = {
    "emotional_depth": [
        "Focus on the psychological depth of characters",
        "Explore complex emotional landscapes", 
        "Create moments of genuine human connection"
    ],
    "narrative_craft": [
        "Experiment with unique narrative structures",
        "Use vivid, sensory descriptions",
        "Create compelling story arcs"
    ],
    "dialogue_mastery": [
        "Write authentic, character-specific dialogue",
        "Use subtext and implied meaning",
        "Balance dialogue with action and description"
    ]
}
```
**Phong cách tác giả** - Mô phỏng các cách viết khác nhau:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### Tùy chỉnh Viết Chung (`src/generators/generate_response_general.py`)

**Các Lĩnh Vực Học Thuật Trọng Tâm** - Nhắm mục tiêu các lĩnh vực viết cụ thể:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**Phương pháp Viết** - Định nghĩa các chiến lược phân tích:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### Tùy chỉnh Tiêu chí Đánh giá (`src/generators/judge_response.py`)

Bạn có thể sửa đổi các tiêu chí đánh giá và câu nhắc đánh giá để tập trung vào các khía cạnh cụ thể của chất lượng bài viết:


```python
# Edit the judge_responses function to customize evaluation criteria
evaluation_criteria = [
    "Technical writing proficiency",
    "Creative originality and innovation", 
    "Emotional impact and reader engagement",
    "Structural coherence and flow",
    "Character development and authenticity"
]
```
### Mẹo cho Cấu Hình Nâng Cao

1. **Sao lưu tệp gốc**: Luôn giữ bản sao của các tệp trình tạo gốc trước khi thực hiện thay đổi
2. **Kiểm tra từng bước**: Thực hiện thay đổi nhỏ và kiểm tra với một vài vòng lặp trước khi chạy toàn bộ chu trình tiến hóa
3. **Giám sát kết quả**: Sử dụng giao diện web để xác minh rằng các tùy chỉnh của bạn cải thiện chất lượng câu chuyện
4. **Kết hợp linh hoạt**: Kết hợp các bộ nhiệm vụ và phong cách tác giả khác nhau để có chiến lược tạo độc đáo
5. **Quản lý phiên bản**: Theo dõi các tùy chỉnh của bạn với git để hoàn nguyên nếu cần thiết

Cách tiếp cận theo mô-đun này cho phép bạn tinh chỉnh quá trình tiến hóa cho mục tiêu và lĩnh vực viết của riêng mình.

## 🌐 Giao Diện Web

Xác minh kết quả tiến hóa của bạn với giao diện web tích hợp sẵn:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
Mở http://localhost:5000 để truy cập:

- **So sánh Câu chuyện**: Đọc song song và lựa chọn ưu tiên
- **Xếp hạng ELO**: Xem bảng xếp hạng và thống kê hiện tại
- **Theo dõi Tiến hóa**: Xác minh rằng các thế hệ sau được cải thiện
- **Xuất Dữ liệu**: Tải kết quả về để phân tích


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---