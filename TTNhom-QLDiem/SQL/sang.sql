
create view ADV_TraCuuDiemHV as
select distinct HocVien.MaHocVien, HoTenHV, NgaySinh, TenLopChuyenNganh, TenHocPhan, DiemCC,DiemTX,DiemThi,DiemTK, TenHocKy
from HocVien 
join LopChuyenNganh on HocVien.MaLopChuyenNganh=LopChuyenNganh.MaLopChuyenNganh
join ChiTietPhieuDiem on HocVien.MaHocVien=ChiTietPhieuDiem.MaHocVien
join PhieuDiem on ChiTietPhieuDiem.MaPhieuDiem=PhieuDiem.MaPhieuDiem
join LopHocPhan on PhieuDiem.MaLopHocPhan=LopHocPhan.MaLopHocPhan
join HocPhan on  LopHocPhan.MaHocPhan=HocPhan.MaHocPhan
join HocKy on LopHocPhan.MaHocKy=HocKy.MaHocKy


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



alter view AD_LopChuyenNganh as
select distinct LopChuyenNganh.MaLopChuyenNganh, TenLopChuyenNganh, BoMon.MaBoMon, TenBoMon, TenKhoa,
(CASE WHEN MaLopTruong IS NULL THEN NULL ELSE HoTenHV END) AS HoTenHV, MaLopTruong
from LopChuyenNganh
join BoMon on LopChuyenNganh.MaBoMon=BoMon.MaBoMon
join Khoa on BoMOn.MaKhoa=Khoa.MaKhoa
, HocVien where MaLopTruong = MaHocVien or (MaLopTruong is NULL )


create view [dbo].[TTDHV] as
select hv.MaHocVien, hv.HoTenHV, hp.TenHocPhan, ctpd.DiemCC, ctpd.DiemTX, ctpd.DiemThi, ctpd.DiemTK, gv.HoTenGV, hk.TenHocKy, hk.MaHocKy, gv.MaGiangVien, hp.MaHocPhan from HocVien hv
join ChiTietPhieuDiem ctpd on ctpd.MaHocVien = hv.MaHocVien
join PhieuDiem pd on pd.MaPhieuDiem = ctpd.MaPhieuDiem 
join LopHocPhan lhp on lhp.MaLopHocPhan = pd.MaLopHocPhan
join HocPhan hp on hp.MaHocPhan = lhp.MaHocPhan
join HocKy hk on hk.MaHocKy = lhp.MaHocKy 
join GiangVien gv on lhp.MaGiangVien = gv.MaGiangVien



CREATE VIEW [dbo].[AD_QLLHP_DSHocPhan] AS 
SELECT MaHocPhan,TenHocPhan,TenBoMon,DonViHocTrinh,SoTiet,SoTC,HinhThucThi,hp.MaBoMon FROM HocPhan hp
INNER JOIN BoMon bm ON hp.MaBoMon = bm.MaBoMon



CREATE VIEW [dbo].[AD_QLLHP_DSLopHocPhan] AS
SELECT lhp.MaLopHocPhan, lhp.TenLopHocPhan, hk.TenHocKy,ph.TenPhongHoc,gv.HoTenGV,lhp.NgayThi,hk.MaHocKy,lhp.MaPhongHoc,gv.MaGiangVien,lhp.MaHocPhan, lhp.TongHV
FROM dbo.LopHocPhan lhp
INNER JOIN dbo.HocKy hk ON hk.MaHocKy = lhp.MaHocKy
INNER JOIN dbo.PhongHoc ph ON ph.MaPhongHoc = lhp.MaPhongHoc
INNER JOIN dbo.GiangVien gv ON gv.MaGiangVien = lhp.MaGiangVien


CREATE VIEW AD_QLLHP_SuaLopCN as
SELECT lcn.MaLopChuyenNganh, lcn.TenLopChuyenNganh, MaLopHocPhan, COUNT(hv.MaHocVien) 'SoHocVien' FROM dbo.LopHP_CN 
INNER JOIN dbo.LopChuyenNganh lcn ON lcn.MaLopChuyenNganh = LopHP_CN.MaLopChuyenNganh
JOIN dbo.HocVien hv ON hv.MaLopChuyenNganh = LopHP_CN.MaLopChuyenNganh
GROUP BY lcn.MaLopChuyenNganh, lcn.TenLopChuyenNganh, MaLopHocPhan



select* from AD_LopChuyenNganh