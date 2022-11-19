

UPDATE tblHoaDonBan set tblHoaDonBan.TongTien = 
(select ISNULL(SUM(tblChiTietHoaDonBan.ThanhTien),0) 
FROM tblChiTietHoaDonBan where tblChiTietHoaDonBan.SoHDB = tblHoaDonBan.SoHDB) 



select * from tblHoaDonBan
go
CREATE OR ALTER  TRIGGER Cau1 ON tblChiTietHoaDonBan
for insert, update, delete
AS BEGIN
	DECLARE @SoHDB1 NVARCHAR(20),@SoHDB2 NVARCHAR(20),@in int,@de int
	SELECT @SoHDB1 = SoHDB,@in =SoLuong from INSERTED
	SELECT @SoHDB2 = SoHDB,@de =SoLuong from DELETED
	UPDATE tblHangHoa SET SoLuong=isnull(SoLuong,0)-isnull(@in,0) WHERE MaHang=INSERTED.MaHang
	UPDATE tblHangHoa SET SoLuong=isnull(SoLuong,0)+isnull(@de,0) WHERE MaHang=DELETED.MaHang
	
END


Go
CREATE OR ALTER  TRIGGER Cau2 ON tblChiTietHoaDonNhap
for insert, update, delete
AS BEGIN
	DECLARE @SoHDN1 NVARCHAR(20),@SoHDN2 NVARCHAR(20),@in int,@de int
	SELECT @SoHDN1 = SoHDN,@in =SoLuong from INSERTED
	SELECT @SoHDN2 = SoHDN,@de =SoLuong from DELETED
	UPDATE tblHangHoa SET SoLuong=isnull(SoLuong,0)+isnull(@in,0) WHERE MaHang=INSERTED.MaHang
	UPDATE tblHangHoa SET SoLuong=isnull(SoLuong,0)-isnull(@de,0) WHERE MaHang=DELETED.MaHang
	
END