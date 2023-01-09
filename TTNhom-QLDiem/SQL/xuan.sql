CREATE view [dbo].[AD_QLHP_DSHocPhan] as 
select MaHocPhan,TenHocPhan,TenBoMon,DonViHocTrinh,SoTiet,SoTC,HinhThucThi,hp.MaBoMon from HocPhan hp
inner join BoMon bm on hp.MaBoMon = bm.MaBoMon

create view [dbo].[GV_LopChuyenNganh] as
select distinct LopChuyenNganh.MaLopChuyenNganh, TenLopChuyenNganh, BoMon.MaBoMon, TenBoMon, TenKhoa, TongHV,TenHocPhan,TenLopHocPhan,GiangVien.MaGiangVien,TenHocKy
from LopChuyenNganh
join BoMon on LopChuyenNganh.MaBoMon=BoMon.MaBoMon
join Khoa on BoMOn.MaKhoa=Khoa.MaKhoa
join LopHP_CN on LopHP_CN.MaLopChuyenNganh=LopChuyenNganh.MaLopChuyenNganh
join LopHocPhan on LopHP_CN.MaLopHocPhan=LopHocPhan.MaLopHocPhan
join HocPhan on LopHocPhan.MaHocPhan=HocPhan.MaHocPhan
join GiangVien on GiangVien.MaGiangVien=LopHocPhan.MaGiangVien
join HocKy on HocKy.MaHocKy=LopHocPhan.MaHocKy




CREATE view [dbo].[GV_DSLopChuyenNganh_HV]
as
select lcn.MaLopChuyenNganh , TenLopChuyenNganh, sum(MaHocVien) as TongHV, lcn.MaBoMon
from lopchuyennganh lcn 
inner join HocVien hv on lcn.MaLopChuyenNganh=hv.MaLopChuyenNganh
inner join bomon bm on lcn.MaBoMon=bm.MaBoMon
inner join GiangVien gv on bm.MaBoMon=gv.MaBoMon
group by lcn.MaLopChuyenNganh, tenlopchuyennganh, lcn.MaBoMon
GO

