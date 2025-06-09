# Định Dạng Mô Hình 4D Tốt (G4MF)

Good 4D Model Format, hay viết tắt là G4MF, là một định dạng mô hình đa chiều tập trung vào 4D dựa trên JSON, lấy cảm hứng từ [glTF™](https://github.com/KhronosGroup/glTF) của Khronos, cho phép truyền tải, trao đổi và tương tác nội dung đa chiều cao hơn giữa các ứng dụng.

Các tệp G4MF có thể có các loại sau:
- `.g4tf` viết tắt cho "Good 4D model Text File". Nó bao gồm dữ liệu JSON ở định dạng văn bản thuần UTF-8, với các blob nhị phân được mã hóa Base64 bên trong chuỗi, hoặc lưu trữ dưới dạng tệp ngoài. Các tệp G4TF hợp lệ không chứa BOM hoặc ký tự xuống dòng dạng carriage return.
- `.g4b` viết tắt cho "Good 4D model Binary". Nó đóng gói dữ liệu nhị phân một cách dày đặc để tiết kiệm dung lượng, nhưng sẽ khó kiểm tra hơn trong trình soạn thảo văn bản.

Đọc đặc tả tại đây: [Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md).

## Khác biệt so với glTF™

G4MF được lấy cảm hứng từ glTF™, và có cấu trúc tổng thể tương tự, nhưng có nhiều điểm khác biệt.

Các điểm khác biệt chính:

- G4MF là định dạng đa chiều tập trung cho 4D, trong khi glTF™ là định dạng 3D. (rõ ràng, nhưng cần nêu ra để minh bạch)
- glTF™ được thiết kế để sẵn sàng cho GPU, với dữ liệu lưu trữ theo cách sẵn sàng nạp vào OpenGL™ hoặc Vulkan™. Vì các API đồ họa không hỗ trợ mô hình 4D, 5D, 6D, v.v., nên mục tiêu đó không phù hợp với G4MF. Thay vào đó, G4MF chủ yếu được thiết kế như một định dạng trao đổi dễ đọc cho con người.
- Đỉnh lưới của G4MF thường được lưu trữ theo cách loại bỏ trùng lặp và được tham chiếu bởi các cạnh và tế bào. glTF™ lưu từng tam giác với các đỉnh duy nhất, dễ nạp trực tiếp lên GPU hơn nhưng dễ gây nhầm lẫn về việc trùng lặp đỉnh. https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF chỉ cho phép một cảnh trên mỗi tệp với một node gốc, trong khi glTF™ cho phép nhiều cảnh và nhiều node gốc. https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- G4MF nhị phân sử dụng số nguyên không dấu 64-bit cho kích thước của tệp và khối `.g4b`, thay vì số nguyên không dấu 32-bit như `.glb`, cho phép tệp lớn hơn 4 GiB. https://github.com/KhronosGroup/glTF/issues/2114
- G4MF là định dạng hoàn toàn mới, trong khi glTF™ là định dạng tiêu chuẩn công nghiệp đã trưởng thành. Do đó, chúng tôi khuyến nghị sử dụng glTF™ cho mô hình 3D, không phải các tệp G4MF 3D.

Ngoài ra, còn nhiều khác biệt chi tiết giữa G4MF và glTF™:

- G4MF thêm một khóa số nguyên bắt buộc mới `"dimension"` vào `"asset"`, BẮT BUỘC phải được định nghĩa, nếu không tệp sẽ không hợp lệ. Điều này có nghĩa là các mô hình 4D PHẢI có `{ "asset": { "dimension": 4 } }` trong dữ liệu JSON.
- Header asset của G4MF chứa mảng `"extensionsUsed"` và `"extensionsRequired"`. Trong glTF™, chúng được định nghĩa ở đối tượng JSON cấp cao nhất.
- Biến đổi node trong G4MF sử dụng kết hợp `"position"` và `"basis"` hoặc `"rotor"`+`"scale"`, trong khi glTF™ sử dụng `"translation"`+`"rotation"`+`"scale"` hoặc ma trận 4x4 `"matrix"`. Cả hai định dạng chỉ cho phép biến đổi tuyến tính, nghĩa là thuộc tính `"matrix"` của glTF™ luôn có giá trị (0, 0, 0, 1) ở hàng cuối. Hàng cuối này hữu ích cho việc gửi dữ liệu lên GPU, nhưng không có ý nghĩa cho trao đổi, do đó không có trong G4MF.
- Thuộc tính `"scale"` của node trong G4MF không cho phép tỉ lệ âm, trong khi glTF™ cho phép. G4MF yêu cầu sử dụng `"basis"` để lật/đối xứng, nếu cần.
- Thuộc tính `"scale"` của node trong G4MF cho phép một giá trị duy nhất đại diện cho tỉ lệ đồng nhất, hữu ích để gọn nhẹ, đặc biệt với không gian nhiều chiều. Thuộc tính `"scale"` của glTF™ luôn là vector 3D.
- Các node của G4MF có boolean `"visible"`, cung cấp chức năng của extension glTF™ `KHR_node_visibility` trong đặc tả cơ bản. https://github.com/KhronosGroup/glTF/pull/2410
- Lưới G4MF có `"surfaces"`, tên gọi thân thiện hơn với người dùng. Lưới glTF™ có `"primitives"`, là thuật ngữ của OpenGL™. https://www.khronos.org/opengl/wiki/primitive
- Các bề mặt lưới của G4MF định nghĩa rõ ràng các đỉnh, cạnh và tế bào trên bề mặt. Primitives của lưới glTF™ định nghĩa các thành phần này trong `"attributes"` và `"mode"`.
- Các bề mặt lưới của G4MF có thể có boolean `"polytopeCells"`, cung cấp extension glTF™ `FB_ngon_encoding` trong đặc tả cơ bản. https://github.com/KhronosGroup/glTF/pull/1620
- Vật liệu G4MF có các kênh tổng quát hóa khái niệm thuộc tính vật liệu riêng biệt của glTF™. Ví dụ, màu cơ bản trong glTF™ sử dụng `"baseColorFactor"` và `"baseColorTexture"`, trong đó `"baseColorTexture"` có textureInfo định nghĩa chỉ số texture `"index"` và chỉ số `"texCoord"`. Vật liệu G4MF có các kênh như `"baseColor"` với các thuộc tính này được hợp nhất dưới nó.
- Đèn của G4MF nằm trong đặc tả cơ bản, trong khi đèn của glTF™ nằm trong extension `KHR_lights_punctual`.
- Đèn của G4MF yêu cầu tính đến tỉ lệ của node gắn vào, trong khi đèn của glTF™ yêu cầu bỏ qua tỉ lệ của node gắn vào.
- Accessor của G4MF có chuỗi `"primitiveType"` với các giá trị như `"uint8"`, `"int16"`, `"float32"`, v.v. Accessor của glTF™ có thuộc tính `"componentType"` với giá trị là các mã hóa cụ thể của OpenGL™ như `5121`, `5122`, `5126`, v.v. Cách tiếp cận của G4MF dễ đọc và mở rộng hơn cho con người, còn cách của glTF™ yêu cầu tra bảng mã để hiểu giá trị.
- Accessor của G4MF có số nguyên `"vectorSize"`, tổng quát hóa khái niệm `"SCALAR"`, `"VEC2"`, `"VEC3"`, và `"VEC4"` của accessor glTF™ sang bất kỳ kích thước nào.
- Accessor của G4MF không có `"count"` như accessor của glTF™, thay vào đó số lượng được xác định bởi kích thước của buffer view.
- Accessor của G4MF không có các thuộc tính `"normalized"`, `"max"`, hoặc `"min"`, vì chúng không hữu ích cho trao đổi.
- Accessor của G4MF là liên tục và không hỗ trợ sparse, trong khi accessor của glTF™ có thể sparse. Điều này hữu ích để tối ưu hóa hiệu suất cho GPU, nhưng không hữu ích cho trao đổi.
- Buffer view của G4MF không có thuộc tính `"byteStride"` hoặc `"target"`, nghĩa là G4MF không hỗ trợ dữ liệu xen kẽ. Điều này hữu ích trong glTF™ cho tối ưu hóa hiệu suất GPU, nhưng không hữu ích cho trao đổi.
- Các khối nhị phân của G4MF có chỉ thị định dạng nén 4 byte, cho phép các tệp nhị phân G4MF nén trong tương lai.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---