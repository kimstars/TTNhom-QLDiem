create view TTDHV as
select hv.MaHocVien, hv.HoTenHV, hp.TenHocPhan, ctpd.DiemCC, ctpd.DiemTX, ctpd.DiemThi, ctpd.DiemTK, gv.HoTenGV, hk.TenHocKy, hk.MaHocKy, gv.MaGiangVien, hp.MaHocPhan from HocVien hv
join ChiTietPhieuDiem ctpd on ctpd.MaHocVien = hv.MaHocVien
join PhieuDiem pd on pd.MaPhieuDiem = ctpd.MaPhieuDiem 
join LopHocPhan lhp on lhp.MaLopHocPhan = pd.MaLopHocPhan
join HocPhan hp on hp.MaHocPhan = lhp.MaHocPhan
join HocKy hk on hk.MaHocKy = lhp.MaHocKy 
join GiangVien gv on lhp.MaGiangVien = gv.MaGiangVien
