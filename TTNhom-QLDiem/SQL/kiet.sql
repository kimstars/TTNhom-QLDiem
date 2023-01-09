CREATE VIEW [dbo].[AD_QLLHP_DSHocPhan] AS 
SELECT MaHocPhan,TenHocPhan,TenBoMon,DonViHocTrinh,SoTiet,SoTC,HinhThucThi,hp.MaBoMon FROM HocPhan hp
INNER JOIN BoMon bm ON hp.MaBoMon = bm.MaBoMon


GO 
CREATE VIEW [dbo].[AD_QLLHP_DSLopHocPhan] AS
SELECT lhp.MaLopHocPhan, lhp.TenLopHocPhan, hk.TenHocKy,ph.TenPhongHoc,gv.HoTenGV,lhp.NgayThi,hk.MaHocKy,lhp.MaPhongHoc,gv.MaGiangVien,lhp.MaHocPhan, lhp.TongHV
FROM dbo.LopHocPhan lhp
INNER JOIN dbo.HocKy hk ON hk.MaHocKy = lhp.MaHocKy
INNER JOIN dbo.PhongHoc ph ON ph.MaPhongHoc = lhp.MaPhongHoc
INNER JOIN dbo.GiangVien gv ON gv.MaGiangVien = lhp.MaGiangVien

GO

CREATE VIEW AD_QLLHP_SuaLopCN as
SELECT lcn.MaLopChuyenNganh, lcn.TenLopChuyenNganh, MaLopHocPhan, COUNT(hv.MaHocVien) 'SoHocVien' FROM dbo.LopHP_CN 
INNER JOIN dbo.LopChuyenNganh lcn ON lcn.MaLopChuyenNganh = LopHP_CN.MaLopChuyenNganh
JOIN dbo.HocVien hv ON hv.MaLopChuyenNganh = LopHP_CN.MaLopChuyenNganh
GROUP BY lcn.MaLopChuyenNganh, lcn.TenLopChuyenNganh, MaLopHocPhan


