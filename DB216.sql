create table ThietBi(
	ID_ThietBi nvarchar(20) Primary Key,
	TenThietBi nvarchar(max),
	NhaSX nvarchar(max) ,
	LoaiThietBi nvarchar(max) ,
	GiaNhap float ,
	GiaBan float 
)
go
create table NhanVien(
	ID_NV nvarchar(20) Primary Key,
	TenNV nvarchar(max),
	GioiTinh bit,
	NgaySinh date,
	SDT nvarchar(max),
	DiaChi nvarchar(max),
	Anh_NV image
)
go
Create table TaiKhoan(
	ID_TK nvarchar(20) Primary key ,
	TenTK nvarchar(1000),
	MatKhau nvarchar(1000),
	ChucVu nvarchar(100),
	ID_NV nvarchar(20) foreign key (ID_NV) references NhanVien
	On update cascade
    On delete cascade
)
go
create table KhachHang(
	TenKH nvarchar(100),
	SDT nvarchar(20) primary key,
	DiaChi nvarchar(max)
)
go
create table KhuyenMai(
	ID_KhuyenMai nvarchar(20) primary key,
	TenKhuyenMai nvarchar(max),
	PhanTram float,
	NgayBatDau datetime,
	NgayKetThuc datetime
)
go
Create table HoaDon(
	ID_HoaDon nvarchar(20) Primary Key,
	ID_KhuyenMai nvarchar(20), 
	PhanTram float,
	TenKhachHang nvarchar(100),
	SDT nvarchar(20),
	NgayMuaHang datetime,
	TongTien float,
	ID_NV nvarchar(20),
	constraint fk_nhanvien foreign key(ID_NV) references NhanVien(ID_NV)
    on delete  set Null,
	constraint fk_khachhang foreign key(SDT) references KhachHang(SDT)
	on delete  set Null,
	constraint fk_khuyenmai foreign key(ID_KhuyenMai) references KhuyenMai(ID_KhuyenMai)
	on delete  set Null,
)
go
create table ChiTietHoaDon(
	ID_HoaDon nvarchar(20) ,
	ID_ThietBi nvarchar(20),
	SoLuong int ,
	GiaNhap float ,
	GiaTien float,
	constraint pk_chitiethoadon primary key(ID_HoaDon,ID_ThietBi),
	constraint fk_chitiethoadon foreign key(ID_HoaDon) references HoaDon(ID_HoaDon)
	on update cascade
	on delete cascade,
	constraint fk_thietbi foreign key(ID_ThietBi) references ThietBi(ID_ThietBi)
	on delete cascade 
)
go
create table KHO(
	ID_ThietBi nvarchar(20) primary key,
	TongSoLuongNhap int,
	SoLuongTonkho int,
	SoLuongBan int,
	constraint fk_kho foreign key(ID_ThietBi) references ThietBi(ID_ThietBi)	
    on delete cascade

)
go
create table NhapKho(
	STT int Primary key,
	ID_ThietBi nvarchar(20) foreign key (ID_ThietBi) references KHO
	on update cascade
	on delete cascade,
	SoLuongNhap int,
	GiaNhap float,
	NgayNhap datetime
)





