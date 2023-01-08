
create view ADV_TraCuuDiemHV as
select distinct HocVien.MaHocVien, HoTenHV, NgaySinh, TenLopChuyenNganh, TenHocPhan, DiemCC,DiemTX,DiemThi,DiemTK, TenHocKy
from HocVien 
join LopChuyenNganh on HocVien.MaLopChuyenNganh=LopChuyenNganh.MaLopChuyenNganh
join ChiTietPhieuDiem on HocVien.MaHocVien=ChiTietPhieuDiem.MaHocVien
join PhieuDiem on ChiTietPhieuDiem.MaPhieuDiem=PhieuDiem.MaPhieuDiem
join LopHocPhan on PhieuDiem.MaLopHocPhan=LopHocPhan.MaLopHocPhan
join HocPhan on  LopHocPhan.MaHocPhan=HocPhan.MaHocPhan
join HocKy on LopHocPhan.MaHocKy=HocKy.MaHocKy
GO


CREATE TRIGGER tr_UpdateTongKetDiem
ON dbo.ChiTietPhieuDiem
AFTER INSERT, update
AS
BEGIN
    UPDATE dbo.ChiTietPhieuDiem
    SET ChiTietPhieuDiem.DiemTK = (ChiTietPhieuDiem.DiemCC + ChiTietPhieuDiem.DiemTX*3 + ChiTietPhieuDiem.DiemThi*6) / 10
    FROM inserted i
    WHERE i.MaHocVien = dbo.ChiTietPhieuDiem.MaHocVien;
END;

go 


create view AD_LopChuyenNganh as
select distinct LopChuyenNganh.MaLopChuyenNganh, TenLopChuyenNganh, BoMon.MaBoMon, TenBoMon, TenKhoa, 
(CASE WHEN MaLopTruong IS NULL THEN NULL ELSE HoTenHV END) AS HoTenHV, MaLopTruong
from LopChuyenNganh
join BoMon on LopChuyenNganh.MaBoMon=BoMon.MaBoMon
join Khoa on BoMOn.MaKhoa=Khoa.MaKhoa
, HocVien where MaLopTruong = MaHocVien or (MaLopTruong is NULL )




