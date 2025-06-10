# TapMePlus1 Auto-Clearing Script

Một userscript Greasemonkey mạnh mẽ để tự động hóa quá trình xóa game TapMePlus1.

## Tính năng

- 🎮 **Tự động hoàn toàn**: Tự động xác định chiến lược nhấp tối ưu
- ⚡ **Quyết định thông minh**: Đánh giá lợi ích tiềm năng của mỗi lần nhấp dựa trên hàm giá trị
- 🔁 **Xử lý chuỗi phản ứng**: Mô phỏng hoàn toàn hiệu ứng loại bỏ chuỗi
- 🚀 **Thuật toán hiệu quả**: Hỗ trợ chiến lược hoạt động liên tục nhiều lần nhấp
- 🛠 **Chế độ đột phá**: Tìm điểm đột phá tốt nhất trong tình huống bất lợi
- 📊 **Giám sát thời gian thực**: Theo dõi trạng thái trò chơi trong nền và tự động khởi động lại trò chơi
- 🖥 **Bảng điều khiển**: Giao diện GUI trực quan để kiểm soát hoạt động của script

## Hướng dẫn cài đặt

1. Cài đặt tiện ích trình duyệt [violentmonkey](https://violentmonkey.github.io/)
2. Nhấp để cài đặt [TapmePlus1 script](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js)
3. Truy cập [TapMePlus1](https://tapmeplus1.com/) để bắt đầu trò chơi

## Tùy chọn cấu hình

Script chứa các tham số có thể điều chỉnh sau (chỉnh sửa trong mã):

```javascript
// ====== Tham số cơ bản ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== Hàm trọng số động ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== Chiến lược theo pha ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: 'Cơ bản', strategy: 'default' };
    };
```

## Giấy phép

Giấy phép GPL-3.0.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---