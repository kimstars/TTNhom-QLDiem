create view ADV_TraCuuDiemHV as
select distinct HocVien.MaHocVien, HoTenHV, NgaySinh, TenLopChuyenNganh, TenHocPhan, DiemCC,DiemTX,DiemThi, TenHocKy
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


