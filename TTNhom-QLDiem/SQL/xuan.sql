CREATE view [dbo].[AD_QLHP_DSHocPhan] as 
select MaHocPhan,TenHocPhan,TenBoMon,DonViHocTrinh,SoTiet,SoTC,HinhThucThi,hp.MaBoMon from HocPhan hp
inner join BoMon bm on hp.MaBoMon = bm.MaBoMon