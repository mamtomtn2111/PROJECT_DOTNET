CREATE DATABASE BaiTapLon

USE BaiTapLon

CREATE TABLE QuanLyDuAn(
	MaDuAn			nvarchar(300)		primary key,
	TGBD			date				,
	TGKT			date				,
	MoTa			nvarchar(500)		
)
create proc GetAllQuanLyDuAn as select * from QuanLyDuAn
GetAllQuanLyDuAn
drop proc GetAllQuanLyDuAn

create proc GetAllSinhVienQuanLyDuAn as select * from QuanLyDuAn
GetAllQuanLyDuAn
--drop proc GetAllQuanLyDuAn

--select MSV, TenSV, Lop, SDT, DiaChi from SinhVien where MaDuAn = 'DUAN1'

CREATE TABLE SinhVien(
	MSV				nvarchar(250)		primary key,
	MaDuAn			nvarchar(300)		not null,
	TenSV			nvarchar(250)		,
	Lop				nvarchar(250)		,
	SDT				varchar(20)			,
	DiaChi			nvarchar(500)		,
)
select * from SinhVien
CREATE TABLE DuAn(
	MaDuAn			nvarchar(300)		primary key,
	TenDuAn			nvarchar(500)		not null,
	CoVan			nvarchar(500)		,
	ThongTinCoVan	nvarchar(500)		,
	SDTCoVan		varchar(50)			,
	NoiDungDuAn		nvarchar(500)		,
)


insert into QuanLyDuAn values('DUAN1','1/1/2020','1/2/2021',N'Dự án khoa học cấp quốc gia của ICTU'),
							('DUAN2','1/2/2019','3/3/2022',N'Dự án đầu tư của bất động sản TN')

insert into SinhVien values('DTC1','DUAN1',N'Nguyễn Hà Đông','CNTT K17A','01234561',N'Thái Nguyên'),
							('DTC2','DUAN1',N'Hà Ngọc Anh','CNTT K18A','032131135',N'Phú Bình'),
							('DTC3','DUAN2',N'Nguyễn Vũ Hải','CNTT K18 CLC','034402612',N'Thái Nguyên'),
							('DTC4','DUAN2',N'Vũ Quang Huy','CNTT K18 CLC','034402614',N'Thái Nguyên')

insert into DuAn values('DUAN1',N'Xử lý ảnh dành cho người khuyết tật',N'Nguyễn Anh Tuẫn',N'IELTS 6.5, hòa đồng, vui tính',N'012365413',N'Hỗ trợ người khiếm khuyết'),
						('DUAN2',N'Web mua đất',N'Hà Văn Ninh',N'Chuyên nghiệp, hòa đồng, vui tính','012366123',N'Hiệu quả cao cho buôn bán đất')

--update QuanLyDuAn set TGBD = '1/1/2000', TGKT = '2/2/2021', MoTa = N'Thay đổi nhỏ' where MaDuAn = 'DUAN3'

--select DuAn.TenDuAn, DuAn.CoVan, Duan.SDTCoVan, QuanLyDuAn.TGBD, QuanLyDuAn.TGKT, DuAn.ThongTinCoVan, DuAn.NoiDungDuAn from QuanLyDuAn, DuAn
--where DuAn.MaDuAn = QuanLyDuAn.MaDuAn and QuanLyDuAn.MaDuAn = 'DUAN1'