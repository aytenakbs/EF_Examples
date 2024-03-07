--Select* from TblCategory
select * from TblProduct where ProductCategory=(select CategoryID from TblCategory where CategoryName='Mobilya')