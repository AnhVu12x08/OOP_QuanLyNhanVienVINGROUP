## BÀI TẬP KẾ THỪA – ĐA HÌNH

Trong tổng công ty VINGROUP, việc quản lý nhân viên được thực hiện như sau:

### Thông tin nhân viên cần lưu giữ gồm:

- Mã số nhân viên (bắt buộc theo định dạng VG****, * là các ký số)
- Họ tên nhân viên
- Ngày sinh
- Giới tính (nam/nữ)
- Số tháng làm việc
- Hệ số lương của nhân viên (có thang hệ số 2.34, 2.67, 3.0, 3.33, 3.66, 3.99).
- Mức lương cơ bản áp dụng cho tất cả các nhân viên là 1.3 triệu đồng.

### Lớp Nhân viên chứa các thông tin trên và các phương thức cần thiết:

- Các phương thức khởi tạo.
- Các phương thức nhập/xuất thông tin.
- Phương thức tính thâm niên = số tháng làm việc / 12.
- Phương thức tính Phụ cấp thâm niên:
  + Nếu thâm niên <= 3 năm: 1 triệu đồng.
  + Nếu thâm niên <= 6 năm: 2 triệu đồng.
  + Nếu thâm niên <= 10 năm: 4 triệu đồng.
  + Từ năm thứ 11: 5 triệu đồng, và thêm 500 ngàn đồng cho mỗi năm tăng thâm niên.

### Loại nhân viên:

Trong công ty VINGROUP, nhân viên được chia thành 3 loại khác nhau trong quá trình vận hành sản xuất là:
- Nhân viên sản xuất
- Nhân viên kinh doanh
- Cán bộ điều hành

### Xếp loại và tính lương:

- Để nâng cao tính tích cực cho nhân viên, công ty tổ chức đánh giá xếp loại thi đua cho nhân viên hàng tháng (loại A, B, C, D).
- Xếp loại này quyết định tổng thu nhập của mỗi nhân viên như sau:
  + Nếu xếp loại 'A': nhân viên được hưởng 100% Lương + phụ cấp thâm niên.
  + Nếu xếp loại 'B': nhân viên được hưởng 75% Lương + phụ cấp thâm niên.
  + Nếu xếp loại 'C': nhân viên được hưởng 50% Lương + phụ cấp thâm niên.
  + Nếu xếp loại 'D': nhân viên được hưởng 0% Lương + phụ cấp thâm niên.


### Chi tiết theo từng loại nhân viên:

#### Nhân viên sản xuất:

- Nhân viên sản xuất được hưởng hệ số phụ cấp nặng nhọc (10%).
- Xếp loại thi đua dựa trên số ngày nghỉ trong một tháng:
  + Nếu số ngày nghỉ <= 1: xếp loại 'A'
  + Nếu số ngày nghỉ <= 3: xếp loại 'B'
  + Nếu số ngày nghỉ <= 5: xếp loại 'C'
  + Còn lại: xếp loại 'D'
- Lương của nhân viên sản xuất được tính theo công thức:
  Lương = hệ số lương * lương cơ bản * (1 + phụ cấp nặng nhọc)

#### Nhân viên kinh doanh:

- Nhân viên kinh doanh không phải làm việc theo ngày, mà dựa vào năng lực bán hàng.
- Có doanh số bán hàng tối thiểu và doanh số bán hàng theo tháng.
- Xếp loại thi đua dựa trên doanh số bán hàng:
  + Nếu hoàn thành doanh số tối thiểu: xếp loại 'B'
  + Nếu không hoàn thành: xếp loại 'C'
  + Nếu doanh số nhỏ hơn 50% doanh số tối thiểu: xếp loại 'D'
  + Nếu doanh số cao hơn 2.0 lần doanh số tối thiểu: xếp loại 'A'
- Lương của nhân viên kinh doanh được xác định như sau:
  Lương = hệ số lương * lương cơ bản + hoa hồng (15% của doanh thu vượt mức doanh số tối thiểu)

#### Cán bộ quản lý:

- Cán bộ quản lý quản lý toàn bộ hoạt động sản xuất của công ty.
- Có thông tin về chức vụ và hệ số chức vụ.
- Xếp loại thi đua luôn luôn là 'A'.
- Lương của cán bộ quản lý được xác định như sau:
  Lương = hệ số lương * lương cơ bản + phụ cấp chức vụ (xác định = hệ số phụ cấp chức vụ * 2 triệu đồng).

### Yêu cầu:

1. Xác định các lớp, vẽ sơ đồ phân cấp cấu trúc các lớp cho bài toán.
2. Xây dựng các lớp cùng các thuộc tính và phương thức theo yêu cầu.
3. Hãy tạo danh sách chứa nhân viên của công ty và thực hiện các yêu cầu sau:
  + a. Đọc dữ liệu từ file XML (cấu trúc file do SV tự thiết kế để phù hợp với các truy vấn của bài).
  + b. Xuất danh sách bảng lương của các nhân viên.
  + c. Xuất danh sách các nhân viên của công ty có hệ số lương là 3.99.
  + d. Xuất danh sách các nhân viên có lương cao nhất.
  + e. Đếm số nhân viên có phụ cấp thâm niên.
  + f. Xuất thông tin các nhân viên có thâm niên từ 10 năm trở lên.
