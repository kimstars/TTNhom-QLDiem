ALTER view [dbo].[TTDHV] as
select hv.MaHocVien, hv.HoTenHV, hp.TenHocPhan, ctpd.DiemCC, ctpd.DiemTX, ctpd.DiemThi, ctpd.DiemTK, gv.HoTenGV, hk.TenHocKy, hk.MaHocKy, gv.MaGiangVien, hp.MaHocPhan, lhp.MaLopHocPhan, ctpd.MaChiTietPhieuDiem, TenLopChuyenNganh from HocVien hv
join ChiTietPhieuDiem ctpd on ctpd.MaHocVien = hv.MaHocVien
join PhieuDiem pd on pd.MaPhieuDiem = ctpd.MaPhieuDiem 
join LopHocPhan lhp on lhp.MaLopHocPhan = pd.MaLopHocPhan
join HocPhan hp on hp.MaHocPhan = lhp.MaHocPhan
join HocKy hk on hk.MaHocKy = lhp.MaHocKy 
join GiangVien gv on lhp.MaGiangVien = gv.MaGiangVien
join LopChuyenNganh lcn on lcn.MaLopChuyenNganh = hv.MaLopChuyenNganh
GO


create view GV_TTHocVien_NhapDiem as
select hv.MaHocVien, hv.HoTenHV, hv.NgaySinh, MaGiangVien, lcn.MaLopChuyenNganh, lcn.TenLopChuyenNganh, lhp.MaHocKy, lhp.MaHocPhan, lhp.MaLopHocPhan
from HocVien hv 
join LopChuyenNganh lcn on lcn.MaLopChuyenNganh = hv.MaLopChuyenNganh
join LopHP_CN on LopHP_CN.MaLopChuyenNganh = lcn.MaLopChuyenNganh
join LopHocPhan  lhp on lhp.MaLopHocPhan = LopHP_CN.MaLopHocPhan
