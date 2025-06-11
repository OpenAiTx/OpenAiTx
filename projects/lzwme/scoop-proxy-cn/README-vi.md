# 🍡 scoop-proxy-cn

Thư viện mirror proxy phù hợp cho người dùng Trung Quốc đại lục sử dụng các bucket của [Scoop](https://scoop.sh). Đồng bộ cập nhật từ nhiều kho `bucket` mã nguồn mở. Trong đó:

- Nhánh `sync` (mặc định): Đồng bộ nhiều kho ứng dụng, nhưng không sửa đổi proxy ghproxy. **Phù hợp với các trường hợp sử dụng scoop phiên bản chỉnh sửa nội địa trên gitee**
- Nhánh `main`: Sửa địa chỉ tải ứng dụng từ `github release` thành địa chỉ tải proxy dựa trên `https://ghfast.top`. **Do địa chỉ proxy thường xuyên thay đổi do hết hạn, không ổn định**

## Sử dụng

Thêm kho ứng dụng `spc`. Phù hợp dùng kèm với [thư viện tối ưu mirror scoop nội địa](https://gitee.com/scoop-installer/scoop):

```bash
# Thêm bucket, mặc định lấy nhánh sync
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# cài ứng dụng
scoop install spc/<tên_ứng_dụng>
```

Nếu chỉ muốn dùng phiên bản Scoop chính thức, có thể làm như sau để chuyển nhánh theo dõi sang nhánh `main`:

```bash
# Vào thư mục spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# Nếu đã đặt biến môi trường SCOOP, thì chạy:
cd "$env:SCOOP\buckets\spc"

# Chuyển sang nhánh main
git fetch --all
git checkout -b main origin/main
```

## Tham khảo cài đặt và cấu hình Scoop

### Cách 1: Cài đặt dựa trên mirror nội địa tùy chỉnh (khuyên dùng)

Do mã nguồn scoop và các ứng dụng buckets chủ yếu được duy trì trên github dưới dạng git, việc truy cập github khó khăn khiến trải nghiệm cài đặt, cập nhật và tải ứng dụng rất kém.

Dưới đây là hướng dẫn cài đặt cho [thư viện tối ưu mirror scoop nội địa](https://gitee.com/scoop-installer/scoop).

```bash
# Thay đổi chính sách thực thi script, mặc định tự đồng ý
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# Cách 1: chạy lệnh cài đặt (mặc định cài trong thư mục người dùng, nếu muốn thay đổi xem phần “Tùy chỉnh thư mục cài đặt” bên dưới)
iwr -useb scoop.201704.xyz | iex


## Cách 2: tùy chỉnh thư mục cài đặt (chú ý sửa lại thư mục cho phù hợp)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# Nếu đã cài scoop chính thức, có thể chuyển nguồn bằng lệnh sau
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# Thêm bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# Cập nhật địa chỉ thư viện mới
scoop update
```

Phiên bản scoop cài theo cách này đã được tùy chỉnh, hỗ trợ proxy tùy chỉnh để tăng tốc tải, và mặc định sử dụng proxy `scoop.201704.xyz` để tải ứng dụng.

```bash
# Thêm proxy
scoop config URL_PROXY "https://scoop.201704.xyz"

# Xóa proxy
scoop config rm URL_PROXY
```

### Cách 2: Cài đặt dựa trên kho chính thức với proxy

Mở `PowerShell` và chạy các lệnh sau để cài đặt:

```bash
# cài đặt
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# cấu hình
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# thêm bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# vào thư mục spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# chuyển sang nhánh main
git fetch --all && git checkout -b main origin/main

# xem trợ giúp
scoop help

# cài 7zip, aria2, scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### Về `scoop-search`

Vì kho `scoop-proxy-cn` đồng bộ trên 14,000+ ứng dụng, lệnh `scoop search` chính thức viết bằng `PowerShell` có hiệu năng quá kém, gần như không dùng được, nên khuyến nghị cài và dùng công cụ `scoop-search` viết bằng `go` thay thế. Ví dụ:

```bash
scoop install scoop-search
# dùng scoop-search
scoop-search act
```

## Các vấn đề thường gặp

### Về lỗi tải xuống do `aria2`

Khi đã cài `aria2`, scoop sẽ dùng `aria2` để tải ứng dụng theo phân mảnh giúp tăng tốc. Tuy nhiên một số proxy không hỗ trợ hoặc chặn tải phân mảnh từ `aria2`. Lúc này có thể tắt `aria2` bằng lệnh:

```bash
scoop config aria2-enabled false
```

### Về lỗi `Hash Check Failed`

Một số app cấu hình địa chỉ tải là bản phát hành mới nhất nhưng đồng thời có hash kiểm tra, khi có bản mới sẽ gây lỗi `Hash Check Failed`. Lúc này có thể thêm tham số `-s` để bỏ qua kiểm tra. Ví dụ:

```bash
scoop install scoop-search -s
```

### Cách xử lý khi proxy bị lỗi cần cập nhật

Khi dùng phiên bản Scoop chính thức theo nhánh `main`, sẽ dùng proxy để tăng tốc tải git repo và ứng dụng. Nếu proxy cũ không còn hoạt động sẽ không thể cập nhật. Hãy chạy các lệnh sau để thêm lại:

```bash
# Cập nhật scoop repo
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# Cách 1: cập nhật repo spc bucket
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# Nếu đã đổi vị trí thư mục buckets, chạy:
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# Cách 2: xóa rồi thêm lại spc bucket
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## Đồng bộ Buckets từ

- [ScoopInstaller/PHP](https://github.com/ScoopInstaller/PHP)
- [ScoopInstaller/Main](https://github.com/ScoopInstaller/Main)
- [ScoopInstaller/Extras](https://github.com/ScoopInstaller/Extras)
- [ScoopInstaller/Java](https://github.com/ScoopInstaller/Java)
- [ScoopInstaller/Versions](https://github.com/ScoopInstaller/Versions)
- [ScoopInstaller/Nirsoft](https://github.com/ScoopInstaller/Nirsoft)
- [ScoopInstaller/Nonportable](https://github.com/ScoopInstaller/Nonportable)
- [renxia/scoop-bucket](https://github.com/renxia/scoop-bucket)
- [scoopcn/scoopcn](https://github.com/scoopcn/scoopcn)
- [rasa/scoops](https://github.com/rasa/scoops)
- [amorphobia/siku](https://github.com/amorphobia/siku)
- [ACooper81/scoop-apps](https://github.com/ACooper81/scoop-apps)
- [kkzzhizhou/scoop-zapps](https://github.com/kkzzhizhou/scoop-zapps)
- [Calinou/scoop-games](https://github.com/Calinou/scoop-games)
- [cderv/r-bucket](https://github.com/cderv/r-bucket)
- [chawyehsu/dorado](https://github.com/chawyehsu/dorado)
- [borger/scoop-galaxy-integrations](https://github.com/borger/scoop-galaxy-integrations)
- [ivaquero/scoopet](https://github.com/ivaquero/scoopet)
- [KNOXDEV/wsl](https://github.com/KNOXDEV/wsl)
- [kodybrown/scoop-nirsoft](https://github.com/kodybrown/scoop-nirsoft)
- [kidonng/sushi](https://github.com/kidonng/sushi)
- [littleli/scoop-clojure](https://github.com/littleli/scoop-clojure)
- [niheaven/scoop-sysinternals](https://github.com/niheaven/scoop-sysinternals)
- [matthewjberger/scoop-nerd-fonts](https://github.com/matthewjberger/scoop-nerd-fonts)
- [TheCjw/scoop-retools](https://github.com/TheCjw/scoop-retools)
- [TheRandomLabs/Scoop-Bucket](https://github.com/TheRandomLabs/Scoop-Bucket)
- [TheRandomLabs/scoop-nonportable](https://github.com/TheRandomLabs/scoop-nonportable)
- [TheRandomLabs/Scoop-Spotify](https://github.com/TheRandomLabs/Scoop-Spotify)
- [Paxxs/Cluttered-bucket](https://github.com/Paxxs/Cluttered-bucket)
- [zhoujin7/tomato](https://github.com/zhoujin7/tomato)
- [HCLonely/my-scoop-bucket](https://github.com/HCLonely/my-scoop-bucket)
- [Weidows-projects/scoop-3rd](https://github.com/Weidows-projects/scoop-3rd)
- [hermanjustnu/scoop-emulators](https://github.com/hermanjustnu/scoop-emulators)
- [everyx/scoop-bucket](https://github.com/everyx/scoop-bucket)
- [borger/scoop-emulators](https://github.com/borger/scoop-emulators)
- [ZvonimirSun/scoop-iszy](https://github.com/ZvonimirSun/scoop-iszy)
- [kiennq/scoop-misc](https://github.com/kiennq/scoop-misc)
- [wzv5/ScoopBucket](https://github.com/wzv5/ScoopBucket)
- [TheRandomLabs/Scoop-Python](https://github.com/TheRandomLabs/Scoop-Python)
- [naderi/scoop-bucket](https://github.com/naderi/scoop-bucket)
- [ViCrack/scoop-bucket](https://github.com/ViCrack/scoop-bucket)
- [42wim/scoop-bucket](https://github.com/42wim/scoop-bucket)
- [akirco/aki-apps](https://github.com/akirco/aki-apps)
- [batkiz/backit](https://github.com/batkiz/backit)
- [iquiw/scoop-bucket](https://github.com/iquiw/scoop-bucket)
- [ygguorun/scoop-bucket](https://github.com/ygguorun/scoop-bucket)
- [seumsc/scoop-seu](https://github.com/seumsc/scoop-seu)
- [cc713/ownscoop](https://github.com/cc713/ownscoop)
- [aoisummer/scoop-bucket](https://github.com/aoisummer/scoop-bucket)
- [yuusakuri/scoop-bucket](https://github.com/yuusakuri/scoop-bucket)
- [hu3rror/scoop-muggle](https://github.com/hu3rror/scoop-muggle)
- [starise/Scoop-Confetti](https://github.com/starise/Scoop-Confetti)
- [dodorz/scoop](https://github.com/dodorz/scoop)
- [SayCV/scoop-cvp](https://github.com/SayCV/scoop-cvp)
- [Qv2ray/mochi](https://github.com/Qv2ray/mochi)
- [Homeland-Community/scoop](https://github.com/Homeland-Community/scoop)
- [jingyu9575/scoop-jingyu9575](https://github.com/jingyu9575/scoop-jingyu9575)
- [couleur-tweak-tips/utils](https://github.com/couleur-tweak-tips/utils)
- [wangzq/scoop-bucket](https://github.com/wangzq/scoop-bucket)
- [jonz94/scoop-sarasa-nerd-fonts](https://github.com/jonz94/scoop-sarasa-nerd-fonts)
- [NyaMisty/scoop_bucket_misty](https://github.com/NyaMisty/scoop_bucket_misty)
- [jfut/scoop-jfut](https://github.com/jfut/scoop-jfut)
- [mogeko/scoop-sysinternals](https://github.com/mogeko/scoop-sysinternals)
- [ChungZH/peach](https://github.com/ChungZH/peach)
- [DoveBoy/Apps](https://github.com/DoveBoy/Apps)
- [Velgus/Scoop-Portapps](https://github.com/Velgus/Scoop-Portapps)
- [starise/Scoop-Gaming](https://github.com/starise/Scoop-Gaming)
- [mo-san/scoop-bucket](https://github.com/mo-san/scoop-bucket)
- [brian6932/dank-scoop](https://github.com/brian6932/dank-scoop)
- [AkariiinMKII/Scoop4kariiin](https://github.com/AkariiinMKII/Scoop4kariiin)
- [littleli/Scoop-littleli](https://github.com/littleli/Scoop-littleli)
- [ChinLong/scoop-customize](https://github.com/ChinLong/scoop-customize)
- [Darkatse/Scoop-KanColle](https://github.com/Darkatse/Scoop-KanColle)
- [aliesbelik/poldi](https://github.com/aliesbelik/poldi)
- [MCOfficer/scoop-bucket](https://github.com/MCOfficer/scoop-bucket)
- [KnotUntied/scoop-fonts](https://github.com/KnotUntied/scoop-fonts)
- [beerpiss/scoop-bucket](https://github.com/beerpiss/scoop-bucket)
- [HUMORCE/nuke](https://github.com/HUMORCE/nuke)
- [AkinoKaede/maple](https://github.com/AkinoKaede/maple)
- [hulucc/bucket](https://github.com/hulucc/bucket)
- [Deide/deide-bucket](https://github.com/Deide/deide-bucket)
- [echoiron/echo-scoop](https://github.com/echoiron/echo-scoop)
- [tetradice/scoop-iyokan-jp](https://github.com/tetradice/scoop-iyokan-jp)

## Tuyên bố

> [!WARNING]
> Kho chứa này chỉ đồng bộ thông tin ứng dụng từ các kho bên thứ ba, chưa từng được kiểm tra tính khả dụng và an toàn từng cái một, vui lòng tự kiểm tra và xác minh khi lựa chọn cài đặt. Nếu có vi phạm bản quyền, vui lòng tạo issue để xử lý.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---