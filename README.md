BÀI TẬP KẾ THỪA – ĐA HÌNH



Trong tổng công ty VINGROUP, công tác quản lý thực hiện như sau:

Thông tin nhân viên cần lưu giữ gồm:

	Mã số nhân viên, bắt buộc VG****, * là các ký số

	Họ tên nhân viên

	Ngày sinh

	Giới tính (nam/nữ)

	Số tháng làm việc

	Hệ số lương của nhân viên có thang hệ số (2.34, 2.67, 3.0, 3.33, 3.66, 3.99).

	Mức lương cơ bản áp dụng cho tất cả các nhân viên là 1.3 triệu.

Hãy xây dựng lớp Nhân viên chứa các thông tin trên và các phương thức cần thiết:

	Các phương thức khởi tạo.

	Các phương thức nhập/xuất thông tin.

	Phương thức tính thâm niên = số tháng làm việc/12;

	Phương thức tính Phụ cấp thâm niên

+	Nếu thâm niên <= 3 năm: 1 triệu đồng

+	Ngược lại nếu thâm niên <= 6 năm: 2 triệu

+	Ngược lại nếu thâm niên <= 10 năm: 4 triệu

+	Từ năm thứ 11: 5 triệu, và thêm 500 ngàn cho mỗi năm tăng thâm niên.

Trong công ty VINGROUP, nhân viên được chia làm 3 loại khác nhau trong quá trình vận hành sản xuất là nhân viên sản xuất, nhân viên kinh doanh và cán bộ điều hành.

	Để nâng cao tính tích cực cho nhân viên, công ty tổ chức đánh giá xếp loại thi đua cho nhân viên hàng tháng (loại A, B, C, D). Xếp loại này sẽ quyết định tổng thu nhập của mỗi nhân viên như sau:

+	Nếu xếp loại ‘A’: nhân viên được hưởng 100% Lương + phụ cấp thâm niên.

+	Nếu xếp loại ‘B’: nhân viên được hưởng 75% Lương + phụ cấp thâm niên.

+	Nếu xếp loại ‘C’: nhân viên được hưởng 50% Lương + phụ cấp thâm niên.

+	Nếu xếp loại ‘D’: nhân viên được hưởng 0% Lương + phụ cấp thâm niên

Do tính chất công việc nên mỗi nhân viên lại có những đặc điểm, cách xếp loại, cách tính lương và phụ cấp khác nhau như sau:

	Nhân viên sản xuất: do làm việc trong môi trường độc hại nên nhân viên sản xuất đều được hưởng một hệ số phụ cấp nặng nhọc. Hệ số này là chung cho tất cả các nhân viên sản xuất của công ty và đang được công ty qui định là 10%. Ngoài ra mỗi nhân viên sẽ có thông tin về số ngày nghỉ trong một tháng và xếp loại thi đua được tính như sau: Nếu số ngày nghỉ <=1 thì xếp loại
 
‘A’, số ngày nghỉ <=3 thì xếp loại ‘B’, số ngày nghỉ <=5 thì xếp loại ‘C’còn lại  là xếp loại ‘D’.

Lương của nhân viên sản xuất được tính theo công thức như sau:

Lương = hệ số lương * lương cơ bản * (1 + phụ cấp nặng nhọc)

	Nhân viên kinh doanh: Công ty không bắt buộc nhân viên kinh doanh phải làm việc theo ngày giống như nhân viên sản xuất mà chỉ quan tâm tới năng lực bán hàng của từng người. Mỗi nhân viên kinh doanh có một doanh số bán hàng tối thiểu khác nhau và một thông tin về doanh số bán hàng theo tháng. Nếu nhân viên hoàn thành doanh số tối thiểu thì xếp loại thi đua là ‘B’, nếu không hoàn thành thì xếp loại ‘C’. Nếu doanh số nhỏ hơn 50% doanh số tối thiểu thì xếp loại ‘D’. Ngược lại nếu nhân viên có danh số cao hơn 2.0 lần doanh số tối thiểu thì xếp loại ‘A’. Lương của nhân viên kinh doanh cũng được xác định như sau: Lương = hệ số lương * lương cơ bản + hoa hồng

trong đó hoa hồng là 15% của doanh thu vượt mức doanh thu tối thiểu.

	Cán bộ quản lý: Cán bộ quản lý có trách nhiệm quản lý toàn bộ hoạt động sản xuất của công ty. Cán bộ quản lý có thêm thông tin về chức vụ và hệ số chức vụ. Xếp loại thi đua của cán bộ quản lý luôn luôn là ‘A’ và lương của cán bộ quản lý được xác định như sau: Lương = hệ số lương * lương cơ bản + phụ cấp chức vụ. Trong đó phụ cấp chức vụ được xác định = hệ số phụ cấp chức vụ * 2 triệu.


Yêu cầu:

1/ Xác định các lớp, vẽ sơ đồ phân cấp cấu trúc các lớp cho bài toán 2/ Xây dựng các lớp cùng các thuộc tính và phương thức theo yêu cầu.
3/ Hãy tạo danh sách chứa nhân viên của công ty và thực hiện các yêu cầu sau:

a.	Đọc dữ liệu từ file XML (file này SV tự thiết kế cấu trúc chứa dữ liệu cho phù hợp các truy vấn của bài).

b.	Xuất danh sách bảng lương của các nhân viên.

c.	Xuất danh sách các nhân viên của công ty có hệ số lương là 3.99.

d.	Xuất danh sách các nhân viên có lương cao nhất.

e.	Đếm số nhân viên có phụ cấp thâm niên.

f.	Xuất thông tin các nhân viên có thâm niên từ 10 năm trở lên.
